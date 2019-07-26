using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToPDF
{
    class Folder
    {
        //存放文件夹路径以及文件夹下的图片路径
        private string path;
        private List<string> image = new List<string>() { };


        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public List<string> Image
        {
            get { return image; }
            set { image = value; }
        }



        public Folder(string path)
        {
            this.path = path;
            //获得所有图片
            GetImageFromPath(path);

        }

        public void GetImageFromPath(string path)
        {
            //获得所有图片
            List<string> temppic = GetPics(path);
            foreach (string pic in temppic)
            {
                this.image.Add(pic);
            }
        }

        private List<string> GetPics(string fpath)
        {
            //存放所有图片路径
            List<string> picnames = new List<string>();
            //获得目录下的所有图片
            string[] ImageType = { "*.bmp", "*.jpg", "*.png", "*.jpeg" };
            //临时存放当前图片路径
            string[] dirs;
            try
            {
                for (int i = 0; i < ImageType.Length; i++)
                {
                    dirs = Directory.GetFiles(fpath, ImageType[i]);
                    for (int j = 0; j < dirs.Length; j++)
                    {
                        //当前类型的所有图片加入list
                        picnames.Add(dirs[j]);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return picnames;
        }
    }
}
