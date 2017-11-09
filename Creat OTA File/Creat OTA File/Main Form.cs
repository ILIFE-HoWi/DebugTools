using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Creat_OTA_File
{
    public partial class MainForm : Form
    {
        static string BinFilePath;

        byte[] Bin_File = new byte[] { };
        byte[] Bin_File_Temp = new byte[] { };

        bool openFileFlg = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;

            openFileDialog1.Filter = "升级文件 (*.bin)|*.bin";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //System.IO.File.WriteAllText(Application.StartupPath + "/path.txt", openFileDialog1.FileName, Encoding.UTF8);
                textBox_filePath.Text = openFileDialog1.FileName;
                BinFilePath = openFileDialog1.FileName;

                Bin_File = System.IO.File.ReadAllBytes(BinFilePath);//读取BIN文件

                openFileFlg = true;
            }
        }

        bool Check_ver(int ver)
        {
            if ((ver >= 0) && (ver <= 255))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button_creatFile_Click(object sender, EventArgs e)
        {
            if (openFileFlg == true)
            {
                if ((textBox_ver1.Text != "") && (textBox_ver2.Text != "") && (textBox_ver3.Text != ""))
                {
                    int ver1 = System.Convert.ToInt32(textBox_ver1.Text);
                    int ver2 = System.Convert.ToInt32(textBox_ver2.Text);
                    int ver3 = System.Convert.ToInt32(textBox_ver3.Text);

                    if (Check_ver(ver1) == true)
                    {
                        if (Check_ver(ver2) == true)
                        {
                            if (Check_ver(ver3) == true)
                            {
                                byte ver1_t = System.Convert.ToByte(textBox_ver1.Text);
                                byte ver2_t = System.Convert.ToByte(textBox_ver2.Text);
                                byte ver3_t = System.Convert.ToByte(textBox_ver3.Text);

                                byte[] ver_byte = new byte[4] {0, ver1_t, ver2_t, ver3_t};

                                byte[] ver_bin_byte = new byte[] { };

                                ver_bin_byte = ver_byte.Concat(Bin_File).ToArray();//这种linq方法适用于所有数组，狠，一句话搞定

                                string new_binfilepath = Path.GetDirectoryName(BinFilePath) + "\\output_ver_0_" +  ver1 + "_" + ver2 + "_" + ver3 + ".bin";
                                System.IO.File.WriteAllBytes(new_binfilepath, ver_bin_byte);

                                MessageBox.Show("已生成OTA文件: " + new_binfilepath, "成功");
                            }
                            else
                            {
                                MessageBox.Show("请核查软件版本号！", "错误");
                            }
                        }
                        else
                        {
                            MessageBox.Show("请核查机型版本号！", "错误");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请核查系列版本号！", "错误");
                    }
                }
                else
                {
                    MessageBox.Show("版本号不能为空！", "错误");
                }
            }
        }
    }
}
