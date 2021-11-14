using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADB1_14_P1
{   
    public partial class Cau3 : Form
    {
        private String thang = "";
        private String nam = "";
        private String doanhThu = "";
        public Cau3()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                this.cbThang.Items.Add(i.ToString());
            }
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThang.SelectedItem != null)
            {
                thang = cbThang.SelectedItem.ToString();
            }                
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNam.SelectedItem != null)
            {
                nam = cbNam.SelectedItem.ToString();
            }
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if (cbNam.Text.Equals("") || cbThang.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn tháng và năm để xem doanh thu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbNam.Text.Equals("2020"))
            {
                if (int.Parse(cbThang.Text) < 5)
                {
                    MessageBox.Show("Vui lòng chọn tháng lớn hơn 4 trong năm 2020!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (cbNam.Text.Equals("2021"))
            {
                if (int.Parse(cbThang.Text) > 6)
                {
                    MessageBox.Show("Vui lòng chọn tháng bé hơn 7 trong năm 2021!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            String connectionString = ConfigurationManager.ConnectionStrings["QLCH_ADB1_14"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            if (int.Parse(thang) < 10)
            {
                thang = "0" + thang;
            }
            String query = "SELECT SUM(CAST(HD.TONGTIEN AS BIGINT)) AS DOANHTHU FROM HOADON HD WHERE HD.NGAYLAP LIKE \'" + nam + "-" + thang + "%\'";         
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            doanhThu = command.ExecuteScalar().ToString();
            lbDoanhThu.Text = doanhThu;
            con.Close();
        }
    }
}
