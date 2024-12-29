namespace GenerateBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picbx = new System.Windows.Forms.PictureBox();
            this.txtUrunIsmi = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblUrunIsmi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYazdır = new DevExpress.XtraEditors.SimpleButton();
            this.btnOluştur = new DevExpress.XtraEditors.SimpleButton();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbx)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbx
            // 
            this.picbx.BackColor = System.Drawing.Color.Black;
            this.picbx.Location = new System.Drawing.Point(26, 11);
            this.picbx.Name = "picbx";
            this.picbx.Size = new System.Drawing.Size(586, 268);
            this.picbx.TabIndex = 0;
            this.picbx.TabStop = false;
            // 
            // txtUrunIsmi
            // 
            this.txtUrunIsmi.Location = new System.Drawing.Point(187, 303);
            this.txtUrunIsmi.Name = "txtUrunIsmi";
            this.txtUrunIsmi.Size = new System.Drawing.Size(291, 20);
            this.txtUrunIsmi.TabIndex = 1;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(187, 357);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(291, 20);
            this.txtBarcode.TabIndex = 3;
            // 
            // lblUrunIsmi
            // 
            this.lblUrunIsmi.AutoSize = true;
            this.lblUrunIsmi.ForeColor = System.Drawing.Color.White;
            this.lblUrunIsmi.Location = new System.Drawing.Point(111, 306);
            this.lblUrunIsmi.Name = "lblUrunIsmi";
            this.lblUrunIsmi.Size = new System.Drawing.Size(54, 13);
            this.lblUrunIsmi.TabIndex = 4;
            this.lblUrunIsmi.Text = "Ürün İsmi:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnYazdır);
            this.panel1.Controls.Add(this.btnOluştur);
            this.panel1.Controls.Add(this.lblFeedback);
            this.panel1.Controls.Add(this.lblBarcode);
            this.panel1.Controls.Add(this.picbx);
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Controls.Add(this.lblUrunIsmi);
            this.panel1.Controls.Add(this.txtUrunIsmi);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 541);
            this.panel1.TabIndex = 6;
            // 
            // btnYazdır
            // 
            this.btnYazdır.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYazdır.ImageOptions.Image")));
            this.btnYazdır.Location = new System.Drawing.Point(274, 403);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(92, 56);
            this.btnYazdır.TabIndex = 9;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // btnOluştur
            // 
            this.btnOluştur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOluştur.ImageOptions.Image")));
            this.btnOluştur.Location = new System.Drawing.Point(386, 403);
            this.btnOluştur.Name = "btnOluştur";
            this.btnOluştur.Size = new System.Drawing.Size(92, 56);
            this.btnOluştur.TabIndex = 8;
            this.btnOluştur.Text = "Oluştur";
            this.btnOluştur.Click += new System.EventHandler(this.btnOluştur_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFeedback.Location = new System.Drawing.Point(3, 520);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(195, 13);
            this.lblFeedback.TabIndex = 7;
            this.lblFeedback.Text = "Barcode Başarılı Bir Şekilde Oluşturuldu.";
            this.lblFeedback.Visible = false;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.ForeColor = System.Drawing.Color.White;
            this.lblBarcode.Location = new System.Drawing.Point(111, 360);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(50, 13);
            this.lblBarcode.TabIndex = 6;
            this.lblBarcode.Text = "Barcode:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(633, 543);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkod Oluştur";
            ((System.ComponentModel.ISupportInitialize)(this.picbx)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbx;
        private System.Windows.Forms.TextBox txtUrunIsmi;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblUrunIsmi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblFeedback;
        private DevExpress.XtraEditors.SimpleButton btnOluştur;
        private DevExpress.XtraEditors.SimpleButton btnYazdır;
    }
}

