using Konscious.Security.Cryptography;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Argon2_encryption_test
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private byte[] CreateSalt()
		{
			int PLI = Convert.ToInt32(PassLengthInput.Text);
			if (PLI < 20)
			{
				if (PassLengthInput.Text == "")
				{
					var buffer = new byte[16];
					var rng = new RNGCryptoServiceProvider();
					rng.GetBytes(buffer);
					return buffer;
				}
				else
				{
					int PassLength = Convert.ToInt32(PassLengthInput.Text);
					var buffer = new byte[PassLength];
					var rng = new RNGCryptoServiceProvider();
					rng.GetBytes(buffer);
					return buffer;
				}
			}
			else
			{
				var buffer = new byte[16];
				var rng = new RNGCryptoServiceProvider();
				rng.GetBytes(buffer);
				return buffer;
			}
		}

		private byte[] HashPassword(string password, byte[] salt)
		{
			var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
			{
				Salt = salt,
				DegreeOfParallelism = 2,
				Iterations = 2,
				MemorySize = 512 * 512
			};
			if (PassLengthInput.Text == "")
			{
				return argon2.GetBytes(16);
			}
			else
			{
				int PassLength = Convert.ToInt32(PassLengthInput.Text);
				return argon2.GetBytes(PassLength);
			}
		}

		private void Encrypt_Click(object sender, EventArgs e)
		{
			if (PassLengthInput.Text == "")
			{
				return;
			}
			else
			{
				var password = Convert.ToString(PasswordInput.Text);
				var salt = CreateSalt();
				UsedHash.Text = Convert.ToBase64String(salt);
				var hash = HashPassword(password, salt);
				EncryptedPassword.Text = Convert.ToBase64String(hash);
			}
		}
	}
}
