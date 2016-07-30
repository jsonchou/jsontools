using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Qiniu.IO;
using Qiniu.Util;

using HtmlAgilityPack;

namespace CSharpWinform
{

    public partial class Form1 : Form
    {

        JObject obj = JC.Common.JsonHelper.GetJsonSiteObject();
        string jsonPath = Directory.GetCurrentDirectory() + ("\\config\\site.json");
        Config cfg = new Config();

        //转换文件
        public List<string> convertFiles = new List<string>();

        public Form1()
        {

            //"七牛云存储文件发布";

            InitializeComponent();

            if (obj == null)
            {
                JC.Common.LogHelper.Info("缺少配置文件");
                return;
            }

            logConfig();


        }


        //发布代码
        private void btnSavePost_Click(object sender, EventArgs e)
        {
            this.lblStatus.Text = "执行中请稍等...";
            lblStatus.Refresh();
            saveConfig();

            List<string> myres = new List<string>();

            //资源发布
            var mylog = new StringBuilder();
            try
            {
                obj = JC.Common.JsonHelper.GetJsonSiteObject();

                Upload upl = new Upload(cfg);

                myres = upl.upload();

                //JC.Common.LogHelper.Info(JsonConvert.SerializeObject(myres));

                for (int i = 0; i < myres.Count; i++)
                {
                    mylog.Append("发布资源：" + myres[i] + "\r\n");
                }

                this.lblStatus.Text = "发布成功";
            }
            catch (Exception err)
            {
                mylog.Append("发布资源：" + err.Message + "\r\n");
                this.lblStatus.Text = "发布失败";
                throw;
            }

            if (cbCDN.Checked)
            {
                List<string> urls = fixDomainPath(string.Join("\r\n", myres));

                mylog.Append(ClearCDN(urls, null));
            }

            txtLog.Text = mylog.ToString();

        }


        //清空CDN目录/文件
        private void btnSaveCDN_Click(object sender, EventArgs e)
        {
            this.lblCDNStatus.Text = "执行中请稍等...";
            lblCDNStatus.Refresh();
            var txtp = this.txtCDNPath.Text;
            if (string.IsNullOrEmpty(txtp))
            {
                return;
            }

            txtCDNPath.Text = String.Join("\r\n", fixCleanPath(txtp));

            var allPath = fixDomainPath(txtp);

            var exts = cfg.Exts;

            var urls = new List<string>();
            var dirs = new List<string>();

            for (int i = 0; i < allPath.Count; i++)
            {
                var item = allPath[i];
                if (exts.Any(c => item.Contains(c)))
                {
                    //文件
                    urls.Add(item);
                }
                else
                {
                    //目录
                    dirs.Add(item);
                }
            }

            //JC.Common.LogHelper.Info("urls:" + string.Join(",", urls));
            //JC.Common.LogHelper.Info("dirs:" + string.Join(",", dirs));

            //清空CDN
            var logs = ClearCDN(urls, dirs);
            txtCDNLogs.Text = logs.ToString();
            this.lblCDNStatus.Text = "清空成功";
        }

        //保存配置
        private void btnSaveSet_Click(object sender, EventArgs e)
        {
            saveConfig();
        }

        //载入配置
        private void logConfig()
        {
            //填充实体类
            cfg.PATH = obj["PATH"].ToString();
            cfg.ACCESS_KEY = obj["ACCESS_KEY"].ToString();
            cfg.SECRET_KEY = obj["SECRET_KEY"].ToString();
            cfg.Bucket_Name = obj["Bucket_Name"].ToString();
            cfg.Uptoken_Url = obj["Uptoken_Url"].ToString();
            cfg.Https = bool.Parse(obj["Https"].ToString());
            cfg.Domains = (List<string>)obj["Domains"].ToObject(typeof(List<string>));
            cfg.Exts = (List<string>)obj["Exts"].ToObject(typeof(List<string>));

            //填充表单
            this.txtLocalPath.Text = cfg.PATH;
            this.txtAK.Text = cfg.ACCESS_KEY;
            this.txtSK.Text = cfg.SECRET_KEY;
            this.txtBucketName.Text = cfg.Bucket_Name;
            this.txtUptokenUrl.Text = cfg.Uptoken_Url;
            this.cbHttps.Checked = cfg.Https;

            var sb = new StringBuilder();
            foreach (var item in cfg.Domains)
            {
                sb.Append(item + "\r\n");
            }
            this.txtDomains.Text = sb.ToString();

            var sbExts = new StringBuilder();
            foreach (var item in cfg.Exts)
            {
                sbExts.Append(item + "|");
            }
            this.txtExts.Text = sbExts.ToString();



        }

        //保存配置
        private void saveConfig()
        {
            //保存path
            cfg.PATH = this.txtLocalPath.Text;
            cfg.ACCESS_KEY = this.txtAK.Text;
            cfg.SECRET_KEY = this.txtSK.Text;
            cfg.Bucket_Name = this.txtBucketName.Text;
            cfg.Uptoken_Url = this.txtUptokenUrl.Text;
            cfg.Https = this.cbHttps.Checked ? true : false;

            var dms = this.txtDomains.Text;
            var dmslist = dms.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList<string>(); ;
            cfg.Domains = dmslist;

            var exs = this.txtExts.Text;
            var exslist = exs.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList<string>(); ;
            cfg.Exts = exslist;


            //保存配置
            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(cfg));
        }

        private List<string> fixCleanPath(string txt)
        {
            if (string.IsNullOrEmpty(txt))
            {
                return null;
            }

            string[] txtArr = txt.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> mylist = new List<string>();

            foreach (var item in txtArr)
            {
                var tag = item.IndexOf(".com");
                if (tag > -1)
                {
                    mylist.Add(item.Substring(tag + 4).ToLower().Replace("/_src/","/"));
                }
                else if (!item.StartsWith("/"))
                {
                    mylist.Add("/" + item.ToLower().Replace("/_src/", "/"));
                }
                else
                {
                    mylist.Add(item.ToLower().Replace("/_src/", "/"));
                }
            }


            return mylist.Distinct().ToList();
        }

        //clean txt
        private List<string> fixDomainPath(string txt)
        {

            var mylist = fixCleanPath(txt);

            List<string> domains = cfg.Domains.ToList<string>();

            List<string> myreal = new List<string>();
            //add prefix domain
            for (int i = 0; i < mylist.Count; i++)
            {
                var item = mylist[i];
                for (int j = 0; j < domains.Count; j++)
                {
                    //add https
                    myreal.Add(domains[j] + item);
                    if (cfg.Https)
                    {
                        myreal.Add(domains[j].Replace("http://", "https://") + item);
                    }
                    //443端口要加吗？
                }
            }

            return myreal.Distinct().ToList();

        }



        //清理CDN文件夹目录
        private StringBuilder ClearCDN(List<string> fullOnlinePathUrls, List<string> fullOnlinePathFolder)
        {
            var mylog = new StringBuilder();
            //清空CDN
            FusionCdn cdn = new FusionCdn(cfg);

            //刷新例子
            try
            {
                var cdnlog = cdn.refresh(fullOnlinePathUrls, fullOnlinePathFolder);
                mylog.Append("清空CDN：" + cdnlog + "\r\n");
            }
            catch (Exception err)
            {
                mylog.Append("清空CDN：" + err.Message + "\r\n");
            }

            return mylog;
        }

        //文件大写转小写
       private void btnChange_Click(object sender, EventArgs e)
        {
            lblConvertStatus.Text = "执行中请稍等...";
            lblConvertStatus.Refresh();

            ListConvertFiles(this.txtFileUppercase.Text);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            doc.OptionOutputOriginalCase = true;
            doc.OptionAutoCloseOnEnd = true;
            doc.OptionCheckSyntax = true;
            doc.OptionFixNestedTags = false;
            doc.OptionWriteEmptyNodes = true;

            //HtmlNode.ElementsFlags["option"] = HtmlElementFlag.Empty;
            //HtmlNode.ElementsFlags["br"] = HtmlElementFlag.Empty;
            //HtmlNode.ElementsFlags["input"] = HtmlElementFlag.Empty;
            //HtmlNode.ElementsFlags["hr"] = HtmlElementFlag.Empty;
            //HtmlNode.ElementsFlags["meta"] = HtmlElementFlag.Empty;
            //HtmlNode.ElementsFlags["title"] = HtmlElementFlag.Empty;

            HtmlNode.ElementsFlags.Remove("option");
            //HtmlNode.ElementsFlags.Remove("br");
            //HtmlNode.ElementsFlags.Remove("input");
            //HtmlNode.ElementsFlags.Remove("hr");
            //HtmlNode.ElementsFlags.Remove("meta");
            //HtmlNode.ElementsFlags.Remove("title");
            HtmlNode.ElementsFlags.Remove("form");

            var sb = new StringBuilder();

            var tags = new List<string> { "script[@src]", "img[@src]", "link[@href]" };

            for (int i = 0; i < convertFiles.Count; i++)
            {
                var item = convertFiles[i];
                 
                var itemType = JC.Common.EncodingType.GetType(item);

                doc.Load(item, itemType, false);
                //doc.DetectEncodingAndLoad(item,false);

                for (int j = 0; j < tags.Count; j++)
                {
                    var tag = tags[j];
                    var tagAttr = tag.Split('@')[1].Replace("]", "");

                    HtmlNode root = doc.DocumentNode;

                    if (root != null)
                    {
                        try
                        {

                            var hn2 = root.SelectNodes("//" + tag);//  : //script[@src]
                            var tagModifies = false;
                            if (hn2 != null)
                            {
                                foreach (HtmlNode link in hn2)
                                {
                                    if (link != null)
                                    {
                                        var myAttr = link.GetAttributeValue(tagAttr, "");
                                        if (!string.IsNullOrEmpty(myAttr))
                                        {
                                            HtmlAttribute att = link.Attributes[tagAttr];
                                            var aArr1 = myAttr.Trim().Split('<')[0];//?前缀url  src="/v1/<%=dddd%>/" src="/content/v1.jpg?v=<%=dddd%>" || src="<%=dddd%>"
                                            //JC.Common.LogHelper.Info(aArr1);
                                            var aArr = string.Empty;
                                            if (!string.IsNullOrEmpty(aArr1))
                                            {
                                                if (myAttr.ToLower() != myAttr)
                                                {
                                                    tagModifies = true;
                                                    aArr = aArr1.ToLower();
                                                    att.Value = myAttr.Replace(aArr1, aArr).Replace("imageview2", "imageView2");
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //JC.Common.LogHelper.Info("null link:" + tag);
                                    }
                                }
                            }
                            else
                            {
                                //JC.Common.LogHelper.Info("null hn.SelectNodes" + tag);
                            }

                            //fix seajs 
                            //seajs.use(['//r01.uzaicdn.com/scripts/m/core', '//r01.uzaicdn.com/scripts/m/menpiao'], function(core, menpiao) {
                            //    menpiao.init();
                            //});

                            var hn3 = root.SelectNodes("//script");
                            if (hn3 != null)
                            {
                                foreach (var sub in hn3)
                                {
                                    if (sub != null)
                                    {
                                        var myHtml = sub.InnerHtml;
                                        if (myHtml.IndexOf("seajs.use") > -1)
                                        {
                                            var prfTagIndex = myHtml.IndexOf("seajs.use(");
                                            var sufTagIndex = myHtml.IndexOf("]");
                                            
                                            if (prfTagIndex != -1 && sufTagIndex != -1)
                                            {
                                                var myTagHtml = myHtml.Substring(prfTagIndex, sufTagIndex - sufTagIndex);
                                                JC.Common.LogHelper.Info(item + " : " + myTagHtml);
                                                if (!string.IsNullOrEmpty(myTagHtml) && myTagHtml.ToLower() != myTagHtml)
                                                {
                                                    tagModifies = true;
                                                    var myTagHtmlNew = myTagHtml.ToLower();
                                                    var mytn = sub.InnerHtml.Replace(myTagHtml, myTagHtmlNew);
                                                    //htmlNode.ParentNode.ReplaceChild(HtmlTextNode.CreateNode(htmlNode.InnerText + "_translated"), htmlNode);
                                                    //sub.ParentNode.ReplaceChild(HtmlTextNode.CreateNode(sub.InnerHtml.Replace(myTag, myTagNew)), sub);
                                                    sub.ParentNode.ReplaceChild(HtmlNode.CreateNode("<script>" + mytn + "</script>"), sub);
                                                }
                                            }
                                        }

                                    }
                                }
                            }

                            if (tagModifies)
                            {
                                //StreamWriter sw = new StreamWriter(item, false, Encoding.UTF8);
                                //doc.Save(sw);

                                //sw.Flush();
                                //sw.Close();

                                doc.Save(item, itemType);
                            }

                             //FileStream fs = new FileStream(item, FileMode.Create);
                             ////获得字节数组
                             //byte[] data = System.Text.Encoding.UTF8.GetBytes(str);
                             ////开始写入
                             //fs.Write(data, 0, data.Length);
                             ////清空缓冲区、关闭流
                             //fs.Flush();
                             //fs.Close();

                        }
                        catch (Exception)
                        {
                            throw;
                        }

                    }
                    else
                    {
                        //JC.Common.LogHelper.Info("doc.DocumentNode" + "\r\n");
                    }
                }

                if (cbToUTF8.Checked)
                {
                    JC.Common.FileHelper.ConvertToUTF8(item);
                }

            }

            lblConvertStatus.Text = "执行成功";


        }
        /// <summary>
        /// 通过目录获取文件列表
        /// </summary>
        /// <param name="dir"></param>
        /// 
        public void ListConvertFiles(string baseDir)
        {

            DirectoryInfo mydir = new DirectoryInfo(baseDir);

            var txtFileTypes = this.txtCheckFiles.Text;
            var txtFileTypesList = txtFileTypes.Split('|').ToList();//文件类型列表

            var txtFolderTypes = this.txtIgnoreFolder.Text;
            var txtFolderTypesList = txtFolderTypes.Split('|').ToList();//忽视文件夹名称列表

            //append root files
            var rootFiles = mydir.GetFiles();
            for (int m = 0; m < rootFiles.Length; m++)
            {
                var fns = rootFiles[m].FullName;
                
                foreach (var item in txtFileTypesList)
                {
                    if (fns.ToLower().IndexOf(item.ToLower()) > -1)
                    {
                        convertFiles.Add(rootFiles[m].FullName);
                    }
                }
            }

            DirectoryInfo[] dirtyArr = mydir.GetDirectories();

            //子目录
            foreach (var item in txtFolderTypesList)
            {
                dirtyArr = dirtyArr.Where(c => !c.FullName.Contains(item)).ToArray();
            }

            foreach (var item in dirtyArr)
            {
                var fns = item.FullName;
                ListConvertFiles(fns);
            }

        }

        /// <summary>
        /// 保存到磁盘
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="saveFullPath">全路径</param>
        /// <returns></returns>
        public void SaveToDisk(byte[] bytes, string saveFullPath)
        {
            var fullPath = Path.GetDirectoryName(saveFullPath);
            //如果没有此文件夹，则新建
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }
            //创建文件，返回一个 FileStream，它提供对 path 中指定的文件的读/写访问。
            using (FileStream stream = File.Create(saveFullPath))
            {
                //将字节数组写入流
                stream.Write(bytes, 0, bytes.Length);
                stream.Close();
            }
        }


    }

    public class Config
    {
        public string PATH { get; set; }
        public string ACCESS_KEY { get; set; }
        public string SECRET_KEY { get; set; }
        public string Bucket_Name { get; set; }
        public string Uptoken_Url { get; set; }
        public bool Https { get; set; }
        public List<string> Exts { get; set; }
        public List<string> Domains { get; set; }
    }

}
