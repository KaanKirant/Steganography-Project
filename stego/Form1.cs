using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int[] liste = new int[1000];
        public class RandomKey
        {
            public int[] randomKeyGenarator(int textLength, int height, int width)
            {

                int[] array = new int[textLength];
                int[] array2 = new int[textLength];

                Random random = new Random();

                for (int i = 0; i < textLength; i++)
                {
                    array[i] = random.Next(height);
                    array2[i] = random.Next(width);
                    liste[i] = array[i];
                    liste[i + 1] = array2[i];
                }
                return liste;
            }
        }

        public RandomKey r = new RandomKey();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog(); //open file
            dialog.Filter = "Image Files (*.bmp) | *.bmp"; //extension filter.
            dialog.InitialDirectory = @"C:\Users\dell\Desktop\steganograpy";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxOpenFile.Text = dialog.FileName.ToString();
                pictureBox1.ImageLocation = textBoxOpenFile.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(textBoxOpenFile.Text);
            string messagge = "";

            for (int a = 0; a < textBoxMessage.TextLength; a++)
            {
                char letter = Convert.ToChar(textBoxMessage.Text.Substring(a, 1));
                int value = Convert.ToInt32(letter);
                string binaryValue = binaryCevir(value);
                switch (binaryValue.Length)
                {
                    case 1:
                        binaryValue = "00000000" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 2:
                        binaryValue = "0000000" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 3:
                        binaryValue = "000000" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 4:
                        binaryValue = "00000" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 5:
                        binaryValue = "0000" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 6:
                        binaryValue = "000" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 7:
                        binaryValue = "00" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 8:
                        binaryValue = "0" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 9:
                        messagge = messagge + binaryValue;
                        break;
                }
            }
            
            double mse = 0;

            double psnr;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixel = bitmap.GetPixel(i, j);
                    double diff;

                    if (j < messagge.Length)
                    {
                        int bluePixel = pixel.B;
                        string binaryBlue = binaryCevir(pixel.B);
                        binaryBlue = binaryBlue.Remove(binaryBlue.Length - 1, 1) + messagge.Substring(j, 1);
                        int newbluePixel = decimalCevir(binaryBlue);
                        bitmap.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, newbluePixel));
                        diff = Math.Pow(newbluePixel - bluePixel, 2);
                        mse = mse + diff;
                    }

                    if (i == bitmap.Width - 1 && j == bitmap.Height - 1)
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, messagge.Length));
                    }
                }
            }
            
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files (*.bmp) | *.bmp"; //extension filter.
            save.InitialDirectory = @"C:\Users\dell\Desktop\steganograpy";

            if (save.ShowDialog() == DialogResult.OK)
            {
                textBoxOpenFile.Text = save.FileName.ToString();
                pictureBox1.ImageLocation = textBoxOpenFile.Text;
                bitmap.Save(textBoxOpenFile.Text);
            }
            textBoxMSE.Text = Convert.ToString(mse / (bitmap.Height * bitmap.Width));
            mse = mse / (bitmap.Height * bitmap.Width);
            psnr = (10 * Math.Log10((255 / mse)));
            textBoxPSNR.Text = Convert.ToString(psnr);
            decimal capacity = (((decimal)textBoxMessage.TextLength * (decimal)8) / ((decimal)bitmap.Width * (decimal)bitmap.Height));
            textBoxCapacity.Text = Convert.ToString(capacity);
            textBoxMessage.Clear();

        }
        public string binaryCevir(int sayi)
        {
            int kalan;
            string yazikalan = "";
            while (sayi != 0)
            {
                kalan = sayi % 2;
                sayi = sayi / 2;

                yazikalan = kalan.ToString() + yazikalan;
            }

            return yazikalan;
        }
        public int decimalCevir(string binary)
        {
            int dec = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] == '0') continue;
                dec += (int)Math.Pow(2, i);
            }

            return dec;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(textBoxOpenFile.Text);
            string messageBinary = "";
            string message = ""; 
            
            Color lastpixel = bitmap.GetPixel(bitmap.Width - 1, bitmap.Height - 1);
            int msglength = lastpixel.B;


            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixel = bitmap.GetPixel(i, j);

                    if (i < 1 && j < msglength)
                    {
                        int bluePixel = pixel.B;
                        string binaryBlue = binaryCevir(pixel.B);
                        char c = Convert.ToChar( binaryBlue.Substring(binaryBlue.Length - 1));

                        messageBinary = messageBinary + Convert.ToString(c);
                    }
                }
            }
            for(int a = 0; a < messageBinary.Length; a++)
            {
                if (a % 9 == 0)
                {
                    string letterBinary = messageBinary.Substring(a, 9);
                    int letterDecimal = decimalCevir(letterBinary);
                    char c = Convert.ToChar(letterDecimal);
                    message = message + c;
                }
            }
            textBoxMessage.Text = message;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string messagge = "";
            double diff;
            double mse = 0;
            double psnr;

            for (int a = 0; a < textBoxMessage.TextLength; a++)
            {
                char letter = Convert.ToChar(textBoxMessage.Text.Substring(a, 1));
                int value = Convert.ToInt32(letter);
                string binaryValue = binaryCevir(value);

                switch (binaryValue.Length)
                {
                    case 1:
                        binaryValue = "00000000" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 2:
                        binaryValue = "0000000" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 3:
                        binaryValue = "000000" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 4:
                        binaryValue = "00000" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 5:
                        binaryValue = "0000" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 6:
                        binaryValue = "000" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 7:
                        binaryValue = "00" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 8:
                        binaryValue = "0" + binaryValue;
                        messagge = messagge + binaryValue;
                        break;
                    case 9:
                        messagge = messagge + binaryValue;
                        break;
                }
            }

            Bitmap bitmap = new Bitmap(textBoxOpenFile.Text);

            int[] list = new int[textBoxMessage.Text.Length * 2 * 9];
            list = r.randomKeyGenarator(textBoxMessage.TextLength * 9, bitmap.Height, bitmap.Width);

            for (int i = 0; i < textBoxMessage.TextLength*9; i++)
            {
                Color pixel = bitmap.GetPixel(list[i], list[i + 1]);
                int bluePixel = pixel.B;
                string binaryBlue = binaryCevir(pixel.B);
                binaryBlue = binaryBlue.Remove(binaryBlue.Length - 1, 1) + messagge.Substring(i, 1);
                int newbluePixel = decimalCevir(binaryBlue);
                bitmap.SetPixel(list[i], list[i+1], Color.FromArgb(pixel.R, pixel.G, newbluePixel));
                diff = Math.Pow(newbluePixel-bluePixel, 2);
                mse = mse + diff;
            }
            for (int a = 0; a < bitmap.Width; a++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixel = bitmap.GetPixel(a, j);
                    if (a == bitmap.Width - 1 && j == bitmap.Height - 1)
                    {
                        bitmap.SetPixel(a, j, Color.FromArgb(pixel.R, pixel.G, textBoxMessage.TextLength));
                    }
                }
            }
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files (*.bmp) | *.bmp"; //extension filter.
            save.InitialDirectory = @"C:\Users\dell\Desktop\steganograpy";

            if (save.ShowDialog() == DialogResult.OK)
            {
                textBoxOpenFile.Text = save.FileName.ToString();
                pictureBox1.ImageLocation = textBoxOpenFile.Text;
                bitmap.Save(textBoxOpenFile.Text);
            }
            textBoxMSE.Text = Convert.ToString(mse / (bitmap.Height * bitmap.Width));
            mse = mse / (bitmap.Height * bitmap.Width);
            psnr = (10 * Math.Log10((255 / mse)));
            textBoxPSNR.Text = Convert.ToString(psnr);
            decimal capacity = (((decimal)textBoxMessage.TextLength * (decimal)8) / ((decimal)bitmap.Width * (decimal)bitmap.Height));
            textBoxCapacity.Text = Convert.ToString(capacity);
            textBoxMessage.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(textBoxOpenFile.Text);

            Color lastpixel = bitmap.GetPixel(bitmap.Width - 1, bitmap.Height - 1);
            int msglength = lastpixel.B;
            Console.WriteLine(liste);

            string message = "";
            string messageBinary = "";

            for (int i = 0; i < msglength*9; i++)
            {

                Color pixel = bitmap.GetPixel(liste[i], liste[i + 1]);
                int bluePixel = pixel.B;
                string binaryBlue = binaryCevir(pixel.B);
                char c = Convert.ToChar(binaryBlue.Substring(binaryBlue.Length - 1));

                messageBinary = messageBinary + Convert.ToString(c);

            }
            for (int a = 0; a < messageBinary.Length; a++)
            {
                if (a % 9 == 0)
                {
                    string letterBinary = messageBinary.Substring(a, 9);
                    int letterDecimal = decimalCevir(letterBinary);
                    char b = Convert.ToChar(letterDecimal);
                    message = message + b;
                }
            }
            textBoxMessage.Text = message;
        }
    }
}
