using System.ComponentModel;

namespace Data_Locker
	{
	partial class dataLockerForm
		{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
			{
			if (disposing && (components != null))
				{
				components.Dispose ( );
				}
			base.Dispose ( disposing );
			}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
			{
			ComponentResourceManager resources = new ComponentResourceManager ( typeof ( dataLockerForm ) );
			inputGrpBox = new GroupBox ( );
			inputTxtBox = new TextBox ( );
			outputGrpBox = new GroupBox ( );
			outputTxt = new TextBox ( );
			encryptBtn = new Button ( );
			decryptBtn = new Button ( );
			authKeyBox = new GroupBox ( );
			hashoutputlbl = new Label ( );
			hashBoxTxt = new TextBox ( );
			copyHash = new Button ( );
			generateRnd32 = new Button ( );
			enterpassLabel = new Label ( );
			keyTxtBox = new TextBox ( );
			controlsBox = new GroupBox ( );
			button3 = new Button ( );
			button2 = new Button ( );
			button1 = new Button ( );
			inputGrpBox.SuspendLayout ( );
			outputGrpBox.SuspendLayout ( );
			authKeyBox.SuspendLayout ( );
			controlsBox.SuspendLayout ( );
			SuspendLayout ( );
			// 
			// inputGrpBox
			// 
			inputGrpBox.Controls.Add ( inputTxtBox );
			inputGrpBox.ForeColor = Color.WhiteSmoke;
			inputGrpBox.Location = new Point ( 12, 12 );
			inputGrpBox.Name = "inputGrpBox";
			inputGrpBox.Size = new Size ( 449, 426 );
			inputGrpBox.TabIndex = 0;
			inputGrpBox.TabStop = false;
			inputGrpBox.Text = "Input";
			// 
			// inputTxtBox
			// 
			inputTxtBox.BackColor = SystemColors.ControlDarkDark;
			inputTxtBox.ForeColor = Color.WhiteSmoke;
			inputTxtBox.Location = new Point ( 6, 30 );
			inputTxtBox.Multiline = true;
			inputTxtBox.Name = "inputTxtBox";
			inputTxtBox.ScrollBars = ScrollBars.Both;
			inputTxtBox.Size = new Size ( 434, 381 );
			inputTxtBox.TabIndex = 1;
			// 
			// outputGrpBox
			// 
			outputGrpBox.Controls.Add ( outputTxt );
			outputGrpBox.ForeColor = Color.WhiteSmoke;
			outputGrpBox.Location = new Point ( 469, 12 );
			outputGrpBox.Name = "outputGrpBox";
			outputGrpBox.Size = new Size ( 456, 426 );
			outputGrpBox.TabIndex = 1;
			outputGrpBox.TabStop = false;
			outputGrpBox.Text = "Output";
			// 
			// outputTxt
			// 
			outputTxt.BackColor = SystemColors.ControlDarkDark;
			outputTxt.ForeColor = Color.WhiteSmoke;
			outputTxt.Location = new Point ( 6, 30 );
			outputTxt.Multiline = true;
			outputTxt.Name = "outputTxt";
			outputTxt.ScrollBars = ScrollBars.Both;
			outputTxt.Size = new Size ( 444, 381 );
			outputTxt.TabIndex = 1;
			// 
			// encryptBtn
			// 
			encryptBtn.BackColor = SystemColors.ControlDarkDark;
			encryptBtn.FlatAppearance.BorderSize = 3;
			encryptBtn.FlatStyle = FlatStyle.Flat;
			encryptBtn.ForeColor = Color.WhiteSmoke;
			encryptBtn.Location = new Point ( 6, 27 );
			encryptBtn.Name = "encryptBtn";
			encryptBtn.Size = new Size ( 428, 41 );
			encryptBtn.TabIndex = 2;
			encryptBtn.Text = "Encrypt";
			encryptBtn.UseVisualStyleBackColor = false;
			encryptBtn.Click += encryptBtn_Click;
			encryptBtn.MouseHover += encryptBtn_MouseHover;
			// 
			// decryptBtn
			// 
			decryptBtn.BackColor = SystemColors.ControlDarkDark;
			decryptBtn.FlatAppearance.BorderSize = 3;
			decryptBtn.FlatStyle = FlatStyle.Flat;
			decryptBtn.ForeColor = Color.WhiteSmoke;
			decryptBtn.Location = new Point ( 6, 74 );
			decryptBtn.Name = "decryptBtn";
			decryptBtn.Size = new Size ( 428, 41 );
			decryptBtn.TabIndex = 3;
			decryptBtn.Text = "Decrypt";
			decryptBtn.UseVisualStyleBackColor = false;
			decryptBtn.Click += decryptBtn_Click;
			decryptBtn.MouseHover += decryptBtn_MouseHover;
			// 
			// authKeyBox
			// 
			authKeyBox.Controls.Add ( hashoutputlbl );
			authKeyBox.Controls.Add ( hashBoxTxt );
			authKeyBox.Controls.Add ( copyHash );
			authKeyBox.Controls.Add ( generateRnd32 );
			authKeyBox.Controls.Add ( enterpassLabel );
			authKeyBox.Controls.Add ( keyTxtBox );
			authKeyBox.ForeColor = Color.WhiteSmoke;
			authKeyBox.Location = new Point ( 469, 444 );
			authKeyBox.Name = "authKeyBox";
			authKeyBox.Size = new Size ( 456, 271 );
			authKeyBox.TabIndex = 4;
			authKeyBox.TabStop = false;
			authKeyBox.Text = "Key / Hash";
			// 
			// hashoutputlbl
			// 
			hashoutputlbl.AutoSize = true;
			hashoutputlbl.Location = new Point ( 11, 138 );
			hashoutputlbl.Name = "hashoutputlbl";
			hashoutputlbl.Size = new Size ( 114, 25 );
			hashoutputlbl.TabIndex = 13;
			hashoutputlbl.Text = "Hash Output";
			// 
			// hashBoxTxt
			// 
			hashBoxTxt.BackColor = SystemColors.ControlDarkDark;
			hashBoxTxt.ForeColor = Color.WhiteSmoke;
			hashBoxTxt.Location = new Point ( 11, 166 );
			hashBoxTxt.Multiline = true;
			hashBoxTxt.Name = "hashBoxTxt";
			hashBoxTxt.Size = new Size ( 427, 33 );
			hashBoxTxt.TabIndex = 12;
			hashBoxTxt.Text = "Hash will appear here after decryption.";
			hashBoxTxt.UseSystemPasswordChar = true;
			// 
			// copyHash
			// 
			copyHash.BackColor = SystemColors.ControlDarkDark;
			copyHash.FlatAppearance.BorderSize = 3;
			copyHash.FlatStyle = FlatStyle.Flat;
			copyHash.ForeColor = Color.WhiteSmoke;
			copyHash.Location = new Point ( 11, 205 );
			copyHash.Name = "copyHash";
			copyHash.Size = new Size ( 427, 41 );
			copyHash.TabIndex = 10;
			copyHash.Text = "Copy Hash";
			copyHash.UseVisualStyleBackColor = false;
			copyHash.Click += copyHash_Click;
			copyHash.MouseHover += copyHash_MouseHover;
			// 
			// generateRnd32
			// 
			generateRnd32.BackColor = SystemColors.ControlDarkDark;
			generateRnd32.FlatAppearance.BorderSize = 3;
			generateRnd32.FlatStyle = FlatStyle.Flat;
			generateRnd32.ForeColor = Color.WhiteSmoke;
			generateRnd32.Location = new Point ( 11, 94 );
			generateRnd32.Name = "generateRnd32";
			generateRnd32.Size = new Size ( 427, 41 );
			generateRnd32.TabIndex = 6;
			generateRnd32.Text = "Generate Cryptographically Strong Key";
			generateRnd32.UseVisualStyleBackColor = false;
			generateRnd32.Click += generateRnd32_Click;
			generateRnd32.MouseHover += generateRnd32_MouseHover;
			// 
			// enterpassLabel
			// 
			enterpassLabel.AutoSize = true;
			enterpassLabel.Location = new Point ( 11, 27 );
			enterpassLabel.Name = "enterpassLabel";
			enterpassLabel.Size = new Size ( 85, 25 );
			enterpassLabel.TabIndex = 3;
			enterpassLabel.Text = "Enter Key";
			// 
			// keyTxtBox
			// 
			keyTxtBox.BackColor = SystemColors.ControlDarkDark;
			keyTxtBox.ForeColor = Color.WhiteSmoke;
			keyTxtBox.Location = new Point ( 11, 55 );
			keyTxtBox.Multiline = true;
			keyTxtBox.Name = "keyTxtBox";
			keyTxtBox.Size = new Size ( 427, 33 );
			keyTxtBox.TabIndex = 2;
			keyTxtBox.Text = "Key must be 32 characters long.";
			keyTxtBox.UseSystemPasswordChar = true;
			// 
			// controlsBox
			// 
			controlsBox.Controls.Add ( button3 );
			controlsBox.Controls.Add ( button2 );
			controlsBox.Controls.Add ( button1 );
			controlsBox.Controls.Add ( encryptBtn );
			controlsBox.Controls.Add ( decryptBtn );
			controlsBox.ForeColor = Color.WhiteSmoke;
			controlsBox.Location = new Point ( 12, 444 );
			controlsBox.Name = "controlsBox";
			controlsBox.Size = new Size ( 440, 271 );
			controlsBox.TabIndex = 5;
			controlsBox.TabStop = false;
			controlsBox.Text = "Controls";
			// 
			// button3
			// 
			button3.BackColor = SystemColors.ControlDarkDark;
			button3.FlatAppearance.BorderSize = 3;
			button3.FlatStyle = FlatStyle.Flat;
			button3.ForeColor = Color.WhiteSmoke;
			button3.Location = new Point ( 6, 213 );
			button3.Name = "button3";
			button3.Size = new Size ( 428, 41 );
			button3.TabIndex = 7;
			button3.Text = "Decrypt";
			button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.ControlDarkDark;
			button2.FlatAppearance.BorderSize = 3;
			button2.FlatStyle = FlatStyle.Flat;
			button2.ForeColor = Color.WhiteSmoke;
			button2.Location = new Point ( 6, 166 );
			button2.Name = "button2";
			button2.Size = new Size ( 428, 41 );
			button2.TabIndex = 6;
			button2.Text = "Decrypt";
			button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.ControlDarkDark;
			button1.FlatAppearance.BorderSize = 3;
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = Color.WhiteSmoke;
			button1.Location = new Point ( 6, 121 );
			button1.Name = "button1";
			button1.Size = new Size ( 428, 41 );
			button1.TabIndex = 5;
			button1.Text = "Decrypt";
			button1.UseVisualStyleBackColor = false;
			// 
			// dataLockerForm
			// 
			AutoScaleDimensions = new SizeF ( 10F, 25F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDarkDark;
			ClientSize = new Size ( 939, 830 );
			Controls.Add ( controlsBox );
			Controls.Add ( outputGrpBox );
			Controls.Add ( inputGrpBox );
			Controls.Add ( authKeyBox );
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Icon = (Icon)resources.GetObject ( "$this.Icon" );
			Name = "dataLockerForm";
			Text = "Data Locker";
			inputGrpBox.ResumeLayout ( false );
			inputGrpBox.PerformLayout ( );
			outputGrpBox.ResumeLayout ( false );
			outputGrpBox.PerformLayout ( );
			authKeyBox.ResumeLayout ( false );
			authKeyBox.PerformLayout ( );
			controlsBox.ResumeLayout ( false );
			ResumeLayout ( false );
			}

		#endregion

		private GroupBox inputGrpBox;
		private TextBox inputTxtBox;
		private GroupBox outputGrpBox;
		private TextBox outputTxt;
		private Button encryptBtn;
		private Button decryptBtn;
		private GroupBox authKeyBox;
		private Label enterpassLabel;
		private TextBox keyTxtBox;
		private Button generateRnd32;
		private GroupBox controlsBox;
		private Button copyHash;
		private Button button3;
		private Button button2;
		private Button button1;
		private Label hashoutputlbl;
		private TextBox hashBoxTxt;
		}
	}