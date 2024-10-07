using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CustomWindowsForm;
using Chaos_Ransomware.Properties;

namespace Ryuk.Net
{
	// Token: 0x02000007 RID: 7
	public partial class extensions : Form
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00007D20 File Offset: 0x00005F20
		public extensions()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00007D39 File Offset: 0x00005F39
		private void _CloseButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00007D43 File Offset: 0x00005F43
		private void button1_Click(object sender, EventArgs e)
		{
			Settings.Default.extensions = this.textBox1.Text;
			MessageBox.Show("Saved successfully");
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00007D67 File Offset: 0x00005F67
		private void extensions_Load(object sender, EventArgs e)
		{
			this.textBox1.Text = Settings.Default.extensions;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00007D80 File Offset: 0x00005F80
		private void extensions_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
			this.lastLocation = e.Location;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00007D96 File Offset: 0x00005F96
		private void extensions_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00007DA0 File Offset: 0x00005FA0
		private void extensions_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mouseDown)
			{
				base.Location = new Point(base.Location.X - this.lastLocation.X + e.X, base.Location.Y - this.lastLocation.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00007E12 File Offset: 0x00006012
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
			this.lastLocation = e.Location;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00007E28 File Offset: 0x00006028
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00007E34 File Offset: 0x00006034
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mouseDown)
			{
				base.Location = new Point(base.Location.X - this.lastLocation.X + e.X, base.Location.Y - this.lastLocation.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x04000055 RID: 85
		private bool mouseDown;

		// Token: 0x04000056 RID: 86
		private Point lastLocation;
	}
}
