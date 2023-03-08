namespace error
{
    partial class Frmins
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnregister = new Button();
            txtphone = new TextBox();
            txtbirth = new TextBox();
            txtaddres = new TextBox();
            txtnational = new TextBox();
            txtname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnregister
            // 
            btnregister.BackColor = Color.RosyBrown;
            btnregister.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnregister.Location = new Point(269, 321);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(148, 35);
            btnregister.TabIndex = 16;
            btnregister.Text = "Register";
            btnregister.UseVisualStyleBackColor = false;
            btnregister.Click += btnregister_Click;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(242, 259);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(200, 27);
            txtphone.TabIndex = 15;
            // 
            // txtbirth
            // 
            txtbirth.Location = new Point(242, 169);
            txtbirth.Name = "txtbirth";
            txtbirth.Size = new Size(200, 27);
            txtbirth.TabIndex = 14;
            // 
            // txtaddres
            // 
            txtaddres.Location = new Point(242, 214);
            txtaddres.Name = "txtaddres";
            txtaddres.Size = new Size(200, 27);
            txtaddres.TabIndex = 13;
            // 
            // txtnational
            // 
            txtnational.Location = new Point(242, 124);
            txtnational.Name = "txtnational";
            txtnational.Size = new Size(200, 27);
            txtnational.TabIndex = 12;
            // 
            // txtname
            // 
            txtname.Location = new Point(242, 79);
            txtname.Name = "txtname";
            txtname.Size = new Size(200, 27);
            txtname.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(163, 81);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(117, 126);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 18;
            label2.Text = "National ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(126, 171);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 19;
            label3.Text = "Birth Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(145, 213);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 20;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(159, 261);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 21;
            label5.Text = "Phone";
            // 
            // button1
            // 
            button1.Location = new Point(269, 384);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 22;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Frmins
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnregister);
            Controls.Add(txtphone);
            Controls.Add(txtbirth);
            Controls.Add(txtaddres);
            Controls.Add(txtnational);
            Controls.Add(txtname);
            Name = "Frmins";
            Text = "Insert Data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnregister;
        private TextBox txtphone;
        private TextBox txtbirth;
        private TextBox txtaddres;
        private TextBox txtnational;
        private TextBox txtname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}