namespace progetto_ristorante
{
    partial class Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            AddressGroupBox = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            NumberAddressTextBox = new TextBox();
            StreetTextBox = new TextBox();
            SupplyLabel = new Label();
            NumberAddresslabel = new Label();
            PostalCodeAddressLabel = new Label();
            StreetLabel = new Label();
            btnTerminaordine = new Button();
            lblCarrello = new Label();
            pcbTornaHomeDelivery = new PictureBox();
            txbNoteAggiuntive = new TextBox();
            AddressGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbTornaHomeDelivery).BeginInit();
            SuspendLayout();
            // 
            // AddressGroupBox
            // 
            AddressGroupBox.Controls.Add(textBox2);
            AddressGroupBox.Controls.Add(textBox1);
            AddressGroupBox.Controls.Add(NumberAddressTextBox);
            AddressGroupBox.Controls.Add(StreetTextBox);
            AddressGroupBox.Controls.Add(SupplyLabel);
            AddressGroupBox.Controls.Add(NumberAddresslabel);
            AddressGroupBox.Controls.Add(PostalCodeAddressLabel);
            AddressGroupBox.Controls.Add(StreetLabel);
            AddressGroupBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddressGroupBox.Location = new Point(3, 95);
            AddressGroupBox.Margin = new Padding(3, 4, 3, 4);
            AddressGroupBox.Name = "AddressGroupBox";
            AddressGroupBox.Padding = new Padding(3, 4, 3, 4);
            AddressGroupBox.Size = new Size(984, 125);
            AddressGroupBox.TabIndex = 7;
            AddressGroupBox.TabStop = false;
            AddressGroupBox.Text = "Indirizzo:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 75);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(828, 24);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(763, 27);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 24);
            textBox1.TabIndex = 6;
            // 
            // NumberAddressTextBox
            // 
            NumberAddressTextBox.Location = new Point(581, 27);
            NumberAddressTextBox.Margin = new Padding(3, 4, 3, 4);
            NumberAddressTextBox.Name = "NumberAddressTextBox";
            NumberAddressTextBox.Size = new Size(114, 24);
            NumberAddressTextBox.TabIndex = 5;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(73, 27);
            StreetTextBox.Margin = new Padding(3, 4, 3, 4);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(407, 24);
            StreetTextBox.TabIndex = 4;
            // 
            // SupplyLabel
            // 
            SupplyLabel.AutoSize = true;
            SupplyLabel.Location = new Point(7, 78);
            SupplyLabel.Name = "SupplyLabel";
            SupplyLabel.Size = new Size(135, 18);
            SupplyLabel.TabIndex = 3;
            SupplyLabel.Text = "Nome e Cognome:\r\n";
            // 
            // NumberAddresslabel
            // 
            NumberAddresslabel.AutoSize = true;
            NumberAddresslabel.Location = new Point(504, 30);
            NumberAddresslabel.Name = "NumberAddresslabel";
            NumberAddresslabel.Size = new Size(66, 18);
            NumberAddresslabel.TabIndex = 2;
            NumberAddresslabel.Text = "Numero:";
            // 
            // PostalCodeAddressLabel
            // 
            PostalCodeAddressLabel.AutoSize = true;
            PostalCodeAddressLabel.Location = new Point(712, 30);
            PostalCodeAddressLabel.Name = "PostalCodeAddressLabel";
            PostalCodeAddressLabel.Size = new Size(42, 18);
            PostalCodeAddressLabel.TabIndex = 1;
            PostalCodeAddressLabel.Text = "CAP:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(7, 30);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(55, 18);
            StreetLabel.TabIndex = 0;
            StreetLabel.Text = "Strada:";
            // 
            // btnTerminaordine
            // 
            btnTerminaordine.BackColor = Color.FromArgb(255, 199, 44);
            btnTerminaordine.FlatAppearance.BorderSize = 0;
            btnTerminaordine.FlatStyle = FlatStyle.Flat;
            btnTerminaordine.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTerminaordine.ForeColor = Color.White;
            btnTerminaordine.Location = new Point(3, 462);
            btnTerminaordine.Margin = new Padding(3, 4, 3, 4);
            btnTerminaordine.Name = "btnTerminaordine";
            btnTerminaordine.Size = new Size(984, 31);
            btnTerminaordine.TabIndex = 6;
            btnTerminaordine.Text = "Termina ordine";
            btnTerminaordine.UseVisualStyleBackColor = false;
            btnTerminaordine.Click += btnTerminaordine_Click;
            // 
            // lblCarrello
            // 
            lblCarrello.AutoSize = true;
            lblCarrello.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarrello.ForeColor = Color.FromArgb(255, 199, 44);
            lblCarrello.ImeMode = ImeMode.NoControl;
            lblCarrello.Location = new Point(431, 18);
            lblCarrello.Name = "lblCarrello";
            lblCarrello.Size = new Size(141, 39);
            lblCarrello.TabIndex = 23;
            lblCarrello.Text = "Delivery";
            // 
            // pcbTornaHomeDelivery
            // 
            pcbTornaHomeDelivery.Cursor = Cursors.Hand;
            pcbTornaHomeDelivery.Image = (Image)resources.GetObject("pcbTornaHomeDelivery.Image");
            pcbTornaHomeDelivery.Location = new Point(923, 13);
            pcbTornaHomeDelivery.Margin = new Padding(3, 4, 3, 4);
            pcbTornaHomeDelivery.Name = "pcbTornaHomeDelivery";
            pcbTornaHomeDelivery.Size = new Size(56, 53);
            pcbTornaHomeDelivery.SizeMode = PictureBoxSizeMode.CenterImage;
            pcbTornaHomeDelivery.TabIndex = 24;
            pcbTornaHomeDelivery.TabStop = false;
            pcbTornaHomeDelivery.Click += pcbTornaHomeDelivery_Click;
            // 
            // txbNoteAggiuntive
            // 
            txbNoteAggiuntive.Location = new Point(10, 227);
            txbNoteAggiuntive.Multiline = true;
            txbNoteAggiuntive.Name = "txbNoteAggiuntive";
            txbNoteAggiuntive.Size = new Size(970, 224);
            txbNoteAggiuntive.TabIndex = 25;
            txbNoteAggiuntive.Text = "Note aggiuntive\r\n\r\nSi prega di specificare eventuali allergie o preferenze alimentari al personale del ristorante.\r\n";
            // 
            // Delivery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 530);
            Controls.Add(txbNoteAggiuntive);
            Controls.Add(pcbTornaHomeDelivery);
            Controls.Add(lblCarrello);
            Controls.Add(AddressGroupBox);
            Controls.Add(btnTerminaordine);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Delivery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delivery";
            AddressGroupBox.ResumeLayout(false);
            AddressGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbTornaHomeDelivery).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox AddressGroupBox;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox NumberAddressTextBox;
        private TextBox StreetTextBox;
        private Label SupplyLabel;
        private Label NumberAddresslabel;
        private Label PostalCodeAddressLabel;
        private Label StreetLabel;
        private Button btnTerminaordine;
        private Label lblCarrello;
        private PictureBox pcbTornaHomeDelivery;
        private TextBox txbNoteAggiuntive;
    }
}