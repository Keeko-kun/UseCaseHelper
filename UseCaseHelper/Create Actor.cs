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
    public partial class Create_Actor : Form
    {

        Element elementManager = new Element();

        public Create_Actor(Element elementManager)
        {
            InitializeComponent();
            this.elementManager = elementManager;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Actor newActor;
            newActor = new Actor(tbName.Text, tbDescription.Lines);
            elementManager.AddActor(newActor);
            this.Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            Graphics name = pnlActor.CreateGraphics();
            pnlActor.Refresh();
            Brush b = new SolidBrush(Color.Black);
            name.DrawString(tbName.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular), b, 110, 220);
        }

        private void pnlActor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(pnlActor.Width, pnlActor.Height), Point.Empty);
            Graphics g = pnlActor.CreateGraphics();
            Pen p = new Pen(Color.Black, 2);
            Brush b = new SolidBrush(Color.Black);

            g.DrawEllipse(p, 125, 50, 50, 50);
            g.DrawLine(p, 150, 100, 150, 175);
            g.DrawLine(p, 150, 135, 104, 85);
            g.DrawLine(p, 150, 135, 196, 85);
            g.DrawLine(p, 150, 175, 186, 215);
            g.DrawLine(p, 150, 175, 114, 215);
        }

    }
}
