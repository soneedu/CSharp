using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace My
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		private static bool addedHandler;

		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

		public static MySettings Default
		{
			get
			{
				if (!addedHandler)
				{
					object obj = addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					Monitor.Enter(obj);
					try
					{
						if (!addedHandler)
						{
							MyProject.Application.Shutdown += delegate
							{
								if (MyProject.Application.SaveMySettingsOnExit)
								{
									MySettingsProperty.Settings.Save();
								}
							};
							addedHandler = true;
						}
					}
					finally
					{
						Monitor.Exit(obj);
					}
				}
				return defaultInstance;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string key
		{
			get
			{
				return Conversions.ToString(this["key"]);
			}
			set
			{
				this["key"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string user
		{
			get
			{
				return Conversions.ToString(this["user"]);
			}
			set
			{
				this["user"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool subfolders
		{
			get
			{
				return Conversions.ToBoolean(this["subfolders"]);
			}
			set
			{
				this["subfolders"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool hidden
		{
			get
			{
				return Conversions.ToBoolean(this["hidden"]);
			}
			set
			{
				this["hidden"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string exclude
		{
			get
			{
				return Conversions.ToString(this["exclude"]);
			}
			set
			{
				this["exclude"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string types
		{
			get
			{
				return Conversions.ToString(this["types"]);
			}
			set
			{
				this["types"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool upgraded
		{
			get
			{
				return Conversions.ToBoolean(this["upgraded"]);
			}
			set
			{
				this["upgraded"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string lang
		{
			get
			{
				return Conversions.ToString(this["lang"]);
			}
			set
			{
				this["lang"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool smart
		{
			get
			{
				return Conversions.ToBoolean(this["smart"]);
			}
			set
			{
				this["smart"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string path
		{
			get
			{
				return Conversions.ToString(this["path"]);
			}
			set
			{
				this["path"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string created
		{
			get
			{
				return Conversions.ToString(this["created"]);
			}
			set
			{
				this["created"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string name
		{
			get
			{
				return Conversions.ToString(this["name"]);
			}
			set
			{
				this["name"] = value;
			}
		}

		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}
	}
}
