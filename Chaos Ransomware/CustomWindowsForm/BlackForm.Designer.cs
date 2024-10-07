namespace CustomWindowsForm
{
	// Token: 0x02000003 RID: 3
	public partial class BlackForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000514C File Offset: 0x0000334C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005184 File Offset: 0x00003384
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackForm));
            this.RightPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this._MinButton = new CustomWindowsForm.ButtonZ();
            this._MaxButton = new CustomWindowsForm.MinMaxButton();
            this.WindowTextLabel = new System.Windows.Forms.Label();
            this._CloseButton = new CustomWindowsForm.ButtonZ();
            this.RightBottomPanel_1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shapedButton2 = new CustomWindowsForm.ShapedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.droppedMessageTextbox = new System.Windows.Forms.TextBox();
            this.shapedButton1 = new CustomWindowsForm.ShapedButton();
            this.sleepCheckBox = new System.Windows.Forms.CheckBox();
            this.SleepTextBox = new System.Windows.Forms.TextBox();
            this.selectIconLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startupcheckBox3 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.spreadNameText = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.usbSpreadCheckBox = new System.Windows.Forms.CheckBox();
            this.shapedButton4 = new CustomWindowsForm.ShapedButton();
            this.shapedButton3 = new CustomWindowsForm.ShapedButton();
            this.RightBottomPanel_2 = new System.Windows.Forms.Panel();
            this.LeftBottomPanel_2 = new System.Windows.Forms.Panel();
            this.RightTopPanel_1 = new System.Windows.Forms.Panel();
            this.RightTopPanel_2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TopPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.BackColor = System.Drawing.Color.Black;
            this.RightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightPanel.Location = new System.Drawing.Point(896, 22);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(2, 468);
            this.RightPanel.TabIndex = 1;
            this.RightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseDown);
            this.RightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseMove);
            this.RightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseUp);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TopPanel.Controls.Add(this._MinButton);
            this.TopPanel.Controls.Add(this._MaxButton);
            this.TopPanel.Controls.Add(this.WindowTextLabel);
            this.TopPanel.Controls.Add(this._CloseButton);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(845, 74);
            this.TopPanel.TabIndex = 4;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // _MinButton
            // 
            this._MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._MinButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._MinButton.DisplayText = "_";
            this._MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._MinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._MinButton.ForeColor = System.Drawing.Color.White;
            this._MinButton.Location = new System.Drawing.Point(737, 8);
            this._MinButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._MinButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._MinButton.Name = "_MinButton";
            this._MinButton.Size = new System.Drawing.Size(31, 24);
            this._MinButton.TabIndex = 4;
            this._MinButton.Text = "_";
            this._MinButton.TextLocation_X = 6;
            this._MinButton.TextLocation_Y = -20;
            this._MinButton.UseVisualStyleBackColor = true;
            this._MinButton.Click += new System.EventHandler(this._MinButton_Click);
            // 
            // _MaxButton
            // 
            this._MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._MaxButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._MaxButton.CFormState = CustomWindowsForm.MinMaxButton.CustomFormState.Normal;
            this._MaxButton.DisplayText = "_";
            this._MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._MaxButton.ForeColor = System.Drawing.Color.White;
            this._MaxButton.Location = new System.Drawing.Point(774, 9);
            this._MaxButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._MaxButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._MaxButton.Name = "_MaxButton";
            this._MaxButton.Size = new System.Drawing.Size(31, 24);
            this._MaxButton.TabIndex = 2;
            this._MaxButton.Text = "minMaxButton1";
            this._MaxButton.TextLocation_X = 8;
            this._MaxButton.TextLocation_Y = 6;
            this._MaxButton.UseVisualStyleBackColor = true;
            this._MaxButton.Click += new System.EventHandler(this._MaxButton_Click);
            // 
            // WindowTextLabel
            // 
            this.WindowTextLabel.AutoSize = true;
            this.WindowTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowTextLabel.ForeColor = System.Drawing.Color.White;
            this.WindowTextLabel.Location = new System.Drawing.Point(8, 22);
            this.WindowTextLabel.Name = "WindowTextLabel";
            this.WindowTextLabel.Size = new System.Drawing.Size(523, 39);
            this.WindowTextLabel.TabIndex = 1;
            this.WindowTextLabel.Text = "Chaos Ransomware Builder v5.2";
            this.WindowTextLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseDown);
            this.WindowTextLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseMove);
            this.WindowTextLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseUp);
            // 
            // _CloseButton
            // 
            this._CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.Location = new System.Drawing.Point(811, 8);
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.Size = new System.Drawing.Size(31, 24);
            this._CloseButton.TabIndex = 0;
            this._CloseButton.Text = "X";
            this._CloseButton.TextLocation_X = 6;
            this._CloseButton.TextLocation_Y = 1;
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // RightBottomPanel_1
            // 
            this.RightBottomPanel_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RightBottomPanel_1.BackColor = System.Drawing.Color.Black;
            this.RightBottomPanel_1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.RightBottomPanel_1.Location = new System.Drawing.Point(878, 509);
            this.RightBottomPanel_1.Name = "RightBottomPanel_1";
            this.RightBottomPanel_1.Size = new System.Drawing.Size(19, 2);
            this.RightBottomPanel_1.TabIndex = 5;
            this.RightBottomPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseDown);
            this.RightBottomPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseMove);
            this.RightBottomPanel_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.shapedButton2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.droppedMessageTextbox);
            this.panel2.Controls.Add(this.shapedButton1);
            this.panel2.Controls.Add(this.sleepCheckBox);
            this.panel2.Controls.Add(this.SleepTextBox);
            this.panel2.Controls.Add(this.selectIconLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.startupcheckBox3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.spreadNameText);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.usbSpreadCheckBox);
            this.panel2.Controls.Add(this.shapedButton4);
            this.panel2.Controls.Add(this.shapedButton3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 146);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // shapedButton2
            // 
            this.shapedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shapedButton2.BackColor = System.Drawing.Color.Transparent;
            this.shapedButton2.BorderColor = System.Drawing.Color.Transparent;
            this.shapedButton2.BorderWidth = 2;
            this.shapedButton2.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.shapedButton2.ButtonText = "FileExtensions";
            this.shapedButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shapedButton2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shapedButton2.FlatAppearance.BorderSize = 0;
            this.shapedButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shapedButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shapedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shapedButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapedButton2.ForeColor = System.Drawing.Color.White;
            this.shapedButton2.GradientAngle = 90;
            this.shapedButton2.Location = new System.Drawing.Point(0, 82);
            this.shapedButton2.MouseClickColor1 = System.Drawing.Color.Black;
            this.shapedButton2.MouseClickColor2 = System.Drawing.Color.Black;
            this.shapedButton2.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.shapedButton2.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.shapedButton2.Name = "shapedButton2";
            this.shapedButton2.ShowButtontext = true;
            this.shapedButton2.Size = new System.Drawing.Size(166, 55);
            this.shapedButton2.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shapedButton2.TabIndex = 27;
            this.shapedButton2.TextLocation_X = 30;
            this.shapedButton2.TextLocation_Y = 19;
            this.shapedButton2.Transparent1 = 250;
            this.shapedButton2.Transparent2 = 250;
            this.shapedButton2.UseVisualStyleBackColor = false;
            this.shapedButton2.Click += new System.EventHandler(this.shapedButton2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dropped File Name";
            // 
            // droppedMessageTextbox
            // 
            this.droppedMessageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.droppedMessageTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.droppedMessageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.droppedMessageTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.droppedMessageTextbox.Location = new System.Drawing.Point(525, 40);
            this.droppedMessageTextbox.Name = "droppedMessageTextbox";
            this.droppedMessageTextbox.Size = new System.Drawing.Size(143, 22);
            this.droppedMessageTextbox.TabIndex = 25;
            this.droppedMessageTextbox.Text = "read_it.txt";
            this.droppedMessageTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shapedButton1
            // 
            this.shapedButton1.BackColor = System.Drawing.Color.Transparent;
            this.shapedButton1.BorderColor = System.Drawing.Color.Transparent;
            this.shapedButton1.BorderWidth = 2;
            this.shapedButton1.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.shapedButton1.ButtonText = "Advanced Options";
            this.shapedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shapedButton1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shapedButton1.FlatAppearance.BorderSize = 0;
            this.shapedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shapedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shapedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shapedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapedButton1.ForeColor = System.Drawing.Color.White;
            this.shapedButton1.GradientAngle = 80;
            this.shapedButton1.Location = new System.Drawing.Point(175, 82);
            this.shapedButton1.MouseClickColor1 = System.Drawing.Color.Black;
            this.shapedButton1.MouseClickColor2 = System.Drawing.Color.Black;
            this.shapedButton1.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.shapedButton1.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.shapedButton1.Name = "shapedButton1";
            this.shapedButton1.ShowButtontext = true;
            this.shapedButton1.Size = new System.Drawing.Size(166, 55);
            this.shapedButton1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shapedButton1.TabIndex = 23;
            this.shapedButton1.TextLocation_X = 16;
            this.shapedButton1.TextLocation_Y = 20;
            this.shapedButton1.Transparent1 = 200;
            this.shapedButton1.Transparent2 = 200;
            this.shapedButton1.UseVisualStyleBackColor = false;
            this.shapedButton1.Click += new System.EventHandler(this.shapedButton1_Click);
            // 
            // sleepCheckBox
            // 
            this.sleepCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sleepCheckBox.AutoSize = true;
            this.sleepCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sleepCheckBox.Location = new System.Drawing.Point(359, 81);
            this.sleepCheckBox.Name = "sleepCheckBox";
            this.sleepCheckBox.Size = new System.Drawing.Size(91, 17);
            this.sleepCheckBox.TabIndex = 22;
            this.sleepCheckBox.Text = "Delay second";
            this.sleepCheckBox.UseVisualStyleBackColor = true;
            this.sleepCheckBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // SleepTextBox
            // 
            this.SleepTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SleepTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SleepTextBox.Enabled = false;
            this.SleepTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SleepTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.SleepTextBox.Location = new System.Drawing.Point(359, 107);
            this.SleepTextBox.Name = "SleepTextBox";
            this.SleepTextBox.Size = new System.Drawing.Size(91, 22);
            this.SleepTextBox.TabIndex = 21;
            this.SleepTextBox.Text = "10";
            this.SleepTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SleepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SleepTextBox_KeyPress_1);
            // 
            // selectIconLabel
            // 
            this.selectIconLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectIconLabel.AutoSize = true;
            this.selectIconLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectIconLabel.Location = new System.Drawing.Point(593, 93);
            this.selectIconLabel.Name = "selectIconLabel";
            this.selectIconLabel.Size = new System.Drawing.Size(61, 13);
            this.selectIconLabel.TabIndex = 20;
            this.selectIconLabel.Text = "Select Icon";
            this.selectIconLabel.Click += new System.EventHandler(this.selectIconLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(579, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // startupcheckBox3
            // 
            this.startupcheckBox3.AutoSize = true;
            this.startupcheckBox3.Checked = true;
            this.startupcheckBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startupcheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startupcheckBox3.Location = new System.Drawing.Point(470, 82);
            this.startupcheckBox3.Name = "startupcheckBox3";
            this.startupcheckBox3.Size = new System.Drawing.Size(92, 17);
            this.startupcheckBox3.TabIndex = 15;
            this.startupcheckBox3.Text = "Add to startup";
            this.startupcheckBox3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(359, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 22);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "svchost.exe";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(359, 17);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Proccess Name:";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // spreadNameText
            // 
            this.spreadNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.spreadNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spreadNameText.ForeColor = System.Drawing.SystemColors.Window;
            this.spreadNameText.Location = new System.Drawing.Point(190, 40);
            this.spreadNameText.Name = "spreadNameText";
            this.spreadNameText.Size = new System.Drawing.Size(143, 22);
            this.spreadNameText.TabIndex = 12;
            this.spreadNameText.Text = "surprise";
            this.spreadNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(20, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Randomize file extension:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(20, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "encrypted";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usbSpreadCheckBox
            // 
            this.usbSpreadCheckBox.AutoSize = true;
            this.usbSpreadCheckBox.Checked = true;
            this.usbSpreadCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.usbSpreadCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usbSpreadCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usbSpreadCheckBox.Location = new System.Drawing.Point(193, 14);
            this.usbSpreadCheckBox.Name = "usbSpreadCheckBox";
            this.usbSpreadCheckBox.Size = new System.Drawing.Size(145, 17);
            this.usbSpreadCheckBox.TabIndex = 9;
            this.usbSpreadCheckBox.Text = "Usb and network spread:";
            this.usbSpreadCheckBox.UseVisualStyleBackColor = true;
            this.usbSpreadCheckBox.CheckedChanged += new System.EventHandler(this.usbSpreadCheckBox_CheckedChanged);
            // 
            // shapedButton4
            // 
            this.shapedButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shapedButton4.BackColor = System.Drawing.Color.Transparent;
            this.shapedButton4.BorderColor = System.Drawing.Color.Transparent;
            this.shapedButton4.BorderWidth = 2;
            this.shapedButton4.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.shapedButton4.ButtonText = "Build ";
            this.shapedButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shapedButton4.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shapedButton4.FlatAppearance.BorderSize = 0;
            this.shapedButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shapedButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shapedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shapedButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapedButton4.ForeColor = System.Drawing.Color.White;
            this.shapedButton4.GradientAngle = 90;
            this.shapedButton4.Location = new System.Drawing.Point(699, 79);
            this.shapedButton4.MouseClickColor1 = System.Drawing.Color.Black;
            this.shapedButton4.MouseClickColor2 = System.Drawing.Color.Black;
            this.shapedButton4.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.shapedButton4.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.shapedButton4.Name = "shapedButton4";
            this.shapedButton4.ShowButtontext = true;
            this.shapedButton4.Size = new System.Drawing.Size(136, 55);
            this.shapedButton4.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shapedButton4.TabIndex = 8;
            this.shapedButton4.TextLocation_X = 46;
            this.shapedButton4.TextLocation_Y = 18;
            this.shapedButton4.Transparent1 = 250;
            this.shapedButton4.Transparent2 = 250;
            this.shapedButton4.UseVisualStyleBackColor = false;
            this.shapedButton4.Click += new System.EventHandler(this.shapedButton4_Click);
            // 
            // shapedButton3
            // 
            this.shapedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shapedButton3.BackColor = System.Drawing.Color.Transparent;
            this.shapedButton3.BorderColor = System.Drawing.Color.Transparent;
            this.shapedButton3.BorderWidth = 2;
            this.shapedButton3.ButtonShape = CustomWindowsForm.ShapedButton.ButtonsShapes.RoundRect;
            this.shapedButton3.ButtonText = "About";
            this.shapedButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shapedButton3.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shapedButton3.FlatAppearance.BorderSize = 0;
            this.shapedButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shapedButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shapedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shapedButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapedButton3.ForeColor = System.Drawing.Color.White;
            this.shapedButton3.GradientAngle = 90;
            this.shapedButton3.Location = new System.Drawing.Point(699, 18);
            this.shapedButton3.MouseClickColor1 = System.Drawing.Color.Black;
            this.shapedButton3.MouseClickColor2 = System.Drawing.Color.Black;
            this.shapedButton3.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.shapedButton3.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.shapedButton3.Name = "shapedButton3";
            this.shapedButton3.ShowButtontext = true;
            this.shapedButton3.Size = new System.Drawing.Size(136, 55);
            this.shapedButton3.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shapedButton3.TabIndex = 7;
            this.shapedButton3.TextLocation_X = 45;
            this.shapedButton3.TextLocation_Y = 18;
            this.shapedButton3.Transparent1 = 250;
            this.shapedButton3.Transparent2 = 250;
            this.shapedButton3.UseVisualStyleBackColor = false;
            this.shapedButton3.Click += new System.EventHandler(this.shapedButton3_Click);
            // 
            // RightBottomPanel_2
            // 
            this.RightBottomPanel_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RightBottomPanel_2.BackColor = System.Drawing.Color.Black;
            this.RightBottomPanel_2.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.RightBottomPanel_2.Location = new System.Drawing.Point(896, 490);
            this.RightBottomPanel_2.Name = "RightBottomPanel_2";
            this.RightBottomPanel_2.Size = new System.Drawing.Size(2, 19);
            this.RightBottomPanel_2.TabIndex = 9;
            this.RightBottomPanel_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_2_MouseDown);
            this.RightBottomPanel_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_2_MouseMove);
            this.RightBottomPanel_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_2_MouseUp);
            // 
            // LeftBottomPanel_2
            // 
            this.LeftBottomPanel_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftBottomPanel_2.BackColor = System.Drawing.Color.Black;
            this.LeftBottomPanel_2.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.LeftBottomPanel_2.Location = new System.Drawing.Point(0, 491);
            this.LeftBottomPanel_2.Name = "LeftBottomPanel_2";
            this.LeftBottomPanel_2.Size = new System.Drawing.Size(2, 19);
            this.LeftBottomPanel_2.TabIndex = 11;
            this.LeftBottomPanel_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_2_MouseDown);
            this.LeftBottomPanel_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_2_MouseMove);
            this.LeftBottomPanel_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_2_MouseUp);
            // 
            // RightTopPanel_1
            // 
            this.RightTopPanel_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightTopPanel_1.BackColor = System.Drawing.Color.Black;
            this.RightTopPanel_1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.RightTopPanel_1.Location = new System.Drawing.Point(896, 2);
            this.RightTopPanel_1.Name = "RightTopPanel_1";
            this.RightTopPanel_1.Size = new System.Drawing.Size(2, 20);
            this.RightTopPanel_1.TabIndex = 12;
            this.RightTopPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseDown);
            this.RightTopPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseMove);
            this.RightTopPanel_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseUp);
            // 
            // RightTopPanel_2
            // 
            this.RightTopPanel_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightTopPanel_2.BackColor = System.Drawing.Color.Black;
            this.RightTopPanel_2.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.RightTopPanel_2.Location = new System.Drawing.Point(878, 0);
            this.RightTopPanel_2.Name = "RightTopPanel_2";
            this.RightTopPanel_2.Size = new System.Drawing.Size(20, 2);
            this.RightTopPanel_2.TabIndex = 13;
            this.RightTopPanel_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_2_MouseDown);
            this.RightTopPanel_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_2_MouseMove);
            this.RightTopPanel_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_2_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(833, 312);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BlackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(847, 544);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RightTopPanel_2);
            this.Controls.Add(this.RightTopPanel_1);
            this.Controls.Add(this.LeftBottomPanel_2);
            this.Controls.Add(this.RightBottomPanel_2);
            this.Controls.Add(this.RightBottomPanel_1);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(847, 544);
            this.Name = "BlackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ryuk Ransomware";
            this.Load += new System.EventHandler(this.BlackForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000025 RID: 37
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Panel RightPanel;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Panel TopPanel;

		// Token: 0x04000028 RID: 40
		private global::CustomWindowsForm.ButtonZ _CloseButton;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Panel RightBottomPanel_1;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label WindowTextLabel;

		// Token: 0x0400002B RID: 43
		private global::CustomWindowsForm.MinMaxButton _MaxButton;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400002D RID: 45
		private global::CustomWindowsForm.ButtonZ _MinButton;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Panel RightBottomPanel_2;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Panel LeftBottomPanel_2;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Panel RightTopPanel_1;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Panel RightTopPanel_2;

		// Token: 0x04000032 RID: 50
		private global::CustomWindowsForm.ShapedButton shapedButton4;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.CheckBox usbSpreadCheckBox;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000035 RID: 53
		private global::CustomWindowsForm.ShapedButton shapedButton3;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog1;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.TextBox spreadNameText;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.CheckBox startupcheckBox3;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label selectIconLabel;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.CheckBox sleepCheckBox;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.TextBox SleepTextBox;

		// Token: 0x04000042 RID: 66
		private global::CustomWindowsForm.ShapedButton shapedButton1;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.TextBox droppedMessageTextbox;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000045 RID: 69
		private global::CustomWindowsForm.ShapedButton shapedButton2;
	}
}
