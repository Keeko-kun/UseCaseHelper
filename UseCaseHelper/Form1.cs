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
        List<PictureBox> casePB = new List<PictureBox>();
        List<Label> caseLBL = new List<Label>();

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
                if (elementManager.CurrentElement != -1)
                {
                    CreateCase(e.X, e.Y, elementManager.GetCase(elementManager.CurrentElement));
                }
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
            actorsPB[newActor].BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(actorsPB[newActor]);
            actorsPB[newActor].BringToFront();
            actorsPB[newActor].Click += (s, e) => 
            {
                if (elementManager.GetDrawMode == "Line")
                {
                    if (points == 0)
                    {
                        lineX1 = actorsPB[newActor].Location.X + 75;
                        lineY1 = actorsPB[newActor].Location.Y;
                        points++;
                    }
                    else if (points == 1)
                    {
                        lineX2 = actorsPB[newActor].Location.X + 75;
                        lineY2 = actorsPB[newActor].Location.Y;
                        elementManager.AddLine(new Line(lineX1, lineY1, lineX2, lineY2));
                        this.Invalidate();
                        panel1.Invalidate();
                        points = 0;
                    }
                }
                else
                {
                    View_Actor viewActor = new View_Actor(actor);
                    viewActor.Show();
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

        private void CreateCase (int corX, int corY, UseCase newUseCase)
        {
            casePB.Add(new PictureBox());
            int newCase = casePB.Count - 1;
            casePB[newCase].BackgroundImage = Properties.Resources._2000px_Circle___black_simple_svg;
            casePB[newCase].BackColor = SystemColors.ControlLightLight;
            casePB[newCase].Location = new System.Drawing.Point(corX - 200, corY);
            casePB[newCase].Size = new System.Drawing.Size(432, 115);
            casePB[newCase].BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(casePB[newCase]);
            casePB[newCase].BringToFront();
            casePB[newCase].Click += (s, e) =>
            {
                if (elementManager.GetDrawMode == "Line")
                {
                    if (points == 0)
                    {
                        lineX1 = casePB[newCase].Location.X + 125;
                        lineY1 = casePB[newCase].Location.Y;
                        points++;
                    }
                    else if (points == 1)
                    {
                        lineX2 = casePB[newCase].Location.X + 125;
                        lineY2 = casePB[newCase].Location.Y;
                        elementManager.AddLine(new Line(lineX1, lineY1, lineX2, lineY2));
                        this.Invalidate();
                        panel1.Invalidate();
                        points = 0;
                    }
                }
                else
                {
                    View_Use_Case viewCase = new View_Use_Case(newUseCase);
                    viewCase.Show();
                }
            };

            caseLBL.Add(new Label());
            caseLBL[newCase].AutoSize = false;
            caseLBL[newCase].Anchor = System.Windows.Forms.AnchorStyles.None;
            caseLBL[newCase].Location = new System.Drawing.Point(corX - 150, corY + 45);
            caseLBL[newCase].TabIndex = 1;
            caseLBL[newCase].Text = newUseCase.GetName;
            caseLBL[newCase].Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            caseLBL[newCase].Size = new System.Drawing.Size(332, 23);
            caseLBL[newCase].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Controls.Add(caseLBL[newCase]);
            caseLBL[newCase].BringToFront();
            caseLBL[newCase].BackColor = SystemColors.ControlLightLight;
            caseLBL[newCase].Click += (s, e) =>
             {
                 if (elementManager.GetDrawMode == "Line")
                 {
                     if (points == 0)
                     {
                         lineX1 = casePB[newCase].Location.X + 125;
                         lineY1 = casePB[newCase].Location.Y;
                         points++;
                     }
                     else if (points == 1)
                     {
                         lineX2 = casePB[newCase].Location.X + 125;
                         lineY2 = casePB[newCase].Location.Y;
                         elementManager.AddLine(new Line(lineX1, lineY1, lineX2, lineY2));
                         this.Invalidate();
                         panel1.Invalidate();
                         points = 0;
                     }
                 }
                 else
                 {
                     View_Use_Case viewCase = new View_Use_Case(newUseCase);
                     viewCase.Show();
                 }
             };

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

        private void tsUseCase_Click(object sender, EventArgs e)
        {
            Create_Use_Case createUseCase = new Create_Use_Case(elementManager);
            createUseCase.ShowDialog();
        }

        private void btnExitLineMode_Click(object sender, EventArgs e)
        {
            elementManager.SetDrawMode = drawMode.Actor;
            elementManager.CurrentElement = -1;
        }

        private void btnClearAllLines_Click(object sender, EventArgs e)
        {
            elementManager.ClearLines();
            this.Invalidate();
            panel1.Invalidate();
        }

        private void btnUndoActor_Click(object sender, EventArgs e)
        {
            if (actorsPB.Count > 0)
            {
                Controls.Remove(actorsPB[actorsPB.Count - 1]);
                Controls.Remove(actorsLBL[actorsLBL.Count - 1]);
                actorsPB.Remove(actorsPB[actorsPB.Count - 1]);
                actorsLBL.Remove(actorsLBL[actorsLBL.Count - 1]);
            }

        }

        private void btnUndoCase_Click(object sender, EventArgs e)
        {
            Controls.Remove(casePB[casePB.Count - 1]);
            Controls.Remove(caseLBL[caseLBL.Count - 1]);
            casePB.Remove(casePB[casePB.Count - 1]);
            caseLBL.Remove(caseLBL[caseLBL.Count - 1]);
        }
    }
}
