using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;
using System.Net;
using System.IO;

using Qiniu.IO;
using Qiniu.FileOp;
using Qiniu.Conf;
using Qiniu.Auth;
using Qiniu.Util;

using Newtonsoft.Json;

namespace CSharpWinform
{
    public class FusionCdn
    {
        public FusionCdn(Config cfg)
        {
            Qiniu.Conf.Config.ACCESS_KEY = cfg.ACCESS_KEY;
            Qiniu.Conf.Config.SECRET_KEY = cfg.SECRET_KEY;
        }
        /**
        * 刷新目录或者链接列表，注意目录必须以 / 结尾
        * @param urls 待刷新的链接列表
        * @param dirs 待刷新的目录列表
        *  <returns>返回日志记录</returns>
        */

        public string refresh(List<string> urls, List<string> dirs)
        {

            if ((urls == null || urls.Count == 0) && (dirs == null || dirs.Count == 0))
            {
                return "文件或目录为空";
            }

            QiniuAuthClient qac = new QiniuAuthClient();
            var client = (HttpWebRequest)WebRequest.Create("http://fusion.qiniuapi.com/refresh");

            client.Method = "POST";
            client.Host = "fusion.qiniuapi.com";
            client.ContentType = "application/json";

            using (var stm = client.GetRequestStream())
            {
                string json = "{\"urls\":" + JsonConvert.SerializeObject(urls) + ",\"dirs\":" + JsonConvert.SerializeObject(dirs) + "}";

                //JC.Common.LogHelper.Info(json);

                qac.SetAuth(client, stm);//设置Authorization

                StreamWriter streamWriter = new StreamWriter(stm);
                streamWriter.Write(json);

                streamWriter.Flush();
                streamWriter.Close();

                var httpResponse = (HttpWebResponse)client.GetResponse();
               
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    //JC.Common.LogHelper.Info(JsonConvert.SerializeObject(result));
                    return result;
                }
            }
        }
    }
}