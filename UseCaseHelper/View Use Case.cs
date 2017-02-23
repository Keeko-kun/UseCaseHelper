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
    public partial class View_Use_Case : Form
    {
        public View_Use_Case(UseCase usecase)
        {
            InitializeComponent();
            tbName.Text = usecase.GetName;
            tbSummary.Text = usecase.GetSummary;
            tbActors.Lines = usecase.GetActors;
            tbPrecondition.Lines = usecase.GetPrecondition;
            tbFlow.Lines = usecase.GetFlow;
            tbException.Lines = usecase.GetExceptions;
            tbPostcondition.Text = usecase.GetPostcondition;
        }
    }
}
