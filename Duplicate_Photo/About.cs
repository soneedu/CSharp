using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using My;
using My.Resources;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public class About : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("pbProdLogo")]
	private PictureBox _pbProdLogo;

	[CompilerGenerated]
	[AccessedThroughProperty("pbCompLogo")]
	private PictureBox _pbCompLogo;

	[CompilerGenerated]
	[AccessedThroughProperty("p")]
	private Panel _p;

	[CompilerGenerated]
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[CompilerGenerated]
	[AccessedThroughProperty("lLicenseType")]
	private Label _lLicenseType;

	[CompilerGenerated]
	[AccessedThroughProperty("lVer")]
	private Label _lVer;

	[CompilerGenerated]
	[AccessedThroughProperty("lMember")]
	private Label _lMember;

	[CompilerGenerated]
	[AccessedThroughProperty("lCopyright")]
	private Label _lCopyright;

	[CompilerGenerated]
	[AccessedThroughProperty("lCUName")]
	private Label _lCUName;

	[CompilerGenerated]
	[AccessedThroughProperty("lLicensed")]
	private Label _lLicensed;

	[CompilerGenerated]
	[AccessedThroughProperty("tt")]
	private ToolTip _tt;

	[CompilerGenerated]
	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[CompilerGenerated]
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	internal virtual PictureBox pbProdLogo
	{
		[CompilerGenerated]
		get
		{
			return _pbProdLogo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Pictures_Click;
			PictureBox pbProdLogo = _pbProdLogo;
			if (pbProdLogo != null)
			{
				pbProdLogo.Click -= value2;
			}
			_pbProdLogo = value;
			pbProdLogo = _pbProdLogo;
			if (pbProdLogo != null)
			{
				pbProdLogo.Click += value2;
			}
		}
	}

	internal virtual PictureBox pbCompLogo
	{
		[CompilerGenerated]
		get
		{
			return _pbCompLogo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Pictures_Click;
			PictureBox pbCompLogo = _pbCompLogo;
			if (pbCompLogo != null)
			{
				pbCompLogo.Click -= value2;
			}
			_pbCompLogo = value;
			pbCompLogo = _pbCompLogo;
			if (pbCompLogo != null)
			{
				pbCompLogo.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("p")]
	internal virtual Panel p
	{
		get;
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get;
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lLicenseType")]
	internal virtual Label lLicenseType
	{
		get;
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lVer")]
	internal virtual Label lVer
	{
		get;
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lMember")]
	internal virtual Label lMember
	{
		get;
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lCopyright")]
	internal virtual Label lCopyright
	{
		get;
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lCUName")]
	internal virtual Label lCUName
	{
		get;
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lLicensed")]
	internal virtual Label lLicensed
	{
		get;
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tt")]
	internal virtual ToolTip tt
	{
		get;
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get;
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Button1")]
	internal virtual Button Button1
	{
		get;
		[MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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
		p = new System.Windows.Forms.Panel();
		Button1 = new System.Windows.Forms.Button();
		Label2 = new System.Windows.Forms.Label();
		lCUName = new System.Windows.Forms.Label();
		lLicensed = new System.Windows.Forms.Label();
		lCopyright = new System.Windows.Forms.Label();
		lVer = new System.Windows.Forms.Label();
		lMember = new System.Windows.Forms.Label();
		lLicenseType = new System.Windows.Forms.Label();
		Label1 = new System.Windows.Forms.Label();
		pbCompLogo = new System.Windows.Forms.PictureBox();
		pbProdLogo = new System.Windows.Forms.PictureBox();
		tt = new System.Windows.Forms.ToolTip(components);
		p.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pbCompLogo).BeginInit();
		((System.ComponentModel.ISupportInitialize)pbProdLogo).BeginInit();
		SuspendLayout();
		p.BackColor = System.Drawing.Color.White;
		p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		p.Controls.Add(Button1);
		p.Controls.Add(Label2);
		p.Controls.Add(lCUName);
		p.Controls.Add(lLicensed);
		p.Controls.Add(lCopyright);
		p.Controls.Add(lVer);
		p.Controls.Add(lMember);
		p.Controls.Add(lLicenseType);
		p.Controls.Add(Label1);
		p.Controls.Add(pbCompLogo);
		p.Controls.Add(pbProdLogo);
		p.Location = new System.Drawing.Point(9, 9);
		p.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		p.Name = "p";
		p.Size = new System.Drawing.Size(587, 203);
		p.TabIndex = 2;
		Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		Button1.Location = new System.Drawing.Point(170, 938);
		Button1.Name = "Button1";
		Button1.Size = new System.Drawing.Size(75, 22);
		Button1.TabIndex = 10;
		Button1.Text = "Button1";
		Button1.UseVisualStyleBackColor = true;
		Label2.BackColor = System.Drawing.Color.Gray;
		Label2.Location = new System.Drawing.Point(-1, 145);
		Label2.Name = "Label2";
		Label2.Size = new System.Drawing.Size(700, 1);
		Label2.TabIndex = 9;
		lCUName.AutoSize = true;
		lCUName.ForeColor = System.Drawing.Color.Blue;
		lCUName.Location = new System.Drawing.Point(9, 179);
		lCUName.Name = "lCUName";
		lCUName.Size = new System.Drawing.Size(76, 15);
		lCUName.TabIndex = 7;
		lCUName.Text = "Licensed to...";
		lLicensed.AutoSize = true;
		lLicensed.Location = new System.Drawing.Point(9, 155);
		lLicensed.Name = "lLicensed";
		lLicensed.Size = new System.Drawing.Size(145, 15);
		lLicensed.TabIndex = 4;
		lLicensed.Text = "This product is licensed to";
		lCopyright.AutoSize = true;
		lCopyright.Location = new System.Drawing.Point(137, 121);
		lCopyright.Name = "lCopyright";
		lCopyright.Size = new System.Drawing.Size(69, 15);
		lCopyright.TabIndex = 5;
		lCopyright.Text = "Copyright...";
		lVer.AutoSize = true;
		lVer.Location = new System.Drawing.Point(137, 97);
		lVer.Name = "lVer";
		lVer.Size = new System.Drawing.Size(55, 15);
		lVer.TabIndex = 4;
		lVer.Text = "Version...";
		lMember.AutoSize = true;
		lMember.Location = new System.Drawing.Point(137, 73);
		lMember.Name = "lMember";
		lMember.Size = new System.Drawing.Size(295, 15);
		lMember.TabIndex = 4;
		lMember.Text = "Member of TriSun Software Windows Explorer solution";
		lLicenseType.AutoSize = true;
		lLicenseType.Font = new System.Drawing.Font("Segoe UI", 17f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
		lLicenseType.ForeColor = System.Drawing.Color.FromArgb(0, 174, 29);
		lLicenseType.Location = new System.Drawing.Point(137, 41);
		lLicenseType.Name = "lLicenseType";
		lLicenseType.Size = new System.Drawing.Size(118, 23);
		lLicenseType.TabIndex = 3;
		lLicenseType.Text = "License Type...";
		Label1.AutoSize = true;
		Label1.Font = new System.Drawing.Font("Segoe UI", 17f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
		Label1.Location = new System.Drawing.Point(137, 9);
		Label1.Name = "Label1";
		Label1.Size = new System.Drawing.Size(221, 23);
		Label1.TabIndex = 3;
		Label1.Text = "Duplicate Photo Finder Plus";
		pbCompLogo.Cursor = System.Windows.Forms.Cursors.Hand;
		pbCompLogo.Image = My.Resources.Resources.tsslogo;
		pbCompLogo.Location = new System.Drawing.Point(435, 2);
		pbCompLogo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		pbCompLogo.Name = "pbCompLogo";
		pbCompLogo.Size = new System.Drawing.Size(142, 60);
		pbCompLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		pbCompLogo.TabIndex = 1;
		pbCompLogo.TabStop = false;
		tt.SetToolTip(pbCompLogo, "Company Homepage");
		pbProdLogo.Cursor = System.Windows.Forms.Cursors.Hand;
		pbProdLogo.Image = My.Resources.Resources.logo128;
		pbProdLogo.Location = new System.Drawing.Point(0, 0);
		pbProdLogo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		pbProdLogo.Name = "pbProdLogo";
		pbProdLogo.Size = new System.Drawing.Size(128, 128);
		pbProdLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		pbProdLogo.TabIndex = 0;
		pbProdLogo.TabStop = false;
		tt.SetToolTip(pbProdLogo, "Product Homepage");
		tt.IsBalloon = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.Color.FromArgb(103, 103, 103);
		base.CancelButton = Button1;
		base.ClientSize = new System.Drawing.Size(605, 222);
		base.Controls.Add(p);
		Font = new System.Drawing.Font("Segoe UI", 11.9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
		ForeColor = System.Drawing.Color.FromArgb(72, 72, 72);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "About";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "About Duplicate Photo Finder Plus";
		p.ResumeLayout(false);
		p.PerformLayout();
		((System.ComponentModel.ISupportInitialize)pbCompLogo).EndInit();
		((System.ComponentModel.ISupportInitialize)pbProdLogo).EndInit();
		ResumeLayout(false);
	}

	private void LoadLicense()
	{
		//Discarded unreachable code: IL_0107, IL_014d, IL_014f, IL_015f, IL_0181
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
			if (Declarer.licenseType.Length > 0)
			{
				num = 4;
				lLicensed.Text = SelfService.GetWord("licensed_to");
				num = 5;
				lCUName.Text = My.MySettingsProperty.Settings.user;
				num = 6;
				lCUName.ForeColor = Color.FromArgb(0, 174, 29);
				num = 7;
				lLicenseType.ForeColor = Color.FromArgb(0, 174, 29);
			}
			else
			{
				num = 9;
				lLicensed.Text = SelfService.GetWord("trial_version");
				num = 10;
				lCUName.Text = SelfService.GetWord("dpfp_limit");
				num = 11;
				lCUName.ForeColor = Color.FromArgb(243, 82, 37);
				num = 12;
				lLicenseType.ForeColor = Color.FromArgb(243, 82, 37);
			}
			num = 13;
			Form inter = this;
			SelfService.DisplayLicense(ref inter);
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_017f: Could not find block for branch target IL_014f*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Pictures_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0059, IL_0083, IL_0085, IL_0095, IL_00b7
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
			if (Operators.CompareString(((Control)sender).Name, "pbCompLogo", TextCompare: false) == 0)
			{
				num = 4;
				Interaction.Shell("explorer \"http://www.TriSunSoft.com/\"", AppWinStyle.NormalFocus);
			}
			else
			{
				num = 6;
				Interaction.Shell("explorer \"http://DuplicateFileFinder4PC.com/duplicate-photo-finder-plus.htm?source=dpfp_inter\"", AppWinStyle.NormalFocus);
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_00b5: Could not find block for branch target IL_0085*/;
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
			LoadLicense();
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

	public About()
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
	}

	private void LoadLangText()
	{
		//Discarded unreachable code: IL_010c, IL_0142, IL_0144, IL_0154, IL_0176
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
			Text = SelfService.GetWord("about") + "Duplicate Photo Finder Plus";
			num = 4;
			lMember.Text = SelfService.GetWord("twes");
			num = 5;
			lVer.Text = SelfService.GetWord("version") + "8.0 (" + SelfService.GetWord("build") + "022)";
			num = 6;
			lCopyright.Text = SelfService.GetWord("copyright") + "2013-2018 TriSun Software Limited. " + SelfService.GetWord("rights");
			num = 7;
			tt.SetToolTip(pbCompLogo, SelfService.GetWord("comp_home"));
			num = 8;
			tt.SetToolTip(pbProdLogo, SelfService.GetWord("prod_home"));
			num = 9;
			pbCompLogo.Left = checked(p.Width - pbCompLogo.Width - 3);
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0174: Could not find block for branch target IL_0144*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
