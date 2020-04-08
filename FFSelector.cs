using IWshRuntimeLibrary;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using My;
using My.Resources;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TSSFL.Utility;

[DesignerGenerated]
public class FFSelector : Form
{
	private IContainer components;

	private TreeView tv;
	private Label lCancel;
	private Label lOK;
	private Button bCancel;
	private Button bOK;
	private ImageList ilTV;
	private ListBox lbSelected;
	private Label lRemove;
	private Label lDrives;
	private Label Label2;
	private Label lCls;


	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
            this.components = new System.ComponentModel.Container();
            this.tv = new System.Windows.Forms.TreeView();
            this.ilTV = new System.Windows.Forms.ImageList(this.components);
            this.lCancel = new System.Windows.Forms.Label();
            this.lOK = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.lbSelected = new System.Windows.Forms.ListBox();
            this.lRemove = new System.Windows.Forms.Label();
            this.lDrives = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lCls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.AccessibleDescription = "";
            this.tv.BackColor = System.Drawing.Color.White;
            this.tv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv.CheckBoxes = true;
            this.tv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tv.HideSelection = false;
            this.tv.ImageIndex = 0;
            this.tv.ImageList = this.ilTV;
            this.tv.Location = new System.Drawing.Point(9, 37);
            this.tv.Name = "tv";
            this.tv.SelectedImageIndex = 0;
            this.tv.Size = new System.Drawing.Size(480, 591);
            this.tv.TabIndex = 8;
            this.tv.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterCheck);
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            this.tv.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseDoubleClick);
            // 
            // ilTV
            // 
            this.ilTV.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilTV.ImageSize = new System.Drawing.Size(16, 16);
            this.ilTV.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lCancel
            // 
            this.lCancel.AccessibleDescription = "cancel";
            this.lCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lCancel.ForeColor = System.Drawing.Color.White;
            this.lCancel.Location = new System.Drawing.Point(752, 601);
            this.lCancel.Name = "lCancel";
            this.lCancel.Size = new System.Drawing.Size(81, 27);
            this.lCancel.TabIndex = 159;
            this.lCancel.Text = "Cancel";
            this.lCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lCancel.Click += new System.EventHandler(this.lCancel_Click);
            this.lCancel.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.lCancel.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // lOK
            // 
            this.lOK.AccessibleDescription = "ok";
            this.lOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lOK.ForeColor = System.Drawing.Color.White;
            this.lOK.Location = new System.Drawing.Point(668, 601);
            this.lOK.Name = "lOK";
            this.lOK.Size = new System.Drawing.Size(82, 27);
            this.lOK.TabIndex = 158;
            this.lOK.Text = "OK";
            this.lOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lOK.Click += new System.EventHandler(this.Buttons_Click);
            this.lOK.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.lOK.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(69, 1000);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 160;
            this.bCancel.Text = "Button1";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(2, 1000);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 161;
            this.bOK.Text = "Button1";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // lbSelected
            // 
            this.lbSelected.BackColor = System.Drawing.Color.White;
            this.lbSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lbSelected.FormattingEnabled = true;
            this.lbSelected.HorizontalScrollbar = true;
            this.lbSelected.ItemHeight = 15;
            this.lbSelected.Location = new System.Drawing.Point(498, 37);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbSelected.Size = new System.Drawing.Size(335, 555);
            this.lbSelected.Sorted = true;
            this.lbSelected.TabIndex = 162;
            // 
            // lRemove
            // 
            this.lRemove.AccessibleDescription = "remove1";
            this.lRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lRemove.ForeColor = System.Drawing.Color.White;
            this.lRemove.Location = new System.Drawing.Point(498, 601);
            this.lRemove.Name = "lRemove";
            this.lRemove.Size = new System.Drawing.Size(83, 27);
            this.lRemove.TabIndex = 163;
            this.lRemove.Text = "Remove";
            this.lRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lRemove.Click += new System.EventHandler(this.Buttons_Click);
            this.lRemove.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.lRemove.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // lDrives
            // 
            this.lDrives.AccessibleDescription = "selected_resources";
            this.lDrives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lDrives.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lDrives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lDrives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lDrives.Location = new System.Drawing.Point(498, 9);
            this.lDrives.Name = "lDrives";
            this.lDrives.Size = new System.Drawing.Size(335, 28);
            this.lDrives.TabIndex = 164;
            this.lDrives.Text = "Selected Resources";
            this.lDrives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.AccessibleDescription = "all_selecting";
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label2.Location = new System.Drawing.Point(9, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(480, 28);
            this.Label2.TabIndex = 165;
            this.Label2.Text = "All Resources for Selecting";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lCls
            // 
            this.lCls.AccessibleDescription = "clear1";
            this.lCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lCls.ForeColor = System.Drawing.Color.White;
            this.lCls.Location = new System.Drawing.Point(583, 601);
            this.lCls.Name = "lCls";
            this.lCls.Size = new System.Drawing.Size(83, 27);
            this.lCls.TabIndex = 166;
            this.lCls.Text = "Clear";
            this.lCls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lCls.Click += new System.EventHandler(this.Buttons_Click);
            this.lCls.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.lCls.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // FFSelector
            // 
            this.AcceptButton = this.bOK;
            this.AccessibleDescription = "ff_selector";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(842, 637);
            this.Controls.Add(this.lCls);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lDrives);
            this.Controls.Add(this.lRemove);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.lCancel);
            this.Controls.Add(this.lOK);
            this.Controls.Add(this.tv);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FFSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Folder(s) / File(s) Selector";
            this.ResumeLayout(false);

	}

	private void Buttons_MouseEnter(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_002f, IL_004d, IL_004f, IL_005f, IL_0081
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			int num = 1;
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", Microsoft.VisualBasic.CompareMethod.Binary))
			{
				ProjectData.ClearProjectError();
				num2 = 1;
			}
			num = 3;
			((Control)sender).BackColor = Declarer.darkGray;
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_007f: Could not find block for branch target IL_004f*/
			;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}

	}

	private void Buttons_MouseLeave(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_002f, IL_004d, IL_004f, IL_005f, IL_0081
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			int num = 1;
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", Microsoft.VisualBasic.CompareMethod.Binary))
			{
				ProjectData.ClearProjectError();
				num2 = 1;
			}
			num = 3;
			((Control)sender).BackColor = Declarer.lightGray;
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_007f: Could not find block for branch target IL_004f*/
			;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void lCancel_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0025, IL_0043, IL_0045, IL_0055, IL_0077
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			int num = 1;
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", Microsoft.VisualBasic.CompareMethod.Binary))
			{
				ProjectData.ClearProjectError();
				num2 = 1;
			}
			num = 3;
			Close();
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

	private void Me_Load(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0268, IL_02f2, IL_02f4, IL_0304, IL_0326
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			int num = 1;
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", Microsoft.VisualBasic.CompareMethod.Binary))
			{
				ProjectData.ClearProjectError();
				num2 = 1;
			}
			num = 3;
			ilTV.Images.Clear();
			num = 4;
			ilTV.Images.Add(My.Resources.Resources.drive16);
			num = 5;
			ilTV.Images.Add(My.Resources.Resources.rom16);
			num = 6;
			ilTV.Images.Add(My.Resources.Resources.network16);
			num = 7;
			ilTV.Images.Add(My.Resources.Resources.folder16);
			num = 8;
			ilTV.Images.Add(My.Resources.Resources.file16);
			num = 9;
			tv.Nodes.Clear();
			num = 10;
			lbSelected.Items.Clear();
			num = 11;
			IEnumerator enumerator = My.MyProject.Forms.Main.lbFF.Items.GetEnumerator();
			while (enumerator.MoveNext())
			{
				//Exception objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				num = 12;
				lbSelected.Items.Add(RuntimeHelpers.GetObjectValue(enumerator.Current));
				num = 13;
			}
			num = 14;
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
			num = 15;
			DriveInfo[] drives = DriveInfo.GetDrives();
			num = 16;
			string empty = string.Empty;
			num = 17;
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				num = 18;
				if (driveInfo.IsReady)
				{
					num = 19;
					empty = driveInfo.VolumeLabel + " (" + driveInfo.Name.Replace(":\\", ":") + ")";
					num = 20;
					TreeNode treeNode;
					if (driveInfo.DriveType == DriveType.CDRom)
					{
						num = 21;
						treeNode = new TreeNode(empty, 1, 1);
					}
					else
					{
						num = 23;
						if (driveInfo.DriveType == DriveType.Network)
						{
							num = 24;
							empty = ((IFileSystem3)new FileSystemObjectClass()).GetDrive(driveInfo.Name).ShareName + " (" + driveInfo.Name.Replace(":\\", ":") + ")";
							num = 25;
							treeNode = new TreeNode(empty, 2, 2);
						}
						else
						{
							num = 27;
							treeNode = new TreeNode(empty, 0, 0);
						}
					}
					num = 28;
					treeNode.Name = driveInfo.Name.ToLower();
					num = 29;
					tv.Nodes.Add(treeNode);
				}
				num = 30;
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0324: Could not find block for branch target IL_02f4*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void tv_AfterCheck(object sender, TreeViewEventArgs e)
	{
		//Discarded unreachable code: IL_048f, IL_0585, IL_0587, IL_0597, IL_05b9
		checked
		{
			int num2 = default(int);
			int num6 = default(int);
			try
			{
				int num = 1;
				if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", Microsoft.VisualBasic.CompareMethod.Binary))
				{
					ProjectData.ClearProjectError();
					num2 = 1;
				}
				num = 3;
				if (!e.Node.Checked)
				{
					num = 55;
					lbSelected.Items.Remove(e.Node.Name);
					goto IL_0457;
				}
				num = 4;
				if (e.Node.Level != 0)
				{
					goto IL_0072;
				}
				num = 5;
				if (!My.MySettingsProperty.Settings.subfolders)
				{
					goto IL_0072;
				}
				num = 6;
				e.Node.Checked = false;
				num = 7;
				Interaction.MsgBox(SelfService.GetWord("not_root"), MsgBoxStyle.Information);
				goto end_IL_0000;
				IL_0072:
				num = 9;
				if (Microsoft.VisualBasic.FileIO.FileSystem.DirectoryExists(e.Node.Name))
				{
					num = 10;
					if (My.MySettingsProperty.Settings.subfolders)
					{
						num = 11;
						int num3 = lbSelected.Items.Count - 1;
						num = 12;
						for (int i = num3; i >= 0; i += -1)
						{
							num = 13;
							if (LikeOperator.LikeString(lbSelected.Items[i].ToString().ToLower(), e.Node.Name.ToLower() + "\\*", Microsoft.VisualBasic.CompareMethod.Binary))
							{
								num = 14;
								lbSelected.Items.RemoveAt(i);
							}
							num = 15;
						}
						num = 16;
						num3 = lbSelected.Items.Count - 1;
						num = 17;
						int num4 = num3;
						while (num4 >= 0)
						{
							num = 18;
							if (!LikeOperator.LikeString(e.Node.Name.ToLower(), lbSelected.Items[num4].ToString().ToLower() + "\\*", Microsoft.VisualBasic.CompareMethod.Binary))
							{
								num = 22;
								num4 += -1;
								continue;
							}
							num = 19;
							e.Node.Checked = false;
							num = 20;
							Interaction.MsgBox(SelfService.GetWord("sel_again"), MsgBoxStyle.Information);
							goto end_IL_0000;
						}
					}
					else
					{
						num = 24;
						int num3 = lbSelected.Items.Count - 1;
						num = 25;
						for (int j = num3; j >= 0; j += -1)
						{
							num = 26;
							if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(lbSelected.Items[j].ToString().ToLower()))
							{
								num = 27;
								if (Operators.CompareString(new FileInfo(lbSelected.Items[j].ToString()).DirectoryName.ToLower(), e.Node.Name.ToLower(), TextCompare: false) == 0)
								{
									num = 28;
									lbSelected.Items.RemoveAt(j);
								}
							}
							num = 29;
						}
					}
				}
				num = 30;
				if (!Microsoft.VisualBasic.FileIO.FileSystem.FileExists(e.Node.Name))
				{
					goto IL_03fc;
				}
				num = 31;
				if (My.MySettingsProperty.Settings.subfolders)
				{
					num = 32;
					int num3 = lbSelected.Items.Count - 1;
					num = 33;
					int num5 = num3;
					while (num5 >= 0)
					{
						num = 34;
						if (!LikeOperator.LikeString(e.Node.Name.ToLower(), lbSelected.Items[num5].ToString().ToLower() + "\\*", Microsoft.VisualBasic.CompareMethod.Binary))
						{
							num = 38;
							num5 += -1;
							continue;
						}
						num = 35;
						e.Node.Checked = false;
						num = 36;
						Interaction.MsgBox(SelfService.GetWord("sel_again"), MsgBoxStyle.Information);
						goto end_IL_0000;
					}
					goto IL_0376;
				}
				num = 40;
				if (lbSelected.FindStringExact(e.Node.Parent.Name) == -1)
				{
					goto IL_0376;
				}
				num = 41;
				e.Node.Checked = false;
				num = 42;
				Interaction.MsgBox(SelfService.GetWord("file_again"), MsgBoxStyle.Information);
				goto end_IL_0000;
				IL_0457:
				num = 56;
				if (lbSelected.Items.Count > 0 && lbSelected.SelectedIndex < 0)
				{
					num = 57;
					lbSelected.SelectedIndex = 0;
				}
				goto end_IL_0000;
				IL_03fc:
				num = 52;
				if (lbSelected.FindStringExact(e.Node.Name) == -1)
				{
					num = 53;
					lbSelected.Items.Add(e.Node.Name);
				}
				goto IL_0457;
				IL_0376:
				num = 44;
				string text = new FileInfo(e.Node.Name).Extension.ToLower() + ".";
				num = 45;
				if (text.Length > 2)
				{
					num = 46;
					if (Declarer.allPicExts.Contains(text))
					{
						goto IL_03fc;
					}
				}
				num = 49;
				e.Node.Checked = false;
				num = 50;
				Interaction.MsgBox(SelfService.GetWord("invalid_pic") + "\r\n" + e.Node.Name, MsgBoxStyle.Information);
				end_IL_0000:;
			}
			catch (Exception obj) when ((obj is Exception && num2 != 0) & (num6 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_05b7: Could not find block for branch target IL_0587*/;
			}
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void tv_AfterSelect(object sender, TreeViewEventArgs e)
	{
		if (!Microsoft.VisualBasic.FileIO.FileSystem.FileExists(e.Node.Name))
		{
			if (!Microsoft.VisualBasic.FileIO.FileSystem.DirectoryExists(e.Node.Name))
			{
				Interaction.MsgBox("no_removed\r\n" + e.Node.Name, MsgBoxStyle.Information);
				tv.SelectedNode.Remove();
			}
			else if (e.Node.Nodes.Count <= 0)
			{
				Folder folder = ((IFileSystem3)new FileSystemObjectClass()).GetFolder(e.Node.Name);
				try
				{
					_ = folder.SubFolders.Count;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
					return;
				}
				try
				{
					_ = folder.Files.Count;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
					return;
				}
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = folder.SubFolders.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Folder folder2 = (Folder)enumerator.Current;
						TreeNode treeNode = new TreeNode(folder2.Name, 3, 3);
						treeNode.Name = folder2.Path;
						e.Node.Nodes.Add(treeNode);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = folder.Files.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						IWshRuntimeLibrary.File file = (IWshRuntimeLibrary.File)enumerator2.Current;
						TreeNode treeNode = new TreeNode(file.Name, 4, 4);
						treeNode.Name = file.Path;
						e.Node.Nodes.Add(treeNode);
					}
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				e.Node.Expand();
			}
		}
	}

	private void tv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
	{
		//Discarded unreachable code: IL_0048, IL_006a, IL_006c, IL_007c, IL_009e
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			int num = 1;
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", Microsoft.VisualBasic.CompareMethod.Binary))
			{
				ProjectData.ClearProjectError();
				num2 = 1;
			}
			num = 3;
			if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(e.Node.Name))
			{
				num = 4;
				TFile.ExecFileFolder(tv.SelectedNode.Name);
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_009c: Could not find block for branch target IL_006c*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Buttons_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0180, IL_01f2, IL_01f4, IL_0204, IL_0226
		checked
		{
			int num2 = default(int);
			int num4 = default(int);
			try
			{
				int num = 1;
				if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", Microsoft.VisualBasic.CompareMethod.Binary))
				{
					ProjectData.ClearProjectError();
					num2 = 1;
				}
				num = 3;
				string name = ((Control)sender).Name;
				if (Operators.CompareString(name, "lRemove", TextCompare: false) != 0)
				{
					if (Operators.CompareString(name, "lCls", TextCompare: false) != 0)
					{
						if (Operators.CompareString(name, "lOK", TextCompare: false) != 0)
						{
							if (Operators.CompareString(name, "lCancel", TextCompare: false) == 0)
							{
								num = 23;
								Close();
							}
						}
						else
						{
							num = 21;
							bOK_Click(bOK, new EventArgs());
						}
					}
					else
					{
						num = 16;
						if (lbSelected.Items.Count <= 0)
						{
							goto IL_0147;
						}
						num = 17;
						if (Interaction.MsgBox(SelfService.GetWord("ask_remove_all"), MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question) == MsgBoxResult.Yes)
						{
							goto IL_0147;
						}
					}
				}
				else
				{
					num = 5;
					if (lbSelected.SelectedItems.Count <= 0)
					{
						goto IL_009e;
					}
					num = 6;
					if (Interaction.MsgBox(SelfService.GetWord("ask_remove"), MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question) == MsgBoxResult.Yes)
					{
						goto IL_009e;
					}
				}
				goto end_IL_0000;
				IL_0147:
				num = 19;
				lbSelected.Items.Clear();
				goto end_IL_0000;
				IL_009e:
				num = 8;
				int num3 = lbSelected.Items.Count - 1;
				num = 9;
				for (int i = num3; i >= 0; i += -1)
				{
					num = 10;
					if (lbSelected.GetSelected(i))
					{
						num = 11;
						lbSelected.Items.RemoveAt(i);
					}
					num = 12;
				}
				num = 13;
				if (lbSelected.Items.Count > 0)
				{
					num = 14;
					lbSelected.SelectedIndex = 0;
				}
				end_IL_0000:;
			}
			catch (Exception obj) when ((obj is Exception && num2 != 0) & (num4 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_0224: Could not find block for branch target IL_01f4*/;
			}
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void lbSelected_KeyUp(object sender, KeyEventArgs e)
	{
		//Discarded unreachable code: IL_003c, IL_005e, IL_0060, IL_0070, IL_0092
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			int num = 1;
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", Microsoft.VisualBasic.CompareMethod.Binary))
			{
				ProjectData.ClearProjectError();
				num2 = 1;
			}
			num = 3;
			if (e.KeyCode == Keys.Delete)
			{
				num = 4;
				Buttons_Click(lRemove, new EventArgs());
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0090: Could not find block for branch target IL_0060*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void bOK_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0140, IL_0196, IL_0198, IL_01a8, IL_01ca
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			int num = 1;
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", Microsoft.VisualBasic.CompareMethod.Binary))
			{
				ProjectData.ClearProjectError();
				num2 = 1;
			}
			num = 3;
			if (lbSelected.Items.Count < 1)
			{
				num = 4;
				Interaction.MsgBox(SelfService.GetWord("sel_ff"), MsgBoxStyle.Information);
			}
			else
			{
				num = 7;
				if (lbSelected.Items.Count == 1 && Microsoft.VisualBasic.FileIO.FileSystem.FileExists(lbSelected.Items[0].ToString()))
				{
					num = 8;
					Interaction.MsgBox(SelfService.GetWord("sel_ff"), MsgBoxStyle.Information);
				}
				else
				{
					num = 11;
					My.MyProject.Forms.Main.lbFF.Items.Clear();
					num = 12;
					IEnumerator enumerator = lbSelected.Items.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						num = 13;
						My.MyProject.Forms.Main.lbFF.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
						num = 14;
					}
					num = 15;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					num = 16;
					My.MyProject.Forms.Main.rbFF.Checked = true;
					num = 17;
					Close();
				}
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_01c8: Could not find block for branch target IL_0198*/
			;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public FFSelector()
	{
		base.Load += Me_Load;
		InitializeComponent();
		if (Operators.CompareString(My.MySettingsProperty.Settings.lang, "ar", TextCompare: false) == 0)
		{
			RightToLeft = RightToLeft.Yes;
		}
		else
		{
			RightToLeft = RightToLeft.No;
		}
		LoadLangText();
		lbSelected.Height = checked(lRemove.Top - 9 - lbSelected.Top);
	}

	private void LoadLangText()
	{
		//Discarded unreachable code: IL_009e, IL_00d4, IL_00d6, IL_00e6, IL_0108
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			int num = 1;
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", Microsoft.VisualBasic.CompareMethod.Binary))
			{
				ProjectData.ClearProjectError();
				num2 = 1;
			}
			num = 3;
			Text = SelfService.GetWord(base.AccessibleDescription);
			num = 4;
			IEnumerator enumerator = base.Controls.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control control = (Control)enumerator.Current;
				num = 5;
				if (control.AccessibleDescription != null)
				{
					num = 6;
					if (control.AccessibleDescription.Length > 0)
					{
						num = 7;
						control.Text = SelfService.GetWord(control.AccessibleDescription);
					}
				}
				num = 8;
			}
			num = 9;
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0106: Could not find block for branch target IL_00d6*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
