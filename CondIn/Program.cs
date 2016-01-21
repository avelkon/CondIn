using System;
using System.IO;

namespace CondIn
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.ServicePointManager.Expect100Continue = false;
            OK_Service.WS_ISIntegrationSoapClient service = new OK_Service.WS_ISIntegrationSoapClient();
            string op = "";
            string login = "global";
            string pass = "z61Q6BibuF";
            string data = "";
            string logFileName = "OK.log";
            string destFileName = "";
            string sourceFileName = "";
            byte[] sourceFileData;
            int serv_proc = 0;
            bool isHelp = false, isDataKey = false;
            for (int i = 0; i < args.Length; i++)
            {
                if (isHelp) break;
                if (isDataKey)
                {
                    data += args[i]+" ";
                }
                switch(args[i].ToLower()) {
                    case "set": serv_proc = 1; break;
                    case "-d": isDataKey = true; break;
                    case "-o": op = args[i + 1];break;
                    case "upload": serv_proc = 2; break;
                    case "uploadfile": serv_proc = 2; break;
                    case "-s": sourceFileName = args[i + 1]; break;
                    case "-f": destFileName = args[i + 1]; break;
                    case "-l": login = args[i + 1]; break;
                    case "-p": pass = args[i + 1]; break;
                    case "-h": isHelp = true; break;
                    case "--log": logFileName = args[i + 1]; break;
                }
            }
            data = data.Trim();
            if (isHelp)
            {
                Console.WriteLine("\t-h\t\tShow help");
                Console.WriteLine("\t-l\t\tService login");
                Console.WriteLine("\t-p\t\tService password");
                Console.WriteLine("\t--log\t\tLog file name");
                Console.WriteLine("\tKeys for \"Set\" procedure");
                Console.WriteLine("\t-o\t\tProcedure name and args");
                Console.WriteLine("\t-d\t\tData for procedure");
                Console.WriteLine("\tKeys for \"UploadFile\" procedure");
                Console.WriteLine("\t-s\t\tPath to source file");
                Console.WriteLine("\t-f\t\tFile name");
            }
            else
            {
                try
                {
                    OK_Service.ResultService result = null;
                    if (serv_proc == 0)
                    {
                        //op = "DMT_Set_StockEx \"КО01283-03750\",1,816707759";
                        //result = service.Set(login, pass, op);
                    }
                    if (serv_proc == 1)
                    {
                        result = service.SetAsync(login, pass, op, data);
                    }
                    if (serv_proc == 2)
                    {
                        sourceFileData = File.ReadAllBytes(sourceFileName);
                        result = service.UploadFile(login, pass, sourceFileData, destFileName);
                    }
                    File.AppendAllText(logFileName, "[RESPONSE]\t" + DateTime.Now.ToString() + "\t" + result.Text + "\t" + result.Data + "\n");
                }
                catch (Exception ex)
                {
                    File.AppendAllText(logFileName, "[ERROR]\t" + DateTime.Now.ToString() + "\t" + ex.Message+"\n");
                }
            }
        }
    }
}
