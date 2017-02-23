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
    public partial class Element_List : Form
    {

        Element elementManager = new Element();

        public Element_List(Element elementManager)
        {
            InitializeComponent();
            this.elementManager = elementManager;
        }

        private void Element_List_Load(object sender, EventArgs e)
        {
            rbActor.Checked = true;
            lbList.Items.Clear();
            for (int i = 0; i <= elementManager.GetActorLength - 1; i++)
            {
                lbList.Items.Add(elementManager.GetActor(i));
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lbList.SelectedItem == null)
            {
                MessageBox.Show("Please select an element.");
            }
            else
            {
                elementManager.CurrentElement = lbList.SelectedIndex;
                if (rbActor.Checked)
                {
                    elementManager.SetDrawMode = drawMode.Actor;
                }
                else if (rbCase.Checked)
                {
                    elementManager.SetDrawMode = drawMode.Case;
                }
                MessageBox.Show("Element succesfully selected. Click on the panel to draw.");
                this.Close();
            }
        }

        private void rbActor_CheckedChanged(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            for (int i = 0; i <= elementManager.GetActorLength - 1; i++)
            {
                lbList.Items.Add(elementManager.GetActor(i));
            }
        }

        private void rbCase_CheckedChanged(object sender, EventArgs e)
        {
            lbList.Items.Clear();
            //for (int i = 0; i <= elementManager.GetActorLength - 1; i++)
            //{
            //    lbList.Items.Add(elementManager.GetActor(i));
            //}
        }
    }
}
