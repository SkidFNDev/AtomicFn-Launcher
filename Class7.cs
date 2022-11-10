using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000017 RID: 23
internal static class Class7
{
	// Token: 0x0600009A RID: 154 RVA: 0x0000A608 File Offset: 0x00008808
	public static void smethod_0(string string_0, string string_1)
	{
		new WebClient().DownloadFile(string_0, string_1);
	}

	// Token: 0x0600009B RID: 155
	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenThread(Class7.Enum0 enum0_0, bool bool_0, uint uint_0);

	// Token: 0x0600009C RID: 156 RVA: 0x0000A624 File Offset: 0x00008824
	public static void smethod_1(this Process process_0)
	{
		foreach (object obj in process_0.Threads)
		{
			ProcessThread processThread = (ProcessThread)obj;
			IntPtr intPtr = Class7.OpenThread(Class7.Enum0.SUSPEND_RESUME, false, (uint)processThread.Id);
			if (intPtr == IntPtr.Zero)
			{
				break;
			}
			Class7.ResumeThread(intPtr);
		}
	}

	// Token: 0x0600009D RID: 157
	[DllImport("kernel32.dll")]
	private static extern int ResumeThread(IntPtr intptr_0);

	// Token: 0x0600009E RID: 158 RVA: 0x0000A69C File Offset: 0x0000889C
	public static void smethod_2(this Process process_0)
	{
		foreach (object obj in process_0.Threads)
		{
			ProcessThread processThread = (ProcessThread)obj;
			IntPtr intPtr = Class7.OpenThread(Class7.Enum0.SUSPEND_RESUME, false, (uint)processThread.Id);
			if (intPtr == IntPtr.Zero)
			{
				break;
			}
			Class7.SuspendThread(intPtr);
		}
	}

	// Token: 0x0600009F RID: 159
	[DllImport("kernel32.dll")]
	private static extern uint SuspendThread(IntPtr intptr_0);

	// Token: 0x02000018 RID: 24
	[Flags]
	public enum Enum0
	{
		// Token: 0x0400006F RID: 111
		TERMINATE = 1,
		// Token: 0x04000070 RID: 112
		SUSPEND_RESUME = 2,
		// Token: 0x04000071 RID: 113
		GET_CONTEXT = 8,
		// Token: 0x04000072 RID: 114
		SET_CONTEXT = 16,
		// Token: 0x04000073 RID: 115
		SET_INFORMATION = 32,
		// Token: 0x04000074 RID: 116
		QUERY_INFORMATION = 64,
		// Token: 0x04000075 RID: 117
		SET_THREAD_TOKEN = 128,
		// Token: 0x04000076 RID: 118
		IMPERSONATE = 256,
		// Token: 0x04000077 RID: 119
		DIRECT_IMPERSONATION = 512
	}

	// Token: 0x02000019 RID: 25
	internal static class Class8
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0000A714 File Offset: 0x00008914
		[STAThread]
		private static void smethod_0()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
