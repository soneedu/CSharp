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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public class Options : Form
{
	private IContainer components;

	private ToolTip tt;
	private Label lSave;
	private Label lReset;
	private Label lCancel;
	private Button Button1;
	private CheckBox cbSub;
	private CheckBox cbHidden;
	private Label Label1;
	private Label l2;
	private ListBox lbExclude;
	private Label lDel;
	private Label lAdd;
	private Label lCls;
	private Label lTypes;
	private Panel p;
	private Panel pPath;
	private RadioButton rbShort;
	private RadioButton rbLong;
	private Panel pName;
	private RadioButton rbLongN;
	private RadioButton rbShortN;
	private Label lSmart4;
	private Panel pCreated;
	private RadioButton rbLate;
	private RadioButton rbEarly;
	private Label lSmart3;
	private Label lSmart2;
	private Label lSmart1;
	private CheckBox cbSmart;
	private Label Label5;


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
		tt = new System.Windows.Forms.ToolTip(components);
		lCls = new System.Windows.Forms.Label();
		lDel = new System.Windows.Forms.Label();
		lAdd = new System.Windows.Forms.Label();
		Button1 = new System.Windows.Forms.Button();
		cbSub = new System.Windows.Forms.CheckBox();
		cbHidden = new System.Windows.Forms.CheckBox();
		Label1 = new System.Windows.Forms.Label();
		l2 = new System.Windows.Forms.Label();
		lbExclude = new System.Windows.Forms.ListBox();
		lCancel = new System.Windows.Forms.Label();
		lReset = new System.Windows.Forms.Label();
		lSave = new System.Windows.Forms.Label();
		lTypes = new System.Windows.Forms.Label();
		p = new System.Windows.Forms.Panel();
		Label5 = new System.Windows.Forms.Label();
		pPath = new System.Windows.Forms.Panel();
		rbShort = new System.Windows.Forms.RadioButton();
		rbLong = new System.Windows.Forms.RadioButton();
		pName = new System.Windows.Forms.Panel();
		rbLongN = new System.Windows.Forms.RadioButton();
		rbShortN = new System.Windows.Forms.RadioButton();
		lSmart4 = new System.Windows.Forms.Label();
		pCreated = new System.Windows.Forms.Panel();
		rbLate = new System.Windows.Forms.RadioButton();
		rbEarly = new System.Windows.Forms.RadioButton();
		lSmart3 = new System.Windows.Forms.Label();
		lSmart2 = new System.Windows.Forms.Label();
		lSmart1 = new System.Windows.Forms.Label();
		cbSmart = new System.Windows.Forms.CheckBox();
		p.SuspendLayout();
		pPath.SuspendLayout();
		pName.SuspendLayout();
		pCreated.SuspendLayout();
		SuspendLayout();
		tt.IsBalloon = true;
		lCls.AccessibleName = "clear1";
		lCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lCls.ForeColor = System.Drawing.Color.White;
		lCls.Image = My.Resources.Resources.cls32;
		lCls.Location = new System.Drawing.Point(53, 334);
		lCls.Name = "lCls";
		lCls.Size = new System.Drawing.Size(20, 20);
		lCls.TabIndex = 23;
		lCls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		tt.SetToolTip(lCls, "Clear");
		lDel.AccessibleName = "del";
		lDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lDel.ForeColor = System.Drawing.Color.White;
		lDel.Image = My.Resources.Resources.del32_white;
		lDel.Location = new System.Drawing.Point(31, 334);
		lDel.Name = "lDel";
		lDel.Size = new System.Drawing.Size(20, 20);
		lDel.TabIndex = 22;
		lDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		tt.SetToolTip(lDel, "Delete");
		lAdd.AccessibleName = "add2";
		lAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lAdd.ForeColor = System.Drawing.Color.White;
		lAdd.Image = My.Resources.Resources.add32;
		lAdd.Location = new System.Drawing.Point(9, 334);
		lAdd.Name = "lAdd";
		lAdd.Size = new System.Drawing.Size(20, 20);
		lAdd.TabIndex = 21;
		lAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		tt.SetToolTip(lAdd, "Add...");
		Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		Button1.Location = new System.Drawing.Point(359, 1000);
		Button1.Name = "Button1";
		Button1.Size = new System.Drawing.Size(75, 23);
		Button1.TabIndex = 173;
		Button1.Text = "Button1";
		Button1.UseVisualStyleBackColor = true;
		cbSub.AccessibleDescription = "scan_sub";
		cbSub.AutoSize = true;
		cbSub.Checked = true;
		cbSub.CheckState = System.Windows.Forms.CheckState.Checked;
		cbSub.Location = new System.Drawing.Point(9, 155);
		cbSub.Name = "cbSub";
		cbSub.Size = new System.Drawing.Size(234, 19);
		cbSub.TabIndex = 17;
		cbSub.Text = "S&can all sub folders for a specified path.";
		cbSub.UseVisualStyleBackColor = true;
		cbHidden.AccessibleDescription = "no_hidden";
		cbHidden.AutoSize = true;
		cbHidden.Checked = true;
		cbHidden.CheckState = System.Windows.Forms.CheckState.Checked;
		cbHidden.Location = new System.Drawing.Point(9, 184);
		cbHidden.Name = "cbHidden";
		cbHidden.Size = new System.Drawing.Size(230, 19);
		cbHidden.TabIndex = 18;
		cbHidden.Text = "Anyway, do NOT scan the &hidden files.";
		cbHidden.UseVisualStyleBackColor = true;
		Label1.AccessibleDescription = "no_below";
		Label1.AutoSize = true;
		Label1.Location = new System.Drawing.Point(9, 212);
		Label1.Name = "Label1";
		Label1.Size = new System.Drawing.Size(326, 15);
		Label1.TabIndex = 19;
		Label1.Text = "Anyway, do NOT scan the following system / special folders:";
		l2.AccessibleDescription = "warning";
		l2.ForeColor = System.Drawing.Color.FromArgb(243, 82, 37);
		l2.Location = new System.Drawing.Point(9, 236);
		l2.Name = "l2";
		l2.Size = new System.Drawing.Size(345, 35);
		l2.TabIndex = 20;
		l2.Text = "WARNING: we highly recommend that you do NOT modify this listing to protect your system security.";
		lbExclude.BackColor = System.Drawing.Color.White;
		lbExclude.BorderStyle = System.Windows.Forms.BorderStyle.None;
		lbExclude.ForeColor = System.Drawing.Color.FromArgb(72, 72, 72);
		lbExclude.FormattingEnabled = true;
		lbExclude.HorizontalScrollbar = true;
		lbExclude.ItemHeight = 15;
		lbExclude.Location = new System.Drawing.Point(9, 363);
		lbExclude.Name = "lbExclude";
		lbExclude.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
		lbExclude.Size = new System.Drawing.Size(513, 120);
		lbExclude.TabIndex = 24;
		lCancel.AccessibleDescription = "cancel";
		lCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lCancel.ForeColor = System.Drawing.Color.White;
		lCancel.Image = My.Resources.Resources.del32_white;
		lCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		lCancel.Location = new System.Drawing.Point(446, 492);
		lCancel.Name = "lCancel";
		lCancel.Size = new System.Drawing.Size(76, 27);
		lCancel.TabIndex = 27;
		lCancel.Text = "Cancel";
		lCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		lReset.AccessibleDescription = "reset_no_save";
		lReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lReset.ForeColor = System.Drawing.Color.White;
		lReset.Image = My.Resources.Resources.reset32;
		lReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		lReset.Location = new System.Drawing.Point(301, 492);
		lReset.Name = "lReset";
		lReset.Size = new System.Drawing.Size(143, 27);
		lReset.TabIndex = 26;
		lReset.Text = "Reset without Save";
		lReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		lSave.AccessibleDescription = "save_close1";
		lSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lSave.ForeColor = System.Drawing.Color.White;
		lSave.Image = My.Resources.Resources.save32;
		lSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		lSave.Location = new System.Drawing.Point(186, 492);
		lSave.Name = "lSave";
		lSave.Size = new System.Drawing.Size(113, 27);
		lSave.TabIndex = 25;
		lSave.Text = "Save && Close";
		lSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		lTypes.AccessibleDescription = "manage_types";
		lTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lTypes.ForeColor = System.Drawing.Color.White;
		lTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		lTypes.Location = new System.Drawing.Point(9, 9);
		lTypes.Name = "lTypes";
		lTypes.Size = new System.Drawing.Size(513, 27);
		lTypes.TabIndex = 0;
		lTypes.Text = "Click Here To Manage Picture Types";
		lTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		p.BackColor = System.Drawing.Color.White;
		p.Controls.Add(Label5);
		p.Controls.Add(pPath);
		p.Controls.Add(pName);
		p.Controls.Add(lSmart4);
		p.Controls.Add(pCreated);
		p.Controls.Add(lSmart3);
		p.Controls.Add(lSmart2);
		p.Controls.Add(lSmart1);
		p.Controls.Add(cbSmart);
		p.Controls.Add(cbSub);
		p.Controls.Add(cbHidden);
		p.Controls.Add(Label1);
		p.Controls.Add(l2);
		p.Location = new System.Drawing.Point(9, 45);
		p.Name = "p";
		p.Size = new System.Drawing.Size(513, 280);
		p.TabIndex = 1;
		Label5.BackColor = System.Drawing.Color.Gray;
		Label5.Location = new System.Drawing.Point(-105, 145);
		Label5.Name = "Label5";
		Label5.Size = new System.Drawing.Size(800, 1);
		Label5.TabIndex = 16;
		pPath.Controls.Add(rbShort);
		pPath.Controls.Add(rbLong);
		pPath.Location = new System.Drawing.Point(170, 89);
		pPath.Name = "pPath";
		pPath.Size = new System.Drawing.Size(391, 19);
		pPath.TabIndex = 9;
		rbShort.AccessibleDescription = "shortest";
		rbShort.AutoSize = true;
		rbShort.Checked = true;
		rbShort.Location = new System.Drawing.Point(0, 0);
		rbShort.Name = "rbShort";
		rbShort.Size = new System.Drawing.Size(68, 19);
		rbShort.TabIndex = 10;
		rbShort.TabStop = true;
		rbShort.Text = "Sh&ortest";
		rbShort.UseVisualStyleBackColor = true;
		rbLong.AccessibleDescription = "longest";
		rbLong.AutoSize = true;
		rbLong.Location = new System.Drawing.Point(77, 0);
		rbLong.Name = "rbLong";
		rbLong.Size = new System.Drawing.Size(67, 19);
		rbLong.TabIndex = 11;
		rbLong.Text = "&Longest";
		rbLong.UseVisualStyleBackColor = true;
		pName.Controls.Add(rbLongN);
		pName.Controls.Add(rbShortN);
		pName.Location = new System.Drawing.Point(213, 117);
		pName.Name = "pName";
		pName.Size = new System.Drawing.Size(390, 19);
		pName.TabIndex = 13;
		rbLongN.AccessibleDescription = "longest1";
		rbLongN.AutoSize = true;
		rbLongN.Location = new System.Drawing.Point(77, 0);
		rbLongN.Name = "rbLongN";
		rbLongN.Size = new System.Drawing.Size(67, 19);
		rbLongN.TabIndex = 15;
		rbLongN.Text = "Lo&ngest";
		rbLongN.UseVisualStyleBackColor = true;
		rbShortN.AccessibleDescription = "shortest1";
		rbShortN.AutoSize = true;
		rbShortN.Checked = true;
		rbShortN.Location = new System.Drawing.Point(0, 0);
		rbShortN.Name = "rbShortN";
		rbShortN.Size = new System.Drawing.Size(68, 19);
		rbShortN.TabIndex = 14;
		rbShortN.TabStop = true;
		rbShortN.Text = "Sho&rtest";
		rbShortN.UseVisualStyleBackColor = true;
		lSmart4.AccessibleDescription = "still_same";
		lSmart4.AutoSize = true;
		lSmart4.Location = new System.Drawing.Point(9, 119);
		lSmart4.Name = "lSmart4";
		lSmart4.Size = new System.Drawing.Size(195, 15);
		lSmart4.TabIndex = 12;
		lSmart4.Text = "If still same, then compare filename";
		pCreated.Controls.Add(rbLate);
		pCreated.Controls.Add(rbEarly);
		pCreated.Location = new System.Drawing.Point(91, 61);
		pCreated.Name = "pCreated";
		pCreated.Size = new System.Drawing.Size(483, 19);
		pCreated.TabIndex = 5;
		rbLate.AccessibleDescription = "latest";
		rbLate.AutoSize = true;
		rbLate.Checked = true;
		rbLate.Location = new System.Drawing.Point(71, 0);
		rbLate.Name = "rbLate";
		rbLate.Size = new System.Drawing.Size(56, 19);
		rbLate.TabIndex = 7;
		rbLate.TabStop = true;
		rbLate.Text = "La&test";
		rbLate.UseVisualStyleBackColor = true;
		rbEarly.AccessibleDescription = "earliest";
		rbEarly.AutoSize = true;
		rbEarly.Location = new System.Drawing.Point(0, 0);
		rbEarly.Name = "rbEarly";
		rbEarly.Size = new System.Drawing.Size(62, 19);
		rbEarly.TabIndex = 6;
		rbEarly.Text = "&Earliest";
		rbEarly.UseVisualStyleBackColor = true;
		lSmart3.AccessibleDescription = "crea_date";
		lSmart3.AutoSize = true;
		lSmart3.Location = new System.Drawing.Point(9, 63);
		lSmart3.Name = "lSmart3";
		lSmart3.Size = new System.Drawing.Size(73, 15);
		lSmart3.TabIndex = 4;
		lSmart3.Text = "Date created";
		lSmart2.AccessibleDescription = "same_path";
		lSmart2.AccessibleName = "";
		lSmart2.AutoSize = true;
		lSmart2.Location = new System.Drawing.Point(9, 91);
		lSmart2.Name = "lSmart2";
		lSmart2.Size = new System.Drawing.Size(152, 15);
		lSmart2.TabIndex = 8;
		lSmart2.Text = "If same, then compare path";
		lSmart1.AccessibleDescription = "keep_file";
		lSmart1.AutoSize = true;
		lSmart1.Location = new System.Drawing.Point(9, 37);
		lSmart1.Name = "lSmart1";
		lSmart1.Size = new System.Drawing.Size(360, 15);
		lSmart1.TabIndex = 3;
		lSmart1.Text = "Only keep the following file, and check others in a duplicate group.";
		cbSmart.AccessibleDescription = "smart_selection";
		cbSmart.AutoSize = true;
		cbSmart.Checked = true;
		cbSmart.CheckState = System.Windows.Forms.CheckState.Checked;
		cbSmart.Location = new System.Drawing.Point(9, 9);
		cbSmart.Name = "cbSmart";
		cbSmart.Size = new System.Drawing.Size(236, 19);
		cbSmart.TabIndex = 2;
		cbSmart.Text = "Use s&mart selection for the result listing.";
		cbSmart.UseVisualStyleBackColor = true;
		base.AccessibleDescription = "options";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.Color.FromArgb(103, 103, 103);
		base.CancelButton = Button1;
		base.ClientSize = new System.Drawing.Size(531, 528);
		base.Controls.Add(p);
		base.Controls.Add(lTypes);
		base.Controls.Add(lAdd);
		base.Controls.Add(lCls);
		base.Controls.Add(lDel);
		base.Controls.Add(lbExclude);
		base.Controls.Add(Button1);
		base.Controls.Add(lCancel);
		base.Controls.Add(lReset);
		base.Controls.Add(lSave);
		Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
		ForeColor = System.Drawing.Color.FromArgb(72, 72, 72);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Options";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Options";
		p.ResumeLayout(false);
		p.PerformLayout();
		pPath.ResumeLayout(false);
		pPath.PerformLayout();
		pName.ResumeLayout(false);
		pName.PerformLayout();
		pCreated.ResumeLayout(false);
		pCreated.PerformLayout();
		ResumeLayout(false);
	}

	private void LoadSettings()
	{
		//Discarded unreachable code: IL_01ac, IL_0222, IL_0224, IL_0234, IL_0256
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
			cbSub.Checked = My.MySettingsProperty.Settings.subfolders;
			num = 4;
			cbHidden.Checked = My.MySettingsProperty.Settings.hidden;
			num = 5;
			cbSmart.Checked = My.MySettingsProperty.Settings.smart;
			num = 6;
			if (Operators.CompareString(My.MySettingsProperty.Settings.path, "S", TextCompare: false) == 0)
			{
				num = 7;
				rbShort.Checked = true;
			}
			else
			{
				num = 9;
				rbLong.Checked = true;
			}
			num = 10;
			if (Operators.CompareString(My.MySettingsProperty.Settings.name, "S", TextCompare: false) == 0)
			{
				num = 11;
				rbShortN.Checked = true;
			}
			else
			{
				num = 13;
				rbLongN.Checked = true;
			}
			num = 14;
			if (Operators.CompareString(My.MySettingsProperty.Settings.created, "E", TextCompare: false) == 0)
			{
				num = 15;
				rbEarly.Checked = true;
			}
			else
			{
				num = 17;
				rbLate.Checked = true;
			}
			num = 18;
			lbExclude.Items.Clear();
			num = 19;
			string[] array = My.MySettingsProperty.Settings.exclude.Split('|');
			num = 20;
			string[] array2 = array;
			foreach (string text in array2)
			{
				num = 21;
				if (Microsoft.VisualBasic.FileIO.FileSystem.DirectoryExists(text))
				{
					num = 22;
					lbExclude.Items.Add(text);
				}
				num = 23;
			}
			num = 24;
			if (lbExclude.Items.Count > 0)
			{
				num = 25;
				lbExclude.SelectedIndex = 0;
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0254: Could not find block for branch target IL_0224*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void SaveSettings()
	{
		//Discarded unreachable code: IL_0199, IL_01f3, IL_01f5, IL_0205, IL_0227
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
			My.MySettingsProperty.Settings.subfolders = cbSub.Checked;
			num = 4;
			My.MySettingsProperty.Settings.hidden = cbHidden.Checked;
			num = 5;
			My.MySettingsProperty.Settings.smart = cbSmart.Checked;
			num = 6;
			My.MySettingsProperty.Settings.path = Interaction.IIf(rbShort.Checked, "S", "L").ToString();
			num = 7;
			My.MySettingsProperty.Settings.name = Interaction.IIf(rbShortN.Checked, "S", "L").ToString();
			num = 8;
			My.MySettingsProperty.Settings.created = Interaction.IIf(rbEarly.Checked, "E", "L").ToString();
			num = 9;
			string text = "|";
			num = 10;
			IEnumerator enumerator = lbExclude.Items.GetEnumerator();
			while (enumerator.MoveNext())
			{
				//Exception objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				num = 11;
				if (Microsoft.VisualBasic.FileIO.FileSystem.DirectoryExists(enumerator.Current.ToString()))
				{
					num = 12;
					text = text + enumerator.Current.ToString() + "|";
				}
				num = 13;
			}
			num = 14;
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
			num = 15;
			My.MySettingsProperty.Settings.exclude = text;
			num = 16;
			My.MySettingsProperty.Settings.Save();
			num = 17;
			Interaction.MsgBox(SelfService.GetWord("save_succ"), MsgBoxStyle.Information);
			num = 18;
			Close();
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0225: Could not find block for branch target IL_01f5*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Me_Load(object sender, EventArgs e)
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
			LoadSettings();
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

	private void lbExclude_KeyUp(object sender, KeyEventArgs e)
	{
		//Discarded unreachable code: IL_003c, IL_005e, IL_0060, IL_0070, IL_0092
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
			if (e.KeyCode == Keys.Delete)
			{
				num = 4;
				Buttons_Click(lDel, new EventArgs());
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

	private void Buttons_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_03bc, IL_04aa, IL_04ac, IL_04bc, IL_04de
		checked
		{
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
				string name = ((Control)sender).Name;
				if (Operators.CompareString(name, "lTypes", TextCompare: false) != 0)
				{
					if (Operators.CompareString(name, "lAdd", TextCompare: false) != 0)
					{
						if (Operators.CompareString(name, "lDel", TextCompare: false) != 0)
						{
							if (Operators.CompareString(name, "lCls", TextCompare: false) != 0)
							{
								if (Operators.CompareString(name, "lSave", TextCompare: false) != 0)
								{
									if (Operators.CompareString(name, "lReset", TextCompare: false) == 0)
									{
										num = 38;
										cbSub.Checked = true;
										num = 39;
										cbHidden.Checked = true;
										num = 40;
										cbSmart.Checked = true;
										num = 41;
										rbShort.Checked = true;
										num = 42;
										rbShortN.Checked = true;
										num = 43;
										rbLate.Checked = true;
										num = 44;
										lbExclude.Items.Clear();
										num = 45;
										lbExclude.Items.Add(Environment.GetEnvironmentVariable("WinDir"));
										num = 46;
										lbExclude.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
										num = 47;
										string empty = string.Empty;
										num = 48;
										empty = Environment.GetEnvironmentVariable("ProgramFiles(x86)");
										num = 49;
										if (empty != null)
										{
											num = 50;
											if (empty.Length > 0)
											{
												num = 51;
												lbExclude.Items.Add(empty);
											}
										}
										num = 52;
										lbExclude.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
										num = 53;
										lbExclude.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
										num = 54;
										lbExclude.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
									}
								}
								else
								{
									num = 36;
									SaveSettings();
								}
							}
							else
							{
								num = 31;
								if (lbExclude.Items.Count <= 0)
								{
									goto IL_0257;
								}
								num = 32;
								if (Interaction.MsgBox(SelfService.GetWord("remove_all"), MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question) == MsgBoxResult.Yes)
								{
									goto IL_0257;
								}
							}
						}
						else
						{
							num = 20;
							if (lbExclude.SelectedItems.Count <= 0)
							{
								goto IL_01a4;
							}
							num = 21;
							if (Interaction.MsgBox(SelfService.GetWord("remove_folder"), MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question) == MsgBoxResult.Yes)
							{
								goto IL_01a4;
							}
						}
					}
					else
					{
						num = 7;
						FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
						num = 8;
						folderBrowserDialog.Description = SelfService.GetWord("folder_exclude");
						num = 9;
						folderBrowserDialog.ShowDialog();
						num = 10;
						if (folderBrowserDialog.SelectedPath.Length >= 1)
						{
							num = 12;
							if (folderBrowserDialog.SelectedPath.Length < 4)
							{
								num = 13;
								Interaction.MsgBox(SelfService.GetWord("drive_exclude"), MsgBoxStyle.Information);
							}
							else
							{
								num = 15;
								if (lbExclude.FindStringExact(folderBrowserDialog.SelectedPath) == -1)
								{
									num = 16;
									lbExclude.Items.Add(folderBrowserDialog.SelectedPath);
								}
								else
								{
									num = 18;
									Interaction.MsgBox(SelfService.GetWord("folder_exist") + "\r\n" + folderBrowserDialog.SelectedPath, MsgBoxStyle.Information);
								}
							}
						}
					}
				}
				else
				{
					num = 5;
					My.MyProject.Forms.Types.ShowDialog(this);
				}
				goto end_IL_0000;
				IL_0257:
				num = 34;
				lbExclude.Items.Clear();
				goto end_IL_0000;
				IL_01a4:
				num = 23;
				int num3 = lbExclude.Items.Count - 1;
				num = 24;
				for (int i = num3; i >= 0; i += -1)
				{
					num = 25;
					if (lbExclude.GetSelected(i))
					{
						num = 26;
						lbExclude.Items.RemoveAt(i);
					}
					num = 27;
				}
				num = 28;
				if (lbExclude.Items.Count > 0)
				{
					num = 29;
					lbExclude.SelectedIndex = 0;
				}
				end_IL_0000:;
			}
			catch (Exception obj) when ((obj is Exception && num2 != 0) & (num4 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_04dc: Could not find block for branch target IL_04ac*/;
			}
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	public Options()
	{
		base.Load += Me_Load;
		InitializeComponent();
		checked
		{
			lbExclude.Height = lSave.Top - 9 - lbExclude.Top;
			l2.Width = p.Width - 18;
			if (Operators.CompareString(My.MySettingsProperty.Settings.lang, "ar", TextCompare: false) == 0)
			{
				RightToLeft = RightToLeft.Yes;
			}
			else
			{
				RightToLeft = RightToLeft.No;
			}
			LoadLangText();
		}
	}

	private void LoadLangText()
	{
		//Discarded unreachable code: IL_043c, IL_050a, IL_050c, IL_051c, IL_053e
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
					if (control.AccessibleName != null)
					{
						num = 9;
						if (control.AccessibleName.Length > 0)
						{
							num = 10;
							tt.SetToolTip(control, SelfService.GetWord(control.AccessibleName));
						}
					}
					num = 11;
					if (control is Panel)
					{
						num = 12;
						IEnumerator enumerator2 = control.Controls.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							Control control2 = (Control)enumerator2.Current;
							num = 13;
							if (control2.AccessibleDescription != null)
							{
								num = 14;
								if (control2.AccessibleDescription.Length > 0)
								{
									num = 15;
									control2.Text = SelfService.GetWord(control2.AccessibleDescription);
								}
							}
							num = 16;
							if (control2 is Panel)
							{
								num = 17;
								IEnumerator enumerator3 = control2.Controls.GetEnumerator();
								while (enumerator3.MoveNext())
								{
									Control control3 = (Control)enumerator3.Current;
									num = 18;
									if (control3.AccessibleDescription != null)
									{
										num = 19;
										if (control3.AccessibleDescription.Length > 0)
										{
											num = 20;
											control3.Text = SelfService.GetWord(control3.AccessibleDescription);
										}
									}
									num = 21;
								}
								num = 22;
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
							}
							num = 23;
						}
						num = 24;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					num = 25;
				}
				num = 26;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				num = 27;
				pCreated.Left = lSmart3.Left + lSmart3.Width + 9;
				num = 28;
				pPath.Left = lSmart2.Left + lSmart2.Width + 9;
				num = 29;
				pName.Left = lSmart4.Left + lSmart4.Width + 9;
				num = 30;
				rbLate.Left = rbEarly.Left + rbEarly.Width + 9;
				num = 31;
				rbLong.Left = rbShort.Left + rbShort.Width + 9;
				num = 32;
				rbLongN.Left = rbShortN.Left + rbShortN.Width + 9;
				num = 33;
				lSave.AutoSize = true;
				num = 34;
				int width = lSave.Width + 32;
				num = 35;
				lSave.AutoSize = false;
				num = 36;
				lSave.Size = new Size(width, 27);
				num = 37;
				lReset.AutoSize = true;
				num = 38;
				width = lReset.Width + 32;
				num = 39;
				lReset.AutoSize = false;
				num = 40;
				lReset.Size = new Size(width, 27);
				num = 41;
				lCancel.AutoSize = true;
				num = 42;
				width = lCancel.Width + 32;
				num = 43;
				lCancel.AutoSize = false;
				num = 44;
				lCancel.Size = new Size(width, 27);
				num = 45;
				lCancel.Left = lbExclude.Left + lbExclude.Width - lCancel.Width;
				num = 46;
				lReset.Left = lCancel.Left - 9 - lReset.Width;
				num = 47;
				lSave.Left = lReset.Left - 9 - lSave.Width;
			}
			catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_053c: Could not find block for branch target IL_050c*/;
			}
			if (num3 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void cbSmart_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_00f8, IL_0136, IL_0138, IL_0148, IL_016a
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
			lSmart1.Enabled = cbSmart.Checked;
			num = 4;
			lSmart2.Enabled = lSmart1.Enabled;
			num = 5;
			lSmart3.Enabled = lSmart1.Enabled;
			num = 6;
			lSmart4.Enabled = lSmart1.Enabled;
			num = 7;
			pCreated.Enabled = lSmart1.Enabled;
			num = 8;
			rbShort.Enabled = lSmart1.Enabled;
			num = 9;
			rbLong.Enabled = lSmart1.Enabled;
			num = 10;
			rbShortN.Enabled = lSmart1.Enabled;
			num = 11;
			rbLongN.Enabled = lSmart1.Enabled;
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0168: Could not find block for branch target IL_0138*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
