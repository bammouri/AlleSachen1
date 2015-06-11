using System.Windows.Forms;
namespace YouTubeDownloaderTest
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addUrl = new System.Windows.Forms.Button();
            this.rtbUrls = new System.Windows.Forms.RichTextBox();
            this.tbxAddUrl = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Ordnertxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ordnerbtn = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.CleanBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addUrl);
            this.groupBox1.Controls.Add(this.rtbUrls);
            this.groupBox1.Controls.Add(this.tbxAddUrl);
            this.groupBox1.Location = new System.Drawing.Point(238, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // addUrl
            // 
            this.addUrl.Location = new System.Drawing.Point(275, 16);
            this.addUrl.Name = "addUrl";
            this.addUrl.Size = new System.Drawing.Size(75, 23);
            this.addUrl.TabIndex = 3;
            this.addUrl.Text = "Add Url";
            this.addUrl.UseVisualStyleBackColor = true;
            this.addUrl.Click += new System.EventHandler(this.addUrl_Click);
            // 
            // rtbUrls
            // 
            this.rtbUrls.Location = new System.Drawing.Point(6, 45);
            this.rtbUrls.Name = "rtbUrls";
            this.rtbUrls.Size = new System.Drawing.Size(332, 122);
            this.rtbUrls.TabIndex = 2;
            this.rtbUrls.Text = "";
            this.rtbUrls.TextChanged += new System.EventHandler(this.rtbUrls_TextChanged);
            // 
            // tbxAddUrl
            // 
            this.tbxAddUrl.Location = new System.Drawing.Point(6, 19);
            this.tbxAddUrl.Name = "tbxAddUrl";
            this.tbxAddUrl.Size = new System.Drawing.Size(262, 20);
            this.tbxAddUrl.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::YouTubeDownloaderTest.Properties.Resources.Download;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 194);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Beenden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gebe hier die URL ein : ";
            // 
            // Ordnertxb
            // 
            this.Ordnertxb.Location = new System.Drawing.Point(202, 255);
            this.Ordnertxb.Name = "Ordnertxb";
            this.Ordnertxb.Size = new System.Drawing.Size(229, 20);
            this.Ordnertxb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ziel Ordner : ";
            // 
            // Ordnerbtn
            // 
            this.Ordnerbtn.Location = new System.Drawing.Point(468, 252);
            this.Ordnerbtn.Name = "Ordnerbtn";
            this.Ordnerbtn.Size = new System.Drawing.Size(75, 23);
            this.Ordnerbtn.TabIndex = 8;
            this.Ordnerbtn.Text = "Neustart";
            this.Ordnerbtn.UseVisualStyleBackColor = true;
            this.Ordnerbtn.Click += new System.EventHandler(this.Ordnerbtn_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(93, 253);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(81, 23);
            this.btnDownload.TabIndex = 9;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // CleanBtn
            // 
            this.CleanBtn.Location = new System.Drawing.Point(549, 253);
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.Size = new System.Drawing.Size(81, 23);
            this.CleanBtn.TabIndex = 10;
            this.CleanBtn.Text = "Clean";
            this.CleanBtn.UseVisualStyleBackColor = true;
            this.CleanBtn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 288);
            this.Controls.Add(this.CleanBtn);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.Ordnerbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ordnertxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "YouTube Downloader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbxAddUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ordnertxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbUrls;
        private System.Windows.Forms.Button addUrl;
        private System.Windows.Forms.Button Ordnerbtn;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button CleanBtn;
    }
}

