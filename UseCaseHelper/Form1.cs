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
            if (elementManager.CurrentElement != -1)
            {
                CreateActor(e.X, e.Y, elementManager.GetActor(elementManager.CurrentElement));
            }
           else
            {
                MessageBox.Show("Please select an element.");
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
                MessageBox.Show(actor.GetName);
            };

            actorsLBL.Add(new Label());
            actorsLBL[newActor].AutoSize = true;
            actorsLBL[newActor].Location = new System.Drawing.Point(corX - 50, corY + 155);
            actorsLBL[newActor].TabIndex = 0;
            actorsLBL[newActor].Text = actor.GetName;
            actorsLBL[newActor].Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            Controls.Add(actorsLBL[newActor]);
            actorsLBL[newActor].BringToFront();
            actorsLBL[newActor].BackColor = Color.Transparent;
        }

    }
}
