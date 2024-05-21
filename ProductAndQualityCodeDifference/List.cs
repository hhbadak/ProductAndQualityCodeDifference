using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductAndQualityCodeDifference
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {

        }

        private void productBarcode_Click(object sender, EventArgs e)
        {
            bool acikmi = false;
            Form[] acikformlar = this.MdiChildren;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(cikartilanBarkod))
                {
                    acikmi = true;
                    item.Activate();
                }
            }

            if (acikmi == false)
            {
                cikartilanBarkod brc = new cikartilanBarkod();
                brc.MdiParent = this;
                brc.Show();
            }
        }

        private void productControl_Click(object sender, EventArgs e)
        {

        }

        private void barcodeBetween_Click(object sender, EventArgs e)
        {

        }
    }
}
