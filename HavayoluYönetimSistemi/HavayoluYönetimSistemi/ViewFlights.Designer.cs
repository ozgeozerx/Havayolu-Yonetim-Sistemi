
namespace HavayoluYönetimSistemi
{
    partial class ViewFlights
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FcodeTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.KltSayısı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VarısCb = new System.Windows.Forms.ComboBox();
            this.SrcCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.FlightDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(145, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarifeli Uçuşları Görüntüle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(210, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Türk Hava Yolları";
            // 
            // FcodeTb
            // 
            this.FcodeTb.Location = new System.Drawing.Point(179, 148);
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.Size = new System.Drawing.Size(133, 22);
            this.FcodeTb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(43, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Uçuş Kodu";
            // 
            // UTarih
            // 
            this.UTarih.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UTarih.Location = new System.Drawing.Point(179, 189);
            this.UTarih.Name = "UTarih";
            this.UTarih.Size = new System.Drawing.Size(133, 32);
            this.UTarih.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(43, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tarih";
            // 
            // KltSayısı
            // 
            this.KltSayısı.Location = new System.Drawing.Point(338, 257);
            this.KltSayısı.Name = "KltSayısı";
            this.KltSayısı.Size = new System.Drawing.Size(133, 22);
            this.KltSayısı.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(198, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Koltuk Sayısı";
            // 
            // VarısCb
            // 
            this.VarısCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VarısCb.ForeColor = System.Drawing.Color.Red;
            this.VarısCb.FormattingEnabled = true;
            this.VarısCb.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Antalya",
            "Bolu",
            "Bursa",
            "Çanakkale",
            "Erzincan",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kayseri"});
            this.VarısCb.Location = new System.Drawing.Point(476, 190);
            this.VarısCb.Name = "VarısCb";
            this.VarısCb.Size = new System.Drawing.Size(133, 31);
            this.VarısCb.TabIndex = 25;
            // 
            // SrcCb
            // 
            this.SrcCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SrcCb.ForeColor = System.Drawing.Color.Red;
            this.SrcCb.FormattingEnabled = true;
            this.SrcCb.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Antalya",
            "Bolu",
            "Bursa",
            "Çanakkale",
            "Erzincan",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kayseri"});
            this.SrcCb.Location = new System.Drawing.Point(476, 142);
            this.SrcCb.Name = "SrcCb";
            this.SrcCb.Size = new System.Drawing.Size(133, 31);
            this.SrcCb.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(334, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Source";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(334, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Varış Noktası";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(283, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(151, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(368, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 35);
            this.button3.TabIndex = 29;
            this.button3.Text = "Sıfırla";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(453, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 35);
            this.button4.TabIndex = 30;
            this.button4.Text = "Geri";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FlightDGV
            // 
            this.FlightDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightDGV.Location = new System.Drawing.Point(12, 369);
            this.FlightDGV.Name = "FlightDGV";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FlightDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.FlightDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FlightDGV.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.FlightDGV.RowTemplate.Height = 24;
            this.FlightDGV.Size = new System.Drawing.Size(658, 209);
            this.FlightDGV.TabIndex = 38;
            this.FlightDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightDGV_CellContentClick);
            // 
            // ViewFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 590);
            this.Controls.Add(this.FlightDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VarısCb);
            this.Controls.Add(this.SrcCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UTarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KltSayısı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FcodeTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewFlights";
            this.Load += new System.EventHandler(this.ViewFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FcodeTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker UTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox KltSayısı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox VarısCb;
        private System.Windows.Forms.ComboBox SrcCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView FlightDGV;
    }
}