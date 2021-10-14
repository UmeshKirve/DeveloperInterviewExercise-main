using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileDataBusiness
{
    public class FileDataManager : IFileDataManager
    {
        public static readonly List<String> versionArgumentTypes = new List<string>(new List<String> { "-v", "--v", "/v", "--version" });

        public static readonly List<String> sizeArgumentTypes = new List<string>(new List<String> { "-s", "--s", "/s", "--size" });

        public string GetFileDetails(string argsFirst, string argsSecond)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(argsFirst) || string.IsNullOrWhiteSpace(argsSecond))
                {
                    return null;
                }

                if (versionArgumentTypes.Contains(argsFirst))
                {
                    return string.Format("File Version : {0}", GetFileVersion(argsSecond));
                }
                if (sizeArgumentTypes.Contains(argsFirst))
                {
                    return string.Format("File Size : {0}", GetFileSize(argsSecond));
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }

        private int GetFileSize(string filePath)
        {
            FileDetails fileDetailsObj = new FileDetails();
            return fileDetailsObj.Size(filePath);
        }

        private string GetFileVersion(string filePath)
        {
            FileDetails fileDetailsObj = new FileDetails();
            return  fileDetailsObj.Version(filePath);
        }
    }
}
