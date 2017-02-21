using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class Form1 : Form
    {
        Element elementManager = new Element();
        List<PictureBox> actorsPB = new List<PictureBox>();
        List<Label> actorsLBL = new List<Label>();

        int points = 0;
        int lineX1;
        int lineX2;
        int lineY1;
        int lineY2;

        public Form1()
        {
            InitializeComponent();
            elementManager.CurrentElement = -1;
        }

        private void tsActor_Click(object sender, EventArgs e)
        {
            Create_Actor createActor = new Create_Actor(elementManager);
            createActor.ShowDialog();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Element_List elementList = new Element_List(elementManager);
            elementList.ShowDialog();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (elementManager.GetDrawMode == "Actor")
            {
                if (elementManager.CurrentElement != -1)
                {
                    CreateActor(e.X, e.Y, elementManager.GetActor(elementManager.CurrentElement));
                }
                else
                {
                    MessageBox.Show("Please select an element.");
                }
            }
            else if (elementManager.GetDrawMode == "Case")
            {

            }
            else if (elementManager.GetDrawMode == "Line")
            {
                return;
            }
        }

        private void CreateActor(int corX, int corY, Actor actor)
        {
            actorsPB.Add(new PictureBox());
            int newActor = actorsPB.Count - 1;
            actorsPB[newActor].BackgroundImage = Properties.Resources.stick_man_by_minimoko94_d2zvfn8;
            actorsPB[newActor].BackColor = SystemColors.ControlLightLight;
            actorsPB[newActor].Location = new System.Drawing.Point(corX - 75, corY);
            actorsPB[newActor].Size = new System.Drawing.Size(150, 150);
            actorsPB[newActor].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Controls.Add(actorsPB[newActor]);
            actorsPB[newActor].BringToFront();
            actorsPB[newActor].Click += (s, e) => 
            {
                if (elementManager.GetDrawMode == "Actor")
                {
                    MessageBox.Show(actor.GetName);
                }
                else if (elementManager.GetDrawMode == "Line")
                {
                    if (points == 0)
                    {
                        lineX1 = actorsPB[newActor].PointToScreen(Point.Empty).X - 80;
                        lineY1 = actorsPB[newActor].PointToScreen(Point.Empty).Y - 75;
                        points++;
                    }
                    else if (points == 1)
                    {
                        lineX2 = actorsPB[newActor].PointToScreen(Point.Empty).X - 80;
                        lineY2 = actorsPB[newActor].PointToScreen(Point.Empty).Y - 75;
                        elementManager.AddLine(new Line(lineX1,lineY1,lineX2,lineY2));
                        this.Invalidate();
                        points = 0;
                    }
                }
            };

            actorsLBL.Add(new Label());
            actorsLBL[newActor].AutoSize = true;
            actorsLBL[newActor].Location = new System.Drawing.Point(corX - 50, corY + 155);
            actorsLBL[newActor].TabIndex = 0;
            actorsLBL[newActor].Text = actor.GetName;
            actorsLBL[newActor].Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            Controls.Add(actorsLBL[newActor]);
            actorsLBL[newActor].BringToFront();
            actorsLBL[newActor].BackColor = SystemColors.ControlLightLight;
        }

        private void tsQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = elementManager.GetLineLength; i > 0; i--)
            {
                Line temp = elementManager.GetLine(i - 1);
                g.DrawLine(new Pen(Color.Black), temp.FirstPoint, temp.SecondPoint);
            }
        }

        private void tsLine_Click(object sender, EventArgs e)
        {
            elementManager.SetDrawMode = drawMode.Line;
            MessageBox.Show("Line mode enabled.\nSelect two elements to draw a line in between.");
        }
    }
}
