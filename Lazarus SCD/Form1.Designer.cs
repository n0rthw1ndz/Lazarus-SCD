namespace Lazarus_SCD
{
    partial class FRM_MAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MAIN));
            this.MM_STRIP = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRDTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontsColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEX2CODEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_STRIP = new System.Windows.Forms.ToolStrip();
            this.BTN_OPEN = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_H2B = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_DEBUG = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_EXE = new System.Windows.Forms.ToolStripButton();
            this.STATUS_STRIP = new System.Windows.Forms.StatusStrip();
            this.LBL_FILE = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBL_STATUS = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBL_SELECTED_SZ = new System.Windows.Forms.ToolStripStatusLabel();
            this.FILE_DLG = new System.Windows.Forms.OpenFileDialog();
            this.LST_CODE = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LB_SCD = new System.Windows.Forms.ListBox();
            this.LST_BYTE = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OPCODE_DESC = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openEXEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MM_STRIP.SuspendLayout();
            this.BTN_STRIP.SuspendLayout();
            this.STATUS_STRIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // MM_STRIP
            // 
            this.MM_STRIP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MM_STRIP.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MM_STRIP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MM_STRIP.Location = new System.Drawing.Point(0, 0);
            this.MM_STRIP.Name = "MM_STRIP";
            this.MM_STRIP.Size = new System.Drawing.Size(1846, 26);
            this.MM_STRIP.TabIndex = 0;
            this.MM_STRIP.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRDTToolStripMenuItem,
            this.openSCDToolStripMenuItem,
            this.openEXEToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openRDTToolStripMenuItem
            // 
            this.openRDTToolStripMenuItem.Name = "openRDTToolStripMenuItem";
            this.openRDTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openRDTToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.openRDTToolStripMenuItem.Text = "Open . RDT";
            this.openRDTToolStripMenuItem.Click += new System.EventHandler(this.openRDTToolStripMenuItem_Click);
            // 
            // openSCDToolStripMenuItem
            // 
            this.openSCDToolStripMenuItem.Name = "openSCDToolStripMenuItem";
            this.openSCDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.openSCDToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.openSCDToolStripMenuItem.Text = "Open . SCD";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontsColoursToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.hEX2CODEToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // fontsColoursToolStripMenuItem
            // 
            this.fontsColoursToolStripMenuItem.Name = "fontsColoursToolStripMenuItem";
            this.fontsColoursToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.fontsColoursToolStripMenuItem.Text = "Fonts & Colors";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // hEX2CODEToolStripMenuItem
            // 
            this.hEX2CODEToolStripMenuItem.Name = "hEX2CODEToolStripMenuItem";
            this.hEX2CODEToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.hEX2CODEToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.hEX2CODEToolStripMenuItem.Text = "HEX 2 CODE";
            this.hEX2CODEToolStripMenuItem.Click += new System.EventHandler(this.hEX2CODEToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BTN_STRIP
            // 
            this.BTN_STRIP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_STRIP.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.BTN_STRIP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_OPEN,
            this.toolStripSeparator1,
            this.BTN_H2B,
            this.toolStripSeparator2,
            this.BTN_DEBUG,
            this.toolStripSeparator3,
            this.BTN_EXE});
            this.BTN_STRIP.Location = new System.Drawing.Point(0, 26);
            this.BTN_STRIP.Name = "BTN_STRIP";
            this.BTN_STRIP.Size = new System.Drawing.Size(1846, 37);
            this.BTN_STRIP.TabIndex = 1;
            this.BTN_STRIP.Text = "toolStrip1";
            // 
            // BTN_OPEN
            // 
            this.BTN_OPEN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_OPEN.Image = ((System.Drawing.Image)(resources.GetObject("BTN_OPEN.Image")));
            this.BTN_OPEN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_OPEN.Name = "BTN_OPEN";
            this.BTN_OPEN.Size = new System.Drawing.Size(34, 34);
            this.BTN_OPEN.Text = "toolStripButton1";
            this.BTN_OPEN.Click += new System.EventHandler(this.BTN_OPEN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // BTN_H2B
            // 
            this.BTN_H2B.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_H2B.Image = ((System.Drawing.Image)(resources.GetObject("BTN_H2B.Image")));
            this.BTN_H2B.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_H2B.Name = "BTN_H2B";
            this.BTN_H2B.Size = new System.Drawing.Size(34, 34);
            this.BTN_H2B.Text = "toolStripButton2";
            this.BTN_H2B.Click += new System.EventHandler(this.BTN_H2B_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // BTN_DEBUG
            // 
            this.BTN_DEBUG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_DEBUG.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DEBUG.Image")));
            this.BTN_DEBUG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_DEBUG.Name = "BTN_DEBUG";
            this.BTN_DEBUG.Size = new System.Drawing.Size(34, 34);
            this.BTN_DEBUG.Text = "toolStripButton3";
            this.BTN_DEBUG.Click += new System.EventHandler(this.BTN_DEBUG_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // BTN_EXE
            // 
            this.BTN_EXE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTN_EXE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_EXE.Image")));
            this.BTN_EXE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_EXE.Name = "BTN_EXE";
            this.BTN_EXE.Size = new System.Drawing.Size(34, 34);
            this.BTN_EXE.Text = "toolStripButton1";
            this.BTN_EXE.Click += new System.EventHandler(this.BTN_EXE_Click);
            // 
            // STATUS_STRIP
            // 
            this.STATUS_STRIP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBL_FILE,
            this.LBL_STATUS,
            this.LBL_SELECTED_SZ});
            this.STATUS_STRIP.Location = new System.Drawing.Point(0, 825);
            this.STATUS_STRIP.Name = "STATUS_STRIP";
            this.STATUS_STRIP.Size = new System.Drawing.Size(1846, 23);
            this.STATUS_STRIP.TabIndex = 2;
            this.STATUS_STRIP.Text = "statusStrip1";
            // 
            // LBL_FILE
            // 
            this.LBL_FILE.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F);
            this.LBL_FILE.Name = "LBL_FILE";
            this.LBL_FILE.Size = new System.Drawing.Size(38, 18);
            this.LBL_FILE.Text = "RDT";
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(68, 18);
            this.LBL_STATUS.Text = "Status";
            // 
            // LBL_SELECTED_SZ
            // 
            this.LBL_SELECTED_SZ.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F);
            this.LBL_SELECTED_SZ.Name = "LBL_SELECTED_SZ";
            this.LBL_SELECTED_SZ.Size = new System.Drawing.Size(78, 18);
            this.LBL_SELECTED_SZ.Text = "SEL SZ:";
            // 
            // FILE_DLG
            // 
            this.FILE_DLG.FileName = "openFileDialog1";
            this.FILE_DLG.FileOk += new System.ComponentModel.CancelEventHandler(this.FILE_DLG_FileOk);
            // 
            // LST_CODE
            // 
            this.LST_CODE.BackColor = System.Drawing.SystemColors.WindowText;
            this.LST_CODE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LST_CODE.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F);
            this.LST_CODE.ForeColor = System.Drawing.Color.White;
            this.LST_CODE.FullRowSelect = true;
            this.LST_CODE.HideSelection = false;
            this.LST_CODE.Location = new System.Drawing.Point(146, 159);
            this.LST_CODE.MultiSelect = false;
            this.LST_CODE.Name = "LST_CODE";
            this.LST_CODE.Size = new System.Drawing.Size(1760, 830);
            this.LST_CODE.TabIndex = 3;
            this.LST_CODE.UseCompatibleStateImageBehavior = false;
            this.LST_CODE.View = System.Windows.Forms.View.Details;
            this.LST_CODE.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Line";
            this.columnHeader1.Width = 196;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Interpreted Code";
            this.columnHeader2.Width = 339;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Comments";
            this.columnHeader3.Width = 104;
            // 
            // LB_SCD
            // 
            this.LB_SCD.BackColor = System.Drawing.SystemColors.WindowText;
            this.LB_SCD.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F);
            this.LB_SCD.ForeColor = System.Drawing.Color.White;
            this.LB_SCD.FormattingEnabled = true;
            this.LB_SCD.ItemHeight = 18;
            this.LB_SCD.Location = new System.Drawing.Point(0, 159);
            this.LB_SCD.Name = "LB_SCD";
            this.LB_SCD.Size = new System.Drawing.Size(140, 814);
            this.LB_SCD.TabIndex = 5;
            this.LB_SCD.SelectedIndexChanged += new System.EventHandler(this.LB_SCD_SelectedIndexChanged);
            // 
            // LST_BYTE
            // 
            this.LST_BYTE.BackColor = System.Drawing.SystemColors.WindowText;
            this.LST_BYTE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LST_BYTE.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F);
            this.LST_BYTE.ForeColor = System.Drawing.Color.White;
            this.LST_BYTE.FullRowSelect = true;
            this.LST_BYTE.HideSelection = false;
            this.LST_BYTE.Location = new System.Drawing.Point(146, 160);
            this.LST_BYTE.MultiSelect = false;
            this.LST_BYTE.Name = "LST_BYTE";
            this.LST_BYTE.Size = new System.Drawing.Size(1760, 830);
            this.LST_BYTE.TabIndex = 6;
            this.LST_BYTE.UseCompatibleStateImageBehavior = false;
            this.LST_BYTE.View = System.Windows.Forms.View.Details;
            this.LST_BYTE.SelectedIndexChanged += new System.EventHandler(this.LST_BYTE_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Line";
            this.columnHeader4.Width = 196;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "BYTE STR";
            this.columnHeader5.Width = 339;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "LENGTH";
            this.columnHeader6.Width = 104;
            // 
            // OPCODE_DESC
            // 
            this.OPCODE_DESC.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.OPCODE_DESC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OPCODE_DESC.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F);
            this.OPCODE_DESC.ForeColor = System.Drawing.Color.AliceBlue;
            this.OPCODE_DESC.Location = new System.Drawing.Point(2, 91);
            this.OPCODE_DESC.Name = "OPCODE_DESC";
            this.OPCODE_DESC.Size = new System.Drawing.Size(1937, 62);
            this.OPCODE_DESC.TabIndex = 7;
            this.OPCODE_DESC.Text = "Description Box for Selected Opcode";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(-3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1942, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "CODE DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openEXEToolStripMenuItem
            // 
            this.openEXEToolStripMenuItem.Name = "openEXEToolStripMenuItem";
            this.openEXEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.openEXEToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.openEXEToolStripMenuItem.Text = "Open . EXE";
            this.openEXEToolStripMenuItem.Click += new System.EventHandler(this.openEXEToolStripMenuItem_Click);
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1846, 848);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OPCODE_DESC);
            this.Controls.Add(this.STATUS_STRIP);
            this.Controls.Add(this.BTN_STRIP);
            this.Controls.Add(this.MM_STRIP);
            this.Controls.Add(this.LB_SCD);
            this.Controls.Add(this.LST_CODE);
            this.Controls.Add(this.LST_BYTE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MM_STRIP;
            this.Name = "FRM_MAIN";
            this.Text = "LAZARUS SCD VIEW v0.0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MM_STRIP.ResumeLayout(false);
            this.MM_STRIP.PerformLayout();
            this.BTN_STRIP.ResumeLayout(false);
            this.BTN_STRIP.PerformLayout();
            this.STATUS_STRIP.ResumeLayout(false);
            this.STATUS_STRIP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MM_STRIP;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontsColoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRDTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSCDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStrip BTN_STRIP;
        private System.Windows.Forms.StatusStrip STATUS_STRIP;
        private System.Windows.Forms.ToolStripButton BTN_OPEN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTN_H2B;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BTN_DEBUG;
        private System.Windows.Forms.ToolStripStatusLabel LBL_STATUS;
        private System.Windows.Forms.OpenFileDialog FILE_DLG;
        private System.Windows.Forms.ListView LST_CODE;
        private System.Windows.Forms.ListBox LB_SCD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView LST_BYTE;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.RichTextBox OPCODE_DESC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel LBL_FILE;
        private System.Windows.Forms.ToolStripStatusLabel LBL_SELECTED_SZ;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hEX2CODEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BTN_EXE;
        private System.Windows.Forms.ToolStripMenuItem openEXEToolStripMenuItem;
    }
}

