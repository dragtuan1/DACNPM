using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACNPM.Library_Control
{
    public partial class QL_Vehicle : UserControl
    {
        public QL_Vehicle()
        {
            InitializeComponent();
            DGV_QLXe.DataSource = BLL_QLVehicle.Instance.GetALL_Vehicle();
        }

    }
}
