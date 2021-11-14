
namespace Cau1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonTHEM = new System.Windows.Forms.Button();
            this.buttonHUY = new System.Windows.Forms.Button();
            this.comboBoxMAKH = new System.Windows.Forms.ComboBox();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBQLCHADB114DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QLCH_ADB1_14DataSet = new Cau1.DB_QLCH_ADB1_14DataSet();
            this.textBoxTHANHTIEN = new System.Windows.Forms.TextBox();
            this.textBoxMAHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNGAYLAP = new System.Windows.Forms.Label();
            this.labelMAKH = new System.Windows.Forms.Label();
            this.labelTHANHTIEN = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.kHACHHANGTableAdapter = new Cau1.DB_QLCH_ADB1_14DataSetTableAdapters.KHACHHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBQLCHADB114DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCH_ADB1_14DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTHEM
            // 
            this.buttonTHEM.Location = new System.Drawing.Point(261, 189);
            this.buttonTHEM.Name = "buttonTHEM";
            this.buttonTHEM.Size = new System.Drawing.Size(75, 23);
            this.buttonTHEM.TabIndex = 0;
            this.buttonTHEM.Text = "Thêm";
            this.buttonTHEM.UseVisualStyleBackColor = true;
            this.buttonTHEM.Click += new System.EventHandler(this.buttonTHEM_Click);
            // 
            // buttonHUY
            // 
            this.buttonHUY.Location = new System.Drawing.Point(533, 190);
            this.buttonHUY.Name = "buttonHUY";
            this.buttonHUY.Size = new System.Drawing.Size(75, 23);
            this.buttonHUY.TabIndex = 1;
            this.buttonHUY.Text = "Hủy";
            this.buttonHUY.UseVisualStyleBackColor = true;
            this.buttonHUY.Click += new System.EventHandler(this.buttonHUY_Click);
            // 
            // comboBoxMAKH
            // 
            this.comboBoxMAKH.DataSource = this.kHACHHANGBindingSource;
            this.comboBoxMAKH.DisplayMember = "MAKH";
            this.comboBoxMAKH.FormattingEnabled = true;
            this.comboBoxMAKH.Location = new System.Drawing.Point(113, 106);
            this.comboBoxMAKH.Name = "comboBoxMAKH";
            this.comboBoxMAKH.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMAKH.TabIndex = 2;
            this.comboBoxMAKH.ValueMember = "MAKH";
            this.comboBoxMAKH.SelectedIndexChanged += new System.EventHandler(this.comboBoxMAKH_SelectedIndexChanged);
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.dBQLCHADB114DataSetBindingSource;
            // 
            // dBQLCHADB114DataSetBindingSource
            // 
            this.dBQLCHADB114DataSetBindingSource.DataSource = this.dB_QLCH_ADB1_14DataSet;
            this.dBQLCHADB114DataSetBindingSource.Position = 0;
            // 
            // dB_QLCH_ADB1_14DataSet
            // 
            this.dB_QLCH_ADB1_14DataSet.DataSetName = "DB_QLCH_ADB1_14DataSet";
            this.dB_QLCH_ADB1_14DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxTHANHTIEN
            // 
            this.textBoxTHANHTIEN.Location = new System.Drawing.Point(113, 148);
            this.textBoxTHANHTIEN.Name = "textBoxTHANHTIEN";
            this.textBoxTHANHTIEN.Size = new System.Drawing.Size(100, 20);
            this.textBoxTHANHTIEN.TabIndex = 3;
            // 
            // textBoxMAHD
            // 
            this.textBoxMAHD.Location = new System.Drawing.Point(113, 24);
            this.textBoxMAHD.Name = "textBoxMAHD";
            this.textBoxMAHD.Size = new System.Drawing.Size(100, 20);
            this.textBoxMAHD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã hóa đơn ";
            // 
            // labelNGAYLAP
            // 
            this.labelNGAYLAP.AutoSize = true;
            this.labelNGAYLAP.Location = new System.Drawing.Point(22, 70);
            this.labelNGAYLAP.Name = "labelNGAYLAP";
            this.labelNGAYLAP.Size = new System.Drawing.Size(52, 13);
            this.labelNGAYLAP.TabIndex = 7;
            this.labelNGAYLAP.Text = "Ngày lập ";
            // 
            // labelMAKH
            // 
            this.labelMAKH.AutoSize = true;
            this.labelMAKH.Location = new System.Drawing.Point(22, 109);
            this.labelMAKH.Name = "labelMAKH";
            this.labelMAKH.Size = new System.Drawing.Size(85, 13);
            this.labelMAKH.TabIndex = 8;
            this.labelMAKH.Text = "Mã khách hàng ";
            // 
            // labelTHANHTIEN
            // 
            this.labelTHANHTIEN.AutoSize = true;
            this.labelTHANHTIEN.Location = new System.Drawing.Point(22, 151);
            this.labelTHANHTIEN.Name = "labelTHANHTIEN";
            this.labelTHANHTIEN.Size = new System.Drawing.Size(61, 13);
            this.labelTHANHTIEN.TabIndex = 9;
            this.labelTHANHTIEN.Text = "Thành tiền ";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(113, 63);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 10;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 225);
            this.Controls.Add(this.date);
            this.Controls.Add(this.labelTHANHTIEN);
            this.Controls.Add(this.labelMAKH);
            this.Controls.Add(this.labelNGAYLAP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMAHD);
            this.Controls.Add(this.textBoxTHANHTIEN);
            this.Controls.Add(this.comboBoxMAKH);
            this.Controls.Add(this.buttonHUY);
            this.Controls.Add(this.buttonTHEM);
            this.Name = "Form1";
            this.Text = "Thêm mới hóa đơn ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBQLCHADB114DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCH_ADB1_14DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTHEM;
        private System.Windows.Forms.Button buttonHUY;
        private System.Windows.Forms.ComboBox comboBoxMAKH;
        private System.Windows.Forms.TextBox textBoxTHANHTIEN;
        private System.Windows.Forms.TextBox textBoxMAHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNGAYLAP;
        private System.Windows.Forms.Label labelMAKH;
        private System.Windows.Forms.Label labelTHANHTIEN;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.BindingSource dBQLCHADB114DataSetBindingSource;
        private DB_QLCH_ADB1_14DataSet dB_QLCH_ADB1_14DataSet;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private DB_QLCH_ADB1_14DataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
    }
}

