﻿using System;
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
    class author_node
    {
        public author_node next;
        public Author author;


        public author_node(Author a)
        {
            this.author = a;
            this.next = null;
        }
    }
    public class Author_List
    {
        int point_y = Author.author_point_y;
        int point_x = Author.author_point_x;
        int author_count = 0;

        author_node root;

        public int Author_count { get => author_count; set => author_count = value; }

        public Author_List()
        {

            root = null;
        }
        public void Add_Author_to_List(Author author)
        {
            if (root == null)
            {
                root = new author_node(author);
                author_count++;
                return;
            }

            author_node iterator = root;
            while (iterator.next != null)
                iterator = iterator.next;

            iterator.next = new author_node(author);
            author_count++ ;
        }

        public void Show_All_Authors()
        {
            author_node iterator = root;
            while (iterator != null)
            {
                iterator.author.Author_info.Draw_Author_Obj(ref Author.author_point_y, ref Author.author_point_x);
                iterator = iterator.next;
            }
        }

        
        public void Delete_Author_from_List(int author_id, bool delete_picture)
        {

            author_node iterator = root;

            if (root == null)
            {
                return;
            }

            while (iterator.next.author.Author_id != author_id)
            {
                iterator = iterator.next;
                if (iterator.next == null)
                {
                    MessageBox.Show("CANT FOUND");
                    return;
                }
            }

            if (delete_picture == true)
                Picture_Events.Delete_The_Picture(iterator.next.author.Author_cover_path_file);
            iterator.next.author = null;
            iterator.next = iterator.next.next;
            return;
        }

        public Author Find_Author_By_ID(int author_id)
        {
            if (root == null)
                return null;

            author_node iterator = root;

            while (iterator.author.Author_id != author_id)
            {
                if (iterator.next == null)
                    return null;

                iterator = iterator.next;
            }

            return iterator.author;
        }
        public bool Is_Author_List_Empty()
        {
            if (root == null)
                return true;
            else
                return false;
        }
        public void Fill_Cover_Image_List()
        {
            author_node iterator = root;
            while (iterator != null)
            {
                //iterator.author.Cover_Pic_to_Image_List();
                iterator = iterator.next;
            }
        }
    }
}
