namespace quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonAyikla_Click_1(object sender, EventArgs e)
        {
            richTextBoxTek.Text = "";
            richTextBoxCift.Text = "";
            int baslangic = Convert.ToInt32(textBoxBaslangic.Text);
            int bitis = Convert.ToInt32(textBoxBitis.Text);

            for (int i = baslangic; i <= bitis; i++)
            {
                if (i % 2 == 1)
                {
                    richTextBoxTek.Text = richTextBoxTek.Text + " " + i;

                }
                if (i % 2 == 0)
                {
                    richTextBoxCift.Text = richTextBoxCift.Text + " " + i;
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= progressBar1.Maximum - 10)
                progressBar1.Value += 10;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
        }
    }
}
