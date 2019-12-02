using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave_v1._0.UserControls
{
    public partial class Receipt_Small : UserControl
    {
        string receipt_name;
        int receipt_id;
        Receipt_Info info;

        public Receipt_Small()
        {
            InitializeComponent();
        }
    }
}
