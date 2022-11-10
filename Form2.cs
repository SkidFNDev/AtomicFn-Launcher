using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using AtomicLauncher;
using Guna.UI2.WinForms;
using Microsoft.Toolkit.Uwp.Notifications;
using RestSharp;

// Token: 0x02000015 RID: 21
public partial class Form2 : Form
{
	// Token: 0x0600007F RID: 127 RVA: 0x00007FE8 File Offset: 0x000061E8
	public Form2()
	{
		this.InitializeComponent();
		this.guna2TextBox1.Text = Settings.Default.Accid;
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00004694 File Offset: 0x00002894
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

	// Token: 0x06000081 RID: 129 RVA: 0x00008020 File Offset: 0x00006220
	private void guna2GradientButton1_Click(object sender, EventArgs e)
	{
		string text = Class5.smethod_1(Class5.smethod_0());
		text.Split(new char[]
		{
			','
		}, 2);
		if (!text.Contains("error"))
		{
			this.guna2TextBox1.Text = Settings.Default.Accid;
		}
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00008070 File Offset: 0x00006270
	private void guna2GradientButton2_Click(object sender, EventArgs e)
	{
		Settings.Default.Accid = this.guna2TextBox1.Text;
		string text = "https://atomicv2.raxterxpsycho.repl.co/stats/vbucks/" + this.guna2TextBox1.Text + "/" + this.guna2TextBox4.Text;
		IRestClient restClient = new RestClient();
		IRestRequest restRequest = new RestRequest(text);
		RestClientExtensions.Get(restClient, restRequest);
		new ToastContentBuilder().AddText("Applied Your Vbucks As " + this.guna2TextBox4.Text + "!", null, null, null, null, null, null).AddText("Restart Fn For This To Show", null, null, null, null, null, null).Show();
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00008164 File Offset: 0x00006364
	private void guna2GradientButton3_Click(object sender, EventArgs e)
	{
		Settings.Default.Accid = this.guna2TextBox1.Text;
		string text = "https://atomicv2.raxterxpsycho.repl.co/stats/level/" + this.guna2TextBox1.Text + "/" + this.guna2TextBox5.Text;
		IRestClient restClient = new RestClient();
		IRestRequest restRequest = new RestRequest(text);
		RestClientExtensions.Get(restClient, restRequest);
		new ToastContentBuilder().AddText("Applied Your Level As " + this.guna2TextBox5.Text + "!", null, null, null, null, null, null).AddText("Restart Fn For This To Show", null, null, null, null, null, null).Show();
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00008258 File Offset: 0x00006458
	private void Form2_Load(object sender, EventArgs e)
	{
		this.guna2TextBox1.Text = Settings.Default.Accid;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x0000827C File Offset: 0x0000647C
	private void guna2Button2_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	// Token: 0x06000086 RID: 134 RVA: 0x000046F4 File Offset: 0x000028F4
	private void guna2Button3_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00008290 File Offset: 0x00006490
	private void guna2GradientButton4_Click(object sender, EventArgs e)
	{
		new Form5().Show();
	}

	// Token: 0x06000088 RID: 136 RVA: 0x000082A8 File Offset: 0x000064A8
	private void guna2GradientButton6_Click(object sender, EventArgs e)
	{
		Settings.Default.Accid = this.guna2TextBox1.Text;
		string text = "https://atomicv2.raxterxpsycho.repl.co/stats/crowns/" + this.guna2TextBox1.Text + "/" + this.guna2TextBox7.Text;
		IRestClient restClient = new RestClient();
		IRestRequest restRequest = new RestRequest(text);
		RestClientExtensions.Get(restClient, restRequest);
		new ToastContentBuilder().AddText("Applied Your Crowns As " + this.guna2TextBox7.Text + "!", null, null, null, null, null, null).AddText("Restart Fn For This To Show", null, null, null, null, null, null).Show();
	}

	// Token: 0x06000089 RID: 137 RVA: 0x0000839C File Offset: 0x0000659C
	private void guna2GradientButton5_Click(object sender, EventArgs e)
	{
		Settings.Default.Accid = this.guna2TextBox1.Text;
		string text = "https://atomicv2.raxterxpsycho.repl.co/stats/stars/" + this.guna2TextBox1.Text + "/" + this.guna2TextBox6.Text;
		IRestClient restClient = new RestClient();
		IRestRequest restRequest = new RestRequest(text);
		RestClientExtensions.Get(restClient, restRequest);
		new ToastContentBuilder().AddText("Applied Your Stars As " + this.guna2TextBox6.Text + "!", null, null, null, null, null, null).AddText("Restart Fn For This To Show", null, null, null, null, null, null).Show();
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002C50 File Offset: 0x00000E50
	private void guna2TextBox4_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002C50 File Offset: 0x00000E50
	private void guna2TextBox5_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002C50 File Offset: 0x00000E50
	private void guna2TextBox7_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002C50 File Offset: 0x00000E50
	private void guna2TextBox6_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002C50 File Offset: 0x00000E50
	private void guna2TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00008490 File Offset: 0x00006690
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x04000056 RID: 86
	private IContainer icontainer_0 = null;
}
