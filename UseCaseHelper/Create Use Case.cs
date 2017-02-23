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
    public partial class Create_Use_Case : Form
    {
        Element elementManager;

        public Create_Use_Case(Element elementManager)
        {
            InitializeComponent();
            this.elementManager = elementManager;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UseCase newCase;
            newCase = new UseCase(tbName.Text, tbSummary.Text, tbActors.Lines, tbPrecondition.Lines, tbFlow.Lines, tbException.Lines, tbPostcondition.Text);
            elementManager.AddCase(newCase);
            this.Close();
        }
    }
}
