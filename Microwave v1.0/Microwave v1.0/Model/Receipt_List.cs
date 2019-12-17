using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Microwave_v1._0.Model
{
    class receipt_node
    {
        public Receipt receipt;
        public receipt_node next;
        public receipt_node(Receipt r)
        {
            this.receipt = r;
            this.next = null;
        }
    }
    public class Receipt_List
    {
        int point_y = Receipt.point_y;
        receipt_node root;


        public Receipt_List()
        {
            root = null;
        }
        public void Fill_Receipt_List(DataTable dt)
        {
            int rows_count = dt.Rows.Count;
            if (rows_count == 0)
            {
                return;
            }
            for (int i = 0; i < rows_count; i++)
            {
                int receipt_id = int.Parse(dt.Rows[i][0].ToString());
                int book_id = int.Parse(dt.Rows[i][1].ToString());
                int user_id = int.Parse(dt.Rows[i][2].ToString());
                int lib_id = int.Parse(dt.Rows[i][3].ToString());
                string name = dt.Rows[i][4].ToString();
                string msg = dt.Rows[i][5].ToString();
                string cr_date = dt.Rows[i][6].ToString();
                string rc_date = dt.Rows[i][7].ToString();
                string pt_name = dt.Rows[i][8].ToString();
                int fee = int.Parse(dt.Rows[i][9].ToString());
                Receipt receipt;

                if (name != "PENALTY")
                    receipt = new Informer(receipt_id, book_id, user_id, lib_id, name, msg, cr_date, rc_date);
                else
                    receipt = new Penalty(receipt_id, book_id, user_id, lib_id, msg, cr_date, rc_date, pt_name, fee);
                receipt.Set_Receipt();
                this.Add_Receipt_to_List(receipt);

            }
        }

        public void Delete_All_List()
        {
            receipt_node iterator = root;
            receipt_node current;

            while (iterator != null)
            {
                current = iterator.next;
                iterator.receipt.Info.Dispose();
                iterator.receipt = null;
                iterator = current;
            }
            root = null;

            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        public void Add_Receipt_to_List(Receipt receipt)
        {
            if (root == null)
            {
                root = new receipt_node(receipt);
                return;
            }

            receipt_node iterator = root;
            while (iterator.next != null)
                iterator = iterator.next;

            iterator.next = new receipt_node(receipt);
        }

        public void Draw_All_Receipts()
        {
            Receipt.point_y = 5;
            Receipt.point_x = 25;

            receipt_node iterator = root;
            while (iterator != null)
            {
                iterator.receipt.Info.Draw_Receipt_Obj(ref Receipt.point_x, ref Receipt.point_y);
                iterator.receipt.Info.Show();
                iterator = iterator.next;
            }
        }
        public void Deselect_All_Infos()
        {
            receipt_node iterator = root;
            while (iterator != null)
            {
                iterator.receipt.Info.Deselect_Receipt_Info();
                iterator = iterator.next;
            }
        }
        public void Hide_All_Receipt_Objects()
        {
            receipt_node iterator = root;
            while (iterator != null)
            {
                iterator.receipt.Info.Hide_Info();
                iterator = iterator.next;
            }
        }
        public void Delete_Receipt_from_List(int receipt_id)
        {
            receipt_node iterator = root;

            if (root == null)
            {
                return;
            }

            if (root.receipt.Receipt_id == receipt_id)
            {
                root.receipt.Delete();
                root.receipt = null;
                root = root.next;
                return;
            }

            while (iterator.next.receipt.Receipt_id != receipt_id)
            {
                iterator = iterator.next;
                if (iterator.next == null)
                {
                    MessageBox.Show("CANT FOUND");
                    return;
                }
            }

            iterator.next.receipt.Delete();
            iterator.next.receipt = null;
            iterator.next = iterator.next.next;
            return;
        }

        public Receipt Find_Receipt_By_ID(int receipt_id)
        {
            if (root == null)
                return null;

            receipt_node iterator = root;

            while (iterator.receipt.Receipt_id != receipt_id)
            {
                if (iterator.next == null)
                    return null;

                iterator = iterator.next;
            }

            return iterator.receipt;
        }
        public bool Is_List_Empty()
        {
            if (root == null)
                return true;
            else
                return false;
        }

    }
}
