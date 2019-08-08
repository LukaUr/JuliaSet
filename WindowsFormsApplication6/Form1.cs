using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            pictureBox1.Image = Program.WypelnijPlaszczyzneWspolrzednymi(textBoxXmin.Text, textBoxYmin.Text, textBoxXmax.Text, textBoxYmax.Text, textBoxCr.Text, textBoxCi.Text, "20");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Po co tu klikasz?", "Hehehehehehe");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label11.Show();
            label11.Refresh();
            pictureBox1.Image = Program.WypelnijPlaszczyzneWspolrzednymi(textBoxXmin.Text, textBoxYmin.Text, textBoxXmax.Text, textBoxYmax.Text, textBoxCr.Text, textBoxCi.Text, textBoxLiczbaIteracji.Text);
            label11.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zbiór tworzą te punkty p należące do płaszczyzny zespolonej C dla których ciąg:\n\n   z(0) = p;\n   z(n+1) = z(n)^2 + c\n\nnie dąży do nieskończoności.\n\n c to liczba zespolona będąca parametrem zbioru, która determinuje jego kształt.", "Zbiór Julii");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wprowadź współrzędne narożników fragmentu płaszczyzny zespolonej, dla której będzie rysowany zbiór Julii. \n\nZbiór mieści się w polu: X (-1,5 : 1,5), Y (-1,2 : 1,2).", "Współrzędne płaszczyzny zespolonej");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parametr c jest liczbą zespoloną determinującą kształt i właściwości zbioru Julii. \n\nWprowadź wartość rzeczywistą i urojoną parametru c.\n\n\n\n\nPrzykłady ciekawych kombinacji:\n\nr = -0,71   i = 0,19\n\nr = 0,99    i = -0,615\n\nr = -0,61   i = 0\n\nr= 1          i = -0,648", "Parametr c");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liczba iteracji determinuje dokładność odwzorowania Zbioru Julii.\nDuża liczba iteracji wydłuża czas generowania zbioru.\n\nWprowadź wartośc od 1 do 255.", "Liczba iteracji");
        }        
    }
}
