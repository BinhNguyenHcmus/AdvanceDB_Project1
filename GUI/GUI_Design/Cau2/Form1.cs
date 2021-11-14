using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_diện_câu_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QLCH_ADB1_14DataSet.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.dB_QLCH_ADB1_14DataSet.HOADON);

        }


        private void hOADONDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
