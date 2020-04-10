namespace Argon2_encryption_test
{
	partial class Form1
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
			this.PasswordInput = new System.Windows.Forms.TextBox();
			this.Encrypt = new System.Windows.Forms.Button();
			this.EncryptedPassword = new System.Windows.Forms.TextBox();
			this.UsedHash = new System.Windows.Forms.TextBox();
			this.UsersPass = new System.Windows.Forms.Label();
			this.saltsalt = new System.Windows.Forms.Label();
			this.FinalPass = new System.Windows.Forms.Label();
			this.PassLengthInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// PasswordInput
			// 
			this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.PasswordInput.Location = new System.Drawing.Point(12, 34);
			this.PasswordInput.Multiline = true;
			this.PasswordInput.Name = "PasswordInput";
			this.PasswordInput.Size = new System.Drawing.Size(387, 68);
			this.PasswordInput.TabIndex = 0;
			// 
			// Encrypt
			// 
			this.Encrypt.BackColor = System.Drawing.Color.Tomato;
			this.Encrypt.Location = new System.Drawing.Point(121, 251);
			this.Encrypt.Name = "Encrypt";
			this.Encrypt.Size = new System.Drawing.Size(165, 48);
			this.Encrypt.TabIndex = 1;
			this.Encrypt.Text = "Encrypt";
			this.Encrypt.UseVisualStyleBackColor = false;
			this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
			// 
			// EncryptedPassword
			// 
			this.EncryptedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.EncryptedPassword.Location = new System.Drawing.Point(12, 305);
			this.EncryptedPassword.Multiline = true;
			this.EncryptedPassword.Name = "EncryptedPassword";
			this.EncryptedPassword.ReadOnly = true;
			this.EncryptedPassword.Size = new System.Drawing.Size(387, 68);
			this.EncryptedPassword.TabIndex = 2;
			// 
			// UsedHash
			// 
			this.UsedHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.UsedHash.Location = new System.Drawing.Point(93, 108);
			this.UsedHash.Multiline = true;
			this.UsedHash.Name = "UsedHash";
			this.UsedHash.ReadOnly = true;
			this.UsedHash.Size = new System.Drawing.Size(306, 68);
			this.UsedHash.TabIndex = 3;
			this.UsedHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// UsersPass
			// 
			this.UsersPass.AutoSize = true;
			this.UsersPass.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.UsersPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UsersPass.Location = new System.Drawing.Point(116, 6);
			this.UsersPass.Name = "UsersPass";
			this.UsersPass.Size = new System.Drawing.Size(190, 25);
			this.UsersPass.TabIndex = 4;
			this.UsersPass.Text = "Enter your password";
			// 
			// saltsalt
			// 
			this.saltsalt.AutoSize = true;
			this.saltsalt.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.saltsalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.saltsalt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.saltsalt.Location = new System.Drawing.Point(206, 190);
			this.saltsalt.Name = "saltsalt";
			this.saltsalt.Size = new System.Drawing.Size(158, 20);
			this.saltsalt.TabIndex = 5;
			this.saltsalt.Text = "Salt used to encrypt";
			// 
			// FinalPass
			// 
			this.FinalPass.AutoSize = true;
			this.FinalPass.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.FinalPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FinalPass.Location = new System.Drawing.Point(116, 376);
			this.FinalPass.Name = "FinalPass";
			this.FinalPass.Size = new System.Drawing.Size(191, 25);
			this.FinalPass.TabIndex = 6;
			this.FinalPass.Text = "Encrypted Password";
			// 
			// PassLengthInput
			// 
			this.PassLengthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.PassLengthInput.Location = new System.Drawing.Point(12, 108);
			this.PassLengthInput.Multiline = true;
			this.PassLengthInput.Name = "PassLengthInput";
			this.PassLengthInput.Size = new System.Drawing.Size(75, 68);
			this.PassLengthInput.TabIndex = 7;
			this.PassLengthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(8, 190);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Bytes (must be <20)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 410);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PassLengthInput);
			this.Controls.Add(this.FinalPass);
			this.Controls.Add(this.saltsalt);
			this.Controls.Add(this.UsersPass);
			this.Controls.Add(this.UsedHash);
			this.Controls.Add(this.EncryptedPassword);
			this.Controls.Add(this.Encrypt);
			this.Controls.Add(this.PasswordInput);
			this.Name = "Form1";
			this.Text = "Argon2 Encryption";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PasswordInput;
		private System.Windows.Forms.Button Encrypt;
		private System.Windows.Forms.TextBox EncryptedPassword;
		private System.Windows.Forms.TextBox UsedHash;
		private System.Windows.Forms.Label UsersPass;
		private System.Windows.Forms.Label saltsalt;
		private System.Windows.Forms.Label FinalPass;
		private System.Windows.Forms.TextBox PassLengthInput;
		private System.Windows.Forms.Label label1;
	}
}

