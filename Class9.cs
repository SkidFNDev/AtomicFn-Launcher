using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x0200001A RID: 26
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal class Class9
{
	// Token: 0x060000A1 RID: 161 RVA: 0x000033D8 File Offset: 0x000015D8
	internal Class9()
	{
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000A738 File Offset: 0x00008938
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class9.resourceManager_0 == null)
			{
				ResourceManager resourceManager = new ResourceManager("j=q;>70!Wp(PMc{}o\\*d8 _Bk%", typeof(Class9).Assembly);
				Class9.resourceManager_0 = resourceManager;
			}
			return Class9.resourceManager_0;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000A778 File Offset: 0x00008978
	// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000A78C File Offset: 0x0000898C
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class9.cultureInfo_0;
		}
		set
		{
			Class9.cultureInfo_0 = value;
		}
	}

	// Token: 0x04000078 RID: 120
	private static ResourceManager resourceManager_0;

	// Token: 0x04000079 RID: 121
	private static CultureInfo cultureInfo_0;
}
