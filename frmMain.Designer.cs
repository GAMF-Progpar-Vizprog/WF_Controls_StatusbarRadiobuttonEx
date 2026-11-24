
namespace WF_Controls_StatusbarRadiobuttonEx
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			ssStatusbar = new System.Windows.Forms.StatusStrip();
			tssFirst = new System.Windows.Forms.ToolStripStatusLabel();
			tssSecond = new System.Windows.Forms.ToolStripStatusLabel();
			tssThird = new System.Windows.Forms.ToolStripStatusLabel();
			tssFourth = new System.Windows.Forms.ToolStripStatusLabel();
			label1 = new System.Windows.Forms.Label();
			gbPanelSelection = new System.Windows.Forms.GroupBox();
			rbFourth = new System.Windows.Forms.RadioButton();
			rbThird = new System.Windows.Forms.RadioButton();
			rbSecond = new System.Windows.Forms.RadioButton();
			tbText = new System.Windows.Forms.TextBox();
			btAssign = new System.Windows.Forms.Button();
			tmClock = new System.Windows.Forms.Timer(components);
			ssStatusbar.SuspendLayout();
			gbPanelSelection.SuspendLayout();
			SuspendLayout();
			// 
			// ssStatusbar
			// 
			ssStatusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tssFirst, tssSecond, tssThird, tssFourth });
			ssStatusbar.Location = new System.Drawing.Point(0, 205);
			ssStatusbar.Name = "ssStatusbar";
			ssStatusbar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
			ssStatusbar.Size = new System.Drawing.Size(525, 22);
			ssStatusbar.TabIndex = 0;
			ssStatusbar.Text = "statusStrip1";
			// 
			// tssFirst
			// 
			tssFirst.AutoSize = false;
			tssFirst.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			tssFirst.Name = "tssFirst";
			tssFirst.Size = new System.Drawing.Size(100, 17);
			tssFirst.Text = " ";
			// 
			// tssSecond
			// 
			tssSecond.AutoSize = false;
			tssSecond.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			tssSecond.Name = "tssSecond";
			tssSecond.Size = new System.Drawing.Size(100, 17);
			tssSecond.Text = " ";
			// 
			// tssThird
			// 
			tssThird.AutoSize = false;
			tssThird.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			tssThird.Name = "tssThird";
			tssThird.Size = new System.Drawing.Size(100, 17);
			tssThird.Text = " ";
			// 
			// tssFourth
			// 
			tssFourth.AutoSize = false;
			tssFourth.Name = "tssFourth";
			tssFourth.Size = new System.Drawing.Size(100, 17);
			tssFourth.Text = "  ";
			// 
			// label1
			// 
			label1.Location = new System.Drawing.Point(15, 15);
			label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(440, 47);
			label1.TabIndex = 1;
			label1.Text = "Clicking the button will assign the value in the text box to the selected panel of the status bar.";
			// 
			// gbPanelSelection
			// 
			gbPanelSelection.Controls.Add(rbFourth);
			gbPanelSelection.Controls.Add(rbThird);
			gbPanelSelection.Controls.Add(rbSecond);
			gbPanelSelection.Location = new System.Drawing.Point(14, 66);
			gbPanelSelection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			gbPanelSelection.Name = "gbPanelSelection";
			gbPanelSelection.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			gbPanelSelection.Size = new System.Drawing.Size(115, 115);
			gbPanelSelection.TabIndex = 5;
			gbPanelSelection.TabStop = false;
			gbPanelSelection.Text = "Panel selection";
			// 
			// rbFourth
			// 
			rbFourth.AutoSize = true;
			rbFourth.Location = new System.Drawing.Point(7, 76);
			rbFourth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			rbFourth.Name = "rbFourth";
			rbFourth.Size = new System.Drawing.Size(92, 19);
			rbFourth.TabIndex = 0;
			rbFourth.Text = "Fourth panel";
			rbFourth.UseVisualStyleBackColor = true;
			rbFourth.CheckedChanged += rb_CheckedChanged;
			// 
			// rbThird
			// 
			rbThird.AutoSize = true;
			rbThird.Location = new System.Drawing.Point(7, 50);
			rbThird.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			rbThird.Name = "rbThird";
			rbThird.Size = new System.Drawing.Size(84, 19);
			rbThird.TabIndex = 0;
			rbThird.Text = "Third panel";
			rbThird.UseVisualStyleBackColor = true;
			rbThird.CheckedChanged += rb_CheckedChanged;
			// 
			// rbSecond
			// 
			rbSecond.AutoSize = true;
			rbSecond.Checked = true;
			rbSecond.Location = new System.Drawing.Point(7, 22);
			rbSecond.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			rbSecond.Name = "rbSecond";
			rbSecond.Size = new System.Drawing.Size(96, 19);
			rbSecond.TabIndex = 0;
			rbSecond.TabStop = true;
			rbSecond.Text = "Second panel";
			rbSecond.UseVisualStyleBackColor = true;
			rbSecond.CheckedChanged += rb_CheckedChanged;
			// 
			// tbText
			// 
			tbText.Location = new System.Drawing.Point(150, 87);
			tbText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			tbText.Name = "tbText";
			tbText.Size = new System.Drawing.Size(150, 23);
			tbText.TabIndex = 7;
			// 
			// btAssign
			// 
			btAssign.Location = new System.Drawing.Point(180, 138);
			btAssign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btAssign.Name = "btAssign";
			btAssign.Size = new System.Drawing.Size(88, 27);
			btAssign.TabIndex = 6;
			btAssign.Text = "Assign";
			btAssign.Click += btAssign_Click;
			// 
			// tmClock
			// 
			tmClock.Tick += tmClock_Tick;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(525, 227);
			Controls.Add(tbText);
			Controls.Add(btAssign);
			Controls.Add(gbPanelSelection);
			Controls.Add(label1);
			Controls.Add(ssStatusbar);
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "frmMain";
			Text = "Using the statusbar";
			FormClosing += frmMain_FormClosing;
			ssStatusbar.ResumeLayout(false);
			ssStatusbar.PerformLayout();
			gbPanelSelection.ResumeLayout(false);
			gbPanelSelection.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.StatusStrip ssStatusbar;
    private System.Windows.Forms.ToolStripStatusLabel tssFirst;
    private System.Windows.Forms.ToolStripStatusLabel tssSecond;
    private System.Windows.Forms.ToolStripStatusLabel tssThird;
    private System.Windows.Forms.ToolStripStatusLabel tssFourth;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox gbPanelSelection;
    private System.Windows.Forms.RadioButton rbFourth;
    private System.Windows.Forms.RadioButton rbThird;
    private System.Windows.Forms.RadioButton rbSecond;
    private System.Windows.Forms.TextBox tbText;
    private System.Windows.Forms.Button btAssign;
    private System.Windows.Forms.Timer tmClock;

  }
}

