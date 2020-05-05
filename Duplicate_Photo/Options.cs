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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.lCls = new System.Windows.Forms.Label();
            this.lDel = new System.Windows.Forms.Label();
            this.lAdd = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.cbSub = new System.Windows.Forms.CheckBox();
            this.cbHidden = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.lbExclude = new System.Windows.Forms.ListBox();
            this.lCancel = new System.Windows.Forms.Label();
            this.lReset = new System.Windows.Forms.Label();
            this.lSave = new System.Windows.Forms.Label();
            this.lTypes = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.pPath = new System.Windows.Forms.Panel();
            this.rbShort = new System.Windows.Forms.RadioButton();
            this.rbLong = new System.Windows.Forms.RadioButton();
            this.pName = new System.Windows.Forms.Panel();
            this.rbLongN = new System.Windows.Forms.RadioButton();
            this.rbShortN = new System.Windows.Forms.RadioButton();
            this.lSmart4 = new System.Windows.Forms.Label();
            this.pCreated = new System.Windows.Forms.Panel();
            this.rbLate = new System.Windows.Forms.RadioButton();
            this.rbEarly = new System.Windows.Forms.RadioButton();
            this.lSmart3 = new System.Windows.Forms.Label();
            this.lSmart2 = new System.Windows.Forms.Label();
            this.lSmart1 = new System.Windows.Forms.Label();
            this.cbSmart = new System.Windows.Forms.CheckBox();
            this.p.SuspendLayout();
            this.pPath.SuspendLayout();
            this.pName.SuspendLayout();
            this.pCreated.SuspendLayout();
            this.SuspendLayout();
            // 
            // tt
            // 
            this.tt.IsBalloon = true;
            // 
            // lCls
            // 
            this.lCls.AccessibleName = "clear1";
            this.lCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lCls.ForeColor = System.Drawing.Color.White;
            this.lCls.Image = ((System.Drawing.Image)(resources.GetObject("lCls.Image")));
            this.lCls.Location = new System.Drawing.Point(53, 334);
            this.lCls.Name = "lCls";
            this.lCls.Size = new System.Drawing.Size(20, 20);
            this.lCls.TabIndex = 23;
            this.lCls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lCls, "Clear");
            // 
            // lDel
            // 
            this.lDel.AccessibleName = "del";
            this.lDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lDel.ForeColor = System.Drawing.Color.White;
            this.lDel.Image = ((System.Drawing.Image)(resources.GetObject("lDel.Image")));
            this.lDel.Location = new System.Drawing.Point(31, 334);
            this.lDel.Name = "lDel";
            this.lDel.Size = new System.Drawing.Size(20, 20);
            this.lDel.TabIndex = 22;
            this.lDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lDel, "Delete");
            // 
            // lAdd
            // 
            this.lAdd.AccessibleName = "add2";
            this.lAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lAdd.ForeColor = System.Drawing.Color.White;
            this.lAdd.Image = ((System.Drawing.Image)(resources.GetObject("lAdd.Image")));
            this.lAdd.Location = new System.Drawing.Point(9, 334);
            this.lAdd.Name = "lAdd";
            this.lAdd.Size = new System.Drawing.Size(20, 20);
            this.lAdd.TabIndex = 21;
            this.lAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lAdd, "Add...");
            // 
            // Button1
            // 
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button1.Location = new System.Drawing.Point(359, 1000);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 173;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // cbSub
            // 
            this.cbSub.AccessibleDescription = "scan_sub";
            this.cbSub.AutoSize = true;
            this.cbSub.Checked = true;
            this.cbSub.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSub.Location = new System.Drawing.Point(9, 155);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(234, 19);
            this.cbSub.TabIndex = 17;
            this.cbSub.Text = "S&can all sub folders for a specified path.";
            this.cbSub.UseVisualStyleBackColor = true;
            // 
            // cbHidden
            // 
            this.cbHidden.AccessibleDescription = "no_hidden";
            this.cbHidden.AutoSize = true;
            this.cbHidden.Checked = true;
            this.cbHidden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHidden.Location = new System.Drawing.Point(9, 184);
            this.cbHidden.Name = "cbHidden";
            this.cbHidden.Size = new System.Drawing.Size(228, 19);
            this.cbHidden.TabIndex = 18;
            this.cbHidden.Text = "Anyway, do NOT scan the &hidden files.";
            this.cbHidden.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AccessibleDescription = "no_below";
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 212);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(324, 15);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Anyway, do NOT scan the following system / special folders:";
            // 
            // l2
            // 
            this.l2.AccessibleDescription = "warning";
            this.l2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(82)))), ((int)(((byte)(37)))));
            this.l2.Location = new System.Drawing.Point(9, 236);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(345, 35);
            this.l2.TabIndex = 20;
            this.l2.Text = "WARNING: we highly recommend that you do NOT modify this listing to protect your " +
    "system security.";
            // 
            // lbExclude
            // 
            this.lbExclude.BackColor = System.Drawing.Color.White;
            this.lbExclude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbExclude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lbExclude.FormattingEnabled = true;
            this.lbExclude.HorizontalScrollbar = true;
            this.lbExclude.ItemHeight = 15;
            this.lbExclude.Location = new System.Drawing.Point(9, 363);
            this.lbExclude.Name = "lbExclude";
            this.lbExclude.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbExclude.Size = new System.Drawing.Size(513, 120);
            this.lbExclude.TabIndex = 24;
            // 
            // lCancel
            // 
            this.lCancel.AccessibleDescription = "";
            this.lCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lCancel.ForeColor = System.Drawing.Color.White;
            this.lCancel.Image = ((System.Drawing.Image)(resources.GetObject("lCancel.Image")));
            this.lCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lCancel.Location = new System.Drawing.Point(446, 492);
            this.lCancel.Name = "lCancel";
            this.lCancel.Size = new System.Drawing.Size(76, 27);
            this.lCancel.TabIndex = 27;
            this.lCancel.Text = "Cancel";
            this.lCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lCancel.Click += new System.EventHandler(this.lCancel_Click);
            // 
            // lReset
            // 
            this.lReset.AccessibleDescription = "";
            this.lReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lReset.ForeColor = System.Drawing.Color.White;
            this.lReset.Image = ((System.Drawing.Image)(resources.GetObject("lReset.Image")));
            this.lReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lReset.Location = new System.Drawing.Point(301, 492);
            this.lReset.Name = "lReset";
            this.lReset.Size = new System.Drawing.Size(143, 27);
            this.lReset.TabIndex = 26;
            this.lReset.Text = "Reset without Save";
            this.lReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lReset.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // lSave
            // 
            this.lSave.AccessibleDescription = "save_close1";
            this.lSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lSave.ForeColor = System.Drawing.Color.White;
            this.lSave.Image = ((System.Drawing.Image)(resources.GetObject("lSave.Image")));
            this.lSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lSave.Location = new System.Drawing.Point(186, 492);
            this.lSave.Name = "lSave";
            this.lSave.Size = new System.Drawing.Size(113, 27);
            this.lSave.TabIndex = 25;
            this.lSave.Text = "Save && Close";
            this.lSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lSave.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // lTypes
            // 
            this.lTypes.AccessibleDescription = "manage_types";
            this.lTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lTypes.ForeColor = System.Drawing.Color.White;
            this.lTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lTypes.Location = new System.Drawing.Point(9, 9);
            this.lTypes.Name = "lTypes";
            this.lTypes.Size = new System.Drawing.Size(513, 27);
            this.lTypes.TabIndex = 0;
            this.lTypes.Text = "Click Here To Manage Picture Types";
            this.lTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.White;
            this.p.Controls.Add(this.Label5);
            this.p.Controls.Add(this.pPath);
            this.p.Controls.Add(this.pName);
            this.p.Controls.Add(this.lSmart4);
            this.p.Controls.Add(this.pCreated);
            this.p.Controls.Add(this.lSmart3);
            this.p.Controls.Add(this.lSmart2);
            this.p.Controls.Add(this.lSmart1);
            this.p.Controls.Add(this.cbSmart);
            this.p.Controls.Add(this.cbSub);
            this.p.Controls.Add(this.cbHidden);
            this.p.Controls.Add(this.Label1);
            this.p.Controls.Add(this.l2);
            this.p.Location = new System.Drawing.Point(9, 45);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(513, 280);
            this.p.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Gray;
            this.Label5.Location = new System.Drawing.Point(-105, 145);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(800, 1);
            this.Label5.TabIndex = 16;
            // 
            // pPath
            // 
            this.pPath.Controls.Add(this.rbShort);
            this.pPath.Controls.Add(this.rbLong);
            this.pPath.Location = new System.Drawing.Point(170, 89);
            this.pPath.Name = "pPath";
            this.pPath.Size = new System.Drawing.Size(391, 19);
            this.pPath.TabIndex = 9;
            // 
            // rbShort
            // 
            this.rbShort.AccessibleDescription = "shortest";
            this.rbShort.AutoSize = true;
            this.rbShort.Checked = true;
            this.rbShort.Location = new System.Drawing.Point(0, 0);
            this.rbShort.Name = "rbShort";
            this.rbShort.Size = new System.Drawing.Size(68, 19);
            this.rbShort.TabIndex = 10;
            this.rbShort.TabStop = true;
            this.rbShort.Text = "Sh&ortest";
            this.rbShort.UseVisualStyleBackColor = true;
            // 
            // rbLong
            // 
            this.rbLong.AccessibleDescription = "longest";
            this.rbLong.AutoSize = true;
            this.rbLong.Location = new System.Drawing.Point(77, 0);
            this.rbLong.Name = "rbLong";
            this.rbLong.Size = new System.Drawing.Size(67, 19);
            this.rbLong.TabIndex = 11;
            this.rbLong.Text = "&Longest";
            this.rbLong.UseVisualStyleBackColor = true;
            // 
            // pName
            // 
            this.pName.Controls.Add(this.rbLongN);
            this.pName.Controls.Add(this.rbShortN);
            this.pName.Location = new System.Drawing.Point(213, 117);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(390, 19);
            this.pName.TabIndex = 13;
            // 
            // rbLongN
            // 
            this.rbLongN.AccessibleDescription = "longest1";
            this.rbLongN.AutoSize = true;
            this.rbLongN.Location = new System.Drawing.Point(77, 0);
            this.rbLongN.Name = "rbLongN";
            this.rbLongN.Size = new System.Drawing.Size(67, 19);
            this.rbLongN.TabIndex = 15;
            this.rbLongN.Text = "Lo&ngest";
            this.rbLongN.UseVisualStyleBackColor = true;
            // 
            // rbShortN
            // 
            this.rbShortN.AccessibleDescription = "shortest1";
            this.rbShortN.AutoSize = true;
            this.rbShortN.Checked = true;
            this.rbShortN.Location = new System.Drawing.Point(0, 0);
            this.rbShortN.Name = "rbShortN";
            this.rbShortN.Size = new System.Drawing.Size(68, 19);
            this.rbShortN.TabIndex = 14;
            this.rbShortN.TabStop = true;
            this.rbShortN.Text = "Sho&rtest";
            this.rbShortN.UseVisualStyleBackColor = true;
            // 
            // lSmart4
            // 
            this.lSmart4.AccessibleDescription = "still_same";
            this.lSmart4.AutoSize = true;
            this.lSmart4.Location = new System.Drawing.Point(9, 119);
            this.lSmart4.Name = "lSmart4";
            this.lSmart4.Size = new System.Drawing.Size(195, 15);
            this.lSmart4.TabIndex = 12;
            this.lSmart4.Text = "If still same, then compare filename";
            // 
            // pCreated
            // 
            this.pCreated.Controls.Add(this.rbLate);
            this.pCreated.Controls.Add(this.rbEarly);
            this.pCreated.Location = new System.Drawing.Point(91, 61);
            this.pCreated.Name = "pCreated";
            this.pCreated.Size = new System.Drawing.Size(483, 19);
            this.pCreated.TabIndex = 5;
            // 
            // rbLate
            // 
            this.rbLate.AccessibleDescription = "latest";
            this.rbLate.AutoSize = true;
            this.rbLate.Checked = true;
            this.rbLate.Location = new System.Drawing.Point(71, 0);
            this.rbLate.Name = "rbLate";
            this.rbLate.Size = new System.Drawing.Size(56, 19);
            this.rbLate.TabIndex = 7;
            this.rbLate.TabStop = true;
            this.rbLate.Text = "La&test";
            this.rbLate.UseVisualStyleBackColor = true;
            // 
            // rbEarly
            // 
            this.rbEarly.AccessibleDescription = "earliest";
            this.rbEarly.AutoSize = true;
            this.rbEarly.Location = new System.Drawing.Point(0, 0);
            this.rbEarly.Name = "rbEarly";
            this.rbEarly.Size = new System.Drawing.Size(62, 19);
            this.rbEarly.TabIndex = 6;
            this.rbEarly.Text = "&Earliest";
            this.rbEarly.UseVisualStyleBackColor = true;
            // 
            // lSmart3
            // 
            this.lSmart3.AccessibleDescription = "crea_date";
            this.lSmart3.AutoSize = true;
            this.lSmart3.Location = new System.Drawing.Point(9, 63);
            this.lSmart3.Name = "lSmart3";
            this.lSmart3.Size = new System.Drawing.Size(73, 15);
            this.lSmart3.TabIndex = 4;
            this.lSmart3.Text = "Date created";
            // 
            // lSmart2
            // 
            this.lSmart2.AccessibleDescription = "same_path";
            this.lSmart2.AccessibleName = "";
            this.lSmart2.AutoSize = true;
            this.lSmart2.Location = new System.Drawing.Point(9, 91);
            this.lSmart2.Name = "lSmart2";
            this.lSmart2.Size = new System.Drawing.Size(152, 15);
            this.lSmart2.TabIndex = 8;
            this.lSmart2.Text = "If same, then compare path";
            // 
            // lSmart1
            // 
            this.lSmart1.AccessibleDescription = "keep_file";
            this.lSmart1.AutoSize = true;
            this.lSmart1.Location = new System.Drawing.Point(9, 37);
            this.lSmart1.Name = "lSmart1";
            this.lSmart1.Size = new System.Drawing.Size(360, 15);
            this.lSmart1.TabIndex = 3;
            this.lSmart1.Text = "Only keep the following file, and check others in a duplicate group.";
            // 
            // cbSmart
            // 
            this.cbSmart.AccessibleDescription = "";
            this.cbSmart.AutoSize = true;
            this.cbSmart.Checked = true;
            this.cbSmart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSmart.Location = new System.Drawing.Point(9, 9);
            this.cbSmart.Name = "cbSmart";
            this.cbSmart.Size = new System.Drawing.Size(236, 19);
            this.cbSmart.TabIndex = 2;
            this.cbSmart.Text = "Use s&mart selection for the result listing.";
            this.cbSmart.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.CancelButton = this.Button1;
            this.ClientSize = new System.Drawing.Size(531, 528);
            this.Controls.Add(this.p);
            this.Controls.Add(this.lTypes);
            this.Controls.Add(this.lAdd);
            this.Controls.Add(this.lCls);
            this.Controls.Add(this.lDel);
            this.Controls.Add(this.lbExclude);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.lCancel);
            this.Controls.Add(this.lReset);
            this.Controls.Add(this.lSave);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.p.ResumeLayout(false);
            this.p.PerformLayout();
            this.pPath.ResumeLayout(false);
            this.pPath.PerformLayout();
            this.pName.ResumeLayout(false);
            this.pName.PerformLayout();
            this.pCreated.ResumeLayout(false);
            this.pCreated.PerformLayout();
            this.ResumeLayout(false);

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
