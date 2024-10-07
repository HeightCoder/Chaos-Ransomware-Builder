using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomWindowsForm
{
	// Token: 0x02000008 RID: 8
	public partial class Form2 : Form
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00008495 File Offset: 0x00006695
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000084AE File Offset: 0x000066AE
		private void buttonZ1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000084B8 File Offset: 0x000066B8
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000084BB File Offset: 0x000066BB
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseDown = true;
			this.lastLocation = e.Location;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000084D4 File Offset: 0x000066D4
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mouseDown)
			{
				base.Location = new Point(base.Location.X - this.lastLocation.X + e.X, base.Location.Y - this.lastLocation.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00008546 File Offset: 0x00006746
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			this.mouseDown = false;
		}

		// Token: 0x0400005D RID: 93
		private bool mouseDown;

		// Token: 0x0400005E RID: 94
		private Point lastLocation;
	}
}
