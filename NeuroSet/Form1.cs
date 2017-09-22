using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NeuroSet
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        int[,] fieldState = new int[10, 10];
        String[] fieldContent = new String[43];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createNewDrawField();
            selectedSymbol.SelectedIndex = 0;
            for (int i = 0; i < 43; i++)
            {
                fieldContent[i] = "";
            }
        }

        private void createNewDrawField()
        {
            bitmap = new Bitmap(drawField.Width, drawField.Height);
            Graphics gr = Graphics.FromImage(bitmap);
            for (int i = 0; i <= 300; i += 30)
            {
                gr.DrawLine(new Pen(Brushes.Black, 1), new Point(0, i), new Point(300, i));
                gr.DrawLine(new Pen(Brushes.Black, 1), new Point(i, 0), new Point(i, 300));
            }
            drawField.Image = bitmap;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    fieldState[i, j] = 0;
                }
            }
        }

        private void drawField_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / 30;
            int y = e.Y / 30;
            changeFieldState(x, y);
            changeCellColor(x, y);
            //MessageBox.Show("X="+x+"<>Y="+y);
        }

        private void changeFieldState(int x, int y)
        {
            if (fieldState[x, y] == 0)
            {
                fieldState[x, y] = 1;
            }
            else
            {
                fieldState[x, y] = 0;
            }
        }

        private void changeCellColor(int x, int y)
        {
            int startX = x * 30 + 1;
            int startY = y * 30 + 1;
            int endX = (x + 1) * 30;
            int endY = (y + 1) * 30;
            Graphics gr = Graphics.FromImage(bitmap);
            if (fieldState[x, y] == 1)
            {
                gr.FillRectangle(new SolidBrush(Color.Red), new Rectangle(startX, startY, (endX - startX), (endY - startY)));
            }
            else
            {
                gr.FillRectangle(new SolidBrush(Color.White), new Rectangle(startX, startY, (endX - startX), (endY - startY)));
            }
            drawField.Image = bitmap;
        }

        private void b_SaveSymbol_Click(object sender, EventArgs e)
        {
            int symbolIndex = selectedSymbol.SelectedIndex;
            String symbolContent = "";
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    symbolContent += fieldState[x, y];
                }
            }
            fieldContent[symbolIndex] = symbolContent;
        }

        private void b_ClearField_Click(object sender, EventArgs e)
        {
            createNewDrawField();
        }

        private void b_LoadSymbol_Click(object sender, EventArgs e)
        {
            int symbolIndex = selectedSymbol.SelectedIndex;
            String symbolContent = fieldContent[symbolIndex];
            int result = String.Compare(symbolContent, "");
            if (result != 0)
            {
                int ind = 0;
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        fieldState[x, y] = (int)Char.GetNumericValue(symbolContent[ind]);
                        ind += 1;
                        changeCellColor(x, y);
                    }
                }
            }
            else
            {
                MessageBox.Show("Данный символ не содержится в памяти!");
            }
        }

        private void b_SaveInFile_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(new FileStream("neuroset.txt", FileMode.Create));
            for (int i = 0; i < 43; i++)
            {
                writer.WriteLine(fieldContent[i]);
            }
            writer.Close();
            MessageBox.Show("Сохранение данных завершено!");
        }

        private void b_ReadFromFile_Click(object sender, EventArgs e)
        {
            if (File.Exists("neuroset.txt"))
            {
                StreamReader reader = new StreamReader(new FileStream("neuroset.txt", FileMode.Open));
                for (int i = 0; i < 43; i++)
                {
                    fieldContent[i] = reader.ReadLine();
                }
                reader.Close();
                MessageBox.Show("Чтение данных завершено!");
            }
            else
            {
                MessageBox.Show("Файла с данными для нейросети не существует!");
            }
        }

    }
}
