using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace AtomicLauncher.Properties
{
	// Token: 0x0200001B RID: 27
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000A7A0 File Offset: 0x000089A0
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x0400007A RID: 122
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
