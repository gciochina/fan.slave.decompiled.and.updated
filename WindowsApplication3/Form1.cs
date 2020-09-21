using Microsoft.VisualBasic;
using System.Linq;
using System.Data.Linq;
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
using Timer = System.Windows.Forms.Timer;

namespace WindowsApplication3
{
	public class Form1 : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		[AccessedThroughProperty("WebBrowser1")]
		private WebBrowser _WebBrowser1;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		[AccessedThroughProperty("lblstatus")]
		private Label _lblstatus;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Timer2")]
		private Timer _Timer2;

		private bool standby;

		private bool facebook;

		private int trying;

		private bool start;

		private int time1;

		private int time2;

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
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button1_Click);
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

		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= eventHandler;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button3;
			}
			[DebuggerNonUserCode]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Button3_Click);
				if (this._Button3 != null)
				{
					this._Button3.Click -= eventHandler;
				}
				this._Button3 = value;
				if (this._Button3 != null)
				{
					this._Button3.Click += eventHandler;
				}
			}
		}

		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			set
			{
				this._GroupBox1 = value;
			}
		}

		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			set
			{
				this._GroupBox2 = value;
			}
		}

		internal virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			set
			{
				this._GroupBox3 = value;
			}
		}

		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Label2 = value;
			}
		}

		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Label3 = value;
			}
		}

		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Label4 = value;
			}
		}

		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Label5 = value;
			}
		}

		internal virtual Label lblstatus
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblstatus;
			}
			[DebuggerNonUserCode]
			set
			{
				this._lblstatus = value;
			}
		}

		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			set
			{
				this._TextBox1 = value;
			}
		}

		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Timer1_Tick);
				if (this._Timer1 != null)
				{
					this._Timer1.Tick -= eventHandler;
				}
				this._Timer1 = value;
				if (this._Timer1 != null)
				{
					this._Timer1.Tick += eventHandler;
				}
			}
		}

		internal virtual Timer Timer2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer2;
			}
			[DebuggerNonUserCode]
			set
			{
				Form1 form1 = this;
				EventHandler eventHandler = new EventHandler(form1.Timer2_Tick);
				if (this._Timer2 != null)
				{
					this._Timer2.Tick -= eventHandler;
				}
				this._Timer2 = value;
				if (this._Timer2 != null)
				{
					this._Timer2.Tick += eventHandler;
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
				Form1 form1 = this;
				WebBrowserDocumentCompletedEventHandler webBrowserDocumentCompletedEventHandler = new WebBrowserDocumentCompletedEventHandler(form1.WebBrowser1_DocumentCompleted);
				if (this._WebBrowser1 != null)
				{
					this._WebBrowser1.DocumentCompleted -= webBrowserDocumentCompletedEventHandler;
				}
				this._WebBrowser1 = value;
				if (this._WebBrowser1 != null)
				{
					this._WebBrowser1.DocumentCompleted += webBrowserDocumentCompletedEventHandler;
				}
			}
		}

		[DebuggerNonUserCode]
		static Form1()
		{
			Form1.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public Form1()
		{
			Form1 form1 = this;
			base.FormClosing += new FormClosingEventHandler(form1.Form1_FormClosing);
			Form1 form11 = this;
			base.Load += new EventHandler(form11.Form1_Load);
			Form1.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form1.__ENCList;
			bool flag = false;
			try
			{
				Monitor.Enter(_ENCList, ref flag);
				if (Form1.__ENCList.Count == Form1.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(Form1.__ENCList.Count - 1);
					for (int i = 0; i <= count; i++)
					{
						if (Form1.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								Form1.__ENCList[item] = Form1.__ENCList[i];
							}
							item++;
						}
					}
					Form1.__ENCList.RemoveRange(item, checked(Form1.__ENCList.Count - item));
					Form1.__ENCList.Capacity = Form1.__ENCList.Count;
				}
				Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
			this.time1 = checked((int)Math.Round(Conversions.ToDouble(this.TextBox1.Text) * 1000));
			this.lblstatus.Text = "Status: Started.";
			this.Button1.Enabled = false;
			this.Button2.Enabled = true;
			this.Timer1.Enabled = true;
			this.start = true;
			this.trying = 0;
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.Timer2.Enabled = false;
			this.lblstatus.Text = "Status: Stopped.";
			this.Button1.Enabled = true;
			this.Button2.Enabled = false;
			this.start = false;
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			var settingsString = MyProject.Computer.FileSystem.ReadAllText("settings");
			if (Strings.Split(settingsString, ",", -1, CompareMethod.Binary).Length > 1 &&
				Operators.CompareString(Strings.Split(settingsString, ",", -1, CompareMethod.Binary)[1], "noupdate", false) != 0)
			{
				MyProject.Computer.FileSystem.WriteAllText("settings", this.TextBox1.Text, false);
			}
			else
			{
				MyProject.Computer.FileSystem.WriteAllText("settings", string.Concat(this.TextBox1.Text, ",noupdate"), false);
			}
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

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				string str = MyProject.Computer.FileSystem.ReadAllText("settings");
				this.TextBox1.Text = Strings.Split(str, ",", -1, CompareMethod.Binary)[0];
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.Button1 = new Button();
			this.Timer1 = new Timer(this.components);
			this.WebBrowser1 = new WebBrowser();
			this.Label1 = new Label();
			this.Button2 = new Button();
			this.Label2 = new Label();
			this.Label3 = new Label();
			this.TextBox1 = new TextBox();
			this.Label5 = new Label();
			this.Button3 = new Button();
			this.lblstatus = new Label();
			this.GroupBox1 = new GroupBox();
			this.GroupBox2 = new GroupBox();
			this.GroupBox3 = new GroupBox();
			this.Label4 = new Label();
			this.Timer2 = new Timer(this.components);
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.SuspendLayout();
			Button button1 = this.Button1;
			Point point = new Point(6, 19);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			Size size = new Size(75, 23);
			button.Size = size;
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Start";
			this.Button1.UseVisualStyleBackColor = true;
			this.Timer1.Interval = 6000;
			WebBrowser webBrowser1 = this.WebBrowser1;
			point = new Point(12, 117);
			webBrowser1.Location = point;
			WebBrowser webBrowser = this.WebBrowser1;
			size = new Size(20, 20);
			webBrowser.MinimumSize = size;
			this.WebBrowser1.Name = "WebBrowser1";
			this.WebBrowser1.ScriptErrorsSuppressed = true;
			WebBrowser webBrowser11 = this.WebBrowser1;
			size = new Size(997, 777);
			webBrowser11.Size = size;
			this.WebBrowser1.TabIndex = 1;
			this.WebBrowser1.Url = new Uri("http://www.fanslave.com/account-overview.html", UriKind.Absolute);
			this.Label1.AutoSize = true;
			Label label1 = this.Label1;
			point = new Point(30, 16);
			label1.Location = point;
			this.Label1.Name = "Label1";
			Label label = this.Label1;
			size = new Size(13, 13);
			label.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "0";
			this.Button2.Enabled = false;
			Button button2 = this.Button2;
			point = new Point(119, 19);
			button2.Location = point;
			this.Button2.Name = "Button2";
			Button button21 = this.Button2;
			size = new Size(75, 23);
			button21.Size = size;
			this.Button2.TabIndex = 3;
			this.Button2.Text = "Stop";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			Label label2 = this.Label2;
			point = new Point(49, 16);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new Size(62, 13);
			label21.Size = size;
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Pages liked";
			this.Label3.AutoSize = true;
			Label label3 = this.Label3;
			point = new Point(6, 24);
			label3.Location = point;
			this.Label3.Name = "Label3";
			Label label31 = this.Label3;
			size = new Size(70, 13);
			label31.Size = size;
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Check every:";
			TextBox textBox1 = this.TextBox1;
			point = new Point(82, 21);
			textBox1.Location = point;
			this.TextBox1.Name = "TextBox1";
			TextBox textBox = this.TextBox1;
			size = new Size(45, 20);
			textBox.Size = size;
			this.TextBox1.TabIndex = 7;
			this.TextBox1.Text = "5";
			this.Label5.AutoSize = true;
			Label label5 = this.Label5;
			point = new Point(133, 24);
			label5.Location = point;
			this.Label5.Name = "Label5";
			Label label51 = this.Label5;
			size = new Size(47, 13);
			label51.Size = size;
			this.Label5.TabIndex = 9;
			this.Label5.Text = "seconds";
			Button button3 = this.Button3;
			point = new Point(186, 19);
			button3.Location = point;
			this.Button3.Name = "Button3";
			Button button31 = this.Button3;
			size = new Size(100, 23);
			button31.Size = size;
			this.Button3.TabIndex = 11;
			this.Button3.Text = "Save Settings";
			this.Button3.UseVisualStyleBackColor = true;
			this.lblstatus.AutoSize = true;
			Label label4 = this.lblstatus;
			point = new Point(212, 16);
			label4.Location = point;
			this.lblstatus.Name = "lblstatus";
			Label label6 = this.lblstatus;
			size = new Size(74, 13);
			label6.Size = size;
			this.lblstatus.TabIndex = 12;
			this.lblstatus.Text = "Status: Ready";
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Button2);
			GroupBox groupBox1 = this.GroupBox1;
			point = new Point(12, 3);
			groupBox1.Location = point;
			this.GroupBox1.Name = "GroupBox1";
			GroupBox groupBox = this.GroupBox1;
			size = new Size(200, 57);
			groupBox.Size = size;
			this.GroupBox1.TabIndex = 13;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Controls";
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.TextBox1);
			this.GroupBox2.Controls.Add(this.Label5);
			this.GroupBox2.Controls.Add(this.Button3);
			GroupBox groupBox2 = this.GroupBox2;
			point = new Point(218, 3);
			groupBox2.Location = point;
			this.GroupBox2.Name = "GroupBox2";
			GroupBox groupBox21 = this.GroupBox2;
			size = new Size(310, 57);
			groupBox21.Size = size;
			this.GroupBox2.TabIndex = 14;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Settings";
			this.GroupBox3.Controls.Add(this.Label4);
			this.GroupBox3.Controls.Add(this.lblstatus);
			this.GroupBox3.Controls.Add(this.Label2);
			this.GroupBox3.Controls.Add(this.Label1);
			GroupBox groupBox3 = this.GroupBox3;
			point = new Point(12, 66);
			groupBox3.Location = point;
			this.GroupBox3.Name = "GroupBox3";
			GroupBox groupBox31 = this.GroupBox3;
			size = new Size(516, 45);
			groupBox31.Size = size;
			this.GroupBox3.TabIndex = 15;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Stats";
			this.Label4.AutoSize = true;
			this.Label4.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Label label41 = this.Label4;
			point = new Point(316, 30);
			label41.Location = point;
			this.Label4.Name = "Label4";
			Label label42 = this.Label4;
			size = new Size(197, 12);
			label42.Size = size;
			this.Label4.TabIndex = 13;
			this.Label4.Text = "email: pushbutton.receivebacon@hotmail.com";
			this.Timer2.Interval = 6000;
			SizeF sizeF = new SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new Size(537, 585);
			this.ClientSize = size;
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.WebBrowser1);
			//this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Form1";
			this.Text = "Fanslave bot by Subcode";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.ResumeLayout(false);
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Interval = this.time1;
			this.Timer1.Enabled = false;
			this.WebBrowser1.Navigate("http://www.fanslave.com/account-overview.html?meldung=0");
		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			this.Timer2.Enabled = false;
			try
			{
				this.lblstatus.Text = "Status: Clicking Like";
				HtmlElementCollection elementsByTagName = this.WebBrowser1.Document.GetElementsByTagName("input");

                foreach (HtmlElement element in elementsByTagName)
                {
                    if (element.OuterHtml.Contains("value=\"Like\""))
                    {
                        element.InvokeMember("Click");
                        break;
                    }
                }


                //var element = elementsByTagName.FirstOrDefault( e => e.OuterHtml.Contains("value='Like'"));
				//elementsByTagName[17].InvokeMember("Click");
                
				this.standby = true;
				this.Label1.Text = Conversions.ToString(Conversions.ToDouble(this.Label1.Text) + 1);
				this.trying = 0;
                WebBrowser1_DocumentCompleted(null, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				this.Timer2.Enabled = true;
				if (this.trying != 5)
				{
					this.trying = checked(this.trying + 1);
				}
				else
				{
					this.trying = 0;
					this.Timer2.Enabled = false;
					this.Timer1.Enabled = true;
				}
				ProjectData.ClearProjectError();
			}
		}

		private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			if (this.start)
			{
				if (this.standby)
				{
					this.standby = false;
					this.Timer1.Enabled = true;
				}
				if (this.facebook)
				{
					this.facebook = false;
					this.Timer2.Enabled = true;
				}
				if (this.WebBrowser1.DocumentText.Contains("Just visit one or more of the following"))
				{
					this.lblstatus.Text = "Status: Going to Facebook page.";
					this.Timer2.Enabled = false;
					string str = Strings.Split(Strings.Split(this.WebBrowser1.DocumentText, "fanslave/weiterleitung.php?", -1, CompareMethod.Binary)[1], "' target=", -1, CompareMethod.Binary)[0];
					this.WebBrowser1.Navigate(string.Concat("http://www.fanslave.com/fanslave/weiterleitung.php?", str));
					this.facebook = true;
				}
				if (this.WebBrowser1.DocumentText.Contains("There are no fanpages"))
				{
					this.Timer2.Enabled = false;
					this.lblstatus.Text = "Status: No Fanpages, Re-checking.";
					this.Timer1.Enabled = true;
				}
				if (this.WebBrowser1.DocumentText.Contains("reached the daily limit."))
				{
					this.Timer2.Enabled = false;
					this.Timer1.Enabled = false;
					this.lblstatus.Text = "Status: Daily limit Reached !";
				}
				if (this.WebBrowser1.DocumentText.Contains("Security-Check"))
				{
					this.Timer2.Enabled = false;
					this.Timer1.Enabled = false;
					this.lblstatus.Text = "Status: Fill in Captcha !";
					this.TopMost = true;
					this.TopMost = false;
				}
			}
		}
	}
}