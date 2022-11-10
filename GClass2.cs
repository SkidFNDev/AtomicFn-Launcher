using System;
using System.Runtime.InteropServices;

// Token: 0x0200001C RID: 28
public class GClass2
{
	// Token: 0x060000A8 RID: 168
	[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_Initialize(string string_0, ref GClass2.GStruct0 gstruct0_0, bool bool_0, string string_1);

	// Token: 0x060000A9 RID: 169
	[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_RunCallbacks();

	// Token: 0x060000AA RID: 170
	[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_Shutdown();

	// Token: 0x060000AB RID: 171
	[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void Discord_UpdatePresence(ref GClass2.GStruct1 gstruct1_0);

	// Token: 0x060000AC RID: 172 RVA: 0x0000A7D8 File Offset: 0x000089D8
	internal static void smethod_0(string string_0, ref object object_0, bool bool_0, object object_1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0200001D RID: 29
	// (Invoke) Token: 0x060000AF RID: 175
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GDelegate0(int errorCode, string message);

	// Token: 0x0200001E RID: 30
	// (Invoke) Token: 0x060000B3 RID: 179
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GDelegate1(int errorCode, string message);

	// Token: 0x0200001F RID: 31
	public struct GStruct0
	{
		// Token: 0x0400007B RID: 123
		public GClass2.GDelegate2 gdelegate2_0;

		// Token: 0x0400007C RID: 124
		public GClass2.GDelegate0 gdelegate0_0;

		// Token: 0x0400007D RID: 125
		public GClass2.GDelegate1 gdelegate1_0;
	}

	// Token: 0x02000020 RID: 32
	// (Invoke) Token: 0x060000B7 RID: 183
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void GDelegate2();

	// Token: 0x02000021 RID: 33
	[Serializable]
	public struct GStruct1
	{
		// Token: 0x0400007E RID: 126
		public string state;

		// Token: 0x0400007F RID: 127
		public string details;

		// Token: 0x04000080 RID: 128
		public long startTimestamp;

		// Token: 0x04000081 RID: 129
		public long endTimestamp;

		// Token: 0x04000082 RID: 130
		public string largeImageKey;

		// Token: 0x04000083 RID: 131
		public string largeImageText;

		// Token: 0x04000084 RID: 132
		public string smallImageKey;

		// Token: 0x04000085 RID: 133
		public string smallImageText;

		// Token: 0x04000086 RID: 134
		public string partyId;

		// Token: 0x04000087 RID: 135
		public int partySize;

		// Token: 0x04000088 RID: 136
		public int partyMax;

		// Token: 0x04000089 RID: 137
		public string matchSecret;

		// Token: 0x0400008A RID: 138
		public string joinSecret;

		// Token: 0x0400008B RID: 139
		public string spectateSecret;

		// Token: 0x0400008C RID: 140
		public bool instance;
	}
}
