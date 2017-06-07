using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioDomeSimulator
{
    public partial class BioDomeTestBed : Form
    {
        public BioDomeTestBed()
        {
            InitializeComponent();
        }

        private void btnReAttachTestBed_Click(object sender, EventArgs e)
        {
            BioDomeSimulator bioDome = new BioDomeSimulator();

            bioDome.panelBioDomeTestBed.Size = new Size(2100, 1109);
            this.Visible = false;
            //bioDome. = 1890;

        }

        private void rbTmExecuteSingleTestcase_CheckedChanged(object sender, EventArgs e)
        {
            BioDomeSimulator bioDome = new BioDomeSimulator();

            bioDome.panelBioDomeControlCover.Visible = false;
            panelMainTestPage.Visible = false;
            panelBioDomeLoggingCover.Visible = false;
            panelExpTestcaseImplementationTool.Visible = true;
            bioDome.panelBioDomeView.Visible = true;
            panelBioDomeLogging.Visible = true;
            rbTmExecuteSingleTestcase.Checked = false;

        }
    }
}
