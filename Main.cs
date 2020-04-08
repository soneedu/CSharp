using IWshRuntimeLibrary;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using My;
using My.Resources;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TSSFL.Utility;

[DesignerGenerated]
public class Main : Form
{
	private IContainer components;
	public Label lPrompt;

	public ContextMenuStrip cmsMore;

	public ToolStripMenuItem tsmiLatest;

	public ToolTip tt;

	public Label lProgress;

	public Panel pBanner;

	public Label lEFN;

	public Label lFind;

	public Label lStop;

	public Panel pDrives;

	public RadioButton rbAll;

	public RadioButton rbExcept;

	public CheckBox cbCD;

	public Label lDrives;

	public RadioButton rbSpecify;

	public Label lReset;

	public CheckBox cbSystem;

	public CheckBox cbNetwork;

	public ToolStripMenuItem tsmiSupport;

	public Label lLogo;

	public Label lTypes;

	public Panel pTypes;

	public CheckBox cbIcon;

	public CheckBox cbTIF;

	public CheckBox cbBMP;

	public CheckBox cbGIF;

	public CheckBox cbJPG;

	public CheckBox cbPNG;

	public CheckBox cbAll;

	public CheckBox cbOthers;

	public Label lCurrent;

	public Label lHelp;

	public Label lRecomm;

	public Label lFB;

	public Label lTwitter;

	public Label lGP;

	public Label lAbout;

	public Label lMore;

	public Label lHome;

	public ToolStripMenuItem tsmiAllDup;

	public ToolStripMenuItem tsmiTSSI;

	public Label lLicense;

	public Label lVirtual;

	public Label lLicType;

	public ContextMenuStrip cmsLicense;

	public ToolStripMenuItem tsmiLBuy;

	public ToolStripMenuItem tsmiLInput;

	public ToolStripMenuItem tsmiLRetrieve;

	public TextBox tbDrives;

	public RadioButton rbFF;

	public ListBox lbFF;

	public Label lOpt;

	public Label lLoad;

	public ToolStripMenuItem tsmiRSupport;

	public LinkLabel llSelDrives;

	public LinkLabel llSelFF;

	public LinkLabel llTypesManager;

	public Label Label3;

	public Label Label5;

	public Label Label4;

	public Label Label1;

	public Label Label2;

	public Label Label6;

	public ContextMenuStrip cmsLangs;

	public Label lLang;

	public ToolStripMenuItem tsmiHVT;

	public ToolStripMenuItem tsmiNew;

	public ToolStripMenuItem tsmiHTrans;



	public Main()
	{
		base.FormClosing += Me_FormClosing;
		base.HelpRequested += Me_HelpRequested;
		base.KeyDown += Me_KeyDown;
		base.Load += Me_Load;
		InitializeComponent();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lPrompt = new System.Windows.Forms.Label();
            this.cmsMore = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiHVT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAllDup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTSSI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLatest = new System.Windows.Forms.ToolStripMenuItem();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.lEFN = new System.Windows.Forms.Label();
            this.lFind = new System.Windows.Forms.Label();
            this.lStop = new System.Windows.Forms.Label();
            this.lLang = new System.Windows.Forms.Label();
            this.lVirtual = new System.Windows.Forms.Label();
            this.lFB = new System.Windows.Forms.Label();
            this.lLogo = new System.Windows.Forms.Label();
            this.lLoad = new System.Windows.Forms.Label();
            this.lReset = new System.Windows.Forms.Label();
            this.lTwitter = new System.Windows.Forms.Label();
            this.lGP = new System.Windows.Forms.Label();
            this.lRecomm = new System.Windows.Forms.Label();
            this.lLicense = new System.Windows.Forms.Label();
            this.lMore = new System.Windows.Forms.Label();
            this.lHelp = new System.Windows.Forms.Label();
            this.lHome = new System.Windows.Forms.Label();
            this.lOpt = new System.Windows.Forms.Label();
            this.lAbout = new System.Windows.Forms.Label();
            this.lProgress = new System.Windows.Forms.Label();
            this.pBanner = new System.Windows.Forms.Panel();
            this.lLicType = new System.Windows.Forms.Label();
            this.pDrives = new System.Windows.Forms.Panel();
            this.llSelFF = new System.Windows.Forms.LinkLabel();
            this.llSelDrives = new System.Windows.Forms.LinkLabel();
            this.lbFF = new System.Windows.Forms.ListBox();
            this.rbFF = new System.Windows.Forms.RadioButton();
            this.tbDrives = new System.Windows.Forms.TextBox();
            this.cbNetwork = new System.Windows.Forms.CheckBox();
            this.cbSystem = new System.Windows.Forms.CheckBox();
            this.cbCD = new System.Windows.Forms.CheckBox();
            this.rbExcept = new System.Windows.Forms.RadioButton();
            this.rbSpecify = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.lDrives = new System.Windows.Forms.Label();
            this.lTypes = new System.Windows.Forms.Label();
            this.pTypes = new System.Windows.Forms.Panel();
            this.llTypesManager = new System.Windows.Forms.LinkLabel();
            this.cbOthers = new System.Windows.Forms.CheckBox();
            this.cbIcon = new System.Windows.Forms.CheckBox();
            this.cbTIF = new System.Windows.Forms.CheckBox();
            this.cbBMP = new System.Windows.Forms.CheckBox();
            this.cbGIF = new System.Windows.Forms.CheckBox();
            this.cbJPG = new System.Windows.Forms.CheckBox();
            this.cbPNG = new System.Windows.Forms.CheckBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.lCurrent = new System.Windows.Forms.Label();
            this.cmsLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLInput = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLRetrieve = new System.Windows.Forms.ToolStripMenuItem();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.cmsLangs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsMore.SuspendLayout();
            this.pBanner.SuspendLayout();
            this.pDrives.SuspendLayout();
            this.pTypes.SuspendLayout();
            this.cmsLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // lPrompt
            // 
            this.lPrompt.AccessibleDescription = "";
            this.lPrompt.BackColor = System.Drawing.Color.White;
            this.lPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lPrompt.Location = new System.Drawing.Point(429, 227);
            this.lPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPrompt.Name = "lPrompt";
            this.lPrompt.Size = new System.Drawing.Size(288, 117);
            this.lPrompt.TabIndex = 137;
            // 
            // cmsMore
            // 
            this.cmsMore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmsMore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHVT,
            this.tsmiNew,
            this.tsmiSupport,
            this.tsmiRSupport,
            this.tsmiAllDup,
            this.tsmiTSSI,
            this.tsmiHTrans,
            this.tsmiLatest});
            this.cmsMore.Name = "cms";
            this.cmsMore.Size = new System.Drawing.Size(277, 180);
            // 
            // tsmiHVT
            // 
            this.tsmiHVT.AccessibleDescription = "video_t2";
            this.tsmiHVT.Name = "tsmiHVT";
            this.tsmiHVT.Size = new System.Drawing.Size(276, 22);
            this.tsmiHVT.Text = "Video tutorial";
            // 
            // tsmiNew
            // 
            this.tsmiNew.AccessibleDescription = "update_his";
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(276, 22);
            this.tsmiNew.Text = "Update history";
            // 
            // tsmiSupport
            // 
            this.tsmiSupport.AccessibleDescription = "email_support";
            this.tsmiSupport.Name = "tsmiSupport";
            this.tsmiSupport.Size = new System.Drawing.Size(276, 22);
            this.tsmiSupport.Text = "Request Email Support (Free)";
            // 
            // tsmiRSupport
            // 
            this.tsmiRSupport.AccessibleDescription = "remote_support";
            this.tsmiRSupport.Name = "tsmiRSupport";
            this.tsmiRSupport.Size = new System.Drawing.Size(276, 22);
            this.tsmiRSupport.Text = "Request Remote Support (Fee-based)";
            // 
            // tsmiAllDup
            // 
            this.tsmiAllDup.AccessibleDescription = "view_all";
            this.tsmiAllDup.Name = "tsmiAllDup";
            this.tsmiAllDup.Size = new System.Drawing.Size(276, 22);
            this.tsmiAllDup.Text = "View All Duplicate File Finder Products";
            // 
            // tsmiTSSI
            // 
            this.tsmiTSSI.AccessibleDescription = "comp_home";
            this.tsmiTSSI.Name = "tsmiTSSI";
            this.tsmiTSSI.Size = new System.Drawing.Size(276, 22);
            this.tsmiTSSI.Text = "Company Homepage";
            // 
            // tsmiHTrans
            // 
            this.tsmiHTrans.AccessibleDescription = "free_key";
            this.tsmiHTrans.Name = "tsmiHTrans";
            this.tsmiHTrans.Size = new System.Drawing.Size(276, 22);
            this.tsmiHTrans.Text = "Get Free License Key via Translation";
            // 
            // tsmiLatest
            // 
            this.tsmiLatest.AccessibleDescription = "check_new";
            this.tsmiLatest.Name = "tsmiLatest";
            this.tsmiLatest.Size = new System.Drawing.Size(276, 22);
            this.tsmiLatest.Text = "Check Latest Version";
            // 
            // tt
            // 
            this.tt.IsBalloon = true;
            // 
            // lEFN
            // 
            this.lEFN.AccessibleName = "prod_home";
            this.lEFN.AutoSize = true;
            this.lEFN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lEFN.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lEFN.ForeColor = System.Drawing.Color.White;
            this.lEFN.Location = new System.Drawing.Point(73, 14);
            this.lEFN.Name = "lEFN";
            this.lEFN.Size = new System.Drawing.Size(314, 30);
            this.lEFN.TabIndex = 0;
            this.lEFN.Text = "Duplicate Photo Finder Plus vX.X";
            this.tt.SetToolTip(this.lEFN, "Product Homepage");
            // 
            // lFind
            // 
            this.lFind.AccessibleDescription = "find_now";
            this.lFind.AccessibleName = "find_tip3";
            this.lFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lFind.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(7)))));
            this.lFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lFind.Location = new System.Drawing.Point(590, 354);
            this.lFind.Name = "lFind";
            this.lFind.Size = new System.Drawing.Size(126, 65);
            this.lFind.TabIndex = 147;
            this.lFind.Tag = "Ready!";
            this.lFind.Text = "Find Now!";
            this.lFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tt.SetToolTip(this.lFind, "Finds the Duplicate Pictures According to Your Settings <F5>");
            this.lFind.Click += new System.EventHandler(this.lFind_Click);
            // 
            // lStop
            // 
            this.lStop.AccessibleDescription = "stop_find";
            this.lStop.AccessibleName = "stop_tip1";
            this.lStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lStop.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(7)))));
            this.lStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lStop.Location = new System.Drawing.Point(590, 354);
            this.lStop.Name = "lStop";
            this.lStop.Size = new System.Drawing.Size(126, 65);
            this.lStop.TabIndex = 148;
            this.lStop.Text = "Stop Finding";
            this.lStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tt.SetToolTip(this.lStop, "Stops Current Finding Job <F6>");
            // 
            // lLang
            // 
            this.lLang.AccessibleName = "set_lang";
            this.lLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lLang.ForeColor = System.Drawing.Color.White;
            this.lLang.Image = ((System.Drawing.Image)(resources.GetObject("lLang.Image")));
            this.lLang.Location = new System.Drawing.Point(198, 420);
            this.lLang.Name = "lLang";
            this.lLang.Size = new System.Drawing.Size(32, 30);
            this.lLang.TabIndex = 173;
            this.lLang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lLang, "Language");
            // 
            // lVirtual
            // 
            this.lVirtual.AccessibleName = "";
            this.lVirtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lVirtual.ForeColor = System.Drawing.Color.White;
            this.lVirtual.Image = global::Resources.find128;
            this.lVirtual.Location = new System.Drawing.Point(430, 354);
            this.lVirtual.Name = "lVirtual";
            this.lVirtual.Size = new System.Drawing.Size(161, 95);
            this.lVirtual.TabIndex = 160;
            this.lVirtual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lVirtual, "Finds the Duplicate Pictures According to Your Settings <F5>");
            this.lVirtual.Click += new System.EventHandler(this.Buttons_Click);
            this.lVirtual.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.lVirtual.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // lFB
            // 
            this.lFB.AccessibleName = "facebook";
            this.lFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lFB.ForeColor = System.Drawing.Color.White;
            this.lFB.Image = global::Resources.facebook32;
            this.lFB.Location = new System.Drawing.Point(592, 420);
            this.lFB.Name = "lFB";
            this.lFB.Size = new System.Drawing.Size(32, 30);
            this.lFB.TabIndex = 156;
            this.lFB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lFB, "Finds Us on Facebook");
            // 
            // lLogo
            // 
            this.lLogo.AccessibleName = "prod_home";
            this.lLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lLogo.Image = global::Resources.logo64;
            this.lLogo.Location = new System.Drawing.Point(2, -1);
            this.lLogo.Name = "lLogo";
            this.lLogo.Size = new System.Drawing.Size(64, 60);
            this.lLogo.TabIndex = 1;
            this.tt.SetToolTip(this.lLogo, "Product Homepage");
            // 
            // lLoad
            // 
            this.lLoad.AccessibleName = "load_result3";
            this.lLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lLoad.ForeColor = System.Drawing.Color.White;
            this.lLoad.Image = global::Resources.load32_white;
            this.lLoad.Location = new System.Drawing.Point(43, 420);
            this.lLoad.Name = "lLoad";
            this.lLoad.Size = new System.Drawing.Size(32, 30);
            this.lLoad.TabIndex = 162;
            this.lLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lLoad, "Loads Result from a Saved DPFP File Directly <Ctrl+L>");
            // 
            // lReset
            // 
            this.lReset.AccessibleName = "reset_conditions";
            this.lReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lReset.ForeColor = System.Drawing.Color.White;
            this.lReset.Image = global::Resources.reset32;
            this.lReset.Location = new System.Drawing.Point(9, 420);
            this.lReset.Name = "lReset";
            this.lReset.Size = new System.Drawing.Size(32, 30);
            this.lReset.TabIndex = 151;
            this.lReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lReset, "Resets All Conditions to the Default Values <Ctrl+R>");
            // 
            // lTwitter
            // 
            this.lTwitter.AccessibleName = "twitter";
            this.lTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lTwitter.ForeColor = System.Drawing.Color.White;
            this.lTwitter.Image = global::Resources.twitter32;
            this.lTwitter.Location = new System.Drawing.Point(626, 420);
            this.lTwitter.Name = "lTwitter";
            this.lTwitter.Size = new System.Drawing.Size(32, 30);
            this.lTwitter.TabIndex = 156;
            this.lTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lTwitter, "Finds Us on Twitter");
            // 
            // lGP
            // 
            this.lGP.AccessibleName = "google_plus";
            this.lGP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lGP.ForeColor = System.Drawing.Color.White;
            this.lGP.Image = global::Resources.g_32;
            this.lGP.Location = new System.Drawing.Point(660, 420);
            this.lGP.Name = "lGP";
            this.lGP.Size = new System.Drawing.Size(32, 30);
            this.lGP.TabIndex = 156;
            this.lGP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lGP, "Finds Us On Google+");
            // 
            // lRecomm
            // 
            this.lRecomm.AccessibleDescription = "";
            this.lRecomm.AccessibleName = "recommend";
            this.lRecomm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lRecomm.ForeColor = System.Drawing.Color.White;
            this.lRecomm.Image = global::Resources.support32;
            this.lRecomm.Location = new System.Drawing.Point(300, 420);
            this.lRecomm.Name = "lRecomm";
            this.lRecomm.Size = new System.Drawing.Size(32, 30);
            this.lRecomm.TabIndex = 155;
            this.lRecomm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lRecomm, "Recommends to Friends");
            // 
            // lLicense
            // 
            this.lLicense.AccessibleDescription = "license";
            this.lLicense.AccessibleName = "get_license";
            this.lLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lLicense.ForeColor = System.Drawing.Color.White;
            this.lLicense.Image = global::Resources.license32;
            this.lLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lLicense.Location = new System.Drawing.Point(111, 420);
            this.lLicense.Name = "lLicense";
            this.lLicense.Size = new System.Drawing.Size(85, 30);
            this.lLicense.TabIndex = 158;
            this.lLicense.Text = "License";
            this.lLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lLicense, "Gets Your License");
            // 
            // lMore
            // 
            this.lMore.AccessibleName = "more";
            this.lMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lMore.ForeColor = System.Drawing.Color.White;
            this.lMore.Image = global::Resources.more32;
            this.lMore.Location = new System.Drawing.Point(368, 420);
            this.lMore.Name = "lMore";
            this.lMore.Size = new System.Drawing.Size(32, 30);
            this.lMore.TabIndex = 155;
            this.lMore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lMore, "More...");
            // 
            // lHelp
            // 
            this.lHelp.AccessibleName = "disp_help";
            this.lHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lHelp.ForeColor = System.Drawing.Color.White;
            this.lHelp.Image = global::Resources.help32;
            this.lHelp.Location = new System.Drawing.Point(266, 420);
            this.lHelp.Name = "lHelp";
            this.lHelp.Size = new System.Drawing.Size(32, 30);
            this.lHelp.TabIndex = 155;
            this.lHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lHelp, "Online Help <F1>");
            // 
            // lHome
            // 
            this.lHome.AccessibleName = "visit_home";
            this.lHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lHome.ForeColor = System.Drawing.Color.White;
            this.lHome.Image = global::Resources.home32;
            this.lHome.Location = new System.Drawing.Point(232, 420);
            this.lHome.Name = "lHome";
            this.lHome.Size = new System.Drawing.Size(32, 30);
            this.lHome.TabIndex = 157;
            this.lHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lHome, "Product Homepage");
            // 
            // lOpt
            // 
            this.lOpt.AccessibleName = "";
            this.lOpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lOpt.ForeColor = System.Drawing.Color.White;
            this.lOpt.Image = global::Resources.opt32;
            this.lOpt.Location = new System.Drawing.Point(77, 420);
            this.lOpt.Name = "lOpt";
            this.lOpt.Size = new System.Drawing.Size(32, 30);
            this.lOpt.TabIndex = 161;
            this.lOpt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lOpt, "Options <F7>");
            this.lOpt.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // lAbout
            // 
            this.lAbout.AccessibleName = "prog_info";
            this.lAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lAbout.ForeColor = System.Drawing.Color.White;
            this.lAbout.Image = global::Resources.info32;
            this.lAbout.Location = new System.Drawing.Point(334, 420);
            this.lAbout.Name = "lAbout";
            this.lAbout.Size = new System.Drawing.Size(32, 30);
            this.lAbout.TabIndex = 155;
            this.lAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lAbout, "Program Information");
            // 
            // lProgress
            // 
            this.lProgress.AutoSize = true;
            this.lProgress.BackColor = System.Drawing.Color.Maroon;
            this.lProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lProgress.Font = new System.Drawing.Font("Segoe UI", 26.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lProgress.ForeColor = System.Drawing.Color.Lime;
            this.lProgress.Location = new System.Drawing.Point(609, 556);
            this.lProgress.Name = "lProgress";
            this.lProgress.Size = new System.Drawing.Size(266, 39);
            this.lProgress.TabIndex = 143;
            this.lProgress.Text = "Testing, please wait...";
            this.lProgress.Visible = false;
            // 
            // pBanner
            // 
            this.pBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pBanner.Controls.Add(this.lLicType);
            this.pBanner.Controls.Add(this.lLogo);
            this.pBanner.Controls.Add(this.lEFN);
            this.pBanner.Location = new System.Drawing.Point(-1, -1);
            this.pBanner.Name = "pBanner";
            this.pBanner.Size = new System.Drawing.Size(735, 60);
            this.pBanner.TabIndex = 145;
            // 
            // lLicType
            // 
            this.lLicType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lLicType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lLicType.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel);
            this.lLicType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.lLicType.Location = new System.Drawing.Point(563, -1);
            this.lLicType.Name = "lLicType";
            this.lLicType.Size = new System.Drawing.Size(163, 60);
            this.lLicType.TabIndex = 148;
            this.lLicType.Tag = "";
            this.lLicType.Text = "Trial Version";
            this.lLicType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pDrives
            // 
            this.pDrives.BackColor = System.Drawing.Color.White;
            this.pDrives.Controls.Add(this.llSelFF);
            this.pDrives.Controls.Add(this.llSelDrives);
            this.pDrives.Controls.Add(this.lbFF);
            this.pDrives.Controls.Add(this.rbFF);
            this.pDrives.Controls.Add(this.tbDrives);
            this.pDrives.Controls.Add(this.cbNetwork);
            this.pDrives.Controls.Add(this.cbSystem);
            this.pDrives.Controls.Add(this.cbCD);
            this.pDrives.Controls.Add(this.rbExcept);
            this.pDrives.Controls.Add(this.rbSpecify);
            this.pDrives.Controls.Add(this.rbAll);
            this.pDrives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.pDrives.Location = new System.Drawing.Point(9, 96);
            this.pDrives.Name = "pDrives";
            this.pDrives.Size = new System.Drawing.Size(411, 315);
            this.pDrives.TabIndex = 0;
            // 
            // llSelFF
            // 
            this.llSelFF.AccessibleDescription = "";
            this.llSelFF.AutoSize = true;
            this.llSelFF.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.llSelFF.Location = new System.Drawing.Point(316, 155);
            this.llSelFF.Name = "llSelFF";
            this.llSelFF.Size = new System.Drawing.Size(38, 15);
            this.llSelFF.TabIndex = 163;
            this.llSelFF.TabStop = true;
            this.llSelFF.Text = "Select";
            this.llSelFF.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // llSelDrives
            // 
            this.llSelDrives.AccessibleDescription = "";
            this.llSelDrives.AutoSize = true;
            this.llSelDrives.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.llSelDrives.Location = new System.Drawing.Point(316, 95);
            this.llSelDrives.Name = "llSelDrives";
            this.llSelDrives.Size = new System.Drawing.Size(38, 15);
            this.llSelDrives.TabIndex = 162;
            this.llSelDrives.TabStop = true;
            this.llSelDrives.Text = "Select";
            this.llSelDrives.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // lbFF
            // 
            this.lbFF.BackColor = System.Drawing.Color.White;
            this.lbFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lbFF.FormattingEnabled = true;
            this.lbFF.HorizontalScrollbar = true;
            this.lbFF.ItemHeight = 15;
            this.lbFF.Location = new System.Drawing.Point(9, 181);
            this.lbFF.Name = "lbFF";
            this.lbFF.Size = new System.Drawing.Size(393, 124);
            this.lbFF.TabIndex = 159;
            // 
            // rbFF
            // 
            this.rbFF.AccessibleDescription = "";
            this.rbFF.AutoSize = true;
            this.rbFF.Location = new System.Drawing.Point(9, 153);
            this.rbFF.Name = "rbFF";
            this.rbFF.Size = new System.Drawing.Size(222, 19);
            this.rbFF.TabIndex = 158;
            this.rbFF.Text = "Only Scan the Following &Folders/Files";
            this.rbFF.UseVisualStyleBackColor = true;
            this.rbFF.CheckedChanged += new System.EventHandler(this.Buttons_Click);
            // 
            // tbDrives
            // 
            this.tbDrives.BackColor = System.Drawing.Color.White;
            this.tbDrives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDrives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbDrives.Location = new System.Drawing.Point(9, 121);
            this.tbDrives.Name = "tbDrives";
            this.tbDrives.ReadOnly = true;
            this.tbDrives.Size = new System.Drawing.Size(393, 23);
            this.tbDrives.TabIndex = 157;
            // 
            // cbNetwork
            // 
            this.cbNetwork.AccessibleDescription = "";
            this.cbNetwork.AutoSize = true;
            this.cbNetwork.Checked = true;
            this.cbNetwork.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNetwork.Location = new System.Drawing.Point(206, 65);
            this.cbNetwork.Name = "cbNetwork";
            this.cbNetwork.Size = new System.Drawing.Size(114, 19);
            this.cbNetwork.TabIndex = 5;
            this.cbNetwork.Text = "&Network Drive(s)";
            this.cbNetwork.UseVisualStyleBackColor = true;
            // 
            // cbSystem
            // 
            this.cbSystem.AccessibleDescription = "";
            this.cbSystem.AutoSize = true;
            this.cbSystem.Checked = true;
            this.cbSystem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSystem.Location = new System.Drawing.Point(9, 65);
            this.cbSystem.Name = "cbSystem";
            this.cbSystem.Size = new System.Drawing.Size(94, 19);
            this.cbSystem.TabIndex = 3;
            this.cbSystem.Text = "S&ystem Drive";
            this.cbSystem.UseVisualStyleBackColor = true;
            // 
            // cbCD
            // 
            this.cbCD.AccessibleDescription = "";
            this.cbCD.AutoSize = true;
            this.cbCD.Checked = true;
            this.cbCD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCD.Location = new System.Drawing.Point(112, 65);
            this.cbCD.Name = "cbCD";
            this.cbCD.Size = new System.Drawing.Size(85, 19);
            this.cbCD.TabIndex = 4;
            this.cbCD.Text = "&CD Drive(s)";
            this.cbCD.UseVisualStyleBackColor = true;
            // 
            // rbExcept
            // 
            this.rbExcept.AccessibleDescription = "";
            this.rbExcept.AutoSize = true;
            this.rbExcept.Checked = true;
            this.rbExcept.Location = new System.Drawing.Point(9, 37);
            this.rbExcept.Name = "rbExcept";
            this.rbExcept.Size = new System.Drawing.Size(276, 19);
            this.rbExcept.TabIndex = 2;
            this.rbExcept.TabStop = true;
            this.rbExcept.Text = "All &But Excludes the Following Checked Drive(s)";
            this.rbExcept.UseVisualStyleBackColor = true;
            // 
            // rbSpecify
            // 
            this.rbSpecify.AccessibleDescription = "";
            this.rbSpecify.AutoSize = true;
            this.rbSpecify.Location = new System.Drawing.Point(9, 93);
            this.rbSpecify.Name = "rbSpecify";
            this.rbSpecify.Size = new System.Drawing.Size(243, 19);
            this.rbSpecify.TabIndex = 6;
            this.rbSpecify.Text = "Only &Scan the Following Selected Drive(s)";
            this.rbSpecify.UseVisualStyleBackColor = true;
            this.rbSpecify.CheckedChanged += new System.EventHandler(this.Resources_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AccessibleDescription = "";
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(9, 9);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(74, 19);
            this.rbAll.TabIndex = 1;
            this.rbAll.Text = "&All Drives";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // lDrives
            // 
            this.lDrives.AccessibleDescription = "";
            this.lDrives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lDrives.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lDrives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lDrives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lDrives.Location = new System.Drawing.Point(9, 68);
            this.lDrives.Name = "lDrives";
            this.lDrives.Size = new System.Drawing.Size(411, 28);
            this.lDrives.TabIndex = 61;
            this.lDrives.Text = "Select Resources";
            this.lDrives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lTypes
            // 
            this.lTypes.AccessibleDescription = "";
            this.lTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lTypes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lTypes.Location = new System.Drawing.Point(429, 68);
            this.lTypes.Name = "lTypes";
            this.lTypes.Size = new System.Drawing.Size(288, 28);
            this.lTypes.TabIndex = 152;
            this.lTypes.Text = "Select Type(s)";
            this.lTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTypes
            // 
            this.pTypes.BackColor = System.Drawing.Color.White;
            this.pTypes.Controls.Add(this.llTypesManager);
            this.pTypes.Controls.Add(this.cbOthers);
            this.pTypes.Controls.Add(this.cbIcon);
            this.pTypes.Controls.Add(this.cbTIF);
            this.pTypes.Controls.Add(this.cbBMP);
            this.pTypes.Controls.Add(this.cbGIF);
            this.pTypes.Controls.Add(this.cbJPG);
            this.pTypes.Controls.Add(this.cbPNG);
            this.pTypes.Controls.Add(this.cbAll);
            this.pTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.pTypes.Location = new System.Drawing.Point(429, 96);
            this.pTypes.Name = "pTypes";
            this.pTypes.Size = new System.Drawing.Size(288, 94);
            this.pTypes.TabIndex = 16;
            // 
            // llTypesManager
            // 
            this.llTypesManager.AccessibleDescription = "";
            this.llTypesManager.AutoSize = true;
            this.llTypesManager.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.llTypesManager.Location = new System.Drawing.Point(151, 11);
            this.llTypesManager.Name = "llTypesManager";
            this.llTypesManager.Size = new System.Drawing.Size(50, 15);
            this.llTypesManager.TabIndex = 164;
            this.llTypesManager.TabStop = true;
            this.llTypesManager.Text = "Manage";
            // 
            // cbOthers
            // 
            this.cbOthers.AccessibleDescription = "other_pics";
            this.cbOthers.AutoSize = true;
            this.cbOthers.Location = new System.Drawing.Point(122, 65);
            this.cbOthers.Name = "cbOthers";
            this.cbOthers.Size = new System.Drawing.Size(118, 19);
            this.cbOthers.TabIndex = 24;
            this.cbOthers.Text = "All &Other Pictures";
            this.cbOthers.UseVisualStyleBackColor = true;
            // 
            // cbIcon
            // 
            this.cbIcon.AutoSize = true;
            this.cbIcon.Checked = true;
            this.cbIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIcon.Location = new System.Drawing.Point(63, 65);
            this.cbIcon.Name = "cbIcon";
            this.cbIcon.Size = new System.Drawing.Size(49, 19);
            this.cbIcon.TabIndex = 23;
            this.cbIcon.Text = "&Icon";
            this.cbIcon.UseVisualStyleBackColor = true;
            // 
            // cbTIF
            // 
            this.cbTIF.AutoSize = true;
            this.cbTIF.Checked = true;
            this.cbTIF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTIF.Location = new System.Drawing.Point(9, 65);
            this.cbTIF.Name = "cbTIF";
            this.cbTIF.Size = new System.Drawing.Size(41, 19);
            this.cbTIF.TabIndex = 22;
            this.cbTIF.Text = "&TIF";
            this.cbTIF.UseVisualStyleBackColor = true;
            // 
            // cbBMP
            // 
            this.cbBMP.AutoSize = true;
            this.cbBMP.Checked = true;
            this.cbBMP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBMP.Location = new System.Drawing.Point(174, 37);
            this.cbBMP.Name = "cbBMP";
            this.cbBMP.Size = new System.Drawing.Size(51, 19);
            this.cbBMP.TabIndex = 21;
            this.cbBMP.Text = "B&MP";
            this.cbBMP.UseVisualStyleBackColor = true;
            // 
            // cbGIF
            // 
            this.cbGIF.AutoSize = true;
            this.cbGIF.Checked = true;
            this.cbGIF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGIF.Location = new System.Drawing.Point(122, 37);
            this.cbGIF.Name = "cbGIF";
            this.cbGIF.Size = new System.Drawing.Size(43, 19);
            this.cbGIF.TabIndex = 20;
            this.cbGIF.Text = "&GIF";
            this.cbGIF.UseVisualStyleBackColor = true;
            // 
            // cbJPG
            // 
            this.cbJPG.AutoSize = true;
            this.cbJPG.Checked = true;
            this.cbJPG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJPG.Location = new System.Drawing.Point(9, 37);
            this.cbJPG.Name = "cbJPG";
            this.cbJPG.Size = new System.Drawing.Size(45, 19);
            this.cbJPG.TabIndex = 18;
            this.cbJPG.Text = "&JPG";
            this.cbJPG.UseVisualStyleBackColor = true;
            // 
            // cbPNG
            // 
            this.cbPNG.AutoSize = true;
            this.cbPNG.Checked = true;
            this.cbPNG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPNG.Location = new System.Drawing.Point(63, 37);
            this.cbPNG.Name = "cbPNG";
            this.cbPNG.Size = new System.Drawing.Size(50, 19);
            this.cbPNG.TabIndex = 19;
            this.cbPNG.Text = "&PNG";
            this.cbPNG.UseVisualStyleBackColor = true;
            // 
            // cbAll
            // 
            this.cbAll.AccessibleDescription = "";
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(9, 9);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(133, 19);
            this.cbAll.TabIndex = 17;
            this.cbAll.Text = "Ch&eck / Uncheck All";
            this.cbAll.UseVisualStyleBackColor = true;
            // 
            // lCurrent
            // 
            this.lCurrent.AccessibleDescription = "";
            this.lCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lCurrent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lCurrent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lCurrent.Location = new System.Drawing.Point(429, 199);
            this.lCurrent.Name = "lCurrent";
            this.lCurrent.Size = new System.Drawing.Size(288, 28);
            this.lCurrent.TabIndex = 154;
            this.lCurrent.Text = "Current Progress";
            this.lCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmsLicense
            // 
            this.cmsLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmsLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLBuy,
            this.tsmiLInput,
            this.tsmiLRetrieve});
            this.cmsLicense.Name = "cms";
            this.cmsLicense.Size = new System.Drawing.Size(181, 70);
            // 
            // tsmiLBuy
            // 
            this.tsmiLBuy.AccessibleDescription = "purchase";
            this.tsmiLBuy.Name = "tsmiLBuy";
            this.tsmiLBuy.Size = new System.Drawing.Size(180, 22);
            this.tsmiLBuy.Text = "Purchase License";
            // 
            // tsmiLInput
            // 
            this.tsmiLInput.AccessibleDescription = "input_key";
            this.tsmiLInput.Name = "tsmiLInput";
            this.tsmiLInput.Size = new System.Drawing.Size(180, 22);
            this.tsmiLInput.Text = "Input License Key...";
            // 
            // tsmiLRetrieve
            // 
            this.tsmiLRetrieve.AccessibleDescription = "retrieve_key";
            this.tsmiLRetrieve.Name = "tsmiLRetrieve";
            this.tsmiLRetrieve.Size = new System.Drawing.Size(180, 22);
            this.tsmiLRetrieve.Text = "Retrieve License Key";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(429, 353);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(288, 1);
            this.Label3.TabIndex = 166;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(716, 353);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(1, 66);
            this.Label5.TabIndex = 168;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(429, 353);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(1, 96);
            this.Label4.TabIndex = 169;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(591, 419);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(126, 1);
            this.Label1.TabIndex = 170;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(591, 419);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(1, 31);
            this.Label2.TabIndex = 171;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(429, 449);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(162, 1);
            this.Label6.TabIndex = 172;
            // 
            // cmsLangs
            // 
            this.cmsLangs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cmsLangs.Name = "cms";
            this.cmsLangs.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(727, 461);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lLang);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lVirtual);
            this.Controls.Add(this.lFB);
            this.Controls.Add(this.pBanner);
            this.Controls.Add(this.pTypes);
            this.Controls.Add(this.lLoad);
            this.Controls.Add(this.lReset);
            this.Controls.Add(this.lTwitter);
            this.Controls.Add(this.lGP);
            this.Controls.Add(this.lTypes);
            this.Controls.Add(this.lRecomm);
            this.Controls.Add(this.lCurrent);
            this.Controls.Add(this.pDrives);
            this.Controls.Add(this.lProgress);
            this.Controls.Add(this.lLicense);
            this.Controls.Add(this.lDrives);
            this.Controls.Add(this.lPrompt);
            this.Controls.Add(this.lMore);
            this.Controls.Add(this.lHelp);
            this.Controls.Add(this.lHome);
            this.Controls.Add(this.lOpt);
            this.Controls.Add(this.lAbout);
            this.Controls.Add(this.lFind);
            this.Controls.Add(this.lStop);
            this.Font = new System.Drawing.Font("Segoe UI", 11.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(632, 444);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duplicate Photo Finder Plus";
            this.cmsMore.ResumeLayout(false);
            this.pBanner.ResumeLayout(false);
            this.pBanner.PerformLayout();
            this.pDrives.ResumeLayout(false);
            this.pDrives.PerformLayout();
            this.pTypes.ResumeLayout(false);
            this.pTypes.PerformLayout();
            this.cmsLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void Me_FormClosing(object sender, FormClosingEventArgs e)
	{
		//Discarded unreachable code: IL_005c, IL_0086, IL_0088, IL_0098, IL_00ba
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
			if (Operators.CompareString(lFind.Tag.ToString(), "F", TextCompare: false) == 0)
			{
				num = 4;
				if (Interaction.MsgBox(SelfService.GetWord("finding1"), MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question) != MsgBoxResult.Yes)
				{
					num = 5;
					e.Cancel = true;
				}
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_00b8: Could not find block for branch target IL_0088*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Me_HelpRequested(object sender, HelpEventArgs hlpevent)
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
			Buttons_Click(lHelp, new EventArgs());
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

	private void cbTypes_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_00f5, IL_0123, IL_0125, IL_0135, IL_0157
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
			if (!cbJPG.Checked && !cbPNG.Checked && !cbGIF.Checked && !cbBMP.Checked && !cbTIF.Checked && !cbIcon.Checked && !cbOthers.Checked)
			{
				num = 4;
				cbAll.Checked = false;
			}
			else
			{
				num = 6;
				if (cbJPG.Checked && cbPNG.Checked && cbGIF.Checked && cbBMP.Checked && cbTIF.Checked && cbIcon.Checked && cbOthers.Checked)
				{
					num = 7;
					cbAll.Checked = true;
				}
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0155: Could not find block for branch target IL_0125*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cbAll_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_00c6, IL_00fc, IL_00fe, IL_010e, IL_0130
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
			cbJPG.Checked = cbAll.Checked;
			num = 4;
			cbPNG.Checked = cbAll.Checked;
			num = 5;
			cbGIF.Checked = cbAll.Checked;
			num = 6;
			cbBMP.Checked = cbAll.Checked;
			num = 7;
			cbTIF.Checked = cbAll.Checked;
			num = 8;
			cbIcon.Checked = cbAll.Checked;
			num = 9;
			cbOthers.Checked = cbAll.Checked;
		}
		catch (Exception obj) when((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_012e: Could not find block for branch target IL_00fe*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

		private void cbExcept_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_002b, IL_0049, IL_004b, IL_005b, IL_007d
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
			rbExcept.Checked = true;
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_007b: Could not find block for branch target IL_004b*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Buttons_MouseEnter(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_00a4, IL_00d6, IL_00d8, IL_00e8, IL_010a
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
			Control control = (Control)sender;
			num = 4;
			control.BackColor = Declarer.darkGray;
			num = 5;
			if (Operators.CompareString(control.Name, "lFind", TextCompare: false) == 0 || Operators.CompareString(control.Name, "lStop", TextCompare: false) == 0 || Operators.CompareString(control.Name, "lVirtual", TextCompare: false) == 0)
			{
				num = 6;
				lVirtual.BackColor = Declarer.darkGray;
				num = 7;
				lFind.BackColor = Declarer.darkGray;
				num = 8;
				lStop.BackColor = Declarer.darkGray;
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0108: Could not find block for branch target IL_00d8*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Buttons_MouseLeave(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_00a4, IL_00d6, IL_00d8, IL_00e8, IL_010a
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
			Control control = (Control)sender;
			num = 4;
			control.BackColor = Declarer.lightGray;
			num = 5;
			if (Operators.CompareString(control.Name, "lFind", TextCompare: false) == 0 || Operators.CompareString(control.Name, "lStop", TextCompare: false) == 0 || Operators.CompareString(control.Name, "lVirtual", TextCompare: false) == 0)
			{
				num = 6;
				lVirtual.BackColor = Declarer.lightGray;
				num = 7;
				lFind.BackColor = Declarer.lightGray;
				num = 8;
				lStop.BackColor = Declarer.lightGray;
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0108: Could not find block for branch target IL_00d8*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cmsLicense_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
		//Discarded unreachable code: IL_0229, IL_02b7, IL_02b9, IL_02c9, IL_02eb
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
			cmsLicense.Visible = false;
			num = 4;
			string name = e.ClickedItem.Name;
			if (Operators.CompareString(name, "tsmiLBuy", TextCompare: false) != 0)
			{
				if (Operators.CompareString(name, "tsmiLInput", TextCompare: false) != 0)
				{
					if (Operators.CompareString(name, "tsmiLRetrieve", TextCompare: false) == 0)
					{
						num = 30;
						Interaction.Shell("explorer \"http://www.trisunsoft.com/contact.htm#key\"", AppWinStyle.NormalFocus);
					}
				}
				else
				{
					while (true)
					{
						num = 8;
						string empty = string.Empty;
						num = 9;
						empty = Interaction.InputBox(SelfService.GetWord("input_key_prompt")).Trim();
						num = 10;
						if (empty.Length < 1)
						{
							break;
						}
						num = 12;
						if (SelfService.VerifyKey(empty, ref Declarer.licenseType, ref Declarer.licensedPCs))
						{
							num = 16;
							My.MySettingsProperty.Settings.key = empty;
							while (true)
							{
								num = 17;
								if (General.InStrings(Declarer.licenseType, "SG", "PS", "HM"))
								{
									num = 18;
									My.MySettingsProperty.Settings.user = Interaction.InputBox(SelfService.GetWord("input_name")).Trim();
								}
								else
								{
									num = 20;
									My.MySettingsProperty.Settings.user = Interaction.InputBox(SelfService.GetWord("input_compname")).Trim();
								}
								num = 21;
								if (My.MySettingsProperty.Settings.user.Length >= 1)
								{
									num = 23;
									if (Operators.CompareString(My.MySettingsProperty.Settings.user, Interaction.InputBox(SelfService.GetWord("input_again")).Trim(), TextCompare: false) == 0)
									{
										break;
									}
									num = 24;
									Interaction.MsgBox(SelfService.GetWord("error_names"), MsgBoxStyle.Information);
								}
							}
							num = 26;
							My.MySettingsProperty.Settings.Save();
							num = 27;
							Form inter = this;
							SelfService.DisplayLicense(ref inter);
							num = 28;
							Interaction.MsgBox(SelfService.GetWord("congratulation"), MsgBoxStyle.Information);
							break;
						}
						num = 13;
						Interaction.MsgBox(SelfService.GetWord("error_key"), MsgBoxStyle.Exclamation);
					}
				}
			}
			else
			{
				num = 6;
				SelfService.Purchase();
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_02e9: Could not find block for branch target IL_02b9*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cmsHelp_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
		//Discarded unreachable code: IL_0254, IL_02c2, IL_02c4, IL_02d4, IL_02f6
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
			cmsMore.Visible = false;
			num = 4;
			string name = e.ClickedItem.Name;
			switch (_003CPrivateImplementationDetails_003E.ComputeStringHash(name))
			{
			case 3639714892u:
				if (Operators.CompareString(name, "tsmiHVT", TextCompare: false) == 0)
				{
					num = 6;
					Interaction.Shell("explorer \"https://youtu.be/34sX8J2bjcY\"", AppWinStyle.NormalFocus);
				}
				break;
			case 3836876212u:
				if (Operators.CompareString(name, "tsmiNew", TextCompare: false) == 0)
				{
					num = 8;
					Interaction.Shell("explorer \"http://DuplicateFileFinder4PC.com/duplicate-photo-finder-plus.htm?expand=updatetext&source=dpfp_inter#update\"", AppWinStyle.NormalFocus);
				}
				break;
			case 2113394185u:
				if (Operators.CompareString(name, "tsmiSupport", TextCompare: false) == 0)
				{
					num = 10;
					Interaction.Shell("explorer \"http://DuplicateFileFinder4PC.com/support.htm#email\"", AppWinStyle.NormalFocus);
				}
				break;
			case 3660380239u:
				if (Operators.CompareString(name, "tsmiRSupport", TextCompare: false) == 0)
				{
					num = 12;
					Interaction.Shell("explorer \"http://www.TriSunSoft.com/contact.htm#remote\"", AppWinStyle.NormalFocus);
				}
				break;
			case 3893614522u:
				if (Operators.CompareString(name, "tsmiAllDup", TextCompare: false) == 0)
				{
					num = 14;
					Interaction.Shell("explorer \"http://DuplicateFileFinder4PC.com/\"", AppWinStyle.NormalFocus);
				}
				break;
			case 1646601491u:
				if (Operators.CompareString(name, "tsmiTSSI", TextCompare: false) == 0)
				{
					num = 16;
					Interaction.Shell("explorer \"http://www.trisunsoft.com/\"", AppWinStyle.NormalFocus);
				}
				break;
			case 712474456u:
				if (Operators.CompareString(name, "tsmiHTrans", TextCompare: false) == 0)
				{
					num = 18;
					Interaction.Shell("explorer \"http://www.trisunsoft.com/translate.htm\"", AppWinStyle.NormalFocus);
				}
				break;
			case 3714752033u:
				if (Operators.CompareString(name, "tsmiLatest", TextCompare: false) == 0)
				{
					num = 20;
					string word = SelfService.GetWord("checking_new");
					Form f = this;
					Label l = lProgress;
					SelfService.WaitPrompt(word, ref f, ref l);
					lProgress = l;
					num = 21;
					SelfService.CheckLatestVer();
					num = 22;
					f = this;
					l = lProgress;
					SelfService.AfterPrompt(ref f, ref l);
					lProgress = l;
				}
				break;
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_02f4: Could not find block for branch target IL_02c4*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Me_KeyDown(object sender, KeyEventArgs e)
	{
		//Discarded unreachable code: IL_010b, IL_0169, IL_016b, IL_017b, IL_019d
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
			if (e.Control)
			{
				num = 4;
				switch (e.KeyCode)
				{
				case Keys.R:
					num = 6;
					lReset_Click(lReset, new EventArgs());
					break;
				case Keys.L:
					num = 8;
					Buttons_Click(lLoad, new EventArgs());
					break;
				}
			}
			num = 10;
			switch (e.KeyCode)
			{
			case Keys.F7:
				num = 12;
				Buttons_Click(lOpt, new EventArgs());
				break;
			case Keys.F5:
				num = 14;
				if (Operators.CompareString(lFind.Tag.ToString(), "F", TextCompare: false) != 0)
				{
					num = 15;
					lFind_Click(lFind, new EventArgs());
				}
				break;
			case Keys.F6:
				num = 17;
				if (Operators.CompareString(lFind.Tag.ToString(), "F", TextCompare: false) == 0)
				{
					num = 18;
					Buttons_Click(lStop, new EventArgs());
				}
				break;
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_019b: Could not find block for branch target IL_016b*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Me_Load(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_00b5, IL_00e7, IL_00e9, IL_00f9, IL_011b
		checked
		{
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
				LoadLangText();
				num = 4;
				Form inter = this;
				SelfService.DisplayLicense(ref inter);
				num = 5;
				Text = "Duplicate Photo Finder Plus";
				num = 6;
				lEFN.Text = "Duplicate Photo Finder Plus v8.0";
				num = 7;
				base.Left = (int)Math.Round((double)(Screen.PrimaryScreen.WorkingArea.Width - base.Width) * 0.382);
				num = 8;
				base.Top = (int)Math.Round((double)(Screen.PrimaryScreen.WorkingArea.Height - base.Height) * 0.382);
			}
			catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_0119: Could not find block for branch target IL_00e9*/;
			}
			if (num3 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Buttons_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_060e, IL_06fc, IL_06fe, IL_070e, IL_0730
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
			string name = ((Control)sender).Name;
			Console.WriteLine(_003CPrivateImplementationDetails_003E.ComputeStringHash(name).ToString());
			switch (_003CPrivateImplementationDetails_003E.ComputeStringHash(name))
			{
			case 3964015041u:
				if (Operators.CompareString(name, "llTypesManager", TextCompare: false) == 0)
				{
					num = 5;
					My.MyProject.Forms.Types.ShowDialog(this);
				}
				break;
			case 4159638806u:
				if (Operators.CompareString(name, "llSelDrives", TextCompare: false) == 0)
				{
					num = 7;
					My.MyProject.Forms.DrivesSelector.ShowDialog(this);
				}
				break;
			case 2377643907u:
				if (Operators.CompareString(name, "llSelFF", TextCompare: false) == 0)
				{
					num = 9;
					My.MyProject.Forms.FFSelector.ShowDialog(this);
				}
				break;
			case 892509120u:
				if (Operators.CompareString(name, "lOpt", TextCompare: false) == 0)
				{
					num = 11;
					if (Operators.CompareString(lFind.Tag.ToString(), "F", TextCompare: false) == 0)
					{
						num = 12;
						Interaction.MsgBox(SelfService.GetWord("condi_find"), MsgBoxStyle.Information);
					}
					else
					{
						num = 14;
						My.MyProject.Forms.Options.ShowDialog(this);
					}
				}
				break;
			case 2193529387u:
				if (Operators.CompareString(name, "lLoad", TextCompare: false) == 0)
				{
					num = 16;
					if (Operators.CompareString(lFind.Tag.ToString(), "F", TextCompare: false) == 0)
					{
						num = 17;
						Interaction.MsgBox(SelfService.GetWord("load_find"), MsgBoxStyle.Information);
					}
					else
					{
						num = 19;
						Declarer.finalResult = new SortedDictionary<string, List<string>>(new Declarer.DescComparer());
						num = 20;
						Declarer.loadFromMain = true;
						num = 21;
						My.MyProject.Forms.Result.ShowDialog(this);
					}
				}
				break;
			case 3339041242u:
				if (Operators.CompareString(name, "lLicense", TextCompare: false) == 0)
				{
					num = 23;
					cmsLicense.Show(lLicense, 0, lLicense.Height);
				}
				break;
			case 65967693u:
				if (Operators.CompareString(name, "lLicType", TextCompare: false) == 0)
				{
					num = 25;
					if (Declarer.licenseType.Length < 1)
					{
						num = 26;
						SelfService.Purchase();
					}
				}
				break;
			case 2952640931u:
				if (Operators.CompareString(name, "lStop", TextCompare: false) == 0)
				{
					num = 28;
					lFind.BringToFront();
					num = 29;
					lVirtual.Image = Resources.find128;
					num = 30;
					tt.SetToolTip(lVirtual, SelfService.GetWord("find_tip3"));
					num = 31;
					lFind.Tag = "S";
				}
				break;
			case 3877574414u:
				if (Operators.CompareString(name, "lVirtual", TextCompare: false) == 0)
				{
					num = 33;
					if (Operators.CompareString(lFind.Tag.ToString(), "F", TextCompare: false) == 0)
					{
						num = 34;
						Buttons_Click(lStop, new EventArgs());
					}
					else
					{
						num = 36;
						lFind_Click(lFind, new EventArgs());
					}
				}
				break;
			case 2611984124u:
				if (Operators.CompareString(name, "lLogo", TextCompare: false) != 0)
				{
					break;
				}
				goto IL_0537;
			case 2391145246u:
				if (Operators.CompareString(name, "lEFN", TextCompare: false) != 0)
				{
					break;
				}
				goto IL_0537;
			case 397063848u:
				if (Operators.CompareString(name, "lHome", TextCompare: false) != 0)
				{
					break;
				}
				goto IL_0537;
			case 2426073928u:
				if (Operators.CompareString(name, "lHelp", TextCompare: false) == 0)
				{
					num = 40;
					Interaction.Shell("explorer \"http://DuplicateFileFinder4PC.com/duplicate-photo-finder-plus.htm?expand=usagetext#usage\"", AppWinStyle.NormalFocus);
				}
				break;
			case 431928106u:
				if (Operators.CompareString(name, "lRecomm", TextCompare: false) == 0)
				{
					num = 42;
					Interaction.Shell("explorer \"http://DuplicateFileFinder4PC.com/duplicate-photo-finder-plus.htm?expand=recommendtext#recommend\"", AppWinStyle.NormalFocus);
				}
				break;
			case 2241562072u:
				if (Operators.CompareString(name, "lAbout", TextCompare: false) == 0)
				{
					num = 44;
					My.MyProject.Forms.About.ShowDialog();
				}
				break;
			case 2431448798u:
				if (Operators.CompareString(name, "lMore", TextCompare: false) == 0)
				{
					num = 46;
					cmsMore.Show(lMore, 0, lMore.Height);
				}
				break;
			case 1947814959u:
				if (Operators.CompareString(name, "lFB", TextCompare: false) == 0)
				{
					num = 48;
					Interaction.Shell("explorer \"https://www.facebook.com/DuplicateFileFinder4PC\"", AppWinStyle.NormalFocus);
				}
				break;
			case 2915629254u:
				if (Operators.CompareString(name, "lTwitter", TextCompare: false) == 0)
				{
					num = 50;
					Interaction.Shell("explorer \"https://twitter.com/D2F4PC\"", AppWinStyle.NormalFocus);
				}
				break;
			case 1612115484u:
				if (Operators.CompareString(name, "lGP", TextCompare: false) == 0)
				{
					num = 52;
					Interaction.Shell("explorer \"https://google.com/+Duplicatefilefinder4pc\"", AppWinStyle.NormalFocus);
				}
				break;
			case 3852240915u:
				{
					if (Operators.CompareString(name, "lLang", TextCompare: false) == 0)
					{
						num = 54;
						cmsLangs.Show(lLang, 0, lLang.Height);
					}
					break;
				}
				IL_0537:
				num = 38;
				Interaction.Shell("explorer \"http://DuplicateFileFinder4PC.com/duplicate-photo-finder-plus.htm?source=dpfp_inter\"", AppWinStyle.NormalFocus);
				break;
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_072e: Could not find block for branch target IL_06fe*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void lReset_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_010a, IL_0160, IL_0162, IL_0172, IL_0194
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
			if (Operators.CompareString(lFind.Tag.ToString(), "F", TextCompare: false) == 0)
			{
				num = 4;
				Interaction.MsgBox(SelfService.GetWord("reset_find"), MsgBoxStyle.Information);
			}
			else
			{
				num = 6;
				rbExcept.Checked = true;
				num = 7;
				cbSystem.Checked = true;
				num = 8;
				cbCD.Checked = true;
				num = 9;
				cbNetwork.Checked = true;
				num = 10;
				cbAll.Checked = false;
				num = 11;
				cbJPG.Checked = true;
				num = 12;
				cbPNG.Checked = true;
				num = 13;
				cbGIF.Checked = true;
				num = 14;
				cbBMP.Checked = true;
				num = 15;
				cbTIF.Checked = true;
				num = 16;
				cbIcon.Checked = true;
				num = 17;
				cbOthers.Checked = false;
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0192: Could not find block for branch target IL_0162*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void lFind_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_1368, IL_1766, IL_1768, IL_1778, IL_179a
		//My.MySettingsProperty.Settings.smart = true;
		checked
		{
			int num2 = default(int);
			int num8 = default(int);
			try
			{
				int num = 1;
				if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", Microsoft.VisualBasic.CompareMethod.Binary))
				{
					ProjectData.ClearProjectError();
					num2 = 1;
				}
				num = 3;
				if (!cbJPG.Checked && !cbPNG.Checked && !cbGIF.Checked && !cbBMP.Checked && !cbTIF.Checked && !cbIcon.Checked && !cbOthers.Checked)
				{
					num = 4;
					Interaction.MsgBox(SelfService.GetWord("sel_type1"), MsgBoxStyle.Information);
				}
				else
				{
					num = 6;
					if (rbSpecify.Checked)
					{
						num = 7;
						if (tbDrives.Text.Length < 1)
						{
							num = 8;
							Interaction.MsgBox(SelfService.GetWord("sel_drive1"), MsgBoxStyle.Information);
							goto IL_12c0;
						}
					}
					else
					{
						num = 11;
						if (rbFF.Checked)
						{
							num = 12;
							if (lbFF.Items.Count < 1)
							{
								num = 13;
								Interaction.MsgBox(SelfService.GetWord("sel_ff1"), MsgBoxStyle.Information);
								goto IL_12c0;
							}
						}
					}
					num = 15;
					DateTime now = DateAndTime.Now;
					num = 16;
					base.Enabled = false;
					num = 17;
					lStop.BringToFront();
					num = 18;
					lVirtual.Image = Resources.stop128;
					num = 19;
					tt.SetToolTip(lVirtual, SelfService.GetWord("stop_tip1"));
					num = 20;
					lFind.Tag = "F";
					num = 21;
					pDrives.Enabled = false;
					num = 22;
					pTypes.Enabled = false;
					num = 23;
					base.Enabled = true;
					num = 24;
					Declarer.ScannedResult.Clear();
					num = 25;
					Declarer.ComparedResult.Clear();
					num = 26;
					Declarer.finalResult.Clear();
					num = 27;
					My.MyProject.Forms.Result.tlv.Items.Clear();
					num = 28;
					My.MyProject.Forms.Result.cbSA.Checked = true;
					num = 29;
					My.MyProject.Forms.Result.cbSH.Checked = true;
					num = 30;
					My.MyProject.Forms.Result.cbSL.Checked = true;
					num = 31;
					My.MyProject.Forms.Result.cbSM.Checked = true;
					num = 32;
					My.MyProject.Forms.Result.cbSS.Checked = true;
					num = 33;
					My.MyProject.Forms.Result.cbST.Checked = true;
					num = 34;
					Declarer.scannedFolders = 0;
					num = 35;
					Declarer.scannedFiles = 0L;
					num = 36;
					Declarer.scannedSize = 0L;
					num = 37;
					Declarer.dupSize = 0L;
					num = 38;
					My.MyProject.Forms.Result.pPreviews.Controls.Clear();
					num = 39;
					lPrompt.Text = SelfService.GetWord("start_scan");
					num = 40;
					if (rbSpecify.Checked)
					{
						num = 41;
						List<string>.Enumerator enumerator = Declarer.selectedDrives.GetEnumerator();
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							num = 42;
							DriveInfo driveInfo = new DriveInfo(current);
							num = 43;
							if (driveInfo.IsReady)
							{
								num = 44;
								Declarer.scannedSize += driveInfo.TotalSize - driveInfo.TotalFreeSpace;
								num = 45;
								SelfService.ScanFiles(current, true);
							}
							num = 46;
							if (Operators.CompareString(lFind.Tag.ToString(), "S", TextCompare: false) != 0)
							{
								num = 48;
								continue;
							}
							goto IL_12c0;
						}
						num = 49;
						((IDisposable)enumerator).Dispose();
					}
					else
					{
						num = 51;
						if (rbFF.Checked)
						{
							num = 52;
							List<string> list = new List<string>();
							num = 53;
							IEnumerator enumerator2 = lbFF.Items.GetEnumerator();
							int num3 = default(int);
							while (enumerator2.MoveNext())
							{
								object objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
								num = 54;
								if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(objectValue.ToString()))
								{
									num = 55;
									if (!list.Contains(new FileInfo(objectValue.ToString()).DirectoryName.ToLower()))
									{
										num = 56;
										list.Add(new FileInfo(objectValue.ToString()).DirectoryName.ToLower());
									}
								}
								else
								{
									num = 58;
									if (Microsoft.VisualBasic.FileIO.FileSystem.DirectoryExists(objectValue.ToString()))
									{
										num = 59;
										if (!list.Contains(objectValue.ToString().ToLower()))
										{
											num = 60;
											list.Add(objectValue.ToString().ToLower());
										}
										num = 61;
										num3++;
									}
								}
								num = 62;
							}
							num = 63;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
							num = 64;
							Declarer.scannedFolders += list.Count - num3;
							num = 65;
							IEnumerator enumerator3 = lbFF.Items.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator3.Current);
								num = 66;
								if (Microsoft.VisualBasic.FileIO.FileSystem.DirectoryExists(objectValue2.ToString()))
								{
									num = 67;
									Folder folder = ((IFileSystem3)new FileSystemObjectClass()).GetFolder(objectValue2.ToString());
									num = 68;
									Declarer.scannedSize += Conversions.ToLong(folder.Size);
									num = 69;
									SelfService.ScanFiles(objectValue2.ToString(), true);
								}
								else
								{
									num = 71;
									if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(objectValue2.ToString()))
									{
										num = 72;
										SelfService.ScanFile(objectValue2.ToString());
									}
								}
								num = 73;
								if (Operators.CompareString(lFind.Tag.ToString(), "S", TextCompare: false) != 0)
								{
									num = 75;
									continue;
								}
								goto IL_12c0;
							}
							num = 76;
							if (enumerator3 is IDisposable)
							{
								(enumerator3 as IDisposable).Dispose();
							}
						}
						else
						{
							num = 78;
							DriveInfo[] drives = DriveInfo.GetDrives();
							num = 79;
							string environmentVariable = Environment.GetEnvironmentVariable("SystemDrive");
							num = 80;
							DriveInfo[] array = drives;
							for (int i = 0; i < array.Length; num = 100, i++)
							{
								DriveInfo driveInfo2 = array[i];
								num = 81;
								if (!driveInfo2.IsReady)
								{
									continue;
								}
								num = 82;
								if (rbAll.Checked)
								{
									num = 83;
									Declarer.scannedSize += driveInfo2.TotalSize - driveInfo2.TotalFreeSpace;
									num = 84;
									SelfService.ScanFiles(driveInfo2.Name, true);
								}
								else
								{
									num = 86;
									if (rbExcept.Checked)
									{
										num = 87;
										if (cbSystem.Checked)
										{
											num = 88;
											if (Operators.CompareString(driveInfo2.Name.ToLower().Substring(0, 2), environmentVariable.ToLower().Substring(0, 2), TextCompare: false) == 0)
											{
												continue;
											}
										}
										num = 90;
										if (cbCD.Checked)
										{
											num = 91;
											if (driveInfo2.DriveType == DriveType.CDRom)
											{
												continue;
											}
										}
										num = 93;
										if (cbNetwork.Checked)
										{
											num = 94;
											if (driveInfo2.DriveType == DriveType.Network)
											{
												continue;
											}
										}
										num = 96;
										Declarer.scannedSize += driveInfo2.TotalSize - driveInfo2.TotalFreeSpace;
										num = 97;
										SelfService.ScanFiles(driveInfo2.Name, true);
									}
								}
								num = 98;
								if (Operators.CompareString(lFind.Tag.ToString(), "S", TextCompare: false) != 0)
								{
									continue;
								}
								goto IL_12c0;
							}
						}
					}
					num = 101;
					lPrompt.Text = SelfService.GetWord("finish_scan");
					num = 102;
					lPrompt.Text = SelfService.GetWord("start_comp");
					num = 103;
					int num4 = 0;
					num = 104;
					Dictionary<long, List<string>>.Enumerator enumerator4 = Declarer.ScannedResult.GetEnumerator();
					while (true)
					{
						if (!enumerator4.MoveNext())
						{
							num = 113;
							((IDisposable)enumerator4).Dispose();
							num = 114;
							Declarer.ScannedResult.Clear();
							num = 115;
							lPrompt.Text = SelfService.GetWord("finish_comp");
							num = 116;
							lPrompt.Text = SelfService.GetWord("sort_result");
							num = 117;
							Declarer.finalResult = new SortedDictionary<string, List<string>>(Declarer.ComparedResult, new Declarer.DescComparer());
							num = 118;
							Declarer.ComparedResult.Clear();
							num = 119;
							lPrompt.Text = SelfService.GetWord("load_result2");
							num = 120;
							bool flag = false;
							num = 121;
							List<string> list2 = new List<string>();
							num = 122;
							SortedDictionary<string, List<string>>.Enumerator enumerator5 = Declarer.finalResult.GetEnumerator();
							while (enumerator5.MoveNext())
							{
								KeyValuePair<string, List<string>> current2 = enumerator5.Current;
								num = 123;
								DateTime t = default(DateTime);
								num = 124;
								int num5 = 0;
								num = 125;
								int num6 = 0;
								num = 126;
								string item = string.Empty;
								num = 127;
								List<string>.Enumerator enumerator6 = current2.Value.GetEnumerator();
								while (enumerator6.MoveNext())
								{
									string current3 = enumerator6.Current;
									num = 128;
									IWshRuntimeLibrary.File file = ((IFileSystem3)new FileSystemObjectClass()).GetFile(current3);
									num = 129;
									if (My.MySettingsProperty.Settings.smart)
									{
										num = 130;
										if (num5 == 0)
										{
											num = 131;
											t = file.DateCreated;
											num = 132;
											num5 = file.ParentFolder.Path.Length;
											num = 133;
											num6 = file.Name.Length;
											num = 134;
											item = current3;
										}
										else
										{
											num = 136;
											if (DateTime.Compare(file.DateCreated, t) > 0)
											{
												num = 137;
												if (Operators.CompareString(My.MySettingsProperty.Settings.created, "L", TextCompare: false) == 0)
												{
													num = 138;
													t = file.DateCreated;
													num = 139;
													num5 = file.ParentFolder.Path.Length;
													num = 140;
													num6 = file.Name.Length;
													num = 141;
													item = current3;
												}
											}
											else
											{
												num = 143;
												if (DateTime.Compare(file.DateCreated, t) < 0)
												{
													num = 144;
													if (Operators.CompareString(My.MySettingsProperty.Settings.created, "E", TextCompare: false) == 0)
													{
														num = 145;
														t = file.DateCreated;
														num = 146;
														num5 = file.ParentFolder.Path.Length;
														num = 147;
														num6 = file.Name.Length;
														num = 148;
														item = current3;
													}
												}
												else
												{
													num = 150;
													if (file.ParentFolder.Path.Length < num5)
													{
														num = 151;
														if (Operators.CompareString(My.MySettingsProperty.Settings.path, "S", TextCompare: false) == 0)
														{
															num = 152;
															t = file.DateCreated;
															num = 153;
															num5 = file.ParentFolder.Path.Length;
															num = 154;
															num6 = file.Name.Length;
															num = 155;
															item = current3;
														}
													}
													else
													{
														num = 157;
														if (file.ParentFolder.Path.Length > num5)
														{
															num = 158;
															if (Operators.CompareString(My.MySettingsProperty.Settings.path, "L", TextCompare: false) == 0)
															{
																num = 159;
																t = file.DateCreated;
																num = 160;
																num5 = file.ParentFolder.Path.Length;
																num = 161;
																num6 = file.Name.Length;
																num = 162;
																item = current3;
															}
														}
														else
														{
															num = 164;
															if (file.Name.Length < num6)
															{
																num = 165;
																if (Operators.CompareString(My.MySettingsProperty.Settings.name, "S", TextCompare: false) == 0)
																{
																	num = 166;
																	t = file.DateCreated;
																	num = 167;
																	num5 = file.ParentFolder.Path.Length;
																	num = 168;
																	num6 = file.Name.Length;
																	num = 169;
																	item = current3;
																}
															}
															else
															{
																num = 171;
																if (file.Name.Length > num6)
																{
																	num = 172;
																	if (Operators.CompareString(My.MySettingsProperty.Settings.path, "L", TextCompare: false) == 0)
																	{
																		num = 173;
																		t = file.DateCreated;
																		num = 174;
																		num5 = file.ParentFolder.Path.Length;
																		num = 175;
																		num6 = file.Name.Length;
																		num = 176;
																		item = current3;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
									num = 177;
									ListViewItem listViewItem = My.MyProject.Forms.Result.tlv.Items.Add(file.Name);
									num = 178;
									listViewItem.Name = current3;
									num = 179;
									listViewItem.Tag = current2.Key + "|" + current3;
									num = 180;
									if (flag)
									{
										num = 181;
										listViewItem.ForeColor = Color.FromArgb(4, 165, 240);
									}
									num = 182;
									listViewItem.SubItems.Add(file.ParentFolder.Path);
									num = 183;
									listViewItem.SubItems.Add(SelfService.IntelligentSize(Conversions.ToLong(Conversion.Int(current2.Key))));
									num = 184;
									Declarer.dupSize += Conversions.ToLong(Conversion.Int(current2.Key));
									num = 185;
									listViewItem.SubItems.Add(file.Type);
									num = 186;
									listViewItem.SubItems.Add(file.DateCreated.ToString());
									num = 187;
									listViewItem.SubItems.Add(file.DateLastModified.ToString());
									num = 188;
									Console.WriteLine(My.MySettingsProperty.Settings.smart);
									if (My.MySettingsProperty.Settings.smart)
									{
										num = 189;
										listViewItem.Checked = true;
									}
									num = 190;
								}
								num = 191;
								((IDisposable)enumerator6).Dispose();
								num = 192;
								flag = !flag;
								num = 193;
								if (My.MySettingsProperty.Settings.smart)
								{
									num = 194;
									list2.Add(item);
								}
								num = 195;
							}
							num = 196;
							((IDisposable)enumerator5).Dispose();
							num = 197;
							if (My.MySettingsProperty.Settings.smart)
							{
								num = 198;
								List<string>.Enumerator enumerator7 = list2.GetEnumerator();
								while (enumerator7.MoveNext())
								{
									string current4 = enumerator7.Current;
									num = 199;
									My.MyProject.Forms.Result.tlv.Items.Find(current4, searchAllSubItems: false)[0].Checked = false;
									num = 200;
								}
								num = 201;
								((IDisposable)enumerator7).Dispose();
							}
							num = 202;
							lPrompt.Text = SelfService.GetWord("done");
							num = 203;
							Result result = My.MyProject.Forms.Result;
							num = 204;
							string empty = string.Empty;
							num = 205;
							string empty2 = string.Empty;
							num = 206;
							string empty3 = string.Empty;
							num = 207;
							string empty4 = string.Empty;
							num = 208;
							if (Declarer.scannedFiles < 2)
							{
								num = 209;
								empty = SelfService.GetWord("file1");
							}
							else
							{
								num = 211;
								empty = SelfService.GetWord("files");
							}
							num = 212;
							if (Declarer.scannedFolders < 2)
							{
								num = 213;
								empty2 = SelfService.GetWord("folder");
							}
							else
							{
								num = 215;
								empty2 = SelfService.GetWord("folders");
							}
							num = 216;
							if (result.tlv.Items.Count < 2)
							{
								num = 217;
								empty3 = SelfService.GetWord("dup_pic");
							}
							else
							{
								num = 219;
								empty3 = SelfService.GetWord("dup_pics");
							}
							num = 220;
							if (Declarer.finalResult.Count < 2)
							{
								num = 221;
								empty4 = SelfService.GetWord("group");
							}
							else
							{
								num = 223;
								empty4 = SelfService.GetWord("groups");
							}
							num = 224;
							result.lSScanned.Text = SelfService.IntelligentSize(Declarer.scannedSize) + ", " + Strings.Format(Declarer.scannedFiles, "#,0") + " " + empty + ", " + Strings.Format(Declarer.scannedFolders, "#,0") + " " + empty2;
							num = 225;
							result.lSFound.Text = SelfService.IntelligentSize(Declarer.dupSize) + ", " + Strings.Format(result.tlv.Items.Count, "#,0") + " " + empty3 + ", " + Strings.Format(Declarer.finalResult.Count, "#,0") + " " + empty4;
							num = 226;
							result.lSFiltered.Text = result.lSFound.Text;
							num = 227;
							long num7 = Math.Abs(DateAndTime.DateDiff(DateInterval.Second, now, DateAndTime.Now));
							num = 228;
							if (num7 < 1)
							{
								num = 229;
								result.lSDone.Text = Conversions.ToString(num7) + SelfService.GetWord("did_time2");
							}
							else
							{
								num = 231;
								if (num7 < 2)
								{
									num = 232;
									result.lSDone.Text = Conversions.ToString(num7) + SelfService.GetWord("did_time");
								}
								else
								{
									num = 234;
									if (num7 < 60)
									{
										num = 235;
										result.lSDone.Text = Conversions.ToString(num7) + SelfService.GetWord("did_time2");
									}
									else
									{
										num = 237;
										if (num7 < 63)
										{
											num = 238;
											result.lSDone.Text = SelfService.GetWord("did_time3");
										}
										else
										{
											num = 240;
											result.lSDone.Text = Strings.Format((double)num7 / 60.0, "#.#") + SelfService.GetWord("did_time4");
										}
									}
								}
							}
							num = 241;
							result.Text = SelfService.GetWord("result_title1");
							num = 242;
							base.Tag = "L";
							num = 243;
							result.ShowDialog(this);
							result = null;
							break;
						}
						KeyValuePair<long, List<string>> kvpFiles = enumerator4.Current;
						num = 105;
						if (Operators.CompareString(lFind.Tag.ToString(), "S", TextCompare: false) == 0)
						{
							break;
						}
						num = 107;
						if (kvpFiles.Value.Count > 1)
						{
							num = 108;
							if (unchecked(num4 % 26) == 0)
							{
								num = 109;
								lPrompt.Text = SelfService.GetWord("comparing") + kvpFiles.Value[0] + " | " + kvpFiles.Value[1] + "...";
							}
							num = 110;
							SelfService.CompareFiles(ref kvpFiles);
							num = 111;
							num4++;
						}
						num = 112;
					}
				}
				goto IL_12c0;
				IL_12c0:
				num = 245;
				lFind.BringToFront();
				num = 246;
				lVirtual.Image = Resources.find128;
				num = 247;
				tt.SetToolTip(lVirtual, SelfService.GetWord("find_tip3"));
				num = 248;
				lFind.Tag = "S";
				num = 249;
				lPrompt.Text = SelfService.GetWord(lPrompt.AccessibleDescription);
				num = 250;
				pDrives.Enabled = true;
				num = 251;
				pTypes.Enabled = true;
			}
			catch (Exception obj) when ((obj is Exception && num2 != 0) & (num8 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_1798: Could not find block for branch target IL_1768*/;
			}
			if (num8 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Resources_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_011c, IL_0182, IL_0184, IL_0194, IL_01b6
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
			Font font = new Font("Segoe UI", 11.9f, FontStyle.Regular, GraphicsUnit.Pixel);
			num = 4;
			rbAll.Font = font;
			num = 5;
			rbExcept.Font = font;
			num = 6;
			rbSpecify.Font = font;
			num = 7;
			rbFF.Font = font;
			num = 8;
			Font font2 = new Font(font, cbSystem.Font.Style | FontStyle.Bold);
			num = 9;
			bool flag = true;
			num = 11;
			if (flag == rbAll.Checked)
			{
				num = 12;
				rbAll.Font = font2;
			}
			else
			{
				num = 14;
				if (flag == rbExcept.Checked)
				{
					num = 15;
					rbExcept.Font = font2;
				}
				else
				{
					num = 17;
					if (flag == rbSpecify.Checked)
					{
						num = 18;
						rbSpecify.Font = font2;
					}
					else
					{
						num = 20;
						if (flag == rbFF.Checked)
						{
							num = 21;
							rbFF.Font = font2;
						}
					}
				}
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_01b4: Could not find block for branch target IL_0184*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void LoadLangText()
	{
		//Discarded unreachable code: IL_07f8, IL_093e, IL_0940, IL_0950, IL_0972
		checked
		{
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
				if (Operators.CompareString(My.MySettingsProperty.Settings.lang, "ar", TextCompare: false) == 0)
				{
					num = 4;
					RightToLeft = RightToLeft.Yes;
				}
				else
				{
					num = 6;
					RightToLeft = RightToLeft.No;
				}
				num = 7;
				IEnumerator enumerator = base.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					num = 8;
					if (control.AccessibleDescription != null)
					{
						num = 9;
						if (control.AccessibleDescription.Length > 0)
						{
							num = 10;
							control.Text = SelfService.GetWord(control.AccessibleDescription);
						}
					}
					num = 11;
					if (control.AccessibleName != null)
					{
						num = 12;
						if (control.AccessibleName.Length > 0)
						{
							num = 13;
							tt.SetToolTip(control, SelfService.GetWord(control.AccessibleName));
						}
					}
					num = 14;
					if (control is Panel)
					{
						num = 15;
						IEnumerator enumerator2 = control.Controls.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							Control control2 = (Control)enumerator2.Current;
							num = 16;
							if (control2.AccessibleDescription != null)
							{
								num = 17;
								if (control2.AccessibleDescription.Length > 0)
								{
									num = 18;
									control2.Text = SelfService.GetWord(control2.AccessibleDescription);
								}
							}
							num = 19;
							if (control2.AccessibleName != null)
							{
								num = 20;
								if (control2.AccessibleName.Length > 0)
								{
									num = 21;
									tt.SetToolTip(control2, SelfService.GetWord(control2.AccessibleName));
								}
							}
							num = 22;
						}
						num = 23;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					num = 24;
				}
				num = 25;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				num = 26;
				IEnumerator enumerator3 = cmsLicense.Items.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)enumerator3.Current;
					num = 27;
					if (toolStripMenuItem.AccessibleDescription != null)
					{
						num = 28;
						if (toolStripMenuItem.AccessibleDescription.Length > 0)
						{
							num = 29;
							toolStripMenuItem.Text = SelfService.GetWord(toolStripMenuItem.AccessibleDescription);
						}
					}
					num = 30;
				}
				num = 31;
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
				num = 32;
				IEnumerator enumerator4 = cmsMore.Items.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					ToolStripMenuItem toolStripMenuItem2 = (ToolStripMenuItem)enumerator4.Current;
					num = 33;
					if (toolStripMenuItem2.AccessibleDescription != null)
					{
						num = 34;
						if (toolStripMenuItem2.AccessibleDescription.Length > 0)
						{
							num = 35;
							toolStripMenuItem2.Text = SelfService.GetWord(toolStripMenuItem2.AccessibleDescription);
						}
					}
					num = 36;
				}
				num = 37;
				if (enumerator4 is IDisposable)
				{
					(enumerator4 as IDisposable).Dispose();
				}
				num = 38;
				cbCD.Left = cbSystem.Left + cbSystem.Width + 9;
				num = 39;
				cbNetwork.Left = cbCD.Left + cbCD.Width + 9;
				num = 40;
				llSelDrives.Left = tbDrives.Left + tbDrives.Width - llSelDrives.Width;
				num = 41;
				llSelFF.Left = llSelDrives.Left;
				num = 42;
				llTypesManager.Left = cbAll.Left + cbAll.Width + 9;
				num = 43;
				ContextMenuStrip cmsLangs = this.cmsLangs;
				num = 44;
				cmsLangs.Items.Clear();
				num = 45;
				cmsLangs.Items.Add("Deutsch");
				num = 46;
				cmsLangs.Items.Add("English");
				num = 47;
				cmsLangs.Items.Add("Español");
				num = 48;
				cmsLangs.Items.Add("Français");
				num = 49;
				cmsLangs.Items.Add("Polski");
				num = 50;
				cmsLangs.Items.Add("Português (Brasil)");
				num = 51;
				cmsLangs.Items.Add("Slovenščina");
				num = 52;
				cmsLangs.Items.Add("Türkçe");
				num = 53;
				cmsLangs.Items.Add("Русский");
				num = 54;
				cmsLangs.Items.Add("العربية");
				num = 55;
				cmsLangs.Items.Add("简体中文");
				num = 56;
				cmsLangs.Items.Add("繁體中文");
				num = 57;
				cmsLangs.Items.Add("-");
				num = 58;
				cmsLangs.Items.Add(SelfService.GetWord("free_key"));
				cmsLangs = null;
				num = 60;
				IEnumerator enumerator5 = this.cmsLangs.Items.GetEnumerator();
				bool flag = default(bool);
				while (enumerator5.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator5.Current);
					num = 61;
					if (objectValue is ToolStripMenuItem)
					{
						num = 62;
						ToolStripMenuItem toolStripMenuItem3 = (ToolStripMenuItem)objectValue;
						num = 63;
						if ((Operators.CompareString(My.MySettingsProperty.Settings.lang, "en", TextCompare: false) == 0 && Operators.CompareString(toolStripMenuItem3.Text, "English", TextCompare: false) == 0) || (Operators.CompareString(My.MySettingsProperty.Settings.lang, "sc", TextCompare: false) == 0 && Operators.CompareString(toolStripMenuItem3.Text, "简体中文", TextCompare: false) == 0) || (Operators.CompareString(My.MySettingsProperty.Settings.lang, "sl", TextCompare: false) == 0 && Operators.CompareString(toolStripMenuItem3.Text, "Slovenščina", TextCompare: false) == 0) || (Operators.CompareString(My.MySettingsProperty.Settings.lang, "es", TextCompare: false) == 0 && Operators.CompareString(toolStripMenuItem3.Text, "Español", TextCompare: false) == 0) || (Operators.CompareString(My.MySettingsProperty.Settings.lang, "pl", TextCompare: false) == 0 && Operators.CompareString(toolStripMenuItem3.Text, "Polski", TextCompare: false) == 0) || (Operators.CompareString(My.MySettingsProperty.Settings.lang, "fr", TextCompare: false) == 0 && Operators.CompareString(toolStripMenuItem3.Text, "Français", TextCompare: false) == 0) || (Operators.CompareString(My.MySettingsProperty.Settings.lang, "tr", TextCompare: false) == 0 && Operators.CompareString(toolStripMenuItem3.Text, "Türkçe", TextCompare: false) == 0) || (Operators.CompareString(My.MySettingsProperty.Settings.lang, "ru", TextCompare: false) == 0 && Operators.CompareString(toolStripMenuItem3.Text, "Русский", TextCompare: false) == 0) || (Operators.CompareString(My.MySettingsProperty.Settings.lang, "de", TextCompare: false) == 0 && Operators.CompareString(toolStripMenuItem3.Text, "Deutsch", TextCompare: false) == 0) || (Operators.CompareString(My.MySettingsProperty.Settings.lang, "ar", TextCompare: false) == 0 && Operators.CompareString(toolStripMenuItem3.Text, "العربية", TextCompare: false) == 0) || (Operators.CompareString(My.MySettingsProperty.Settings.lang, "pt_br", TextCompare: false) == 0 && Operators.CompareString(toolStripMenuItem3.Text, "Português (Brasil)", TextCompare: false) == 0) || (Operators.CompareString(My.MySettingsProperty.Settings.lang, "tc", TextCompare: false) == 0 && Operators.CompareString(toolStripMenuItem3.Text, "繁體中文", TextCompare: false) == 0))
						{
							num = 64;
							toolStripMenuItem3.Checked = true;
							num = 65;
							flag = true;
							break;
						}
					}
					num = 67;
				}
				num = 68;
				if (enumerator5 is IDisposable)
				{
					(enumerator5 as IDisposable).Dispose();
				}
				num = 69;
				if (!flag)
				{
					num = 70;
					IEnumerator enumerator6 = this.cmsLangs.Items.GetEnumerator();
					while (enumerator6.MoveNext())
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator6.Current);
						num = 71;
						if (objectValue2 is ToolStripMenuItem)
						{
							num = 72;
							ToolStripMenuItem toolStripMenuItem3 = (ToolStripMenuItem)objectValue2;
							num = 73;
							if (Operators.CompareString(toolStripMenuItem3.Text, "English", TextCompare: false) == 0)
							{
								num = 74;
								toolStripMenuItem3.Checked = true;
								break;
							}
						}
						num = 76;
					}
					num = 77;
					if (enumerator6 is IDisposable)
					{
						(enumerator6 as IDisposable).Dispose();
					}
				}
			}
			catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_0970: Could not find block for branch target IL_0940*/;
			}
			if (num3 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void cmsLangs_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
		//Discarded unreachable code: IL_02c0, IL_0396, IL_0398, IL_03a8, IL_03ca
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
			string lang = My.MySettingsProperty.Settings.lang;
			num = 4;
			cmsLangs.Visible = false;
			num = 5;
			string text = e.ClickedItem.Text;
			num = 7;
			if (Operators.CompareString(text, "English", TextCompare: false) == 0)
			{
				num = 8;
				My.MySettingsProperty.Settings.lang = "en";
			}
			else
			{
				num = 10;
				if (Operators.CompareString(text, "简体中文", TextCompare: false) == 0)
				{
					num = 11;
					My.MySettingsProperty.Settings.lang = "sc";
				}
				else
				{
					num = 13;
					if (Operators.CompareString(text, "Español", TextCompare: false) == 0)
					{
						num = 14;
						My.MySettingsProperty.Settings.lang = "es";
					}
					else
					{
						num = 16;
						if (Operators.CompareString(text, "Русский", TextCompare: false) == 0)
						{
							num = 17;
							My.MySettingsProperty.Settings.lang = "ru";
						}
						else
						{
							num = 19;
							if (Operators.CompareString(text, "Polski", TextCompare: false) == 0)
							{
								num = 20;
								My.MySettingsProperty.Settings.lang = "pl";
							}
							else
							{
								num = 22;
								if (Operators.CompareString(text, "Français", TextCompare: false) == 0)
								{
									num = 23;
									My.MySettingsProperty.Settings.lang = "fr";
								}
								else
								{
									num = 25;
									if (Operators.CompareString(text, "Deutsch", TextCompare: false) == 0)
									{
										num = 26;
										My.MySettingsProperty.Settings.lang = "de";
									}
									else
									{
										num = 28;
										if (Operators.CompareString(text, "Português (Brasil)", TextCompare: false) == 0)
										{
											num = 29;
											My.MySettingsProperty.Settings.lang = "pt_br";
										}
										else
										{
											num = 31;
											if (Operators.CompareString(text, "Slovenščina", TextCompare: false) == 0)
											{
												num = 32;
												My.MySettingsProperty.Settings.lang = "sl";
											}
											else
											{
												num = 34;
												if (Operators.CompareString(text, "Türkçe", TextCompare: false) == 0)
												{
													num = 35;
													My.MySettingsProperty.Settings.lang = "tr";
												}
												else
												{
													num = 37;
													if (Operators.CompareString(text, "العربية", TextCompare: false) == 0)
													{
														num = 38;
														My.MySettingsProperty.Settings.lang = "ar";
													}
													else
													{
														num = 40;
														if (Operators.CompareString(text, "繁體中文", TextCompare: false) == 0)
														{
															num = 41;
															My.MySettingsProperty.Settings.lang = "tc";
														}
														else
														{
															num = 43;
															if (Operators.CompareString(text, SelfService.GetWord("free_key"), TextCompare: false) == 0)
															{
																num = 44;
																Interaction.Shell("explorer \"http://www.trisunsoft.com/translate.htm\"", AppWinStyle.NormalFocus);
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			num = 45;
			My.MySettingsProperty.Settings.Save();
			num = 46;
			if (Operators.CompareString(lang, My.MySettingsProperty.Settings.lang, TextCompare: false) != 0)
			{
				num = 47;
				Declarer.xd.Load(Declarer.startPath + "\\langs\\" + My.MySettingsProperty.Settings.lang + ".xml");
				num = 48;
				Declarer.xeL = Declarer.xd["LANG_TEXT"];
				num = 49;
				SelfService.ReloadInterfacesWithLang();
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_03c8: Could not find block for branch target IL_0398*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}

internal class _003CPrivateImplementationDetails_003E
{
	internal static uint ComputeStringHash(string s)
	{
		uint num = 0;

		if (s != null)
		{
			num = 0x811c9dc5;
			for (int i = 0; i < s.Length; i++)
			{
				num = unchecked((s[i] ^ num) * 0x1000193);
			}
		}

		return num;
	}
}