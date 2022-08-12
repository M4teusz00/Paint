using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_App
{
    public partial class Form1 : Form
    {

        public Point current = new Point();  
        public Point old = new Point();         //do aktualizowania lokalizacji pędzla podczas rysowania

        public Graphics g;
        public Graphics graph;          //zmienne do tworzenej grafiki

        public Pen pen = new Pen(Color.Black, 5);    //zmienna dla defaultowego pedzla

        Bitmap surface;    //pole na ktorym bedzie rysunek


        public Form1()  
        {
            InitializeComponent();

            g = Canvas_Panel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            //inicjalizacja zmiennych
            surface = new Bitmap(Canvas_Panel.Width, Canvas_Panel.Height);    

            graph = Graphics.FromImage(surface);

            Canvas_Panel.BackgroundImage = surface;
            Canvas_Panel.BackgroundImageLayout = ImageLayout.None;

            pen.Width = (float)Pencil_Size.Value;

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location; ///aktualizuje polozenie olowka/pedzla

        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)     //sprawdzenie czy przycisk myszy jest wcisniety
            {
                current = e.Location;
                g.DrawLine(pen, old, current);
                graph.DrawLine(pen, old, current);

                old = current;
            }

        }
        private Point mouseOffsetPos;
        private Boolean isMouseDown = false;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                mouseOffsetPos = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffsetPos.X, mouseOffsetPos.Y);
                this.Location = mousePos;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)            //po puszczeniu klawisza linia nie bedzie rysowana 
            {
                isMouseDown = false; 
            }
        }

        
        private void Eraser_Button_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }
         
        private void Pencil_Button_Click(object sender, EventArgs e)
        {
            pen.Color = Colorbox.BackColor;

        }

        private void Colorbox_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
                Colorbox.BackColor = cd.Color;
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            Canvas_Panel.Invalidate();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Png Files (*png) | .png";
            sfd.DefaultExt = "png";
            sfd.AddExtension = true;

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                surface.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);

            }

;       }

        private void pencilsize_changed(object sender, EventArgs e)
        {
            pen.Width = (float)Pencil_Size.Value;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Czy na pewno chcesz wyjść z aplikacji?", "Wyjście!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }
    }
}
