using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cau1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HUYENE856\SQLEXPRESS;Initial Catalog=DB_QLCH_ADB1_14;Integrated Security=True");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void BindComboBox()
        {
            SqlConnection contemp = new SqlConnection(@"Data Source=HUYENE856\SQLEXPRESS;Initial Catalog=DB_QLCH_ADB1_14;Integrated Security=True");
            contemp.Open();
            //if (contemp.State == ConnectionState.Open) MessageBox.Show("Good");
            string strCmd = "select MAKH from kHACHHANG";
            SqlCommand cmd = new SqlCommand(strCmd, contemp);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, contemp);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            da.Fill(dt);

            comboBoxMAKH.DisplayMember = dt.Columns[0].ToString();
            comboBoxMAKH.ValueMember = dt.Columns[0].ToString();
            comboBoxMAKH.DataSource = dt;
            //comboBoxMAKH.Enabled = true;

            contemp.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QLCH_ADB1_14DataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.dB_QLCH_ADB1_14DataSet.KHACHHANG);
            buttonTHEM.Enabled = true;
            buttonHUY.Enabled = true;
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "MM/dd/yyyy";
            textBoxTHANHTIEN.Enabled = false;
            textBoxTHANHTIEN.Text = "0";
        }

        private void buttonTHEM_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            if (textBoxMAHD.Text.Equals (""))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmd.CommandText = "insert into HOADON values ('" + textBoxMAHD.Text + "','" + comboBoxMAKH.Text + "','" + date.Value.ToString() + "','" + textBoxTHANHTIEN.Text + "')";
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm hóa đơn mới thành công", "Successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi xin vui lòng thử lại, có thể mã hóa đơn đã tồn tại hoặc mã khách hàng không hợp lệ", "Error");
            }


            con.Close();
        }

        private void buttonHUY_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Dispose();
            Application.Exit();
        }

        private void comboBoxMAKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

