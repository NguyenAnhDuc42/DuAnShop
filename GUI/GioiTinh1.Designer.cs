namespace GUI
{
    partial class GioiTinh1
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
            btn_sua11 = new Button();
            btn_add11 = new Button();
            label1 = new Label();
            dtg_gioitinh1 = new DataGridView();
            txt_gioitinh = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_gioitinh1).BeginInit();
            SuspendLayout();
            // 
            // btn_sua11
            // 
            btn_sua11.Location = new Point(633, 648);
            btn_sua11.Name = "btn_sua11";
            btn_sua11.Size = new Size(194, 118);
            btn_sua11.TabIndex = 15;
            btn_sua11.Text = "Sua";
            btn_sua11.UseVisualStyleBackColor = true;
            btn_sua11.Click += btn_sua11_Click;
            // 
            // btn_add11
            // 
            btn_add11.Location = new Point(173, 648);
            btn_add11.Name = "btn_add11";
            btn_add11.Size = new Size(194, 118);
            btn_add11.TabIndex = 14;
            btn_add11.Text = "Add";
            btn_add11.UseVisualStyleBackColor = true;
            btn_add11.Click += btn_add11_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 125);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 10;
            label1.Text = "Gioi tinh";
            // 
            // dtg_gioitinh1
            // 
            dtg_gioitinh1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_gioitinh1.Location = new Point(993, 46);
            dtg_gioitinh1.Name = "dtg_gioitinh1";
            dtg_gioitinh1.RowHeadersWidth = 62;
            dtg_gioitinh1.Size = new Size(625, 918);
            dtg_gioitinh1.TabIndex = 8;
            dtg_gioitinh1.CellClick += dtg_gioitinh1_CellClick;
            // 
            // txt_gioitinh
            // 
            txt_gioitinh.Location = new Point(269, 125);
            txt_gioitinh.Name = "txt_gioitinh";
            txt_gioitinh.Size = new Size(588, 31);
            txt_gioitinh.TabIndex = 16;
            // 
            // GioiTinh1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1657, 1026);
            Controls.Add(txt_gioitinh);
            Controls.Add(btn_sua11);
            Controls.Add(btn_add11);
            Controls.Add(label1);
            Controls.Add(dtg_gioitinh1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GioiTinh1";
            Text = "GioiTinh";
            ((System.ComponentModel.ISupportInitialize)dtg_gioitinh1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_sua11;
        private Button btn_add11;
        private Label label1;
        private DataGridView dtg_gioitinh1;
        private TextBox txt_gioitinh;
    }
}