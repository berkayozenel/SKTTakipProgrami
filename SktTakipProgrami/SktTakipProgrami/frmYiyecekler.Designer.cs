namespace SktTakipProgrami
{
    partial class frmYiyecekler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYiyecekler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpSkt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunTur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sktTett = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpSkt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUrunTur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUrunAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(341, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün Ekle";
            // 
            // dtpSkt
            // 
            this.dtpSkt.CustomFormat = "MM/dd/yyyy";
            this.dtpSkt.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSkt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSkt.Location = new System.Drawing.Point(141, 63);
            this.dtpSkt.Name = "dtpSkt";
            this.dtpSkt.Size = new System.Drawing.Size(200, 34);
            this.dtpSkt.TabIndex = 8;
            this.dtpSkt.ValueChanged += new System.EventHandler(this.dtpSkt_ValueChanged);
            this.dtpSkt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpSkt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(137, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "AY/GÜN/YIL";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(90, 279);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 40);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "*SKT - TETT:";
            // 
            // txtUrunTur
            // 
            this.txtUrunTur.Enabled = false;
            this.txtUrunTur.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunTur.Location = new System.Drawing.Point(138, 215);
            this.txtUrunTur.Name = "txtUrunTur";
            this.txtUrunTur.Size = new System.Drawing.Size(158, 34);
            this.txtUrunTur.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Türü:";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Enabled = false;
            this.txtUrunAd.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Location = new System.Drawing.Point(138, 147);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(158, 34);
            this.txtUrunAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Ürün Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(377, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 326);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(875, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(680, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 369);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ayrılan/İade Edilen Ürünler";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 30);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(569, 336);
            this.dataGridView3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox4.Location = new System.Drawing.Point(12, 362);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(662, 369);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SKT/TETT Gelen Ürünler";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAdi,
            this.urunTuru,
            this.sktTett});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(656, 336);
            this.dataGridView2.TabIndex = 0;
            // 
            // urunAdi
            // 
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.MinimumWidth = 6;
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.ReadOnly = true;
            // 
            // urunTuru
            // 
            this.urunTuru.HeaderText = "Ürün Türü";
            this.urunTuru.MinimumWidth = 6;
            this.urunTuru.Name = "urunTuru";
            this.urunTuru.ReadOnly = true;
            // 
            // sktTett
            // 
            this.sktTett.HeaderText = "SKT - TETT";
            this.sktTett.MinimumWidth = 6;
            this.sktTett.Name = "sktTett";
            this.sktTett.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "(\'*\' zorunlu alan)";
            // 
            // frmYiyecekler
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1270, 743);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmYiyecekler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YİYECEKLER";
            this.Load += new System.EventHandler(this.frmYiyecekler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunTur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn sktTett;
        private System.Windows.Forms.DateTimePicker dtpSkt;
        private System.Windows.Forms.Label label5;
    }
}