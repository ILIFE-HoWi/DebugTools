namespace Creat_OTA_File
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox_filePath = new System.Windows.Forms.TextBox();
            this.button_openFile = new System.Windows.Forms.Button();
            this.textBox_ver1 = new System.Windows.Forms.TextBox();
            this.textBox_ver2 = new System.Windows.Forms.TextBox();
            this.textBox_ver3 = new System.Windows.Forms.TextBox();
            this.button_creatFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox_filePath
            // 
            this.textBox_filePath.Location = new System.Drawing.Point(31, 33);
            this.textBox_filePath.Name = "textBox_filePath";
            this.textBox_filePath.Size = new System.Drawing.Size(329, 21);
            this.textBox_filePath.TabIndex = 0;
            // 
            // button_openFile
            // 
            this.button_openFile.Location = new System.Drawing.Point(380, 32);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(91, 23);
            this.button_openFile.TabIndex = 1;
            this.button_openFile.Text = "打开bin文件";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // textBox_ver1
            // 
            this.textBox_ver1.Location = new System.Drawing.Point(31, 86);
            this.textBox_ver1.Name = "textBox_ver1";
            this.textBox_ver1.Size = new System.Drawing.Size(100, 21);
            this.textBox_ver1.TabIndex = 2;
            this.textBox_ver1.Text = "0";
            this.textBox_ver1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_ver2
            // 
            this.textBox_ver2.Location = new System.Drawing.Point(145, 86);
            this.textBox_ver2.Name = "textBox_ver2";
            this.textBox_ver2.Size = new System.Drawing.Size(100, 21);
            this.textBox_ver2.TabIndex = 3;
            this.textBox_ver2.Text = "0";
            this.textBox_ver2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_ver3
            // 
            this.textBox_ver3.Location = new System.Drawing.Point(259, 86);
            this.textBox_ver3.Name = "textBox_ver3";
            this.textBox_ver3.Size = new System.Drawing.Size(100, 21);
            this.textBox_ver3.TabIndex = 4;
            this.textBox_ver3.Text = "0";
            this.textBox_ver3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_creatFile
            // 
            this.button_creatFile.Location = new System.Drawing.Point(380, 85);
            this.button_creatFile.Name = "button_creatFile";
            this.button_creatFile.Size = new System.Drawing.Size(91, 23);
            this.button_creatFile.TabIndex = 5;
            this.button_creatFile.Text = "生成OTA文件";
            this.button_creatFile.UseVisualStyleBackColor = true;
            this.button_creatFile.Click += new System.EventHandler(this.button_creatFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "文件路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "系列版本(0~255)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "机型版本(0~255)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "软件版本(0~255)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 146);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_creatFile);
            this.Controls.Add(this.textBox_ver3);
            this.Controls.Add(this.textBox_ver2);
            this.Controls.Add(this.textBox_ver1);
            this.Controls.Add(this.button_openFile);
            this.Controls.Add(this.textBox_filePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(518, 184);
            this.MinimumSize = new System.Drawing.Size(518, 184);
            this.Name = "MainForm";
            this.Text = "Creat OTA File V1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_filePath;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.TextBox textBox_ver1;
        private System.Windows.Forms.TextBox textBox_ver2;
        private System.Windows.Forms.TextBox textBox_ver3;
        private System.Windows.Forms.Button button_creatFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

