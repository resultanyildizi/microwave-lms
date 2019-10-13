using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Microwave_v1._0
{
    class Picture_Events
    {
        private string pic_dest_path;
        private string pic_default_file;
        private string pic_source_file;
        private PictureBox picture_box;
        private OpenFileDialog pic_choose_dialog;
        private int i = 0;

        public string Pic_dest_path { get => pic_dest_path; set => pic_dest_path = value; }
        public string Pic_default_file { get => pic_default_file; set => pic_default_file = value; }
        public string Pic_source_file { get => pic_source_file; set => pic_source_file = value; }
        public PictureBox Picture_box { get => picture_box; set => picture_box = value; }

        public Picture_Events(string pic_dest_path, string pic_default_file, ref PictureBox pb)
        {
            this.Pic_dest_path = pic_dest_path;
            this.Pic_default_file = pic_default_file;
            this.picture_box = pb;
        }

        public void Choose_Image()
        {
            if (pic_choose_dialog == null)
                pic_choose_dialog = new OpenFileDialog();

            pic_choose_dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            pic_choose_dialog.ShowDialog();
            pic_source_file = pic_choose_dialog.FileName;


            try
            {
                this.picture_box.Load(pic_source_file);
            }
            catch (System.InvalidOperationException d)
            {
                pic_source_file = pic_default_file;
                this.picture_box.Load(pic_source_file);
            }

            pic_choose_dialog.Dispose();
            GC.Collect();
        }
        public void Copy_The_Picture(string name)
        {
            
            string pic_target_file;
            string pic_name = name + ".jpg";

            pic_target_file = System.IO.Path.Combine(pic_dest_path, pic_name);

            try
            {
                System.IO.File.Copy(pic_source_file, pic_target_file);
                pic_source_file = pic_target_file;
                i = 0;
            }
            catch (System.ArgumentException d)
            {
                pic_source_file = pic_default_file;
                System.IO.File.Copy(pic_source_file, pic_target_file);
            }
            catch(System.IO.IOException d)
            {
                /*
                i++;
                name += i.ToString();
                pic_name = name + ".jpg";
                pic_target_file = System.IO.Path.Combine(pic_dest_path, pic_name);
                System.IO.File.Copy(pic_source_file, pic_target_file);
                pic_source_file = pic_target_file;*/

                pic_source_file = pic_default_file;
            }
        }
    }
}
