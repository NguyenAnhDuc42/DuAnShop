namespace GUI
{
    partial class KichCo1
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
            btn_sua12 = new Button();
            btn_add12 = new Button();
            label1 = new Label();
            dtg_kichco1 = new DataGridView();
            txt_kichco = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_kichco1).BeginInit();
            SuspendLayout();
            // 
            // btn_sua12
            // 
            btn_sua12.Location = new Point(615, 658);
            btn_sua12.Name = "btn_sua12";
            btn_sua12.Size = new Size(194, 118);
            btn_sua12.TabIndex = 21;
            btn_sua12.Text = "Sua";
            btn_sua12.UseVisualStyleBackColor = true;
            btn_sua12.Click += btn_sua12_Click;
            // 
            // btn_add12
            // 
            btn_add12.Location = new Point(139, 658);
            btn_add12.Name = "btn_add12";
            btn_add12.Size = new Size(194, 118);
            btn_add12.TabIndex = 20;
            btn_add12.Text = "Add";
            btn_add12.UseVisualStyleBackColor = true;
            btn_add12.Click += btn_add12_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 116);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 18;
            label1.Text = "Kich co";
            // 
            // dtg_kichco1
            // 
            dtg_kichco1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_kichco1.Location = new Point(983, 48);
            dtg_kichco1.Name = "dtg_kichco1";
            dtg_kichco1.RowHeadersWidth = 62;
            dtg_kichco1.Size = new Size(633, 926);
            dtg_kichco1.TabIndex = 17;
            dtg_kichco1.CellClick += dtg_kichco1_CellClick;
            // 
            // txt_kichco
            // 
            txt_kichco.Location = new Point(209, 116);
            txt_kichco.Name = "txt_kichco";
            txt_kichco.Size = new Size(623, 31);
            txt_kichco.TabIndex = 22;
            // 
            // KichCo1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1655, 1030);
            Controls.Add(txt_kichco);
            Controls.Add(btn_sua12);
            Controls.Add(btn_add12);
            Controls.Add(label1);
            Controls.Add(dtg_kichco1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KichCo1";
            Text = "KichCo";
            ((System.ComponentModel.ISupportInitialize)dtg_kichco1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_sua12;
        private Button btn_add12;
        private Label label1;
        private DataGridView dtg_kichco1;
        private TextBox txt_kichco;
    }
}