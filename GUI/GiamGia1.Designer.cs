namespace GUI
{
    partial class GiamGia1
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
            btn_sua14 = new Button();
            btn_add14 = new Button();
            dtg_giamgia1 = new DataGridView();
            txt_loaigiamgia1 = new TextBox();
            txt_mucgiam1 = new TextBox();
            txt_ngaybatdau1 = new TextBox();
            txt_ngayketthuc2 = new TextBox();
            cmbx_trangthai2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btn_save1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_giamgia1).BeginInit();
            SuspendLayout();
            // 
            // btn_sua14
            // 
            btn_sua14.Location = new Point(600, 666);
            btn_sua14.Name = "btn_sua14";
            btn_sua14.Size = new Size(194, 118);
            btn_sua14.TabIndex = 27;
            btn_sua14.Text = "Sua";
            btn_sua14.UseVisualStyleBackColor = true;
            btn_sua14.Click += btn_sua14_Click;
            // 
            // btn_add14
            // 
            btn_add14.Location = new Point(128, 666);
            btn_add14.Name = "btn_add14";
            btn_add14.Size = new Size(194, 118);
            btn_add14.TabIndex = 26;
            btn_add14.Text = "Add";
            btn_add14.UseVisualStyleBackColor = true;
            btn_add14.Click += btn_add14_Click;
            // 
            // dtg_giamgia1
            // 
            dtg_giamgia1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_giamgia1.Location = new Point(983, 44);
            dtg_giamgia1.Name = "dtg_giamgia1";
            dtg_giamgia1.RowHeadersWidth = 62;
            dtg_giamgia1.Size = new Size(628, 929);
            dtg_giamgia1.TabIndex = 23;
            dtg_giamgia1.CellClick += dtg_giamgia1_CellClick;
            // 
            // txt_loaigiamgia1
            // 
            txt_loaigiamgia1.Location = new Point(152, 122);
            txt_loaigiamgia1.Name = "txt_loaigiamgia1";
            txt_loaigiamgia1.Size = new Size(447, 31);
            txt_loaigiamgia1.TabIndex = 28;
            // 
            // txt_mucgiam1
            // 
            txt_mucgiam1.Location = new Point(749, 122);
            txt_mucgiam1.Name = "txt_mucgiam1";
            txt_mucgiam1.Size = new Size(144, 31);
            txt_mucgiam1.TabIndex = 29;
            // 
            // txt_ngaybatdau1
            // 
            txt_ngaybatdau1.Location = new Point(152, 231);
            txt_ngaybatdau1.Name = "txt_ngaybatdau1";
            txt_ngaybatdau1.Size = new Size(293, 31);
            txt_ngaybatdau1.TabIndex = 30;
            // 
            // txt_ngayketthuc2
            // 
            txt_ngayketthuc2.Location = new Point(600, 231);
            txt_ngayketthuc2.Name = "txt_ngayketthuc2";
            txt_ngayketthuc2.Size = new Size(293, 31);
            txt_ngayketthuc2.TabIndex = 31;
            // 
            // cmbx_trangthai2
            // 
            cmbx_trangthai2.FormattingEnabled = true;
            cmbx_trangthai2.Location = new Point(335, 357);
            cmbx_trangthai2.Name = "cmbx_trangthai2";
            cmbx_trangthai2.Size = new Size(182, 33);
            cmbx_trangthai2.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 123);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 33;
            label1.Text = "Loai giam gia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(635, 125);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 34;
            label2.Text = "Muc giam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 234);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 35;
            label3.Text = "Ngay bat dau";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 234);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 36;
            label4.Text = "Ngay ket thuc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 360);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 37;
            label5.Text = "Trang thai";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(451, 234);
            label6.Name = "label6";
            label6.Size = new Size(16, 25);
            label6.TabIndex = 38;
            label6.Text = "|";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(613, 125);
            label7.Name = "label7";
            label7.Size = new Size(16, 25);
            label7.TabIndex = 39;
            label7.Text = "|";
            // 
            // btn_save1
            // 
            btn_save1.Location = new Point(382, 530);
            btn_save1.Name = "btn_save1";
            btn_save1.Size = new Size(171, 117);
            btn_save1.TabIndex = 40;
            btn_save1.Text = "Save";
            btn_save1.UseVisualStyleBackColor = true;
            btn_save1.Click += btn_save1_Click;
            // 
            // GiamGia1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1650, 1016);
            Controls.Add(btn_save1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbx_trangthai2);
            Controls.Add(txt_ngayketthuc2);
            Controls.Add(txt_ngaybatdau1);
            Controls.Add(txt_mucgiam1);
            Controls.Add(txt_loaigiamgia1);
            Controls.Add(btn_sua14);
            Controls.Add(btn_add14);
            Controls.Add(dtg_giamgia1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GiamGia1";
            Text = "GiamGia";
            ((System.ComponentModel.ISupportInitialize)dtg_giamgia1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_sua14;
        private Button btn_add14;
        private DataGridView dtg_giamgia1;
        private TextBox txt_loaigiamgia1;
        private TextBox txt_mucgiam1;
        private TextBox txt_ngaybatdau1;
        private TextBox txt_ngayketthuc2;
        private ComboBox cmbx_trangthai2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btn_save1;
    }
}