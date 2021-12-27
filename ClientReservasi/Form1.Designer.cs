
namespace ClientReservasi
{
    partial class Form1
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
            this.LabelIDReservasi = new System.Windows.Forms.Label();
            this.LabelNama = new System.Windows.Forms.Label();
            this.LabelNoTelfon = new System.Windows.Forms.Label();
            this.labelJmlPsnan = new System.Windows.Forms.Label();
            this.LabelIdLokasi = new System.Windows.Forms.Label();
            this.TxtBoxIdReservasi = new System.Windows.Forms.TextBox();
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.TxtTelfon = new System.Windows.Forms.TextBox();
            this.TxtJml = new System.Windows.Forms.TextBox();
            this.TxtIdLokasi = new System.Windows.Forms.TextBox();
            this.Btnsimpan = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelIDReservasi
            // 
            this.LabelIDReservasi.AutoSize = true;
            this.LabelIDReservasi.Location = new System.Drawing.Point(48, 73);
            this.LabelIDReservasi.Name = "LabelIDReservasi";
            this.LabelIDReservasi.Size = new System.Drawing.Size(68, 13);
            this.LabelIDReservasi.TabIndex = 0;
            this.LabelIDReservasi.Text = "ID Reservasi";
            // 
            // LabelNama
            // 
            this.LabelNama.AutoSize = true;
            this.LabelNama.Location = new System.Drawing.Point(48, 119);
            this.LabelNama.Name = "LabelNama";
            this.LabelNama.Size = new System.Drawing.Size(35, 13);
            this.LabelNama.TabIndex = 1;
            this.LabelNama.Text = "Nama";
            // 
            // LabelNoTelfon
            // 
            this.LabelNoTelfon.AutoSize = true;
            this.LabelNoTelfon.Location = new System.Drawing.Point(48, 162);
            this.LabelNoTelfon.Name = "LabelNoTelfon";
            this.LabelNoTelfon.Size = new System.Drawing.Size(54, 13);
            this.LabelNoTelfon.TabIndex = 2;
            this.LabelNoTelfon.Text = "No Telfon";
            // 
            // labelJmlPsnan
            // 
            this.labelJmlPsnan.AutoSize = true;
            this.labelJmlPsnan.Location = new System.Drawing.Point(48, 210);
            this.labelJmlPsnan.Name = "labelJmlPsnan";
            this.labelJmlPsnan.Size = new System.Drawing.Size(99, 13);
            this.labelJmlPsnan.TabIndex = 3;
            this.labelJmlPsnan.Text = "Jumlah Pemesanan";
            // 
            // LabelIdLokasi
            // 
            this.LabelIdLokasi.AutoSize = true;
            this.LabelIdLokasi.Location = new System.Drawing.Point(48, 264);
            this.LabelIdLokasi.Name = "LabelIdLokasi";
            this.LabelIdLokasi.Size = new System.Drawing.Size(52, 13);
            this.LabelIdLokasi.TabIndex = 4;
            this.LabelIdLokasi.Text = "ID Lokasi";
            // 
            // TxtBoxIdReservasi
            // 
            this.TxtBoxIdReservasi.Location = new System.Drawing.Point(326, 73);
            this.TxtBoxIdReservasi.Name = "TxtBoxIdReservasi";
            this.TxtBoxIdReservasi.Size = new System.Drawing.Size(199, 20);
            this.TxtBoxIdReservasi.TabIndex = 5;
            this.TxtBoxIdReservasi.TextChanged += new System.EventHandler(this.TxtBoxIdReservasi_TextChanged);
            // 
            // TxtNama
            // 
            this.TxtNama.Location = new System.Drawing.Point(326, 116);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(199, 20);
            this.TxtNama.TabIndex = 6;
            // 
            // TxtTelfon
            // 
            this.TxtTelfon.Location = new System.Drawing.Point(326, 162);
            this.TxtTelfon.Name = "TxtTelfon";
            this.TxtTelfon.Size = new System.Drawing.Size(199, 20);
            this.TxtTelfon.TabIndex = 7;
            // 
            // TxtJml
            // 
            this.TxtJml.Location = new System.Drawing.Point(326, 210);
            this.TxtJml.Name = "TxtJml";
            this.TxtJml.Size = new System.Drawing.Size(199, 20);
            this.TxtJml.TabIndex = 8;
            // 
            // TxtIdLokasi
            // 
            this.TxtIdLokasi.Location = new System.Drawing.Point(326, 264);
            this.TxtIdLokasi.Name = "TxtIdLokasi";
            this.TxtIdLokasi.Size = new System.Drawing.Size(199, 20);
            this.TxtIdLokasi.TabIndex = 9;
            // 
            // Btnsimpan
            // 
            this.Btnsimpan.Location = new System.Drawing.Point(763, 95);
            this.Btnsimpan.Name = "Btnsimpan";
            this.Btnsimpan.Size = new System.Drawing.Size(75, 23);
            this.Btnsimpan.TabIndex = 10;
            this.Btnsimpan.Text = "Simpan";
            this.Btnsimpan.UseVisualStyleBackColor = true;
            this.Btnsimpan.Click += new System.EventHandler(this.Btnsimpan_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(763, 152);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(763, 208);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(763, 262);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 13;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(822, 242);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 591);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.Btnsimpan);
            this.Controls.Add(this.TxtIdLokasi);
            this.Controls.Add(this.TxtJml);
            this.Controls.Add(this.TxtTelfon);
            this.Controls.Add(this.TxtNama);
            this.Controls.Add(this.TxtBoxIdReservasi);
            this.Controls.Add(this.LabelIdLokasi);
            this.Controls.Add(this.labelJmlPsnan);
            this.Controls.Add(this.LabelNoTelfon);
            this.Controls.Add(this.LabelNama);
            this.Controls.Add(this.LabelIDReservasi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelIDReservasi;
        private System.Windows.Forms.Label LabelNama;
        private System.Windows.Forms.Label LabelNoTelfon;
        private System.Windows.Forms.Label labelJmlPsnan;
        private System.Windows.Forms.Label LabelIdLokasi;
        private System.Windows.Forms.TextBox TxtBoxIdReservasi;
        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.TextBox TxtTelfon;
        private System.Windows.Forms.TextBox TxtJml;
        private System.Windows.Forms.TextBox TxtIdLokasi;
        private System.Windows.Forms.Button Btnsimpan;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

