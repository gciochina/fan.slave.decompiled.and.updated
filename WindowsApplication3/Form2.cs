using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using WindowsApplication3.My;

namespace WindowsApplication3
{
	public class Form2 : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser _WebBrowser1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		private string codename;

		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			set
			{
				Form2 form2 = this;
				EventHandler eventHandler = new EventHandler(form2.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= eventHandler;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += eventHandler;
				}
			}
		}

		internal virtual WebBrowser WebBrowser1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WebBrowser1;
			}
			[DebuggerNonUserCode]
			set
			{
				this._WebBrowser1 = value;
			}
		}

		[DebuggerNonUserCode]
		static Form2()
		{
			Form2.__ENCList = new List<WeakReference>();
		}

		public Form2()
		{
			Form2 form2 = this;
			base.Load += new EventHandler(form2.Form2_Load);
			Form2 form21 = this;
			base.FormClosing += new FormClosingEventHandler(form21.Form2_FormClosing);
			Form2.__ENCAddToList(this);
			this.codename = "simon";
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form2.__ENCList;
			bool flag = false;
			try
			{
				Monitor.Enter(_ENCList, ref flag);
				if (Form2.__ENCList.Count == Form2.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(Form2.__ENCList.Count - 1);
					for (int i = 0; i <= count; i++)
					{
						if (Form2.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								Form2.__ENCList[item] = Form2.__ENCList[i];
							}
							item++;
						}
					}
					Form2.__ENCList.RemoveRange(item, checked(Form2.__ENCList.Count - item));
					Form2.__ENCList.Capacity = Form2.__ENCList.Count;
				}
				Form2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(_ENCList);
				}
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			MyProject.Forms.Form3.Show();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if ((!disposing || this.components == null ? false : true))
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			try
			{
				MyProject.Computer.Network.DownloadFile("http://craft-com.net/software/fanslave/version", "version");
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(Strings.Split(MyProject.Computer.FileSystem.ReadAllText("version"), ",", -1, CompareMethod.Binary)[0], this.codename, false) != 0)
			{
				Interaction.MsgBox("Press ok to update.", MsgBoxStyle.OkOnly, null);
				MyProject.Computer.FileSystem.WriteAllText("version", string.Concat(",", Application.ExecutablePath), true);
				MyProject.Computer.Network.DownloadFile("http://www.craft-com.net/software/updater/updater.exe", "update.exe");
				Interaction.Shell("update.exe", AppWinStyle.MinimizedFocus, false, -1);
				this.Close();
			}
			else
			{
				MyProject.Computer.FileSystem.DeleteFile("version");
				Interaction.MsgBox("please make sure you are logged into facebook, then press next", MsgBoxStyle.OkOnly, null);
			}
			try
			{
				MyProject.Computer.FileSystem.DeleteFile("version");
				MyProject.Computer.FileSystem.DeleteFile("update.exe");
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				ProjectData.ClearProjectError();
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
			this.WebBrowser1 = new WebBrowser();
			this.Button1 = new Button();
			this.SuspendLayout();
			this.WebBrowser1.Dock = DockStyle.Fill;
			WebBrowser webBrowser1 = this.WebBrowser1;
			Point point = new Point(0, 0);
			webBrowser1.Location = point;
			WebBrowser webBrowser = this.WebBrowser1;
			Size size = new Size(20, 20);
			webBrowser.MinimumSize = size;
			this.WebBrowser1.Name = "WebBrowser1";
			WebBrowser webBrowser11 = this.WebBrowser1;
			size = new Size(1041, 825);
			webBrowser11.Size = size;
			this.WebBrowser1.TabIndex = 0;
			this.WebBrowser1.Url = new Uri("http://facebook.com", UriKind.Absolute);
			Button button1 = this.Button1;
			point = new Point(0, 0);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			size = new Size(86, 46);
			button.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Next";
			this.Button1.UseVisualStyleBackColor = true;
			SizeF sizeF = new SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new Size(1041, 825);
			this.ClientSize = size;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.WebBrowser1);
			//this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Form2";
			this.Text = "Facebook Check";
			this.ResumeLayout(false);
		}
	}
}