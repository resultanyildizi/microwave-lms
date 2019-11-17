using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using Microwave_v1._0.UserControls;
using Microwave_v1._0.Forms;

namespace Microwave_v1._0.Classes
{

    class pub_node
    {
        public pub_node next;
        public Publisher pub;


        public pub_node(Publisher p)
        {
            this.pub = p;
            this.next = null;
        }
    }

    public class Publisher_List
    {
        int point_y = Publisher.pub_point_y;

        pub_node root;

        public Publisher_List()
        {

            root = null;
        }
        public void Add_Publisher_to_List(Publisher pub)
        {
            if (root == null)
            {
                root = new pub_node(pub);
                return;
            }

            pub_node iterator = root;
            while (iterator.next != null)
                iterator = iterator.next;

            iterator.next = new pub_node(pub);
        }

        public void Show_All_Publishers()
        {
            pub_node iterator = root;
            while (iterator != null)
            {
                iterator.pub.Pub_info.Draw_Publisher_Obj(ref Publisher.pub_point_y);
                iterator = iterator.next;
            }
        }

        public void Deselect_All_Publisher_Infos()
        {
            pub_node iterator = root;
            while (iterator != null)
            {
                iterator.pub.Pub_info.Deselect_Publisher_Info();
                iterator = iterator.next;
            }
        }
        public void Delete_Book_from_List(int publisher_id, bool delete_picture)
        {

            pub_node iterator = root;

            if (root == null)
            {
                return;
            }

            while (iterator.next.pub.Publisher_id != publisher_id)
            {
                iterator = iterator.next;
                if (iterator.next == null)
                {
                    MessageBox.Show("CANT FOUND");
                    return;
                }
            }

            if (delete_picture == true)
                Picture_Events.Delete_The_Picture(iterator.next.pub.Pub_cover_path_file);
            iterator.next.pub = null;
            iterator.next = iterator.next.next;
            return;
        }

        public Publisher Find_Publisher_By_ID(int publisher_id)
        {
            if (root == null)
                return null;

            pub_node iterator = root;

            while (iterator.pub.Publisher_id!= publisher_id)
            {
                if (iterator.next == null)
                    return null;

                iterator = iterator.next;
            }

            return iterator.pub;
        }
        public bool Is_Pub_List_Empty()
        {
            if (root == null)
                return true;
            else
                return false;
        }
        public void Fill_Cover_Image_List()
        {
            pub_node iterator = root;
            while (iterator != null)
            {
                iterator.pub.Cover_Pic_to_Image_List();
                iterator = iterator.next;
            }
        }
    }

}
