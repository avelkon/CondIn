using System;
using System.IO;

namespace CondIn
{
    class Program
    {
        static void Main(string[] args)
        {
            OK_Service.WS_ISIntegrationSoapClient service = new OK_Service.WS_ISIntegrationSoapClient();
            string op = "";
            string login = "global";
            string pass = "z61Q6BibuF";
            string data = "";
            string fileName = "OK.log";
            bool isHelp = false;
            for (int i = 0; i < args.Length; i++)
            {
                switch(args[i]) {
                    case "-h": isHelp = true; break;
                    case "-o": op = args[i + 1];break;
                    case "-l": login = args[i + 1]; break;
                    case "-p": pass = args[i + 1]; break;
                    case "-d": data = args[i + 1]; break;
                    case "-f": fileName = args[i + 1]; break;
                }
            }
            if (isHelp)
            {
                Console.WriteLine("\t-h\t\tShow help");
                Console.WriteLine("\t-o\t\tProcedure name");
                Console.WriteLine("\t-l\t\tService login");
                Console.WriteLine("\t-p\t\tService password");
                Console.WriteLine("\t-d\t\tData for called procedure");
                Console.WriteLine("\t-f\t\tLog file name");
            }
            else
            {
                OK_Service.ResultService result = service.SetAsync(login, pass, op, data);
                File.AppendAllText(fileName, DateTime.Now.ToString() + "\t" + result.Status + "\t" + result.Text + "\n");
            }
        }
    }
}
