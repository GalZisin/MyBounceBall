using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyBounceBall
{
    public partial class Form1 : Form
    {
        private static int ballIndex = 0;
        int dx = 1;
        int dy = 1;
        int ix = 1;
        int iy = 1;
        bool bexitw = false;
        private static int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();
            //return;
            //BallPicBox.Location = new Point(BallPicBox.Location.X + dx * ix, BallPicBox.Location.Y + dy * iy);
            //    //CheckDirection();
            //    if (!bexitw)
            //    {
            //        timer1.Start();
            //    }
            //    else
            //    {
            //        PictureBox pb = BallPicBox;
            //        string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Boom.jpg";
            //        pb.Size = new System.Drawing.Size(120, 115);
            //        pb.Image = Image.FromFile(path);
            //        this.panel1.Update();
            //        Thread.Sleep(500);
            //        RemovePicBox(BallPicBox);

            //    }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.Width - 40;
            panel1.Height = this.Height -100;
            WinLbl.Location = new System.Drawing.Point(panel1.Width / 2 - WinLbl.Width / 2, panel1.Height / 2 - WinLbl.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BallPicBox.Location = new Point(panel1.Width / 2 - BallPicBox.Width / 2, panel1.Height / 2 - BallPicBox.Height);
            // timer1.Start();
            button1_Click(new object(), EventArgs.Empty);
        }
        //private void CheckDirection()
        //{
        //    int x = BallPicBox.Location.X;
        //    int y = BallPicBox.Location.Y;
        //    if (y <= 0)
        //    {
        //        iy = -1 * iy;
        //    }
        //    else if (x <= 0)
        //    {
        //        ix = -1 * ix;
        //    }
        //    else if (x >= panel1.Width - BallPicBox.Width)
        //    {
        //        ix = -1 * ix;
        //    }
        //    else if (y >= panel1.Height - BallPicBox.Height)
        //    {
        //        iy = -1 * iy;
        //    }
        //    else
        //    {
        //        if (CheckIfAnyBallOverLapping(BallPicBox))
        //        {
        //            iy = -1 * iy;
        //            ix = -1 * ix;
        //        }

        //    }
        //}
        private void CheckDirectionAll(PictureBox BallPicBox1, ref Direction d)
        {
            int x = BallPicBox1.Location.X;
            int y = BallPicBox1.Location.Y;
            if (y <= 0)
            {
                d.iy = -1 * d.iy;
            }
            else if (x <= 0)
            {
                d.ix = -1 * d.ix;
            }
            else if (x >= panel1.Width - BallPicBox1.Width)
            {
                d.ix = -1 * d.ix;
            }
            else if (y >= panel1.Height - BallPicBox1.Height)
            {
                d.iy = -1 * d.iy;
            }
            else
            {
                if (CheckIfAnyBallOverLapping(BallPicBox1))
                {
                    d.iy = -1 * d.iy;
                    d.ix = -1 * d.ix;

                }
            }
        }
        private bool CheckIfAnyBallOverLapping(PictureBox ballBox)
        {
            foreach (var b in panel1.Controls)
            {
                PictureBox pb = b as PictureBox;
                if (pb != null)
                {
                    if (pb.Name != ballBox.Name)
                    {
                        if (pb.Bounds.IntersectsWith(ballBox.Bounds))
                            return true;
                    }
                }
            }
            return false;
            
        }
        private bool IfIntersect(int x, int y, int x1, int y1)
        {
            if(Math.Abs(x-x1)<= BallPicBox.Width && Math.Abs(y - y1) <= BallPicBox.Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IfIntersectAll(int x, int y)
        {
            foreach (var b in panel1.Controls)
            {
                PictureBox pb = b as PictureBox;
                if (pb != null)
                {
                    if(IfIntersect(x, y, pb.Location.X, pb.Location.Y))
                    {
                            return true;
                    }
                }
            }
            return false;
        }
        private PictureBox CreateAnotherBall()
        {
            int X = 0;
            int Y = 0;
            bool IfLocationNotFree = true;
      
                while (IfLocationNotFree)
                {
                    Random r = new Random();
                    X = r.Next(panel1.Width - BallPicBox.Width);
                    Y = r.Next(panel1.Height - BallPicBox.Height);
                    IfLocationNotFree = IfIntersectAll(X, Y);
                }
           
                System.Windows.Forms.PictureBox BallPicBox1 = new PictureBox();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                BallPicBox1.Image = ((System.Drawing.Image)(resources.GetObject("BallPicBox.Image")));
                //BallPicBox1.Location = new System.Drawing.Point(0, 75);
                //BallPicBox1.Location = new Point(panel1.Width / 2 - BallPicBox.Width / 2, panel1.Height / 2 - BallPicBox.Height);
                BallPicBox1.Location = new Point(X, Y);
                ballIndex++;
                BallPicBox1.Name = $"BallPicBox{ballIndex}";
                BallPicBox1.Size = new System.Drawing.Size(59, 53);
                BallPicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                BallPicBox1.TabIndex = 0;
                BallPicBox1.TabStop = false;
                BallPicBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BallPicBox1_MouseClick);
                panel1.Controls.Add(BallPicBox1);

            return BallPicBox1;
        }
        private void MoveNewBall()
        {
            Direction d = new Direction();
            System.Windows.Forms.PictureBox BallPicBox1 = null;
            RunOnUI(() => BallPicBox1 = CreateAnotherBall());
            bool bexitwhile = false;
            int stepCount = 0;
            while (true)
            {
                RunOnUI(() =>
                {
                    BallPicBox1.Location = new Point(BallPicBox1.Location.X + dx * d.ix, BallPicBox1.Location.Y + dy * d.iy);
                    stepCount++;
                    CheckDirectionAll(BallPicBox1, ref d);
                    if (BallPicBox1.Name == "deleted")
                    {
                        bexitwhile = true;
                    }
                });
                if (bexitwhile || count>=10)
                {
                    break;
                }
                Thread.Sleep(10);
            }
            Thread.Sleep(500);
      
                RunOnUI(() =>
                {
                    RemovePicBox(BallPicBox1);
                });
            
        }
        private void RemovePicBox(PictureBox p)
        {
            panel1.Controls.Remove(p);
            p = null;
        }
        private void RunOnUI(Action action)
        {
            this.BeginInvoke(action);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count >= 10)
                return;

            Task.Run(() => {
                MoveNewBall();

            });
        }

        private void BallPicBox_MouseClick(object sender, MouseEventArgs e)
        {
            count++;
            HitCountLbl.Text = $"Hit Points: {count}";
            bexitw =true;
            if (count >= 10)
            {
                Thread.Sleep(10);
                RunOnUI(() => { panel1.Controls.Add(WinLbl); });
            }
        }
        private void BallPicBox1_MouseClick(object sender, MouseEventArgs e)
        {
            count++;
            HitCountLbl.Text = $"Hit Points: {count}";
            string path= System.IO.Path.GetDirectoryName(Application.ExecutablePath)+ @"\Boom.jpg";
            PictureBox pb = ((PictureBox)sender);
            pb.Size = new System.Drawing.Size(120, 115);
            pb.Image= Image.FromFile(path);
            pb.Name = "deleted";
            if (count >= 10)
            {
                Thread.Sleep(10);
                RunOnUI(() => { panel1.Controls.Add(WinLbl); });
            }
        }

        private void HitCountLbl_Click(object sender, EventArgs e)
        {
            
        }
    }
    public class Direction
    {
        public int ix =1;
        public int iy =1;
    }
}
