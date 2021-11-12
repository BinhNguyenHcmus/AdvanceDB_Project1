using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Câu_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_QLCH_ADB1_14DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QLCH_ADB1_14DataSet.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.dB_QLCH_ADB1_14DataSet.HOADON);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hOADONBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hOADONBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.hOADONBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_QLCH_ADB1_14DataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.hOADONBindingSource.AddNew();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hOADONTableAdapter.FillBy(this.dB_QLCH_ADB1_14DataSet.HOADON);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
