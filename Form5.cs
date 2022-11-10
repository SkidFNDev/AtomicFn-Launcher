using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.WindowsAPICodePack.Dialogs;

// Token: 0x0200000F RID: 15
public partial class Form5 : Form
{
	// Token: 0x06000049 RID: 73 RVA: 0x00005BF0 File Offset: 0x00003DF0
	public Form5()
	{
		this.InitializeComponent();
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00005C10 File Offset: 0x00003E10
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

	// Token: 0x0600004B RID: 75 RVA: 0x00005C5C File Offset: 0x00003E5C
	private void guna2GradientButton1_Click(object sender, EventArgs e)
	{
		CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
		if (commonOpenFileDialog.ShowDialog() == 1 && Form5.list_0.Contains(Path.GetExtension(commonOpenFileDialog.FileName).ToUpperInvariant()))
		{
			this.string_0 = commonOpenFileDialog.FileName;
			this.guna2Panel1.BackgroundImage = new Bitmap(this.string_0);
			this.guna2Panel1.BackgroundImageLayout = ImageLayout.Zoom;
		}
		else
		{
			MessageBox.Show("Invalid image");
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00005CD0 File Offset: 0x00003ED0
	private void guna2GradientButton2_Click(object sender, EventArgs e)
	{
		string sourceFileName = this.string_0;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/FortniteGame/Saved/PersistentDownloadDir/CMS/Files/C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2/8A23C3655E11CAB81B1A518D37BC912F3A303321.png";
		File.Delete(text);
		File.Copy(sourceFileName, text);
		MessageBox.Show("Applied");
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00005D10 File Offset: 0x00003F10
	private void guna2GradientButton3_Click(object sender, EventArgs e)
	{
		string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/FortniteGame/Saved/PersistentDownloadDir/CMS/Files/C28FF1DE0C661DAF01E118A30B3F21B897A7A6E2";
		Directory.Delete(path, true);
		Directory.CreateDirectory(path);
		MessageBox.Show("Successfully Reset");
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002C50 File Offset: 0x00000E50
	private void Form5_Load(object sender, EventArgs e)
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00005D48 File Offset: 0x00003F48
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x04000039 RID: 57
	public static readonly List<string> list_0 = new List<string>
	{
		".JPG",
		".JPEG",
		".JPE",
		".BMP",
		".PNG"
	};

	// Token: 0x0400003A RID: 58
	private string string_0;

	// Token: 0x0400003B RID: 59
	private IContainer icontainer_0 = null;
}
