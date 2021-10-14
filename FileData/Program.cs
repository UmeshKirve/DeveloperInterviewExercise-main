using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Insuffiecent arguments");
            }
            else if (args.Length == 2)
            {
                string argFirstParameter = args[0];
                if (argFirstParameter == "-v" || argFirstParameter == "--v" || argFirstParameter == "/v" || argFirstParameter == "--version")
                {
                    string argsSecondParameter = args[1];
                    FileDetails fileDetailsObj = new FileDetails();
                    Console.WriteLine("Version : {0}", fileDetailsObj.Version(argsSecondParameter));
                    Console.Read();
                }
                if (argFirstParameter == "-s" || argFirstParameter == "--s" || argFirstParameter == "/s" || argFirstParameter == "--size")
                {
                    string argsSecondParameter = args[1];
                    FileDetails fileDetailsObj = new FileDetails();
                    Console.WriteLine("File Size : {0}", fileDetailsObj.Size(argsSecondParameter));
                    Console.Read();
                } 
            }
        }
    }
}
