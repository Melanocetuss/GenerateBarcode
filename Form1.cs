using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ZXing;

namespace GenerateBarcode
{
    public partial class Form1 : Form
    {
        private Bitmap barcodeBitmap;
        private PrintDocument printDocumentBarcode = new PrintDocument(); // PrintDocument nesnesi tanımlandı

        public Form1()
        {
            InitializeComponent();

            printDocumentBarcode.PrintPage += printDocumentBarcode_PrintPage;
        }

        private void btnOluştur_Click(object sender, EventArgs e)
        {
            string barcodeData = txtBarcode.Text.Trim(); // Barkod numarası
            string UrunIsmi = txtUrunIsmi.Text.Trim();   // Ürün adı

            if (string.IsNullOrWhiteSpace(barcodeData) || string.IsNullOrWhiteSpace(UrunIsmi))
            {
                lblFeedback.Text = "Barkod veya Ürün İsmi Boş Geçilemez";
                lblFeedback.ForeColor = Color.Red;
                lblFeedback.Visible = true;
                return;
            }

            // Barkod yazar nesnesini oluştur
            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 300,  // Daha küçük genişlik
                    Height = 100,  // Daha küçük yükseklik
                    Margin = 5,   // Daha küçük margin (boşluk)
                }
            };

            // Barkodu oluştur
            Bitmap generatedBarcode = barcodeWriter.Write(barcodeData);

            // 4 barkod için geniş bir bitmap oluştur
            int finalWidth = 600; // Barkodların yatay yerleşimi için
            int finalHeight = 300; // Barkod ve isim için yer
            barcodeBitmap = new Bitmap(finalWidth, finalHeight);

            using (Graphics g = Graphics.FromImage(barcodeBitmap))
            {
                g.Clear(Color.White); // Arka planı beyaz yap

                int topMargin = 2; // 0,25 cm boşluk için ayar (0,25 cm ≈ 2,5 piksel, yuvarlanarak 2 piksel)

                for (int i = 0; i < 4; i++)
                {
                    // Pozisyon belirle (yatay hizalama)
                    int xOffset = i * 130; // Barkodlar arası boşluğu daha da azalttık
                    int yOffset = topMargin; // Kağıdın üstünden 0,25 cm boşluk

                    // Barkodu döndür ve çiz
                    g.TranslateTransform(xOffset + generatedBarcode.Height / 2, yOffset + generatedBarcode.Width / 2); // Ortaya taşı
                    g.RotateTransform(90); // 90 derece döndür
                    g.DrawImage(generatedBarcode, -generatedBarcode.Width / 2, -generatedBarcode.Height / 2);
                    g.ResetTransform(); // Sonraki çizim için sıfırla

                    // Ürün adını yaz (90 derece döndürülmüş)
                    Font font = new Font("Arial", 10, FontStyle.Bold);
                    SizeF textSize = g.MeasureString(UrunIsmi, font);

                    // Ürün adı için döndürme
                    g.TranslateTransform(xOffset + generatedBarcode.Height + 20, yOffset + generatedBarcode.Width / 2);
                    g.RotateTransform(90);
                    g.DrawString(UrunIsmi, font, Brushes.Black, -textSize.Width / 2, 0);
                    g.ResetTransform();
                }
            }

            // PictureBox'ta göster
            picbx.Image = barcodeBitmap;

            lblFeedback.Text = "Barkodlar Başarılı Bir Şekilde Oluşturuldu";
            lblFeedback.ForeColor = Color.Green;
            lblFeedback.Visible = true;
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            if (barcodeBitmap == null)
            {
                lblFeedback.Text = "Lütfen önce barkod oluşturun";
                lblFeedback.ForeColor = Color.Red;
                lblFeedback.Visible = true;
                return;
            }

            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocumentBarcode
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocumentBarcode.Print();
            }
        }

        private void printDocumentBarcode_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (barcodeBitmap != null)
            {
                // Barkod resmini yazdır
                e.Graphics.DrawImage(barcodeBitmap, new Point(0, 0));
            }
        }

       
    }
}