namespace GUI
{
    partial class Hang
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
            dtg_hang1 = new DataGridView();
            txt_tenhang1 = new TextBox();
            label1 = new Label();
            txt_diachi1 = new TextBox();
            label2 = new Label();
            btn_add10 = new Button();
            btn_sua10 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_hang1).BeginInit();
            SuspendLayout();
            // 
            // dtg_hang1
            // 
            dtg_hang1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hang1.Location = new Point(989, 50);
            dtg_hang1.Name = "dtg_hang1";
            dtg_hang1.RowHeadersWidth = 62;
            dtg_hang1.Size = new Size(630, 918);
            dtg_hang1.TabIndex = 0;
            dtg_hang1.CellClick += dtg_hang1_CellClick;
            // 
            // txt_tenhang1
            // 
            txt_tenhang1.Location = new Point(217, 144);
            txt_tenhang1.Name = "txt_tenhang1";
            txt_tenhang1.Size = new Size(623, 31);
            txt_tenhang1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 144);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 2;
            label1.Text = "Ten hang";
            // 
            // txt_diachi1
            // 
            txt_diachi1.Location = new Point(217, 245);
            txt_diachi1.Name = "txt_diachi1";
            txt_diachi1.Size = new Size(623, 31);
            txt_diachi1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 245);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 4;
            label2.Text = "Dia chi";
            // 
            // btn_add10
            // 
            btn_add10.Location = new Point(109, 647);
            btn_add10.Name = "btn_add10";
            btn_add10.Size = new Size(194, 118);
            btn_add10.TabIndex = 6;
            btn_add10.Text = "Add";
            btn_add10.UseVisualStyleBackColor = true;
            btn_add10.Click += btn_add10_Click;
            // 
            // btn_sua10
            // 
            btn_sua10.Location = new Point(646, 647);
            btn_sua10.Name = "btn_sua10";
            btn_sua10.Size = new Size(194, 118);
            btn_sua10.TabIndex = 7;
            btn_sua10.Text = "Sua";
            btn_sua10.UseVisualStyleBackColor = true;
            btn_sua10.Click += btn_sua10_Click;
            // 
            // Hang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1658, 1027);
            Controls.Add(btn_sua10);
            Controls.Add(btn_add10);
            Controls.Add(label2);
            Controls.Add(txt_diachi1);
            Controls.Add(label1);
            Controls.Add(txt_tenhang1);
            Controls.Add(dtg_hang1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Hang";
            Text = "Hang";
            ((System.ComponentModel.ISupportInitialize)dtg_hang1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_hang1;
        private TextBox txt_tenhang1;
        private Label label1;
        private TextBox txt_diachi1;
        private Label label2;
        private Button btn_add10;
        private Button btn_sua10;
    }
}