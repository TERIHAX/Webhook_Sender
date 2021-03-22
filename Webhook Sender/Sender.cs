using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;

namespace Webhook_Sender
{
    public partial class Sender : Form
    {
		public Sender()
        {
            InitializeComponent();
        }

		Point p;

		protected override CreateParams CreateParams // This thing creates a shadow around the window to make it nice :P
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ClassStyle |= 0x00020000;
				return cp;
			}
		}

		private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Closes it.
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; // Minimizes it.
        }

        private async void sendBtn_Click(object sender, EventArgs e)
        {
			if (msgTextBox.Text != null || msgTextBox.Text != "" || msgTextBox.Text != " " || hookBox.Text != null || hookBox.Text != "" || hookBox.Text != " ")
			{
				try
				{
					using (var wc = new WebClient())
					{
						NameValueCollection nvc = new NameValueCollection();
						nvc["content"] = msgTextBox.Text;
						nvc["username"] = userBox.Text;
						nvc["avatar_url"] = avatarBox.Text;

						wc.UploadValues(hookBox.Text, nvc); // Send to the webhook.

						sendBtn.Text = "Sent Successfully!";
						await Task.Delay(3000);
						sendBtn.Text = "Send Webhook";
					}
				}
				catch
				{
					try
					{
						using (var hc = new HttpClient()) // Use the Http client in case if something fails when using the WebClient.
						{
							Dictionary<string, string> dict = new Dictionary<string, string>
							{
								{
									"content",
									string.Concat(new string[]
									{
										msgTextBox.Text
									})
								},
								{
									"username",
									userBox.Text
								},
								{
									"avatar_url",
									avatarBox.Text
								}
							};
							hc.PostAsync(hookBox.Text, new FormUrlEncodedContent(dict)).GetAwaiter().GetResult(); // Send the values.

							sendBtn.Text = "Sent Successfully!";
							await Task.Delay(3000);
							sendBtn.Text = "Send Webhook";
						}
					}
					catch
					{
						MessageBox.Show("You need to fill in the required fields! * = Required!", "Fill in Required Fields!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
			else
            {
				MessageBox.Show("You need to fill in the required fields! * = Required!", "Fill in Required Fields!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

        private void titleLbl_MouseDown(object sender, MouseEventArgs e)
        {
			p = new Point(e.X, e.Y); // This is for window dragging.
		}

		private void titleLbl_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Opacity = 0.8; // Make it transparent.
				Left += e.X - p.X; Top += e.Y - p.Y; // This is for window dragging.
			}
		}

		private void titleLbl_MouseUp(object sender, MouseEventArgs e)
		{
			Opacity = 100; // Make it non-transparent after the mouse is up.
		}

		private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
			p = new Point(e.X, e.Y); // This is for window dragging.
		}

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Left)
			{
				Opacity = 0.8; // Make it transparent.
				Left += e.X - p.X; Top += e.Y - p.Y; // This is for window dragging.
			}
		}

		private void topPanel_MouseUp(object sender, MouseEventArgs e)
		{
			Opacity = 100; // Make it non-transparent after the mouse stops dragging.
		}

		private void logoBox_MouseDown(object sender, MouseEventArgs e)
        {
			p = new Point(e.X, e.Y); // This is for window dragging.
		}

        private void logoBox_MouseMove(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Left)
			{
				Opacity = 0.8; // Make it transparent.
				Left += e.X - p.X; Top += e.Y - p.Y; // This is for window dragging.
			}
		}

		private void logoBox_MouseUp(object sender, MouseEventArgs e)
		{
			Opacity = 100; // Make it non-transparent after the mouse stops dragging.
		}        
    }
}
