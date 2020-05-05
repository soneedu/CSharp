using IWshRuntimeLibrary;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
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

[DesignerGenerated]
public class DrivesSelector : Form
{
	private IContainer components;


	private TreeView tv;

	private Label lCancel;

	private Label lOK;

	private Button bCancel;

	private Button bOK;

	private ImageList ilTV;



	[DebuggerNonUserCode]
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
		components = new System.ComponentModel.Container();
		tv = new System.Windows.Forms.TreeView();
		ilTV = new System.Windows.Forms.ImageList(components);
		lCancel = new System.Windows.Forms.Label();
		lOK = new System.Windows.Forms.Label();
		bCancel = new System.Windows.Forms.Button();
		bOK = new System.Windows.Forms.Button();
		SuspendLayout();
		tv.AccessibleDescription = "";
		tv.BackColor = System.Drawing.Color.White;
		tv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		tv.CheckBoxes = true;
		tv.ForeColor = System.Drawing.Color.FromArgb(72, 72, 72);
		tv.HideSelection = false;
		tv.ImageIndex = 0;
		tv.ImageList = ilTV;
		tv.Location = new System.Drawing.Point(9, 9);
		tv.Name = "tv";
		tv.SelectedImageIndex = 0;
		tv.ShowLines = false;
		tv.ShowRootLines = false;
		tv.Size = new System.Drawing.Size(312, 291);
		tv.TabIndex = 8;
		ilTV.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		ilTV.ImageSize = new System.Drawing.Size(16, 16);
		ilTV.TransparentColor = System.Drawing.Color.Transparent;
		lCancel.AccessibleDescription = "cancel";
		lCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lCancel.ForeColor = System.Drawing.Color.White;
		lCancel.Location = new System.Drawing.Point(247, 309);
		lCancel.Name = "lCancel";
		lCancel.Size = new System.Drawing.Size(74, 27);
		lCancel.TabIndex = 159;
		lCancel.Text = "Cancel";
		lCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		lCancel.Click += new System.EventHandler(this.lCancel_Click);
		lOK.AccessibleDescription = "ok";
		lOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lOK.ForeColor = System.Drawing.Color.White;
		lOK.Location = new System.Drawing.Point(171, 309);
		lOK.Name = "lOK";
		lOK.Size = new System.Drawing.Size(74, 27);
		lOK.TabIndex = 158;
		lOK.Text = "OK";
		lOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		lOK.Click += new System.EventHandler(this.lOK_Click);
		bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		bCancel.Location = new System.Drawing.Point(69, 938);
		bCancel.Name = "bCancel";
		bCancel.Size = new System.Drawing.Size(75, 22);
		bCancel.TabIndex = 160;
		bCancel.Text = "Button1";
		bCancel.UseVisualStyleBackColor = true;
		bOK.Location = new System.Drawing.Point(2, 938);
		bOK.Name = "bOK";
		bOK.Size = new System.Drawing.Size(75, 22);
		bOK.TabIndex = 161;
		bOK.Text = "Button1";
		bOK.UseVisualStyleBackColor = true;
		base.AcceptButton = bOK;
		base.AccessibleDescription = "drives_selector";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.Color.FromArgb(103, 103, 103);
		base.CancelButton = bCancel;
		base.ClientSize = new System.Drawing.Size(330, 346);
		base.Controls.Add(bOK);
		base.Controls.Add(bCancel);
		base.Controls.Add(lCancel);
		base.Controls.Add(lOK);
		base.Controls.Add(tv);
		Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
		ForeColor = System.Drawing.Color.FromArgb(72, 72, 72);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DrivesSelector";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Drive(s) Selector";
		ResumeLayout(false);
	}

	public DrivesSelector()
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
			/*Error near IL_007f: Could not find block for branch target IL_004f*/;
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
			/*Error near IL_007f: Could not find block for branch target IL_004f*/;
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

	private void lOK_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0030, IL_004e, IL_0050, IL_0060, IL_0082
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
			bOK_Click(bOK, new EventArgs());
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0080: Could not find block for branch target IL_0050*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void bOK_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0121, IL_017b, IL_017d, IL_018d, IL_01af
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
			string text = string.Empty;
			num = 4;
			Declarer.selectedDrives.Clear();
			num = 5;
			IEnumerator enumerator = tv.Nodes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				TreeNode treeNode = (TreeNode)enumerator.Current;
				num = 6;
				if (treeNode.Checked)
				{
					num = 7;
					text = text + treeNode.Text + ", ";
					num = 8;
					Declarer.selectedDrives.Add(treeNode.Name);
				}
				num = 9;
			}
			num = 10;
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
			num = 11;
			if (text.Length > 0)
			{
				num = 12;
				text = text.Substring(0, checked(text.Length - 2));
				num = 16;
				My.MyProject.Forms.Main.tbDrives.Text = text;
				num = 17;
				My.MyProject.Forms.Main.rbSpecify.Checked = true;
				num = 18;
				Close();
			}
			else
			{
				num = 14;
				Interaction.MsgBox(SelfService.GetWord("sel_drive"), MsgBoxStyle.Information);
			}
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

	private void Me_Load(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0208, IL_0282, IL_0284, IL_0294, IL_02b6
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
			tv.Nodes.Clear();
			num = 8;
			DriveInfo[] drives = DriveInfo.GetDrives();
			num = 9;
			string empty = string.Empty;
			num = 10;
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				num = 11;
				if (driveInfo.IsReady)
				{
					num = 12;
					empty = driveInfo.VolumeLabel + " (" + driveInfo.Name.Replace(":\\", ":") + ")";
					num = 13;
					TreeNode treeNode;
					if (driveInfo.DriveType == DriveType.CDRom)
					{
						num = 14;
						treeNode = new TreeNode(empty, 1, 1);
					}
					else
					{
						num = 16;
						if (driveInfo.DriveType == DriveType.Network)
						{
							num = 17;
							empty = ((IFileSystem3)new FileSystemObjectClass()).GetDrive(driveInfo.Name).ShareName + " (" + driveInfo.Name.Replace(":\\", ":") + ")";
							num = 18;
							treeNode = new TreeNode(empty, 2, 2);
						}
						else
						{
							num = 20;
							treeNode = new TreeNode(empty, 0, 0);
						}
					}
					num = 21;
					treeNode.Name = driveInfo.Name.ToLower();
					num = 22;
					tv.Nodes.Add(treeNode);
				}
				num = 23;
			}
			num = 24;
			Text = SelfService.GetWord(base.AccessibleDescription);
			num = 25;
			lOK.Text = SelfService.GetWord(lOK.AccessibleDescription);
			num = 26;
			lCancel.Text = SelfService.GetWord(lCancel.AccessibleDescription);
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_02b4: Could not find block for branch target IL_0284*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
