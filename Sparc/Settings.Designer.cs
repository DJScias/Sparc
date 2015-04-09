﻿namespace Sparc
{
    partial class Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stAutoRefresh = new System.Windows.Forms.CheckBox();
            this.stSaveLogs = new System.Windows.Forms.CheckBox();
            this.stName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stflashOnCall = new System.Windows.Forms.CheckBox();
            this.sthlName = new System.Windows.Forms.CheckBox();
            this.sthlAdmin = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stqbTime = new System.Windows.Forms.NumericUpDown();
            this.stqbReason = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stShowBanLength = new System.Windows.Forms.CheckBox();
            this.stShowAdminBan = new System.Windows.Forms.CheckBox();
            this.stShowAdminKick = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sparcVersion = new System.Windows.Forms.Label();
            this.sparcTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stqbTime)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stAutoRefresh);
            this.groupBox1.Controls.Add(this.stSaveLogs);
            this.groupBox1.Controls.Add(this.stName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // stAutoRefresh
            // 
            this.stAutoRefresh.AutoSize = true;
            this.stAutoRefresh.Location = new System.Drawing.Point(6, 58);
            this.stAutoRefresh.Name = "stAutoRefresh";
            this.stAutoRefresh.Size = new System.Drawing.Size(129, 17);
            this.stAutoRefresh.TabIndex = 6;
            this.stAutoRefresh.Text = "Auto refresh player list";
            this.stAutoRefresh.UseVisualStyleBackColor = true;
            // 
            // stSaveLogs
            // 
            this.stSaveLogs.AutoSize = true;
            this.stSaveLogs.Location = new System.Drawing.Point(6, 81);
            this.stSaveLogs.Name = "stSaveLogs";
            this.stSaveLogs.Size = new System.Drawing.Size(139, 17);
            this.stSaveLogs.TabIndex = 5;
            this.stSaveLogs.Text = "Save chat/console logs";
            this.stSaveLogs.UseVisualStyleBackColor = true;
            // 
            // stName
            // 
            this.stName.Location = new System.Drawing.Point(6, 32);
            this.stName.Name = "stName";
            this.stName.Size = new System.Drawing.Size(146, 20);
            this.stName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin name";
            // 
            // stflashOnCall
            // 
            this.stflashOnCall.AutoSize = true;
            this.stflashOnCall.Location = new System.Drawing.Point(6, 65);
            this.stflashOnCall.Name = "stflashOnCall";
            this.stflashOnCall.Size = new System.Drawing.Size(150, 17);
            this.stflashOnCall.TabIndex = 4;
            this.stflashOnCall.Text = "Flash window when called";
            this.stflashOnCall.UseVisualStyleBackColor = true;
            // 
            // sthlName
            // 
            this.sthlName.AutoSize = true;
            this.sthlName.Location = new System.Drawing.Point(6, 42);
            this.sthlName.Name = "sthlName";
            this.sthlName.Size = new System.Drawing.Size(150, 17);
            this.sthlName.TabIndex = 3;
            this.sthlName.Text = "Alert when called by name";
            this.sthlName.UseVisualStyleBackColor = true;
            // 
            // sthlAdmin
            // 
            this.sthlAdmin.AutoSize = true;
            this.sthlAdmin.Location = new System.Drawing.Point(6, 19);
            this.sthlAdmin.Name = "sthlAdmin";
            this.sthlAdmin.Size = new System.Drawing.Size(148, 17);
            this.sthlAdmin.TabIndex = 2;
            this.sthlAdmin.Text = "Alert when admin is called";
            this.sthlAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stqbTime);
            this.groupBox2.Controls.Add(this.stqbReason);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(176, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quick Ban";
            // 
            // stqbTime
            // 
            this.stqbTime.Location = new System.Drawing.Point(6, 32);
            this.stqbTime.Name = "stqbTime";
            this.stqbTime.Size = new System.Drawing.Size(146, 20);
            this.stqbTime.TabIndex = 4;
            this.stqbTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // stqbReason
            // 
            this.stqbReason.Location = new System.Drawing.Point(6, 80);
            this.stqbReason.Name = "stqbReason";
            this.stqbReason.Size = new System.Drawing.Size(146, 20);
            this.stqbReason.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ban reason";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ban time (minutes)";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(12, 221);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(276, 23);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stShowBanLength);
            this.groupBox3.Controls.Add(this.stShowAdminBan);
            this.groupBox3.Controls.Add(this.stShowAdminKick);
            this.groupBox3.Location = new System.Drawing.Point(176, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 87);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kick/Ban Messages";
            // 
            // stShowBanLength
            // 
            this.stShowBanLength.AutoSize = true;
            this.stShowBanLength.Location = new System.Drawing.Point(6, 65);
            this.stShowBanLength.Name = "stShowBanLength";
            this.stShowBanLength.Size = new System.Drawing.Size(106, 17);
            this.stShowBanLength.TabIndex = 2;
            this.stShowBanLength.Text = "Show ban length";
            this.stShowBanLength.UseVisualStyleBackColor = true;
            // 
            // stShowAdminBan
            // 
            this.stShowAdminBan.AutoSize = true;
            this.stShowAdminBan.Location = new System.Drawing.Point(6, 42);
            this.stShowAdminBan.Name = "stShowAdminBan";
            this.stShowAdminBan.Size = new System.Drawing.Size(149, 17);
            this.stShowAdminBan.TabIndex = 1;
            this.stShowAdminBan.Text = "Show admin name on ban";
            this.stShowAdminBan.UseVisualStyleBackColor = true;
            // 
            // stShowAdminKick
            // 
            this.stShowAdminKick.AutoSize = true;
            this.stShowAdminKick.Location = new System.Drawing.Point(6, 19);
            this.stShowAdminKick.Name = "stShowAdminKick";
            this.stShowAdminKick.Size = new System.Drawing.Size(151, 17);
            this.stShowAdminKick.TabIndex = 0;
            this.stShowAdminKick.Text = "Show admin name on kick";
            this.stShowAdminKick.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sthlAdmin);
            this.groupBox4.Controls.Add(this.sthlName);
            this.groupBox4.Controls.Add(this.stflashOnCall);
            this.groupBox4.Location = new System.Drawing.Point(12, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 87);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chat Settings";
            // 
            // sparcVersion
            // 
            this.sparcVersion.AutoSize = true;
            this.sparcVersion.Location = new System.Drawing.Point(294, 231);
            this.sparcVersion.Name = "sparcVersion";
            this.sparcVersion.Size = new System.Drawing.Size(37, 13);
            this.sparcVersion.TabIndex = 6;
            this.sparcVersion.Text = "v0.0.0";
            // 
            // sparcTitle
            // 
            this.sparcTitle.AutoSize = true;
            this.sparcTitle.Location = new System.Drawing.Point(293, 218);
            this.sparcTitle.Name = "sparcTitle";
            this.sparcTitle.Size = new System.Drawing.Size(35, 13);
            this.sparcTitle.TabIndex = 7;
            this.sparcTitle.Text = "Sparc";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 249);
            this.Controls.Add(this.sparcTitle);
            this.Controls.Add(this.sparcVersion);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stqbTime)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox stflashOnCall;
        private System.Windows.Forms.CheckBox sthlName;
        private System.Windows.Forms.CheckBox sthlAdmin;
        private System.Windows.Forms.TextBox stName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown stqbTime;
        private System.Windows.Forms.TextBox stqbReason;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.CheckBox stSaveLogs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox stShowBanLength;
        private System.Windows.Forms.CheckBox stShowAdminBan;
        private System.Windows.Forms.CheckBox stShowAdminKick;
        private System.Windows.Forms.CheckBox stAutoRefresh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label sparcVersion;
        private System.Windows.Forms.Label sparcTitle;
    }
}