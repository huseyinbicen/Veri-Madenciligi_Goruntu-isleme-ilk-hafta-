using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace VeriMadenciligi_Goruntu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Resim seç!";
            fd.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(fd.OpenFile());
            }
        }

        List<double> dizi_R = new List<double>();
        List<double> dizi_G = new List<double>();
        List<double> dizi_B = new List<double>();

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Image);

            for (int i = 0; i < bm.Width - 1; i++)
            {
                for (int j = 0; j < bm.Height - 1; j++)
                {
                    dizi_R.Add(bm.GetPixel(i, j).R);
                    dizi_G.Add(bm.GetPixel(i, j).G);
                    dizi_B.Add(bm.GetPixel(i, j).B);
                }
            }

            StatisticalCalculations px_R = new StatisticalCalculations(dizi_R);
            StatisticalCalculations px_G = new StatisticalCalculations(dizi_G);
            StatisticalCalculations px_B = new StatisticalCalculations(dizi_B);

            R_Mod.Text = px_R.Mod().ToString("#.##");
            G_Mod.Text = px_G.Mod().ToString("#.##");
            B_Mod.Text = px_B.Mod().ToString("#.##");

            R_Medyan.Text = px_R.Medyan().ToString("#.##");
            G_Medyan.Text = px_G.Medyan().ToString("#.##");
            B_Medyan.Text = px_B.Medyan().ToString("#.##");

            R_Ortalama.Text = px_R.Ortalama().ToString("#.##");
            G_Ortalama.Text = px_G.Ortalama().ToString("#.##");
            B_Ortalama.Text = px_B.Ortalama().ToString("#.##");

            R_Varyans.Text = px_R.OGMoment(2).ToString("#.##");
            G_Varyans.Text = px_G.OGMoment(2).ToString("#.##");
            B_Varyans.Text = px_B.OGMoment(2).ToString("#.##");

            R_Ssapma.Text = px_R.StandartSapma().ToString("#.##");
            G_Ssapma.Text = px_G.StandartSapma().ToString("#.##");
            B_Ssapma.Text = px_B.StandartSapma().ToString("#.##");

            R_Carpiklik.Text = px_R.Carpiklik();
            G_Carpiklik.Text = px_G.Carpiklik();
            B_Carpiklik.Text = px_B.Carpiklik();

            R_Basiklik.Text = px_R.Basiklik();
            G_Basiklik.Text = px_G.Basiklik();
            B_Basiklik.Text = px_B.Basiklik();

            R_DKatsayisi.Text = px_R.DegisimKatSayisi().ToString("#.##");
            G_DKatsayisi.Text = px_G.DegisimKatSayisi().ToString("#.##");
            B_DKatsayisi.Text = px_B.DegisimKatSayisi().ToString("#.##");

            R_Min.Text = px_R.Min().ToString("#.##");
            G_Min.Text = px_G.Min().ToString("#.##");
            B_Min.Text = px_B.Min().ToString("#.##");

            R_Max.Text = px_R.Max().ToString("#.##");
            G_Max.Text = px_G.Max().ToString("#.##");
            B_Max.Text = px_B.Max().ToString("#.##");


        }
    }
}
