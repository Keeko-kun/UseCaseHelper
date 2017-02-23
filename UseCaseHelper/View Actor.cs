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
        public View_Actor(Actor actor)
        {
            InitializeComponent();
            tbName.Text = actor.GetName;
            tbDescription.Lines = actor.GetDescription;
        }
    }
}