using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using AtomicLauncher;
using Guna.UI2.WinForms;
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.WindowsAPICodePack.Dialogs;

// Token: 0x0200000E RID: 14
public partial class Form4 : Form
{
	// Token: 0x0600003D RID: 61 RVA: 0x00004674 File Offset: 0x00002874
	public Form4()
	{
		this.InitializeComponent();
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00004694 File Offset: 0x00002894
	protected virtual void WndProc(ref Message m)
	{
		int msg = m.Msg;
		int num = msg;
		if (num == 132)
		{
			base.WndProc(ref m);
			if ((int)m.Result == 1)
			{
				m.Result = (IntPtr)2;
			}
		}
		else
		{
			base.WndProc(ref m);
		}
	}

	// Token: 0x0600003F RID: 63 RVA: 0x000046E0 File Offset: 0x000028E0
	private void guna2Button2_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	// Token: 0x06000040 RID: 64 RVA: 0x000046F4 File Offset: 0x000028F4
	private void guna2Button3_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00004708 File Offset: 0x00002908
	private void method_0(object sender, EventArgs e)
	{
		new Form1().Show();
		base.Hide();
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002C50 File Offset: 0x00000E50
	private void Form4_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00004728 File Offset: 0x00002928
	private void guna2GradientButton1_Click(object sender, EventArgs e)
	{
		string tempPath = Path.GetTempPath();
		Directory.GetCurrentDirectory() + "\\";
		string arg = tempPath + "/AtomicS13.dll";
		string arg2 = tempPath + "/AtomicS13Console.dll";
		string text = tempPath + "/AtomicS13Tools.dll";
		Settings.Default.Path + "`\\FortniteGame\\Binaries\\Win64\\Tool.dll";
		WebClient webClient = new WebClient();
		Settings.Default.Path = this.guna2TextBox2.Text;
		base.Hide();
		if (!File.Exists(tempPath + "/Inject.exe"))
		{
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1032986535273967696/1033439324609462362/Injector.exe", tempPath + "/Inject.exe");
		}
		if (!File.Exists(tempPath + "/AtomicS13.dll"))
		{
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/768564166159368242/1033378978901278762/AtomicS13.dll", tempPath + "/AtomicS13.dll");
		}
		if (!File.Exists(tempPath + "/AtomicS13Console.dll"))
		{
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/870681151302426637/897451770521997402/FortConsole.dll", tempPath + "/AtomicS13Console.dll");
		}
		if (!File.Exists(text))
		{
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/768564166159368242/1034194831481786469/FortniteTools.dll", text);
		}
		string text2 = Class5.smethod_1(Class5.smethod_0());
		string[] array = text2.Split(new char[]
		{
			','
		}, 2);
		if (!text2.Contains("error"))
		{
			string str = array[1];
			string string_ = array[0];
			string str2 = Class5.smethod_3(string_);
			new ToastContentBuilder().AddText("Successfully logged in as " + str + "!", null, null, null, null, null, null).AddText("Going into fortnite...", null, null, null, null, null, null).Show();
			Process process = Process.Start(new ProcessStartInfo
			{
				FileName = Settings.Default.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe",
				Arguments = "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -nobe -fromfl=eac -fltoken=919348d6add4c4c7c7507e61"
			});
			process.smethod_2();
			Process process2 = Process.Start(new ProcessStartInfo
			{
				FileName = Settings.Default.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe",
				Arguments = "-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -nobe -fromfl=eac -fltoken=919348d6add4c4c7c7507e61"
			});
			process2.smethod_2();
			Process process3 = Process.Start(new ProcessStartInfo
			{
				FileName = Settings.Default.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe",
				Arguments = string.Concat(new string[]
				{
					"-AUTH_LOGIN=unused -AUTH_PASSWORD=" + str2 + " -AUTH_TYPE=exchangecode  -AUTH_PASSWORD=unused -AUTH_TYPE=epic -epicapp=Fortnite -epicportal -noeac -fromfl=be -fltoken=020912211c40g052474d02f1 -skippatchcheck -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiYmU5ZGE1YzJmYmVhNDQwN2IyZjQwZWJhYWQ4NTlhZDQiLCJnZW5lcmF0ZWQiOjE2Mzg3MTcyNzgsImNhbGRlcmFHdWlkIjoiMzgxMGI4NjMtMmE2NS00NDU3LTliNTgtNGRhYjNiNDgyYTg2IiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.VAWQB67RTxhiWOxx7DBjnzDnXyyEnX7OljJm-j2d88G_WgwQ9wrE6lwMEHZHjBd1ISJdUO1UVUqkfLdU5nofBQ"
				})
			});
			base.Hide();
			process3.WaitForInputIdle();
			new Process
			{
				StartInfo = 
				{
					Arguments = string.Format("\"{0}\" \"{1}\"", process3.Id, arg),
					CreateNoWindow = true,
					UseShellExecute = false,
					FileName = tempPath + "/Inject.exe"
				}
			}.Start();
			Thread.Sleep(30000);
			Thread.Sleep(10000);
			new Process
			{
				StartInfo = 
				{
					Arguments = string.Format("\"{0}\" \"{1}\"", process3.Id, text),
					CreateNoWindow = true,
					UseShellExecute = false,
					FileName = tempPath + "/Inject.exe"
				}
			}.Start();
			if (this.guna2CheckBox1.Checked)
			{
				new Process
				{
					StartInfo = 
					{
						Arguments = string.Format("\"{0}\" \"{1}\"", process3.Id, arg2),
						CreateNoWindow = true,
						UseShellExecute = false,
						FileName = tempPath + "/Inject.exe"
					}
				}.Start();
			}
			Thread.Sleep(1000);
			process3.WaitForExit();
			base.Show();
			Process.Start("taskkill", "/f /pid " + process.Id.ToString());
			Process.Start("taskkill", "/f /pid " + process2.Id.ToString());
			Process.Start("taskkill", "/f /im node.exe");
			Process.Start("taskkill", "/f /im cmd.exe");
			Process.Start("taskkill", "/f /im conhost.exe");
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00004BB0 File Offset: 0x00002DB0
	private void guna2Button1_Click(object sender, EventArgs e)
	{
		CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog
		{
			IsFolderPicker = true
		};
		if (commonOpenFileDialog.ShowDialog() == 1)
		{
			this.guna2TextBox2.Text = commonOpenFileDialog.FileName;
		}
		if (!Directory.Exists(this.guna2TextBox2.Text + "/Fortnitegame"))
		{
			MessageBox.Show("Please Put Valid Path!");
		}
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00004C10 File Offset: 0x00002E10
	private void guna2GradientButton3_Click(object sender, EventArgs e)
	{
		new Form3().Show();
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00004708 File Offset: 0x00002908
	private void PrivServerButton_Click(object sender, EventArgs e)
	{
		new Form1().Show();
		base.Hide();
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00004C28 File Offset: 0x00002E28
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x0400002E RID: 46
	private IContainer icontainer_0 = null;
}
