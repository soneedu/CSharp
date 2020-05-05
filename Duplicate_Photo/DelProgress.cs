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
using TSSFL.UIControl;
using TSSFL.Utility;

[DesignerGenerated]
public class DelProgress : Form
{
	private IContainer components;

	public Label lCancel;
	public Label lOK;
	public Button bCancel;
	public Button bOK;
	public ImageList ilTV;
	public TListView tlv;
	public ColumnHeader chName;
	public ProgressBar pb;
	public Label lProgress;
	public Label lTip;
	public Label lReport;
	public ContextMenuStrip cms;
	public ToolStripMenuItem tsmiRemove;
	public ToolStripMenuItem tsmiRun;

	private bool _doing;


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
		ilTV = new System.Windows.Forms.ImageList(components);
		lCancel = new System.Windows.Forms.Label();
		lOK = new System.Windows.Forms.Label();
		bCancel = new System.Windows.Forms.Button();
		bOK = new System.Windows.Forms.Button();
		tlv = new TSSFL.UIControl.TListView();
		chName = new System.Windows.Forms.ColumnHeader();
		pb = new System.Windows.Forms.ProgressBar();
		lProgress = new System.Windows.Forms.Label();
		lTip = new System.Windows.Forms.Label();
		lReport = new System.Windows.Forms.Label();
		cms = new System.Windows.Forms.ContextMenuStrip(components);
		tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
		tsmiRun = new System.Windows.Forms.ToolStripMenuItem();
		cms.SuspendLayout();
		SuspendLayout();
		ilTV.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		ilTV.ImageSize = new System.Drawing.Size(20, 16);
		ilTV.TransparentColor = System.Drawing.Color.Transparent;
		lCancel.AccessibleDescription = "cancel";
		lCancel.BackColor = System.Drawing.Color.FromArgb(103, 103, 103);
		lCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lCancel.ForeColor = System.Drawing.Color.White;
		lCancel.Location = new System.Drawing.Point(593, 595);
		lCancel.Name = "lCancel";
		lCancel.Size = new System.Drawing.Size(74, 27);
		lCancel.TabIndex = 159;
		lCancel.Text = "Cancel";
		lCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		lOK.AccessibleDescription = "ok";
		lOK.BackColor = System.Drawing.Color.FromArgb(103, 103, 103);
		lOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lOK.ForeColor = System.Drawing.Color.White;
		lOK.Location = new System.Drawing.Point(517, 595);
		lOK.Name = "lOK";
		lOK.Size = new System.Drawing.Size(74, 27);
		lOK.TabIndex = 158;
		lOK.Text = "OK";
		lOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		bCancel.Location = new System.Drawing.Point(69, 1000);
		bCancel.Name = "bCancel";
		bCancel.Size = new System.Drawing.Size(75, 23);
		bCancel.TabIndex = 160;
		bCancel.Text = "Button1";
		bCancel.UseVisualStyleBackColor = true;
		bOK.Location = new System.Drawing.Point(2, 1000);
		bOK.Name = "bOK";
		bOK.Size = new System.Drawing.Size(75, 23);
		bOK.TabIndex = 161;
		bOK.Text = "Button1";
		bOK.UseVisualStyleBackColor = true;
		tlv.BackColor = System.Drawing.Color.White;
		tlv.BorderStyle = System.Windows.Forms.BorderStyle.None;
		tlv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
		{
			chName
		});
		tlv.ContextMenuStrip = cms;
		tlv.ForeColor = System.Drawing.Color.FromArgb(72, 72, 72);
		tlv.FullRowSelect = true;
		tlv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
		tlv.HideSelection = false;
		tlv.Location = new System.Drawing.Point(9, 37);
		tlv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		tlv.Name = "tlv";
		tlv.ShowItemToolTips = true;
		tlv.Size = new System.Drawing.Size(658, 521);
		tlv.Sorting = System.Windows.Forms.SortOrder.Ascending;
		tlv.TabIndex = 0;
		tlv.UseCompatibleStateImageBehavior = false;
		tlv.View = System.Windows.Forms.View.Details;
		chName.Tag = "name";
		chName.Text = "Name";
		chName.Width = 635;
		pb.Location = new System.Drawing.Point(9, 558);
		pb.Name = "pb";
		pb.Size = new System.Drawing.Size(658, 28);
		pb.Step = 1;
		pb.TabIndex = 163;
		lProgress.AccessibleDescription = "";
		lProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lProgress.ForeColor = System.Drawing.Color.White;
		lProgress.Location = new System.Drawing.Point(9, 588);
		lProgress.Name = "lProgress";
		lProgress.Size = new System.Drawing.Size(658, 15);
		lProgress.TabIndex = 164;
		lProgress.Text = "0 / 354";
		lProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		lTip.AccessibleDescription = "";
		lTip.BackColor = System.Drawing.Color.FromArgb(217, 217, 217);
		lTip.Font = new System.Drawing.Font("Segoe UI", 15.9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
		lTip.ForeColor = System.Drawing.Color.FromArgb(72, 72, 72);
		lTip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		lTip.Location = new System.Drawing.Point(9, 9);
		lTip.Name = "lTip";
		lTip.Size = new System.Drawing.Size(658, 28);
		lTip.TabIndex = 166;
		lTip.Text = "Please review your checks, and then click <OK>.";
		lTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		lReport.AccessibleDescription = "";
		lReport.BackColor = System.Drawing.Color.FromArgb(217, 217, 217);
		lReport.Font = new System.Drawing.Font("Segoe UI", 15.9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
		lReport.ForeColor = System.Drawing.Color.FromArgb(72, 72, 72);
		lReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		lReport.Location = new System.Drawing.Point(9, 305);
		lReport.Name = "lReport";
		lReport.Size = new System.Drawing.Size(658, 253);
		lReport.TabIndex = 167;
		lReport.Text = "Report:";
		lReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		lReport.Visible = false;
		cms.Font = new System.Drawing.Font("Segoe UI", 11.9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
		cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[2]
		{
			tsmiRemove,
			tsmiRun
		});
		cms.Name = "cms";
		cms.Size = new System.Drawing.Size(220, 80);
		tsmiRemove.AccessibleDescription = "";
		tsmiRemove.ForeColor = System.Drawing.Color.Black;
		tsmiRemove.Image = My.Resources.Resources.del32;
		tsmiRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		tsmiRemove.Name = "tsmiRemove";
		tsmiRemove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
		tsmiRemove.Size = new System.Drawing.Size(219, 38);
		tsmiRemove.Text = "Remove";
		tsmiRun.AccessibleDescription = "open";
		tsmiRun.Image = My.Resources.Resources.run32;
		tsmiRun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
		tsmiRun.Name = "tsmiRun";
		tsmiRun.ShortcutKeyDisplayString = "Double-click";
		tsmiRun.Size = new System.Drawing.Size(219, 38);
		tsmiRun.Text = "Run/Open";
		base.AcceptButton = bOK;
		base.AccessibleDescription = "";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.Color.FromArgb(103, 103, 103);
		base.CancelButton = bCancel;
		base.ClientSize = new System.Drawing.Size(677, 631);
		base.Controls.Add(lReport);
		base.Controls.Add(lTip);
		base.Controls.Add(lCancel);
		base.Controls.Add(lOK);
		base.Controls.Add(lProgress);
		base.Controls.Add(pb);
		base.Controls.Add(tlv);
		base.Controls.Add(bOK);
		base.Controls.Add(bCancel);
		Font = new System.Drawing.Font("Segoe UI", 11.9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
		ForeColor = System.Drawing.Color.FromArgb(72, 72, 72);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "DelProgress";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Delete files";
		cms.ResumeLayout(false);
		ResumeLayout(false);
	}

	public DelProgress()
	{
		base.FormClosing += DelProgress_FormClosing;
		base.Load += Me_Load;
		_doing = false;
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
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", CompareMethod.Binary))
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
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", CompareMethod.Binary))
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
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", CompareMethod.Binary))
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
			if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", CompareMethod.Binary))
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
		if (Operators.CompareString(lProgress.Text, SelfService.GetWord("done"), TextCompare: false) == 0)
		{
			Close();
			return;
		}
		if (_doing)
		{
			return;
		}
		string prompt = string.Empty;
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		if (Operators.CompareString(base.Tag.ToString(), "RB", TextCompare: false) == 0)
		{
			prompt = SelfService.GetWord("ask_bin_pic");
		}
		else if (Operators.CompareString(base.Tag.ToString(), "PD", TextCompare: false) == 0)
		{
			prompt = SelfService.GetWord("ask_del_pic");
		}
		else if (Operators.CompareString(base.Tag.ToString(), "MOVE", TextCompare: false) == 0)
		{
			folderBrowserDialog.Description = SelfService.GetWord("move_dup1");
			folderBrowserDialog.ShowDialog();
			if (folderBrowserDialog.SelectedPath.Length < 1)
			{
				return;
			}
			goto IL_00d2;
		}
		if (Interaction.MsgBox(prompt, MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question) != MsgBoxResult.Yes)
		{
			return;
		}
		goto IL_00d2;
		IL_00d2:
		_doing = true;
		bool flag = false;
		long num = 0L;
		checked
		{
			for (int i = tlv.Items.Count - 1; i >= 0; i += -1)
			{
				ListViewItem listViewItem = tlv.Items[i];
				if (Operators.CompareString(base.Tag.ToString(), "MOVE", TextCompare: false) == 0)
				{
					if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(listViewItem.Text))
					{
						try
						{
							Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(listViewItem.Text, folderBrowserDialog.SelectedPath + "\\" + Path.GetFileName(listViewItem.Text), UIOption.OnlyErrorDialogs);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
				}
				else if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(listViewItem.Text))
				{
					try
					{
						num += new FileInfo(listViewItem.Text).Length;
						if (Operators.CompareString(base.Tag.ToString(), "RB", TextCompare: false) == 0)
						{
							Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(listViewItem.Text, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
						}
						else
						{
							Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(listViewItem.Text, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				if (!Microsoft.VisualBasic.FileIO.FileSystem.FileExists(listViewItem.Text))
				{
					Declarer.finalResult[listViewItem.Tag.ToString()].Remove(listViewItem.Text);
					pb.Value++;
					lProgress.Text = pb.Value.ToString() + " / " + pb.Maximum.ToString();
					tlv.Items.RemoveAt(i);
					flag = true;
				}
				Application.DoEvents();
			}
			lProgress.Text = SelfService.GetWord("done");
			lReport.Visible = true;
			if (Operators.CompareString(base.Tag.ToString(), "MOVE", TextCompare: false) == 0)
			{
				lReport.Text = ">>>> " + SelfService.GetWord("report") + " <<<<\r\n\r\n" + SelfService.GetWord("moved") + Strings.Format(pb.Value, "#,0").ToString() + " " + SelfService.GetWord("files") + "\r\n\r\n" + SelfService.GetWord("possible_reasons1") + "\r\n" + SelfService.GetWord("del_reasons1");
			}
			else
			{
				lReport.Text = ">>>> " + SelfService.GetWord("report") + " <<<<\r\n\r\n" + SelfService.GetWord("del_rb") + Strings.Format(pb.Value, "#,0").ToString() + " " + SelfService.GetWord("files") + "\r\n" + SelfService.GetWord("released") + SelfService.IntelligentSize(num) + "\r\n\r\n" + SelfService.GetWord("possible_reasons") + "\r\n" + SelfService.GetWord("del_reasons");
			}
			if (flag)
			{
				My.MyProject.Forms.Result.FilterResult();
			}
			_doing = false;
		}
	}

	private void DelProgress_FormClosing(object sender, FormClosingEventArgs e)
	{
		//Discarded unreachable code: IL_0030, IL_0052, IL_0054, IL_0064, IL_0086
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
			if (_doing)
			{
				num = 4;
				e.Cancel = true;
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0084: Could not find block for branch target IL_0054*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Me_Load(object sender, EventArgs e)
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
			lTip.Text = SelfService.GetWord("review_checks");
			num = 4;
			lOK.Text = SelfService.GetWord("ok");
			num = 5;
			lCancel.Text = SelfService.GetWord("cancel");
			num = 6;
			tsmiRemove.Text = SelfService.GetWord("remove1");
			num = 7;
			tsmiRun.Text = SelfService.GetWord("open");
			num = 8;
			tsmiRun.ShortcutKeyDisplayString = SelfService.GetWord("dclick");
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

	private void tlv_DoubleClick(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0078, IL_00a6, IL_00a8, IL_00b8, IL_00da
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
			if (!_doing)
			{
				num = 5;
				if (tlv.SelectedItems.Count > 0)
				{
					num = 6;
					if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(tlv.SelectedItems[0].Text))
					{
						num = 7;
						TFile.ExecFileFolder(tlv.SelectedItems[0].Text);
					}
				}
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_00d8: Could not find block for branch target IL_00a8*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
		//Discarded unreachable code: IL_0134, IL_018a, IL_018c, IL_019c, IL_01be
		checked
		{
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
				if (!_doing)
				{
					num = 5;
					string name = e.ClickedItem.Name;
					if (Operators.CompareString(name, "tsmiRun", TextCompare: false) != 0)
					{
						if (Operators.CompareString(name, "tsmiRemove", TextCompare: false) == 0)
						{
							num = 9;
							tlv.BeginUpdate();
							num = 10;
							IEnumerator enumerator = tlv.SelectedItems.GetEnumerator();
							while (enumerator.MoveNext())
							{
								ListViewItem item = (ListViewItem)enumerator.Current;
								num = 11;
								tlv.Items.Remove(item);
								num = 12;
								pb.Maximum--;
								num = 13;
								lProgress.Text = "0 / " + pb.Maximum.ToString();
								num = 14;
							}
							num = 15;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
							num = 16;
							tlv.EndUpdate();
						}
					}
					else
					{
						num = 7;
						tlv_DoubleClick(tlv, new EventArgs());
					}
				}
			}
			catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_01bc: Could not find block for branch target IL_018c*/;
			}
			if (num3 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}
}
