using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Microwave_v1._0
{
    class user_node
    {
        public user_node next;
        public User user;


        public user_node(User u)
        {
            this.user = u;
            this.next = null;
        }
    }
        

    public class User_List
    {

        int point_y = User.point_y;


        user_node root;
        public User_List()
        {

            root = null;
        }


        public void Fill_User_List(DataTable dt, INFO_COLOR_MODE color_mode)
        {
            int rows_count = dt.Rows.Count;

            // IMPORTANT
            if (rows_count == 0)
                return;

            for(int i = 0; i < rows_count; i++)
            {
                int user_id = int.Parse(dt.Rows[i][0].ToString());
                if (user_id == 0)
                    continue;
                string name    = dt.Rows[i][1].ToString();
                string surname = dt.Rows[i][2].ToString();
                string gender = dt.Rows[i][3].ToString();
                int age = int.Parse(dt.Rows[i][4].ToString());
                string email = dt.Rows[i][5].ToString();
                string password = dt.Rows[i][6].ToString();
                string date = dt.Rows[i][7].ToString();

                User user = new User(user_id, name, surname, gender, age, email, password, date);
                user.Set_Book(color_mode);
                this.Add_User_to_List(user);
            }
        }
        public void Delete_All_List()
        {
            user_node iterator = root;
            user_node current;

            while (iterator != null)
            {
                current = iterator.next;
                iterator.user.Info.Dispose();
                iterator.user = null;
                iterator = current;
            }
            root = null;
        }
        public void Draw_All_Users()
        {
            User.point_y = 5;
            user_node iterator = root;
            while (iterator != null)
            {
                iterator.user.Info.Draw_User_Obj(ref User.point_y);
                iterator.user.Info.Show();
                iterator = iterator.next;
            }
        }
        public void Deselect_All_Infos()
        {
            user_node iterator = root;
            while (iterator != null)
            {
                iterator.user.Info.Deselect_User_Info();
                iterator = iterator.next;
            }
        }
        public void Hide_All_User_Objects()
        {
            user_node iterator = root;
            while(iterator != null)
            {
                iterator.user.Info.Hide_Info();
                iterator = iterator.next;
            }
        }
        public void Add_User_to_List(User user)
        {
            if (root == null)
            {
                root = new user_node(user);
                return;
            }

            user_node iterator = root;
            while (iterator.next != null)
                iterator = iterator.next;

            iterator.next = new user_node(user);
        }
        public void Delete_User_From_List(int user_id)
        {
            user_node iterator = root;

            if (root == null)
                return;

            if(root.user.User_id == user_id)
            {
                root.user.Delete();
                root.user = null;
                root = root.next;
                return;
            }

            while(iterator.next.user.User_id != user_id)
            {
                iterator = iterator.next;
                if(iterator.next == null)
                {
                    MessageBox.Show("CAN'T FOUNT");
                    return;
                }
            }

            iterator.next.user.Delete();
            iterator.next.user = null;
            iterator.next = iterator.next.next;
            return;
        }
        public User Find_User_By_ID(int user_id)
        {
            if (root == null)
                return null;

            user_node iterator = root;

            while (iterator.user.User_id != user_id)
            {
                if (iterator.next == null)
                    return null;

                iterator = iterator.next;
            }

            return iterator.user;
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
