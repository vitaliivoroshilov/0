namespace CG_Lab0
{
    public partial class Form1 : Form
    {
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(ofd.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void êîíâåğòàöèÿÂÎòòåíêèÑåğîãîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GreyFilter filter = new GreyFilter();
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void áèíàğèçàöèÿÏîÏîğîãóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int limit = int.Parse(textBox1.Text);

            BinaryFilter filter = new BinaryFilter(limit);
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }

        private void óâåëè÷åíèåßğêîñòèÍàÊîíñòàíòóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int deltaBrightness = int.Parse(textBox1.Text);

            IncBrightnessFilter filter = new IncBrightnessFilter(deltaBrightness);
            Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }
    }
}