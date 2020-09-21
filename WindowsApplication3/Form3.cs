using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
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
	public class Form3 : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser _WebBrowser1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

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
				Form3 form3 = this;
				EventHandler eventHandler = new EventHandler(form3.Button1_Click);
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
		static Form3()
		{
			Form3.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public Form3()
		{
			Form3 form3 = this;
			base.FormClosing += new FormClosingEventHandler(form3.Form3_FormClosing);
			Form3 form31 = this;
			base.Load += new EventHandler(form31.Form3_Load);
			Form3.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form3.__ENCList;
			bool flag = false;
			try
			{
				Monitor.Enter(_ENCList, ref flag);
				if (Form3.__ENCList.Count == Form3.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(Form3.__ENCList.Count - 1);
					for (int i = 0; i <= count; i++)
					{
						if (Form3.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								Form3.__ENCList[item] = Form3.__ENCList[i];
							}
							item++;
						}
					}
					Form3.__ENCList.RemoveRange(item, checked(Form3.__ENCList.Count - item));
					Form3.__ENCList.Capacity = Form3.__ENCList.Count;
				}
				Form3.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
			MyProject.Forms.Form4.Show();
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

		private void Form3_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				MyProject.Forms.Form2.Close();
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			Interaction.MsgBox("Please make sure you are logged into FanSlave, then press next.", MsgBoxStyle.OkOnly, null);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
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
			size = new Size(1004, 798);
			webBrowser11.Size = size;
			this.WebBrowser1.TabIndex = 0;
			this.WebBrowser1.Url = new Uri("http://www.fanslave.com/?ref=22144", UriKind.Absolute);
			Button button1 = this.Button1;
			point = new Point(0, 0);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			size = new Size(71, 38);
			button.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Next";
			this.Button1.UseVisualStyleBackColor = true;
			SizeF sizeF = new SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new Size(1004, 798);
			this.ClientSize = size;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.WebBrowser1);
			//this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Form3";
			this.Text = "FanSlave Check";
			this.ResumeLayout(false);
		}
	}
}