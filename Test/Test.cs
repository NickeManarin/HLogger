using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logger;

namespace Test
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btnLogMe_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Title = tbPageTitle.Text;
                Log.Header = tbHeader.Text;
                Log.ProjectName = tbProject.Text;
                Log.ProjectPath = tbProjectPath.Text;

                Log.ExpandErrors = cbExpandErrors.Checked;
                Log.ExpandWarnings = cbExpandWarnings.Checked;
                Log.ExpandMessages = cbExpandMessages.Checked;
                Log.ExpandSuccesses = cbExpandSuccesses.Checked;

                Log.Folder = Application.StartupPath;
                Log.Me();

                tooltip.ToolTipTitle = "Logged!";
                tooltip.ToolTipIcon = ToolTipIcon.Info;
                tooltip.Show("Everything fine", btnLogMe, 0, btnLogMe.Height, 2000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while logging: " + ex.Message, "Error Logging", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnException_Click(object sender, EventArgs e)
        {
            Log.Exceptions.Add(tbException.Text);
            
            //or:
            //Log.Exceptions.Add(new Exception(tbException.Text));
            //or:

            try
            {
                string test = null;
                if (test.Length > 0) //Exception.
                    test = "";
            }
            catch (Exception ex)
            {
                Log.Exceptions.Add(ex);
            }

            tooltip.ToolTipTitle = "Exception";
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.Show("Exception added", tbException, 0, tbException.Height, 1500);
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            Log.Warnings.Add(tbWarning.Text);

            tooltip.ToolTipTitle = "Warning";
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.Show("Warning added", tbWarning, 0, tbWarning.Height, 1500);
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            Log.Messages.Add(tbMessage.Text);

            tooltip.ToolTipTitle = "Message";
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.Show("Message added", tbMessage, 0, tbMessage.Height, 1500);
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            Log.Successes.Add(tbSuccess.Text);

            tooltip.ToolTipTitle = "Success";
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.Show("Success added", tbSuccess, 0, tbSuccess.Height, 1500);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Log.Clean();

            tooltip.ToolTipTitle = "Cleaned";
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.Show("All cleaned.", btnClean, 0, btnClean.Height, 1500);
        }
    }
}
