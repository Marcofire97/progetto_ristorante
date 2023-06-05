namespace progetto_ristorante
{
	partial class Carrello
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrello));
			lblCarrello = new Label();
			pcbTornaHomeCarrello = new PictureBox();
			groupBox1 = new GroupBox();
			bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pcbTornaHomeCarrello).BeginInit();
			SuspendLayout();
			// 
			// lblCarrello
			// 
			lblCarrello.AutoSize = true;
			lblCarrello.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblCarrello.ForeColor = Color.FromArgb(255, 199, 44);
			lblCarrello.ImeMode = ImeMode.NoControl;
			lblCarrello.Location = new Point(60, 26);
			lblCarrello.Name = "lblCarrello";
			lblCarrello.Size = new Size(319, 39);
			lblCarrello.TabIndex = 2;
			lblCarrello.Text = "Carrello della spesa";
			// 
			// pcbTornaHomeCarrello
			// 
			pcbTornaHomeCarrello.Cursor = Cursors.Hand;
			pcbTornaHomeCarrello.Image = (Image)resources.GetObject("pcbTornaHomeCarrello.Image");
			pcbTornaHomeCarrello.Location = new Point(958, 13);
			pcbTornaHomeCarrello.Margin = new Padding(3, 4, 3, 4);
			pcbTornaHomeCarrello.Name = "pcbTornaHomeCarrello";
			pcbTornaHomeCarrello.Size = new Size(56, 53);
			pcbTornaHomeCarrello.SizeMode = PictureBoxSizeMode.CenterImage;
			pcbTornaHomeCarrello.TabIndex = 13;
			pcbTornaHomeCarrello.TabStop = false;
			pcbTornaHomeCarrello.Click += pcbTornaHomeCarrello_Click;
			// 
			// groupBox1
			// 
			groupBox1.Location = new Point(60, 96);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(932, 457);
			groupBox1.TabIndex = 14;
			groupBox1.TabStop = false;
			// 
			// bunifuDragControl1
			// 
			bunifuDragControl1.Fixed = true;
			bunifuDragControl1.Horizontal = true;
			bunifuDragControl1.TargetControl = null;
			bunifuDragControl1.Vertical = true;
			// 
			// button1
			// 
			button1.Location = new Point(465, 575);
			button1.Name = "button1";
			button1.Size = new Size(120, 29);
			button1.TabIndex = 15;
			button1.Text = "ORDINA";
			button1.UseVisualStyleBackColor = true;
			// 
			// Carrello
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1039, 616);
			Controls.Add(button1);
			Controls.Add(groupBox1);
			Controls.Add(pcbTornaHomeCarrello);
			Controls.Add(lblCarrello);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Carrello";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Carrello";
			((System.ComponentModel.ISupportInitialize)pcbTornaHomeCarrello).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblCarrello;
		private PictureBox pcbTornaHomeCarrello;
		private GroupBox groupBox1;
		private ElementoCarrello elementoCarrello1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private Button button1;
	}
}