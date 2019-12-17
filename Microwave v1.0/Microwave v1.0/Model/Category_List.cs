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

namespace Microwave_v1._0.Model
{
        class category_node
        {
            public category_node next;
            public Category category;


            public category_node(Category c)
            {
                this.category = c;
                this.next = null;
            }
        }
        public class Category_List
        {
            int point_y = Category.category_point_y;
            int point_x = Category.category_point_x;
            int category_count = 0;

            category_node root;

            public int Category_count { get => category_count; set => category_count = value; }

            public Category_List()
            {

                root = null;
            }

            public void Fill_Category_List(DataTable dt)
            {
                int rows_count = dt.Rows.Count;

                for (int i = 0; i < rows_count; i++)
                {
                    int category_id = int.Parse(dt.Rows[i][0].ToString());
                    if (category_id == 0)
                        continue;
                    string category_name = dt.Rows[i][1].ToString();
                    int popularity_id = int.Parse(dt.Rows[i][2].ToString());
                    int popularity_score = int.Parse(dt.Rows[i][3].ToString());
                    string category_cover_path_file = dt.Rows[i][4].ToString();

                    Category category = new Category(category_id, category_name, popularity_id, popularity_score, category_cover_path_file);
                    category.Set_Categories();
                    this.Add_Category_to_List(category);
                }

            }

            public void Delete_All_List()
            {
                category_node iterator = root;
                category_node current;

                while (iterator != null)
                {
                    current = iterator.next;
                    iterator.category.Info.Dispose();
                    iterator.category = null;
                    iterator = current;
                }
                root = null;

                GC.WaitForPendingFinalizers();
                GC.Collect();
            }

            public void Add_Category_to_List(Category category)
            {
                if (root == null)
                {
                    root = new category_node(category);
                    category_count++;
                    return;
                }

                category_node iterator = root;
                while (iterator.next != null)
                    iterator = iterator.next;

                iterator.next = new category_node(category);
                category_count++;
            }

            public void Draw_All_Categories()
            {
                Category.category_point_y = 5;
                Category.category_point_x = 35;

                category_node iterator = root;
                while (iterator != null)
                {
                    iterator.category.Info.Draw_Category_Obj(ref Category.category_point_x, ref Category.category_point_y);
                    iterator.category.Info.Show();
                    iterator = iterator.next;
                }
            }

            public void Deselect_All_Infos()
            {
                category_node iterator = root;
                while (iterator != null)
                {
                    iterator.category.Info.Deselect_Category_Info();
                    iterator = iterator.next;
                }
            }

            public void Hide_All_Category_Objects()
            {
                category_node iterator = root;
                while (iterator != null)
                {
                    iterator.category.Info.Hide_Info();
                    iterator = iterator.next;
                }
            }

            public void Delete_Category_from_List(int category_id, bool delete_picture)
            {

                category_node iterator = root;

                if (root == null)
                {
                    return;
                }

                while (iterator.next.category.Category_id != category_id)
                {
                    iterator = iterator.next;
                    if (iterator.next == null)
                    {
                        MessageBox.Show("CANT FOUND");
                        return;
                    }
                }

                if (delete_picture == true)
                    Picture_Events.Delete_The_Picture(iterator.next.category.Category_cover_path_file);
                iterator.next.category.Delete();
                iterator.next.category = null;
                iterator.next = iterator.next.next;
                return;
            }

            public Category Find_Category_By_ID(int category_id)
            {
                if (root == null)
                    return null;

                category_node iterator = root;

                while (iterator.category.Category_id != category_id)
                {
                    if (iterator.next == null)
                        return null;

                    iterator = iterator.next;
                }

            return iterator.category;
            }
            public bool Is_Category_List_Empty()
            {
                if (root == null)
                    return true;
                else
                    return false;
            }
            public void Fill_Cover_Image_List()
            {
                category_node iterator = root;
                while (iterator != null)
                {
                    //iterator.author.Cover_Pic_to_Image_List();
                    iterator = iterator.next;
                }
            }
        }
    }

