namespace BilgiYarışması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BTNA = new System.Windows.Forms.Button();
            this.BTNB = new System.Windows.Forms.Button();
            this.BTNC = new System.Windows.Forms.Button();
            this.BTND = new System.Windows.Forms.Button();
            this.labelsoru = new System.Windows.Forms.Label();
            this.labeldoğru = new System.Windows.Forms.Label();
            this.LABELYANLIŞ = new System.Windows.Forms.Label();
            this.LABELPUAN = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lblsoruno = new System.Windows.Forms.Label();
            this.lbldoğru = new System.Windows.Forms.Label();
            this.lblyanlış = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lbldgr = new System.Windows.Forms.Label();
            this.lblscm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(299, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİM MİLYONER OLMAK İSTER?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(159, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(551, 52);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // BTNA
            // 
            this.BTNA.Location = new System.Drawing.Point(159, 207);
            this.BTNA.Name = "BTNA";
            this.BTNA.Size = new System.Drawing.Size(241, 60);
            this.BTNA.TabIndex = 2;
            this.BTNA.Text = "A";
            this.BTNA.UseVisualStyleBackColor = true;
            this.BTNA.Click += new System.EventHandler(this.BTNA_Click);
            // 
            // BTNB
            // 
            this.BTNB.Location = new System.Drawing.Point(473, 207);
            this.BTNB.Name = "BTNB";
            this.BTNB.Size = new System.Drawing.Size(237, 60);
            this.BTNB.TabIndex = 3;
            this.BTNB.Text = "B";
            this.BTNB.UseVisualStyleBackColor = true;
            this.BTNB.Click += new System.EventHandler(this.BTNB_Click);
            // 
            // BTNC
            // 
            this.BTNC.Location = new System.Drawing.Point(159, 297);
            this.BTNC.Name = "BTNC";
            this.BTNC.Size = new System.Drawing.Size(241, 51);
            this.BTNC.TabIndex = 4;
            this.BTNC.Text = "C";
            this.BTNC.UseVisualStyleBackColor = true;
            this.BTNC.Click += new System.EventHandler(this.BTNC_Click);
            // 
            // BTND
            // 
            this.BTND.Location = new System.Drawing.Point(473, 297);
            this.BTND.Name = "BTND";
            this.BTND.Size = new System.Drawing.Size(237, 51);
            this.BTND.TabIndex = 5;
            this.BTND.Text = "D";
            this.BTND.UseVisualStyleBackColor = true;
            this.BTND.Click += new System.EventHandler(this.BTND_Click);
            // 
            // labelsoru
            // 
            this.labelsoru.AutoSize = true;
            this.labelsoru.Location = new System.Drawing.Point(777, 150);
            this.labelsoru.Name = "labelsoru";
            this.labelsoru.Size = new System.Drawing.Size(69, 16);
            this.labelsoru.TabIndex = 6;
            this.labelsoru.Text = "SORU NO";
            // 
            // labeldoğru
            // 
            this.labeldoğru.AutoSize = true;
            this.labeldoğru.Location = new System.Drawing.Point(777, 186);
            this.labeldoğru.Name = "labeldoğru";
            this.labeldoğru.Size = new System.Drawing.Size(57, 16);
            this.labeldoğru.TabIndex = 7;
            this.labeldoğru.Text = "DOĞRU";
            // 
            // LABELYANLIŞ
            // 
            this.LABELYANLIŞ.AutoSize = true;
            this.LABELYANLIŞ.Location = new System.Drawing.Point(777, 220);
            this.LABELYANLIŞ.Name = "LABELYANLIŞ";
            this.LABELYANLIŞ.Size = new System.Drawing.Size(54, 16);
            this.LABELYANLIŞ.TabIndex = 8;
            this.LABELYANLIŞ.Text = "YANLIŞ";
            // 
            // LABELPUAN
            // 
            this.LABELPUAN.AutoSize = true;
            this.LABELPUAN.Location = new System.Drawing.Point(777, 251);
            this.LABELPUAN.Name = "LABELPUAN";
            this.LABELPUAN.Size = new System.Drawing.Size(45, 16);
            this.LABELPUAN.TabIndex = 9;
            this.LABELPUAN.Text = "PUAN";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(780, 297);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "SONRAKİ SORU";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblsoruno
            // 
            this.lblsoruno.AutoSize = true;
            this.lblsoruno.Location = new System.Drawing.Point(901, 150);
            this.lblsoruno.Name = "lblsoruno";
            this.lblsoruno.Size = new System.Drawing.Size(14, 16);
            this.lblsoruno.TabIndex = 11;
            this.lblsoruno.Text = "0";
            // 
            // lbldoğru
            // 
            this.lbldoğru.AutoSize = true;
            this.lbldoğru.Location = new System.Drawing.Point(901, 186);
            this.lbldoğru.Name = "lbldoğru";
            this.lbldoğru.Size = new System.Drawing.Size(14, 16);
            this.lbldoğru.TabIndex = 12;
            this.lbldoğru.Text = "0";
            // 
            // lblyanlış
            // 
            this.lblyanlış.AutoSize = true;
            this.lblyanlış.Location = new System.Drawing.Point(901, 220);
            this.lblyanlış.Name = "lblyanlış";
            this.lblyanlış.Size = new System.Drawing.Size(14, 16);
            this.lblyanlış.TabIndex = 13;
            this.lblyanlış.Text = "0";
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Location = new System.Drawing.Point(901, 251);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(14, 16);
            this.lblpuan.TabIndex = 14;
            this.lblpuan.Text = "0";
            // 
            // lbldgr
            // 
            this.lbldgr.AutoSize = true;
            this.lbldgr.Location = new System.Drawing.Point(281, 429);
            this.lbldgr.Name = "lbldgr";
            this.lbldgr.Size = new System.Drawing.Size(44, 16);
            this.lbldgr.TabIndex = 15;
            this.lbldgr.Text = "label2";
            this.lbldgr.Visible = false;
            // 
            // lblscm
            // 
            this.lblscm.AutoSize = true;
            this.lblscm.Location = new System.Drawing.Point(473, 429);
            this.lblscm.Name = "lblscm";
            this.lblscm.Size = new System.Drawing.Size(44, 16);
            this.lblscm.TabIndex = 16;
            this.lblscm.Text = "label3";
            this.lblscm.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 603);
            this.Controls.Add(this.lblscm);
            this.Controls.Add(this.lbldgr);
            this.Controls.Add(this.lblpuan);
            this.Controls.Add(this.lblyanlış);
            this.Controls.Add(this.lbldoğru);
            this.Controls.Add(this.lblsoruno);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.LABELPUAN);
            this.Controls.Add(this.LABELYANLIŞ);
            this.Controls.Add(this.labeldoğru);
            this.Controls.Add(this.labelsoru);
            this.Controls.Add(this.BTND);
            this.Controls.Add(this.BTNC);
            this.Controls.Add(this.BTNB);
            this.Controls.Add(this.BTNA);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BTNA;
        private System.Windows.Forms.Button BTNB;
        private System.Windows.Forms.Button BTNC;
        private System.Windows.Forms.Button BTND;
        private System.Windows.Forms.Label labelsoru;
        private System.Windows.Forms.Label labeldoğru;
        private System.Windows.Forms.Label LABELYANLIŞ;
        private System.Windows.Forms.Label LABELPUAN;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblsoruno;
        private System.Windows.Forms.Label lbldoğru;
        private System.Windows.Forms.Label lblyanlış;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lbldgr;
        private System.Windows.Forms.Label lblscm;
    }
}

