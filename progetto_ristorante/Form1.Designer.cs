namespace progetto_ristorante
{
	partial class Form1
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
			bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
			bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
			bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
			SuspendLayout();
			// 
			// bunifuElipse1
			// 
			bunifuElipse1.ElipseRadius = 5;
			bunifuElipse1.TargetControl = this;
			// 
			// bunifuDragControl1
			// 
			bunifuDragControl1.Fixed = true;
			bunifuDragControl1.Horizontal = true;
			bunifuDragControl1.TargetControl = null;
			bunifuDragControl1.Vertical = true;
			// 
			// bunifuButton1
			// 
			bunifuButton1.AllowAnimations = true;
			bunifuButton1.AllowMouseEffects = true;
			bunifuButton1.AllowToggling = false;
			bunifuButton1.AnimationSpeed = 200;
			bunifuButton1.AutoGenerateColors = false;
			bunifuButton1.AutoRoundBorders = false;
			bunifuButton1.AutoSizeLeftIcon = true;
			bunifuButton1.AutoSizeRightIcon = true;
			bunifuButton1.BackColor = Color.Transparent;
			bunifuButton1.BackColor1 = Color.FromArgb(51, 122, 183);
			bunifuButton1.BackgroundImage = (Image)resources.GetObject("bunifuButton1.BackgroundImage");
			bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			bunifuButton1.ButtonText = "bunifuButton1";
			bunifuButton1.ButtonTextMarginLeft = 0;
			bunifuButton1.ColorContrastOnClick = 45;
			bunifuButton1.ColorContrastOnHover = 45;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			bunifuButton1.CustomizableEdges = borderEdges1;
			bunifuButton1.DialogResult = DialogResult.None;
			bunifuButton1.DisabledBorderColor = Color.FromArgb(191, 191, 191);
			bunifuButton1.DisabledFillColor = Color.Empty;
			bunifuButton1.DisabledForecolor = Color.Empty;
			bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
			bunifuButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			bunifuButton1.ForeColor = Color.White;
			bunifuButton1.IconLeft = null;
			bunifuButton1.IconLeftAlign = ContentAlignment.MiddleLeft;
			bunifuButton1.IconLeftCursor = Cursors.Default;
			bunifuButton1.IconLeftPadding = new Padding(11, 3, 3, 3);
			bunifuButton1.IconMarginLeft = 11;
			bunifuButton1.IconPadding = 10;
			bunifuButton1.IconRight = null;
			bunifuButton1.IconRightAlign = ContentAlignment.MiddleRight;
			bunifuButton1.IconRightCursor = Cursors.Default;
			bunifuButton1.IconRightPadding = new Padding(3, 3, 7, 3);
			bunifuButton1.IconSize = 25;
			bunifuButton1.IdleBorderColor = Color.Empty;
			bunifuButton1.IdleBorderRadius = 0;
			bunifuButton1.IdleBorderThickness = 0;
			bunifuButton1.IdleFillColor = Color.Empty;
			bunifuButton1.IdleIconLeftImage = null;
			bunifuButton1.IdleIconRightImage = null;
			bunifuButton1.IndicateFocus = false;
			bunifuButton1.Location = new Point(316, 202);
			bunifuButton1.Name = "bunifuButton1";
			bunifuButton1.OnDisabledState.BorderColor = Color.FromArgb(191, 191, 191);
			bunifuButton1.OnDisabledState.BorderRadius = 1;
			bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			bunifuButton1.OnDisabledState.BorderThickness = 1;
			bunifuButton1.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
			bunifuButton1.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
			bunifuButton1.OnDisabledState.IconLeftImage = null;
			bunifuButton1.OnDisabledState.IconRightImage = null;
			bunifuButton1.onHoverState.BorderColor = Color.FromArgb(30, 150, 255);
			bunifuButton1.onHoverState.BorderRadius = 1;
			bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			bunifuButton1.onHoverState.BorderThickness = 1;
			bunifuButton1.onHoverState.FillColor = Color.FromArgb(30, 150, 255);
			bunifuButton1.onHoverState.ForeColor = Color.White;
			bunifuButton1.onHoverState.IconLeftImage = null;
			bunifuButton1.onHoverState.IconRightImage = null;
			bunifuButton1.OnIdleState.BorderColor = Color.DodgerBlue;
			bunifuButton1.OnIdleState.BorderRadius = 1;
			bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			bunifuButton1.OnIdleState.BorderThickness = 1;
			bunifuButton1.OnIdleState.FillColor = Color.DodgerBlue;
			bunifuButton1.OnIdleState.ForeColor = Color.White;
			bunifuButton1.OnIdleState.IconLeftImage = null;
			bunifuButton1.OnIdleState.IconRightImage = null;
			bunifuButton1.OnPressedState.BorderColor = Color.FromArgb(40, 96, 144);
			bunifuButton1.OnPressedState.BorderRadius = 1;
			bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
			bunifuButton1.OnPressedState.BorderThickness = 1;
			bunifuButton1.OnPressedState.FillColor = Color.FromArgb(40, 96, 144);
			bunifuButton1.OnPressedState.ForeColor = Color.White;
			bunifuButton1.OnPressedState.IconLeftImage = null;
			bunifuButton1.OnPressedState.IconRightImage = null;
			bunifuButton1.Size = new Size(188, 49);
			bunifuButton1.TabIndex = 0;
			bunifuButton1.TextAlign = ContentAlignment.MiddleCenter;
			bunifuButton1.TextAlignment = HorizontalAlignment.Center;
			bunifuButton1.TextMarginLeft = 0;
			bunifuButton1.TextPadding = new Padding(0);
			bunifuButton1.UseDefaultRadiusAndThickness = true;
			bunifuButton1.Click += bunifuButton1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(bunifuButton1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
	}
}