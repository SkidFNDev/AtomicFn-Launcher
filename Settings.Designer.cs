using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AtomicLauncher
{
	// Token: 0x02000010 RID: 16
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000644C File Offset: 0x0000464C
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00006460 File Offset: 0x00004660
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00006480 File Offset: 0x00004680
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string Path
		{
			get
			{
				return (string)this["Path"];
			}
			set
			{
				this["Path"] = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000649C File Offset: 0x0000469C
		// (set) Token: 0x06000059 RID: 89 RVA: 0x000064BC File Offset: 0x000046BC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool Show
		{
			get
			{
				return (bool)this["Show"];
			}
			set
			{
				this["Show"] = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000064DC File Offset: 0x000046DC
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000064FC File Offset: 0x000046FC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AC_bypass
		{
			get
			{
				return (bool)this["AC_bypass"];
			}
			set
			{
				this["AC_bypass"] = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000651C File Offset: 0x0000471C
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000653C File Offset: 0x0000473C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Email
		{
			get
			{
				return (string)this["Email"];
			}
			set
			{
				this["Email"] = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00006558 File Offset: 0x00004758
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00006578 File Offset: 0x00004778
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string Imgpath
		{
			get
			{
				return (string)this["Imgpath"];
			}
			set
			{
				this["Imgpath"] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00006594 File Offset: 0x00004794
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000065B4 File Offset: 0x000047B4
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string Accid
		{
			get
			{
				return (string)this["Accid"];
			}
			set
			{
				this["Accid"] = value;
			}
		}

		// Token: 0x04000041 RID: 65
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
