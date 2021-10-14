using FileDataBusiness;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.UnitTest
{
    [TestFixture]
    public class FileDataTestCase
    {
        [TestCase]
        public void GetFileInfo()
        {
            IFileDataManager fileDataManager = new FileDataManager();
            var arguments = new string[] { "--v", "C:/ test.txt" }; 
            Assert.NotNull(fileDataManager.GetFileDetails(arguments[0], arguments[1]));
        }

        
    }
}
