using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace ImageToPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //存放选择的目录
        string father_path = "";
        //存放文件夹对象
        private List<Folder> folder = new List<Folder>() { };
        //默认文件夹路径，用于记录上次的路径
        string defaultfilePath = ""; 
        //记录图片个数
        int count = 0;
        

        //获得所有文件及目录
        private void tb_path_MouseClick(object sender, MouseEventArgs e)
        {
            this.btn_clear.PerformClick();
            
            FolderBrowserDialog dir_path = new FolderBrowserDialog();
            if (defaultfilePath != "")
            {
                //设置此次默认目录为上一次选中目录  
                dir_path.SelectedPath = defaultfilePath;
            }

            if (dir_path.ShowDialog() == DialogResult.OK)
            {
                father_path = dir_path.SelectedPath;
                this.tb_path.Text = father_path;
                folder.Add(new Folder(father_path));
                getDirectory(father_path, 2);
                //输出当前目录下的所有目录
                for (int i = 0; i < folder.Count; i++)
                {
                    this.tb_info.Text += folder[i].Path + "\r\n";
                    
                    for (int j = 0; j < folder[i].Image.Count; j++)
                    {
                        Console.WriteLine(folder[i].Image[j]);
                    }
                    Console.WriteLine();
                    count += folder[i].Image.Count;
                }
                //记录默认位置
                defaultfilePath = dir_path.SelectedPath;

                this.lab_state.Text = "状态：目录读取完毕，共" + folder.Count + "个文件夹，" + count +"张图片！";
            }

        }

        //递归获得目录下的所有文件夹
        public void getDirectory(string path, int indent)
        {
            try
            {
                DirectoryInfo root = new DirectoryInfo(path);
                foreach (DirectoryInfo d in root.GetDirectories())
                {
                    folder.Add(new Folder(d.FullName));
                    getDirectory(d.FullName, indent + 2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //清空所有
        private void btn_clear_Click(object sender, EventArgs e)
        {
            father_path = "";
            folder.Clear();
            this.tb_info.Text = "";
            this.lab_state.Text = "状态：";
            this.tb_path.Text = "";
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t       点击下面的横条选择主目录\r\n    点击生成可将每个目录下的图片合并成一个pdf文档\r\n        所有pdf文件保存在主目录下的【AllPdfFiles】中\r\n\t\t使用愉快：）", "【说明】");
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            int pdfcount = 0;
            //无效操作过滤
            if (father_path.Equals(""))
            {
                MessageBox.Show("请先选择一个目录！", "【警告】");
            }
            else if (count == 0)
            {
                MessageBox.Show("目录下没有图片！", "【警告】");
            }
            else
            {
                //文件夹不存在则创建文件夹
                string subPath = this.tb_path.Text + @"\AllPdfFiles\";
                string temp = "";
                if (false == System.IO.Directory.Exists(subPath))            
                {
                    try
                    {
                        //创建allpdffiles文件夹
                        System.IO.Directory.CreateDirectory(subPath);
                    }
                    catch 
                    {
                        MessageBox.Show("目录【AllPdfFiles】创建失败！", "【警告】");
                    }
                }
                //文件夹存在则使用                
                try
                {
                    for (int i = 0; i < folder.Count; i++)
                    {
                        if (folder[i].Image.Count <= 0)
                            continue;
                        iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);
                        //temp = folder[i].Path; 
                        temp = folder[i].Path.Substring(0, folder[i].Path.LastIndexOf('\\'));
                        temp = folder[0].Path + @"\AllPdfFiles" + temp.Substring(temp.LastIndexOf('\\')) + ".pdf";
                        iTextSharp.text.pdf.PdfWriter.GetInstance(document, new FileStream(temp, FileMode.Create, FileAccess.ReadWrite));
                        document.Open();
                        iTextSharp.text.Image image;
                        for (int j = 0; j < folder[i].Image.Count; j++)
                        {
                            if (String.IsNullOrEmpty(folder[i].Image[j])) break;

                            image = iTextSharp.text.Image.GetInstance(folder[i].Image[j]);
                            
                            if (image.Height > iTextSharp.text.PageSize.A4.Height - 25)
                            {
                                image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                            }
                            else if (image.Width > iTextSharp.text.PageSize.A4.Width - 25)
                            {
                                image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                            }
                            image.Alignment = iTextSharp.text.Image.ALIGN_MIDDLE;
                            document.NewPage();
                            document.Add(image);
                        } 
                        pdfcount++;
                        document.Close();
                    }
                    this.lab_state.Text = "状态：所有pdf创建成功！共" + pdfcount + "个pdf文件被创建！路径为：\r\n      " + subPath;
                }
                catch
                {
                    this.lab_state.Text = "状态：pdf创建失败！";
                }                
            }
        }
    }
}
