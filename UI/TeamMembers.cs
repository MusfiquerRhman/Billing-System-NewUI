using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystemNewUI.UI
{
    public partial class TeamMembers : Form
    {
        public TeamMembers()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            this.Close();
            SellProduct sellProduct = new SellProduct();
            sellProduct.Show();
        }
    }
}
