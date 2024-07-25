namespace GUI
{
    partial class MauSac1
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
            btn_sua13 = new Button();
            btn_add13 = new Button();
            label1 = new Label();
            dtg_mausac1 = new DataGridView();
            txt_mausac1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_mausac1).BeginInit();
            SuspendLayout();
            // 
            // btn_sua13
            // 
            btn_sua13.Location = new Point(602, 662);
            btn_sua13.Name = "btn_sua13";
            btn_sua13.Size = new Size(194, 118);
            btn_sua13.TabIndex = 27;
            btn_sua13.Text = "Sua";
            btn_sua13.UseVisualStyleBackColor = true;
            btn_sua13.Click += btn_sua13_Click;
            // 
            // btn_add13
            // 
            btn_add13.Location = new Point(159, 662);
            btn_add13.Name = "btn_add13";
            btn_add13.Size = new Size(194, 118);
            btn_add13.TabIndex = 26;
            btn_add13.Text = "Add";
            btn_add13.UseVisualStyleBackColor = true;
            btn_add13.Click += btn_add13_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 139);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 24;
            label1.Text = "Mau sac";
            // 
            // dtg_mausac1
            // 
            dtg_mausac1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_mausac1.Location = new Point(983, 49);
            dtg_mausac1.Name = "dtg_mausac1";
            dtg_mausac1.RowHeadersWidth = 62;
            dtg_mausac1.Size = new Size(633, 929);
            dtg_mausac1.TabIndex = 23;
            dtg_mausac1.CellClick += dtg_mausac1_CellClick;
            // 
            // txt_mausac1
            // 
            txt_mausac1.Location = new Point(232, 137);
            txt_mausac1.Name = "txt_mausac1";
            txt_mausac1.Size = new Size(564, 31);
            txt_mausac1.TabIndex = 28;
            // 
            // MauSac1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1654, 1027);
            Controls.Add(txt_mausac1);
            Controls.Add(btn_sua13);
            Controls.Add(btn_add13);
            Controls.Add(label1);
            Controls.Add(dtg_mausac1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MauSac1";
            Text = "MauSac";
            ((System.ComponentModel.ISupportInitialize)dtg_mausac1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_sua13;
        private Button btn_add13;
        private Label label1;
        private DataGridView dtg_mausac1;
        private TextBox txt_mausac1;
    }
}