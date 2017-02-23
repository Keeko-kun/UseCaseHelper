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
    public partial class View_Actor : Form
    {

        string s = "";

        public View_Actor(Actor actor)
        {
            InitializeComponent();
            tbName.Text = actor.GetName;
            for (int i = 0; i < actor.GetDescription.Length; i++)
            {
                if (i == 0)
                {
                    tbDescription.Text += actor.GetDescription[i];
                }
                else
                {
                    tbDescription.Text += "\r\n";
                    tbDescription.Text += actor.GetDescription[i];
                }
            }
        }
    }
}