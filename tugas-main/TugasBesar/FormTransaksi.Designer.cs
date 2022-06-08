
namespace TugasBesar
{
    partial class FormTransaksi
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
            this.kryptonButtonPenjualan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelKonten = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.panelKonten.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonButtonPenjualan
            // 
            this.kryptonButtonPenjualan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButtonPenjualan.Location = new System.Drawing.Point(3, 3);
            this.kryptonButtonPenjualan.Name = "kryptonButtonPenjualan";
            this.kryptonButtonPenjualan.Size = new System.Drawing.Size(466, 48);
            this.kryptonButtonPenjualan.TabIndex = 0;
            this.kryptonButtonPenjualan.Values.Text = "PENJUALAN";
            this.kryptonButtonPenjualan.Click += new System.EventHandler(this.kryptonButtonPenjualan_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.labelTitle.Location = new System.Drawing.Point(4, 11);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 34);
            this.labelTitle.TabIndex = 2;
            // 
            // panelKonten
            // 
            this.panelKonten.Controls.Add(this.label);
            this.panelKonten.Controls.Add(this.labelTitle);
            this.panelKonten.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKonten.Location = new System.Drawing.Point(0, 0);
            this.panelKonten.Margin = new System.Windows.Forms.Padding(4);
            this.panelKonten.Name = "panelKonten";
            this.panelKonten.Size = new System.Drawing.Size(934, 536);
            this.panelKonten.TabIndex = 3;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(475, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(456, 48);
            this.kryptonButton1.TabIndex = 2;
            this.kryptonButton1.Values.Text = "SERVICE";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButtonService_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 462F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonButton1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonButtonPenjualan, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 535);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 55);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(166, 174);
            this.label.Name = "label";
            this.label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label.Size = new System.Drawing.Size(574, 45);
            this.label.TabIndex = 22;
            this.label.Text = "SILAHKAN PILIH MENU DIBAWAH";
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 590);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelKonten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.panelKonten.ResumeLayout(false);
            this.panelKonten.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelKonten;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonPenjualan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label;
    }
}