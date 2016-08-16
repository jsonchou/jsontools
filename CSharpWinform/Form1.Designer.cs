namespace CSharpWinform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSavePost = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.cbCDN = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalPath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLogs = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtCDNLogs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCDNStatus = new System.Windows.Forms.Label();
            this.txtCDNPath = new System.Windows.Forms.TextBox();
            this.btnSaveCDN = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCheckFiles = new System.Windows.Forms.TextBox();
            this.cbToUTF8 = new System.Windows.Forms.CheckBox();
            this.lblConvertStatus = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFileUppercase = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblLowserStatus = new System.Windows.Forms.Label();
            this.txtConvertTolowerCase = new System.Windows.Forms.Button();
            this.txtUpperCasePath = new System.Windows.Forms.TextBox();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtIgnoreFolder = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblExts = new System.Windows.Forms.Label();
            this.txtExts = new System.Windows.Forms.TextBox();
            this.cbHttps = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDomains = new System.Windows.Forms.TextBox();
            this.btnSaveSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSK = new System.Windows.Forms.TextBox();
            this.txtUptokenUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBucketName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSavePost
            // 
            this.btnSavePost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSavePost.Location = new System.Drawing.Point(112, 312);
            this.btnSavePost.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePost.Name = "btnSavePost";
            this.btnSavePost.Size = new System.Drawing.Size(167, 48);
            this.btnSavePost.TabIndex = 0;
            this.btnSavePost.Text = "发布";
            this.btnSavePost.UseVisualStyleBackColor = true;
            this.btnSavePost.Click += new System.EventHandler(this.btnSavePost_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(287, 329);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(31, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "...";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(112, 85);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(520, 165);
            this.txtLog.TabIndex = 5;
            this.txtLog.Text = "";
            // 
            // cbCDN
            // 
            this.cbCDN.AutoSize = true;
            this.cbCDN.Checked = true;
            this.cbCDN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCDN.Location = new System.Drawing.Point(112, 261);
            this.cbCDN.Margin = new System.Windows.Forms.Padding(4);
            this.cbCDN.Name = "cbCDN";
            this.cbCDN.Size = new System.Drawing.Size(113, 19);
            this.cbCDN.TabIndex = 6;
            this.cbCDN.Text = "清空CDN缓存";
            this.cbCDN.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 651);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtLocalPath);
            this.tabPage1.Controls.Add(this.txtLog);
            this.tabPage1.Controls.Add(this.cbCDN);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.btnSavePost);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(670, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "推送静态资源";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 422);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(420, 30);
            this.label12.TabIndex = 14;
            this.label12.Text = "1、状态码400037：表示文件已存在队列中，请稍等！\r\n2、本地路径里的文件存放路径，与服务器（七牛云）保持一致";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 388);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "提示：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "日志记录：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "本地路径：";
            // 
            // txtLocalPath
            // 
            this.txtLocalPath.Location = new System.Drawing.Point(112, 45);
            this.txtLocalPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalPath.Name = "txtLocalPath";
            this.txtLocalPath.Size = new System.Drawing.Size(520, 25);
            this.txtLocalPath.TabIndex = 11;
            this.txtLocalPath.Text = "D:\\前端事务\\发布";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lblLogs);
            this.tabPage2.Controls.Add(this.lblFilePath);
            this.tabPage2.Controls.Add(this.txtCDNLogs);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lblCDNStatus);
            this.tabPage2.Controls.Add(this.txtCDNPath);
            this.tabPage2.Controls.Add(this.btnSaveCDN);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(670, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "清空CDN文件/目录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 380);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 75);
            this.label7.TabIndex = 10;
            this.label7.Text = "http://r01.uzaicdn.com/content/_test/\r\nhttp://r01.uzaicdn.com/content/v1/a.jpg\r\nh" +
    "ttp://r01.uzaicdn.com/content/v1/\r\n/content/v1/a.jpg\r\n/content/v1/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 462);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(455, 75);
            this.label6.TabIndex = 9;
            this.label6.Text = "1. 每天文件刷新限额100个，文件预取限额100个，目录限额10次；\r\n2. 每次提交文件刷新最多20个，文件预取最多20个；\r\n3. 输入时，多个 URL 请" +
    "用回车换行分隔，每个 URL 应当\r\n以 http:// 或 https:// 开头，\r\n例如 http://www.example.com/index.htm" +
    "l。";
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Location = new System.Drawing.Point(16, 219);
            this.lblLogs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(82, 15);
            this.lblLogs.TabIndex = 8;
            this.lblLogs.Text = "日志记录：";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(8, 52);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(90, 15);
            this.lblFilePath.TabIndex = 7;
            this.lblFilePath.Text = "目录/文件：";
            // 
            // txtCDNLogs
            // 
            this.txtCDNLogs.Location = new System.Drawing.Point(108, 215);
            this.txtCDNLogs.Margin = new System.Windows.Forms.Padding(4);
            this.txtCDNLogs.Multiline = true;
            this.txtCDNLogs.Name = "txtCDNLogs";
            this.txtCDNLogs.ReadOnly = true;
            this.txtCDNLogs.Size = new System.Drawing.Size(525, 85);
            this.txtCDNLogs.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 380);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "示例：";
            // 
            // lblCDNStatus
            // 
            this.lblCDNStatus.AutoSize = true;
            this.lblCDNStatus.Location = new System.Drawing.Point(285, 332);
            this.lblCDNStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCDNStatus.Name = "lblCDNStatus";
            this.lblCDNStatus.Size = new System.Drawing.Size(31, 15);
            this.lblCDNStatus.TabIndex = 3;
            this.lblCDNStatus.Text = "...";
            // 
            // txtCDNPath
            // 
            this.txtCDNPath.Location = new System.Drawing.Point(108, 48);
            this.txtCDNPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtCDNPath.Multiline = true;
            this.txtCDNPath.Name = "txtCDNPath";
            this.txtCDNPath.Size = new System.Drawing.Size(525, 154);
            this.txtCDNPath.TabIndex = 1;
            // 
            // btnSaveCDN
            // 
            this.btnSaveCDN.Location = new System.Drawing.Point(108, 316);
            this.btnSaveCDN.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCDN.Name = "btnSaveCDN";
            this.btnSaveCDN.Size = new System.Drawing.Size(167, 48);
            this.btnSaveCDN.TabIndex = 0;
            this.btnSaveCDN.Text = "清空CDN文件/目录";
            this.btnSaveCDN.UseVisualStyleBackColor = true;
            this.btnSaveCDN.Click += new System.EventHandler(this.btnSaveCDN_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.txtCheckFiles);
            this.tabPage4.Controls.Add(this.cbToUTF8);
            this.tabPage4.Controls.Add(this.lblConvertStatus);
            this.tabPage4.Controls.Add(this.btnChange);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.txtFileUppercase);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(670, 622);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "文件资源路径转小写";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 99);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "文件类型：";
            // 
            // txtCheckFiles
            // 
            this.txtCheckFiles.Location = new System.Drawing.Point(113, 95);
            this.txtCheckFiles.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckFiles.Name = "txtCheckFiles";
            this.txtCheckFiles.Size = new System.Drawing.Size(520, 25);
            this.txtCheckFiles.TabIndex = 17;
            this.txtCheckFiles.Text = ".master|.ascx|.aspx|.html|.js|.css";
            // 
            // cbToUTF8
            // 
            this.cbToUTF8.AutoSize = true;
            this.cbToUTF8.Checked = true;
            this.cbToUTF8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbToUTF8.Location = new System.Drawing.Point(113, 150);
            this.cbToUTF8.Margin = new System.Windows.Forms.Padding(4);
            this.cbToUTF8.Name = "cbToUTF8";
            this.cbToUTF8.Size = new System.Drawing.Size(121, 19);
            this.cbToUTF8.TabIndex = 16;
            this.cbToUTF8.Text = "转成UTF8格式";
            this.cbToUTF8.UseVisualStyleBackColor = true;
            // 
            // lblConvertStatus
            // 
            this.lblConvertStatus.AutoSize = true;
            this.lblConvertStatus.Location = new System.Drawing.Point(289, 198);
            this.lblConvertStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConvertStatus.Name = "lblConvertStatus";
            this.lblConvertStatus.Size = new System.Drawing.Size(31, 15);
            this.lblConvertStatus.TabIndex = 15;
            this.lblConvertStatus.Text = "...";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(113, 186);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(167, 48);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "转换";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(19, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "本地路径：";
            // 
            // txtFileUppercase
            // 
            this.txtFileUppercase.Location = new System.Drawing.Point(113, 45);
            this.txtFileUppercase.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileUppercase.Name = "txtFileUppercase";
            this.txtFileUppercase.Size = new System.Drawing.Size(520, 25);
            this.txtFileUppercase.TabIndex = 13;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblLowserStatus);
            this.tabPage5.Controls.Add(this.txtConvertTolowerCase);
            this.tabPage5.Controls.Add(this.txtUpperCasePath);
            this.tabPage5.Controls.Add(this.lblFolderPath);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(670, 622);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "文件/文件夹转小写";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblLowserStatus
            // 
            this.lblLowserStatus.AutoSize = true;
            this.lblLowserStatus.Location = new System.Drawing.Point(353, 131);
            this.lblLowserStatus.Name = "lblLowserStatus";
            this.lblLowserStatus.Size = new System.Drawing.Size(31, 15);
            this.lblLowserStatus.TabIndex = 3;
            this.lblLowserStatus.Text = "...";
            // 
            // txtConvertTolowerCase
            // 
            this.txtConvertTolowerCase.Location = new System.Drawing.Point(179, 114);
            this.txtConvertTolowerCase.Name = "txtConvertTolowerCase";
            this.txtConvertTolowerCase.Size = new System.Drawing.Size(167, 48);
            this.txtConvertTolowerCase.TabIndex = 2;
            this.txtConvertTolowerCase.Text = "转成小写";
            this.txtConvertTolowerCase.UseVisualStyleBackColor = true;
            this.txtConvertTolowerCase.Click += new System.EventHandler(this.txtConvertTolowerCase_Click);
            // 
            // txtUpperCasePath
            // 
            this.txtUpperCasePath.Location = new System.Drawing.Point(179, 47);
            this.txtUpperCasePath.Name = "txtUpperCasePath";
            this.txtUpperCasePath.Size = new System.Drawing.Size(430, 25);
            this.txtUpperCasePath.TabIndex = 1;
            this.txtUpperCasePath.Text = "D:\\projects\\uzaistatics\\content";
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(90, 54);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(82, 15);
            this.lblFolderPath.TabIndex = 0;
            this.lblFolderPath.Text = "文件夹路径";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtIgnoreFolder);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.lblExts);
            this.tabPage3.Controls.Add(this.txtExts);
            this.tabPage3.Controls.Add(this.cbHttps);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtDomains);
            this.tabPage3.Controls.Add(this.btnSaveSet);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtAK);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtSK);
            this.tabPage3.Controls.Add(this.txtUptokenUrl);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtBucketName);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(670, 622);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtIgnoreFolder
            // 
            this.txtIgnoreFolder.Location = new System.Drawing.Point(153, 476);
            this.txtIgnoreFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtIgnoreFolder.Name = "txtIgnoreFolder";
            this.txtIgnoreFolder.Size = new System.Drawing.Size(480, 25);
            this.txtIgnoreFolder.TabIndex = 23;
            this.txtIgnoreFolder.Text = ".idea|.svn|.git|node_modules|packages|.tmp|bin";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(53, 479);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "忽视目录：";
            // 
            // lblExts
            // 
            this.lblExts.AutoSize = true;
            this.lblExts.Location = new System.Drawing.Point(9, 444);
            this.lblExts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExts.Name = "lblExts";
            this.lblExts.Size = new System.Drawing.Size(127, 15);
            this.lblExts.TabIndex = 21;
            this.lblExts.Text = "允许上传的类型：";
            // 
            // txtExts
            // 
            this.txtExts.Location = new System.Drawing.Point(153, 440);
            this.txtExts.Margin = new System.Windows.Forms.Padding(4);
            this.txtExts.Name = "txtExts";
            this.txtExts.Size = new System.Drawing.Size(480, 25);
            this.txtExts.TabIndex = 20;
            // 
            // cbHttps
            // 
            this.cbHttps.AutoSize = true;
            this.cbHttps.Location = new System.Drawing.Point(153, 409);
            this.cbHttps.Margin = new System.Windows.Forms.Padding(4);
            this.cbHttps.Name = "cbHttps";
            this.cbHttps.Size = new System.Drawing.Size(69, 19);
            this.cbHttps.TabIndex = 19;
            this.cbHttps.Text = "https";
            this.cbHttps.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 219);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "CDN域名列表：";
            // 
            // txtDomains
            // 
            this.txtDomains.Location = new System.Drawing.Point(153, 215);
            this.txtDomains.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomains.Multiline = true;
            this.txtDomains.Name = "txtDomains";
            this.txtDomains.Size = new System.Drawing.Size(480, 180);
            this.txtDomains.TabIndex = 16;
            this.txtDomains.Text = "http://r.uzaicdn.com\r\nhttp://r01.uzaicdn.com\r\nhttp://r02.uzaicdn.com\r\nhttp://r03." +
    "uzaicdn.com";
            // 
            // btnSaveSet
            // 
            this.btnSaveSet.Location = new System.Drawing.Point(153, 521);
            this.btnSaveSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSet.Name = "btnSaveSet";
            this.btnSaveSet.Size = new System.Drawing.Size(167, 48);
            this.btnSaveSet.TabIndex = 15;
            this.btnSaveSet.Text = "保存设置";
            this.btnSaveSet.UseVisualStyleBackColor = true;
            this.btnSaveSet.Click += new System.EventHandler(this.btnSaveSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "ACCESS_KEY：";
            // 
            // txtAK
            // 
            this.txtAK.Location = new System.Drawing.Point(153, 69);
            this.txtAK.Margin = new System.Windows.Forms.Padding(4);
            this.txtAK.Name = "txtAK";
            this.txtAK.Size = new System.Drawing.Size(480, 25);
            this.txtAK.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "SECRET_KEY：";
            // 
            // txtSK
            // 
            this.txtSK.Location = new System.Drawing.Point(153, 105);
            this.txtSK.Margin = new System.Windows.Forms.Padding(4);
            this.txtSK.Name = "txtSK";
            this.txtSK.Size = new System.Drawing.Size(480, 25);
            this.txtSK.TabIndex = 12;
            // 
            // txtUptokenUrl
            // 
            this.txtUptokenUrl.Location = new System.Drawing.Point(153, 178);
            this.txtUptokenUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtUptokenUrl.Name = "txtUptokenUrl";
            this.txtUptokenUrl.Size = new System.Drawing.Size(480, 25);
            this.txtUptokenUrl.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bucket_Name：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Uptoken_Url：";
            // 
            // txtBucketName
            // 
            this.txtBucketName.Location = new System.Drawing.Point(153, 141);
            this.txtBucketName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBucketName.Name = "txtBucketName";
            this.txtBucketName.Size = new System.Drawing.Size(480, 25);
            this.txtBucketName.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(707, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "七牛云存储文件发布";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSavePost;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.CheckBox cbCDN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCDNPath;
        private System.Windows.Forms.Button btnSaveCDN;
        private System.Windows.Forms.Label lblCDNStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSK;
        private System.Windows.Forms.TextBox txtUptokenUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBucketName;
        private System.Windows.Forms.Button btnSaveSet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocalPath;
        private System.Windows.Forms.TextBox txtDomains;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCDNLogs;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbHttps;
        private System.Windows.Forms.Label lblExts;
        private System.Windows.Forms.TextBox txtExts;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFileUppercase;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblConvertStatus;
        private System.Windows.Forms.CheckBox cbToUTF8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCheckFiles;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.Button txtConvertTolowerCase;
        private System.Windows.Forms.TextBox txtUpperCasePath;
        private System.Windows.Forms.Label lblLowserStatus;
        private System.Windows.Forms.TextBox txtIgnoreFolder;
        private System.Windows.Forms.Label label15;
    }
}

