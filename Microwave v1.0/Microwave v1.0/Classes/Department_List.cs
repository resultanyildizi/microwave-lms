using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Microwave_v1._0.Classes
{
    class department_node
    {
        public department_node next;
        public Department department;

        department_node(Department a)
        {
            this.department = a;
            this.next = null;
        }
    }
   public class Department_List
    {

        department_node root;
        public Department_List()
        {
            root = null;
        }

    }
}
