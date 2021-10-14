using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDataBusiness
{
    public interface IFileDataManager
    {
        string GetFileDetails(string argsFirst, string argsSecond);
        
    }
}
