using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using Microwave_v1._0.UserControls;
using Microwave_v1._0.Forms;
using System.Data;

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

        

        private int publisher_count = 0;

        pub_node root;

        public int Publisher_count { get => publisher_count; set => publisher_count = value; }


        public void Fill_Pub_List(DataTable dt)
        {
            int rows_count = dt.Rows.Count;

            for (int i = 1; i < rows_count; i++)
            {
                int publisher_id = int.Parse(dt.Rows[i][0].ToString());
                string pub_name = dt.Rows[i][1].ToString();
                string pub_date_of_est = dt.Rows[i][2].ToString();
                string pub_cover_path = dt.Rows[i][3].ToString();

                Publisher publisher = new Publisher(publisher_id, pub_name, pub_date_of_est, pub_cover_path);
                publisher.Set_Publisher();
                this.Add_Publisher_to_List(publisher);
            }
            Fill_Cover_Image_List();
        }


        public void Add_Publisher_to_List(Publisher pub)
        {
            if (root == null)
            {
                root = new pub_node(pub);
                publisher_count++;
                return;
            }

            pub_node iterator = root;
            while (iterator.next != null)
                iterator = iterator.next;

            iterator.next = new pub_node(pub);
            publisher_count++;
        }

        public void Show_All_Publishers()
        {
            pub_node iterator = root;
            while (iterator != null)
            {
                iterator.pub.Pub_info.Draw_Publisher_Obj(ref Publisher.pub_point_x, ref Publisher.pub_point_y);
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
        public void Delete_Publisher_from_List(int publisher_id, bool delete_picture)
        {

            pub_node iterator = root;

            if (root == null)
            {
                return;
            }

            if(root.pub.Publisher_id == publisher_id)
            {
                root.pub.Delete();
                if (delete_picture == true)
                    Picture_Events.Delete_The_Picture(root.pub.Pub_cover_path_file);
                root.pub = null;
                root = root.next;
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
            publisher_count--;
            return;
        }

        public Publisher Find_Publisher_By_ID(int publisher_id)
        {
            if (root == null)
                return null;

            pub_node iterator = root;

            while (iterator.pub.Publisher_id != publisher_id)
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
                iterator = iterator.next;
            }
        }
    }

}
