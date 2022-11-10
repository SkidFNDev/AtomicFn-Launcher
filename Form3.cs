using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Guna.UI2.WinForms;

// Token: 0x02000016 RID: 22
public partial class Form3 : Form
{
	// Token: 0x06000091 RID: 145 RVA: 0x00009E8C File Offset: 0x0000808C
	public Form3()
	{
		this.InitializeComponent();
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00005C10 File Offset: 0x00003E10
	protected virtual void WndProc(ref Message m)
	{
		int msg = m.Msg;
		int num = msg;
		if (num != 132)
		{
			base.WndProc(ref m);
		}
		else
		{
			base.WndProc(ref m);
			if ((int)m.Result == 1)
			{
				m.Result = (IntPtr)2;
			}
		}
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00009EAC File Offset: 0x000080AC
	private void guna2Button1_Click(object sender, EventArgs e)
	{
		Process process = new Process
		{
			StartInfo = 
			{
				FileName = "https://dsc.gg/atomicfn"
			}
		};
		process.Start();
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002C50 File Offset: 0x00000E50
	private void Form3_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00008290 File Offset: 0x00006490
	private void guna2Button2_Click(object sender, EventArgs e)
	{
		new Form5().Show();
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00009ED8 File Offset: 0x000080D8
	private void method_0(object sender, EventArgs e)
	{
		if (!File.Exists(Path.GetTempPath() + "/Install.exe"))
		{
			new WebClient().DownloadFile("https://github.com/Reksely/ManifestDownloaders/releases/download/Release/Season20.40Installer.exe", Path.GetTempPath() + "/Install.exe");
		}
		Process.Start(Path.GetTempPath() + "/Install.exe");
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00009F34 File Offset: 0x00008134
	private void guna2Button4_Click(object sender, EventArgs e)
	{
		if (!File.Exists(Path.GetTempPath() + "/Install2.exe"))
		{
			new WebClient().DownloadFile("https://github.com/Reksely/ManifestDownloaders/releases/download/Release/Season13.40Installer.exe", Path.GetTempPath() + "/Install2.exe");
		}
		Process.Start(Path.GetTempPath() + "/Install2.exe");
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00009F90 File Offset: 0x00008190
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x04000067 RID: 103
	private IContainer icontainer_0 = null;
}
