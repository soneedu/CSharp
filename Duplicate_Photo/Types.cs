using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using My;
using My.Resources;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TSSFL.UIControl;

[DesignerGenerated]
public class Types : Form
{
	private IContainer components;

	private ToolTip tt;
	private Label lEdit;
	private Button Button1;
	private Label lDel;
	private Label lAdd;
	private TListView tlv;
	private ColumnHeader chExts;
	private ColumnHeader chDesc;
	private ColumnHeader chPredefined;


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
		lAdd = new System.Windows.Forms.Label();
		lDel = new System.Windows.Forms.Label();
		lEdit = new System.Windows.Forms.Label();
		Button1 = new System.Windows.Forms.Button();
		tlv = new TSSFL.UIControl.TListView();
		chExts = new System.Windows.Forms.ColumnHeader();
		chDesc = new System.Windows.Forms.ColumnHeader();
		chPredefined = new System.Windows.Forms.ColumnHeader();
		SuspendLayout();
		tt.IsBalloon = true;
		lAdd.AccessibleDescription = "add2";
		lAdd.AccessibleName = "pic_tip";
		lAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lAdd.ForeColor = System.Drawing.Color.White;
		lAdd.Image = My.Resources.Resources.add32;
		lAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		lAdd.Location = new System.Drawing.Point(360, 522);
		lAdd.Name = "lAdd";
		lAdd.Size = new System.Drawing.Size(68, 27);
		lAdd.TabIndex = 180;
		lAdd.Text = "Add...";
		lAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		tt.SetToolTip(lAdd, "Adds a custom picture type <Ctrl+N>.");
		lDel.AccessibleDescription = "del";
		lDel.AccessibleName = "pic_tip3";
		lDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lDel.ForeColor = System.Drawing.Color.White;
		lDel.Image = My.Resources.Resources.del32_white;
		lDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		lDel.Location = new System.Drawing.Point(498, 522);
		lDel.Name = "lDel";
		lDel.Size = new System.Drawing.Size(70, 27);
		lDel.TabIndex = 181;
		lDel.Text = "Delete";
		lDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		tt.SetToolTip(lDel, "Deletes the selected custom picture type <Del>.");
		lEdit.AccessibleDescription = "edit2";
		lEdit.AccessibleName = "pic_tip2";
		lEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		lEdit.ForeColor = System.Drawing.Color.White;
		lEdit.Image = My.Resources.Resources.edit32;
		lEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		lEdit.Location = new System.Drawing.Point(430, 522);
		lEdit.Name = "lEdit";
		lEdit.Size = new System.Drawing.Size(66, 27);
		lEdit.TabIndex = 170;
		lEdit.Text = "Edit...";
		lEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		tt.SetToolTip(lEdit, "Edits the selected custom picture type <Ctrl+E or Double-click>.");
		Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		Button1.Location = new System.Drawing.Point(359, 1000);
		Button1.Name = "Button1";
		Button1.Size = new System.Drawing.Size(75, 23);
		Button1.TabIndex = 1;
		Button1.Text = "Button1";
		Button1.UseVisualStyleBackColor = true;
		tlv.BackColor = System.Drawing.Color.White;
		tlv.BorderStyle = System.Windows.Forms.BorderStyle.None;
		tlv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3]
		{
			chExts,
			chDesc,
			chPredefined
		});
		tlv.ForeColor = System.Drawing.Color.FromArgb(72, 72, 72);
		tlv.FullRowSelect = true;
		tlv.GridLines = true;
		tlv.HideSelection = false;
		tlv.Location = new System.Drawing.Point(9, 9);
		tlv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
		tlv.MultiSelect = false;
		tlv.Name = "tlv";
		tlv.ShowItemToolTips = true;
		tlv.Size = new System.Drawing.Size(559, 504);
		tlv.TabIndex = 0;
		tlv.UseCompatibleStateImageBehavior = false;
		tlv.View = System.Windows.Forms.View.Details;
		chExts.Tag = "ext";
		chExts.Text = "Extension(s)";
		chExts.Width = 136;
		chDesc.Tag = "desc";
		chDesc.Text = "Description";
		chDesc.Width = 251;
		chPredefined.Tag = "pred1";
		chPredefined.Text = "Predefined?";
		chPredefined.Width = 145;
		base.AccessibleDescription = "ptm";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.Color.FromArgb(103, 103, 103);
		base.CancelButton = Button1;
		base.ClientSize = new System.Drawing.Size(578, 559);
		base.Controls.Add(tlv);
		base.Controls.Add(lAdd);
		base.Controls.Add(lDel);
		base.Controls.Add(Button1);
		base.Controls.Add(lEdit);
		Font = new System.Drawing.Font("Segoe UI", 11.9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
		ForeColor = System.Drawing.Color.FromArgb(72, 72, 72);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.KeyPreview = true;
		base.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Types";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Picture types manager";
		ResumeLayout(false);
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

	private void Buttons_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0498, IL_0576, IL_0578, IL_0588, IL_05aa
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
			string name = ((Control)sender).Name;
			if (Operators.CompareString(name, "lAdd", TextCompare: false) != 0)
			{
				if (Operators.CompareString(name, "lEdit", TextCompare: false) != 0)
				{
					if (Operators.CompareString(name, "lDel", TextCompare: false) == 0)
					{
						num = 40;
						if (tlv.SelectedItems.Count > 0)
						{
							num = 41;
							if (Interaction.MsgBox(SelfService.GetWord("del_ext") + "\r\n" + tlv.SelectedItems[0].Text, MsgBoxStyle.OkCancel | MsgBoxStyle.AbortRetryIgnore | MsgBoxStyle.Question) == MsgBoxResult.Yes)
							{
								num = 46;
								My.MySettingsProperty.Settings.types = My.MySettingsProperty.Settings.types.Replace("|U:" + tlv.SelectedItems[0].SubItems[1].Text + ":" + tlv.SelectedItems[0].Text.Substring(1), "");
								num = 47;
								SelfService.UpdateExts();
								num = 48;
								My.MySettingsProperty.Settings.Save();
								num = 49;
								tlv.Items.Remove(tlv.SelectedItems[0]);
								num = 50;
								tlv.Items[0].Selected = true;
							}
						}
						else
						{
							num = 44;
							Interaction.MsgBox(SelfService.GetWord("sel_ext_d"), MsgBoxStyle.Information);
						}
					}
				}
				else
				{
					num = 23;
					if (tlv.SelectedItems.Count < 1)
					{
						num = 24;
						Interaction.MsgBox(SelfService.GetWord("ext_edit"), MsgBoxStyle.Information);
					}
					else
					{
						while (true)
						{
							num = 26;
							string text = Interaction.InputBox(SelfService.GetWord("edit_ext"), "", tlv.SelectedItems[0].Text).Trim().ToLower();
							num = 27;
							if (text.Length < 1)
							{
								break;
							}
							num = 29;
							if (checkExts(text, edit: true))
							{
								string text2;
								do
								{
									num = 31;
									text2 = Interaction.InputBox(SelfService.GetWord("desc_type") + "\r\n" + text, "", tlv.SelectedItems[0].SubItems[1].Text).Trim();
									num = 32;
								}
								while (text2.Length < 1);
								num = 34;
								My.MySettingsProperty.Settings.types = My.MySettingsProperty.Settings.types.Replace("|U:" + tlv.SelectedItems[0].SubItems[1].Text + ":" + tlv.SelectedItems[0].Text.Substring(1), "|U:" + text2 + ":" + text.Substring(1));
								num = 35;
								SelfService.UpdateExts();
								num = 36;
								My.MySettingsProperty.Settings.Save();
								num = 37;
								tlv.SelectedItems[0].Text = text;
								num = 38;
								tlv.SelectedItems[0].SubItems[1].Text = text2;
								break;
							}
						}
					}
				}
			}
			else
			{
				num = 5;
				string text3 = string.Empty;
				while (true)
				{
					num = 6;
					text3 = Interaction.InputBox(SelfService.GetWord("input_ext"), "", text3).Trim().ToLower();
					num = 7;
					if (text3.Length < 1)
					{
						break;
					}
					num = 9;
					if (checkExts(text3))
					{
						string text4;
						do
						{
							num = 11;
							text4 = Interaction.InputBox(SelfService.GetWord("desc_type") + "\r\n" + text3).Trim();
							num = 12;
						}
						while (text4.Length < 1);
						num = 14;
						ListViewItem listViewItem = tlv.Items.Add(text3);
						num = 15;
						listViewItem.SubItems.Add(text4);
						num = 16;
						listViewItem.SubItems.Add(SelfService.GetWord("no"));
						num = 17;
						listViewItem.Selected = true;
						num = 18;
						tlv.TopItem = listViewItem;
						num = 19;
						My.MySettings settings;
						(settings = My.MySettingsProperty.Settings).types = settings.types + "|U:" + text4 + ":" + text3.Substring(1);
						num = 20;
						SelfService.UpdateExts();
						num = 21;
						My.MySettingsProperty.Settings.Save();
						break;
					}
				}
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_05a8: Could not find block for branch target IL_0578*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private bool checkExts(string exts, bool edit = false)
	{
		//Discarded unreachable code: IL_027f, IL_0311, IL_0313, IL_0323, IL_0345
		int num2 = default(int);
		bool result = false;
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
			if (exts.Length < 2)
			{
				goto IL_025f;
			}
			num = 5;
			if (exts.Contains("\\") || exts.Contains("/") || exts.Contains(":") || exts.Contains("*") || exts.Contains("?") || exts.Contains("\"") || exts.Contains("|") || exts.Contains("<") || exts.Contains(">"))
			{
				goto IL_025f;
			}
			num = 7;
			if (Operators.CompareString(exts.Substring(0, 1), ".", TextCompare: false) != 0)
			{
				goto IL_025f;
			}
			num = 9;
			List<string> list = new List<string>();
			num = 10;
			string[] array = exts.Substring(1).Split('.');
			num = 11;
			string[] array2 = array;
			int num3 = 0;
			string text;
			while (true)
			{
				if (num3 >= array2.Length)
				{
					num = 30;
					result = true;
					break;
				}
				text = array2[num3];
				num = 12;
				if (text.Trim().Length >= 1)
				{
					num = 14;
					if (!list.Contains(text))
					{
						num = 17;
						IEnumerator enumerator;
						for (enumerator = tlv.Items.GetEnumerator(); enumerator.MoveNext(); num = 26)
						{
							ListViewItem listViewItem = (ListViewItem)enumerator.Current;
							num = 18;
							if (!(listViewItem.Text.ToLower() + ".").Contains("." + text + "."))
							{
								continue;
							}
							num = 19;
							if (edit)
							{
								num = 20;
								if (listViewItem.Selected)
								{
									continue;
								}
								goto IL_01c6;
							}
							goto IL_01ed;
						}
						num = 27;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						num = 28;
						list.Add(text);
						num = 29;
						num3 = checked(num3 + 1);
						continue;
					}
					goto IL_0134;
				}
				goto IL_025f;
			}
			goto end_IL_0000;
			IL_025f:
			num = 31;
			Interaction.MsgBox(SelfService.GetWord("wrong_pic_ext"), MsgBoxStyle.Information);
			goto IL_0275;
			IL_01ed:
			num = 24;
			Interaction.MsgBox(SelfService.GetWord("ext_exist") + "\r\n" + text, MsgBoxStyle.Information);
			goto IL_0275;
			IL_0134:
			num = 15;
			Interaction.MsgBox(SelfService.GetWord("repeat_ext") + "\r\n" + text, MsgBoxStyle.Information);
			goto IL_0275;
			IL_0275:
			num = 32;
			result = false;
			goto end_IL_0000;
			IL_01c6:
			num = 21;
			Interaction.MsgBox(SelfService.GetWord("ext_exist") + "\r\n" + text, MsgBoxStyle.Information);
			goto IL_0275;
			end_IL_0000:;
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num4 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0343: Could not find block for branch target IL_0313*/;
		}
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void LoadTypes()
	{
		//Discarded unreachable code: IL_0139, IL_017f, IL_0181, IL_0191, IL_01b3
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
			tlv.ListViewItemSorter = null;
			num = 4;
			string[] array = My.MySettingsProperty.Settings.types.Split('|');
			num = 5;
			string[] array2 = array;
			foreach (string text in array2)
			{
				num = 6;
				ListViewItem listViewItem = tlv.Items.Add("." + text.Split(':')[2]);
				num = 7;
				listViewItem.SubItems.Add(text.Split(':')[1]);
				num = 8;
				if (Operators.CompareString(text.Split(':')[0], "P", TextCompare: false) == 0)
				{
					num = 9;
					listViewItem.SubItems.Add(SelfService.GetWord("yes"));
				}
				else
				{
					num = 11;
					listViewItem.SubItems.Add(SelfService.GetWord("no"));
				}
				num = 12;
			}
			num = 13;
			tlv.Items[0].Selected = true;
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_01b1: Could not find block for branch target IL_0181*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void tlv_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//Discarded unreachable code: IL_006e, IL_009c, IL_009e, IL_00ae, IL_00d0
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
			if (tlv.Sorting == SortOrder.Ascending)
			{
				num = 4;
				tlv.Sorting = SortOrder.Descending;
			}
			else
			{
				num = 6;
				tlv.Sorting = SortOrder.Ascending;
			}
			num = 7;
			tlv.ListViewItemSorter = new ListViewItemComparer(e.Column, tlv.Sorting);
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_00ce: Could not find block for branch target IL_009e*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public Types()
	{
		//Discarded unreachable code: IL_0187, IL_01d5, IL_01d7, IL_01e7, IL_0209
		base.KeyUp += Me_KeyUp;
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
				InitializeComponent();
				num = 4;
				if (Operators.CompareString(My.MySettingsProperty.Settings.lang, "ar", TextCompare: false) == 0)
				{
					num = 5;
					RightToLeft = RightToLeft.Yes;
				}
				else
				{
					num = 7;
					RightToLeft = RightToLeft.No;
				}
				num = 8;
				LoadTypes();
				num = 9;
				LoadLangText();
				num = 10;
				int num3 = tlv.Width - tlv.Columns[0].Width - tlv.Columns[1].Width - tlv.Columns[2].Width;
				num = 11;
				if (num3 > 40)
				{
					num = 12;
					num3 -= 40;
					num = 13;
					tlv.Columns[0].Width += (int)Math.Round((double)num3 * 0.4);
					num = 14;
					tlv.Columns[1].Width += (int)Math.Round((double)num3 * 0.4);
					num = 15;
					tlv.Columns[2].Width += (int)Math.Round((double)num3 * 0.2);
				}
			}
			catch (Exception obj) when ((obj is Exception && num2 != 0) & (num4 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_0207: Could not find block for branch target IL_01d7*/;
			}
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}

	private void tlv_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
	{
		//Discarded unreachable code: IL_008c, IL_00c2, IL_00c4, IL_00d4, IL_00f6
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
			if (e.IsSelected)
			{
				num = 4;
				if (Operators.CompareString(e.Item.SubItems[2].Text, SelfService.GetWord("yes"), TextCompare: false) == 0)
				{
					num = 5;
					lEdit.Enabled = false;
					num = 6;
					lDel.Enabled = false;
				}
				else
				{
					num = 8;
					lEdit.Enabled = true;
					num = 9;
					lDel.Enabled = true;
				}
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_00f4: Could not find block for branch target IL_00c4*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void lv_DoubleClick(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_003b, IL_005d, IL_005f, IL_006f, IL_0091
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
			if (lEdit.Enabled)
			{
				num = 4;
				Buttons_Click(lEdit, e);
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_008f: Could not find block for branch target IL_005f*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Me_KeyUp(object sender, KeyEventArgs e)
	{
		//Discarded unreachable code: IL_00a8, IL_00f2, IL_00f4, IL_0104, IL_0126
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
			if (e.Control)
			{
				num = 4;
				switch (e.KeyCode)
				{
				case Keys.N:
					num = 6;
					Buttons_Click(lAdd, new EventArgs());
					break;
				case Keys.E:
					num = 8;
					if (lEdit.Enabled)
					{
						num = 9;
						Buttons_Click(lEdit, new EventArgs());
					}
					break;
				}
			}
			else
			{
				num = 12;
				if (e.KeyCode == Keys.Delete)
				{
					num = 13;
					if (lDel.Enabled)
					{
						num = 14;
						Buttons_Click(lDel, new EventArgs());
					}
				}
			}
		}
		catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
		{
			ProjectData.SetProjectError((Exception)obj);
			/*Error near IL_0124: Could not find block for branch target IL_00f4*/;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void LoadLangText()
	{
		//Discarded unreachable code: IL_029a, IL_0328, IL_032a, IL_033a, IL_035c
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
				}
				num = 12;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				num = 13;
				IEnumerator enumerator2 = tlv.Columns.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					ColumnHeader columnHeader = (ColumnHeader)enumerator2.Current;
					num = 14;
					columnHeader.Text = SelfService.GetWord(columnHeader.Tag.ToString());
					num = 15;
				}
				num = 16;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				num = 17;
				lAdd.AutoSize = true;
				num = 18;
				int width = lAdd.Width + 32;
				num = 19;
				lAdd.AutoSize = false;
				num = 20;
				lAdd.Size = new Size(width, 27);
				num = 21;
				lEdit.AutoSize = true;
				num = 22;
				width = lEdit.Width + 32;
				num = 23;
				lEdit.AutoSize = false;
				num = 24;
				lEdit.Size = new Size(width, 27);
				num = 25;
				lDel.AutoSize = true;
				num = 26;
				width = lDel.Width + 32;
				num = 27;
				lDel.AutoSize = false;
				num = 28;
				lDel.Size = new Size(width, 27);
				num = 29;
				lDel.Left = tlv.Left + tlv.Width - lDel.Width;
				num = 30;
				lEdit.Left = lDel.Left - 9 - lEdit.Width;
				num = 31;
				lAdd.Left = lEdit.Left - 9 - lAdd.Width;
			}
			catch (Exception obj) when ((obj is Exception && num2 != 0) & (num3 == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				/*Error near IL_035a: Could not find block for branch target IL_032a*/;
			}
			if (num3 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}
}
