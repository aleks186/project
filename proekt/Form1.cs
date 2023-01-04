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

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Thread threadCircle = new Thread(CircleThread);
            threadCircle.Start();
        }
        public void CircleThread()
        {
            while (true)
            {
                Random random = new Random();
                Pen pen = new Pen(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                Graphics Circle = this.CreateGraphics();
                Circle.DrawEllipse(pen, random.Next(0, this.Width - 200), random.Next(0, this.Height - 250), random.Next(50, 230), random.Next(50, 240));
                Thread.Sleep(4000);
            }
        }
    }
}