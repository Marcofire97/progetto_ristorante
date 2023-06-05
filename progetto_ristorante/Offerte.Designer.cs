namespace progetto_ristorante
{
    partial class Offerte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Offerte));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            pcbTornaHomeTakeAway = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button2 = new Button();
            button3 = new Button();
            lblCarrello = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pcbTornaHomeTakeAway).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 28);
            label1.Name = "label1";
            label1.Size = new Size(274, 23);
            label1.TabIndex = 0;
            label1.Text = "Buono sconto di 1€ ogni 5 acquisti";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(608, 216);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(411, 26);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Riscatta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 30);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 3;
            label3.Text = "0";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 30);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 4;
            label4.Text = "/ 5";
            label4.Click += label4_Click;
            // 
            // pcbTornaHomeTakeAway
            // 
            pcbTornaHomeTakeAway.Cursor = Cursors.Hand;
            pcbTornaHomeTakeAway.Image = (Image)resources.GetObject("pcbTornaHomeTakeAway.Image");
            pcbTornaHomeTakeAway.Location = new Point(648, 13);
            pcbTornaHomeTakeAway.Margin = new Padding(3, 4, 3, 4);
            pcbTornaHomeTakeAway.Name = "pcbTornaHomeTakeAway";
            pcbTornaHomeTakeAway.Size = new Size(56, 53);
            pcbTornaHomeTakeAway.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbTornaHomeTakeAway.TabIndex = 13;
            pcbTornaHomeTakeAway.TabStop = false;
            pcbTornaHomeTakeAway.Click += pcbTornaHomeTakeAway_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(364, 71);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 16;
            label5.Text = "/ 10";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 71);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 15;
            label6.Text = "0";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(56, 69);
            label7.Name = "label7";
            label7.Size = new Size(283, 23);
            label7.TabIndex = 14;
            label7.Text = "Buono sconto di 3€ ogni 10 acquisti";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(365, 116);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 19;
            label8.Text = "/ 20";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(345, 117);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 18;
            label9.Text = "0";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(56, 114);
            label10.Name = "label10";
            label10.Size = new Size(283, 23);
            label10.TabIndex = 17;
            label10.Text = "Buono sconto di 8€ ogni 20 acquisti";
            label10.Click += label10_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(411, 70);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 20;
            button2.Text = "Riscatta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(411, 114);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 21;
            button3.Text = "Riscatta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblCarrello
            // 
            lblCarrello.AutoSize = true;
            lblCarrello.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarrello.ForeColor = Color.FromArgb(255, 199, 44);
            lblCarrello.ImeMode = ImeMode.NoControl;
            lblCarrello.Location = new Point(265, 13);
            lblCarrello.Name = "lblCarrello";
            lblCarrello.Size = new Size(128, 39);
            lblCarrello.TabIndex = 22;
            lblCarrello.Text = "Offerte ";
            lblCarrello.Click += lblCarrello_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(59, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 157);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Offerte";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Offerte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 258);
            Controls.Add(groupBox1);
            Controls.Add(lblCarrello);
            Controls.Add(pcbTornaHomeTakeAway);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Offerte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Offerte";
            Load += Offerte_Load;
            ((System.ComponentModel.ISupportInitialize)pcbTornaHomeTakeAway).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private PictureBox pcbTornaHomeTakeAway;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button2;
        private Button button3;
        private Label lblCarrello;
        private GroupBox groupBox1;
    }
}