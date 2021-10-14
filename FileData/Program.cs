using FileDataBusiness;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2 || args.Length > 2)
                {
                    Console.WriteLine("Please set correct number of arguments");
                }
                else
                {
                    IFileDataManager fileDataManager = new FileDataManager();
                    var fileInfo = fileDataManager.GetFileDetails(args[0], args[1]);
                    Console.WriteLine(!string.IsNullOrWhiteSpace(fileInfo) ? fileInfo : "Please set correct arguments to get FileInfo");
                }
                Console.Read();
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Exception Occured whilemprocessing the request {0}", ex);
            }
            
        }
    }
}
