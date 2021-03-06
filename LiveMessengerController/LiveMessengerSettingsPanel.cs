﻿namespace CherryTomato.LiveMessengerController
{
    partial class LiveMessengerSettingsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiveMessengerSettingsPanel));
            this.msnGroupBox = new System.Windows.Forms.GroupBox();
            this.hintLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.statusTextEditBox = new System.Windows.Forms.TextBox();
            this.statusTextLabel = new System.Windows.Forms.Label();
            this.enabledCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msnGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // msnGroupBox
            // 
            this.msnGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.msnGroupBox.Controls.Add(this.label1);
            this.msnGroupBox.Controls.Add(this.hintLabel);
            this.msnGroupBox.Controls.Add(this.connectButton);
            this.msnGroupBox.Controls.Add(this.connectionStatusLabel);
            this.msnGroupBox.Controls.Add(this.logoPictureBox);
            this.msnGroupBox.Controls.Add(this.statusTextEditBox);
            this.msnGroupBox.Controls.Add(this.statusTextLabel);
            this.msnGroupBox.Controls.Add(this.enabledCheckBox);
            this.msnGroupBox.Location = new System.Drawing.Point(4, 4);
            this.msnGroupBox.Name = "msnGroupBox";
            this.msnGroupBox.Size = new System.Drawing.Size(347, 207);
            this.msnGroupBox.TabIndex = 0;
            this.msnGroupBox.TabStop = false;
            this.msnGroupBox.Text = "Live Messenger";
            // 
            // hintLabel
            // 
            this.hintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hintLabel.AutoSize = true;
            this.hintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.hintLabel.Location = new System.Drawing.Point(124, 188);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(217, 13);
            this.hintLabel.TabIndex = 5;
            this.hintLabel.Text = "Type {0} as a placeholder for minute counter";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(7, 97);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "&Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(7, 81);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(95, 13);
            this.connectionStatusLabel.TabIndex = 1;
            this.connectionStatusLabel.Text = "Connection status:";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.InitialImage")));
            this.logoPictureBox.Location = new System.Drawing.Point(234, 17);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // statusTextEditBox
            // 
            this.statusTextEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTextEditBox.Location = new System.Drawing.Point(7, 155);
            this.statusTextEditBox.Multiline = true;
            this.statusTextEditBox.Name = "statusTextEditBox";
            this.statusTextEditBox.Size = new System.Drawing.Size(334, 31);
            this.statusTextEditBox.TabIndex = 4;
            this.statusTextEditBox.TextChanged += new System.EventHandler(this.statusTextEditBox_TextChanged);
            // 
            // statusTextLabel
            // 
            this.statusTextLabel.AutoSize = true;
            this.statusTextLabel.Location = new System.Drawing.Point(7, 139);
            this.statusTextLabel.Name = "statusTextLabel";
            this.statusTextLabel.Size = new System.Drawing.Size(121, 13);
            this.statusTextLabel.TabIndex = 3;
            this.statusTextLabel.Text = "I&n-Pomodoro status text:";
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Location = new System.Drawing.Point(7, 20);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.Size = new System.Drawing.Size(171, 17);
            this.enabledCheckBox.TabIndex = 0;
            this.enabledCheckBox.Text = "&Indicate when I\'m in Pomodoro";
            this.enabledCheckBox.UseVisualStyleBackColor = true;
            this.enabledCheckBox.CheckedChanged += new System.EventHandler(this.enabledCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enable \"Show what I\'m listening to\"\r\nfor this feature to work";
            // 
            // LiveMessengerSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.msnGroupBox);
            this.Name = "LiveMessengerSettingsPanel";
            this.Size = new System.Drawing.Size(354, 214);
            this.msnGroupBox.ResumeLayout(false);
            this.msnGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox msnGroupBox;
        private System.Windows.Forms.TextBox statusTextEditBox;
        private System.Windows.Forms.Label statusTextLabel;
        private System.Windows.Forms.CheckBox enabledCheckBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Label hintLabel;

    }
}
