using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication6
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
        
        public static Bitmap WypelnijPlaszczyzneWspolrzednymi(string xmint, string ymint, string xmaxt, string ymaxt, string Rt, string it, string lItt)
        {
            double xmin = double.Parse(xmint);
            double ymin = double.Parse(ymint);
            double xmax = double.Parse(xmaxt);
            double ymax = double.Parse(ymaxt);
            double R = double.Parse(Rt);
            double ii = double.Parse(it);
            int lIt = int.Parse(lItt);
            double szerokoscX = xmax - xmin;
            double wysokoscY = ymax - ymin;
            double krokX = szerokoscX / 1200;
            double krokY = wysokoscY / 900;
            Punkcik[,] punktPlaszczyzny = new Punkcik[1200, 900];
            for (int i = 0; i < 1200; i++)
            {
                for (int j = 0; j < 900; j++)
                {
                    punktPlaszczyzny[i, j] = new Punkcik(xmin + i * krokX, ymin + j * krokY);
                }
            }
            //określenie statycznych zmiennych klasy Punkcik (krańcowe punkty płaszczyzny)
            Punkcik.lokacjaMinX = xmin;
            Punkcik.lokacjaMinY = ymin;
            Punkcik.lokacjaMaxX = xmax;
            Punkcik.lokacjaMaxY = ymax;          

            Bitmap image1 = new Bitmap(1200, 900);
            int x, y;
            Color newColor;
            PaletaKolorow.PrzygotujPaleteKolorow();
            double iterowanyX, iterowanyY;
            for (x = 0; x < image1.Width; x++)
            {
                for (y = 0; y < (image1.Height - 1); y++)
                {
                    iterowanyX = punktPlaszczyzny[x, y].xLokacja;
                    iterowanyY = punktPlaszczyzny[x, y].yLokacja;
                    punktPlaszczyzny[x, y].Iteruj(iterowanyX, iterowanyY, R, ii, lIt);      // tutaj wywoływana jest metoda Iteruj
                    newColor = punktPlaszczyzny[x, y].PobierzKolor();
                    image1.SetPixel(x, y, newColor);
                }
            }
            return image1;
        }
        
    }
    class Punkcik
    {
        public double xLokacja;                        //pola klasy Punkcik
        public double yLokacja;
        private bool wZbiorze;
        private Color kolorPunktu;
        private int liczbaIteracjiPrzyWyjsciu;
        public static double lokacjaMinX;               //zmienne lokacja oznaczają współrzędnie granic wyświetlanego obszaru płaszczyzny
        public static double lokacjaMaxX;
        public static double lokacjaMinY;
        public static double lokacjaMaxY;
        public Punkcik(double x, double y)             //konstruktor
        {
            xLokacja = x;
            yLokacja = y;
            wZbiorze = true;
            kolorPunktu = Color.Black;
            liczbaIteracjiPrzyWyjsciu = 0;
        }
        
        public void Koloruj(bool w, int l)
        {
            wZbiorze = w;
            liczbaIteracjiPrzyWyjsciu = l;
            //   if (l > 255) l = 255;
            //   kolorPunktu = Color.FromArgb(l/2, l, l);       
            if (l > 1000) l = 1000;
            kolorPunktu = PaletaKolorow.Paleta[l];  
        }
        public void Iteruj(double zX, double zY, double r, double i, int liczbaIteracji)
        {
                {

                    bool wZbiorzeJulii = true;
                    for (int c = 0; c < liczbaIteracji; c++)
                    {
                        double zXkolejny = zX * zX - zY * zY + r + i;
                        double zYkolejny = 2 * zX * zY + r + i;
                        zX = zXkolejny;
                        zY = zYkolejny;
                        if (!SprawdzCzyWZbiorze(zX, zY))
                        {
                            wZbiorzeJulii = false;
                            break;
                        }
                        Koloruj(wZbiorzeJulii, c);
                    }
                }

            }
        public Color PobierzKolor()
        {
            return kolorPunktu;
        }
        private bool SprawdzCzyWZbiorze(double x, double y)
        {
                if (x * x + y * y < 4)
                    return true;
                else return false;
        }
    }
    public static class PaletaKolorow
    {
        public static Color[] Paleta = new Color[1000];
        public static void PrzygotujPaleteKolorow()
        {
            Paleta[0] = Color.Black;                                // kolor czarny na początek
            for (int licznik = 1; licznik < 50; licznik++)         // kolor pierwszy palety
            {
                Paleta[licznik] = Color.FromArgb(licznik*4, 0, licznik*2);
            }
            for (int licznik = 50; licznik < 500; licznik++)       // kolor drugi palety
            {
                Paleta[licznik] = Color.FromArgb(200, (licznik-50) / 2, 88 + licznik / 4);
            }
            for (int licznik = 500; licznik < 1000; licznik++)      // kolor trzeci palety
                Paleta[licznik] = Color.FromArgb(250, 250, 200);
        }
    }
}
