namespace TugasBesar
{
    partial class FormCetakPenjualan
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
            this.crystalReportViewerPenjualan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerPenjualan
            // 
            this.crystalReportViewerPenjualan.ActiveViewIndex = -1;
            this.crystalReportViewerPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerPenjualan.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerPenjualan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerPenjualan.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerPenjualan.Name = "crystalReportViewerPenjualan";
            this.crystalReportViewerPenjualan.Size = new System.Drawing.Size(1128, 578);
            this.crystalReportViewerPenjualan.TabIndex = 0;
            this.crystalReportViewerPenjualan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewerPenjualan.Load += new System.EventHandler(this.crystalReportViewerPenjualan_Load);
            // 
            // FormCetakPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 578);
            this.Controls.Add(this.crystalReportViewerPenjualan);
            this.Name = "FormCetakPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCetakPenjualan";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerPenjualan;
    }
}