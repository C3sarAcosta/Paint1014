namespace Paint1014
{
    public partial class Form1 : Form
    {
        Graphics papel;
        int x = 0;
        int y = 0;
        int R = 0;
        int G = 0;
        int B = 0;
        int tamnioPincel = 3;
        bool moviendo = false;
        Pen pen;
        bool pintar = false;
        bool borrar = false;

        public Form1()
        {
            InitializeComponent();
            picBoxPapel.Image = new Bitmap(picBoxPapel.Height, picBoxPapel.Width);
            papel = picBoxPapel.CreateGraphics();
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tamnioPincel = trackBarTamnioPincel.Value;
            R = int.Parse(txtR.Text);
            G = int.Parse(txtG.Text);
            B = int.Parse(txtB.Text);
            pen = new Pen(Color.FromArgb(R, G, B), tamnioPincel);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }

        private void btnPinncel_Click(object sender, EventArgs e)
        {
            pintar = true;
            borrar = false;
        }

        private void picBoxPapel_MouseDown(object sender, MouseEventArgs e)
        {
            moviendo = true;
            x = e.X;
            y = e.Y;
            picBoxPapel.Cursor = Cursors.Cross;
        }

        private void picBoxPapel_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = false;
        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            pintar = false;
            borrar = true;
        }

        private void picBoxPapel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendo && pintar)
            {
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
            if (moviendo && borrar)
            {
                cambiarPincel(255, 255, 255);
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void cambiarPincel(int R, int G, int B)
        {
            pen = new Pen(Color.FromArgb(R, G, B), trackBarTamnioPincel.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }

        private void PicBoxNegro_Click(object sender, EventArgs e)
        {
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();
        }

        private void picBoxColores_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtR.Text = colorDialog1.Color.R.ToString();
                txtG.Text = colorDialog1.Color.G.ToString();
                txtB.Text = colorDialog1.Color.B.ToString();
                //VVVV
            }
        }
    }
}