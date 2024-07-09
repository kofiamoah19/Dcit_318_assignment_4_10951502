using System.Drawing;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CanvasDrawingApplication
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private Graphics _graphics;
        private bool _isDrawing = false;
        private Point _lastMousePosition;

        public Form1()
        {
            InitializeComponent();
            InitializeCanvas();
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
        }

        private void InitializeCanvas()
        {
            // Create a new Bitmap to represent the canvas
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_bitmap);

            // Clear the canvas with a white background
            _graphics.Clear(Color.White);
            pictureBox1.Image = _bitmap;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDrawing = true;
                _lastMousePosition = e.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                using (var pen = new Pen(Color.Black, 2f))
                {
                    _graphics.DrawLine(pen, _lastMousePosition, e.Location);
                }
                _lastMousePosition = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDrawing = false;
            }
        }
    }
}

