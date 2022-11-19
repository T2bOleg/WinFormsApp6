namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        Bitmap frame = new(800, 800);
        Graphics g, gFrame;
        List<Duck> ducks = new List<Duck>();
        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            gFrame.Clear(Color.LightBlue);
            gFrame.FillRectangle(new SolidBrush(Color.Green), 0, 150, 800, 800);
            foreach (Duck d in ducks)
            {
                d.Move();
                d.Paint(gFrame);
                //if (d.position.X >850 || d.position.Y >850 || d.position.X <-50 || d.position.Y <-50)
                //    ducks.Remove(d);
            }
            g.DrawImage(frame, 0, 0);
        }

        private void duckSpawn_Tick(object sender, EventArgs e)
        {
            ducks.Add(new Duck(random.Next(50, 750), random.Next(200, 750), random.Next(-8, 8), random.Next(0, 8)));
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Duck d in ducks){
                if (Math.Abs(d.position.X - e.X) < 30 && Math.Abs(d.position.Y - e.Y) < 30)
                    d.Shot();
            }
        }

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            gFrame = Graphics.FromImage(frame);

        }


    }
}