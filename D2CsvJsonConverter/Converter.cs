//using D2CsvJsonConverter.Models;
using Newtonsoft.Json;
using System.Text;
using System.Globalization;
using CsvHelper;
using System.Text.RegularExpressions;
using D2CsvJsonConverter.Models;
using System.Reflection;
using CsvHelper.Configuration;
using System.Diagnostics;

namespace D2CsvJsonConverter
{
    internal class Converter
    {
        static bool isCsvTarget = false;
        static string folderPath = "";
        //Delimeter used in txt files
        const string DELIMITER = "\t";
        //Path to folder where model files will be dumped
        const string MODEL_FOLDER = "C:\\Users\\madin\\Documents\\CSharpProjects\\CsvJsonModel";
        //Set to recreate all model files, can be used to create models for new or updated formats
        const bool SHOULD_WRITE_MODEL_FILES = false;
        //AiParms is not a tsv and TreasureClass is never used in LOD (and also not a proper tsv)
        static string[] excludedFiles = { "AiParms.txt", "TreasureClass.txt" };

        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Missing arguments: <target(0 = csv, 1 = json)> <txt folder path>");
                Console.ReadLine();
                Environment.Exit(1);
            }
            if (args[0] == "0")
            {
                isCsvTarget = true;
            }
            folderPath = args[1];
            if (isCsvTarget)
            {
                Console.WriteLine("Converting files in {0} to Csv", folderPath);
            } 
            else
            {
                Console.WriteLine("Converting files in {0} to Json", folderPath);
            }
            Stopwatch watch = new();
            watch.Start();
            ConvertFolderToTarget(folderPath);
            watch.Stop();
            Console.WriteLine("Done in {0}ms", watch.ElapsedMilliseconds);
            //Console.ReadLine();
        }

        /// <summary>
        /// Converts all files in input folder into target type (json->txt(tsv) txt->json)
        /// </summary>
        /// <param name="folderPath">Path to folder containing files to be converted</param>
        static void ConvertFolderToTarget(string folderPath)
        {
            try
            {
                string[] files = Directory.GetFiles(folderPath);
                foreach (string file in files)
                {
                    if (excludedFiles.Contains(Path.GetFileName(file)))
                    {
                        continue;
                    }
                    //Used for generating the models of each txt
                    if (SHOULD_WRITE_MODEL_FILES)
                    {
                        WriteModelFile(file);
                    }
                    if (isCsvTarget)
                    {
                        if (Path.GetExtension(file) != ".json")
                        {
                            continue;
                        }
                        ConvertJsonToCsv(file);
                    }
                    else
                    {
                        if (Path.GetExtension(file) != ".txt")
                        {
                            continue;
                        }
                        ConvertCsvToJson(file);
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Writes a model file for a given tsv so it can be reversed
        /// </summary>
        /// <param name="filePath">Path to tsv file</param>
        static void WriteModelFile(string filePath)
        {
            try
            {
                StringBuilder sb = new();
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                sb.AppendLine("using System;");
                sb.AppendLine("using System.Collections.Generic;");
                sb.AppendLine("using Newtonsoft.Json;");
                sb.AppendLine("using CsvHelper.Configuration.Attributes;");
                sb.AppendLine("");
                sb.AppendLine("namespace D2CsvJsonConverter.Models");
                sb.AppendLine("{");
                sb.AppendLine("    [JsonObject(MemberSerialization.OptIn)]");
                sb.AppendLine("    internal class " + fileName + "Model");
                sb.AppendLine("    {");
                string line = File.ReadLines(filePath).First();
                string[] header = line.Split(DELIMITER);
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                Dictionary<string, int> colNames = new();
                string nameNotBlank = "";
                string nameFormatted = "";
                foreach (string col in header)
                {
                    nameNotBlank = col;
                    if (string.IsNullOrWhiteSpace(col))
                    {
                        nameNotBlank = "Unknown";
                    }
                    nameFormatted = textInfo.ToTitleCase(nameNotBlank);
                    if (Regex.IsMatch(nameFormatted, @"^\d"))
                    {
                        nameFormatted = "_" + nameFormatted;
                    }
                    nameFormatted = Regex.Replace(nameFormatted, @"[^0-9a-zA-Z_]", string.Empty);
                    if (!colNames.ContainsKey(col))
                    {
                        colNames.Add(col, 0);
                    } 
                    else
                    {
                        colNames[col]++;
                    }
                    sb.AppendLine("        [Name(\"" + col + "\"), NameIndex(" + colNames[col] + "), JsonProperty]");
                    if (colNames[col] > 0)
                    {
                        nameFormatted += colNames[col];
                    }
                    sb.AppendLine("        public string " + nameFormatted + " { get; set; } = \"\";");
                    sb.AppendLine("        ");
                }
                sb.AppendLine("    }");
                sb.AppendLine("}");
                File.WriteAllText(MODEL_FOLDER + "\\" + fileName + "Model.cs", sb.ToString());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Converts a csv/tsv to a valid json file
        /// </summary>
        /// <param name="filePath">Path to csv/tsv file</param>
        static void ConvertCsvToJson(string filePath)
        {
            //Reflection required for matching all the files to their model
            string typeStr = "D2CsvJsonConverter.Models." + Path.GetFileNameWithoutExtension(filePath) + "Model";
            Type type = Type.GetType(typeStr);
            MethodInfo? method = typeof(Converter).GetMethod(nameof(ReadCsv), BindingFlags.Static | BindingFlags.Public, new[] { typeof(string) });
            var csv = method.MakeGenericMethod(type).Invoke(null, new object[] { filePath });
            string jsonPath = Path.Combine(Path.GetDirectoryName(filePath), Path.GetFileNameWithoutExtension(filePath) + ".json");
            JsonSerializer serializer = new()
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter sw = new StreamWriter(jsonPath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, csv);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        static void ConvertJsonToCsv(string filePath)
        {
            //Reflection required for matching all the files to their model
            string typeStr = "D2CsvJsonConverter.Models." + Path.GetFileNameWithoutExtension(filePath) + "Model";
            Type type = Type.GetType(typeStr);
            Type listType = typeof(List<>);
            Type constructedList = listType.MakeGenericType(type);
            Type test = typeof(List<ArenaModel>);
            JsonSerializer serializer = new()
            {
                Formatting = Formatting.Indented
            };
            using (StreamReader sr = new StreamReader(filePath))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                var json = serializer.Deserialize(reader, constructedList);
                MethodInfo? method = typeof(Converter).GetMethod(nameof(WriteCsv), BindingFlags.Static | BindingFlags.Public);
                string csvPath = Path.Combine(Path.GetDirectoryName(filePath), Path.GetFileNameWithoutExtension(filePath) + ".txt");
                method.MakeGenericMethod(type).Invoke(null, new object[] { json, csvPath });
            }
        }

        /// <summary>
        /// Uses CsvHelper to read a csv into the given model type
        /// </summary>
        /// <typeparam name="T">Type matching the model file for the csv</typeparam>
        /// <param name="filePath">Path to csv file</param>
        /// <returns>List of data from csv in model format</returns>
        public static List<T> ReadCsv<T>(string filePath)
        {
            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = DELIMITER,
                    HasHeaderRecord = true,
                    BadDataFound = null,
                    Mode = CsvMode.NoEscape
                };
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, config))
                {
                    return csv.GetRecords<T>().ToList();
                }
                
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }
            return null;
        }

        /// <summary>
        /// Writes a csv file from a list of model entries
        /// </summary>
        /// <typeparam name="T">Type matching the model file for the csv</typeparam>
        /// <param name="input">List of model entries to write</param>
        /// <param name="filePath">Path to csv file to write to</param>
        public static void WriteCsv<T>(List<T> input, string filePath)
        {
            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = DELIMITER,
                    HasHeaderRecord = true,
                    Mode = CsvMode.NoEscape
                };
                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(input);
                }

            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }
        }
    }
}