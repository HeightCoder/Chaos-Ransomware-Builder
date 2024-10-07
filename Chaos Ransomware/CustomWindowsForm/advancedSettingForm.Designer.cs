namespace Ryuk.Net
{
	// Token: 0x02000002 RID: 2
	public partial class advancedSettingForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002A58 File Offset: 0x00000C58
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002A90 File Offset: 0x00000C90
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(advancedSettingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.taskManager = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pathToImageText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pathToXmlLabel = new System.Windows.Forms.Label();
            this.overwriteInfoLabel = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZ1 = new CustomWindowsForm.ButtonZ();
            this.deleteBackupCatalogCheckbox = new System.Windows.Forms.CheckBox();
            this.disableRecoveryModeCheckbox = new System.Windows.Forms.CheckBox();
            this.deleteShadowCopiesCheckbox = new System.Windows.Forms.CheckBox();
            this.resistAdminCheckbox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.taskManager);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pathToImageText);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pathToXmlLabel);
            this.panel1.Controls.Add(this.overwriteInfoLabel);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonZ1);
            this.panel1.Controls.Add(this.deleteBackupCatalogCheckbox);
            this.panel1.Controls.Add(this.disableRecoveryModeCheckbox);
            this.panel1.Controls.Add(this.deleteShadowCopiesCheckbox);
            this.panel1.Controls.Add(this.resistAdminCheckbox);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 415);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // taskManager
            // 
            this.taskManager.AutoSize = true;
            this.taskManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskManager.Enabled = false;
            this.taskManager.ForeColor = System.Drawing.Color.White;
            this.taskManager.Location = new System.Drawing.Point(70, 189);
            this.taskManager.Name = "taskManager";
            this.taskManager.Size = new System.Drawing.Size(128, 17);
            this.taskManager.TabIndex = 34;
            this.taskManager.Text = "Disable task manager";
            this.taskManager.UseVisualStyleBackColor = true;
            this.taskManager.CheckedChanged += new System.EventHandler(this.taskManager_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Change desktop wallpaper";
            // 
            // pathToImageText
            // 
            this.pathToImageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pathToImageText.ForeColor = System.Drawing.Color.White;
            this.pathToImageText.Location = new System.Drawing.Point(21, 250);
            this.pathToImageText.Name = "pathToImageText";
            this.pathToImageText.Size = new System.Drawing.Size(205, 20);
            this.pathToImageText.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(232, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 26);
            this.button1.TabIndex = 31;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Decrypter Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(21, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(206, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 26);
            this.button2.TabIndex = 28;
            this.button2.Text = "Create Decrypter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pathToXmlLabel
            // 
            this.pathToXmlLabel.AutoSize = true;
            this.pathToXmlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathToXmlLabel.ForeColor = System.Drawing.Color.White;
            this.pathToXmlLabel.Location = new System.Drawing.Point(24, 355);
            this.pathToXmlLabel.Name = "pathToXmlLabel";
            this.pathToXmlLabel.Size = new System.Drawing.Size(0, 16);
            this.pathToXmlLabel.TabIndex = 26;
            this.pathToXmlLabel.Click += new System.EventHandler(this.pathToXmlLabel_Click);
            // 
            // overwriteInfoLabel
            // 
            this.overwriteInfoLabel.AutoSize = true;
            this.overwriteInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overwriteInfoLabel.ForeColor = System.Drawing.Color.White;
            this.overwriteInfoLabel.Location = new System.Drawing.Point(22, 331);
            this.overwriteInfoLabel.Name = "overwriteInfoLabel";
            this.overwriteInfoLabel.Size = new System.Drawing.Size(275, 16);
            this.overwriteInfoLabel.TabIndex = 24;
            this.overwriteInfoLabel.Text = "Files will be encrypted with AES/RSA method";
            this.overwriteInfoLabel.Click += new System.EventHandler(this.overwriteInfoLabel_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(206, 296);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(142, 20);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Encrypt  AES / RSA";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(30, 296);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 20);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.Text = "Overwrite all files";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Advanced Options";
            // 
            // buttonZ1
            // 
            this.buttonZ1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZ1.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonZ1.DisplayText = "X";
            this.buttonZ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ1.ForeColor = System.Drawing.Color.White;
            this.buttonZ1.Location = new System.Drawing.Point(318, 0);
            this.buttonZ1.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this.buttonZ1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonZ1.Name = "buttonZ1";
            this.buttonZ1.Size = new System.Drawing.Size(31, 24);
            this.buttonZ1.TabIndex = 20;
            this.buttonZ1.Text = "X";
            this.buttonZ1.TextLocation_X = 6;
            this.buttonZ1.TextLocation_Y = 1;
            this.buttonZ1.UseVisualStyleBackColor = true;
            this.buttonZ1.Click += new System.EventHandler(this.buttonZ1_Click_1);
            // 
            // deleteBackupCatalogCheckbox
            // 
            this.deleteBackupCatalogCheckbox.AutoSize = true;
            this.deleteBackupCatalogCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBackupCatalogCheckbox.Enabled = false;
            this.deleteBackupCatalogCheckbox.ForeColor = System.Drawing.Color.White;
            this.deleteBackupCatalogCheckbox.Location = new System.Drawing.Point(70, 120);
            this.deleteBackupCatalogCheckbox.Name = "deleteBackupCatalogCheckbox";
            this.deleteBackupCatalogCheckbox.Size = new System.Drawing.Size(152, 17);
            this.deleteBackupCatalogCheckbox.TabIndex = 19;
            this.deleteBackupCatalogCheckbox.Text = "Delete the backup catalog";
            this.deleteBackupCatalogCheckbox.UseVisualStyleBackColor = true;
            this.deleteBackupCatalogCheckbox.CheckedChanged += new System.EventHandler(this.deleteBackupCatalogCheckbox_CheckedChanged);
            // 
            // disableRecoveryModeCheckbox
            // 
            this.disableRecoveryModeCheckbox.AutoSize = true;
            this.disableRecoveryModeCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disableRecoveryModeCheckbox.Enabled = false;
            this.disableRecoveryModeCheckbox.ForeColor = System.Drawing.Color.White;
            this.disableRecoveryModeCheckbox.Location = new System.Drawing.Point(70, 155);
            this.disableRecoveryModeCheckbox.Name = "disableRecoveryModeCheckbox";
            this.disableRecoveryModeCheckbox.Size = new System.Drawing.Size(178, 17);
            this.disableRecoveryModeCheckbox.TabIndex = 18;
            this.disableRecoveryModeCheckbox.Text = "Disable windows recovery mode";
            this.disableRecoveryModeCheckbox.UseVisualStyleBackColor = true;
            this.disableRecoveryModeCheckbox.CheckedChanged += new System.EventHandler(this.disableRecoveryModeCheckbox_CheckedChanged);
            // 
            // deleteShadowCopiesCheckbox
            // 
            this.deleteShadowCopiesCheckbox.AutoSize = true;
            this.deleteShadowCopiesCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteShadowCopiesCheckbox.Enabled = false;
            this.deleteShadowCopiesCheckbox.ForeColor = System.Drawing.Color.White;
            this.deleteShadowCopiesCheckbox.Location = new System.Drawing.Point(70, 84);
            this.deleteShadowCopiesCheckbox.Name = "deleteShadowCopiesCheckbox";
            this.deleteShadowCopiesCheckbox.Size = new System.Drawing.Size(190, 17);
            this.deleteShadowCopiesCheckbox.TabIndex = 17;
            this.deleteShadowCopiesCheckbox.Text = "Delete all Volumes Shadow Copies";
            this.deleteShadowCopiesCheckbox.UseVisualStyleBackColor = true;
            this.deleteShadowCopiesCheckbox.CheckedChanged += new System.EventHandler(this.deleteShadowCopiesCheckbox_CheckedChanged);
            // 
            // resistAdminCheckbox
            // 
            this.resistAdminCheckbox.AutoSize = true;
            this.resistAdminCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resistAdminCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resistAdminCheckbox.ForeColor = System.Drawing.Color.White;
            this.resistAdminCheckbox.Location = new System.Drawing.Point(57, 52);
            this.resistAdminCheckbox.Name = "resistAdminCheckbox";
            this.resistAdminCheckbox.Size = new System.Drawing.Size(212, 20);
            this.resistAdminCheckbox.TabIndex = 16;
            this.resistAdminCheckbox.Text = "Resist for admin privileges";
            this.resistAdminCheckbox.UseVisualStyleBackColor = true;
            this.resistAdminCheckbox.CheckedChanged += new System.EventHandler(this.resistAdminCheckbox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // advancedSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(356, 419);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "advancedSettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "advancedSettingForm";
            this.Load += new System.EventHandler(this.advancedSettingForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.advancedSettingForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.advancedSettingForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.advancedSettingForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000005 RID: 5
		private global::CustomWindowsForm.ButtonZ buttonZ1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.CheckBox deleteBackupCatalogCheckbox;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.CheckBox disableRecoveryModeCheckbox;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.CheckBox deleteShadowCopiesCheckbox;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.CheckBox resistAdminCheckbox;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label pathToXmlLabel;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.TextBox pathToImageText;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.RadioButton radioButton2;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.RadioButton radioButton1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label overwriteInfoLabel;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.CheckBox taskManager;
	}
}
