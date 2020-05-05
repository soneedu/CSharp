using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using My;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using TSSFL.Utility;

[StandardModule]
internal sealed class SelfService
{
	public static void Purchase()
	{
		//Discarded unreachable code: IL_002d, IL_004b, IL_004d, IL_005d, IL_007f
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
			Interaction.Shell("explorer \"http://DuplicateFileFinder4PC.com/order-dpfp.htm?source=dpfp_inter\"", AppWinStyle.NormalFocus);
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_007d: Could not find block for branch target IL_004d*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void CheckLatestVer(bool silent = false)
	{
		string empty = string.Empty;
		WebClient webClient = new WebClient();
		string prompt = GetWord("cannot_connect") + "\r\n\r\n" + GetWord("set_proxy");
		try
		{
			empty = webClient.DownloadString("http://DuplicateFileFinder4PC.com/latestver-photo-p.txt");
			if (empty.Length > 2 && empty.Length < 10)
			{
				if (Operators.CompareString(empty, "8.0", TextCompare: false) != 0)
				{
					if (Interaction.MsgBox(GetWord("new_ver_found"), MsgBoxStyle.OkCancel | MsgBoxStyle.Question | MsgBoxStyle.MsgBoxSetForeground) == MsgBoxResult.Ok)
					{
						Interaction.Shell("explorer \"http://DuplicateFileFinder4PC.com/duplicate-photo-finder-plus.htm?expand=updatetext&source=dpfp_inter#update\"", AppWinStyle.NormalFocus);
						Interaction.Shell("explorer \"http://DuplicateFileFinder4PC.com/f/duplicate-photo-finder-plus.zip\"");
						Application.Exit();
					}
				}
				else if (!silent)
				{
					Interaction.MsgBox(GetWord("no_new_ver"), MsgBoxStyle.Information);
				}
			}
			else if (!silent)
			{
				Interaction.MsgBox(prompt, MsgBoxStyle.Exclamation);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!silent)
			{
				Interaction.MsgBox(prompt, MsgBoxStyle.Exclamation);
			}
			ProjectData.ClearProjectError();
		}
	}

	public static void ScanFiles(string path, bool subFolders)
	{
		//Discarded unreachable code: IL_03e1, IL_04e3, IL_04e5, IL_04f5, IL_0517
		int num = default(int);
		int num4 = default(int);
		try
		{
			Microsoft.VisualBasic.CompilerServices.ProjectData.ClearProjectError();
			num = 1;
			int num2 = 2;
			if (Declarer.scannedFolders % 99 == 0)
			{
				num2 = 3;
				My.MyProject.Forms.Main.lPrompt.Text = GetWord("scanning") + path + "...";
			}
			num2 = 4;
			checked
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(My.MyProject.Forms.Main.lFind.Tag.ToString(), "S", false) != 0)
				{
					num2 = 6;
					string text = My.MySettingsProperty.Settings.exclude.ToLower();
					char[] array = new char[1];
					array[0] = '|';
					string[] array2 = text.Split(array);
					num2 = 7;
					string[] array3 = array2;
					int num3 = 0;
					while (true)
					{
						if (num3 >= array3.Length)
						{
							num2 = 11;
							System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(path);
							num2 = 12;
							if (directoryInfo != null)
							{
								num2 = 14;
								System.IO.FileInfo[] files = directoryInfo.GetFiles();
								num2 = 15;
								Declarer.scannedFolders++;
								num2 = 16;
								Declarer.scannedFiles += files.Length;
								num2 = 17;
								System.IO.FileInfo[] array4 = files;
								for (int i = 0; i < array4.Length; num2 = 53, i++)
								{
									System.IO.FileInfo fileInfo = array4[i];
									num2 = 18;
									if (fileInfo == null)
									{
										continue;
									}
									num2 = 20;
									if (My.MySettingsProperty.Settings.hidden)
									{
										num2 = 21;
										if ((fileInfo.Attributes & System.IO.FileAttributes.Hidden) > (System.IO.FileAttributes)0)
										{
											continue;
										}
									}
									num2 = 23;
									if (fileInfo.Length < 1)
									{
										continue;
									}
									num2 = 25;
									string text2 = fileInfo.Extension.ToLower() + ".";
									num2 = 26;
									if (text2.Length < 2)
									{
										continue;
									}
									num2 = 28;
									if (My.MyProject.Forms.Main.cbJPG.Checked)
									{
										num2 = 29;
										if (".jpg.jpeg.jpe.j.".Contains(text2))
										{
											goto IL_032b;
										}
									}
									num2 = 31;
									if (My.MyProject.Forms.Main.cbPNG.Checked)
									{
										num2 = 32;
										if (".png.".Contains(text2))
										{
											goto IL_032b;
										}
									}
									num2 = 34;
									if (My.MyProject.Forms.Main.cbGIF.Checked)
									{
										num2 = 35;
										if (".gif.".Contains(text2))
										{
											goto IL_032b;
										}
									}
									num2 = 37;
									if (My.MyProject.Forms.Main.cbBMP.Checked)
									{
										num2 = 38;
										if (".bmp.".Contains(text2))
										{
											goto IL_032b;
										}
									}
									num2 = 40;
									if (My.MyProject.Forms.Main.cbTIF.Checked)
									{
										num2 = 41;
										if (".tif.tiff.".Contains(text2))
										{
											goto IL_032b;
										}
									}
									num2 = 43;
									if (My.MyProject.Forms.Main.cbIcon.Checked)
									{
										num2 = 44;
										if (".ico.".Contains(text2))
										{
											goto IL_032b;
										}
									}
									num2 = 46;
									if (!My.MyProject.Forms.Main.cbOthers.Checked)
									{
										continue;
									}
									num2 = 47;
									if (!Declarer.allPicExts.Replace(".jpg.jpeg.jpe.j.", ".").Replace(".png.", ".").Replace(".gif.", ".")
										.Replace(".bmp.", ".")
										.Replace(".tif.tiff.", ".")
										.Replace(".ico.", ".")
										.Contains(text2))
									{
										continue;
									}
									goto IL_032b;
								IL_032b:
									num2 = 50;
									if (!Declarer.ScannedResult.ContainsKey(fileInfo.Length))
									{
										num2 = 51;
										Declarer.ScannedResult.Add(fileInfo.Length, new System.Collections.Generic.List<string>());
									}
									num2 = 52;
									Declarer.ScannedResult[fileInfo.Length].Add(fileInfo.FullName);
								}
								num2 = 54;
								System.Windows.Forms.Application.DoEvents();
								num2 = 55;
								if (subFolders)
								{
									num2 = 56;
									System.IO.DirectoryInfo[] directories = directoryInfo.GetDirectories();
									for (int j = 0; j < directories.Length; j++)
									{
										System.IO.DirectoryInfo directoryInfo2 = directories[j];
										num2 = 57;
										if (directoryInfo2 != null)
										{
											num2 = 59;
											ScanFiles(directoryInfo2.FullName, subFolders);
										}
										num2 = 60;
									}
								}
							}
							break;
						}
						string str = array3[num3];
						num2 = 8;
						if (Microsoft.VisualBasic.CompilerServices.LikeOperator.LikeString(path.ToLower() + "\\", str + "\\*", Microsoft.VisualBasic.CompareMethod.Binary))
						{
							break;
						}
						num2 = 10;
						num3++;
					}
				}
			}
		}
		catch (Exception obj) when ((obj is System.Exception && num != 0) & (num4 == 0))
		{
			Microsoft.VisualBasic.CompilerServices.ProjectData.SetProjectError((System.Exception)obj);
			/*Error near IL_0515: Could not find block for branch target IL_04e5*/
			;
		}
		if (num4 != 0)
		{
			Microsoft.VisualBasic.CompilerServices.ProjectData.ClearProjectError();
		}
	}

	public static void ScanFile(string one)
	{
		//Discarded unreachable code: IL_02ef, IL_03b1, IL_03b3, IL_03c3, IL_03e5
		checked
		{
			int num = default(int);
			int num4 = default(int);
			try
			{
				ProjectData.ClearProjectError();
				num = 1;
				int num2 = 2;
				FileInfo fileInfo = new FileInfo(one);
				num2 = 3;
				if (fileInfo != null)
				{
					num2 = 5;
					string[] array = My.MySettingsProperty.Settings.exclude.ToLower().Split('|');
					num2 = 6;
					string[] array2 = array;
					int num3 = 0;
					while (true)
					{
						if (num3 < array2.Length)
						{
							string str = array2[num3];
							num2 = 7;
							if (LikeOperator.LikeString(fileInfo.DirectoryName.ToLower() + "\\", str + "\\*", CompareMethod.Binary))
							{
								break;
							}
							num2 = 9;
							num3++;
							continue;
						}
						num2 = 10;
						Declarer.scannedFiles++;
						num2 = 11;
						Declarer.scannedSize += fileInfo.Length;
						num2 = 12;
						if (My.MySettingsProperty.Settings.hidden)
						{
							num2 = 13;
							if ((fileInfo.Attributes & FileAttributes.Hidden) > (FileAttributes)0)
							{
								break;
							}
						}
						num2 = 15;
						if (fileInfo.Length < 1)
						{
							break;
						}
						num2 = 17;
						string text = fileInfo.Extension.ToLower() + ".";
						num2 = 18;
						if (text.Length < 2)
						{
							break;
						}
						num2 = 20;
						if (My.MyProject.Forms.Main.cbJPG.Checked)
						{
							num2 = 21;
							if (".jpg.jpeg.jpe.".Contains(text))
							{
								goto IL_029f;
							}
						}
						num2 = 23;
						if (My.MyProject.Forms.Main.cbPNG.Checked)
						{
							num2 = 24;
							if (".png.".Contains(text))
							{
								goto IL_029f;
							}
						}
						num2 = 26;
						if (My.MyProject.Forms.Main.cbGIF.Checked)
						{
							num2 = 27;
							if (".gif.".Contains(text))
							{
								goto IL_029f;
							}
						}
						num2 = 29;
						if (My.MyProject.Forms.Main.cbBMP.Checked)
						{
							num2 = 30;
							if (".bmp.".Contains(text))
							{
								goto IL_029f;
							}
						}
						num2 = 32;
						if (My.MyProject.Forms.Main.cbTIF.Checked)
						{
							num2 = 33;
							if (".tif.tiff.".Contains(text))
							{
								goto IL_029f;
							}
						}
						num2 = 35;
						if (My.MyProject.Forms.Main.cbIcon.Checked)
						{
							num2 = 36;
							if (".ico.".Contains(text))
							{
								goto IL_029f;
							}
						}
						num2 = 38;
						if (!My.MyProject.Forms.Main.cbOthers.Checked)
						{
							break;
						}
						num2 = 39;
						if (!Declarer.allPicExts.Replace(".jpg.jpeg.jpe.", ".").Replace(".png.", ".").Replace(".gif.", ".")
							.Replace(".bmp.", ".")
							.Replace(".tif.tiff.", ".")
							.Replace(".ico.", ".")
							.Contains(text))
						{
							break;
						}
						goto IL_029f;
						IL_029f:
						num2 = 42;
						if (!Declarer.ScannedResult.ContainsKey(fileInfo.Length))
						{
							num2 = 43;
							Declarer.ScannedResult.Add(fileInfo.Length, new List<string>());
						}
						num2 = 44;
						Declarer.ScannedResult[fileInfo.Length].Add(fileInfo.FullName);
						break;
					}
				}
			}
			catch (Exception obj) when ((obj is Exception && num != 0) & (num4 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_03e3: Could not find block for branch target IL_03b3*/;
			}
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void CompareFiles(ref KeyValuePair<long, List<string>> kvpFiles)
	{
		//Discarded unreachable code: IL_0234, IL_02c6, IL_02c8, IL_02d8, IL_02fa
		int num2 = default(int);
		int num4 = default(int);
		try
		{
			int num = 1;
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", CompareMethod.Binary))
			{
				ProjectData.ClearProjectError();
				num2 = 1;
			}
			num = 3;
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			num = 4;
			byte[] array = new byte[16];
			num = 5;
			Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
			num = 6;
			List<string>.Enumerator enumerator = kvpFiles.Value.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				num = 7;
				if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(current))
				{
					num = 8;
					FileStream fileStream = new FileStream(current, FileMode.Open, FileAccess.Read, FileShare.Read, 8192);
					num = 9;
					mD5CryptoServiceProvider.ComputeHash(fileStream);
					num = 10;
					array = mD5CryptoServiceProvider.Hash;
					num = 11;
					fileStream.Close();
					num = 12;
					StringBuilder stringBuilder = new StringBuilder();
					num = 13;
					byte[] array2 = array;
					foreach (byte b in array2)
					{
						num = 14;
						stringBuilder.Append($"{b:X2}");
						num = 15;
					}
					num = 16;
					if (!dictionary.ContainsKey(stringBuilder.ToString()))
					{
						num = 17;
						dictionary.Add(stringBuilder.ToString(), new List<string>());
					}
					num = 18;
					dictionary[stringBuilder.ToString()].Add(current);
					num = 19;
					Application.DoEvents();
				}
				num = 20;
			}
			num = 21;
			((IDisposable)enumerator).Dispose();
			num = 22;
			mD5CryptoServiceProvider.Clear();
			num = 23;
			int num3 = 0;
			num = 24;
			Dictionary<string, List<string>>.Enumerator enumerator2 = dictionary.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				KeyValuePair<string, List<string>> current2 = enumerator2.Current;
				num = 25;
				if (current2.Value.Count > 1)
				{
					num = 26;
					if (Declarer.ComparedResult.ContainsKey(kvpFiles.Key.ToString()))
					{
						num = 27;
						Declarer.ComparedResult.Add(kvpFiles.Key.ToString() + "." + Strings.Format(num3, "000"), current2.Value);
					}
					else
					{
						num = 29;
						Declarer.ComparedResult.Add(kvpFiles.Key.ToString(), current2.Value);
					}
					num = 30;
					num3 = checked(num3 + 1);
				}
				num = 31;
			}
			num = 32;
			((IDisposable)enumerator2).Dispose();
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num4 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_02f8: Could not find block for branch target IL_02c8*/;
		}
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static string IntelligentSize(long originalSize)
	{
		//Discarded unreachable code: IL_0153, IL_01b1, IL_01b3, IL_01c3, IL_01e5
		int num2 = default(int);
		string result = "";
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
			string empty = string.Empty;
			num = 4;
			num = 6;
			if (originalSize >= 1073741824)
			{
				num = 7;
				empty = Strings.Format((double)originalSize / 1024.0 / 1024.0 / 1024.0, "#,0.##") + " GB";
			}
			else
			{
				num = 9;
				if (originalSize >= 1048576)
				{
					num = 10;
					empty = Strings.Format((double)originalSize / 1024.0 / 1024.0, "#,0.#") + " MB";
				}
				else
				{
					num = 12;
					if (originalSize >= 1024)
					{
						num = 13;
						empty = Strings.Format((double)originalSize / 1024.0, "#,0") + " KB";
					}
					else
					{
						num = 15;
						if (originalSize != 1)
						{
							num = 16;
							empty = Strings.Format(originalSize, "#,0") + GetWord("bytes");
						}
						else
						{
							num = 18;
							empty = Strings.Format(originalSize, "#,0") + GetWord("byte");
						}
					}
				}
			}
			num = 19;
			result = empty;
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_01e3: Could not find block for branch target IL_01b3*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static string Letter2Num(string letters)
	{
		//Discarded unreachable code: IL_01a0, IL_022e, IL_0230, IL_0240, IL_0262
		int num2 = default(int);
		string result ="";
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
			string text = string.Empty;
			num = 4;
			char[] array = letters.ToCharArray();
			num = 5;
			char[] array2 = array;
			foreach (char c in array2)
			{
				num = 6;
				switch (c)
				{
				case 'Z':
					num = 8;
					text += "1";
					break;
				case 'S':
					num = 10;
					text += "9";
					break;
				case 'Y':
					num = 12;
					text += "3";
					break;
				case 'G':
					num = 14;
					text += "0";
					break;
				case 'X':
					num = 16;
					text += "8";
					break;
				case 'D':
					num = 18;
					text += "4";
					break;
				case 'C':
					num = 20;
					text += "2";
					break;
				case 'P':
					num = 22;
					text += "5";
					break;
				case 'K':
					num = 24;
					text += "6";
					break;
				case 'T':
					num = 26;
					text += "7";
					break;
				default:
					num = 28;
					text += "ERROR!";
					break;
				}
				num = 30;
			}
			num = 31;
			result = text;
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0260: Could not find block for branch target IL_0230*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool VerifyKey(string key, ref string type, ref string pcs)
	{
		//Discarded unreachable code: IL_02a7, IL_02bb, IL_02dd
		int num = default(int);
		bool result = false;
		int num3 = default(int);
		try
		{
			ProjectData.ClearProjectError();
			num = 2;
			string text = key.Trim();
			string empty = string.Empty;
			string[] array = "|XXXX-XXXX-XXXX-XXXX@5.0|TDPF-CYZG-ZYSG-ZGYY@7.0|".Split('|');
			int num2 = 0;
			while (true)
			{
				if (num2 < array.Length)
				{
					empty = array[num2];
					if (empty.Length < 1 || Operators.CompareString(empty.Split('@')[0], text, TextCompare: false) != 0 || Operators.CompareString("8.0", empty.Split('@')[1], TextCompare: false) == 0)
					{
						num2 = checked(num2 + 1);
						continue;
					}
					if (Interaction.MsgBox(GetWord("no_upgrade"), MsgBoxStyle.OkCancel | MsgBoxStyle.Question | MsgBoxStyle.MsgBoxSetForeground) == MsgBoxResult.Ok)
					{
						Purchase();
					}
				}
				else if (text.Length >= 19 && Operators.CompareString(text.Substring(0, 4), "TDPF", TextCompare: false) == 0 && Operators.CompareString(text.Substring(4, 1), "-", TextCompare: false) == 0)
				{
					empty = Letter2Num(text.Substring(5, 2));
					if (Conversions.ToInteger(empty) <= 59 && Conversions.ToInteger(empty) >= 0)
					{
						empty = Letter2Num(text.Substring(7, 2));
						if (Conversions.ToInteger(empty) <= 12 && Conversions.ToInteger(empty) >= 1 && Operators.CompareString(text.Substring(9, 1), "-", TextCompare: false) == 0)
						{
							empty = Letter2Num(text.Substring(10, 2));
							if (Conversions.ToInteger(empty) <= 31 && Conversions.ToInteger(empty) >= 1)
							{
								empty = text.Substring(12, 2);
								if (General.InStrings(empty, "SG", "PS", "HM", "TM", "EP") && Operators.CompareString(text.Substring(14, 1), "-", TextCompare: false) == 0)
								{
									empty = Letter2Num(text.Substring(15, 2));
									if (Conversions.ToInteger(empty) <= 23 && Conversions.ToInteger(empty) >= 0)
									{
										empty = Letter2Num(text.Substring(17, 2));
										if (Conversions.ToInteger(empty) <= 59 && Conversions.ToInteger(empty) >= 0)
										{
											if (text.Length <= 19)
											{
												goto IL_0294;
											}
											if (Operators.CompareString(text.Substring(19, 1), "-", TextCompare: false) == 0)
											{
												empty = Letter2Num(text.Substring(20, 6));
												if (Conversions.ToInteger(empty) <= 999999 && Conversions.ToInteger(empty) >= 11)
												{
													pcs = Conversions.ToInteger(empty).ToString();
													goto IL_0294;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				result = false;
				break;
				IL_0294:
				type = text.Substring(12, 2);
				result = true;
				break;
			}
		}
		catch (Exception obj) when ((obj is Exception && num != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_02db: Could not find block for branch target IL_02a7*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void DisplayLicense(ref Form inter)
	{
		//Discarded unreachable code: IL_0242, IL_02c4, IL_02c6, IL_02d6, IL_02f8
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
			string empty = string.Empty;
			num = 4;
			string licenseType = Declarer.licenseType;
			if (Operators.CompareString(licenseType, "SG", TextCompare: false) != 0)
			{
				if (Operators.CompareString(licenseType, "PS", TextCompare: false) != 0)
				{
					if (Operators.CompareString(licenseType, "HM", TextCompare: false) != 0)
					{
						if (Operators.CompareString(licenseType, "TM", TextCompare: false) != 0)
						{
							if (Operators.CompareString(licenseType, "EP", TextCompare: false) == 0)
							{
								num = 14;
								empty = GetWord("enter_license_main_cust").Replace("XXXX", Strings.Format(Conversions.ToInteger(Declarer.licensedPCs), "#,0"));
							}
							else
							{
								num = 16;
								empty = GetWord("trial_version");
							}
						}
						else
						{
							num = 12;
							empty = GetWord("team_license_main_cust").Replace("XXXX", Strings.Format(Conversions.ToInteger(Declarer.licensedPCs), "#,0"));
						}
					}
					else
					{
						num = 10;
						empty = GetWord("home_license_main");
					}
				}
				else
				{
					num = 8;
					empty = GetWord("personal_license_main");
				}
			}
			else
			{
				num = 6;
				empty = GetWord("single_license_main");
			}
			num = 18;
			if (Operators.CompareString(inter.Name, "Main", TextCompare: false) == 0)
			{
				num = 19;
				if (Declarer.licenseType.Length < 1)
				{
					num = 20;
					My.MyProject.Forms.Main.lLicType.Text = GetWord("buy_full");
					num = 21;
					My.MyProject.Forms.Main.lLicType.Cursor = Cursors.Hand;
					num = 22;
					My.MyProject.Forms.Main.lLicType.Font = new Font("Segoe UI", 15f, FontStyle.Underline, GraphicsUnit.Pixel);
				}
				else
				{
					num = 24;
					My.MyProject.Forms.Main.lLicType.Text = empty;
					num = 25;
					My.MyProject.Forms.Main.lLicType.Cursor = Cursors.Default;
					num = 26;
					My.MyProject.Forms.Main.lLicType.Font = new Font("Segoe UI", 15f, FontStyle.Regular, GraphicsUnit.Pixel);
				}
			}
			else
			{
				num = 28;
				My.MyProject.Forms.About.lLicenseType.Text = empty.Replace("\n", " ");
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_02f6: Could not find block for branch target IL_02c6*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void InitSettings()
	{
		//Discarded unreachable code: IL_015f, IL_01c9, IL_01cb, IL_01db, IL_01fd
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
			My.MySettingsProperty.Settings.subfolders = true;
			num = 4;
			My.MySettingsProperty.Settings.hidden = true;
			num = 5;
			My.MySettingsProperty.Settings.smart = true;
			num = 6;
			My.MySettingsProperty.Settings.created = "L";
			num = 7;
			My.MySettingsProperty.Settings.path = "S";
			num = 8;
			My.MySettingsProperty.Settings.name = "S";
			num = 9;
			string str = "|";
			num = 10;
			str += Environment.GetEnvironmentVariable("WinDir");
			num = 11;
			str = str + "|" + Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
			num = 12;
			string empty = string.Empty;
			num = 13;
			empty = Environment.GetEnvironmentVariable("ProgramFiles(x86)");
			num = 14;
			if (empty != null)
			{
				num = 15;
				if (empty.Length > 0)
				{
					num = 16;
					str = str + "|" + empty;
				}
			}
			num = 17;
			str = str + "|" + Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
			num = 18;
			str = str + "|" + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			num = 19;
			str = str + "|" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "|";
			num = 20;
			My.MySettingsProperty.Settings.exclude = str;
			num = 21;
			My.MySettingsProperty.Settings.types = "P:JPEG Image:jpg.jpeg.jpe|P:Portable Network Graphic:png|P:Graphical Interchange Format File:gif|P:Bitmap Image File:bmp|P:Icon File:ico|P:Adobe Photoshop Document:psd|P:Tagged Image File:tif.tiff|P:Windows Cursor:cur|P:Windows Animated Cursor:ani|P:Targa Graphic:tga|P:Adobe Illustrator File:ai|P:Adobe PhotoDeluxe Image:pdd|P:Deluxe Paint Bitmap Image:lbm|P:Device Independent Bitmap File:dib|P:Digital Negative Image File:dng|P:Dr. Halo Bitmap Image File:cut|P:Encapsulated PostScript File:eps|P:High Dynamic Range Image File:hdr|P:JPEG 2000 Image:jp2.j2k.j2c|P:Kodak Photo CD Image File:pcd|P:Multiple Network Graphic:mng|P:Paintbrush Bitmap Image File:pcx|P:Pentax Electronic File:pef|P:Picture File:pct.pict.pic|P:Pixar Image File:pxr|P:Portable Pixmap Image File:ppm|P:Misc. Camera RAW File:raw.mos.mrw.nef.orf.dcr.crw.raf|P:Run Length Encoded Bitmap:rle|P:Scitex Continuous Tone File:sct|P:Silicon Graphics Image File:sgi|P:Sun Raster Graphic:ras|P:Targa Bitmap Image File:vda|P:Targa ICB Bitmap Image:icb|P:Wireless Bitmap Image File:wbm.wbmp|P:X11 Graphic:xbm.xpm";
			num = 22;
			My.MySettingsProperty.Settings.Save();
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_01fb: Could not find block for branch target IL_01cb*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void UpdateExts()
	{
		//Discarded unreachable code: IL_00a7, IL_00d9, IL_00db, IL_00eb, IL_010d
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
			Declarer.allPicExts = "";
			num = 4;
			string[] array = My.MySettingsProperty.Settings.types.Split('|');
			num = 5;
			string[] array2 = array;
			foreach (string text in array2)
			{
				num = 6;
				Declarer.allPicExts = Declarer.allPicExts + "." + text.Split(':')[2];
				num = 7;
			}
			num = 8;
			Declarer.allPicExts += ".";
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_010b: Could not find block for branch target IL_00db*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void UpgradeSettings()
	{
		//Discarded unreachable code: IL_0050, IL_007a, IL_007c, IL_008c, IL_00ae
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
			if (!My.MySettingsProperty.Settings.upgraded)
			{
				num = 4;
				My.MySettingsProperty.Settings.Upgrade();
				num = 5;
				My.MySettingsProperty.Settings.upgraded = true;
				num = 6;
				My.MySettingsProperty.Settings.Save();
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_00ac: Could not find block for branch target IL_007c*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void WaitPrompt(string prompt, ref Form f, ref Label l)
	{
		//Discarded unreachable code: IL_00b8, IL_00ee, IL_00f0, IL_0100, IL_0122
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
			Cursor.Current = Cursors.WaitCursor;
			num = 4;
			f.Enabled = false;
			num = 5;
			l.Visible = true;
			num = 6;
			l.Text = prompt;
			num = 7;
			l.Location = checked(new Point((int)Math.Round((double)(f.ClientSize.Width - l.Width) / 2.0), (int)Math.Round((double)(f.ClientSize.Height - l.Height) / 2.0)));
			num = 8;
			l.BringToFront();
			num = 9;
			f.Refresh();
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0120: Could not find block for branch target IL_00f0*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void AfterPrompt(ref Form f, ref Label l)
	{
		//Discarded unreachable code: IL_003d, IL_0063, IL_0065, IL_0075, IL_0097
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
			Cursor.Current = Cursors.Default;
			num = 4;
			l.Visible = false;
			num = 5;
			f.Enabled = true;
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0095: Could not find block for branch target IL_0065*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static string GetWord(string entry)
	{
		//Discarded unreachable code: IL_0054, IL_007e, IL_0080, IL_0090, IL_00b2
		int num2 = default(int);
		string result ="";
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
			if (entry.ToLower() != null)
			{
				num = 4;
				result = entry.ToLower().ToString();
			}
			else
			{
				num = 6;
				result = entry;
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_00b0: Could not find block for branch target IL_0080*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void ReloadInterfacesWithLang()
	{
		//Discarded unreachable code: IL_0121, IL_017b, IL_017d, IL_018d, IL_01af
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
			My.MyProject.Forms.About.Dispose();
			num = 4;
			My.MyProject.Forms.About = null;
			num = 5;
			My.MyProject.Forms.DrivesSelector.Dispose();
			num = 6;
			My.MyProject.Forms.DrivesSelector = null;
			num = 7;
			My.MyProject.Forms.FFSelector.Dispose();
			num = 8;
			My.MyProject.Forms.FFSelector = null;
			num = 9;
			My.MyProject.Forms.Options.Dispose();
			num = 10;
			My.MyProject.Forms.Options = null;
			num = 11;
			My.MyProject.Forms.Result.Dispose();
			num = 12;
			My.MyProject.Forms.Result = null;
			num = 13;
			My.MyProject.Forms.Types.Dispose();
			num = 14;
			My.MyProject.Forms.Types = null;
			num = 15;
			My.MyProject.Forms.DelProgress.Dispose();
			num = 16;
			My.MyProject.Forms.DelProgress = null;
			num = 17;
			My.MyProject.Forms.Main.LoadLangText();
			num = 18;
			Form inter = My.MyProject.Forms.Main;
			DisplayLicense(ref inter);
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_01ad: Could not find block for branch target IL_017d*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
