using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JC.Common
{
    public class FileHelper
    {
        /// <summary>
        /// convert file to utf-8
        /// </summary>
        /// <param name="FILE_NAME"></param>
        public static void ConvertToUTF8(string FILE_NAME)
        {
            var fileType = JC.Common.EncodingType.GetType(FILE_NAME);
            Encoding ft = fileType;
            string text = File.ReadAllText(FILE_NAME, ft);
            File.WriteAllText(FILE_NAME, text, new UTF8Encoding(false));
        }
    }
}
