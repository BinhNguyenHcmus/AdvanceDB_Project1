
namespace ADB1_14_P1
{
    partial class Cau3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbThang = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.lbNam = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbThang.Location = new System.Drawing.Point(13, 13);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(49, 17);
            this.lbThang.TabIndex = 0;
            this.lbThang.Text = "Tháng";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(69, 13);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 24);
            this.cbThang.TabIndex = 1;
            
            this.cbThang.SelectedIndexChanged += new System.EventHandler(this.cbThang_SelectedIndexChanged);
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Location = new System.Drawing.Point(196, 13);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(37, 17);
            this.lbNam.TabIndex = 2;
            this.lbNam.Text = "Năm";
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(240, 13);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(121, 24);
            this.cbNam.TabIndex = 3;
            this.cbNam.Items.Add("2020");
            this.cbNam.Items.Add("2021");
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.cbNam_SelectedIndexChanged);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Location = new System.Drawing.Point(13, 44);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(125, 30);
            this.btnDoanhThu.TabIndex = 4;
            this.btnDoanhThu.Text = "Xem doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.AutoSize = true;
            this.lbDoanhThu.Location = new System.Drawing.Point(13, 81);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(16, 17);
            this.lbDoanhThu.TabIndex = 5;
            this.lbDoanhThu.Text = "0";
            // 
            // Cau3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDoanhThu);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.lbNam);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.lbThang);
            this.Name = "Cau3";
            this.Text = "Cau3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Label lbDoanhThu;           
    }
}

