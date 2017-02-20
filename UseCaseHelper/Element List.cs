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
            lbList.Items.Clear();
            for (int i = 0; i <= elementManager.GetActorLength - 1; i++)

                lbList.Items.Add(elementManager.GetActor(i));
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            elementManager.CurrentElement = lbList.SelectedIndex;
            MessageBox.Show("Element succesfully selected. Click on the panel to draw.");
            this.Close();
        }


    }
}
