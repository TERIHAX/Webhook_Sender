
namespace Webhook_Sender
{
    partial class Sender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sender));
            this.topPanel = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.minBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.userLbl = new System.Windows.Forms.Label();
            this.msgLbl = new System.Windows.Forms.Label();
            this.msgTextBox = new System.Windows.Forms.TextBox();
            this.hookLbl = new System.Windows.Forms.Label();
            this.hookBox = new System.Windows.Forms.TextBox();
            this.avatarLbl = new System.Windows.Forms.Label();
            this.avatarBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.topPanel.Controls.Add(this.titleLbl);
            this.topPanel.Controls.Add(this.minBtn);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Controls.Add(this.logoBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(488, 35);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.titleLbl.Location = new System.Drawing.Point(131, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(216, 20);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Webhook Sender by TERI#6116";
            this.titleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLbl_MouseDown);
            this.titleLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLbl_MouseMove);
            this.titleLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleLbl_MouseUp);
            // 
            // minBtn
            // 
            this.minBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.minBtn.Location = new System.Drawing.Point(418, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(35, 35);
            this.minBtn.TabIndex = 2;
            this.minBtn.Text = "—";
            this.minBtn.UseVisualStyleBackColor = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.closeBtn.Location = new System.Drawing.Point(453, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 35);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "╳";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImage = global::Webhook_Sender.Properties.Resources.icons8_attach_96px;
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(35, 35);
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            this.logoBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logoBox_MouseDown);
            this.logoBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logoBox_MouseMove);
            this.logoBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.logoBox_MouseUp);
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.userBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.userBox.ForeColor = System.Drawing.Color.White;
            this.userBox.Location = new System.Drawing.Point(95, 46);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(386, 29);
            this.userBox.TabIndex = 1;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.userLbl.Location = new System.Drawing.Point(11, 49);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(84, 21);
            this.userLbl.TabIndex = 4;
            this.userLbl.Text = "Username:";
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msgLbl.Location = new System.Drawing.Point(12, 84);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(85, 21);
            this.msgLbl.TabIndex = 6;
            this.msgLbl.Text = "Message: *";
            // 
            // msgTextBox
            // 
            this.msgTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.msgTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msgTextBox.ForeColor = System.Drawing.Color.White;
            this.msgTextBox.Location = new System.Drawing.Point(95, 81);
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.Size = new System.Drawing.Size(386, 29);
            this.msgTextBox.TabIndex = 5;
            // 
            // hookLbl
            // 
            this.hookLbl.AutoSize = true;
            this.hookLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hookLbl.Location = new System.Drawing.Point(9, 154);
            this.hookLbl.Name = "hookLbl";
            this.hookLbl.Size = new System.Drawing.Size(90, 21);
            this.hookLbl.TabIndex = 10;
            this.hookLbl.Text = "Webhook: *";
            // 
            // hookBox
            // 
            this.hookBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hookBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hookBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hookBox.ForeColor = System.Drawing.Color.White;
            this.hookBox.Location = new System.Drawing.Point(95, 151);
            this.hookBox.Name = "hookBox";
            this.hookBox.Size = new System.Drawing.Size(386, 29);
            this.hookBox.TabIndex = 9;
            // 
            // avatarLbl
            // 
            this.avatarLbl.AutoSize = true;
            this.avatarLbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.avatarLbl.Location = new System.Drawing.Point(11, 119);
            this.avatarLbl.Name = "avatarLbl";
            this.avatarLbl.Size = new System.Drawing.Size(58, 21);
            this.avatarLbl.TabIndex = 8;
            this.avatarLbl.Text = "Avatar:";
            // 
            // avatarBox
            // 
            this.avatarBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.avatarBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.avatarBox.ForeColor = System.Drawing.Color.White;
            this.avatarBox.Location = new System.Drawing.Point(95, 116);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(386, 29);
            this.avatarBox.TabIndex = 7;
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 10F);
            this.sendBtn.Location = new System.Drawing.Point(7, 187);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(474, 35);
            this.sendBtn.TabIndex = 11;
            this.sendBtn.Text = "Send Webhook";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // Sender
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(488, 230);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.hookBox);
            this.Controls.Add(this.avatarLbl);
            this.Controls.Add(this.avatarBox);
            this.Controls.Add(this.msgTextBox);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.hookLbl);
            this.Controls.Add(this.msgLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webhook Sender by TERI#6116";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.TextBox msgTextBox;
        private System.Windows.Forms.Label hookLbl;
        private System.Windows.Forms.TextBox hookBox;
        private System.Windows.Forms.Label avatarLbl;
        private System.Windows.Forms.TextBox avatarBox;
        private System.Windows.Forms.Button sendBtn;
    }
}

