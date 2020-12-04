namespace Lazarus_SCD
{
    partial class FRM_DEBUG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DEBUG));
            this.LV_DEBUG = new System.Windows.Forms.ListView();
            this.DEBUG_LOG = new System.Windows.Forms.RichTextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LV_DEBUG
            // 
            this.LV_DEBUG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LV_DEBUG.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F);
            this.LV_DEBUG.GridLines = true;
            this.LV_DEBUG.HideSelection = false;
            this.LV_DEBUG.Location = new System.Drawing.Point(12, 12);
            this.LV_DEBUG.Name = "LV_DEBUG";
            this.LV_DEBUG.Size = new System.Drawing.Size(490, 538);
            this.LV_DEBUG.TabIndex = 0;
            this.LV_DEBUG.UseCompatibleStateImageBehavior = false;
            this.LV_DEBUG.View = System.Windows.Forms.View.Details;
            this.LV_DEBUG.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // DEBUG_LOG
            // 
            this.DEBUG_LOG.BackColor = System.Drawing.SystemColors.WindowText;
            this.DEBUG_LOG.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F);
            this.DEBUG_LOG.ForeColor = System.Drawing.Color.White;
            this.DEBUG_LOG.Location = new System.Drawing.Point(508, 12);
            this.DEBUG_LOG.Name = "DEBUG_LOG";
            this.DEBUG_LOG.Size = new System.Drawing.Size(451, 538);
            this.DEBUG_LOG.TabIndex = 1;
            this.DEBUG_LOG.Text = "Debug Log.....";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Offset";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Object Desc";
            this.columnHeader3.Width = 148;
            // 
            // FRM_DEBUG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 562);
            this.Controls.Add(this.DEBUG_LOG);
            this.Controls.Add(this.LV_DEBUG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_DEBUG";
            this.Text = "DEBUG FORM";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ListView LV_DEBUG;
        public System.Windows.Forms.RichTextBox DEBUG_LOG;
    }
}