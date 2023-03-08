namespace error
{
    partial class frmshow
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
            btnsho = new Button();
            dgv = new DataGridView();
            btnnext = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnsho
            // 
            btnsho.BackColor = Color.RosyBrown;
            btnsho.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnsho.Location = new Point(231, 342);
            btnsho.Name = "btnsho";
            btnsho.Size = new Size(201, 41);
            btnsho.TabIndex = 23;
            btnsho.Text = "Show Data";
            btnsho.UseVisualStyleBackColor = false;
            btnsho.Click += btndatasow_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Top;
            dgv.Location = new Point(0, 0);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(695, 310);
            dgv.TabIndex = 24;
            // 
            // btnnext
            // 
            btnnext.BackColor = Color.RosyBrown;
            btnnext.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnnext.Location = new Point(231, 405);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(201, 41);
            btnnext.TabIndex = 25;
            btnnext.Text = "Next Page";
            btnnext.UseVisualStyleBackColor = false;
            btnnext.Click += btnnext_Click;
            // 
            // frmshow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(695, 476);
            Controls.Add(btnnext);
            Controls.Add(dgv);
            Controls.Add(btnsho);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmshow";
            Text = "Show Data";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnsho;
        private DataGridView dgv;
        private Button btnnext;
    }
}