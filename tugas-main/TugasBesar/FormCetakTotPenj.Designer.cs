namespace TugasBesar
{
    partial class FormCetakTotPenj
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
            this.crystalReportViewerTotPenj = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerTotPenj
            // 
            this.crystalReportViewerTotPenj.ActiveViewIndex = -1;
            this.crystalReportViewerTotPenj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerTotPenj.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerTotPenj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerTotPenj.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerTotPenj.Name = "crystalReportViewerTotPenj";
            this.crystalReportViewerTotPenj.Size = new System.Drawing.Size(1128, 578);
            this.crystalReportViewerTotPenj.TabIndex = 0;
            this.crystalReportViewerTotPenj.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewerTotPenj.Load += new System.EventHandler(this.crystalReportViewerTotPenj_Load);
            // 
            // FormCetakTotPenj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 578);
            this.Controls.Add(this.crystalReportViewerTotPenj);
            this.Name = "FormCetakTotPenj";
            this.Text = "FormCetakTotPenj";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerTotPenj;
    }
}