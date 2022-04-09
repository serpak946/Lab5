using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        int b_w = 0, b_h = 0;
        int t_w = 0, t_h = 0;
        int l_w = 0, l_h = 0;
        int num_of_label = 1, num_of_button = 1, num_of_textbox = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static void Change_Location(Button a, ref int w, ref int h, Panel panel)
        {
            a.Location = new Point(a.Location.X + w, a.Location.Y + h);
            if (a.Location.X + 2 * a.Width + 2 * a.Margin.Right > panel.Width)
            {
                if (a.Location.Y + 2 * a.Height + 2 * a.Margin.Bottom < panel.Height)
                {
                    w = 0;
                    h += a.Height + a.Margin.Top;
                }
            }
            else w += a.Width + a.Margin.Left;
        }
        static void Change_Location(Label a, ref int w, ref int h, Panel panel)
        {
            a.Location = new Point(a.Location.X + w, a.Location.Y + h);
            if (a.Location.X + 2 * a.Width + 2 * a.Margin.Right > panel.Width)
            {
                if (a.Location.Y + 2 * a.Height + 2 * a.Margin.Bottom < panel.Height)
                {
                    w = 0;
                    h += a.Height + a.Margin.Top;
                }
            }
            else w += a.Width + a.Margin.Left;
        }
        static void Change_Location(TextBox a, ref int w, ref int h, Panel panel)
        {
            a.Location = new Point(a.Location.X + w, a.Location.Y + h);
            if (a.Location.X + 2 * a.Width + 2 * a.Margin.Right > panel.Width)
            {
                if (a.Location.Y + 2 * a.Height + 2 * a.Margin.Bottom < panel.Height)
                {
                    w = 0;
                    h += a.Height + a.Margin.Top;
                }
            }
            else w += a.Width + a.Margin.Left;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Label l = new Label();
            l.Parent = panel1;
            l.Text = "Label "+Convert.ToString(num_of_label);
            num_of_label++;
            l.AutoSize = true;
            Change_Location(l, ref l_w, ref l_h, panel1);
        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox t = new TextBox();
            t.Parent = panel3;
            t.Text = "TextBox " + Convert.ToString(num_of_textbox);
            num_of_textbox++;
            Change_Location(t, ref t_w, ref t_h, panel3);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = new Button();
            b.Parent = panel2;
            b.Text = "Button " + Convert.ToString(num_of_button);
            num_of_button++;
            Change_Location(b, ref b_w, ref b_h, panel2);
        }
    }
}
