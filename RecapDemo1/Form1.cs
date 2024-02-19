namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)// butonlar�n herbirine ayr� ayr� eri�mek istiyorsan�z ve daha kontroll� olmak istiyorsan�z
                                                            // ayn� i�lemden farkl� nesneler olu�turup onlar� kontrol alt�nda tutmak istiyorsan�z
        {
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            //Button button = new Button();
            //button.Width = 50;
            //button.Height = 50;
            //button.Text = "My Button";
            //this.Controls.Add(button);

            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height=50;
                    buttons[i, j].Top=  top;
                    buttons[i, j].Left=left;
                    left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i,j].BackColor=Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }

                top += 50;
                left = 0;

            }
        }
    }
}
