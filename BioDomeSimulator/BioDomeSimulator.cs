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
    public partial class BioDomeSimulator : Form
    {
        BioDomeControls bioControls = new BioDomeControls();


        public static List<Label> fullBioDomeControlList = new List<Label>();
        public static List<Label> bioClimateControlList = new List<Label>();
        public static List<Label> bioClimateSeverityList = new List<Label>();
        public static List<Label> bioVentList = new List<Label>();
        public static List<Label> bioHeaterList = new List<Label>();
        public static List<Label> bioSprinklerList = new List<Label>();
        public static List<Label> bioControlsInUseList = new List<Label>();
        public static List<ComboBox> expTestcaseControlList = new List<ComboBox>();
        public static List<NumericUpDown> expTestcaseClimateValueList = new List<NumericUpDown>();

        //############################################################################################
        //############################################################################################

        // Constructor for the BioDomeSimulator Form
        public BioDomeSimulator()
        {
            InitializeComponent();

            // Create a System Timer to note elapsed Simulator Session time
            TimerManagement.GenerateSessionTimer(this);

            rtbBdlLoggingWindow.Text = "";
            rtbExpExpectedResults.Text = "";
            LoadClimateAndControlLists();
            //panelExpTestcaseImplementationTool.Visible = true;
            panelExpTestcaseImplementationTool.Visible = false;
            //panelTpTestplanImplementationTool.Visible = true;
            panelTpTestplanImplementationTool.Visible = false;
            panelBioDomeLoggingCover.Visible = true;
            //panelBioDomeLoggingCover.Visible = false;
            //panelBioDomeLogging.Visible = true;
            panelBioDomeLogging.Visible = false;
            panelBioDomeView.Visible = true;
            //panelBioDomeView.Visible = false;
            //panelBioDomeControlCover.Visible = true;
            panelBioDomeControlCover.Visible = false;
            panelMainTestPage.Visible = true;
            //panelMainTestPage.Visible = false;
            //panelTpTestplanImplementationTool.Visible = true;
            bioControls.LoadLoginInfo(this);
            bioControls.LoadETITool(this);
            bioControls.LoadAutorunThrottle(this);
        }

        //############################################################################################
        //############################################################################################

        // Method handles the functionality that is triggered when the “Turn System On/Off”
        // button is pressed. 
        private void btnBioChangeSystemState_Click(object sender, EventArgs e)
        {
            BioDomeControls bioControls = new BioDomeControls();
            if (Constants.SystemState == 0)
            {
                bioControls.SetInitialBioDomeOnDisplay(this);
                btnBioChangeSystemState.Text = "Turn System OFF";
                bioControls.LoadCurrentControlValues(this, rtbBdlLoggingWindow, rtbTPCurrentControlValues);
                bioControls.LoadCurrentControlValues(this, rtbBdlLoggingWindow, rtbExpCurrentControlValues);
                Constants.SystemState = 1;
            }
            else
            {
                //timLapsedSimulatorTime.Stop();
                DialogResult dialogResult = MessageBox.Show("  System SHUTDOWN selected!\n\n  Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                //timLapsedSimulatorTime.Start();


                if (dialogResult == DialogResult.No)
                {
                    Append(rtbBdlLoggingWindow, Constants.BLK, "   Shutdown of System: ");
                    Append(rtbBdlLoggingWindow, Constants.LIGREBLK, "ABORTED\n\n");

                }
                else if (dialogResult == DialogResult.Yes)
                {

                    Append(rtbBdlLoggingWindow, Constants.BLK, "\n   Shutdown of System: ");
                    Append(rtbBdlLoggingWindow, Constants.REDBLK, "CONFIRMED\n\n");
                    bioControls.SetBioDomeOffLineState(this);
                    btnBioChangeSystemState.Text = "Turn System ON";
                    bioControls.LoadCurrentControlValues(this, rtbBdlLoggingWindow, rtbTPCurrentControlValues);
                    bioControls.LoadCurrentControlValues(this, rtbBdlLoggingWindow, rtbExpCurrentControlValues);
                    Constants.SystemState = 0;

                }
                else if (dialogResult == DialogResult.Abort)
                {

                    Append(rtbBdlLoggingWindow, Constants.BLK, "   Shutdown of System: ");
                    Append(rtbBdlLoggingWindow, Constants.LIGREBLK, "ABORTED\n\n");
                }
            }

        }

        //############################################################################################
        //############################################################################################

        // Method runs a timer this tracks the Simulator session duration
        public void sessionTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BioDomeControls.GetSecondsMinutesHours(this);
        }

        //############################################################################################
        //############################################################################################

        public void autoRunThrottleTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

        }

        //############################################################################################
        //############################################################################################

        // Method handles displaying the current state of the system when the button 
        // btnBioViewSystemState is clicked
        private void btnBioViewSystemState_Click(object sender, EventArgs e)
        {
            BioDomeControls bioControls = new BioDomeControls();
            bioControls.DisplayBioDomeControlDetails(this);
        }

        //############################################################################################
        //############################################################################################

        // Method separates the Testbed from the Simulator when the btnTMDeCoupleTestbed
        // is clicked
        private void btnTMDeCoupleTestbed_Click(object sender, EventArgs e)
        {
            BioDomeTestBed bioDomeTestbed = new BioDomeTestBed();

            panelBioDomeTestBed.Size = new Size(2100, 0);
            bioDomeTestbed.Visible = true;
            //this.FormBorderStyle
            this.AutoSize = false;
            this.Height = 30;
        }

        //############################################################################################
        //############################################################################################

        // Method closes the Exploratory Testcase Implementation Tool and re-loads the login
        // screen when the btnExpCloseTestSessionis clicked.
        private void btnExpCloseTestSession_Click(object sender, EventArgs e)
        {
            Append(rtbBdlLoggingWindow, Constants.BLU, "\n   Closing the Exploratory Testcase Implementation Tool.\n");
            CloseTestSession();
            TestTools.DisplayCurrentSystemTime(this);
        }

        //############################################################################################
        //############################################################################################

        // Method manages the shut-down of a Exploratory or Full Testplan testing session
        private void CloseTestSession()
        {
            DialogResult dialogResult = MessageBox.Show("  You have chosen to close your Test Session!\n\n  Are you sure?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                // Stamp the Logfile
                Append(rtbBdlLoggingWindow, Constants.BLK, "\n   Closure of Test Session: ");
                Append(rtbBdlLoggingWindow, Constants.LIGREBLK, "ABORTED\n");
                Append(rtbBdlLoggingWindow, Constants.BLK, "   Current System Time: ");
                Append(rtbBdlLoggingWindow, Constants.RED, TestTools.currentTime + "\n\n");

            }
            else if (dialogResult == DialogResult.Yes)
            {
                // Stamp the Logfile
                Append(rtbBdlLoggingWindow, Constants.BLK, "\n   Closure of Test Session: ");
                Append(rtbBdlLoggingWindow, Constants.REDBLK, "CONFIRMED\n");

                // Make the Testplan login Screen visible
                panelExpTestcaseImplementationTool.Visible = false;
                panelTpTestplanImplementationTool.Visible = false;
                panelMainTestPage.Visible = true;

                // Disable the test selection options in the Testplan Login window
                rbTmExecuteSingleTestcase.Enabled = false;
                rbTmExecuteFullTestPlan.Enabled = false;

                // Clear all Login information from previous session
                cmbTmEnterTesterName.SelectedIndex = 0;
                cmbTmDesignation.SelectedIndex = 0;
                cmbTmTesterId.SelectedIndex = 0;
                tbTmDatabaseName.Text = "";
                cmbTmPathToSQLServer.SelectedIndex = 0;
            }
        }

        //############################################################################################
        //############################################################################################

        // Method clears all user inputted values in the Exploratory Testcase Implementation Tool
        // when the btnExpClearTestCase is clicked
        private void btnExpClearTestCase_Click(object sender, EventArgs e)
        {
            Append(rtbBdlLoggingWindow, Constants.BLU, "\n   Clearing all selected testcase values\n");
            TestTools.DisplayCurrentSystemTime(this);

            for (int i = 0; i < expTestcaseControlList.Count(); i++)
            {
                expTestcaseControlList[i].SelectedIndex = 0;
            }

            numExpTempValue.Value = 20;
            numExpHumidValue.Value = 0;
            numExpWindSpeedValue.Value = 0;

        }

        //############################################################################################
        //############################################################################################

        // Method calls the LoadCurrentControlValues and GenerateTestcaseResultsTemplate methods
        // that populate the Pre-Test Simulator and Expected results listboxes along with loading 
        // the control units with their potential state options when the btnExpLoadNewTestcase 
        // button is clicked. 
        private void btnExpLoadNewTestcase_Click(object sender, EventArgs e)
        {
            BioDomeControls bioControls = new BioDomeControls();
            bioControls.GenerateTestcaseResultsTemplate(this, rtbBdlLoggingWindow, rtbExpExpectedResults);
            TestTools.StringFromRichTextBox(rtbExpExpectedResults, rtbExpCurrentControlValues);
            Constants.testCaseNumber++;
        }

        //############################################################################################
        //############################################################################################

        

        //############################################################################################
        //############################################################################################

        // Method closes the Testplan Implementation Tool and re-loads the login screen
        private void btnTpCloseTestSession_Click(object sender, EventArgs e)
        {
            Append(rtbBdlLoggingWindow, Constants.BLU, "\n   Closing the Testplan Implementation Tool.\n");
            CloseTestSession();
            TestTools.DisplayCurrentSystemTime(this);
        }

        //############################################################################################
        //############################################################################################

        // Method allows the current Test case to be saved to the current Testplan when
        // the btnExpSaveTestCase button is clicked
        private void btnExpSaveTestCase_Click(object sender, EventArgs e)
        {

        }

        //############################################################################################
        //############################################################################################

        // Method allows for editing of the current testplan when the btnTpEditTestPlan
        // button is clicked
        private void btnTpEditTestPlan_Click(object sender, EventArgs e)
        {

        }

        //############################################################################################
        //############################################################################################

        // Method opens the Exploratory Testcase Implementation Tool to the user when the 
        // rbTmExecuteSingleTestcase radio button is selected.
        private void rbTmExecuteSingleTestcase_CheckedChanged(object sender, EventArgs e)
        {
            panelBioDomeControlCover.Visible = false;
            panelMainTestPage.Visible = false;
            panelBioDomeLoggingCover.Visible = false;
            panelTpTestplanImplementationTool.Visible = false;
            panelExpTestcaseImplementationTool.Visible = true;
            panelBioDomeLogging.Visible = true;
            rbTmExecuteSingleTestcase.Checked = false;
            bioControls.LoadCurrentControlValues(this, rtbBdlLoggingWindow, rtbExpCurrentControlValues);
        }

        //############################################################################################
        //############################################################################################

        // Method opens the Testplan Implementation Tool to the user when the 
        // rbTmExecuteFullTestPlan radio button is selected.
        private void rbTmExecuteFullTestPlan_CheckedChanged(object sender, EventArgs e)
        {
            panelBioDomeControlCover.Visible = false;
            panelBioDomeLoggingCover.Visible = false;
            panelMainTestPage.Visible = false;
            panelExpTestcaseImplementationTool.Visible = false;
            panelTpTestplanImplementationTool.Visible = true;
            panelBioDomeLogging.Visible = true;
            rbTmExecuteFullTestPlan.Checked = false;
            bioControls.LoadCurrentControlValues(this, rtbBdlLoggingWindow, rtbTPCurrentControlValues);
        }

        //############################################################################################
        //############################################################################################

        // Method forces the program to quit when the btnExitSimulator is selected.
        private void btnExitSimulator_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //############################################################################################
        //############################################################################################

        // Method generates a new log file when the btnBdlCreateNewLogfile is clicked.
        private void btnBdlCreateNewLogfile_Click(object sender, EventArgs e)
        {

        }

        //############################################################################################
        //############################################################################################

        // Method saves anything captured in the Logging Window to the currently
        // selected log file when the btnBdlSaveToLogfile is clicked.
        private void btnBdlSaveToLogfile_Click(object sender, EventArgs e)
        {

        }

        //############################################################################################
        //############################################################################################

        // Method clear all text from the Logging Window after saving it to the currently 
        // selected log file or temporary text file if no log file has been opened or 
        // selected when the btnBdlClearLoggingWindow button is clicked.
        private void btnBdlClearLoggingWindow_Click(object sender, EventArgs e)
        {

        }

        //############################################################################################
        //############################################################################################

        // Method prints the test results of the current test run when the 
        // btnBdlPrintTestReport is selected.
        private void btnBdlPrintTestReport_Click(object sender, EventArgs e)
        {

        }

        //############################################################################################
        //############################################################################################

        // Method prints out the contents of the currently selected log file when
        // the btnBdlPrintLogReport is selected.
        private void btnBdlPrintLogReport_Click(object sender, EventArgs e)
        {

        }

        //############################################################################################
        //############################################################################################

        private void btnToStart_Click(object sender, EventArgs e)
        {
            // Load the first Holiday record
            //frmHolidayControls.LoadHolidayRecord(0);                                      ############# Here ##################
            // Set the Holiday list positioning variable to the first Holiday record
            SqlCommandHandler.listPosition = 0;
        }

        //############################################################################################
        //############################################################################################

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (SqlCommandHandler.listPosition - 1 >= 0)
            {
                // Load the previous Holiday record
                //frmHolidayControls.LoadHolidayRecord(SqlCommandHandler.listPosition - 1); ############## Here ###################
                // Set the Holiday list positioning variable to the previous student record
                SqlCommandHandler.listPosition--;
            }
        }

        //############################################################################################
        //############################################################################################

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (SqlCommandHandler.listPosition + 1 <= SqlCommandHandler.testCaseCount - 1)
            {
                // Load the next Holiday record
                //frmHolidayControls.LoadHolidayRecord(SqlCommandHandler.listPosition + 1); ############## Here ###################
                // Set the Holiday list positioning variable to the next Holiday record
                SqlCommandHandler.listPosition++;
            }
        }

        //############################################################################################
        //############################################################################################

        private void btnEnd_Click(object sender, EventArgs e)
        {
            // Load the last Holiday record
            //frmHolidayControls.LoadHolidayRecord(SqlCommandHandler.recordCount - 1);  ############## Here ###################
            // Set the Holiday list positioning variable to the last Holiday record
            SqlCommandHandler.listPosition = SqlCommandHandler.testCaseCount - 1;
        }

        //############################################################################################
        //############################################################################################




        // Method loads all the control unit object lists. These object lists will be 
        // used to change the background color of the graphical representations of the
        // Simulator control units 
        public void LoadClimateAndControlLists()
        {

            // Load the FULL Bio-Dome Climate and Control List fullBioDomeControlList
            fullBioDomeControlList.Add(lblBioCurTempOptimal);
            fullBioDomeControlList.Add(lblBioCurHumOptimal);
            fullBioDomeControlList.Add(lblBioCurWindSpeedOptimal);
            fullBioDomeControlList.Add(lblBioCurTempTooHot);
            fullBioDomeControlList.Add(lblBioCurTempTooCold);
            fullBioDomeControlList.Add(lblBioCurHumTooHum);
            fullBioDomeControlList.Add(lblBioCurHumTooDry);
            fullBioDomeControlList.Add(lblBioCurWindSpeedHigh);
            fullBioDomeControlList.Add(lblBioTempLevel0);
            fullBioDomeControlList.Add(lblBioHumidLevel0);
            fullBioDomeControlList.Add(lblBioWindSpeedLevel0);
            fullBioDomeControlList.Add(lblBioTempLevel1);
            fullBioDomeControlList.Add(lblBioHumidLevel1);
            fullBioDomeControlList.Add(lblBioWindSpeedLevel1);
            fullBioDomeControlList.Add(lblBioTempLevel2);
            fullBioDomeControlList.Add(lblBioHumidLevel2);
            fullBioDomeControlList.Add(lblBioWindSpeedLevel2);
            fullBioDomeControlList.Add(lblBioTempLevel3);
            fullBioDomeControlList.Add(lblBioHumidLevel3);
            fullBioDomeControlList.Add(lblBioWindSpeedLevel3);
            fullBioDomeControlList.Add(lblBioHeater1Off);
            fullBioDomeControlList.Add(lblBioHeater2Off);
            fullBioDomeControlList.Add(lblBioHeater3Off);
            fullBioDomeControlList.Add(lblBioHeater4Off);
            fullBioDomeControlList.Add(lblBioHeater1On);
            fullBioDomeControlList.Add(lblBioHeater2On);
            fullBioDomeControlList.Add(lblBioHeater3On);
            fullBioDomeControlList.Add(lblBioHeater4On);
            fullBioDomeControlList.Add(lblBioVent1Closed);
            fullBioDomeControlList.Add(lblBioVent2Closed);
            fullBioDomeControlList.Add(lblBioVent3Closed);
            fullBioDomeControlList.Add(lblBioVent4Closed);
            fullBioDomeControlList.Add(lblBioVent1HalfOpen);
            fullBioDomeControlList.Add(lblBioVent2HalfOpen);
            fullBioDomeControlList.Add(lblBioVent3HalfOpen);
            fullBioDomeControlList.Add(lblBioVent4HalfOpen);
            fullBioDomeControlList.Add(lblBioVent1Open);
            fullBioDomeControlList.Add(lblBioVent2Open);
            fullBioDomeControlList.Add(lblBioVent3Open);
            fullBioDomeControlList.Add(lblBioVent4Open);
            fullBioDomeControlList.Add(lblBioSprink1Off);
            fullBioDomeControlList.Add(lblBioSprink2Off);
            fullBioDomeControlList.Add(lblBioSprink1On);
            fullBioDomeControlList.Add(lblBioSprink2On);
            fullBioDomeControlList.Add(lblHeater1InUse);
            fullBioDomeControlList.Add(lblHeater2InUse);
            fullBioDomeControlList.Add(lblHeater3InUse);
            fullBioDomeControlList.Add(lblHeater4InUse);
            fullBioDomeControlList.Add(lblVent1InUse);
            fullBioDomeControlList.Add(lblVent2InUse);
            fullBioDomeControlList.Add(lblVent3InUse);
            fullBioDomeControlList.Add(lblVent4InUse);
            fullBioDomeControlList.Add(lblSprink1InUse);
            fullBioDomeControlList.Add(lblSprink2InUse);

            // Load the Climate Control List bioClimateControlList
            bioClimateControlList.Add(lblBioCurTempOptimal);
            bioClimateControlList.Add(lblBioCurTempTooHot);
            bioClimateControlList.Add(lblBioCurTempTooCold);
            bioClimateControlList.Add(lblBioCurHumOptimal);
            bioClimateControlList.Add(lblBioCurHumTooHum);
            bioClimateControlList.Add(lblBioCurHumTooDry);
            bioClimateControlList.Add(lblBioCurWindSpeedOptimal);
            bioClimateControlList.Add(lblBioCurWindSpeedHigh);

            // Load the Climate Severity List bioClimateSeverityList
            bioClimateSeverityList.Add(lblBioTempLevel0);
            bioClimateSeverityList.Add(lblBioTempLevel1);
            bioClimateSeverityList.Add(lblBioTempLevel2);
            bioClimateSeverityList.Add(lblBioTempLevel3);
            bioClimateSeverityList.Add(lblBioHumidLevel0);
            bioClimateSeverityList.Add(lblBioHumidLevel1);
            bioClimateSeverityList.Add(lblBioHumidLevel2);
            bioClimateSeverityList.Add(lblBioHumidLevel3);
            bioClimateSeverityList.Add(lblBioWindSpeedLevel0);
            bioClimateSeverityList.Add(lblBioWindSpeedLevel1);
            bioClimateSeverityList.Add(lblBioWindSpeedLevel2);
            bioClimateSeverityList.Add(lblBioWindSpeedLevel3);

            // Load the Ventilation Control List bioVentList
            bioVentList.Add(lblBioVent1Closed);
            bioVentList.Add(lblBioVent1HalfOpen);
            bioVentList.Add(lblBioVent1Open);
            bioVentList.Add(lblBioVent2Closed);
            bioVentList.Add(lblBioVent2HalfOpen);
            bioVentList.Add(lblBioVent2Open);
            bioVentList.Add(lblBioVent3Closed);
            bioVentList.Add(lblBioVent3HalfOpen);
            bioVentList.Add(lblBioVent3Open);
            bioVentList.Add(lblBioVent4Closed);
            bioVentList.Add(lblBioVent4HalfOpen);
            bioVentList.Add(lblBioVent4Open);

            // Load the Heater Control List bioHeaterList
            bioHeaterList.Add(lblBioHeater1Off);
            bioHeaterList.Add(lblBioHeater1On);
            bioHeaterList.Add(lblBioHeater2Off);
            bioHeaterList.Add(lblBioHeater2On);
            bioHeaterList.Add(lblBioHeater3Off);
            bioHeaterList.Add(lblBioHeater3On);
            bioHeaterList.Add(lblBioHeater4Off);
            bioHeaterList.Add(lblBioHeater4On);

            // Load the Sprinkler Control List bioSprinklerList
            bioSprinklerList.Add(lblBioSprink1Off);
            bioSprinklerList.Add(lblBioSprink1On);
            bioSprinklerList.Add(lblBioSprink2Off);
            bioSprinklerList.Add(lblBioSprink2On);

            // Load the Controls in Use List bioControlsInUseList
            bioControlsInUseList.Add(lblHeater1InUse);
            bioControlsInUseList.Add(lblHeater2InUse);
            bioControlsInUseList.Add(lblHeater3InUse);
            bioControlsInUseList.Add(lblHeater4InUse);
            bioControlsInUseList.Add(lblVent1InUse);
            bioControlsInUseList.Add(lblVent2InUse);
            bioControlsInUseList.Add(lblVent3InUse);
            bioControlsInUseList.Add(lblVent4InUse);
            bioControlsInUseList.Add(lblSprink1InUse);
            bioControlsInUseList.Add(lblSprink2InUse);

            // Load the Exploratory Testcase Control Unit Value List
            expTestcaseControlList.Add(cmbExpHeater1);
            expTestcaseControlList.Add(cmbExpHeater2);
            expTestcaseControlList.Add(cmbExpHeater3);
            expTestcaseControlList.Add(cmbExpHeater4);
            expTestcaseControlList.Add(cmbExpVent1);
            expTestcaseControlList.Add(cmbExpVent2);
            expTestcaseControlList.Add(cmbExpVent3);
            expTestcaseControlList.Add(cmbExpVent4);
            expTestcaseControlList.Add(cmbExpSprink1);
            expTestcaseControlList.Add(cmbExpSprink2);

            // Load the Exploratory Testcase Climate Value List
            expTestcaseClimateValueList.Add(numExpTempValue);
            expTestcaseClimateValueList.Add(numExpHumidValue);
            expTestcaseClimateValueList.Add(numExpWindSpeedValue);
        }

        //############################################################################################
        //############################################################################################

        // Method provides the mechanism to change the foreground and 
        // background color of any word or sequence of words in the 
        // Logging Window allowing for a color rich reporting environment
        // within the Logging Window text area.  
        public void Append(RichTextBox rtb, String color, String s)
        {
            switch (color)
            {
                case "Black":
                    rtb.SelectionColor = Color.Black;
                    break;
                case "Green":
                    rtb.SelectionColor = Color.Green;
                    break;
                case "Red":
                    rtb.SelectionColor = Color.Red;
                    break;
                case "Blue":
                    rtb.SelectionColor = Color.Blue;
                    break;
                case "Orange":
                    rtb.SelectionColor = Color.Orange;
                    break;
                case "Yellow":
                    rtb.SelectionColor = Color.Yellow;
                    break;
                case "Lime":
                    rtb.SelectionColor = Color.Lime;
                    break;
                case "BlackWhite":
                    rtb.SelectionColor = Color.Black;
                    rtb.SelectionBackColor = Color.White;
                    break;
                case "YellowBlack":
                    rtb.SelectionColor = Color.Black;
                    rtb.SelectionBackColor = Color.Yellow;
                    break;
                case "GreenBlack":
                    rtb.SelectionColor = Color.Black;
                    rtb.SelectionBackColor = Color.Green;
                    break;
                case "LimeBlack":
                    rtb.SelectionColor = Color.Black;
                    rtb.SelectionBackColor = Color.Lime;
                    break;
                case "RedBlack":
                    rtb.SelectionColor = Color.Black;
                    rtb.SelectionBackColor = Color.Red;
                    break;
                case "BlueYellow":
                    rtb.SelectionColor = Color.Yellow;
                    rtb.SelectionBackColor = Color.Blue;
                    break;
                case "OrangeBlack":
                    rtb.SelectionColor = Color.Black;
                    rtb.SelectionBackColor = Color.Orange;
                    break;
                default:
                    rtb.SelectionColor = Color.Black;
                    rtb.SelectionBackColor = Color.White;
                    break;
            }

            try
            {
                rtb.AppendText(s);
                rtb.ScrollToCaret();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        //############################################################################################
        //############################################################################################

        // Method creates a new testplan in the SQL database by creating a new
        // testplan table in the BioDomeTestPlans Database. 
        private void btnTPCreateNewTestplan_Click(object sender, EventArgs e)
        {

        }

        private void btnTmLoadDefaultServerSettings_Click(object sender, EventArgs e)
        {
            cmbTmEnterTesterName.SelectedIndex = 4;
            cmbTmDesignation.SelectedIndex = 5;
            cmbTmTesterId.SelectedIndex = 5;
            tbTmDatabaseName.Text = "BioDomeTestPlans";
            cmbTmPathToSQLServer.SelectedIndex = 1;

        }

        //############################################################################################
        //############################################################################################

        private void btnTmLogIntoTesterDataBase_Click(object sender, EventArgs e)
        {
            SqlCommandHandler.ValidateLoginDetails(this);
        }

        //############################################################################################
        //############################################################################################

        // Close the Logging Window covers and display the Logging Window
        private void btnOpenLoggingWindow_Click(object sender, EventArgs e)
        {
            panelBioDomeLoggingCover.Visible = false;
            panelBioDomeLogging.Visible = true;
        }

        //############################################################################################
        //############################################################################################

    }
}


/*private void btnBioViewSystemState_Paint(object sender, PaintEventArgs e)
  {
      ControlPaint.DrawBorder(e.Graphics, btnBioViewSystemState.ClientRectangle,
          SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
          SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
          SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
          SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
  }*/
