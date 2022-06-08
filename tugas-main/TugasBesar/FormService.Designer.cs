
namespace TugasBesar
{
    partial class FormService
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
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxBiaya = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDaftar = new System.Windows.Forms.DataGridView();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxIDService = new System.Windows.Forms.TextBox();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(355, 202);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(264, 26);
            this.textBoxTotal.TabIndex = 24;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.Location = new System.Drawing.Point(286, 4);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.ReadOnly = true;
            this.textBoxNama.Size = new System.Drawing.Size(476, 26);
            this.textBoxNama.TabIndex = 12;
            this.textBoxNama.Click += new System.EventHandler(this.textBoxNama_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nama Service";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.86956F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.13044F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxNama, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBiaya, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(73, 98);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(767, 74);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // textBoxBiaya
            // 
            this.textBoxBiaya.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBiaya.Location = new System.Drawing.Point(286, 41);
            this.textBoxBiaya.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBiaya.Name = "textBoxBiaya";
            this.textBoxBiaya.ReadOnly = true;
            this.textBoxBiaya.Size = new System.Drawing.Size(476, 26);
            this.textBoxBiaya.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Biaya";
            // 
            // dataGridViewDaftar
            // 
            this.dataGridViewDaftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftar.Location = new System.Drawing.Point(17, 278);
            this.dataGridViewDaftar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDaftar.Name = "dataGridViewDaftar";
            this.dataGridViewDaftar.RowHeadersWidth = 51;
            this.dataGridViewDaftar.Size = new System.Drawing.Size(879, 201);
            this.dataGridViewDaftar.TabIndex = 22;
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(16, 12);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(165, 27);
            this.buttonNew.TabIndex = 21;
            this.buttonNew.Text = "New Transaksi";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(736, 202);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 27);
            this.buttonSubmit.TabIndex = 20;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxIDService
            // 
            this.textBoxIDService.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDService.Location = new System.Drawing.Point(189, 14);
            this.textBoxIDService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIDService.Name = "textBoxIDService";
            this.textBoxIDService.ReadOnly = true;
            this.textBoxIDService.Size = new System.Drawing.Size(261, 26);
            this.textBoxIDService.TabIndex = 17;
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Enabled = false;
            this.dateTimePickerTanggal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(585, 14);
            this.dateTimePickerTanggal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(309, 26);
            this.dateTimePickerTanggal.TabIndex = 18;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Enabled = false;
            this.buttonTambah.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(628, 202);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(100, 27);
            this.buttonTambah.TabIndex = 19;
            this.buttonTambah.Text = "Add";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonCetak
            // 
            this.buttonCetak.Enabled = false;
            this.buttonCetak.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.Location = new System.Drawing.Point(80, 202);
            this.buttonCetak.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(100, 27);
            this.buttonCetak.TabIndex = 25;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = true;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 491);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridViewDaftar);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxIDService);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.buttonTambah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormService";
            this.Text = "FormService";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxBiaya;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDaftar;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxIDService;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonCetak;
    }
}