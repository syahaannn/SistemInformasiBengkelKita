namespace TugasBesar
{
    partial class FormLapPenjualan
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
            this.labelPenj = new System.Windows.Forms.Label();
            this.dateTimePickerPenj = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPenj = new System.Windows.Forms.ComboBox();
            this.dataGridViewPenj = new System.Windows.Forms.DataGridView();
            this.buttonCetakPenj = new System.Windows.Forms.Button();
            this.labelServ = new System.Windows.Forms.Label();
            this.buttonCetakServ = new System.Windows.Forms.Button();
            this.dataGridViewServ = new System.Windows.Forms.DataGridView();
            this.comboBoxServ = new System.Windows.Forms.ComboBox();
            this.dateTimePickerServ = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelServ = new System.Windows.Forms.Panel();
            this.buttonTutupServ = new System.Windows.Forms.Button();
            this.panelPenj = new System.Windows.Forms.Panel();
            this.labelTotPenj = new System.Windows.Forms.Label();
            this.panelTotPenj = new System.Windows.Forms.Panel();
            this.buttonCetakTotPenj = new System.Windows.Forms.Button();
            this.dataGridViewTotPenj = new System.Windows.Forms.DataGridView();
            this.textBoxTotPenj = new System.Windows.Forms.TextBox();
            this.dateTimePickerTotPenj2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTotPenj1 = new System.Windows.Forms.DateTimePicker();
            this.labelTotServ = new System.Windows.Forms.Label();
            this.panelTotServ = new System.Windows.Forms.Panel();
            this.buttonCetakTotServ = new System.Windows.Forms.Button();
            this.dataGridViewTotServ = new System.Windows.Forms.DataGridView();
            this.dateTimePickerTotServ2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTotServ1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxTotServ = new System.Windows.Forms.TextBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.buttonTutupPenj = new System.Windows.Forms.Button();
            this.buttonTutupTotPenj = new System.Windows.Forms.Button();
            this.buttonTutupTotServ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServ)).BeginInit();
            this.panelServ.SuspendLayout();
            this.panelPenj.SuspendLayout();
            this.panelTotPenj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotPenj)).BeginInit();
            this.panelTotServ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotServ)).BeginInit();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPenj
            // 
            this.labelPenj.AutoSize = true;
            this.labelPenj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPenj.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenj.Location = new System.Drawing.Point(40, 22);
            this.labelPenj.Name = "labelPenj";
            this.labelPenj.Size = new System.Drawing.Size(145, 21);
            this.labelPenj.TabIndex = 0;
            this.labelPenj.Text = "Laporan penjualan";
            this.labelPenj.Click += new System.EventHandler(this.labelPenj_Click);
            // 
            // dateTimePickerPenj
            // 
            this.dateTimePickerPenj.Location = new System.Drawing.Point(390, 23);
            this.dateTimePickerPenj.Name = "dateTimePickerPenj";
            this.dateTimePickerPenj.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerPenj.TabIndex = 0;
            this.dateTimePickerPenj.ValueChanged += new System.EventHandler(this.dateTimePickerPenj_ValueChanged);
            // 
            // comboBoxPenj
            // 
            this.comboBoxPenj.FormattingEnabled = true;
            this.comboBoxPenj.Location = new System.Drawing.Point(34, 21);
            this.comboBoxPenj.Name = "comboBoxPenj";
            this.comboBoxPenj.Size = new System.Drawing.Size(159, 24);
            this.comboBoxPenj.TabIndex = 1;
            this.comboBoxPenj.SelectedIndexChanged += new System.EventHandler(this.comboBoxPenj_SelectedIndexChanged);
            // 
            // dataGridViewPenj
            // 
            this.dataGridViewPenj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPenj.Location = new System.Drawing.Point(3, 86);
            this.dataGridViewPenj.Name = "dataGridViewPenj";
            this.dataGridViewPenj.RowHeadersWidth = 51;
            this.dataGridViewPenj.RowTemplate.Height = 24;
            this.dataGridViewPenj.Size = new System.Drawing.Size(741, 179);
            this.dataGridViewPenj.TabIndex = 2;
            // 
            // buttonCetakPenj
            // 
            this.buttonCetakPenj.Location = new System.Drawing.Point(573, 271);
            this.buttonCetakPenj.Name = "buttonCetakPenj";
            this.buttonCetakPenj.Size = new System.Drawing.Size(81, 30);
            this.buttonCetakPenj.TabIndex = 3;
            this.buttonCetakPenj.Text = "Cetak";
            this.buttonCetakPenj.UseVisualStyleBackColor = true;
            this.buttonCetakPenj.Click += new System.EventHandler(this.buttonCetakPenj_Click);
            // 
            // labelServ
            // 
            this.labelServ.AutoSize = true;
            this.labelServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelServ.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServ.Location = new System.Drawing.Point(40, 42);
            this.labelServ.Name = "labelServ";
            this.labelServ.Size = new System.Drawing.Size(125, 21);
            this.labelServ.TabIndex = 2;
            this.labelServ.Text = "Laporan service";
            this.labelServ.Click += new System.EventHandler(this.labelServ_Click);
            // 
            // buttonCetakServ
            // 
            this.buttonCetakServ.Location = new System.Drawing.Point(571, 268);
            this.buttonCetakServ.Name = "buttonCetakServ";
            this.buttonCetakServ.Size = new System.Drawing.Size(81, 30);
            this.buttonCetakServ.TabIndex = 3;
            this.buttonCetakServ.Text = "Cetak";
            this.buttonCetakServ.UseVisualStyleBackColor = true;
            this.buttonCetakServ.Click += new System.EventHandler(this.buttonCetakServ_Click);
            // 
            // dataGridViewServ
            // 
            this.dataGridViewServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServ.Location = new System.Drawing.Point(3, 83);
            this.dataGridViewServ.Name = "dataGridViewServ";
            this.dataGridViewServ.RowHeadersWidth = 51;
            this.dataGridViewServ.RowTemplate.Height = 24;
            this.dataGridViewServ.Size = new System.Drawing.Size(741, 179);
            this.dataGridViewServ.TabIndex = 2;
            // 
            // comboBoxServ
            // 
            this.comboBoxServ.FormattingEnabled = true;
            this.comboBoxServ.Location = new System.Drawing.Point(34, 24);
            this.comboBoxServ.Name = "comboBoxServ";
            this.comboBoxServ.Size = new System.Drawing.Size(159, 24);
            this.comboBoxServ.TabIndex = 1;
            this.comboBoxServ.SelectedIndexChanged += new System.EventHandler(this.comboBoxServ_SelectedIndexChanged);
            // 
            // dateTimePickerServ
            // 
            this.dateTimePickerServ.Location = new System.Drawing.Point(430, 24);
            this.dateTimePickerServ.Name = "dateTimePickerServ";
            this.dateTimePickerServ.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerServ.TabIndex = 0;
            this.dateTimePickerServ.ValueChanged += new System.EventHandler(this.dateTimePickerServ_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Laporan penjualan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Laporan service";
            // 
            // panelServ
            // 
            this.panelServ.Controls.Add(this.buttonTutupServ);
            this.panelServ.Controls.Add(this.label2);
            this.panelServ.Controls.Add(this.dataGridViewServ);
            this.panelServ.Controls.Add(this.buttonCetakServ);
            this.panelServ.Controls.Add(this.dateTimePickerServ);
            this.panelServ.Controls.Add(this.comboBoxServ);
            this.panelServ.Location = new System.Drawing.Point(63, 164);
            this.panelServ.Name = "panelServ";
            this.panelServ.Size = new System.Drawing.Size(749, 310);
            this.panelServ.TabIndex = 5;
            this.panelServ.Visible = false;
            // 
            // buttonTutupServ
            // 
            this.buttonTutupServ.Location = new System.Drawing.Point(656, 268);
            this.buttonTutupServ.Name = "buttonTutupServ";
            this.buttonTutupServ.Size = new System.Drawing.Size(81, 30);
            this.buttonTutupServ.TabIndex = 5;
            this.buttonTutupServ.Text = "Tutup";
            this.buttonTutupServ.UseVisualStyleBackColor = true;
            this.buttonTutupServ.Click += new System.EventHandler(this.buttonTutupServ_Click);
            // 
            // panelPenj
            // 
            this.panelPenj.Controls.Add(this.buttonTutupPenj);
            this.panelPenj.Controls.Add(this.label1);
            this.panelPenj.Controls.Add(this.dataGridViewPenj);
            this.panelPenj.Controls.Add(this.buttonCetakPenj);
            this.panelPenj.Controls.Add(this.dateTimePickerPenj);
            this.panelPenj.Controls.Add(this.comboBoxPenj);
            this.panelPenj.Location = new System.Drawing.Point(63, 164);
            this.panelPenj.Name = "panelPenj";
            this.panelPenj.Size = new System.Drawing.Size(749, 310);
            this.panelPenj.TabIndex = 6;
            this.panelPenj.Visible = false;
            // 
            // labelTotPenj
            // 
            this.labelTotPenj.AutoSize = true;
            this.labelTotPenj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTotPenj.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotPenj.Location = new System.Drawing.Point(40, 63);
            this.labelTotPenj.Name = "labelTotPenj";
            this.labelTotPenj.Size = new System.Drawing.Size(183, 21);
            this.labelTotPenj.TabIndex = 7;
            this.labelTotPenj.Text = "Laporan total penjualan";
            this.labelTotPenj.Click += new System.EventHandler(this.labelTotPenj_Click);
            // 
            // panelTotPenj
            // 
            this.panelTotPenj.Controls.Add(this.buttonTutupTotPenj);
            this.panelTotPenj.Controls.Add(this.buttonCetakTotPenj);
            this.panelTotPenj.Controls.Add(this.dataGridViewTotPenj);
            this.panelTotPenj.Controls.Add(this.textBoxTotPenj);
            this.panelTotPenj.Controls.Add(this.dateTimePickerTotPenj2);
            this.panelTotPenj.Controls.Add(this.dateTimePickerTotPenj1);
            this.panelTotPenj.Location = new System.Drawing.Point(63, 164);
            this.panelTotPenj.Name = "panelTotPenj";
            this.panelTotPenj.Size = new System.Drawing.Size(749, 310);
            this.panelTotPenj.TabIndex = 8;
            this.panelTotPenj.Visible = false;
            // 
            // buttonCetakTotPenj
            // 
            this.buttonCetakTotPenj.Location = new System.Drawing.Point(575, 277);
            this.buttonCetakTotPenj.Name = "buttonCetakTotPenj";
            this.buttonCetakTotPenj.Size = new System.Drawing.Size(81, 30);
            this.buttonCetakTotPenj.TabIndex = 5;
            this.buttonCetakTotPenj.Text = "Cetak";
            this.buttonCetakTotPenj.UseVisualStyleBackColor = true;
            this.buttonCetakTotPenj.Click += new System.EventHandler(this.buttonCetakTotPenj_Click);
            // 
            // dataGridViewTotPenj
            // 
            this.dataGridViewTotPenj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotPenj.Location = new System.Drawing.Point(4, 83);
            this.dataGridViewTotPenj.Name = "dataGridViewTotPenj";
            this.dataGridViewTotPenj.RowHeadersWidth = 51;
            this.dataGridViewTotPenj.RowTemplate.Height = 24;
            this.dataGridViewTotPenj.Size = new System.Drawing.Size(740, 188);
            this.dataGridViewTotPenj.TabIndex = 4;
            // 
            // textBoxTotPenj
            // 
            this.textBoxTotPenj.Location = new System.Drawing.Point(34, 36);
            this.textBoxTotPenj.Name = "textBoxTotPenj";
            this.textBoxTotPenj.Size = new System.Drawing.Size(159, 22);
            this.textBoxTotPenj.TabIndex = 3;
            // 
            // dateTimePickerTotPenj2
            // 
            this.dateTimePickerTotPenj2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTotPenj2.Location = new System.Drawing.Point(503, 34);
            this.dateTimePickerTotPenj2.Name = "dateTimePickerTotPenj2";
            this.dateTimePickerTotPenj2.Size = new System.Drawing.Size(123, 22);
            this.dateTimePickerTotPenj2.TabIndex = 2;
            this.dateTimePickerTotPenj2.ValueChanged += new System.EventHandler(this.dateTimePickerTotPenj2_ValueChanged);
            // 
            // dateTimePickerTotPenj1
            // 
            this.dateTimePickerTotPenj1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTotPenj1.Location = new System.Drawing.Point(337, 33);
            this.dateTimePickerTotPenj1.Name = "dateTimePickerTotPenj1";
            this.dateTimePickerTotPenj1.Size = new System.Drawing.Size(123, 22);
            this.dateTimePickerTotPenj1.TabIndex = 1;
            this.dateTimePickerTotPenj1.ValueChanged += new System.EventHandler(this.dateTimePickerTotPenj1_ValueChanged);
            // 
            // labelTotServ
            // 
            this.labelTotServ.AutoSize = true;
            this.labelTotServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTotServ.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotServ.Location = new System.Drawing.Point(40, 83);
            this.labelTotServ.Name = "labelTotServ";
            this.labelTotServ.Size = new System.Drawing.Size(163, 21);
            this.labelTotServ.TabIndex = 9;
            this.labelTotServ.Text = "Laporan total service";
            this.labelTotServ.Click += new System.EventHandler(this.labelTotServ_Click);
            // 
            // panelTotServ
            // 
            this.panelTotServ.Controls.Add(this.buttonTutupTotServ);
            this.panelTotServ.Controls.Add(this.buttonCetakTotServ);
            this.panelTotServ.Controls.Add(this.dataGridViewTotServ);
            this.panelTotServ.Controls.Add(this.dateTimePickerTotServ2);
            this.panelTotServ.Controls.Add(this.dateTimePickerTotServ1);
            this.panelTotServ.Controls.Add(this.textBoxTotServ);
            this.panelTotServ.Location = new System.Drawing.Point(63, 164);
            this.panelTotServ.Name = "panelTotServ";
            this.panelTotServ.Size = new System.Drawing.Size(749, 310);
            this.panelTotServ.TabIndex = 10;
            this.panelTotServ.Visible = false;
            // 
            // buttonCetakTotServ
            // 
            this.buttonCetakTotServ.Location = new System.Drawing.Point(585, 273);
            this.buttonCetakTotServ.Name = "buttonCetakTotServ";
            this.buttonCetakTotServ.Size = new System.Drawing.Size(81, 31);
            this.buttonCetakTotServ.TabIndex = 4;
            this.buttonCetakTotServ.Text = "Cetak";
            this.buttonCetakTotServ.UseVisualStyleBackColor = true;
            this.buttonCetakTotServ.Click += new System.EventHandler(this.buttonCetakTotServ_Click);
            // 
            // dataGridViewTotServ
            // 
            this.dataGridViewTotServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotServ.Location = new System.Drawing.Point(4, 69);
            this.dataGridViewTotServ.Name = "dataGridViewTotServ";
            this.dataGridViewTotServ.RowHeadersWidth = 51;
            this.dataGridViewTotServ.RowTemplate.Height = 24;
            this.dataGridViewTotServ.Size = new System.Drawing.Size(740, 201);
            this.dataGridViewTotServ.TabIndex = 3;
            // 
            // dateTimePickerTotServ2
            // 
            this.dateTimePickerTotServ2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTotServ2.Location = new System.Drawing.Point(503, 25);
            this.dateTimePickerTotServ2.Name = "dateTimePickerTotServ2";
            this.dateTimePickerTotServ2.Size = new System.Drawing.Size(123, 22);
            this.dateTimePickerTotServ2.TabIndex = 2;
            this.dateTimePickerTotServ2.ValueChanged += new System.EventHandler(this.dateTimePickerTotServ2_ValueChanged);
            // 
            // dateTimePickerTotServ1
            // 
            this.dateTimePickerTotServ1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTotServ1.Location = new System.Drawing.Point(337, 25);
            this.dateTimePickerTotServ1.Name = "dateTimePickerTotServ1";
            this.dateTimePickerTotServ1.Size = new System.Drawing.Size(123, 22);
            this.dateTimePickerTotServ1.TabIndex = 1;
            this.dateTimePickerTotServ1.ValueChanged += new System.EventHandler(this.dateTimePickerTotServ1_ValueChanged);
            // 
            // textBoxTotServ
            // 
            this.textBoxTotServ.Location = new System.Drawing.Point(34, 26);
            this.textBoxTotServ.Name = "textBoxTotServ";
            this.textBoxTotServ.Size = new System.Drawing.Size(159, 22);
            this.textBoxTotServ.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelTotServ);
            this.panelContent.Controls.Add(this.panelTotPenj);
            this.panelContent.Controls.Add(this.labelServ);
            this.panelContent.Controls.Add(this.labelPenj);
            this.panelContent.Controls.Add(this.labelTotServ);
            this.panelContent.Controls.Add(this.panelServ);
            this.panelContent.Controls.Add(this.panelPenj);
            this.panelContent.Controls.Add(this.labelTotPenj);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1373, 932);
            this.panelContent.TabIndex = 11;
            // 
            // buttonTutupPenj
            // 
            this.buttonTutupPenj.Location = new System.Drawing.Point(653, 271);
            this.buttonTutupPenj.Name = "buttonTutupPenj";
            this.buttonTutupPenj.Size = new System.Drawing.Size(81, 30);
            this.buttonTutupPenj.TabIndex = 6;
            this.buttonTutupPenj.Text = "Tutup";
            this.buttonTutupPenj.UseVisualStyleBackColor = true;
            this.buttonTutupPenj.Click += new System.EventHandler(this.buttonTutupPenj_Click);
            // 
            // buttonTutupTotPenj
            // 
            this.buttonTutupTotPenj.Location = new System.Drawing.Point(656, 276);
            this.buttonTutupTotPenj.Name = "buttonTutupTotPenj";
            this.buttonTutupTotPenj.Size = new System.Drawing.Size(81, 30);
            this.buttonTutupTotPenj.TabIndex = 6;
            this.buttonTutupTotPenj.Text = "Tutup";
            this.buttonTutupTotPenj.UseVisualStyleBackColor = true;
            this.buttonTutupTotPenj.Click += new System.EventHandler(this.buttonTutupTotPenj_Click);
            // 
            // buttonTutupTotServ
            // 
            this.buttonTutupTotServ.Location = new System.Drawing.Point(666, 272);
            this.buttonTutupTotServ.Name = "buttonTutupTotServ";
            this.buttonTutupTotServ.Size = new System.Drawing.Size(81, 31);
            this.buttonTutupTotServ.TabIndex = 5;
            this.buttonTutupTotServ.Text = "Tutup";
            this.buttonTutupTotServ.UseVisualStyleBackColor = true;
            this.buttonTutupTotServ.Click += new System.EventHandler(this.buttonTutupTotServ_Click);
            // 
            // FormLapPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 932);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLapPenjualan";
            this.Text = "FormLapPenjualan";
            this.Load += new System.EventHandler(this.FormLapPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServ)).EndInit();
            this.panelServ.ResumeLayout(false);
            this.panelServ.PerformLayout();
            this.panelPenj.ResumeLayout(false);
            this.panelPenj.PerformLayout();
            this.panelTotPenj.ResumeLayout(false);
            this.panelTotPenj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotPenj)).EndInit();
            this.panelTotServ.ResumeLayout(false);
            this.panelTotServ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotServ)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPenj;
        private System.Windows.Forms.ComboBox comboBoxPenj;
        private System.Windows.Forms.DateTimePicker dateTimePickerPenj;
        private System.Windows.Forms.DataGridView dataGridViewPenj;
        private System.Windows.Forms.Button buttonCetakPenj;
        private System.Windows.Forms.Button buttonCetakServ;
        private System.Windows.Forms.DataGridView dataGridViewServ;
        private System.Windows.Forms.ComboBox comboBoxServ;
        private System.Windows.Forms.DateTimePicker dateTimePickerServ;
        private System.Windows.Forms.Label labelServ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelServ;
        private System.Windows.Forms.Panel panelPenj;
        private System.Windows.Forms.Label labelTotPenj;
        private System.Windows.Forms.Panel panelTotPenj;
        private System.Windows.Forms.Button buttonCetakTotPenj;
        private System.Windows.Forms.DataGridView dataGridViewTotPenj;
        private System.Windows.Forms.TextBox textBoxTotPenj;
        private System.Windows.Forms.DateTimePicker dateTimePickerTotPenj2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTotPenj1;
        private System.Windows.Forms.Label labelTotServ;
        private System.Windows.Forms.Panel panelTotServ;
        private System.Windows.Forms.Button buttonCetakTotServ;
        private System.Windows.Forms.DataGridView dataGridViewTotServ;
        private System.Windows.Forms.DateTimePicker dateTimePickerTotServ2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTotServ1;
        private System.Windows.Forms.TextBox textBoxTotServ;
        private System.Windows.Forms.Button buttonTutupServ;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button buttonTutupPenj;
        private System.Windows.Forms.Button buttonTutupTotPenj;
        private System.Windows.Forms.Button buttonTutupTotServ;
    }
}