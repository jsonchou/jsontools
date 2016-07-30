using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Qiniu.Auth;
using Qiniu.IO;
using Qiniu.IO.Resumable;
using Qiniu.RS;

namespace CSharpWinform
{
    public class Upload
    {

        List<string> myfiles = new List<string>();
        string path = string.Empty;
        List<string> res = new List<string>();

        Config cfg = new Config();

        public Upload(Config mycfg)
        {
            cfg = mycfg;
            //设置账号的AK和SK
            Qiniu.Conf.Config.ACCESS_KEY = cfg.ACCESS_KEY;
            Qiniu.Conf.Config.SECRET_KEY = cfg.SECRET_KEY;
        }

        public List<string> upload()
        {

            path = cfg.PATH;
           
            var bucket = cfg.Bucket_Name; //设置上传的空间
            var uptoken = cfg.Uptoken_Url;

            IOClient target = new IOClient();
            PutExtra extra = new PutExtra();

            //列出所有path文件夹文件
            ListFiles(path);

            //去重
            myfiles = myfiles.Distinct().ToList<string>();

            foreach (var item in myfiles)
            {

                //Replace(@"\", @"/").Replace(@"/_src/", @"/")

                //JC.Common.LogHelper.Info(item);

                //设置上传的文件的key值 文件名（content/v1/scripts/a.js）//日了狗，路径首字母不能包含/

                //JC.Common.LogHelper.Info("item:" + item);
                //JC.Common.LogHelper.Info("path:" + path);

                string key = item.Replace(path.ToLower() + @"\", @"").Replace(@"\", @"/");

                //上传文件的路径 本地文件路径（D:\前端事务\发布\content\_test\x.txt）
                string filepath = item;

                //JC.Common.LogHelper.Info(key);
                //JC.Common.LogHelper.Info(filepath);

                //覆盖上传,<bucket>:<key>，表示只允许用户上传指定key的文件。在这种格式下文件默认允许“修改”，已存在同名资源则会被本次覆盖。
                PutPolicy put = new PutPolicy(bucket + ":" + key, 3600);

                //设置callbackUrl以及callbackBody,七牛将文件名和文件大小回调给业务服务器
                //put.CallBackUrl = "http://your.domain.com/callback";
                //put.CallBackBody = "filename=$(fname)&filesize=$(fsize)";

                //调用Token()方法生成上传的Token
                string upToken = put.Token();

                //JC.Common.LogHelper.Info("豆豆逗逼" + upToken + "---" + key + "---" + filepath + "---" + extra);

                //调用PutFile()方法上传
                PutRet ret = target.PutFile(upToken, key, filepath, extra);

                res.Add(key);

                //JC.Common.LogHelper.Info(JsonConvert.SerializeObject(ret.ToString()));

                //打印出相应的信息
                //Console.WriteLine(ret.Response.ToString());
                //Console.WriteLine(ret.key);
            }

            return res;
           
        }

        /// <summary>
        /// 通过目录获取文件列表
        /// </summary>
        /// <param name="dir"></param>
        public void ListFiles(string baseDir)
        {

            DirectoryInfo mydir = new DirectoryInfo(baseDir);

            if (baseDir == path)
            {
                //append root files
                var rootFiles = mydir.GetFiles();
                for (int m = 0; m < rootFiles.Length; m++)
                {
                    myfiles.Add(rootFiles[m].FullName.Replace(@"\_src\", @"\").ToLower());
                }
            }

            DirectoryInfo[] dirArr = mydir.GetDirectories();

            //子目录
            for (int i = 0; i < dirArr.Length; i++)
            {
                var item = dirArr[i].FullName;
                FileInfo[] myinfo = dirArr[i].GetFiles();
                for (int j = 0; j < myinfo.Length; j++)
                {
                    myfiles.Add(myinfo[j].FullName.Replace(@"\_src\", @"\").ToLower());
                }
                
                ListFiles(item);
            }
        }
    }
}
