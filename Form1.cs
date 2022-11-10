using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using AtomicLauncher;
using Guna.UI2.WinForms;
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;

// Token: 0x02000011 RID: 17
public partial class Form1 : Form
{
	// Token: 0x06000063 RID: 99 RVA: 0x000065F4 File Offset: 0x000047F4
	public Form1()
	{
		this.InitializeComponent();
		this.gstruct0_0 = default(GClass2.GStruct0);
		GClass2.Discord_Initialize("896735458069970976", ref this.gstruct0_0, true, null);
		this.gstruct0_0 = default(GClass2.GStruct0);
		GClass2.Discord_Initialize("896735458069970976", ref this.gstruct0_0, true, null);
		this.gstruct1_0.details = "dsc.gg/atomicfn";
		this.gstruct1_0.state = "Atomic Dev Server";
		this.gstruct1_0.largeImageKey = "image";
		this.gstruct1_0.smallImageKey = "image";
		GClass2.Discord_UpdatePresence(ref this.gstruct1_0);
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00004694 File Offset: 0x00002894
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

	// Token: 0x06000065 RID: 101 RVA: 0x0000669C File Offset: 0x0000489C
	private void guna2GradientButton1_Click(object sender, EventArgs e)
	{
		Settings.Default.Path = this.guna2TextBox2.Text;
		if (!this.guna2CheckBox1.Checked)
		{
			using (WebClient webClient = new WebClient())
			{
				string tempPath = Path.GetTempPath();
				if (!File.Exists(tempPath + "/Inject.exe"))
				{
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/1032986535273967696/1033439324609462362/Injector.exe", tempPath + "/Inject.exe");
				}
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/777557159818166282/1038174928287047762/AntiCheat.exe", Settings.Default.Path + "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping_EAC.exe");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/777557159818166282/1038174928287047762/AntiCheat.exe", Settings.Default.Path + "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping_BE.exe");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/768564166159368242/1038117759550238820/Atomic.dll", Settings.Default.Path + "/FortniteGame/Binaries/Win64/Atomic.dll");
				Process.Start("cmd", "/C start com.epicgames.launcher://apps/Fortnite?action=launch");
				return;
			}
		}
		string tempPath2 = Path.GetTempPath();
		Directory.GetCurrentDirectory() + "\\";
		string arg = Directory.GetCurrentDirectory() + "\\Atomic.dll";
		WebClient webClient2 = new WebClient();
		base.Hide();
		if (!File.Exists(tempPath2 + "/Inject.exe"))
		{
			webClient2.DownloadFile("https://cdn.discordapp.com/attachments/1032986535273967696/1033439324609462362/Injector.exe", tempPath2 + "/Inject.exe");
		}
		string text = Class5.smethod_1(Class5.smethod_0());
		string[] array = text.Split(new char[]
		{
			','
		}, 2);
		if (!text.Contains("error"))
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
					FileName = tempPath2 + "/Inject.exe"
				}
			}.Start();
			Thread.Sleep(30000);
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

	// Token: 0x06000066 RID: 102 RVA: 0x00006A98 File Offset: 0x00004C98
	private void guna2Button1_Click(object sender, EventArgs e)
	{
		CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
		commonOpenFileDialog.IsFolderPicker = true;
		if (commonOpenFileDialog.ShowDialog() == 1)
		{
			this.guna2TextBox2.Text = commonOpenFileDialog.FileName;
		}
		if (!Directory.Exists(this.guna2TextBox2.Text + "\\FortniteGame"))
		{
			MessageBox.Show("Invalid path! Please input valid path that contains \"FortniteGame\" and \"Engine\"");
			this.guna2TextBox2.Text = string.Empty;
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00006B08 File Offset: 0x00004D08
	private void Form1_Load(object sender, EventArgs e)
	{
		Guna2TextBox guna2TextBox = this.guna2TextBox2;
		Form1.GClass1 gclass = Form1.smethod_0().FirstOrDefault(new Func<Form1.GClass1, bool>(Form1.Class6.<>9.method_0));
		guna2TextBox.Text = ((gclass != null) ? gclass.String_0 : null);
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00006B58 File Offset: 0x00004D58
	public static List<Form1.GClass1> smethod_0()
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
		List<Form1.GClass1> result;
		if (Directory.Exists(Path.GetDirectoryName(path)) && File.Exists(path))
		{
			result = JsonConvert.DeserializeObject<Form1.GClass0>(File.ReadAllText(path)).List_0;
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x000046E0 File Offset: 0x000028E0
	private void guna2Button2_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	// Token: 0x0600006A RID: 106 RVA: 0x000046F4 File Offset: 0x000028F4
	private void guna2Button3_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00006BA8 File Offset: 0x00004DA8
	private void guna2GradientButton2_Click(object sender, EventArgs e)
	{
		new Form2().Show();
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00004C10 File Offset: 0x00002E10
	private void guna2GradientButton3_Click(object sender, EventArgs e)
	{
		new Form3().Show();
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00006BC0 File Offset: 0x00004DC0
	private void method_0(object sender, EventArgs e)
	{
		new Form4().Show();
		base.Hide();
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00006BC0 File Offset: 0x00004DC0
	private void S13HybridButton_Click(object sender, EventArgs e)
	{
		new Form4().Show();
		base.Hide();
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002C50 File Offset: 0x00000E50
	private void PrivServerButton_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00006BE0 File Offset: 0x00004DE0
	private void guna2GradientButton4_Click(object sender, EventArgs e)
	{
		Process.Start("cmd", "/C start com.epicgames.launcher://apps/Fortnite?action=verify");
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00006C00 File Offset: 0x00004E00
	private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (!this.guna2CheckBox1.Checked)
		{
			this.guna2GradientButton1.Text = "Launch";
		}
		else
		{
			this.guna2GradientButton1.Text = "Login";
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00006C3C File Offset: 0x00004E3C
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x04000042 RID: 66
	private GClass2.GStruct0 gstruct0_0;

	// Token: 0x04000043 RID: 67
	private GClass2.GStruct1 gstruct1_0;

	// Token: 0x04000044 RID: 68
	private IContainer icontainer_0 = null;

	// Token: 0x02000012 RID: 18
	public class GClass0
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00007F38 File Offset: 0x00006138
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00007F4C File Offset: 0x0000614C
		[JsonProperty("InstallationList")]
		public List<Form1.GClass1> List_0 { get; set; }

		// Token: 0x04000051 RID: 81
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private List<Form1.GClass1> list_0;
	}

	// Token: 0x02000013 RID: 19
	public class GClass1
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00007F60 File Offset: 0x00006160
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00007F74 File Offset: 0x00006174
		[JsonProperty("InstallLocation")]
		public string String_0 { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00007F88 File Offset: 0x00006188
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00007F9C File Offset: 0x0000619C
		[JsonProperty("AppName")]
		public string String_1 { get; set; }

		// Token: 0x04000052 RID: 82
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_0;

		// Token: 0x04000053 RID: 83
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string string_1;
	}

	// Token: 0x02000014 RID: 20
	[CompilerGenerated]
	[Serializable]
	private sealed class Class6
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00007FC8 File Offset: 0x000061C8
		internal bool method_0(Form1.GClass1 gclass1_0)
		{
			return gclass1_0.String_1 == "Fortnite";
		}

		// Token: 0x04000054 RID: 84
		public static readonly Form1.Class6 <>9 = new Form1.Class6();

		// Token: 0x04000055 RID: 85
		public static Func<Form1.GClass1, bool> <>9__6_0;
	}
}
