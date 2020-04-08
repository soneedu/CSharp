using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using TSSFL.Utility;

namespace My
{
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		[STAThread]
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static void Main(string[] Args)
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			MyProject.Application.Run(Args);
		}

		private void Me_Startup(object sender, StartupEventArgs e)
		{
			//Discarded unreachable code: IL_012d, IL_017b, IL_017d, IL_018d, IL_01af
			int num = default(int);
			int num3 = default(int);
			try
			{
				ProjectData.ClearProjectError();
				num = 1;
				int num2 = 2;
				Declarer.startPath = AppDomain.CurrentDomain.BaseDirectory;
				num2 = 3;
				Declarer.startPath = Declarer.startPath.Substring(0, checked(Declarer.startPath.Length - 1));
				num2 = 4;
				if (MySettingsProperty.Settings.lang.Length < 1)
				{
					num2 = 5;
					MySettingsProperty.Settings.lang = TFile.ReadIni(Declarer.startPath + "\\lang.ini", "Language", "lang");
					num2 = 6;
					MySettingsProperty.Settings.Save();
				}
				num2 = 7;
				Declarer.xd.Load(Declarer.startPath + "\\langs\\" + MySettingsProperty.Settings.lang + ".xml");
				num2 = 8;
				Declarer.xeL = Declarer.xd["LANG_TEXT"];
				num2 = 9;
				SelfService.UpgradeSettings();
				num2 = 10;
				if (MySettingsProperty.Settings.types.Length < 1)
				{
					num2 = 11;
					SelfService.InitSettings();
				}
				num2 = 12;
				SelfService.UpdateExts();
				num2 = 13;
				SelfService.VerifyKey(MySettingsProperty.Settings.key, ref Declarer.licenseType, ref Declarer.licensedPCs);
				num2 = 14;
				Thread thread = new Thread(CheckLatestVerOnStartup);
				num2 = 15;
				thread.Start();
			}
			catch (Exception obj) when ((obj is Exception && num != 0) & (num3 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_01ad: Could not find block for branch target IL_017d*/;
			}
			if (num3 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		private void CheckLatestVerOnStartup()
		{
			//Discarded unreachable code: IL_0025, IL_0043, IL_0045, IL_0055, IL_0077
			int num2 = default(int);
			int num3 = default(int);
			try
			{
				int num = 1;
				if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", CompareMethod.Binary))
				{
					ProjectData.ClearProjectError();
					num2 = 1;
				}
				num = 3;
				SelfService.CheckLatestVer(silent: true);
			}
			catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_0075: Could not find block for branch target IL_0045*/;
			}
			if (num3 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		[DebuggerStepThrough]
		public MyApplication()
			: base(AuthenticationMode.Windows)
		{
			base.Startup += Me_Startup;
			base.IsSingleInstance = true;
			base.EnableVisualStyles = true;
			base.SaveMySettingsOnExit = true;
			base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			base.MainForm = MyProject.Forms.Main;
		}
	}
}
