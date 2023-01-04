namespace proekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Thread threadRectangle = new Thread(RectangleThread);
            threadRectangle.Start();
        }
        public void RectangleThread()
        {
            while (true)
            {
                Random random = new Random();
                Pen pen = new Pen(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                Graphics Rectangle = this.CreateGraphics();
                Rectangle.DrawRectangle(pen, random.Next(0, this.Width - 150), random.Next(0, this.Height - 150), random.Next(50, 155), random.Next(50, 155));
                Thread.Sleep(3000);
            }
        }
    }
}