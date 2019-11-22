using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
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

            static Microwave main_page;
            int point_y = User.point_y;


            user_node root;
            public User_List()
            {

                root = null;
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

            public void Show_All_Users()
            {
                user_node iterator = root;
                while (iterator != null)
                {
                    iterator.user.Info.Draw_User_Obj(ref Book.point_y);
                    iterator = iterator.next;
                }
            }



            public void Deselect_All_User_Infos()
            {
                user_node iterator = root;
                while (iterator != null)
                {
                    iterator.user.Info.Deselect_User_Info();
                    iterator = iterator.next;
                }
            }

        }
}
