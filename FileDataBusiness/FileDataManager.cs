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

        public string GetFileDetails(string[] fileInfo)
        {
            try
            {
                string argFirstParameter = fileInfo[0];

                string argsSecondParameter = fileInfo[1];

                if (versionArgumentTypes.Contains(argFirstParameter))
                {
                    return string.Format("File Version : {0}", GetFileVersion(argsSecondParameter));

                }
                if (sizeArgumentTypes.Contains(argFirstParameter))
                {
                    return string.Format("File Size : {0}", GetFileSize(argsSecondParameter));

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
