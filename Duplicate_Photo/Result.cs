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
using System.Text;
using System.Windows.Forms;
using TSSFL.UIControl;
using TSSFL.Utility;

[DesignerGenerated]
public class Result : Form
{
    private IContainer components;
    public ContextMenuStrip cms;
    public ToolStripMenuItem tsmiDel;
    public ToolStripMenuItem tsmiRecycle;
    public ToolStripMenuItem tsmiLocation;
    public ToolStripMenuItem tsmiRun;
    public ToolStripMenuItem tsmiUncheck;
    public ToolStripMenuItem tsmiPro;
    public ToolTip tt;
    public Label lTips;
    public Label lTipsTitle;
    public Label lFilter;
    public Panel pFilter;
    public CheckBox cbSA;
    public CheckBox cbSH;
    public CheckBox cbSM;
    public CheckBox cbSL;
    public CheckBox cbST;
    public CheckBox cbSS;
    public Label lProgress;
    public Label lStatistics;
    public Panel pStatistics;
    public Label lScanned;
    public Label lSScanned;
    public Label lSFound;
    public Label lFound;
    public Label lDone;
    public Label lSDone;
    public Label lSFiltered;
    public Label lFiltered;
    public Label Label4;
    public Label lLocation;
    public Label lPro;
    public Label lUncheck;
    public Label lRecycle;
    public Label lDel;
    public Label lRun;
    public Label lSave;
    public Label lLoad;
    public ToolStripMenuItem tsmiSave;
    public ToolStripMenuItem tsmiLoad;
    public Timer t;
    public Label lInvert;
    public ToolStripMenuItem tsmiInvert;
    public Label lPreviews;
    public Panel pPreviews;
    public Label lSChecked;
    public Label lChecked;
    public SplitContainer sc;
    public TListView tlv;
    public ColumnHeader chName;
    public ColumnHeader chPath;
    public ColumnHeader chSize;
    public ColumnHeader chType;
    public ColumnHeader chCreated;
    public Label lFind;
    public ColumnHeader chModified;
    public ToolStripMenuItem tsmiFind;
    public Label lMove;
    public Label lPath;
    public ToolStripMenuItem tsmiMove;
    public ToolStripMenuItem tsmiPath;

    private bool _all;

    private bool _saved;

    private bool _batchCheck;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecycle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUncheck = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPath = new System.Windows.Forms.ToolStripMenuItem();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.lFind = new System.Windows.Forms.Label();
            this.lInvert = new System.Windows.Forms.Label();
            this.lLoad = new System.Windows.Forms.Label();
            this.lSave = new System.Windows.Forms.Label();
            this.lLocation = new System.Windows.Forms.Label();
            this.lPro = new System.Windows.Forms.Label();
            this.lUncheck = new System.Windows.Forms.Label();
            this.lRecycle = new System.Windows.Forms.Label();
            this.lDel = new System.Windows.Forms.Label();
            this.lRun = new System.Windows.Forms.Label();
            this.lTips = new System.Windows.Forms.Label();
            this.lTipsTitle = new System.Windows.Forms.Label();
            this.lFilter = new System.Windows.Forms.Label();
            this.pFilter = new System.Windows.Forms.Panel();
            this.cbST = new System.Windows.Forms.CheckBox();
            this.cbSS = new System.Windows.Forms.CheckBox();
            this.cbSM = new System.Windows.Forms.CheckBox();
            this.cbSL = new System.Windows.Forms.CheckBox();
            this.cbSH = new System.Windows.Forms.CheckBox();
            this.cbSA = new System.Windows.Forms.CheckBox();
            this.lProgress = new System.Windows.Forms.Label();
            this.lStatistics = new System.Windows.Forms.Label();
            this.pStatistics = new System.Windows.Forms.Panel();
            this.lSChecked = new System.Windows.Forms.Label();
            this.lChecked = new System.Windows.Forms.Label();
            this.lSFiltered = new System.Windows.Forms.Label();
            this.lFiltered = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lSDone = new System.Windows.Forms.Label();
            this.lDone = new System.Windows.Forms.Label();
            this.lSFound = new System.Windows.Forms.Label();
            this.lFound = new System.Windows.Forms.Label();
            this.lSScanned = new System.Windows.Forms.Label();
            this.lScanned = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.lPreviews = new System.Windows.Forms.Label();
            this.pPreviews = new System.Windows.Forms.Panel();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.tlv = new TSSFL.UIControl.TListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lPath = new System.Windows.Forms.Label();
            this.lMove = new System.Windows.Forms.Label();
            this.cms.SuspendLayout();
            this.pFilter.SuspendLayout();
            this.pStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.SuspendLayout();
            // 
            // cms
            // 
            this.cms.Font = new System.Drawing.Font("Segoe UI", 11.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiLoad,
            this.tsmiRecycle,
            this.tsmiDel,
            this.tsmiMove,
            this.tsmiFind,
            this.tsmiRun,
            this.tsmiLocation,
            this.tsmiUncheck,
            this.tsmiInvert,
            this.tsmiPro,
            this.tsmiPath});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(258, 460);
            this.cms.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cms_ItemClicked);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSave.Image")));
            this.tsmiSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(257, 38);
            this.tsmiSave.Text = "Save Result to File...";
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLoad.Image")));
            this.tsmiLoad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.Size = new System.Drawing.Size(257, 38);
            this.tsmiLoad.Text = "Load Result from File...";
            // 
            // tsmiRecycle
            // 
            this.tsmiRecycle.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRecycle.Image")));
            this.tsmiRecycle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiRecycle.Name = "tsmiRecycle";
            this.tsmiRecycle.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmiRecycle.Size = new System.Drawing.Size(257, 38);
            this.tsmiRecycle.Text = "Move to Recycle Bin";
            // 
            // tsmiDel
            // 
            this.tsmiDel.ForeColor = System.Drawing.Color.Black;
            this.tsmiDel.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDel.Image")));
            this.tsmiDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiDel.Name = "tsmiDel";
            this.tsmiDel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.tsmiDel.Size = new System.Drawing.Size(257, 38);
            this.tsmiDel.Text = "Delete";
            // 
            // tsmiMove
            // 
            this.tsmiMove.ForeColor = System.Drawing.Color.Black;
            this.tsmiMove.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMove.Image")));
            this.tsmiMove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiMove.Name = "tsmiMove";
            this.tsmiMove.Size = new System.Drawing.Size(257, 38);
            this.tsmiMove.Text = "Move to folder…";
            // 
            // tsmiFind
            // 
            this.tsmiFind.ForeColor = System.Drawing.Color.Black;
            this.tsmiFind.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFind.Image")));
            this.tsmiFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiFind.Name = "tsmiFind";
            this.tsmiFind.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tsmiFind.Size = new System.Drawing.Size(257, 38);
            this.tsmiFind.Text = "Find...";
            // 
            // tsmiRun
            // 
            this.tsmiRun.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRun.Image")));
            this.tsmiRun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiRun.Name = "tsmiRun";
            this.tsmiRun.ShortcutKeyDisplayString = "Enter / Double-click";
            this.tsmiRun.Size = new System.Drawing.Size(257, 38);
            this.tsmiRun.Text = "Run/Open";
            // 
            // tsmiLocation
            // 
            this.tsmiLocation.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLocation.Image")));
            this.tsmiLocation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiLocation.Name = "tsmiLocation";
            this.tsmiLocation.Size = new System.Drawing.Size(257, 38);
            this.tsmiLocation.Text = "Open File Location";
            // 
            // tsmiUncheck
            // 
            this.tsmiUncheck.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUncheck.Image")));
            this.tsmiUncheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiUncheck.Name = "tsmiUncheck";
            this.tsmiUncheck.Size = new System.Drawing.Size(257, 38);
            this.tsmiUncheck.Text = "Uncheck All";
            // 
            // tsmiInvert
            // 
            this.tsmiInvert.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInvert.Image")));
            this.tsmiInvert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiInvert.Name = "tsmiInvert";
            this.tsmiInvert.Size = new System.Drawing.Size(257, 38);
            this.tsmiInvert.Text = "Invert Checks";
            // 
            // tsmiPro
            // 
            this.tsmiPro.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPro.Image")));
            this.tsmiPro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPro.Name = "tsmiPro";
            this.tsmiPro.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Return)));
            this.tsmiPro.Size = new System.Drawing.Size(257, 38);
            this.tsmiPro.Text = "Properties...";
            // 
            // tsmiPath
            // 
            this.tsmiPath.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPath.Image")));
            this.tsmiPath.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiPath.Name = "tsmiPath";
            this.tsmiPath.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.tsmiPath.Size = new System.Drawing.Size(257, 38);
            this.tsmiPath.Text = "Copy full path";
            // 
            // tt
            // 
            this.tt.IsBalloon = true;
            // 
            // lFind
            // 
            this.lFind.AccessibleDescription = "";
            this.lFind.AccessibleName = "find_tip1";
            this.lFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lFind.ForeColor = System.Drawing.Color.White;
            this.lFind.Image = ((System.Drawing.Image)(resources.GetObject("lFind.Image")));
            this.lFind.Location = new System.Drawing.Point(244, 9);
            this.lFind.Name = "lFind";
            this.lFind.Size = new System.Drawing.Size(45, 45);
            this.lFind.TabIndex = 172;
            this.lFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lFind, "Finds item according the [Name] or [Path] <F3>.");
            // 
            // lInvert
            // 
            this.lInvert.AccessibleDescription = "invert2";
            this.lInvert.AccessibleName = "insert_tip";
            this.lInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lInvert.ForeColor = System.Drawing.Color.White;
            this.lInvert.Image = ((System.Drawing.Image)(resources.GetObject("lInvert.Image")));
            this.lInvert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lInvert.Location = new System.Drawing.Point(675, 9);
            this.lInvert.Name = "lInvert";
            this.lInvert.Size = new System.Drawing.Size(87, 45);
            this.lInvert.TabIndex = 168;
            this.lInvert.Text = "Invert";
            this.lInvert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lInvert, "Inverts checks <Ctrl+I>.");
            // 
            // lLoad
            // 
            this.lLoad.AccessibleName = "load_result";
            this.lLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lLoad.ForeColor = System.Drawing.Color.White;
            this.lLoad.Image = ((System.Drawing.Image)(resources.GetObject("lLoad.Image")));
            this.lLoad.Location = new System.Drawing.Point(56, 9);
            this.lLoad.Name = "lLoad";
            this.lLoad.Size = new System.Drawing.Size(45, 45);
            this.lLoad.TabIndex = 167;
            this.tt.SetToolTip(this.lLoad, "Loads the result from a DPFP file <Ctrl+R>.");
            // 
            // lSave
            // 
            this.lSave.AccessibleName = "save_result";
            this.lSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lSave.ForeColor = System.Drawing.Color.White;
            this.lSave.Image = ((System.Drawing.Image)(resources.GetObject("lSave.Image")));
            this.lSave.Location = new System.Drawing.Point(9, 9);
            this.lSave.Name = "lSave";
            this.lSave.Size = new System.Drawing.Size(45, 45);
            this.lSave.TabIndex = 166;
            this.tt.SetToolTip(this.lSave, "Saves current result to a DPFP file <Ctrl+S>.");
            // 
            // lLocation
            // 
            this.lLocation.AccessibleDescription = "open_location";
            this.lLocation.AccessibleName = "open_tip2";
            this.lLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lLocation.ForeColor = System.Drawing.Color.White;
            this.lLocation.Image = ((System.Drawing.Image)(resources.GetObject("lLocation.Image")));
            this.lLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lLocation.Location = new System.Drawing.Point(418, 9);
            this.lLocation.Name = "lLocation";
            this.lLocation.Size = new System.Drawing.Size(140, 45);
            this.lLocation.TabIndex = 3;
            this.lLocation.Text = "Open Location";
            this.lLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lLocation, "Opens the location of the highlighted file <Ctrl+L>.");
            // 
            // lPro
            // 
            this.lPro.AccessibleDescription = "pro";
            this.lPro.AccessibleName = "pro_tip1";
            this.lPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lPro.ForeColor = System.Drawing.Color.White;
            this.lPro.Image = ((System.Drawing.Image)(resources.GetObject("lPro.Image")));
            this.lPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lPro.Location = new System.Drawing.Point(764, 9);
            this.lPro.Name = "lPro";
            this.lPro.Size = new System.Drawing.Size(109, 45);
            this.lPro.TabIndex = 5;
            this.lPro.Text = "Properties";
            this.lPro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lPro, "Displays the properties of the highlighted file <F4>.");
            // 
            // lUncheck
            // 
            this.lUncheck.AccessibleDescription = "uncheck_all";
            this.lUncheck.AccessibleName = "uncheck_tip1";
            this.lUncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lUncheck.ForeColor = System.Drawing.Color.White;
            this.lUncheck.Image = ((System.Drawing.Image)(resources.GetObject("lUncheck.Image")));
            this.lUncheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lUncheck.Location = new System.Drawing.Point(560, 9);
            this.lUncheck.Name = "lUncheck";
            this.lUncheck.Size = new System.Drawing.Size(113, 45);
            this.lUncheck.TabIndex = 4;
            this.lUncheck.Text = "Uncheck All";
            this.lUncheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lUncheck, "Unchecks all duplicate pictures <Ctrl+U>.");
            // 
            // lRecycle
            // 
            this.lRecycle.AccessibleDescription = "";
            this.lRecycle.AccessibleName = "move_rb1";
            this.lRecycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lRecycle.ForeColor = System.Drawing.Color.White;
            this.lRecycle.Image = ((System.Drawing.Image)(resources.GetObject("lRecycle.Image")));
            this.lRecycle.Location = new System.Drawing.Point(103, 9);
            this.lRecycle.Name = "lRecycle";
            this.lRecycle.Size = new System.Drawing.Size(45, 45);
            this.lRecycle.TabIndex = 0;
            this.lRecycle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lRecycle, "Moves the checked duplicate picture(s) to the Recycle Bin <Del>.");
            // 
            // lDel
            // 
            this.lDel.AccessibleDescription = "";
            this.lDel.AccessibleName = "del_dup1";
            this.lDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lDel.ForeColor = System.Drawing.Color.White;
            this.lDel.Image = ((System.Drawing.Image)(resources.GetObject("lDel.Image")));
            this.lDel.Location = new System.Drawing.Point(150, 9);
            this.lDel.Name = "lDel";
            this.lDel.Size = new System.Drawing.Size(45, 45);
            this.lDel.TabIndex = 1;
            this.lDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lDel, "Permanently deletes the checked duplicate picture(s) <Shift+Del>.");
            // 
            // lRun
            // 
            this.lRun.AccessibleDescription = "open";
            this.lRun.AccessibleName = "run_tip2";
            this.lRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lRun.ForeColor = System.Drawing.Color.White;
            this.lRun.Image = ((System.Drawing.Image)(resources.GetObject("lRun.Image")));
            this.lRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lRun.Location = new System.Drawing.Point(307, 9);
            this.lRun.Name = "lRun";
            this.lRun.Size = new System.Drawing.Size(109, 45);
            this.lRun.TabIndex = 2;
            this.lRun.Text = "Open/Run";
            this.lRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.lRun, "Runs/opens the highlighted file <Enter / Double-click>.");
            // 
            // lTips
            // 
            this.lTips.AccessibleDescription = "result_tip1";
            this.lTips.BackColor = System.Drawing.Color.White;
            this.lTips.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lTips.Location = new System.Drawing.Point(656, 527);
            this.lTips.Name = "lTips";
            this.lTips.Size = new System.Drawing.Size(343, 139);
            this.lTips.TabIndex = 155;
            this.lTips.Text = resources.GetString("lTips.Text");
            // 
            // lTipsTitle
            // 
            this.lTipsTitle.AccessibleDescription = "tips";
            this.lTipsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lTipsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lTipsTitle.Location = new System.Drawing.Point(612, 527);
            this.lTipsTitle.Name = "lTipsTitle";
            this.lTipsTitle.Size = new System.Drawing.Size(44, 139);
            this.lTipsTitle.TabIndex = 156;
            this.lTipsTitle.Text = "Tips";
            this.lTipsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lFilter
            // 
            this.lFilter.AccessibleDescription = "fil";
            this.lFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lFilter.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lFilter.Location = new System.Drawing.Point(9, 486);
            this.lFilter.Name = "lFilter";
            this.lFilter.Size = new System.Drawing.Size(91, 28);
            this.lFilter.TabIndex = 7;
            this.lFilter.Text = "Filter";
            this.lFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pFilter
            // 
            this.pFilter.BackColor = System.Drawing.Color.White;
            this.pFilter.Controls.Add(this.cbST);
            this.pFilter.Controls.Add(this.cbSS);
            this.pFilter.Controls.Add(this.cbSM);
            this.pFilter.Controls.Add(this.cbSL);
            this.pFilter.Controls.Add(this.cbSH);
            this.pFilter.Controls.Add(this.cbSA);
            this.pFilter.Location = new System.Drawing.Point(100, 486);
            this.pFilter.Name = "pFilter";
            this.pFilter.Size = new System.Drawing.Size(899, 28);
            this.pFilter.TabIndex = 8;
            // 
            // cbST
            // 
            this.cbST.AccessibleDescription = "tiny1";
            this.cbST.AutoSize = true;
            this.cbST.Checked = true;
            this.cbST.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbST.Location = new System.Drawing.Point(695, 4);
            this.cbST.Name = "cbST";
            this.cbST.Size = new System.Drawing.Size(93, 19);
            this.cbST.TabIndex = 15;
            this.cbST.Text = "&Tiny (10 KB-)";
            this.cbST.UseVisualStyleBackColor = true;
            // 
            // cbSS
            // 
            this.cbSS.AccessibleDescription = "small1";
            this.cbSS.AutoSize = true;
            this.cbSS.Checked = true;
            this.cbSS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSS.Location = new System.Drawing.Point(560, 4);
            this.cbSS.Name = "cbSS";
            this.cbSS.Size = new System.Drawing.Size(126, 19);
            this.cbSS.TabIndex = 14;
            this.cbSS.Text = "&Small (10~100 KB-)";
            this.cbSS.UseVisualStyleBackColor = true;
            // 
            // cbSM
            // 
            this.cbSM.AccessibleDescription = "medium1";
            this.cbSM.AutoSize = true;
            this.cbSM.Checked = true;
            this.cbSM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSM.Location = new System.Drawing.Point(394, 4);
            this.cbSM.Name = "cbSM";
            this.cbSM.Size = new System.Drawing.Size(157, 19);
            this.cbSM.TabIndex = 13;
            this.cbSM.Text = "&Medium (100 KB~1 MB-)";
            this.cbSM.UseVisualStyleBackColor = true;
            // 
            // cbSL
            // 
            this.cbSL.AccessibleDescription = "large1";
            this.cbSL.AutoSize = true;
            this.cbSL.Checked = true;
            this.cbSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSL.Location = new System.Drawing.Point(267, 4);
            this.cbSL.Name = "cbSL";
            this.cbSL.Size = new System.Drawing.Size(118, 19);
            this.cbSL.TabIndex = 12;
            this.cbSL.Text = "&Large (1~16 MB-)";
            this.cbSL.UseVisualStyleBackColor = true;
            // 
            // cbSH
            // 
            this.cbSH.AccessibleDescription = "huge2";
            this.cbSH.AutoSize = true;
            this.cbSH.Checked = true;
            this.cbSH.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSH.Location = new System.Drawing.Point(151, 4);
            this.cbSH.Name = "cbSH";
            this.cbSH.Size = new System.Drawing.Size(107, 19);
            this.cbSH.TabIndex = 11;
            this.cbSH.Text = "&Huge (16 MB+)";
            this.cbSH.UseVisualStyleBackColor = true;
            // 
            // cbSA
            // 
            this.cbSA.AccessibleDescription = "check";
            this.cbSA.AutoSize = true;
            this.cbSA.Checked = true;
            this.cbSA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSA.Location = new System.Drawing.Point(9, 4);
            this.cbSA.Name = "cbSA";
            this.cbSA.Size = new System.Drawing.Size(133, 19);
            this.cbSA.TabIndex = 9;
            this.cbSA.Text = "Check / Uncheck &All";
            this.cbSA.UseVisualStyleBackColor = true;
            // 
            // lProgress
            // 
            this.lProgress.AutoSize = true;
            this.lProgress.BackColor = System.Drawing.Color.Maroon;
            this.lProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lProgress.Font = new System.Drawing.Font("Segoe UI", 26.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lProgress.ForeColor = System.Drawing.Color.Lime;
            this.lProgress.Location = new System.Drawing.Point(356, 900);
            this.lProgress.Name = "lProgress";
            this.lProgress.Size = new System.Drawing.Size(266, 39);
            this.lProgress.TabIndex = 159;
            this.lProgress.Text = "Testing, please wait...";
            this.lProgress.Visible = false;
            // 
            // lStatistics
            // 
            this.lStatistics.AccessibleDescription = "statistics";
            this.lStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lStatistics.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lStatistics.Location = new System.Drawing.Point(9, 527);
            this.lStatistics.Name = "lStatistics";
            this.lStatistics.Size = new System.Drawing.Size(91, 139);
            this.lStatistics.TabIndex = 16;
            this.lStatistics.Text = "Statistics";
            this.lStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pStatistics
            // 
            this.pStatistics.BackColor = System.Drawing.Color.White;
            this.pStatistics.Controls.Add(this.lSChecked);
            this.pStatistics.Controls.Add(this.lChecked);
            this.pStatistics.Controls.Add(this.lSFiltered);
            this.pStatistics.Controls.Add(this.lFiltered);
            this.pStatistics.Controls.Add(this.Label4);
            this.pStatistics.Controls.Add(this.lSDone);
            this.pStatistics.Controls.Add(this.lDone);
            this.pStatistics.Controls.Add(this.lSFound);
            this.pStatistics.Controls.Add(this.lFound);
            this.pStatistics.Controls.Add(this.lSScanned);
            this.pStatistics.Controls.Add(this.lScanned);
            this.pStatistics.Location = new System.Drawing.Point(100, 527);
            this.pStatistics.Name = "pStatistics";
            this.pStatistics.Size = new System.Drawing.Size(503, 139);
            this.pStatistics.TabIndex = 17;
            // 
            // lSChecked
            // 
            this.lSChecked.AutoSize = true;
            this.lSChecked.Location = new System.Drawing.Point(73, 115);
            this.lSChecked.Name = "lSChecked";
            this.lSChecked.Size = new System.Drawing.Size(106, 15);
            this.lSChecked.TabIndex = 18;
            this.lSChecked.Text = "0 Byte for 0 Picture";
            // 
            // lChecked
            // 
            this.lChecked.AccessibleDescription = "checked";
            this.lChecked.AutoSize = true;
            this.lChecked.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lChecked.Location = new System.Drawing.Point(9, 115);
            this.lChecked.Name = "lChecked";
            this.lChecked.Size = new System.Drawing.Size(55, 15);
            this.lChecked.TabIndex = 17;
            this.lChecked.Text = "Checked";
            // 
            // lSFiltered
            // 
            this.lSFiltered.AutoSize = true;
            this.lSFiltered.Location = new System.Drawing.Point(73, 91);
            this.lSFiltered.Name = "lSFiltered";
            this.lSFiltered.Size = new System.Drawing.Size(57, 15);
            this.lSFiltered.TabIndex = 14;
            this.lSFiltered.Text = "Waiting...";
            // 
            // lFiltered
            // 
            this.lFiltered.AccessibleDescription = "filtered";
            this.lFiltered.AutoSize = true;
            this.lFiltered.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lFiltered.Location = new System.Drawing.Point(14, 91);
            this.lFiltered.Name = "lFiltered";
            this.lFiltered.Size = new System.Drawing.Size(50, 15);
            this.lFiltered.TabIndex = 13;
            this.lFiltered.Text = "Filtered";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Gray;
            this.Label4.Location = new System.Drawing.Point(-64, 81);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(2000, 1);
            this.Label4.TabIndex = 12;
            // 
            // lSDone
            // 
            this.lSDone.AutoSize = true;
            this.lSDone.Location = new System.Drawing.Point(73, 57);
            this.lSDone.Name = "lSDone";
            this.lSDone.Size = new System.Drawing.Size(57, 15);
            this.lSDone.TabIndex = 5;
            this.lSDone.Text = "Waiting...";
            // 
            // lDone
            // 
            this.lDone.AccessibleDescription = "spent";
            this.lDone.AutoSize = true;
            this.lDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lDone.Location = new System.Drawing.Point(24, 57);
            this.lDone.Name = "lDone";
            this.lDone.Size = new System.Drawing.Size(40, 15);
            this.lDone.TabIndex = 4;
            this.lDone.Text = "Spent";
            // 
            // lSFound
            // 
            this.lSFound.AutoSize = true;
            this.lSFound.Location = new System.Drawing.Point(73, 33);
            this.lSFound.Name = "lSFound";
            this.lSFound.Size = new System.Drawing.Size(57, 15);
            this.lSFound.TabIndex = 3;
            this.lSFound.Text = "Waiting...";
            // 
            // lFound
            // 
            this.lFound.AccessibleDescription = "found1";
            this.lFound.AutoSize = true;
            this.lFound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lFound.Location = new System.Drawing.Point(23, 33);
            this.lFound.Name = "lFound";
            this.lFound.Size = new System.Drawing.Size(41, 15);
            this.lFound.TabIndex = 2;
            this.lFound.Text = "Found";
            // 
            // lSScanned
            // 
            this.lSScanned.AutoSize = true;
            this.lSScanned.Location = new System.Drawing.Point(73, 9);
            this.lSScanned.Name = "lSScanned";
            this.lSScanned.Size = new System.Drawing.Size(57, 15);
            this.lSScanned.TabIndex = 1;
            this.lSScanned.Text = "Waiting...";
            // 
            // lScanned
            // 
            this.lScanned.AccessibleDescription = "scanned";
            this.lScanned.AutoSize = true;
            this.lScanned.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lScanned.Location = new System.Drawing.Point(10, 9);
            this.lScanned.Name = "lScanned";
            this.lScanned.Size = new System.Drawing.Size(54, 15);
            this.lScanned.TabIndex = 0;
            this.lScanned.Text = "Scanned";
            // 
            // t
            // 
            this.t.Enabled = true;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // lPreviews
            // 
            this.lPreviews.AccessibleDescription = "previews";
            this.lPreviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lPreviews.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lPreviews.Location = new System.Drawing.Point(0, 0);
            this.lPreviews.Name = "lPreviews";
            this.lPreviews.Size = new System.Drawing.Size(91, 160);
            this.lPreviews.TabIndex = 169;
            this.lPreviews.Text = "Previews";
            this.lPreviews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPreviews
            // 
            this.pPreviews.BackColor = System.Drawing.Color.White;
            this.pPreviews.Location = new System.Drawing.Point(91, 0);
            this.pPreviews.Name = "pPreviews";
            this.pPreviews.Size = new System.Drawing.Size(1075, 160);
            this.pPreviews.TabIndex = 170;
            // 
            // sc
            // 
            this.sc.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.sc.Location = new System.Drawing.Point(9, 63);
            this.sc.Name = "sc";
            this.sc.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.tlv);
            this.sc.Panel1MinSize = 100;
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.pPreviews);
            this.sc.Panel2.Controls.Add(this.lPreviews);
            this.sc.Panel2MinSize = 50;
            this.sc.Size = new System.Drawing.Size(1166, 414);
            this.sc.SplitterDistance = 280;
            this.sc.SplitterWidth = 1;
            this.sc.TabIndex = 171;
            this.sc.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sc_SplitterMoved);
            // 
            // tlv
            // 
            this.tlv.BackColor = System.Drawing.Color.White;
            this.tlv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlv.CheckBoxes = true;
            this.tlv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPath,
            this.chSize,
            this.chType,
            this.chCreated,
            this.chModified});
            this.tlv.ContextMenuStrip = this.cms;
            this.tlv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tlv.FullRowSelect = true;
            this.tlv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.tlv.HideSelection = false;
            this.tlv.Location = new System.Drawing.Point(0, 0);
            this.tlv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlv.MultiSelect = false;
            this.tlv.Name = "tlv";
            this.tlv.ShowItemToolTips = true;
            this.tlv.Size = new System.Drawing.Size(1166, 280);
            this.tlv.TabIndex = 7;
            this.tlv.UseCompatibleStateImageBehavior = false;
            this.tlv.View = System.Windows.Forms.View.Details;
            this.tlv.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.tlv_ItemChecked);
            this.tlv.SelectedIndexChanged += new System.EventHandler(this.tlv_SelectedIndexChanged);
            this.tlv.DoubleClick += new System.EventHandler(this.tlv_DoubleClick);
            // 
            // chName
            // 
            this.chName.Tag = "name";
            this.chName.Text = "Name";
            this.chName.Width = 137;
            // 
            // chPath
            // 
            this.chPath.Tag = "path";
            this.chPath.Text = "Path";
            this.chPath.Width = 278;
            // 
            // chSize
            // 
            this.chSize.Tag = "size";
            this.chSize.Text = "Size";
            this.chSize.Width = 80;
            // 
            // chType
            // 
            this.chType.Tag = "type";
            this.chType.Text = "Type";
            this.chType.Width = 128;
            // 
            // chCreated
            // 
            this.chCreated.Tag = "crea_date";
            this.chCreated.Text = "Created";
            this.chCreated.Width = 147;
            // 
            // chModified
            // 
            this.chModified.Tag = "modi_date";
            this.chModified.Text = "Modified";
            this.chModified.Width = 147;
            // 
            // lPath
            // 
            this.lPath.AccessibleDescription = "copy_path";
            this.lPath.AccessibleName = "path_res";
            this.lPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lPath.ForeColor = System.Drawing.Color.White;
            this.lPath.Image = ((System.Drawing.Image)(resources.GetObject("lPath.Image")));
            this.lPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lPath.Location = new System.Drawing.Point(890, 9);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(109, 45);
            this.lPath.TabIndex = 174;
            this.lPath.Text = "Copy Path";
            this.lPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lMove
            // 
            this.lMove.AccessibleDescription = "";
            this.lMove.AccessibleName = "move_dup";
            this.lMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lMove.ForeColor = System.Drawing.Color.White;
            this.lMove.Image = ((System.Drawing.Image)(resources.GetObject("lMove.Image")));
            this.lMove.Location = new System.Drawing.Point(197, 9);
            this.lMove.Name = "lMove";
            this.lMove.Size = new System.Drawing.Size(45, 45);
            this.lMove.TabIndex = 173;
            this.lMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1184, 675);
            this.Controls.Add(this.lPath);
            this.Controls.Add(this.lMove);
            this.Controls.Add(this.lFind);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.lInvert);
            this.Controls.Add(this.lLoad);
            this.Controls.Add(this.lSave);
            this.Controls.Add(this.lLocation);
            this.Controls.Add(this.lPro);
            this.Controls.Add(this.lUncheck);
            this.Controls.Add(this.lRecycle);
            this.Controls.Add(this.lDel);
            this.Controls.Add(this.lRun);
            this.Controls.Add(this.lProgress);
            this.Controls.Add(this.pStatistics);
            this.Controls.Add(this.pFilter);
            this.Controls.Add(this.lStatistics);
            this.Controls.Add(this.lFilter);
            this.Controls.Add(this.lTipsTitle);
            this.Controls.Add(this.lTips);
            this.Font = new System.Drawing.Font("Segoe UI", 11.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Result";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Duplicate Photo Finder Plus Result - Grouped & Sorted Duplicate Pictures";
            this.Load += new System.EventHandler(this.Me_Load);
            this.cms.ResumeLayout(false);
            this.pFilter.ResumeLayout(false);
            this.pFilter.PerformLayout();
            this.pStatistics.ResumeLayout(false);
            this.pStatistics.PerformLayout();
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void Result_FormClosed(object sender, FormClosedEventArgs e)
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
            Dispose();
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_0075: Could not find block for branch target IL_0045*/
            ;
        }
        if (num3 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private void Me_FormClosing(object sender, FormClosingEventArgs e)
    {
        //Discarded unreachable code: IL_008e, IL_00d0, IL_00d2, IL_00e2, IL_0104
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
            if (Declarer.finalResult.Count > 0)
            {
                num = 4;
                if (Operators.CompareString(Text, SelfService.GetWord("result_title1"), TextCompare: false) == 0)
                {
                    num = 5;
                    if (!_saved)
                    {
                        num = 6;
                        MsgBoxResult msgBoxResult = Interaction.MsgBox(SelfService.GetWord("ask_save"), MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question);
                        num = 7;
                        if (msgBoxResult == MsgBoxResult.Yes)
                        {
                            num = 8;
                            ToolbarClicked("lSave");
                        }
                        else
                        {
                            num = 10;
                            if (msgBoxResult == MsgBoxResult.Cancel)
                            {
                                num = 11;
                                e.Cancel = true;
                            }
                        }
                    }
                }
            }
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_0102: Could not find block for branch target IL_00d2*/
            ;
        }
        if (num3 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private void Buttons_Click(object sender, EventArgs e)
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
            ToolbarClicked(((Control)sender).Name);
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_0080: Could not find block for branch target IL_0050*/
            ;
        }
        if (num3 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private void cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        //Discarded unreachable code: IL_003e, IL_0060, IL_0062, IL_0072, IL_0094
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
            cms.Visible = false;
            num = 4;
            ToolbarClicked(e.ClickedItem.Name);
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_0092: Could not find block for branch target IL_0062*/
            ;
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

    private void Me_Resize(object sender, EventArgs e)
    {
        //Discarded unreachable code: IL_0301, IL_0377, IL_0379, IL_0389, IL_03ab
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
                sc.Width = base.ClientSize.Width - 18;
                num = 4;
                pFilter.Width = base.ClientSize.Width - pFilter.Left - 9;
                num = 5;
                pPreviews.Width = pFilter.Width;
                num = 6;
                lTips.Left = base.ClientSize.Width - 9 - lTips.Width;
                num = 7;
                lTipsTitle.Left = lTips.Left - lTipsTitle.Width;
                num = 8;
                pStatistics.Width = lTipsTitle.Left - pStatistics.Left - 9;
                num = 9;
                lTips.Top = base.ClientSize.Height - 9 - lTips.Height;
                num = 10;
                lTips.Height = lTipsTitle.Height;
                num = 11;
                lTipsTitle.Top = lTips.Top;
                num = 12;
                pStatistics.Top = lTips.Top;
                num = 13;
                lStatistics.Top = lTips.Top;
                num = 14;
                lFilter.Top = lTips.Top - 9 - lFilter.Height;
                num = 15;
                pFilter.Top = lFilter.Top;
                num = 16;
                sc.Height = lFilter.Top - 9 - sc.Top;
                num = 17;
                AdjustPics();
                num = 18;
                TListView tlv = this.tlv;
                num = 19;
                tlv.Columns[0].Width = 228;
                num = 20;
                tlv.Columns[2].Width = 80;
                num = 21;
                tlv.Columns[3].Width = 175;
                num = 22;
                tlv.Columns[4].Width = 166;
                num = 23;
                tlv.Columns[5].Width = 166;
                num = 24;
                tlv.Columns[1].Width = tlv.Width - tlv.Columns[0].Width - tlv.Columns[2].Width - tlv.Columns[3].Width - tlv.Columns[4].Width - tlv.Columns[5].Width - 30;
                tlv = null;
            }
            catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
            {
                ProjectData.SetProjectError((Exception)obj);
                /*Error near IL_03a9: Could not find block for branch target IL_0379*/
                ;
            }
            if (num3 != 0)
            {
                ProjectData.ClearProjectError();
            }
        }
    }

    private void cbSizes_CheckedChanged(object sender, EventArgs e)
    {
        //Discarded unreachable code: IL_00c9, IL_00fb, IL_00fd, IL_010d, IL_012f
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
            if (!cbSH.Checked && !cbSL.Checked && !cbSM.Checked && !cbSS.Checked && !cbST.Checked)
            {
                num = 4;
                cbSA.Checked = false;
            }
            else
            {
                num = 6;
                if (cbSH.Checked && cbSL.Checked && cbSM.Checked && cbSS.Checked && cbST.Checked)
                {
                    num = 7;
                    cbSA.Checked = true;
                }
            }
            num = 8;
            FilterResult();
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_012d: Could not find block for branch target IL_00fd*/
            ;
        }
        if (num3 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private void cbSA_CheckedChanged(object sender, EventArgs e)
    {
        //Discarded unreachable code: IL_00b1, IL_00eb, IL_00ed, IL_00fd, IL_011f
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
            _all = true;
            num = 4;
            cbSH.Checked = cbSA.Checked;
            num = 5;
            cbSL.Checked = cbSA.Checked;
            num = 6;
            cbSM.Checked = cbSA.Checked;
            num = 7;
            cbSS.Checked = cbSA.Checked;
            num = 8;
            cbST.Checked = cbSA.Checked;
            num = 9;
            _all = false;
            num = 10;
            FilterResult();
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_011d: Could not find block for branch target IL_00ed*/
            ;
        }
        if (num3 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private bool CheckItems()
    {
        //Discarded unreachable code: IL_0081, IL_00bb, IL_00bd, IL_00cd, IL_00ef
        int num2 = default(int);
        bool result = false;
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
            if (tlv.Items.Count < 1)
            {
                num = 4;
                Interaction.MsgBox(SelfService.GetWord("no_dup1"), MsgBoxStyle.Information);
                goto IL_007a;
            }
            num = 6;
            if (tlv.CheckedItems.Count < 1)
            {
                num = 7;
                Interaction.MsgBox(SelfService.GetWord("check_do1"), MsgBoxStyle.Information);
                goto IL_007a;
            }
            num = 9;
            result = true;
            goto end_IL_0000;
        IL_007a:
            num = 10;
            result = false;
        end_IL_0000:;
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_00ed: Could not find block for branch target IL_00bd*/
            ;
        }
        if (num3 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    }

    private void ToolbarClicked(string controlName)
    {
        //Discarded unreachable code: IL_10d4, IL_134e, IL_1350, IL_1360, IL_1382
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
            if (!General.InStrings(controlName, "lRecycle", "tsmiRecycle", "lDel", "tsmiDel", "lMove", "tsmiMove"))
            {
                goto IL_0068;
            }
            num = 4;
            if (CheckItems())
            {
                goto IL_0068;
            }
            goto end_IL_0000;
        IL_0068:
            num = 6;
            IEnumerator enumerator;
            OpenFileDialog openFileDialog;
            string word3;
            IEnumerator enumerator6;
            Form f;
            Label l;
            DelProgress delProgress;
            IEnumerator enumerator7;
            switch (_003CPrivateImplementationDetails_003E.ComputeStringHash(controlName))
            {
                default:
                    goto end_IL_0000;
                case 2438708166u:
                    if (Operators.CompareString(controlName, "lSave", TextCompare: false) == 0)
                    {
                        goto IL_0408;
                    }
                    goto end_IL_0000;
                case 3816319543u:
                    if (Operators.CompareString(controlName, "tsmiSave", TextCompare: false) == 0)
                    {
                        goto IL_0408;
                    }
                    goto end_IL_0000;
                case 2409800107u:
                    if (Operators.CompareString(controlName, "lInvert", TextCompare: false) == 0)
                    {
                        goto IL_060e;
                    }
                    goto end_IL_0000;
                case 319867730u:
                    if (Operators.CompareString(controlName, "tsmiInvert", TextCompare: false) == 0)
                    {
                        goto IL_060e;
                    }
                    goto end_IL_0000;
                case 2193529387u:
                    if (Operators.CompareString(controlName, "lLoad", TextCompare: false) == 0)
                    {
                        goto IL_0699;
                    }
                    goto end_IL_0000;
                case 114730722u:
                    if (Operators.CompareString(controlName, "tsmiLoad", TextCompare: false) == 0)
                    {
                        goto IL_0699;
                    }
                    goto end_IL_0000;
                case 2269812164u:
                    if (Operators.CompareString(controlName, "lRecycle", TextCompare: false) == 0)
                    {
                        goto IL_08fe;
                    }
                    goto end_IL_0000;
                case 35380535u:
                    if (Operators.CompareString(controlName, "tsmiRecycle", TextCompare: false) == 0)
                    {
                        goto IL_08fe;
                    }
                    goto end_IL_0000;
                case 3651873292u:
                    if (Operators.CompareString(controlName, "lDel", TextCompare: false) == 0)
                    {
                        goto IL_08fe;
                    }
                    goto end_IL_0000;
                case 772115459u:
                    if (Operators.CompareString(controlName, "tsmiDel", TextCompare: false) == 0)
                    {
                        goto IL_08fe;
                    }
                    goto end_IL_0000;
                case 2162315346u:
                    if (Operators.CompareString(controlName, "lMove", TextCompare: false) == 0)
                    {
                        goto IL_08fe;
                    }
                    goto end_IL_0000;
                case 3972906407u:
                    if (Operators.CompareString(controlName, "tsmiMove", TextCompare: false) == 0)
                    {
                        goto IL_08fe;
                    }
                    goto end_IL_0000;
                case 257238600u:
                    if (Operators.CompareString(controlName, "lFind", TextCompare: false) == 0)
                    {
                        goto IL_0bfa;
                    }
                    goto end_IL_0000;
                case 2598146221u:
                    if (Operators.CompareString(controlName, "tsmiFind", TextCompare: false) == 0)
                    {
                        goto IL_0bfa;
                    }
                    goto end_IL_0000;
                case 500664588u:
                    if (Operators.CompareString(controlName, "lRun", TextCompare: false) == 0)
                    {
                        goto IL_0daf;
                    }
                    goto end_IL_0000;
                case 1341356491u:
                    if (Operators.CompareString(controlName, "tsmiRun", TextCompare: false) == 0)
                    {
                        goto IL_0daf;
                    }
                    goto end_IL_0000;
                case 2750846188u:
                    if (Operators.CompareString(controlName, "lLocation", TextCompare: false) == 0)
                    {
                        goto IL_0e6d;
                    }
                    goto end_IL_0000;
                case 1050495801u:
                    if (Operators.CompareString(controlName, "tsmiLocation", TextCompare: false) == 0)
                    {
                        goto IL_0e6d;
                    }
                    goto end_IL_0000;
                case 43674452u:
                    if (Operators.CompareString(controlName, "lUncheck", TextCompare: false) == 0)
                    {
                        goto IL_0eeb;
                    }
                    goto end_IL_0000;
                case 1597735243u:
                    if (Operators.CompareString(controlName, "tsmiUncheck", TextCompare: false) == 0)
                    {
                        goto IL_0eeb;
                    }
                    goto end_IL_0000;
                case 4155780562u:
                    if (Operators.CompareString(controlName, "lPro", TextCompare: false) == 0)
                    {
                        goto IL_0f82;
                    }
                    goto end_IL_0000;
                case 1209070881u:
                    if (Operators.CompareString(controlName, "tsmiPro", TextCompare: false) == 0)
                    {
                        goto IL_0f82;
                    }
                    goto end_IL_0000;
                case 2568918140u:
                    if (Operators.CompareString(controlName, "lPath", TextCompare: false) == 0)
                    {
                        break;
                    }
                    goto end_IL_0000;
                case 934780953u:
                    {
                        if (Operators.CompareString(controlName, "tsmiPath", TextCompare: false) == 0)
                        {
                            break;
                        }
                        goto end_IL_0000;
                    }
                IL_0f82:
                    num = 146;
                    if (tlv.SelectedItems.Count > 0)
                    {
                        num = 147;
                        if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(tlv.SelectedItems[0].SubItems[1].Text + "\\" + tlv.SelectedItems[0].Text))
                        {
                            num = 148;
                            TFile.ShowProperty(base.Handle, tlv.SelectedItems[0].SubItems[1].Text + "\\" + tlv.SelectedItems[0].Text);
                        }
                    }
                    goto end_IL_0000;
                IL_0eeb:
                    num = 138;
                    _batchCheck = true;
                    num = 139;
                    enumerator = tlv.CheckedItems.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        ListViewItem listViewItem = (ListViewItem)enumerator.Current;
                        num = 140;
                        listViewItem.Checked = false;
                        num = 141;
                    }
                    num = 142;
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                    num = 143;
                    _batchCheck = false;
                    num = 144;
                    tlv_ItemChecked(tlv, new ItemCheckedEventArgs(null));
                    goto end_IL_0000;
                IL_0699:
                    num = 44;
                    if (Declarer.finalResult.Count > 0)
                    {
                        num = 45;
                        if (Operators.CompareString(Text, SelfService.GetWord("result_title1"), TextCompare: false) == 0)
                        {
                            num = 46;
                            if (!_saved)
                            {
                                num = 47;
                                if (Interaction.MsgBox(SelfService.GetWord("save_first"), MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question) == MsgBoxResult.Yes)
                                {
                                    num = 48;
                                    ToolbarClicked("lSave");
                                }
                            }
                        }
                    }
                    num = 49;
                    openFileDialog = new OpenFileDialog();
                    num = 50;
                    openFileDialog.Filter = SelfService.GetWord("dpfp_files");
                    num = 51;
                    openFileDialog.Multiselect = false;
                    num = 52;
                    openFileDialog.ShowDialog();
                    num = 53;
                    if (openFileDialog.FileName.Length >= 1)
                    {
                        num = 55;
                        string word = SelfService.GetWord("load_resu1");
                        f = this;
                        l = lProgress;
                        SelfService.WaitPrompt(word, ref f, ref l);
                        lProgress = l;
                        num = 56;
                        Declarer.finalResult.Clear();
                        num = 57;
                        StreamReader streamReader = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                        while (true)
                        {
                            num = 59;
                            if (streamReader.EndOfStream)
                            {
                                break;
                            }
                            num = 60;
                            string[] array = streamReader.ReadLine().Split('>');
                            num = 61;
                            string[] array2 = array[1].Split('|');
                            num = 62;
                            List<string> list = new List<string>();
                            num = 63;
                            string[] array3 = array2;
                            foreach (string item in array3)
                            {
                                num = 64;
                                list.Add(item);
                                num = 65;
                            }
                            num = 66;
                            Declarer.finalResult.Add(array[0], list);
                        }
                        num = 68;
                        streamReader.Close();
                        num = 69;
                        _batchCheck = true;
                        num = 70;
                        cbSA.Checked = false;
                        num = 71;
                        cbSA.Checked = true;
                        num = 72;
                        _batchCheck = false;
                        num = 73;
                        tlv_ItemChecked(tlv, new ItemCheckedEventArgs(null));
                        num = 74;
                        Text = SelfService.GetWord("loaded_from") + openFileDialog.FileName;
                        num = 75;
                        lSScanned.Text = SelfService.GetWord("not_applicable");
                        num = 76;
                        lSFound.Text = lSFiltered.Text;
                        num = 77;
                        lSDone.Text = lSScanned.Text;
                        num = 78;
                        f = this;
                        l = lProgress;
                        SelfService.AfterPrompt(ref f, ref l);
                        lProgress = l;
                    }
                    goto end_IL_0000;
                IL_0408:
                    num = 8;
                    if (Declarer.finalResult.Count < 1)
                    {
                        num = 9;
                        Interaction.MsgBox(SelfService.GetWord("no_res_s"), MsgBoxStyle.Information);
                    }
                    else
                    {
                        num = 11;
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        num = 12;
                        saveFileDialog.Filter = SelfService.GetWord("dpfp_files");
                        num = 13;
                        saveFileDialog.FileName = "duplicates_" + Strings.Format(DateAndTime.Now, "yyyyMMdd");
                        num = 14;
                        int num3 = (int)saveFileDialog.ShowDialog();
                        num = 15;
                        if (num3 == 1 || num3 == 6)
                        {
                            num = 17;
                            string word2 = SelfService.GetWord("saving_dup1");
                            f = this;
                            l = lProgress;
                            SelfService.WaitPrompt(word2, ref f, ref l);
                            lProgress = l;
                            num = 18;
                            StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, append: false, Encoding.UTF8);
                            num = 19;
                            string empty = string.Empty;
                            num = 20;
                            SortedDictionary<string, List<string>>.Enumerator enumerator2 = Declarer.finalResult.GetEnumerator();
                            while (enumerator2.MoveNext())
                            {
                                KeyValuePair<string, List<string>> current = enumerator2.Current;
                                num = 21;
                                empty = string.Empty;
                                num = 22;
                                List<string>.Enumerator enumerator3 = current.Value.GetEnumerator();
                                while (enumerator3.MoveNext())
                                {
                                    string current2 = enumerator3.Current;
                                    num = 23;
                                    empty = empty + current2 + "|";
                                    num = 24;
                                }
                                num = 25;
                                ((IDisposable)enumerator3).Dispose();
                                num = 26;
                                if (empty.Length > 1)
                                {
                                    num = 27;
                                    empty = empty.Substring(0, checked(empty.Length - 1));
                                }
                                num = 28;
                                streamWriter.WriteLine(current.Key + ">" + empty);
                                num = 29;
                            }
                            num = 30;
                            ((IDisposable)enumerator2).Dispose();
                            num = 31;
                            streamWriter.Close();
                            num = 32;
                            f = this;
                            l = lProgress;
                            SelfService.AfterPrompt(ref f, ref l);
                            lProgress = l;
                            num = 33;
                            Interaction.MsgBox(SelfService.GetWord("save_resu_succ") + "\r\n" + saveFileDialog.FileName, MsgBoxStyle.Information);
                            num = 34;
                            _saved = true;
                        }
                    }
                    goto end_IL_0000;
                IL_0e6d:
                    num = 134;
                    if (tlv.SelectedItems.Count > 0)
                    {
                        num = 135;
                        if (Microsoft.VisualBasic.FileIO.FileSystem.DirectoryExists(tlv.SelectedItems[0].SubItems[1].Text))
                        {
                            num = 136;
                            TFile.ExecFileFolder(tlv.SelectedItems[0].SubItems[1].Text);
                        }
                    }
                    goto end_IL_0000;
                IL_0daf:
                    num = 130;
                    if (tlv.SelectedItems.Count > 0)
                    {
                        num = 131;
                        if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(tlv.SelectedItems[0].SubItems[1].Text + "\\" + tlv.SelectedItems[0].Text))
                        {
                            num = 132;
                            TFile.ExecFileFolder(tlv.SelectedItems[0].SubItems[1].Text + "\\" + tlv.SelectedItems[0].Text);
                        }
                    }
                    goto end_IL_0000;
                IL_0bfa:
                    num = 112;
                    if (tlv.Items.Count < 1)
                    {
                        num = 113;
                        Interaction.MsgBox(SelfService.GetWord("no_data_find"), MsgBoxStyle.Information);
                    }
                    else
                    {
                        num = 115;
                        string text = Interaction.InputBox(SelfService.GetWord("find_input")).Trim().ToLower();
                        num = 116;
                        if (text.Length > 0)
                        {
                            num = 117;
                            IEnumerator enumerator4 = tlv.SelectedItems.GetEnumerator();
                            while (enumerator4.MoveNext())
                            {
                                ListViewItem listViewItem2 = (ListViewItem)enumerator4.Current;
                                num = 118;
                                listViewItem2.Selected = false;
                                num = 119;
                            }
                            num = 120;
                            if (enumerator4 is IDisposable)
                            {
                                (enumerator4 as IDisposable).Dispose();
                            }
                            num = 121;
                            IEnumerator enumerator5 = tlv.Items.GetEnumerator();
                            while (enumerator5.MoveNext())
                            {
                                ListViewItem listViewItem3 = (ListViewItem)enumerator5.Current;
                                num = 122;
                                if (LikeOperator.LikeString(listViewItem3.Text.ToLower(), "*" + text + "*", Microsoft.VisualBasic.CompareMethod.Binary) | LikeOperator.LikeString(listViewItem3.SubItems[1].Text.ToLower(), "*" + text + "*", Microsoft.VisualBasic.CompareMethod.Binary))
                                {
                                    num = 123;
                                    listViewItem3.Selected = true;
                                }
                                num = 124;
                            }
                            num = 125;
                            if (enumerator5 is IDisposable)
                            {
                                (enumerator5 as IDisposable).Dispose();
                            }
                            num = 126;
                            if (tlv.SelectedItems.Count > 0)
                            {
                                num = 127;
                                tlv.TopItem = tlv.SelectedItems[0];
                            }
                            num = 128;
                            tlv.Select();
                        }
                    }
                    goto end_IL_0000;
                IL_08fe:
                    num = 80;
                    delProgress = My.MyProject.Forms.DelProgress;
                    num = 81;
                    if (Declarer.licenseType.Length < 1)
                    {
                        num = 82;
                        if (Interaction.MsgBox(SelfService.GetWord("dear_user") + "\r\n\r\n" + SelfService.GetWord("dpfp_limit_tip") + "\r\n\r\n" + SelfService.GetWord("no_limit") + "\r\n\r\n" + SelfService.GetWord("ask_purchase"), MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question) == MsgBoxResult.Yes)
                        {
                            num = 83;
                            SelfService.Purchase();
                        }
                    }
                    num = 84;
                    word3 = SelfService.GetWord("fill_prog");
                    f = this;
                    l = lProgress;
                    SelfService.WaitPrompt(word3, ref f, ref l);
                    lProgress = l;
                    num = 85;
                    if (General.InStrings(controlName, "lRecycle", "tsmiRecycle"))
                    {
                        num = 86;
                        delProgress.Text = SelfService.GetWord("move_rb3");
                        num = 87;
                        delProgress.Tag = "RB";
                    }
                    else
                    {
                        num = 89;
                        if (General.InStrings(controlName, "lDel", "tsmiDel"))
                        {
                            num = 90;
                            delProgress.Text = SelfService.GetWord("del_files");
                            num = 91;
                            delProgress.Tag = "PD";
                        }
                        else
                        {
                            num = 93;
                            delProgress.Text = SelfService.GetWord("move_files");
                            num = 94;
                            delProgress.Tag = "MOVE";
                        }
                    }
                    num = 95;
                    delProgress.tlv.Items.Clear();
                    num = 96;
                    enumerator6 = tlv.CheckedItems.GetEnumerator();
                    while (enumerator6.MoveNext())
                    {
                        ListViewItem listViewItem4 = (ListViewItem)enumerator6.Current;
                        num = 97;
                        if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(listViewItem4.Tag.ToString().Split('|')[1]))
                        {
                            num = 98;
                            ListViewItem listViewItem5 = delProgress.tlv.Items.Add(listViewItem4.Tag.ToString().Split('|')[1]);
                            num = 99;
                            listViewItem5.Tag = listViewItem4.Tag.ToString().Split('|')[0];
                        }
                        num = 100;
                        if (Declarer.licenseType.Length < 1)
                        {
                            break;
                        }
                        num = 102;
                    }
                    num = 103;
                    if (enumerator6 is IDisposable)
                    {
                        (enumerator6 as IDisposable).Dispose();
                    }
                    num = 104;
                    delProgress.lReport.Visible = false;
                    num = 105;
                    delProgress.pb.Maximum = delProgress.tlv.Items.Count;
                    num = 106;
                    delProgress.pb.Value = 0;
                    num = 107;
                    delProgress.lProgress.Text = "0 / " + delProgress.pb.Maximum.ToString();
                    num = 108;
                    f = this;
                    l = lProgress;
                    SelfService.AfterPrompt(ref f, ref l);
                    lProgress = l;
                    num = 109;
                    delProgress.ShowDialog(this);
                    delProgress = null;
                    goto end_IL_0000;
                IL_060e:
                    num = 36;
                    _batchCheck = true;
                    num = 37;
                    enumerator7 = tlv.Items.GetEnumerator();
                    while (enumerator7.MoveNext())
                    {
                        ListViewItem listViewItem6 = (ListViewItem)enumerator7.Current;
                        num = 38;
                        listViewItem6.Checked = !listViewItem6.Checked;
                        num = 39;
                    }
                    num = 40;
                    if (enumerator7 is IDisposable)
                    {
                        (enumerator7 as IDisposable).Dispose();
                    }
                    num = 41;
                    _batchCheck = false;
                    num = 42;
                    tlv_ItemChecked(tlv, new ItemCheckedEventArgs(null));
                    goto end_IL_0000;
            }
            num = 150;
            if (tlv.SelectedItems.Count > 0)
            {
                num = 151;
                Clipboard.Clear();
                num = 152;
                Clipboard.SetText(tlv.SelectedItems[0].SubItems[1].Text + "\\" + tlv.SelectedItems[0].Text);
                num = 153;
                Interaction.MsgBox(SelfService.GetWord("copied_path"), MsgBoxStyle.Information);
            }
        end_IL_0000:;
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num4 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_1380: Could not find block for branch target IL_1350*/
            ;
        }
        if (num4 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    public void FilterResult()
    {
        //Discarded unreachable code: IL_0917, IL_0b59, IL_0b5b, IL_0b6b, IL_0b8d
        checked
        {
            int num2 = default(int);
            int num9 = default(int);
            try
            {
                int num = 1;
                if (!LikeOperator.LikeString(Declarer.startPath, "*Debug", Microsoft.VisualBasic.CompareMethod.Binary))
                {
                    ProjectData.ClearProjectError();
                    num2 = 1;
                }
                num = 3;
                if (!_all)
                {
                    num = 5;
                    string word = SelfService.GetWord("reload1");
                    Form f = this;
                    Label l = lProgress;
                    SelfService.WaitPrompt(word, ref f, ref l);
                    lProgress = l;
                    num = 6;
                    _batchCheck = true;
                    num = 7;
                    tlv.Items.Clear();
                    num = 8;
                    pPreviews.Controls.Clear();
                    num = 9;
                    bool flag = false;
                    num = 10;
                    List<string> list = new List<string>();
                    num = 11;
                    SortedDictionary<string, List<string>>.ValueCollection.Enumerator enumerator = Declarer.finalResult.Values.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        List<string> current = enumerator.Current;
                        num = 12;
                        int num3 = current.Count - 1;
                        num = 13;
                        for (int i = num3; i >= 0; i += -1)
                        {
                            num = 14;
                            if (!Microsoft.VisualBasic.FileIO.FileSystem.FileExists(current[i]))
                            {
                                num = 15;
                                current.RemoveAt(i);
                            }
                            num = 16;
                        }
                        num = 17;
                    }
                    num = 18;
                    ((IDisposable)enumerator).Dispose();
                    num = 19;
                    SortedDictionary<string, List<string>>.Enumerator enumerator2;
                    int num7 = default(int);
                    long num8 = default(long);
                    for (enumerator2 = Declarer.finalResult.GetEnumerator(); enumerator2.MoveNext(); num = 117)
                    {
                        KeyValuePair<string, List<string>> current2 = enumerator2.Current;
                        num = 20;
                        DateTime t = default(DateTime);
                        num = 21;
                        int num4 = 0;
                        num = 22;
                        int num5 = 0;
                        num = 23;
                        string item = string.Empty;
                        num = 24;
                        if (Declarer.finalResult[current2.Key].Count >= 2)
                        {
                            num = 26;
                            long num6 = Conversions.ToLong(Conversion.Int(current2.Key));
                            num = 28;
                            if (num6 >= 1 && num6 <= 10239)
                            {
                                num = 29;
                                if (!cbST.Checked)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                num = 32;
                                if (num6 >= 10240 && num6 <= 102399)
                                {
                                    num = 33;
                                    if (!cbSS.Checked)
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    num = 36;
                                    if (num6 >= 102400 && num6 <= 1048575)
                                    {
                                        num = 37;
                                        if (!cbSM.Checked)
                                        {
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        num = 40;
                                        if (num6 >= 1048576 && num6 <= 16777215)
                                        {
                                            num = 41;
                                            if (!cbSL.Checked)
                                            {
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            num = 44;
                                            if (num6 < 16777216 || num6 > 134217727)
                                            {
                                                continue;
                                            }
                                            num = 45;
                                            if (!cbSH.Checked)
                                            {
                                                continue;
                                            }
                                        }
                                    }
                                }
                            }
                            num = 48;
                            num7++;
                            num = 49;
                            List<string>.Enumerator enumerator3 = current2.Value.GetEnumerator();
                            while (enumerator3.MoveNext())
                            {
                                string current3 = enumerator3.Current;
                                num = 50;
                                IWshRuntimeLibrary.File file = ((IFileSystem3)new FileSystemObjectClass()).GetFile(current3);
                                num = 51;
                                if (My.MySettingsProperty.Settings.smart)
                                {
                                    num = 52;
                                    if (num4 == 0)
                                    {
                                        num = 53;
                                        t = file.DateCreated;
                                        num = 54;
                                        num4 = file.ParentFolder.Path.Length;
                                        num = 55;
                                        num5 = file.Name.Length;
                                        num = 56;
                                        item = current3;
                                    }
                                    else
                                    {
                                        num = 58;
                                        if (DateTime.Compare(file.DateCreated, t) > 0)
                                        {
                                            num = 59;
                                            if (Operators.CompareString(My.MySettingsProperty.Settings.created, "L", TextCompare: false) == 0)
                                            {
                                                num = 60;
                                                t = file.DateCreated;
                                                num = 61;
                                                num4 = file.ParentFolder.Path.Length;
                                                num = 62;
                                                num5 = file.Name.Length;
                                                num = 63;
                                                item = current3;
                                            }
                                        }
                                        else
                                        {
                                            num = 65;
                                            if (DateTime.Compare(file.DateCreated, t) < 0)
                                            {
                                                num = 66;
                                                if (Operators.CompareString(My.MySettingsProperty.Settings.created, "E", TextCompare: false) == 0)
                                                {
                                                    num = 67;
                                                    t = file.DateCreated;
                                                    num = 68;
                                                    num4 = file.ParentFolder.Path.Length;
                                                    num = 69;
                                                    num5 = file.Name.Length;
                                                    num = 70;
                                                    item = current3;
                                                }
                                            }
                                            else
                                            {
                                                num = 72;
                                                if (file.ParentFolder.Path.Length < num4)
                                                {
                                                    num = 73;
                                                    if (Operators.CompareString(My.MySettingsProperty.Settings.path, "S", TextCompare: false) == 0)
                                                    {
                                                        num = 74;
                                                        t = file.DateCreated;
                                                        num = 75;
                                                        num4 = file.ParentFolder.Path.Length;
                                                        num = 76;
                                                        num5 = file.Name.Length;
                                                        num = 77;
                                                        item = current3;
                                                    }
                                                }
                                                else
                                                {
                                                    num = 79;
                                                    if (file.ParentFolder.Path.Length > num4)
                                                    {
                                                        num = 80;
                                                        if (Operators.CompareString(My.MySettingsProperty.Settings.path, "L", TextCompare: false) == 0)
                                                        {
                                                            num = 81;
                                                            t = file.DateCreated;
                                                            num = 82;
                                                            num4 = file.ParentFolder.Path.Length;
                                                            num = 83;
                                                            num5 = file.Name.Length;
                                                            num = 84;
                                                            item = current3;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        num = 86;
                                                        if (file.Name.Length < num5)
                                                        {
                                                            num = 87;
                                                            if (Operators.CompareString(My.MySettingsProperty.Settings.name, "S", TextCompare: false) == 0)
                                                            {
                                                                num = 88;
                                                                t = file.DateCreated;
                                                                num = 89;
                                                                num4 = file.ParentFolder.Path.Length;
                                                                num = 90;
                                                                num5 = file.Name.Length;
                                                                num = 91;
                                                                item = current3;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            num = 93;
                                                            if (file.Name.Length > num5)
                                                            {
                                                                num = 94;
                                                                if (Operators.CompareString(My.MySettingsProperty.Settings.path, "L", TextCompare: false) == 0)
                                                                {
                                                                    num = 95;
                                                                    t = file.DateCreated;
                                                                    num = 96;
                                                                    num4 = file.ParentFolder.Path.Length;
                                                                    num = 97;
                                                                    num5 = file.Name.Length;
                                                                    num = 98;
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
                                num = 99;
                                ListViewItem listViewItem = tlv.Items.Add(file.Name);
                                num = 100;
                                listViewItem.Name = current3;
                                num = 101;
                                listViewItem.Tag = current2.Key + "|" + current3;
                                num = 102;
                                if (flag)
                                {
                                    num = 103;
                                    listViewItem.ForeColor = Color.FromArgb(4, 165, 240);
                                }
                                num = 104;
                                listViewItem.SubItems.Add(file.ParentFolder.Path);
                                num = 105;
                                listViewItem.SubItems.Add(SelfService.IntelligentSize(Conversions.ToLong(Conversion.Int(current2.Key))));
                                num = 106;
                                num8 += Conversions.ToLong(Conversion.Int(current2.Key));
                                num = 107;
                                listViewItem.SubItems.Add(file.Type);
                                num = 108;
                                listViewItem.SubItems.Add(file.DateCreated.ToString());
                                num = 109;
                                listViewItem.SubItems.Add(file.DateLastModified.ToString());
                                num = 110;
                                if (My.MySettingsProperty.Settings.smart)
                                {
                                    num = 111;
                                    listViewItem.Checked = true;
                                }
                                num = 112;
                            }
                            num = 113;
                            ((IDisposable)enumerator3).Dispose();
                            num = 114;
                            flag = !flag;
                            num = 115;
                            if (My.MySettingsProperty.Settings.smart)
                            {
                                num = 116;
                                list.Add(item);
                            }
                        }
                    }
                    num = 118;
                    ((IDisposable)enumerator2).Dispose();
                    num = 119;
                    if (My.MySettingsProperty.Settings.smart)
                    {
                        num = 120;
                        List<string>.Enumerator enumerator4 = list.GetEnumerator();
                        while (enumerator4.MoveNext())
                        {
                            string current4 = enumerator4.Current;
                            num = 121;
                            tlv.Items.Find(current4, searchAllSubItems: false)[0].Checked = false;
                            num = 122;
                        }
                        num = 123;
                        ((IDisposable)enumerator4).Dispose();
                    }
                    num = 124;
                    if (tlv.Items.Count > 0)
                    {
                        num = 125;
                        tlv.Items[0].Selected = true;
                    }
                    num = 126;
                    string empty = string.Empty;
                    num = 127;
                    string empty2 = string.Empty;
                    num = 128;
                    if (tlv.Items.Count < 2)
                    {
                        num = 129;
                        empty = SelfService.GetWord("dup_pic");
                    }
                    else
                    {
                        num = 131;
                        empty = SelfService.GetWord("dup_pics");
                    }
                    num = 132;
                    if (num7 < 2)
                    {
                        num = 133;
                        empty2 = SelfService.GetWord("group");
                    }
                    else
                    {
                        num = 135;
                        empty2 = SelfService.GetWord("groups");
                    }
                    num = 136;
                    lSFiltered.Text = SelfService.IntelligentSize(num8) + ", " + Strings.Format(tlv.Items.Count, "#,0") + " " + empty + ", " + Strings.Format(num7, "#,0") + " " + empty2;
                    num = 137;
                    f = this;
                    l = lProgress;
                    SelfService.AfterPrompt(ref f, ref l);
                    lProgress = l;
                    num = 138;
                    tlv.Refresh();
                    num = 139;
                    _batchCheck = false;
                    num = 140;
                    tlv_ItemChecked(tlv, new ItemCheckedEventArgs(null));
                }
            }
            catch (Exception obj) when ((obj is Exception && num2 != 0) & (num9 == 0))
            {
                ProjectData.SetProjectError((Exception)obj);
                /*Error near IL_0b8b: Could not find block for branch target IL_0b5b*/
                ;
            }
            if (num9 != 0)
            {
                ProjectData.ClearProjectError();
            }
        }
    }

    private void Me_Load(object sender, EventArgs e)
    {
        //Discarded unreachable code: IL_006b, IL_0099, IL_009b, IL_00ab, IL_00cd
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
            My.MyProject.Forms.Main.Tag = "F";
            num = 4;
            tlv_ItemChecked(tlv, new ItemCheckedEventArgs(null));
            num = 5;
            _saved = false;
            num = 6;
            t.Start();
            num = 7;
            Me_Resize(this, new EventArgs());
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_00cb: Could not find block for branch target IL_009b*/
            ;
        }
        if (num3 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private void t_Tick(object sender, EventArgs e)
    {
        //Discarded unreachable code: IL_010b, IL_0155, IL_0157, IL_0167, IL_0189
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
            t.Stop();
            num = 4;
            if (tlv.Items.Count > 0)
            {
                num = 5;
                tlv.Items[0].Selected = true;
            }
            num = 6;
            if (Declarer.loadFromMain)
            {
                num = 7;
                Declarer.loadFromMain = false;
                num = 8;
                Text = SelfService.GetWord("sel_result_load1");
                num = 9;
                tlv.Items.Clear();
                num = 10;
                lSScanned.Text = SelfService.GetWord("not_applicable1");
                num = 11;
                lSFound.Text = lSScanned.Text;
                num = 12;
                lSDone.Text = lSScanned.Text;
                num = 13;
                lSFiltered.Text = lSScanned.Text;
                num = 14;
                Buttons_Click(lLoad, new EventArgs());
            }
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_0187: Could not find block for branch target IL_0157*/
            ;
        }
        if (num3 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private void tlv_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Discarded unreachable code: IL_02fd, IL_03a3, IL_03a5, IL_03b5, IL_03d7
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
                if (tlv.SelectedItems.Count > 0)
                {
                    num = 4;
                    IEnumerator enumerator = pPreviews.Controls.GetEnumerator();
                    int num3 = default(int);
                    while (true)
                    {
                        if (!enumerator.MoveNext())
                        {
                            num = 8;
                            if (enumerator is IDisposable)
                            {
                                (enumerator as IDisposable).Dispose();
                            }
                            num = 9;
                            pPreviews.Controls.Clear();
                            num = 10;
                            string text = tlv.SelectedItems[0].Tag.ToString().Split('|')[0];
                            num = 11;
                            List<string> list = Declarer.finalResult[text];
                            num = 12;
                            List<string>.Enumerator enumerator2 = list.GetEnumerator();
                            while (enumerator2.MoveNext())
                            {
                                string current = enumerator2.Current;
                                num = 13;
                                PictureBox pictureBox = new PictureBox();
                                num = 14;
                                pictureBox.Height = pPreviews.Height;
                                num = 15;
                                pictureBox.Width = (int)Math.Round((double)(pPreviews.Width - (list.Count - 1) * 2) / (double)list.Count);
                                num = 16;
                                pictureBox.Left = 0 + num3 * pictureBox.Width;
                                num = 17;
                                pictureBox.Top = 0;
                                num = 18;
                                Image image = Image.FromFile(current);
                                num = 19;
                                if (image.Width > pictureBox.Width || image.Height > pictureBox.Height)
                                {
                                    num = 20;
                                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                                else
                                {
                                    num = 22;
                                    pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                                }
                                num = 23;
                                pictureBox.ImageLocation = current;
                                num = 24;
                                tt.SetToolTip(pictureBox, current);
                                num = 25;
                                pictureBox.Cursor = Cursors.Hand;
                                num = 26;
                                pPreviews.Controls.Add(pictureBox);
                                num = 27;
                                pictureBox.Click += pb_Click;
                                num = 28;
                                num3++;
                                num = 29;
                            }
                            num = 30;
                            ((IDisposable)enumerator2).Dispose();
                            num = 31;
                            IEnumerator enumerator3 = tlv.Items.GetEnumerator();
                            while (enumerator3.MoveNext())
                            {
                                ListViewItem listViewItem = (ListViewItem)enumerator3.Current;
                                num = 32;
                                if (Operators.CompareString(listViewItem.Tag.ToString().Split('|')[0], text, TextCompare: false) == 0)
                                {
                                    num = 33;
                                    listViewItem.BackColor = Color.LightSteelBlue;
                                }
                                else
                                {
                                    num = 35;
                                    listViewItem.BackColor = Color.White;
                                }
                                num = 36;
                            }
                            num = 37;
                            if (enumerator3 is IDisposable)
                            {
                                (enumerator3 as IDisposable).Dispose();
                            }
                            break;
                        }
                        Control control = (Control)enumerator.Current;
                        num = 5;
                        if (Operators.CompareString(((PictureBox)control).ImageLocation, tlv.SelectedItems[0].Tag.ToString().Split('|')[1], TextCompare: false) == 0)
                        {
                            break;
                        }
                        num = 7;
                    }
                }
            }
            catch (Exception obj) when ((obj is Exception && num2 != 0) & (num4 == 0))
            {
                ProjectData.SetProjectError((Exception)obj);
                /*Error near IL_03d5: Could not find block for branch target IL_03a5*/
                ;
            }
            if (num4 != 0)
            {
                ProjectData.ClearProjectError();
            }
        }
    }

    private void pb_Click(object sender, EventArgs e)
    {
        //Discarded unreachable code: IL_0042, IL_0068, IL_006a, IL_007a, IL_009c
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
            PictureBox pictureBox = (PictureBox)sender;
            num = 4;
            if (Microsoft.VisualBasic.FileIO.FileSystem.FileExists(pictureBox.ImageLocation))
            {
                num = 5;
                TFile.ExecFileFolder(pictureBox.ImageLocation);
            }
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_009a: Could not find block for branch target IL_006a*/
            ;
        }
        if (num3 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private void tlv_DoubleClick(object sender, EventArgs e)
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
            Buttons_Click(lRun, new EventArgs());
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_0080: Could not find block for branch target IL_0050*/
            ;
        }
        if (num3 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private void tlv_ItemChecked(object sender, ItemCheckedEventArgs e)
    {
        //Discarded unreachable code: IL_01b2, IL_0214, IL_0216, IL_0226, IL_0248
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
            if (!_batchCheck)
            {
                num = 5;
                if (Operators.CompareString(My.MyProject.Forms.Main.Tag.ToString(), "L", TextCompare: false) != 0)
                {
                    num = 7;
                    if (tlv.CheckedItems.Count < 1)
                    {
                        num = 8;
                        if (Operators.CompareString(lSChecked.Text, SelfService.GetWord("zero"), TextCompare: false) != 0)
                        {
                            num = 9;
                            lSChecked.Text = SelfService.GetWord("zero");
                        }
                    }
                    else
                    {
                        num = 11;
                        IEnumerator enumerator = tlv.CheckedItems.GetEnumerator();
                        long num3 = default(long);
                        while (enumerator.MoveNext())
                        {
                            ListViewItem listViewItem = (ListViewItem)enumerator.Current;
                            num = 12;
                            num3 = checked(num3 + Conversions.ToLong(listViewItem.Tag.ToString().Split('|')[0]));
                            num = 13;
                        }
                        num = 14;
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                        num = 15;
                        string empty = string.Empty;
                        num = 16;
                        if (tlv.CheckedItems.Count < 2)
                        {
                            num = 17;
                            empty = SelfService.GetWord("pic");
                        }
                        else
                        {
                            num = 19;
                            empty = SelfService.GetWord("pics");
                        }
                        num = 20;
                        lSChecked.Text = SelfService.IntelligentSize(num3) + ", " + Strings.Format(tlv.CheckedItems.Count, "#,0") + " " + empty;
                    }
                }
            }
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num4 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_0246: Could not find block for branch target IL_0216*/
            ;
        }
        if (num4 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private void sc_SplitterMoved(object sender, SplitterEventArgs e)
    {
        //Discarded unreachable code: IL_005f, IL_0085, IL_0087, IL_0097, IL_00b9
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
            lPreviews.Height = sc.Panel2.Height;
            num = 4;
            pPreviews.Height = sc.Panel2.Height;
            num = 5;
            AdjustPics();
        }
        catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_00b7: Could not find block for branch target IL_0087*/
            ;
        }
        if (num3 != 0)
        {
            ProjectData.ClearProjectError();
        }
    }

    private void AdjustPics()
    {
        //Discarded unreachable code: IL_0140, IL_0192, IL_0194, IL_01a4, IL_01c6
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
                IEnumerator enumerator = pPreviews.Controls.GetEnumerator();
                int num3 = default(int);
                while (enumerator.MoveNext())
                {
                    Control control = (Control)enumerator.Current;
                    num = 4;
                    PictureBox pictureBox = (PictureBox)control;
                    num = 5;
                    pictureBox.Height = pPreviews.Height;
                    num = 6;
                    pictureBox.Width = (int)Math.Round((double)(pPreviews.Width - (pPreviews.Controls.Count - 1) * 2) / (double)pPreviews.Controls.Count);
                    num = 7;
                    pictureBox.Left = 0 + num3 * pictureBox.Width;
                    num = 8;
                    pictureBox.Top = 0;
                    num = 9;
                    Image image = Image.FromFile(pictureBox.ImageLocation);
                    num = 10;
                    if (image.Width > pictureBox.Width || image.Height > pictureBox.Height)
                    {
                        num = 11;
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        num = 13;
                        pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    num = 14;
                    num3++;
                    num = 15;
                }
                num = 16;
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            catch (Exception obj) when ((obj is Exception && num2 != 0) & (num4 == 0))
            {
                ProjectData.SetProjectError((Exception)obj);
                /*Error near IL_01c4: Could not find block for branch target IL_0194*/
                ;
            }
            if (num4 != 0)
            {
                ProjectData.ClearProjectError();
            }
        }
    }

    public  Result()
    {
        base.FormClosed += Result_FormClosed;
        base.FormClosing += Me_FormClosing;
        base.Resize += Me_Resize;
        base.Load += Me_Load;
        _all = false;
        _saved = false;
        _batchCheck = false;
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
        //Discarded unreachable code: IL_0769, IL_08cb, IL_08cd, IL_08dd, IL_08ff
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
                IEnumerator enumerator = base.Controls.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Control control = (Control)enumerator.Current;
                    num = 4;
                    if (control.AccessibleDescription != null)
                    {
                        num = 5;
                        if (control.AccessibleDescription.Length > 0)
                        {
                            num = 6;
                            control.Text = SelfService.GetWord(control.AccessibleDescription);
                        }
                    }
                    num = 7;
                    if (control.AccessibleName != null)
                    {
                        num = 8;
                        if (control.AccessibleName.Length > 0)
                        {
                            num = 9;
                            tt.SetToolTip(control, SelfService.GetWord(control.AccessibleName));
                        }
                    }
                    num = 10;
                    if (control is Panel)
                    {
                        num = 11;
                        IEnumerator enumerator2 = control.Controls.GetEnumerator();
                        while (enumerator2.MoveNext())
                        {
                            Control control2 = (Control)enumerator2.Current;
                            num = 12;
                            if (control2.AccessibleDescription != null)
                            {
                                num = 13;
                                if (control2.AccessibleDescription.Length > 0)
                                {
                                    num = 14;
                                    control2.Text = SelfService.GetWord(control2.AccessibleDescription);
                                }
                            }
                            num = 15;
                        }
                        num = 16;
                        if (enumerator2 is IDisposable)
                        {
                            (enumerator2 as IDisposable).Dispose();
                        }
                    }
                    num = 17;
                }
                num = 18;
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
                num = 19;
                IEnumerator enumerator3 = tlv.Columns.GetEnumerator();
                while (enumerator3.MoveNext())
                {
                    ColumnHeader columnHeader = (ColumnHeader)enumerator3.Current;
                    num = 20;
                    columnHeader.Text = SelfService.GetWord(columnHeader.Tag.ToString());
                    num = 21;
                }
                num = 22;
                if (enumerator3 is IDisposable)
                {
                    (enumerator3 as IDisposable).Dispose();
                }
                num = 23;
                IEnumerator enumerator4 = cms.Items.GetEnumerator();
                while (enumerator4.MoveNext())
                {
                    ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)enumerator4.Current;
                    num = 24;
                    if (toolStripMenuItem.AccessibleDescription != null)
                    {
                        num = 25;
                        if (toolStripMenuItem.AccessibleDescription.Length > 0)
                        {
                            num = 26;
                            toolStripMenuItem.Text = SelfService.GetWord(toolStripMenuItem.AccessibleDescription);
                        }
                    }
                    num = 27;
                }
                num = 28;
                if (enumerator4 is IDisposable)
                {
                    (enumerator4 as IDisposable).Dispose();
                }
                num = 29;
                tsmiRun.ShortcutKeyDisplayString = SelfService.GetWord("dclick");
                num = 30;
                lPreviews.Text = SelfService.GetWord(lPreviews.AccessibleDescription);
                num = 31;
                lRun.AutoSize = true;
                num = 32;
                int width = lRun.Width;
                num = 33;
                lRun.AutoSize = false;
                num = 34;
                lRun.Size = new Size(width + 48, 45);
                num = 35;
                lLocation.AutoSize = true;
                num = 36;
                width = lLocation.Width;
                num = 37;
                lLocation.AutoSize = false;
                num = 38;
                lLocation.Size = new Size(width + 48, 45);
                num = 39;
                lUncheck.AutoSize = true;
                num = 40;
                width = lUncheck.Width;
                num = 41;
                lUncheck.AutoSize = false;
                num = 42;
                lUncheck.Size = new Size(width + 40, 45);
                num = 43;
                lInvert.AutoSize = true;
                num = 44;
                width = lInvert.Width;
                num = 45;
                lInvert.AutoSize = false;
                num = 46;
                lInvert.Size = new Size(width + 48, 45);
                num = 47;
                lPro.AutoSize = true;
                num = 48;
                width = lPro.Width;
                num = 49;
                lPro.AutoSize = false;
                num = 50;
                lPro.Size = new Size(width + 48, 45);
                num = 51;
                lPath.AutoSize = true;
                num = 52;
                width = lPath.Width;
                num = 53;
                lPath.AutoSize = false;
                num = 54;
                lPath.Size = new Size(width + 48, 45);
                num = 55;
                lRun.Left = lFind.Left + lFind.Width + 2;
                num = 56;
                lLocation.Left = lRun.Left + lRun.Width + 2;
                num = 57;
                lUncheck.Left = lLocation.Left + lLocation.Width + 2;
                num = 58;
                lInvert.Left = lUncheck.Left + lUncheck.Width + 2;
                num = 59;
                lPro.Left = lInvert.Left + lInvert.Width + 2;
                num = 60;
                lPath.Left = lPro.Left + lPro.Width + 2;
                num = 61;
                cbSH.Left = cbSA.Left + cbSA.Width + 2;
                num = 62;
                cbSL.Left = cbSH.Left + cbSH.Width + 2;
                num = 63;
                cbSM.Left = cbSL.Left + cbSL.Width + 2;
                num = 64;
                cbSS.Left = cbSM.Left + cbSM.Width + 2;
                num = 65;
                cbST.Left = cbSS.Left + cbSS.Width + 2;
                num = 66;
                int width2 = lScanned.Width;
                num = 67;
                if (lFound.Width > width2)
                {
                    num = 68;
                    width2 = lFound.Width;
                }
                num = 69;
                if (lDone.Width > width2)
                {
                    num = 70;
                    width2 = lDone.Width;
                }
                num = 71;
                if (lFiltered.Width > width2)
                {
                    num = 72;
                    width2 = lFiltered.Width;
                }
                num = 73;
                if (lChecked.Width > width2)
                {
                    num = 74;
                    width2 = lChecked.Width;
                }
                num = 75;
                lScanned.Left = 9 + width2 - lScanned.Width;
                num = 76;
                lFound.Left = 9 + width2 - lFound.Width;
                num = 77;
                lDone.Left = 9 + width2 - lDone.Width;
                num = 78;
                lFiltered.Left = 9 + width2 - lFiltered.Width;
                num = 79;
                lChecked.Left = 9 + width2 - lChecked.Width;
                num = 80;
                lSScanned.Left = 18 + width2;
                num = 81;
                lSFound.Left = lSScanned.Left;
                num = 82;
                lSDone.Left = lSScanned.Left;
                num = 83;
                lSFiltered.Left = lSScanned.Left;
                num = 84;
                lSChecked.Left = lSScanned.Left;
            }
            catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
            {
                ProjectData.SetProjectError((Exception)obj);
                /*Error near IL_08fd: Could not find block for branch target IL_08cd*/
                ;
            }
            if (num3 != 0)
            {
                ProjectData.ClearProjectError();
            }
        }
    }
}
