using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Threading;
using Microwave_v1._0.Classes;
using System.Data;
using System.Drawing;
using Microwave_v1._0.Forms;

namespace Microwave_v1._0.Model
{
    class shelf_node
    {
        public shelf_node next;
        public Shelf shelf;
        public shelf_node(Shelf s)
        {
            this.shelf = s;
            this.next = null;
        }
    }
    public class Shelf_List
    {
        int point_y = Shelf.point_y;
        shelf_node root;

        public Shelf_List()
        {
            root = null;
        }

        public void Fill_Shelf_List(DataTable dt)
        {
            int rows_count = dt.Rows.Count;
            if (rows_count == 0)
            {
                return;
            }
            for (int i = 0; i < rows_count; i++)
            {

                int shelf_id = int.Parse(dt.Rows[i][0].ToString());
                if (shelf_id == 0)
                    continue;
                string shelf_name = dt.Rows[i][1].ToString();

                Shelf shelf = new Shelf(shelf_id,shelf_name);
                shelf.Set_Shelf();
                this.Add_Shelf_to_List(shelf);
            }
        }

        public void Add_Shelf_to_List(Shelf shelf)
        {
            if (root == null)
            {
                root = new shelf_node(shelf);
                return;
            }

            shelf_node iterator = root;
            while (iterator.next != null)
                iterator = iterator.next;

            iterator.next = new shelf_node(shelf);
        }

        public void Draw_All_Shelf()
        {
            Shelf.point_y = 20;
            Shelf.point_x = 22;

            shelf_node iterator = root;
            while (iterator != null)
            {
                iterator.shelf.Shelf_ınfo.Draw_Shelf_Obj(Shelf.point_x,ref Shelf.point_y);
                iterator.shelf.Shelf_ınfo.Show();
                iterator = iterator.next;
            }
        }

        public Shelf Find_Shelf_By_ID(int shelf_id)
        {
            if (root == null)
                return null;

            shelf_node iterator = root;

            while (iterator.shelf.Shelf_id != shelf_id)
            {
                if (iterator.next == null)
                    return null;

                iterator = iterator.next;
            }

            return iterator.shelf;
        }

        //BOOK

    }
}
