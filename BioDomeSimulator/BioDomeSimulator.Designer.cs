using System.Drawing;

namespace BioDomeSimulator
{
    partial class BioDomeSimulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBioDomeView = new System.Windows.Forms.Panel();
            this.panelBioResourceAvailability = new System.Windows.Forms.Panel();
            this.tbBioDomeControlsInUse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAvailableResource = new System.Windows.Forms.Label();
            this.lblAvailableGreen = new System.Windows.Forms.Label();
            this.lblPartiallyAvailOrange = new System.Windows.Forms.Label();
            this.lblPartiallyAvailableResources = new System.Windows.Forms.Label();
            this.lblUnavailableRed = new System.Windows.Forms.Label();
            this.lblUnavailableResources = new System.Windows.Forms.Label();
            this.lblSprink2InUse = new System.Windows.Forms.Label();
            this.lblSprink1InUse = new System.Windows.Forms.Label();
            this.lblSprinklersInUse = new System.Windows.Forms.Label();
            this.lblVent4InUse = new System.Windows.Forms.Label();
            this.lblVent3InUse = new System.Windows.Forms.Label();
            this.lblVent2InUse = new System.Windows.Forms.Label();
            this.lblVent1InUse = new System.Windows.Forms.Label();
            this.lblVentsInUse = new System.Windows.Forms.Label();
            this.lblHeater4InUse = new System.Windows.Forms.Label();
            this.lblHeater3InUse = new System.Windows.Forms.Label();
            this.lblHeater2InUse = new System.Windows.Forms.Label();
            this.lblHeater1InUse = new System.Windows.Forms.Label();
            this.lblHeatersInUse = new System.Windows.Forms.Label();
            this.lblResourceAvailability = new System.Windows.Forms.Label();
            this.panelBioCurrentClimateValues = new System.Windows.Forms.Panel();
            this.lblBioCurrentClimateValues = new System.Windows.Forms.Label();
            this.tbCurWindSpeedReading = new System.Windows.Forms.TextBox();
            this.lblCurWindSpeedReading = new System.Windows.Forms.Label();
            this.tbCurHumidReading = new System.Windows.Forms.TextBox();
            this.lblCurHumidReading = new System.Windows.Forms.Label();
            this.tbCurTempReading = new System.Windows.Forms.TextBox();
            this.lblCurTempReading = new System.Windows.Forms.Label();
            this.pbBioCompanyLogo = new System.Windows.Forms.PictureBox();
            this.panelCurrentSystemControl = new System.Windows.Forms.Panel();
            this.BioDomeTestInterval = new System.Windows.Forms.Label();
            this.lblBioTimeLapsedSinceStartOfTestSession = new System.Windows.Forms.Label();
            this.btnBioViewSystemState = new System.Windows.Forms.Button();
            this.btnBioChangeSystemState = new System.Windows.Forms.Button();
            this.lblBioCurrentStatusValue = new System.Windows.Forms.Label();
            this.lblBioCurrentStatus = new System.Windows.Forms.Label();
            this.panelBioMoistureControlView = new System.Windows.Forms.Panel();
            this.lblBioSprink2On = new System.Windows.Forms.Label();
            this.lblBioSprink1On = new System.Windows.Forms.Label();
            this.lblBioSprink2Off = new System.Windows.Forms.Label();
            this.lblBioSprink1Off = new System.Windows.Forms.Label();
            this.lblSprinkler2 = new System.Windows.Forms.Label();
            this.lblSprinkler1 = new System.Windows.Forms.Label();
            this.lblMoistureControlView = new System.Windows.Forms.Label();
            this.panelBioVentilationControlView = new System.Windows.Forms.Panel();
            this.lblBioVent4Open = new System.Windows.Forms.Label();
            this.lblBioVent3Open = new System.Windows.Forms.Label();
            this.lblBioVent2Open = new System.Windows.Forms.Label();
            this.lblBioVent4HalfOpen = new System.Windows.Forms.Label();
            this.lblBioVent3HalfOpen = new System.Windows.Forms.Label();
            this.lblBioVent2HalfOpen = new System.Windows.Forms.Label();
            this.lblBioVent4Closed = new System.Windows.Forms.Label();
            this.lblBioVent3Closed = new System.Windows.Forms.Label();
            this.lblBioVent2Closed = new System.Windows.Forms.Label();
            this.lblBioVent1Open = new System.Windows.Forms.Label();
            this.lblBioVent1HalfOpen = new System.Windows.Forms.Label();
            this.lblBioVent1Closed = new System.Windows.Forms.Label();
            this.lblVentilationUnit4 = new System.Windows.Forms.Label();
            this.lblVentilationUnit3 = new System.Windows.Forms.Label();
            this.lblVentilationUnit2 = new System.Windows.Forms.Label();
            this.lblVentilationUnit1 = new System.Windows.Forms.Label();
            this.lblVentilationControlView = new System.Windows.Forms.Label();
            this.panelBioTempControlView = new System.Windows.Forms.Panel();
            this.lblBioHeater4On = new System.Windows.Forms.Label();
            this.lblBioHeater4Off = new System.Windows.Forms.Label();
            this.lblBioHeater3On = new System.Windows.Forms.Label();
            this.lblBioHeater3Off = new System.Windows.Forms.Label();
            this.lblBioHeater2On = new System.Windows.Forms.Label();
            this.lblBioHeater2Off = new System.Windows.Forms.Label();
            this.lblBioHeater1On = new System.Windows.Forms.Label();
            this.lblBioHeater1Off = new System.Windows.Forms.Label();
            this.lblHeater4 = new System.Windows.Forms.Label();
            this.lblHeater3 = new System.Windows.Forms.Label();
            this.lblHeater2 = new System.Windows.Forms.Label();
            this.lblHeater1 = new System.Windows.Forms.Label();
            this.lblTemperatureControlView = new System.Windows.Forms.Label();
            this.panelBioExternalClimateControlView1_1 = new System.Windows.Forms.Panel();
            this.tbWindAvailControls = new System.Windows.Forms.TextBox();
            this.tbWindUsedControls = new System.Windows.Forms.TextBox();
            this.tbHumAvailControls = new System.Windows.Forms.TextBox();
            this.tbHumUsedControls = new System.Windows.Forms.TextBox();
            this.tbTempAvailControls = new System.Windows.Forms.TextBox();
            this.tbTempUsedControls = new System.Windows.Forms.TextBox();
            this.lblControlUnitsB = new System.Windows.Forms.Label();
            this.lblControlUnitsA = new System.Windows.Forms.Label();
            this.lblControlsUsed = new System.Windows.Forms.Label();
            this.lblBioWindSpeedLevel0 = new System.Windows.Forms.Label();
            this.lblBioHumidLevel0 = new System.Windows.Forms.Label();
            this.lblBioTempLevel0 = new System.Windows.Forms.Label();
            this.lblBioWindSpeedLevel3 = new System.Windows.Forms.Label();
            this.lblBioWindSpeedLevel2 = new System.Windows.Forms.Label();
            this.lblBioWindSpeedLevel1 = new System.Windows.Forms.Label();
            this.lblCurWindSeverity = new System.Windows.Forms.Label();
            this.lblBioCurWindSpeedHigh = new System.Windows.Forms.Label();
            this.lblBioCurWindSpeedOptimal = new System.Windows.Forms.Label();
            this.lblBioHumidLevel3 = new System.Windows.Forms.Label();
            this.lblBioHumidLevel2 = new System.Windows.Forms.Label();
            this.lblBioHumidLevel1 = new System.Windows.Forms.Label();
            this.lblCurHumSeverity = new System.Windows.Forms.Label();
            this.lblBioCurHumTooDry = new System.Windows.Forms.Label();
            this.lblBioCurHumTooHum = new System.Windows.Forms.Label();
            this.lblBioCurHumOptimal = new System.Windows.Forms.Label();
            this.lblBioTempLevel3 = new System.Windows.Forms.Label();
            this.lblBioTempLevel2 = new System.Windows.Forms.Label();
            this.lblBioTempLevel1 = new System.Windows.Forms.Label();
            this.lblCurTempSeverity = new System.Windows.Forms.Label();
            this.lblBioCurTempTooCold = new System.Windows.Forms.Label();
            this.lblBioCurTempTooHot = new System.Windows.Forms.Label();
            this.lblBioCurTempOptimal = new System.Windows.Forms.Label();
            this.lblCurrentWindClimateView = new System.Windows.Forms.Label();
            this.lblCurrentHumidClimateView = new System.Windows.Forms.Label();
            this.lblBioDomeClimateView = new System.Windows.Forms.Label();
            this.lblCurTempClimateView = new System.Windows.Forms.Label();
            this.panelBioDomeTestBed = new System.Windows.Forms.Panel();
            this.panelBioDomeLogging = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblBdlLoggingWindow = new System.Windows.Forms.Label();
            this.btnBdlClearLoggingWindow = new System.Windows.Forms.Button();
            this.btnBdlSaveToLogfile = new System.Windows.Forms.Button();
            this.btnBdlPrintLogReport = new System.Windows.Forms.Button();
            this.btnBdlPrintTestReport = new System.Windows.Forms.Button();
            this.btnBdlCreateNewLogfile = new System.Windows.Forms.Button();
            this.tbBdlLoggingFilename = new System.Windows.Forms.TextBox();
            this.lblBdlLoggingFileName = new System.Windows.Forms.Label();
            this.rtbBdlLoggingWindow = new System.Windows.Forms.RichTextBox();
            this.lblBdlLoggingAndReportingTool = new System.Windows.Forms.Label();
            this.panelBioDomeLoggingCover = new System.Windows.Forms.Panel();
            this.btnOpenLoggingWindow = new System.Windows.Forms.Button();
            this.pbBioLoggingCoverTop = new System.Windows.Forms.PictureBox();
            this.pbBioLoggingCoverBottom = new System.Windows.Forms.PictureBox();
            this.panelExpTestcaseImplementationTool = new System.Windows.Forms.Panel();
            this.tbCurrentTestCaseSelected = new System.Windows.Forms.TextBox();
            this.labCurrentTestCase = new System.Windows.Forms.Label();
            this.btnExpLogDefectIncident = new System.Windows.Forms.Button();
            this.cmbSelectATestPlanFromTheList = new System.Windows.Forms.ComboBox();
            this.lblExpSelectTestPlan = new System.Windows.Forms.Label();
            this.lblExpCurrentControlValues = new System.Windows.Forms.Label();
            this.rtbExpCurrentControlValues = new System.Windows.Forms.RichTextBox();
            this.btnExpLoadNewTestcase = new System.Windows.Forms.Button();
            this.tbExpTestCaseNumberOf = new System.Windows.Forms.TextBox();
            this.lblExpTestCaseNumberOf = new System.Windows.Forms.Label();
            this.btnExpNextTestCase = new System.Windows.Forms.Button();
            this.btnExpLastTestCase = new System.Windows.Forms.Button();
            this.btnExpPreviousTestCase = new System.Windows.Forms.Button();
            this.lblExpActualResults = new System.Windows.Forms.Label();
            this.rtbExpActualResults = new System.Windows.Forms.RichTextBox();
            this.btnExpFirstTestCase = new System.Windows.Forms.Button();
            this.btnExpCloseTestSession = new System.Windows.Forms.Button();
            this.btnExpClearTestCase = new System.Windows.Forms.Button();
            this.btnExpDeleteTestCase = new System.Windows.Forms.Button();
            this.tbExpTestcaseResult = new System.Windows.Forms.TextBox();
            this.lblExpTestcaseResult = new System.Windows.Forms.Label();
            this.btnExpSaveTestCase = new System.Windows.Forms.Button();
            this.rtbExpExpectedResults = new System.Windows.Forms.RichTextBox();
            this.lblExpExpectedResults = new System.Windows.Forms.Label();
            this.cmbExpSprink2 = new System.Windows.Forms.ComboBox();
            this.btnExpRunTestCase = new System.Windows.Forms.Button();
            this.cmbExpSprink1 = new System.Windows.Forms.ComboBox();
            this.lblExpSprink2 = new System.Windows.Forms.Label();
            this.lblExpSprink1 = new System.Windows.Forms.Label();
            this.cmbExpVent4 = new System.Windows.Forms.ComboBox();
            this.cmbExpVent3 = new System.Windows.Forms.ComboBox();
            this.cmbExpVent2 = new System.Windows.Forms.ComboBox();
            this.cmbExpVent1 = new System.Windows.Forms.ComboBox();
            this.lblExpVent4 = new System.Windows.Forms.Label();
            this.lblExpVent3 = new System.Windows.Forms.Label();
            this.lblExpVent2 = new System.Windows.Forms.Label();
            this.lblExpVent1 = new System.Windows.Forms.Label();
            this.cmbExpHeater4 = new System.Windows.Forms.ComboBox();
            this.cmbExpHeater3 = new System.Windows.Forms.ComboBox();
            this.cmbExpHeater2 = new System.Windows.Forms.ComboBox();
            this.cmbExpHeater1 = new System.Windows.Forms.ComboBox();
            this.lblExpHeater4 = new System.Windows.Forms.Label();
            this.lblExpHeater3 = new System.Windows.Forms.Label();
            this.lblExpHeater2 = new System.Windows.Forms.Label();
            this.lblExpHeater1 = new System.Windows.Forms.Label();
            this.lblExpSetControlInputs = new System.Windows.Forms.Label();
            this.lblExpDateOfTest = new System.Windows.Forms.Label();
            this.dtpExpDateOfTest = new System.Windows.Forms.DateTimePicker();
            this.numExpWindSpeedValue = new System.Windows.Forms.NumericUpDown();
            this.numExpHumidValue = new System.Windows.Forms.NumericUpDown();
            this.numExpTempValue = new System.Windows.Forms.NumericUpDown();
            this.lblExpWindSpeedValue = new System.Windows.Forms.Label();
            this.lblExpHumidValue = new System.Windows.Forms.Label();
            this.lblExpTempValue = new System.Windows.Forms.Label();
            this.lblExpSetClimateTestInputs = new System.Windows.Forms.Label();
            this.lblExpExploratoryTestcaseImplementationTool = new System.Windows.Forms.Label();
            this.panelMainTestPage = new System.Windows.Forms.Panel();
            this.panelTestMethodSelection = new System.Windows.Forms.Panel();
            this.cmbTmPathToSQLServer = new System.Windows.Forms.ComboBox();
            this.cmbTmTesterId = new System.Windows.Forms.ComboBox();
            this.cmbTmEnterTesterName = new System.Windows.Forms.ComboBox();
            this.rtbTMLoginStatusInfo = new System.Windows.Forms.RichTextBox();
            this.btnTMDeCoupleTestbed = new System.Windows.Forms.Button();
            this.btnTmHelp = new System.Windows.Forms.Button();
            this.btnTmLoadDefaultServerSettings = new System.Windows.Forms.Button();
            this.btnTmLogIntoTesterDataBase = new System.Windows.Forms.Button();
            this.lblTmPathToSQLServer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTmSelectTheTestMethod = new System.Windows.Forms.Label();
            this.rbTmExecuteFullTestPlan = new System.Windows.Forms.RadioButton();
            this.rbTmExecuteSingleTestcase = new System.Windows.Forms.RadioButton();
            this.btnExitSimulator = new System.Windows.Forms.Button();
            this.tbTmDatabaseName = new System.Windows.Forms.TextBox();
            this.lblTmSelectedDB = new System.Windows.Forms.Label();
            this.cmbTmDesignation = new System.Windows.Forms.ComboBox();
            this.lblTmDesignation = new System.Windows.Forms.Label();
            this.lblTmTesterID = new System.Windows.Forms.Label();
            this.lblTmEnterTesterName = new System.Windows.Forms.Label();
            this.pbCompanyLogo = new System.Windows.Forms.PictureBox();
            this.panelTpTestplanImplementationTool = new System.Windows.Forms.Panel();
            this.btnTpLoadFirstTestCase = new System.Windows.Forms.Button();
            this.btnTPLogDefectIncident = new System.Windows.Forms.Button();
            this.lblTPCurrentControlValues = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbTPCurrentControlValues = new System.Windows.Forms.RichTextBox();
            this.cmbTPThrottleAutorunTestPace = new System.Windows.Forms.ComboBox();
            this.lblTpThrottleAutorunTestPace = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTpClimateAndControlTestInputs = new System.Windows.Forms.Label();
            this.panelTpSelectTestCaseRange = new System.Windows.Forms.Panel();
            this.tbTpToTestCase = new System.Windows.Forms.TextBox();
            this.lblTpToTestCase = new System.Windows.Forms.Label();
            this.tbTpFromTestCase = new System.Windows.Forms.TextBox();
            this.lblTpFromTestCase = new System.Windows.Forms.Label();
            this.lblTpSTRSelectTestCaseRange = new System.Windows.Forms.Label();
            this.panelTpSelectTestMode = new System.Windows.Forms.Panel();
            this.rbTpSTMManualTestMode = new System.Windows.Forms.RadioButton();
            this.lblTpSTMSelectTestMode = new System.Windows.Forms.Label();
            this.rbTpSTMAutoTestMode = new System.Windows.Forms.RadioButton();
            this.tbTpGotoTestCase = new System.Windows.Forms.TextBox();
            this.lblTpGotoTestCase = new System.Windows.Forms.Label();
            this.btnTpPauseTestRun = new System.Windows.Forms.Button();
            this.tbTpCurrentTestcase = new System.Windows.Forms.TextBox();
            this.lblTpNumOfTestsInTestPlan = new System.Windows.Forms.Label();
            this.tbTpNumOfTestsInTestPlan = new System.Windows.Forms.TextBox();
            this.tbTpSprink2 = new System.Windows.Forms.TextBox();
            this.tbTpSprink1 = new System.Windows.Forms.TextBox();
            this.cmbTpSelectTestPlan = new System.Windows.Forms.ComboBox();
            this.tbTpVent4 = new System.Windows.Forms.TextBox();
            this.lblTpSelectTestPlan = new System.Windows.Forms.Label();
            this.tbTpVent3 = new System.Windows.Forms.TextBox();
            this.tbTpVent2 = new System.Windows.Forms.TextBox();
            this.tbTpVent1 = new System.Windows.Forms.TextBox();
            this.tbTpHeater4 = new System.Windows.Forms.TextBox();
            this.tbTpHeater3 = new System.Windows.Forms.TextBox();
            this.tbTpHeater2 = new System.Windows.Forms.TextBox();
            this.tbTpHeater1 = new System.Windows.Forms.TextBox();
            this.tbTpWindSpeedValue = new System.Windows.Forms.TextBox();
            this.tbTpHumidValue = new System.Windows.Forms.TextBox();
            this.tbTpTempValue = new System.Windows.Forms.TextBox();
            this.tbTpTestCaseNumberOf = new System.Windows.Forms.TextBox();
            this.lblTpTestPlanImplementationTool = new System.Windows.Forms.Label();
            this.lblTpTestCaseNumberOf = new System.Windows.Forms.Label();
            this.btnTpNextTestCase = new System.Windows.Forms.Button();
            this.btnTpLastTestCase = new System.Windows.Forms.Button();
            this.btnTpPreviousTestCase = new System.Windows.Forms.Button();
            this.btnTpFirstTestCase = new System.Windows.Forms.Button();
            this.btnTpCloseTestSession = new System.Windows.Forms.Button();
            this.tbTpTestcaseResult = new System.Windows.Forms.TextBox();
            this.lblTpTestcaseResult = new System.Windows.Forms.Label();
            this.btnTpEditTestPlan = new System.Windows.Forms.Button();
            this.lblTpActualResults = new System.Windows.Forms.Label();
            this.rtbTpActualResults = new System.Windows.Forms.RichTextBox();
            this.rtbTpExpectedResults = new System.Windows.Forms.RichTextBox();
            this.lblTpExpectedResults = new System.Windows.Forms.Label();
            this.btnTpStartTestRun = new System.Windows.Forms.Button();
            this.lblTpSprink2 = new System.Windows.Forms.Label();
            this.lblTpSprink1 = new System.Windows.Forms.Label();
            this.lblTpVent4 = new System.Windows.Forms.Label();
            this.lblTpVent3 = new System.Windows.Forms.Label();
            this.lblTpVent2 = new System.Windows.Forms.Label();
            this.lblTpVent1 = new System.Windows.Forms.Label();
            this.lblTpHeater4 = new System.Windows.Forms.Label();
            this.lblTpHeater3 = new System.Windows.Forms.Label();
            this.lblTpHeater2 = new System.Windows.Forms.Label();
            this.lblTpHeater1 = new System.Windows.Forms.Label();
            this.lblTpDateOfTest = new System.Windows.Forms.Label();
            this.dtpTpDateOfTest = new System.Windows.Forms.DateTimePicker();
            this.lblTpWindSpeedValue = new System.Windows.Forms.Label();
            this.lblTpHumidValue = new System.Windows.Forms.Label();
            this.lblTpTempValue = new System.Windows.Forms.Label();
            this.lblTpClimateTestInputs = new System.Windows.Forms.Label();
            this.panelBioControlSeperator = new System.Windows.Forms.Panel();
            this.panelBioDomeControlCover = new System.Windows.Forms.Panel();
            this.pbBioDomeControlCover = new System.Windows.Forms.PictureBox();
            this.panelBioDomeView.SuspendLayout();
            this.panelBioResourceAvailability.SuspendLayout();
            this.panelBioCurrentClimateValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBioCompanyLogo)).BeginInit();
            this.panelCurrentSystemControl.SuspendLayout();
            this.panelBioMoistureControlView.SuspendLayout();
            this.panelBioVentilationControlView.SuspendLayout();
            this.panelBioTempControlView.SuspendLayout();
            this.panelBioExternalClimateControlView1_1.SuspendLayout();
            this.panelBioDomeTestBed.SuspendLayout();
            this.panelBioDomeLogging.SuspendLayout();
            this.panelBioDomeLoggingCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBioLoggingCoverTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBioLoggingCoverBottom)).BeginInit();
            this.panelExpTestcaseImplementationTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpWindSpeedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpHumidValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpTempValue)).BeginInit();
            this.panelMainTestPage.SuspendLayout();
            this.panelTestMethodSelection.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyLogo)).BeginInit();
            this.panelTpTestplanImplementationTool.SuspendLayout();
            this.panelTpSelectTestCaseRange.SuspendLayout();
            this.panelTpSelectTestMode.SuspendLayout();
            this.panelBioDomeControlCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBioDomeControlCover)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBioDomeView
            // 
            this.panelBioDomeView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelBioDomeView.Controls.Add(this.panelBioResourceAvailability);
            this.panelBioDomeView.Controls.Add(this.panelBioCurrentClimateValues);
            this.panelBioDomeView.Controls.Add(this.pbBioCompanyLogo);
            this.panelBioDomeView.Controls.Add(this.panelCurrentSystemControl);
            this.panelBioDomeView.Controls.Add(this.panelBioMoistureControlView);
            this.panelBioDomeView.Controls.Add(this.panelBioVentilationControlView);
            this.panelBioDomeView.Controls.Add(this.panelBioTempControlView);
            this.panelBioDomeView.Controls.Add(this.panelBioExternalClimateControlView1_1);
            this.panelBioDomeView.Location = new System.Drawing.Point(0, 0);
            this.panelBioDomeView.Margin = new System.Windows.Forms.Padding(1);
            this.panelBioDomeView.Name = "panelBioDomeView";
            this.panelBioDomeView.Size = new System.Drawing.Size(1200, 347);
            this.panelBioDomeView.TabIndex = 0;
            // 
            // panelBioResourceAvailability
            // 
            this.panelBioResourceAvailability.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panelBioResourceAvailability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBioResourceAvailability.Controls.Add(this.tbBioDomeControlsInUse);
            this.panelBioResourceAvailability.Controls.Add(this.label2);
            this.panelBioResourceAvailability.Controls.Add(this.lblAvailableResource);
            this.panelBioResourceAvailability.Controls.Add(this.lblAvailableGreen);
            this.panelBioResourceAvailability.Controls.Add(this.lblPartiallyAvailOrange);
            this.panelBioResourceAvailability.Controls.Add(this.lblPartiallyAvailableResources);
            this.panelBioResourceAvailability.Controls.Add(this.lblUnavailableRed);
            this.panelBioResourceAvailability.Controls.Add(this.lblUnavailableResources);
            this.panelBioResourceAvailability.Controls.Add(this.lblSprink2InUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblSprink1InUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblSprinklersInUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblVent4InUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblVent3InUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblVent2InUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblVent1InUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblVentsInUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblHeater4InUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblHeater3InUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblHeater2InUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblHeater1InUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblHeatersInUse);
            this.panelBioResourceAvailability.Controls.Add(this.lblResourceAvailability);
            this.panelBioResourceAvailability.Location = new System.Drawing.Point(335, 284);
            this.panelBioResourceAvailability.Margin = new System.Windows.Forms.Padding(1);
            this.panelBioResourceAvailability.Name = "panelBioResourceAvailability";
            this.panelBioResourceAvailability.Size = new System.Drawing.Size(503, 62);
            this.panelBioResourceAvailability.TabIndex = 7;
            // 
            // tbBioDomeControlsInUse
            // 
            this.tbBioDomeControlsInUse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBioDomeControlsInUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBioDomeControlsInUse.ForeColor = System.Drawing.Color.Blue;
            this.tbBioDomeControlsInUse.Location = new System.Drawing.Point(465, 31);
            this.tbBioDomeControlsInUse.Margin = new System.Windows.Forms.Padding(1);
            this.tbBioDomeControlsInUse.Multiline = true;
            this.tbBioDomeControlsInUse.Name = "tbBioDomeControlsInUse";
            this.tbBioDomeControlsInUse.Size = new System.Drawing.Size(26, 18);
            this.tbBioDomeControlsInUse.TabIndex = 23;
            this.tbBioDomeControlsInUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "In Use:";
            // 
            // lblAvailableResource
            // 
            this.lblAvailableResource.AutoSize = true;
            this.lblAvailableResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableResource.Location = new System.Drawing.Point(152, 4);
            this.lblAvailableResource.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAvailableResource.Name = "lblAvailableResource";
            this.lblAvailableResource.Size = new System.Drawing.Size(53, 13);
            this.lblAvailableResource.TabIndex = 21;
            this.lblAvailableResource.Text = "Available:";
            // 
            // lblAvailableGreen
            // 
            this.lblAvailableGreen.BackColor = System.Drawing.Color.Lime;
            this.lblAvailableGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvailableGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableGreen.Location = new System.Drawing.Point(212, 5);
            this.lblAvailableGreen.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAvailableGreen.Name = "lblAvailableGreen";
            this.lblAvailableGreen.Size = new System.Drawing.Size(12, 12);
            this.lblAvailableGreen.TabIndex = 20;
            this.lblAvailableGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartiallyAvailOrange
            // 
            this.lblPartiallyAvailOrange.BackColor = System.Drawing.Color.Orange;
            this.lblPartiallyAvailOrange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPartiallyAvailOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartiallyAvailOrange.Location = new System.Drawing.Point(364, 5);
            this.lblPartiallyAvailOrange.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPartiallyAvailOrange.Name = "lblPartiallyAvailOrange";
            this.lblPartiallyAvailOrange.Size = new System.Drawing.Size(12, 12);
            this.lblPartiallyAvailOrange.TabIndex = 19;
            this.lblPartiallyAvailOrange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartiallyAvailableResources
            // 
            this.lblPartiallyAvailableResources.AutoSize = true;
            this.lblPartiallyAvailableResources.Location = new System.Drawing.Point(265, 4);
            this.lblPartiallyAvailableResources.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPartiallyAvailableResources.Name = "lblPartiallyAvailableResources";
            this.lblPartiallyAvailableResources.Size = new System.Drawing.Size(92, 13);
            this.lblPartiallyAvailableResources.TabIndex = 18;
            this.lblPartiallyAvailableResources.Text = "Partially Available:";
            // 
            // lblUnavailableRed
            // 
            this.lblUnavailableRed.BackColor = System.Drawing.Color.Red;
            this.lblUnavailableRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnavailableRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnavailableRed.Location = new System.Drawing.Point(479, 5);
            this.lblUnavailableRed.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUnavailableRed.Name = "lblUnavailableRed";
            this.lblUnavailableRed.Size = new System.Drawing.Size(12, 12);
            this.lblUnavailableRed.TabIndex = 17;
            this.lblUnavailableRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnavailableResources
            // 
            this.lblUnavailableResources.AutoSize = true;
            this.lblUnavailableResources.Location = new System.Drawing.Point(411, 4);
            this.lblUnavailableResources.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUnavailableResources.Name = "lblUnavailableResources";
            this.lblUnavailableResources.Size = new System.Drawing.Size(66, 13);
            this.lblUnavailableResources.TabIndex = 16;
            this.lblUnavailableResources.Text = "Unavailable:";
            // 
            // lblSprink2InUse
            // 
            this.lblSprink2InUse.BackColor = System.Drawing.SystemColors.Control;
            this.lblSprink2InUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSprink2InUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprink2InUse.Location = new System.Drawing.Point(391, 32);
            this.lblSprink2InUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSprink2InUse.Name = "lblSprink2InUse";
            this.lblSprink2InUse.Size = new System.Drawing.Size(18, 14);
            this.lblSprink2InUse.TabIndex = 13;
            this.lblSprink2InUse.Text = "2";
            this.lblSprink2InUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSprink1InUse
            // 
            this.lblSprink1InUse.BackColor = System.Drawing.SystemColors.Control;
            this.lblSprink1InUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSprink1InUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprink1InUse.Location = new System.Drawing.Point(370, 32);
            this.lblSprink1InUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSprink1InUse.Name = "lblSprink1InUse";
            this.lblSprink1InUse.Size = new System.Drawing.Size(18, 14);
            this.lblSprink1InUse.TabIndex = 12;
            this.lblSprink1InUse.Text = "1";
            this.lblSprink1InUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSprinklersInUse
            // 
            this.lblSprinklersInUse.AutoSize = true;
            this.lblSprinklersInUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprinklersInUse.Location = new System.Drawing.Point(313, 32);
            this.lblSprinklersInUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSprinklersInUse.Name = "lblSprinklersInUse";
            this.lblSprinklersInUse.Size = new System.Drawing.Size(56, 13);
            this.lblSprinklersInUse.TabIndex = 11;
            this.lblSprinklersInUse.Text = "Sprinklers:";
            // 
            // lblVent4InUse
            // 
            this.lblVent4InUse.BackColor = System.Drawing.SystemColors.Control;
            this.lblVent4InUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVent4InUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVent4InUse.Location = new System.Drawing.Point(266, 32);
            this.lblVent4InUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblVent4InUse.Name = "lblVent4InUse";
            this.lblVent4InUse.Size = new System.Drawing.Size(18, 14);
            this.lblVent4InUse.TabIndex = 10;
            this.lblVent4InUse.Text = "4";
            this.lblVent4InUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVent3InUse
            // 
            this.lblVent3InUse.BackColor = System.Drawing.SystemColors.Control;
            this.lblVent3InUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVent3InUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVent3InUse.Location = new System.Drawing.Point(246, 32);
            this.lblVent3InUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblVent3InUse.Name = "lblVent3InUse";
            this.lblVent3InUse.Size = new System.Drawing.Size(18, 14);
            this.lblVent3InUse.TabIndex = 9;
            this.lblVent3InUse.Text = "3";
            this.lblVent3InUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVent2InUse
            // 
            this.lblVent2InUse.BackColor = System.Drawing.SystemColors.Control;
            this.lblVent2InUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVent2InUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVent2InUse.Location = new System.Drawing.Point(226, 32);
            this.lblVent2InUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblVent2InUse.Name = "lblVent2InUse";
            this.lblVent2InUse.Size = new System.Drawing.Size(18, 14);
            this.lblVent2InUse.TabIndex = 8;
            this.lblVent2InUse.Text = "2";
            this.lblVent2InUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVent1InUse
            // 
            this.lblVent1InUse.BackColor = System.Drawing.SystemColors.Control;
            this.lblVent1InUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVent1InUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVent1InUse.Location = new System.Drawing.Point(206, 32);
            this.lblVent1InUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblVent1InUse.Name = "lblVent1InUse";
            this.lblVent1InUse.Size = new System.Drawing.Size(18, 14);
            this.lblVent1InUse.TabIndex = 7;
            this.lblVent1InUse.Text = "1";
            this.lblVent1InUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVentsInUse
            // 
            this.lblVentsInUse.AutoSize = true;
            this.lblVentsInUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentsInUse.Location = new System.Drawing.Point(171, 32);
            this.lblVentsInUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblVentsInUse.Name = "lblVentsInUse";
            this.lblVentsInUse.Size = new System.Drawing.Size(37, 13);
            this.lblVentsInUse.TabIndex = 6;
            this.lblVentsInUse.Text = "Vents:";
            // 
            // lblHeater4InUse
            // 
            this.lblHeater4InUse.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeater4InUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeater4InUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeater4InUse.Location = new System.Drawing.Point(121, 32);
            this.lblHeater4InUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeater4InUse.Name = "lblHeater4InUse";
            this.lblHeater4InUse.Size = new System.Drawing.Size(18, 14);
            this.lblHeater4InUse.TabIndex = 5;
            this.lblHeater4InUse.Text = "4";
            this.lblHeater4InUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeater3InUse
            // 
            this.lblHeater3InUse.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeater3InUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeater3InUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeater3InUse.Location = new System.Drawing.Point(100, 32);
            this.lblHeater3InUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeater3InUse.Name = "lblHeater3InUse";
            this.lblHeater3InUse.Size = new System.Drawing.Size(18, 14);
            this.lblHeater3InUse.TabIndex = 4;
            this.lblHeater3InUse.Text = "3";
            this.lblHeater3InUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeater2InUse
            // 
            this.lblHeater2InUse.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeater2InUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeater2InUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeater2InUse.Location = new System.Drawing.Point(80, 32);
            this.lblHeater2InUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeater2InUse.Name = "lblHeater2InUse";
            this.lblHeater2InUse.Size = new System.Drawing.Size(18, 14);
            this.lblHeater2InUse.TabIndex = 3;
            this.lblHeater2InUse.Text = "2";
            this.lblHeater2InUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeater1InUse
            // 
            this.lblHeater1InUse.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeater1InUse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeater1InUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeater1InUse.Location = new System.Drawing.Point(60, 32);
            this.lblHeater1InUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeater1InUse.Name = "lblHeater1InUse";
            this.lblHeater1InUse.Size = new System.Drawing.Size(18, 14);
            this.lblHeater1InUse.TabIndex = 2;
            this.lblHeater1InUse.Text = "1";
            this.lblHeater1InUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeatersInUse
            // 
            this.lblHeatersInUse.AutoSize = true;
            this.lblHeatersInUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatersInUse.Location = new System.Drawing.Point(12, 32);
            this.lblHeatersInUse.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeatersInUse.Name = "lblHeatersInUse";
            this.lblHeatersInUse.Size = new System.Drawing.Size(47, 13);
            this.lblHeatersInUse.TabIndex = 1;
            this.lblHeatersInUse.Text = "Heaters:";
            // 
            // lblResourceAvailability
            // 
            this.lblResourceAvailability.AutoSize = true;
            this.lblResourceAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResourceAvailability.Location = new System.Drawing.Point(12, 3);
            this.lblResourceAvailability.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblResourceAvailability.Name = "lblResourceAvailability";
            this.lblResourceAvailability.Size = new System.Drawing.Size(126, 13);
            this.lblResourceAvailability.TabIndex = 0;
            this.lblResourceAvailability.Text = "Resource Availability";
            // 
            // panelBioCurrentClimateValues
            // 
            this.panelBioCurrentClimateValues.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panelBioCurrentClimateValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBioCurrentClimateValues.Controls.Add(this.lblBioCurrentClimateValues);
            this.panelBioCurrentClimateValues.Controls.Add(this.tbCurWindSpeedReading);
            this.panelBioCurrentClimateValues.Controls.Add(this.lblCurWindSpeedReading);
            this.panelBioCurrentClimateValues.Controls.Add(this.tbCurHumidReading);
            this.panelBioCurrentClimateValues.Controls.Add(this.lblCurHumidReading);
            this.panelBioCurrentClimateValues.Controls.Add(this.tbCurTempReading);
            this.panelBioCurrentClimateValues.Controls.Add(this.lblCurTempReading);
            this.panelBioCurrentClimateValues.Location = new System.Drawing.Point(2, 284);
            this.panelBioCurrentClimateValues.Margin = new System.Windows.Forms.Padding(1);
            this.panelBioCurrentClimateValues.Name = "panelBioCurrentClimateValues";
            this.panelBioCurrentClimateValues.Size = new System.Drawing.Size(330, 62);
            this.panelBioCurrentClimateValues.TabIndex = 6;
            // 
            // lblBioCurrentClimateValues
            // 
            this.lblBioCurrentClimateValues.AutoSize = true;
            this.lblBioCurrentClimateValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioCurrentClimateValues.Location = new System.Drawing.Point(12, 3);
            this.lblBioCurrentClimateValues.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBioCurrentClimateValues.Name = "lblBioCurrentClimateValues";
            this.lblBioCurrentClimateValues.Size = new System.Drawing.Size(193, 13);
            this.lblBioCurrentClimateValues.TabIndex = 8;
            this.lblBioCurrentClimateValues.Text = "Current Bio-Dome Climate Values";
            // 
            // tbCurWindSpeedReading
            // 
            this.tbCurWindSpeedReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurWindSpeedReading.Location = new System.Drawing.Point(284, 32);
            this.tbCurWindSpeedReading.Margin = new System.Windows.Forms.Padding(1);
            this.tbCurWindSpeedReading.Multiline = true;
            this.tbCurWindSpeedReading.Name = "tbCurWindSpeedReading";
            this.tbCurWindSpeedReading.ReadOnly = true;
            this.tbCurWindSpeedReading.Size = new System.Drawing.Size(29, 20);
            this.tbCurWindSpeedReading.TabIndex = 7;
            this.tbCurWindSpeedReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurWindSpeedReading
            // 
            this.lblCurWindSpeedReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurWindSpeedReading.Location = new System.Drawing.Point(213, 32);
            this.lblCurWindSpeedReading.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCurWindSpeedReading.Name = "lblCurWindSpeedReading";
            this.lblCurWindSpeedReading.Size = new System.Drawing.Size(77, 15);
            this.lblCurWindSpeedReading.TabIndex = 6;
            this.lblCurWindSpeedReading.Text = "Wind Speed:";
            this.lblCurWindSpeedReading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCurHumidReading
            // 
            this.tbCurHumidReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurHumidReading.Location = new System.Drawing.Point(172, 32);
            this.tbCurHumidReading.Margin = new System.Windows.Forms.Padding(1);
            this.tbCurHumidReading.Multiline = true;
            this.tbCurHumidReading.Name = "tbCurHumidReading";
            this.tbCurHumidReading.ReadOnly = true;
            this.tbCurHumidReading.Size = new System.Drawing.Size(29, 20);
            this.tbCurHumidReading.TabIndex = 5;
            this.tbCurHumidReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurHumidReading
            // 
            this.lblCurHumidReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurHumidReading.Location = new System.Drawing.Point(120, 32);
            this.lblCurHumidReading.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCurHumidReading.Name = "lblCurHumidReading";
            this.lblCurHumidReading.Size = new System.Drawing.Size(52, 16);
            this.lblCurHumidReading.TabIndex = 4;
            this.lblCurHumidReading.Text = "Humidity:";
            this.lblCurHumidReading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCurTempReading
            // 
            this.tbCurTempReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurTempReading.Location = new System.Drawing.Point(84, 32);
            this.tbCurTempReading.Margin = new System.Windows.Forms.Padding(1);
            this.tbCurTempReading.Multiline = true;
            this.tbCurTempReading.Name = "tbCurTempReading";
            this.tbCurTempReading.ReadOnly = true;
            this.tbCurTempReading.Size = new System.Drawing.Size(29, 20);
            this.tbCurTempReading.TabIndex = 3;
            this.tbCurTempReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurTempReading
            // 
            this.lblCurTempReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurTempReading.Location = new System.Drawing.Point(12, 32);
            this.lblCurTempReading.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCurTempReading.Name = "lblCurTempReading";
            this.lblCurTempReading.Size = new System.Drawing.Size(72, 16);
            this.lblCurTempReading.TabIndex = 2;
            this.lblCurTempReading.Text = "Temperature:";
            this.lblCurTempReading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbBioCompanyLogo
            // 
            this.pbBioCompanyLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBioCompanyLogo.Image = global::BioDomeSimulator.Properties.Resources.biodome;
            this.pbBioCompanyLogo.Location = new System.Drawing.Point(841, 1);
            this.pbBioCompanyLogo.Margin = new System.Windows.Forms.Padding(1);
            this.pbBioCompanyLogo.Name = "pbBioCompanyLogo";
            this.pbBioCompanyLogo.Size = new System.Drawing.Size(358, 154);
            this.pbBioCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBioCompanyLogo.TabIndex = 5;
            this.pbBioCompanyLogo.TabStop = false;
            // 
            // panelCurrentSystemControl
            // 
            this.panelCurrentSystemControl.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panelCurrentSystemControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrentSystemControl.Controls.Add(this.BioDomeTestInterval);
            this.panelCurrentSystemControl.Controls.Add(this.lblBioTimeLapsedSinceStartOfTestSession);
            this.panelCurrentSystemControl.Controls.Add(this.btnBioViewSystemState);
            this.panelCurrentSystemControl.Controls.Add(this.btnBioChangeSystemState);
            this.panelCurrentSystemControl.Controls.Add(this.lblBioCurrentStatusValue);
            this.panelCurrentSystemControl.Controls.Add(this.lblBioCurrentStatus);
            this.panelCurrentSystemControl.Location = new System.Drawing.Point(841, 251);
            this.panelCurrentSystemControl.Margin = new System.Windows.Forms.Padding(1);
            this.panelCurrentSystemControl.Name = "panelCurrentSystemControl";
            this.panelCurrentSystemControl.Size = new System.Drawing.Size(357, 94);
            this.panelCurrentSystemControl.TabIndex = 4;
            // 
            // BioDomeTestInterval
            // 
            this.BioDomeTestInterval.BackColor = System.Drawing.Color.White;
            this.BioDomeTestInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BioDomeTestInterval.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BioDomeTestInterval.Location = new System.Drawing.Point(188, 66);
            this.BioDomeTestInterval.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.BioDomeTestInterval.Name = "BioDomeTestInterval";
            this.BioDomeTestInterval.Size = new System.Drawing.Size(157, 21);
            this.BioDomeTestInterval.TabIndex = 35;
            this.BioDomeTestInterval.Text = "00 hrs  00 mins  00 secs";
            this.BioDomeTestInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioTimeLapsedSinceStartOfTestSession
            // 
            this.lblBioTimeLapsedSinceStartOfTestSession.AutoSize = true;
            this.lblBioTimeLapsedSinceStartOfTestSession.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioTimeLapsedSinceStartOfTestSession.Location = new System.Drawing.Point(12, 70);
            this.lblBioTimeLapsedSinceStartOfTestSession.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBioTimeLapsedSinceStartOfTestSession.Name = "lblBioTimeLapsedSinceStartOfTestSession";
            this.lblBioTimeLapsedSinceStartOfTestSession.Size = new System.Drawing.Size(162, 14);
            this.lblBioTimeLapsedSinceStartOfTestSession.TabIndex = 34;
            this.lblBioTimeLapsedSinceStartOfTestSession.Text = "Time Since Session Started:";
            // 
            // btnBioViewSystemState
            // 
            this.btnBioViewSystemState.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBioViewSystemState.FlatAppearance.BorderSize = 2;
            this.btnBioViewSystemState.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBioViewSystemState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBioViewSystemState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBioViewSystemState.Location = new System.Drawing.Point(188, 35);
            this.btnBioViewSystemState.Margin = new System.Windows.Forms.Padding(0);
            this.btnBioViewSystemState.Name = "btnBioViewSystemState";
            this.btnBioViewSystemState.Size = new System.Drawing.Size(157, 23);
            this.btnBioViewSystemState.TabIndex = 33;
            this.btnBioViewSystemState.Text = "Display System State";
            this.btnBioViewSystemState.UseVisualStyleBackColor = false;
            this.btnBioViewSystemState.Click += new System.EventHandler(this.btnBioViewSystemState_Click);
            // 
            // btnBioChangeSystemState
            // 
            this.btnBioChangeSystemState.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBioChangeSystemState.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBioChangeSystemState.FlatAppearance.BorderSize = 2;
            this.btnBioChangeSystemState.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBioChangeSystemState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBioChangeSystemState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBioChangeSystemState.Location = new System.Drawing.Point(15, 35);
            this.btnBioChangeSystemState.Margin = new System.Windows.Forms.Padding(0);
            this.btnBioChangeSystemState.Name = "btnBioChangeSystemState";
            this.btnBioChangeSystemState.Size = new System.Drawing.Size(157, 23);
            this.btnBioChangeSystemState.TabIndex = 32;
            this.btnBioChangeSystemState.Text = "Turn System ON";
            this.btnBioChangeSystemState.UseVisualStyleBackColor = false;
            this.btnBioChangeSystemState.Click += new System.EventHandler(this.btnBioChangeSystemState_Click);
            // 
            // lblBioCurrentStatusValue
            // 
            this.lblBioCurrentStatusValue.BackColor = System.Drawing.Color.Red;
            this.lblBioCurrentStatusValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioCurrentStatusValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBioCurrentStatusValue.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioCurrentStatusValue.ForeColor = System.Drawing.Color.Black;
            this.lblBioCurrentStatusValue.Location = new System.Drawing.Point(280, 8);
            this.lblBioCurrentStatusValue.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioCurrentStatusValue.Name = "lblBioCurrentStatusValue";
            this.lblBioCurrentStatusValue.Size = new System.Drawing.Size(65, 17);
            this.lblBioCurrentStatusValue.TabIndex = 31;
            this.lblBioCurrentStatusValue.Text = "Off-Line";
            this.lblBioCurrentStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioCurrentStatus
            // 
            this.lblBioCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioCurrentStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblBioCurrentStatus.Location = new System.Drawing.Point(12, 8);
            this.lblBioCurrentStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioCurrentStatus.Name = "lblBioCurrentStatus";
            this.lblBioCurrentStatus.Size = new System.Drawing.Size(160, 17);
            this.lblBioCurrentStatus.TabIndex = 29;
            this.lblBioCurrentStatus.Text = "Current System Status:";
            this.lblBioCurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBioMoistureControlView
            // 
            this.panelBioMoistureControlView.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panelBioMoistureControlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBioMoistureControlView.Controls.Add(this.lblBioSprink2On);
            this.panelBioMoistureControlView.Controls.Add(this.lblBioSprink1On);
            this.panelBioMoistureControlView.Controls.Add(this.lblBioSprink2Off);
            this.panelBioMoistureControlView.Controls.Add(this.lblBioSprink1Off);
            this.panelBioMoistureControlView.Controls.Add(this.lblSprinkler2);
            this.panelBioMoistureControlView.Controls.Add(this.lblSprinkler1);
            this.panelBioMoistureControlView.Controls.Add(this.lblMoistureControlView);
            this.panelBioMoistureControlView.Location = new System.Drawing.Point(841, 158);
            this.panelBioMoistureControlView.Margin = new System.Windows.Forms.Padding(1);
            this.panelBioMoistureControlView.Name = "panelBioMoistureControlView";
            this.panelBioMoistureControlView.Size = new System.Drawing.Size(357, 90);
            this.panelBioMoistureControlView.TabIndex = 3;
            // 
            // lblBioSprink2On
            // 
            this.lblBioSprink2On.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioSprink2On.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioSprink2On.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioSprink2On.Location = new System.Drawing.Point(248, 57);
            this.lblBioSprink2On.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioSprink2On.Name = "lblBioSprink2On";
            this.lblBioSprink2On.Size = new System.Drawing.Size(84, 17);
            this.lblBioSprink2On.TabIndex = 33;
            this.lblBioSprink2On.Text = "On";
            this.lblBioSprink2On.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioSprink1On
            // 
            this.lblBioSprink1On.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioSprink1On.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioSprink1On.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioSprink1On.Location = new System.Drawing.Point(248, 24);
            this.lblBioSprink1On.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioSprink1On.Name = "lblBioSprink1On";
            this.lblBioSprink1On.Size = new System.Drawing.Size(84, 17);
            this.lblBioSprink1On.TabIndex = 32;
            this.lblBioSprink1On.Text = "On";
            this.lblBioSprink1On.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioSprink2Off
            // 
            this.lblBioSprink2Off.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioSprink2Off.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioSprink2Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioSprink2Off.Location = new System.Drawing.Point(161, 57);
            this.lblBioSprink2Off.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioSprink2Off.Name = "lblBioSprink2Off";
            this.lblBioSprink2Off.Size = new System.Drawing.Size(84, 17);
            this.lblBioSprink2Off.TabIndex = 31;
            this.lblBioSprink2Off.Text = "Off";
            this.lblBioSprink2Off.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioSprink1Off
            // 
            this.lblBioSprink1Off.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioSprink1Off.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioSprink1Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioSprink1Off.Location = new System.Drawing.Point(161, 24);
            this.lblBioSprink1Off.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioSprink1Off.Name = "lblBioSprink1Off";
            this.lblBioSprink1Off.Size = new System.Drawing.Size(84, 17);
            this.lblBioSprink1Off.TabIndex = 30;
            this.lblBioSprink1Off.Text = "Off";
            this.lblBioSprink1Off.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSprinkler2
            // 
            this.lblSprinkler2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprinkler2.Location = new System.Drawing.Point(12, 60);
            this.lblSprinkler2.Margin = new System.Windows.Forms.Padding(0);
            this.lblSprinkler2.Name = "lblSprinkler2";
            this.lblSprinkler2.Size = new System.Drawing.Size(140, 15);
            this.lblSprinkler2.TabIndex = 29;
            this.lblSprinkler2.Text = "Sprinkler Unit #2 (Zone 2):";
            this.lblSprinkler2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSprinkler1
            // 
            this.lblSprinkler1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprinkler1.Location = new System.Drawing.Point(12, 28);
            this.lblSprinkler1.Margin = new System.Windows.Forms.Padding(0);
            this.lblSprinkler1.Name = "lblSprinkler1";
            this.lblSprinkler1.Size = new System.Drawing.Size(136, 15);
            this.lblSprinkler1.TabIndex = 28;
            this.lblSprinkler1.Text = "Sprinkler Unit #1 (Zone 1):";
            this.lblSprinkler1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMoistureControlView
            // 
            this.lblMoistureControlView.AutoSize = true;
            this.lblMoistureControlView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoistureControlView.Location = new System.Drawing.Point(12, 3);
            this.lblMoistureControlView.Margin = new System.Windows.Forms.Padding(0);
            this.lblMoistureControlView.Name = "lblMoistureControlView";
            this.lblMoistureControlView.Size = new System.Drawing.Size(130, 13);
            this.lblMoistureControlView.TabIndex = 27;
            this.lblMoistureControlView.Text = "Moisture Control View";
            // 
            // panelBioVentilationControlView
            // 
            this.panelBioVentilationControlView.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panelBioVentilationControlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBioVentilationControlView.Controls.Add(this.lblBioVent4Open);
            this.panelBioVentilationControlView.Controls.Add(this.lblBioVent3Open);
            this.panelBioVentilationControlView.Controls.Add(this.lblBioVent2Open);
            this.panelBioVentilationControlView.Controls.Add(this.lblBioVent4HalfOpen);
            this.panelBioVentilationControlView.Controls.Add(this.lblBioVent3HalfOpen);
            this.panelBioVentilationControlView.Controls.Add(this.lblBioVent2HalfOpen);
            this.panelBioVentilationControlView.Controls.Add(this.lblBioVent4Closed);
            this.panelBioVentilationControlView.Controls.Add(this.lblBioVent3Closed);
            this.panelBioVentilationControlView.Controls.Add(this.lblBioVent2Closed);
            this.panelBioVentilationControlView.Controls.Add(this.lblBioVent1Open);
            this.panelBioVentilationControlView.Controls.Add(this.lblBioVent1HalfOpen);
            this.panelBioVentilationControlView.Controls.Add(this.lblBioVent1Closed);
            this.panelBioVentilationControlView.Controls.Add(this.lblVentilationUnit4);
            this.panelBioVentilationControlView.Controls.Add(this.lblVentilationUnit3);
            this.panelBioVentilationControlView.Controls.Add(this.lblVentilationUnit2);
            this.panelBioVentilationControlView.Controls.Add(this.lblVentilationUnit1);
            this.panelBioVentilationControlView.Controls.Add(this.lblVentilationControlView);
            this.panelBioVentilationControlView.Location = new System.Drawing.Point(377, 126);
            this.panelBioVentilationControlView.Margin = new System.Windows.Forms.Padding(1);
            this.panelBioVentilationControlView.Name = "panelBioVentilationControlView";
            this.panelBioVentilationControlView.Size = new System.Drawing.Size(461, 155);
            this.panelBioVentilationControlView.TabIndex = 2;
            // 
            // lblBioVent4Open
            // 
            this.lblBioVent4Open.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioVent4Open.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioVent4Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioVent4Open.Location = new System.Drawing.Point(350, 121);
            this.lblBioVent4Open.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioVent4Open.Name = "lblBioVent4Open";
            this.lblBioVent4Open.Size = new System.Drawing.Size(84, 17);
            this.lblBioVent4Open.TabIndex = 42;
            this.lblBioVent4Open.Text = "Open";
            this.lblBioVent4Open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioVent3Open
            // 
            this.lblBioVent3Open.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioVent3Open.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioVent3Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioVent3Open.Location = new System.Drawing.Point(350, 89);
            this.lblBioVent3Open.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioVent3Open.Name = "lblBioVent3Open";
            this.lblBioVent3Open.Size = new System.Drawing.Size(84, 17);
            this.lblBioVent3Open.TabIndex = 41;
            this.lblBioVent3Open.Text = "Open";
            this.lblBioVent3Open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioVent2Open
            // 
            this.lblBioVent2Open.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioVent2Open.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioVent2Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioVent2Open.Location = new System.Drawing.Point(350, 57);
            this.lblBioVent2Open.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioVent2Open.Name = "lblBioVent2Open";
            this.lblBioVent2Open.Size = new System.Drawing.Size(84, 17);
            this.lblBioVent2Open.TabIndex = 40;
            this.lblBioVent2Open.Text = "Open";
            this.lblBioVent2Open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioVent4HalfOpen
            // 
            this.lblBioVent4HalfOpen.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioVent4HalfOpen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioVent4HalfOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioVent4HalfOpen.Location = new System.Drawing.Point(264, 121);
            this.lblBioVent4HalfOpen.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioVent4HalfOpen.Name = "lblBioVent4HalfOpen";
            this.lblBioVent4HalfOpen.Size = new System.Drawing.Size(84, 17);
            this.lblBioVent4HalfOpen.TabIndex = 39;
            this.lblBioVent4HalfOpen.Text = "Half-Open";
            this.lblBioVent4HalfOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioVent3HalfOpen
            // 
            this.lblBioVent3HalfOpen.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioVent3HalfOpen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioVent3HalfOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioVent3HalfOpen.Location = new System.Drawing.Point(264, 89);
            this.lblBioVent3HalfOpen.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioVent3HalfOpen.Name = "lblBioVent3HalfOpen";
            this.lblBioVent3HalfOpen.Size = new System.Drawing.Size(84, 17);
            this.lblBioVent3HalfOpen.TabIndex = 38;
            this.lblBioVent3HalfOpen.Text = "Half-Open";
            this.lblBioVent3HalfOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioVent2HalfOpen
            // 
            this.lblBioVent2HalfOpen.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioVent2HalfOpen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioVent2HalfOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioVent2HalfOpen.Location = new System.Drawing.Point(264, 57);
            this.lblBioVent2HalfOpen.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioVent2HalfOpen.Name = "lblBioVent2HalfOpen";
            this.lblBioVent2HalfOpen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBioVent2HalfOpen.Size = new System.Drawing.Size(84, 17);
            this.lblBioVent2HalfOpen.TabIndex = 37;
            this.lblBioVent2HalfOpen.Text = "Half-Open";
            this.lblBioVent2HalfOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioVent4Closed
            // 
            this.lblBioVent4Closed.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioVent4Closed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioVent4Closed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioVent4Closed.Location = new System.Drawing.Point(179, 121);
            this.lblBioVent4Closed.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioVent4Closed.Name = "lblBioVent4Closed";
            this.lblBioVent4Closed.Size = new System.Drawing.Size(84, 17);
            this.lblBioVent4Closed.TabIndex = 36;
            this.lblBioVent4Closed.Text = "Closed";
            this.lblBioVent4Closed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioVent3Closed
            // 
            this.lblBioVent3Closed.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioVent3Closed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioVent3Closed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioVent3Closed.Location = new System.Drawing.Point(179, 89);
            this.lblBioVent3Closed.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioVent3Closed.Name = "lblBioVent3Closed";
            this.lblBioVent3Closed.Size = new System.Drawing.Size(84, 17);
            this.lblBioVent3Closed.TabIndex = 35;
            this.lblBioVent3Closed.Text = "Closed";
            this.lblBioVent3Closed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioVent2Closed
            // 
            this.lblBioVent2Closed.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioVent2Closed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioVent2Closed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioVent2Closed.Location = new System.Drawing.Point(179, 57);
            this.lblBioVent2Closed.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioVent2Closed.Name = "lblBioVent2Closed";
            this.lblBioVent2Closed.Size = new System.Drawing.Size(84, 17);
            this.lblBioVent2Closed.TabIndex = 34;
            this.lblBioVent2Closed.Text = "Closed";
            this.lblBioVent2Closed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioVent1Open
            // 
            this.lblBioVent1Open.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioVent1Open.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioVent1Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioVent1Open.Location = new System.Drawing.Point(350, 24);
            this.lblBioVent1Open.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioVent1Open.Name = "lblBioVent1Open";
            this.lblBioVent1Open.Size = new System.Drawing.Size(84, 17);
            this.lblBioVent1Open.TabIndex = 33;
            this.lblBioVent1Open.Text = "Open";
            this.lblBioVent1Open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioVent1HalfOpen
            // 
            this.lblBioVent1HalfOpen.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioVent1HalfOpen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioVent1HalfOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioVent1HalfOpen.Location = new System.Drawing.Point(264, 24);
            this.lblBioVent1HalfOpen.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioVent1HalfOpen.Name = "lblBioVent1HalfOpen";
            this.lblBioVent1HalfOpen.Size = new System.Drawing.Size(84, 17);
            this.lblBioVent1HalfOpen.TabIndex = 32;
            this.lblBioVent1HalfOpen.Text = "Half-Open";
            this.lblBioVent1HalfOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioVent1Closed
            // 
            this.lblBioVent1Closed.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioVent1Closed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioVent1Closed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioVent1Closed.Location = new System.Drawing.Point(179, 24);
            this.lblBioVent1Closed.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioVent1Closed.Name = "lblBioVent1Closed";
            this.lblBioVent1Closed.Size = new System.Drawing.Size(84, 17);
            this.lblBioVent1Closed.TabIndex = 31;
            this.lblBioVent1Closed.Text = "Closed";
            this.lblBioVent1Closed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVentilationUnit4
            // 
            this.lblVentilationUnit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentilationUnit4.Location = new System.Drawing.Point(12, 124);
            this.lblVentilationUnit4.Margin = new System.Windows.Forms.Padding(0);
            this.lblVentilationUnit4.Name = "lblVentilationUnit4";
            this.lblVentilationUnit4.Size = new System.Drawing.Size(144, 12);
            this.lblVentilationUnit4.TabIndex = 30;
            this.lblVentilationUnit4.Text = "Ventilation Unit #4 (Zone 2):";
            this.lblVentilationUnit4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVentilationUnit3
            // 
            this.lblVentilationUnit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentilationUnit3.Location = new System.Drawing.Point(12, 92);
            this.lblVentilationUnit3.Margin = new System.Windows.Forms.Padding(0);
            this.lblVentilationUnit3.Name = "lblVentilationUnit3";
            this.lblVentilationUnit3.Size = new System.Drawing.Size(140, 12);
            this.lblVentilationUnit3.TabIndex = 29;
            this.lblVentilationUnit3.Text = "Ventilation Unit #3 (Zone 2):";
            this.lblVentilationUnit3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVentilationUnit2
            // 
            this.lblVentilationUnit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentilationUnit2.Location = new System.Drawing.Point(12, 60);
            this.lblVentilationUnit2.Margin = new System.Windows.Forms.Padding(0);
            this.lblVentilationUnit2.Name = "lblVentilationUnit2";
            this.lblVentilationUnit2.Size = new System.Drawing.Size(144, 12);
            this.lblVentilationUnit2.TabIndex = 28;
            this.lblVentilationUnit2.Text = "Ventilation Unit #2 (Zone 1):";
            this.lblVentilationUnit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVentilationUnit1
            // 
            this.lblVentilationUnit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentilationUnit1.Location = new System.Drawing.Point(12, 28);
            this.lblVentilationUnit1.Margin = new System.Windows.Forms.Padding(0);
            this.lblVentilationUnit1.Name = "lblVentilationUnit1";
            this.lblVentilationUnit1.Size = new System.Drawing.Size(143, 12);
            this.lblVentilationUnit1.TabIndex = 27;
            this.lblVentilationUnit1.Text = "Ventilation Unit #1 (Zone 1):";
            this.lblVentilationUnit1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVentilationControlView
            // 
            this.lblVentilationControlView.AutoSize = true;
            this.lblVentilationControlView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentilationControlView.Location = new System.Drawing.Point(12, 3);
            this.lblVentilationControlView.Margin = new System.Windows.Forms.Padding(0);
            this.lblVentilationControlView.Name = "lblVentilationControlView";
            this.lblVentilationControlView.Size = new System.Drawing.Size(142, 13);
            this.lblVentilationControlView.TabIndex = 26;
            this.lblVentilationControlView.Text = "Ventilation Control View";
            // 
            // panelBioTempControlView
            // 
            this.panelBioTempControlView.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panelBioTempControlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBioTempControlView.Controls.Add(this.lblBioHeater4On);
            this.panelBioTempControlView.Controls.Add(this.lblBioHeater4Off);
            this.panelBioTempControlView.Controls.Add(this.lblBioHeater3On);
            this.panelBioTempControlView.Controls.Add(this.lblBioHeater3Off);
            this.panelBioTempControlView.Controls.Add(this.lblBioHeater2On);
            this.panelBioTempControlView.Controls.Add(this.lblBioHeater2Off);
            this.panelBioTempControlView.Controls.Add(this.lblBioHeater1On);
            this.panelBioTempControlView.Controls.Add(this.lblBioHeater1Off);
            this.panelBioTempControlView.Controls.Add(this.lblHeater4);
            this.panelBioTempControlView.Controls.Add(this.lblHeater3);
            this.panelBioTempControlView.Controls.Add(this.lblHeater2);
            this.panelBioTempControlView.Controls.Add(this.lblHeater1);
            this.panelBioTempControlView.Controls.Add(this.lblTemperatureControlView);
            this.panelBioTempControlView.Location = new System.Drawing.Point(2, 126);
            this.panelBioTempControlView.Margin = new System.Windows.Forms.Padding(1);
            this.panelBioTempControlView.Name = "panelBioTempControlView";
            this.panelBioTempControlView.Size = new System.Drawing.Size(373, 155);
            this.panelBioTempControlView.TabIndex = 1;
            // 
            // lblBioHeater4On
            // 
            this.lblBioHeater4On.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioHeater4On.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioHeater4On.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioHeater4On.Location = new System.Drawing.Point(263, 121);
            this.lblBioHeater4On.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioHeater4On.Name = "lblBioHeater4On";
            this.lblBioHeater4On.Size = new System.Drawing.Size(84, 17);
            this.lblBioHeater4On.TabIndex = 35;
            this.lblBioHeater4On.Text = "On";
            this.lblBioHeater4On.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioHeater4Off
            // 
            this.lblBioHeater4Off.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioHeater4Off.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioHeater4Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioHeater4Off.Location = new System.Drawing.Point(177, 121);
            this.lblBioHeater4Off.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioHeater4Off.Name = "lblBioHeater4Off";
            this.lblBioHeater4Off.Size = new System.Drawing.Size(84, 17);
            this.lblBioHeater4Off.TabIndex = 34;
            this.lblBioHeater4Off.Text = "Off";
            this.lblBioHeater4Off.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioHeater3On
            // 
            this.lblBioHeater3On.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioHeater3On.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioHeater3On.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioHeater3On.Location = new System.Drawing.Point(263, 89);
            this.lblBioHeater3On.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioHeater3On.Name = "lblBioHeater3On";
            this.lblBioHeater3On.Size = new System.Drawing.Size(84, 17);
            this.lblBioHeater3On.TabIndex = 33;
            this.lblBioHeater3On.Text = "On";
            this.lblBioHeater3On.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioHeater3Off
            // 
            this.lblBioHeater3Off.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioHeater3Off.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioHeater3Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioHeater3Off.Location = new System.Drawing.Point(177, 89);
            this.lblBioHeater3Off.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioHeater3Off.Name = "lblBioHeater3Off";
            this.lblBioHeater3Off.Size = new System.Drawing.Size(84, 17);
            this.lblBioHeater3Off.TabIndex = 32;
            this.lblBioHeater3Off.Text = "Off";
            this.lblBioHeater3Off.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioHeater2On
            // 
            this.lblBioHeater2On.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioHeater2On.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioHeater2On.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioHeater2On.Location = new System.Drawing.Point(263, 57);
            this.lblBioHeater2On.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioHeater2On.Name = "lblBioHeater2On";
            this.lblBioHeater2On.Size = new System.Drawing.Size(84, 17);
            this.lblBioHeater2On.TabIndex = 31;
            this.lblBioHeater2On.Text = "On";
            this.lblBioHeater2On.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioHeater2Off
            // 
            this.lblBioHeater2Off.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioHeater2Off.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioHeater2Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioHeater2Off.Location = new System.Drawing.Point(177, 57);
            this.lblBioHeater2Off.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioHeater2Off.Name = "lblBioHeater2Off";
            this.lblBioHeater2Off.Size = new System.Drawing.Size(84, 17);
            this.lblBioHeater2Off.TabIndex = 30;
            this.lblBioHeater2Off.Text = "Off";
            this.lblBioHeater2Off.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioHeater1On
            // 
            this.lblBioHeater1On.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioHeater1On.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioHeater1On.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioHeater1On.Location = new System.Drawing.Point(263, 24);
            this.lblBioHeater1On.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioHeater1On.Name = "lblBioHeater1On";
            this.lblBioHeater1On.Size = new System.Drawing.Size(84, 17);
            this.lblBioHeater1On.TabIndex = 29;
            this.lblBioHeater1On.Text = "On";
            this.lblBioHeater1On.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioHeater1Off
            // 
            this.lblBioHeater1Off.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioHeater1Off.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioHeater1Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioHeater1Off.Location = new System.Drawing.Point(177, 24);
            this.lblBioHeater1Off.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioHeater1Off.Name = "lblBioHeater1Off";
            this.lblBioHeater1Off.Size = new System.Drawing.Size(84, 17);
            this.lblBioHeater1Off.TabIndex = 25;
            this.lblBioHeater1Off.Text = "Off";
            this.lblBioHeater1Off.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeater4
            // 
            this.lblHeater4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeater4.Location = new System.Drawing.Point(12, 124);
            this.lblHeater4.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeater4.Name = "lblHeater4";
            this.lblHeater4.Size = new System.Drawing.Size(131, 15);
            this.lblHeater4.TabIndex = 28;
            this.lblHeater4.Text = "Heater Unit #4 (Zone 2):";
            this.lblHeater4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeater3
            // 
            this.lblHeater3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeater3.Location = new System.Drawing.Point(12, 92);
            this.lblHeater3.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeater3.Name = "lblHeater3";
            this.lblHeater3.Size = new System.Drawing.Size(127, 15);
            this.lblHeater3.TabIndex = 27;
            this.lblHeater3.Text = "Heater Unit #3 (Zone 2):";
            this.lblHeater3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeater2
            // 
            this.lblHeater2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeater2.Location = new System.Drawing.Point(12, 60);
            this.lblHeater2.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeater2.Name = "lblHeater2";
            this.lblHeater2.Size = new System.Drawing.Size(125, 15);
            this.lblHeater2.TabIndex = 26;
            this.lblHeater2.Text = "Heater Unit #2 (Zone 1):";
            this.lblHeater2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeater1
            // 
            this.lblHeater1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeater1.Location = new System.Drawing.Point(12, 28);
            this.lblHeater1.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeater1.Name = "lblHeater1";
            this.lblHeater1.Size = new System.Drawing.Size(124, 15);
            this.lblHeater1.TabIndex = 25;
            this.lblHeater1.Text = "Heater Unit #1 (Zone 1):";
            this.lblHeater1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTemperatureControlView
            // 
            this.lblTemperatureControlView.AutoSize = true;
            this.lblTemperatureControlView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureControlView.Location = new System.Drawing.Point(12, 3);
            this.lblTemperatureControlView.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemperatureControlView.Name = "lblTemperatureControlView";
            this.lblTemperatureControlView.Size = new System.Drawing.Size(153, 13);
            this.lblTemperatureControlView.TabIndex = 25;
            this.lblTemperatureControlView.Text = "Temperature Control View";
            // 
            // panelBioExternalClimateControlView1_1
            // 
            this.panelBioExternalClimateControlView1_1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panelBioExternalClimateControlView1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.tbWindAvailControls);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.tbWindUsedControls);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.tbHumAvailControls);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.tbHumUsedControls);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.tbTempAvailControls);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.tbTempUsedControls);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblControlUnitsB);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblControlUnitsA);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblControlsUsed);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioWindSpeedLevel0);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioHumidLevel0);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioTempLevel0);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioWindSpeedLevel3);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioWindSpeedLevel2);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioWindSpeedLevel1);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblCurWindSeverity);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioCurWindSpeedHigh);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioCurWindSpeedOptimal);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioHumidLevel3);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioHumidLevel2);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioHumidLevel1);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblCurHumSeverity);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioCurHumTooDry);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioCurHumTooHum);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioCurHumOptimal);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioTempLevel3);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioTempLevel2);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioTempLevel1);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblCurTempSeverity);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioCurTempTooCold);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioCurTempTooHot);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioCurTempOptimal);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblCurrentWindClimateView);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblCurrentHumidClimateView);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblBioDomeClimateView);
            this.panelBioExternalClimateControlView1_1.Controls.Add(this.lblCurTempClimateView);
            this.panelBioExternalClimateControlView1_1.Location = new System.Drawing.Point(2, 1);
            this.panelBioExternalClimateControlView1_1.Margin = new System.Windows.Forms.Padding(1);
            this.panelBioExternalClimateControlView1_1.Name = "panelBioExternalClimateControlView1_1";
            this.panelBioExternalClimateControlView1_1.Size = new System.Drawing.Size(836, 122);
            this.panelBioExternalClimateControlView1_1.TabIndex = 0;
            // 
            // tbWindAvailControls
            // 
            this.tbWindAvailControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWindAvailControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWindAvailControls.ForeColor = System.Drawing.Color.Blue;
            this.tbWindAvailControls.Location = new System.Drawing.Point(791, 89);
            this.tbWindAvailControls.Margin = new System.Windows.Forms.Padding(1);
            this.tbWindAvailControls.Multiline = true;
            this.tbWindAvailControls.Name = "tbWindAvailControls";
            this.tbWindAvailControls.ReadOnly = true;
            this.tbWindAvailControls.Size = new System.Drawing.Size(24, 18);
            this.tbWindAvailControls.TabIndex = 43;
            this.tbWindAvailControls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWindUsedControls
            // 
            this.tbWindUsedControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWindUsedControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWindUsedControls.ForeColor = System.Drawing.Color.Red;
            this.tbWindUsedControls.Location = new System.Drawing.Point(735, 89);
            this.tbWindUsedControls.Margin = new System.Windows.Forms.Padding(1);
            this.tbWindUsedControls.Multiline = true;
            this.tbWindUsedControls.Name = "tbWindUsedControls";
            this.tbWindUsedControls.ReadOnly = true;
            this.tbWindUsedControls.Size = new System.Drawing.Size(24, 18);
            this.tbWindUsedControls.TabIndex = 42;
            this.tbWindUsedControls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHumAvailControls
            // 
            this.tbHumAvailControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHumAvailControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHumAvailControls.ForeColor = System.Drawing.Color.Blue;
            this.tbHumAvailControls.Location = new System.Drawing.Point(791, 57);
            this.tbHumAvailControls.Margin = new System.Windows.Forms.Padding(1);
            this.tbHumAvailControls.Multiline = true;
            this.tbHumAvailControls.Name = "tbHumAvailControls";
            this.tbHumAvailControls.ReadOnly = true;
            this.tbHumAvailControls.Size = new System.Drawing.Size(24, 18);
            this.tbHumAvailControls.TabIndex = 41;
            this.tbHumAvailControls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHumUsedControls
            // 
            this.tbHumUsedControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHumUsedControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHumUsedControls.ForeColor = System.Drawing.Color.Red;
            this.tbHumUsedControls.Location = new System.Drawing.Point(735, 57);
            this.tbHumUsedControls.Margin = new System.Windows.Forms.Padding(1);
            this.tbHumUsedControls.Multiline = true;
            this.tbHumUsedControls.Name = "tbHumUsedControls";
            this.tbHumUsedControls.ReadOnly = true;
            this.tbHumUsedControls.Size = new System.Drawing.Size(24, 18);
            this.tbHumUsedControls.TabIndex = 40;
            this.tbHumUsedControls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTempAvailControls
            // 
            this.tbTempAvailControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTempAvailControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTempAvailControls.ForeColor = System.Drawing.Color.Blue;
            this.tbTempAvailControls.Location = new System.Drawing.Point(791, 24);
            this.tbTempAvailControls.Margin = new System.Windows.Forms.Padding(1);
            this.tbTempAvailControls.Multiline = true;
            this.tbTempAvailControls.Name = "tbTempAvailControls";
            this.tbTempAvailControls.ReadOnly = true;
            this.tbTempAvailControls.Size = new System.Drawing.Size(24, 18);
            this.tbTempAvailControls.TabIndex = 39;
            this.tbTempAvailControls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTempUsedControls
            // 
            this.tbTempUsedControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTempUsedControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTempUsedControls.ForeColor = System.Drawing.Color.Red;
            this.tbTempUsedControls.Location = new System.Drawing.Point(735, 24);
            this.tbTempUsedControls.Margin = new System.Windows.Forms.Padding(1);
            this.tbTempUsedControls.Multiline = true;
            this.tbTempUsedControls.Name = "tbTempUsedControls";
            this.tbTempUsedControls.ReadOnly = true;
            this.tbTempUsedControls.Size = new System.Drawing.Size(24, 18);
            this.tbTempUsedControls.TabIndex = 38;
            this.tbTempUsedControls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblControlUnitsB
            // 
            this.lblControlUnitsB.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlUnitsB.Location = new System.Drawing.Point(690, 66);
            this.lblControlUnitsB.Margin = new System.Windows.Forms.Padding(0);
            this.lblControlUnitsB.Name = "lblControlUnitsB";
            this.lblControlUnitsB.Size = new System.Drawing.Size(36, 15);
            this.lblControlUnitsB.TabIndex = 37;
            this.lblControlUnitsB.Text = "States";
            this.lblControlUnitsB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControlUnitsA
            // 
            this.lblControlUnitsA.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlUnitsA.Location = new System.Drawing.Point(684, 51);
            this.lblControlUnitsA.Margin = new System.Windows.Forms.Padding(0);
            this.lblControlUnitsA.Name = "lblControlUnitsA";
            this.lblControlUnitsA.Size = new System.Drawing.Size(49, 15);
            this.lblControlUnitsA.TabIndex = 36;
            this.lblControlUnitsA.Text = "Control";
            this.lblControlUnitsA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControlsUsed
            // 
            this.lblControlsUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlsUsed.Location = new System.Drawing.Point(731, 8);
            this.lblControlsUsed.Margin = new System.Windows.Forms.Padding(0);
            this.lblControlsUsed.Name = "lblControlsUsed";
            this.lblControlsUsed.Size = new System.Drawing.Size(98, 15);
            this.lblControlsUsed.TabIndex = 28;
            this.lblControlsUsed.Text = "Used       Available";
            this.lblControlsUsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBioWindSpeedLevel0
            // 
            this.lblBioWindSpeedLevel0.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioWindSpeedLevel0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioWindSpeedLevel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioWindSpeedLevel0.Location = new System.Drawing.Point(460, 89);
            this.lblBioWindSpeedLevel0.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioWindSpeedLevel0.Name = "lblBioWindSpeedLevel0";
            this.lblBioWindSpeedLevel0.Size = new System.Drawing.Size(53, 17);
            this.lblBioWindSpeedLevel0.TabIndex = 27;
            this.lblBioWindSpeedLevel0.Text = "Level 0";
            this.lblBioWindSpeedLevel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioHumidLevel0
            // 
            this.lblBioHumidLevel0.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioHumidLevel0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioHumidLevel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioHumidLevel0.Location = new System.Drawing.Point(460, 57);
            this.lblBioHumidLevel0.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioHumidLevel0.Name = "lblBioHumidLevel0";
            this.lblBioHumidLevel0.Size = new System.Drawing.Size(53, 17);
            this.lblBioHumidLevel0.TabIndex = 26;
            this.lblBioHumidLevel0.Text = "Level 0";
            this.lblBioHumidLevel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioTempLevel0
            // 
            this.lblBioTempLevel0.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioTempLevel0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioTempLevel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioTempLevel0.Location = new System.Drawing.Point(460, 24);
            this.lblBioTempLevel0.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioTempLevel0.Name = "lblBioTempLevel0";
            this.lblBioTempLevel0.Size = new System.Drawing.Size(53, 17);
            this.lblBioTempLevel0.TabIndex = 25;
            this.lblBioTempLevel0.Text = "Level 0";
            this.lblBioTempLevel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioWindSpeedLevel3
            // 
            this.lblBioWindSpeedLevel3.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioWindSpeedLevel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioWindSpeedLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioWindSpeedLevel3.Location = new System.Drawing.Point(622, 89);
            this.lblBioWindSpeedLevel3.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioWindSpeedLevel3.Name = "lblBioWindSpeedLevel3";
            this.lblBioWindSpeedLevel3.Size = new System.Drawing.Size(53, 17);
            this.lblBioWindSpeedLevel3.TabIndex = 24;
            this.lblBioWindSpeedLevel3.Text = "Level 3";
            this.lblBioWindSpeedLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioWindSpeedLevel2
            // 
            this.lblBioWindSpeedLevel2.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioWindSpeedLevel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioWindSpeedLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioWindSpeedLevel2.Location = new System.Drawing.Point(568, 89);
            this.lblBioWindSpeedLevel2.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioWindSpeedLevel2.Name = "lblBioWindSpeedLevel2";
            this.lblBioWindSpeedLevel2.Size = new System.Drawing.Size(53, 17);
            this.lblBioWindSpeedLevel2.TabIndex = 23;
            this.lblBioWindSpeedLevel2.Text = "Level 2";
            this.lblBioWindSpeedLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioWindSpeedLevel1
            // 
            this.lblBioWindSpeedLevel1.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioWindSpeedLevel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioWindSpeedLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioWindSpeedLevel1.Location = new System.Drawing.Point(514, 89);
            this.lblBioWindSpeedLevel1.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioWindSpeedLevel1.Name = "lblBioWindSpeedLevel1";
            this.lblBioWindSpeedLevel1.Size = new System.Drawing.Size(53, 17);
            this.lblBioWindSpeedLevel1.TabIndex = 22;
            this.lblBioWindSpeedLevel1.Text = "Level 1";
            this.lblBioWindSpeedLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurWindSeverity
            // 
            this.lblCurWindSeverity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurWindSeverity.Location = new System.Drawing.Point(409, 91);
            this.lblCurWindSeverity.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurWindSeverity.Name = "lblCurWindSeverity";
            this.lblCurWindSeverity.Size = new System.Drawing.Size(60, 15);
            this.lblCurWindSeverity.TabIndex = 21;
            this.lblCurWindSeverity.Text = "Severity:";
            this.lblCurWindSeverity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBioCurWindSpeedHigh
            // 
            this.lblBioCurWindSpeedHigh.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioCurWindSpeedHigh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioCurWindSpeedHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioCurWindSpeedHigh.Location = new System.Drawing.Point(220, 89);
            this.lblBioCurWindSpeedHigh.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioCurWindSpeedHigh.Name = "lblBioCurWindSpeedHigh";
            this.lblBioCurWindSpeedHigh.Size = new System.Drawing.Size(84, 17);
            this.lblBioCurWindSpeedHigh.TabIndex = 20;
            this.lblBioCurWindSpeedHigh.Text = "Too High";
            this.lblBioCurWindSpeedHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioCurWindSpeedOptimal
            // 
            this.lblBioCurWindSpeedOptimal.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioCurWindSpeedOptimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioCurWindSpeedOptimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioCurWindSpeedOptimal.Location = new System.Drawing.Point(135, 89);
            this.lblBioCurWindSpeedOptimal.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioCurWindSpeedOptimal.Name = "lblBioCurWindSpeedOptimal";
            this.lblBioCurWindSpeedOptimal.Size = new System.Drawing.Size(84, 17);
            this.lblBioCurWindSpeedOptimal.TabIndex = 19;
            this.lblBioCurWindSpeedOptimal.Text = "Optimal";
            this.lblBioCurWindSpeedOptimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioHumidLevel3
            // 
            this.lblBioHumidLevel3.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioHumidLevel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioHumidLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioHumidLevel3.Location = new System.Drawing.Point(622, 57);
            this.lblBioHumidLevel3.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioHumidLevel3.Name = "lblBioHumidLevel3";
            this.lblBioHumidLevel3.Size = new System.Drawing.Size(53, 17);
            this.lblBioHumidLevel3.TabIndex = 18;
            this.lblBioHumidLevel3.Text = "Level 3";
            this.lblBioHumidLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioHumidLevel2
            // 
            this.lblBioHumidLevel2.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioHumidLevel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioHumidLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioHumidLevel2.Location = new System.Drawing.Point(568, 57);
            this.lblBioHumidLevel2.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioHumidLevel2.Name = "lblBioHumidLevel2";
            this.lblBioHumidLevel2.Size = new System.Drawing.Size(53, 17);
            this.lblBioHumidLevel2.TabIndex = 17;
            this.lblBioHumidLevel2.Text = "Level 2";
            this.lblBioHumidLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioHumidLevel1
            // 
            this.lblBioHumidLevel1.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioHumidLevel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioHumidLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioHumidLevel1.Location = new System.Drawing.Point(514, 57);
            this.lblBioHumidLevel1.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioHumidLevel1.Name = "lblBioHumidLevel1";
            this.lblBioHumidLevel1.Size = new System.Drawing.Size(53, 17);
            this.lblBioHumidLevel1.TabIndex = 16;
            this.lblBioHumidLevel1.Text = "Level 1";
            this.lblBioHumidLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurHumSeverity
            // 
            this.lblCurHumSeverity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurHumSeverity.Location = new System.Drawing.Point(409, 59);
            this.lblCurHumSeverity.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurHumSeverity.Name = "lblCurHumSeverity";
            this.lblCurHumSeverity.Size = new System.Drawing.Size(60, 15);
            this.lblCurHumSeverity.TabIndex = 15;
            this.lblCurHumSeverity.Text = "Severity:";
            this.lblCurHumSeverity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBioCurHumTooDry
            // 
            this.lblBioCurHumTooDry.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioCurHumTooDry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioCurHumTooDry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioCurHumTooDry.Location = new System.Drawing.Point(304, 57);
            this.lblBioCurHumTooDry.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioCurHumTooDry.Name = "lblBioCurHumTooDry";
            this.lblBioCurHumTooDry.Size = new System.Drawing.Size(84, 17);
            this.lblBioCurHumTooDry.TabIndex = 14;
            this.lblBioCurHumTooDry.Text = "Too Dry";
            this.lblBioCurHumTooDry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioCurHumTooHum
            // 
            this.lblBioCurHumTooHum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBioCurHumTooHum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioCurHumTooHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioCurHumTooHum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBioCurHumTooHum.Location = new System.Drawing.Point(220, 57);
            this.lblBioCurHumTooHum.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioCurHumTooHum.Name = "lblBioCurHumTooHum";
            this.lblBioCurHumTooHum.Size = new System.Drawing.Size(84, 17);
            this.lblBioCurHumTooHum.TabIndex = 12;
            this.lblBioCurHumTooHum.Text = "Too Humid";
            this.lblBioCurHumTooHum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioCurHumOptimal
            // 
            this.lblBioCurHumOptimal.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioCurHumOptimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioCurHumOptimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioCurHumOptimal.Location = new System.Drawing.Point(135, 57);
            this.lblBioCurHumOptimal.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioCurHumOptimal.Name = "lblBioCurHumOptimal";
            this.lblBioCurHumOptimal.Size = new System.Drawing.Size(84, 17);
            this.lblBioCurHumOptimal.TabIndex = 11;
            this.lblBioCurHumOptimal.Text = "Optimal";
            this.lblBioCurHumOptimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioTempLevel3
            // 
            this.lblBioTempLevel3.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioTempLevel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioTempLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioTempLevel3.Location = new System.Drawing.Point(622, 24);
            this.lblBioTempLevel3.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioTempLevel3.Name = "lblBioTempLevel3";
            this.lblBioTempLevel3.Size = new System.Drawing.Size(53, 17);
            this.lblBioTempLevel3.TabIndex = 10;
            this.lblBioTempLevel3.Text = "Level 3";
            this.lblBioTempLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioTempLevel2
            // 
            this.lblBioTempLevel2.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioTempLevel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioTempLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioTempLevel2.Location = new System.Drawing.Point(568, 24);
            this.lblBioTempLevel2.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioTempLevel2.Name = "lblBioTempLevel2";
            this.lblBioTempLevel2.Size = new System.Drawing.Size(53, 17);
            this.lblBioTempLevel2.TabIndex = 9;
            this.lblBioTempLevel2.Text = "Level 2";
            this.lblBioTempLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioTempLevel1
            // 
            this.lblBioTempLevel1.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioTempLevel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioTempLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioTempLevel1.Location = new System.Drawing.Point(514, 24);
            this.lblBioTempLevel1.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioTempLevel1.Name = "lblBioTempLevel1";
            this.lblBioTempLevel1.Size = new System.Drawing.Size(53, 17);
            this.lblBioTempLevel1.TabIndex = 8;
            this.lblBioTempLevel1.Text = "Level 1";
            this.lblBioTempLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurTempSeverity
            // 
            this.lblCurTempSeverity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurTempSeverity.Location = new System.Drawing.Point(409, 25);
            this.lblCurTempSeverity.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurTempSeverity.Name = "lblCurTempSeverity";
            this.lblCurTempSeverity.Size = new System.Drawing.Size(60, 15);
            this.lblCurTempSeverity.TabIndex = 7;
            this.lblCurTempSeverity.Text = "Severity:";
            this.lblCurTempSeverity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBioCurTempTooCold
            // 
            this.lblBioCurTempTooCold.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioCurTempTooCold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioCurTempTooCold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioCurTempTooCold.Location = new System.Drawing.Point(304, 24);
            this.lblBioCurTempTooCold.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioCurTempTooCold.Name = "lblBioCurTempTooCold";
            this.lblBioCurTempTooCold.Size = new System.Drawing.Size(84, 17);
            this.lblBioCurTempTooCold.TabIndex = 6;
            this.lblBioCurTempTooCold.Text = "Too Cold";
            this.lblBioCurTempTooCold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioCurTempTooHot
            // 
            this.lblBioCurTempTooHot.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioCurTempTooHot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioCurTempTooHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioCurTempTooHot.Location = new System.Drawing.Point(220, 24);
            this.lblBioCurTempTooHot.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioCurTempTooHot.Name = "lblBioCurTempTooHot";
            this.lblBioCurTempTooHot.Size = new System.Drawing.Size(84, 17);
            this.lblBioCurTempTooHot.TabIndex = 5;
            this.lblBioCurTempTooHot.Text = "Too Hot";
            this.lblBioCurTempTooHot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBioCurTempOptimal
            // 
            this.lblBioCurTempOptimal.BackColor = System.Drawing.SystemColors.Control;
            this.lblBioCurTempOptimal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBioCurTempOptimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioCurTempOptimal.Location = new System.Drawing.Point(135, 24);
            this.lblBioCurTempOptimal.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioCurTempOptimal.Name = "lblBioCurTempOptimal";
            this.lblBioCurTempOptimal.Size = new System.Drawing.Size(84, 17);
            this.lblBioCurTempOptimal.TabIndex = 4;
            this.lblBioCurTempOptimal.Text = "Optimal";
            this.lblBioCurTempOptimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentWindClimateView
            // 
            this.lblCurrentWindClimateView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWindClimateView.Location = new System.Drawing.Point(12, 92);
            this.lblCurrentWindClimateView.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentWindClimateView.Name = "lblCurrentWindClimateView";
            this.lblCurrentWindClimateView.Size = new System.Drawing.Size(116, 15);
            this.lblCurrentWindClimateView.TabIndex = 3;
            this.lblCurrentWindClimateView.Text = "Current Wind Speed:";
            this.lblCurrentWindClimateView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentHumidClimateView
            // 
            this.lblCurrentHumidClimateView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHumidClimateView.Location = new System.Drawing.Point(12, 60);
            this.lblCurrentHumidClimateView.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentHumidClimateView.Name = "lblCurrentHumidClimateView";
            this.lblCurrentHumidClimateView.Size = new System.Drawing.Size(108, 12);
            this.lblCurrentHumidClimateView.TabIndex = 2;
            this.lblCurrentHumidClimateView.Text = "Current Humidity:";
            this.lblCurrentHumidClimateView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBioDomeClimateView
            // 
            this.lblBioDomeClimateView.AutoSize = true;
            this.lblBioDomeClimateView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBioDomeClimateView.Location = new System.Drawing.Point(12, 3);
            this.lblBioDomeClimateView.Margin = new System.Windows.Forms.Padding(0);
            this.lblBioDomeClimateView.Name = "lblBioDomeClimateView";
            this.lblBioDomeClimateView.Size = new System.Drawing.Size(137, 13);
            this.lblBioDomeClimateView.TabIndex = 1;
            this.lblBioDomeClimateView.Text = "Bio-Dome Climate View";
            // 
            // lblCurTempClimateView
            // 
            this.lblCurTempClimateView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurTempClimateView.Location = new System.Drawing.Point(12, 28);
            this.lblCurTempClimateView.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurTempClimateView.Name = "lblCurTempClimateView";
            this.lblCurTempClimateView.Size = new System.Drawing.Size(124, 12);
            this.lblCurTempClimateView.TabIndex = 0;
            this.lblCurTempClimateView.Text = "Current Temperature:";
            this.lblCurTempClimateView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBioDomeTestBed
            // 
            this.panelBioDomeTestBed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelBioDomeTestBed.Controls.Add(this.panelBioDomeLogging);
            this.panelBioDomeTestBed.Controls.Add(this.panelBioDomeLoggingCover);
            this.panelBioDomeTestBed.Controls.Add(this.panelMainTestPage);
            this.panelBioDomeTestBed.Controls.Add(this.panelTpTestplanImplementationTool);
            this.panelBioDomeTestBed.Controls.Add(this.panelExpTestcaseImplementationTool);
            this.panelBioDomeTestBed.Location = new System.Drawing.Point(0, 352);
            this.panelBioDomeTestBed.Margin = new System.Windows.Forms.Padding(1);
            this.panelBioDomeTestBed.Name = "panelBioDomeTestBed";
            this.panelBioDomeTestBed.Size = new System.Drawing.Size(1200, 554);
            this.panelBioDomeTestBed.TabIndex = 1;
            // 
            // panelBioDomeLogging
            // 
            this.panelBioDomeLogging.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelBioDomeLogging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBioDomeLogging.Controls.Add(this.button2);
            this.panelBioDomeLogging.Controls.Add(this.lblBdlLoggingWindow);
            this.panelBioDomeLogging.Controls.Add(this.btnBdlClearLoggingWindow);
            this.panelBioDomeLogging.Controls.Add(this.btnBdlSaveToLogfile);
            this.panelBioDomeLogging.Controls.Add(this.btnBdlPrintLogReport);
            this.panelBioDomeLogging.Controls.Add(this.btnBdlPrintTestReport);
            this.panelBioDomeLogging.Controls.Add(this.btnBdlCreateNewLogfile);
            this.panelBioDomeLogging.Controls.Add(this.tbBdlLoggingFilename);
            this.panelBioDomeLogging.Controls.Add(this.lblBdlLoggingFileName);
            this.panelBioDomeLogging.Controls.Add(this.rtbBdlLoggingWindow);
            this.panelBioDomeLogging.Controls.Add(this.lblBdlLoggingAndReportingTool);
            this.panelBioDomeLogging.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelBioDomeLogging.Location = new System.Drawing.Point(744, 4);
            this.panelBioDomeLogging.Margin = new System.Windows.Forms.Padding(1);
            this.panelBioDomeLogging.Name = "panelBioDomeLogging";
            this.panelBioDomeLogging.Size = new System.Drawing.Size(455, 547);
            this.panelBioDomeLogging.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(308, 516);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 61;
            this.button2.Text = "Display Failed Tests";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblBdlLoggingWindow
            // 
            this.lblBdlLoggingWindow.AutoSize = true;
            this.lblBdlLoggingWindow.Location = new System.Drawing.Point(4, 28);
            this.lblBdlLoggingWindow.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBdlLoggingWindow.Name = "lblBdlLoggingWindow";
            this.lblBdlLoggingWindow.Size = new System.Drawing.Size(87, 13);
            this.lblBdlLoggingWindow.TabIndex = 60;
            this.lblBdlLoggingWindow.Text = "Logging Window";
            // 
            // btnBdlClearLoggingWindow
            // 
            this.btnBdlClearLoggingWindow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBdlClearLoggingWindow.FlatAppearance.BorderSize = 2;
            this.btnBdlClearLoggingWindow.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBdlClearLoggingWindow.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBdlClearLoggingWindow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBdlClearLoggingWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBdlClearLoggingWindow.Location = new System.Drawing.Point(160, 480);
            this.btnBdlClearLoggingWindow.Margin = new System.Windows.Forms.Padding(1);
            this.btnBdlClearLoggingWindow.Name = "btnBdlClearLoggingWindow";
            this.btnBdlClearLoggingWindow.Size = new System.Drawing.Size(140, 23);
            this.btnBdlClearLoggingWindow.TabIndex = 59;
            this.btnBdlClearLoggingWindow.Text = "Clear Logging Window";
            this.btnBdlClearLoggingWindow.UseVisualStyleBackColor = false;
            this.btnBdlClearLoggingWindow.Click += new System.EventHandler(this.btnBdlClearLoggingWindow_Click);
            // 
            // btnBdlSaveToLogfile
            // 
            this.btnBdlSaveToLogfile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBdlSaveToLogfile.FlatAppearance.BorderSize = 2;
            this.btnBdlSaveToLogfile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBdlSaveToLogfile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBdlSaveToLogfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBdlSaveToLogfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBdlSaveToLogfile.Location = new System.Drawing.Point(308, 480);
            this.btnBdlSaveToLogfile.Margin = new System.Windows.Forms.Padding(1);
            this.btnBdlSaveToLogfile.Name = "btnBdlSaveToLogfile";
            this.btnBdlSaveToLogfile.Size = new System.Drawing.Size(140, 23);
            this.btnBdlSaveToLogfile.TabIndex = 58;
            this.btnBdlSaveToLogfile.Text = "Save to Logfile";
            this.btnBdlSaveToLogfile.UseVisualStyleBackColor = false;
            this.btnBdlSaveToLogfile.Click += new System.EventHandler(this.btnBdlSaveToLogfile_Click);
            // 
            // btnBdlPrintLogReport
            // 
            this.btnBdlPrintLogReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBdlPrintLogReport.FlatAppearance.BorderSize = 2;
            this.btnBdlPrintLogReport.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBdlPrintLogReport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBdlPrintLogReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBdlPrintLogReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBdlPrintLogReport.Location = new System.Drawing.Point(160, 516);
            this.btnBdlPrintLogReport.Margin = new System.Windows.Forms.Padding(1);
            this.btnBdlPrintLogReport.Name = "btnBdlPrintLogReport";
            this.btnBdlPrintLogReport.Size = new System.Drawing.Size(140, 23);
            this.btnBdlPrintLogReport.TabIndex = 57;
            this.btnBdlPrintLogReport.Text = "Print Log Report";
            this.btnBdlPrintLogReport.UseVisualStyleBackColor = false;
            this.btnBdlPrintLogReport.Click += new System.EventHandler(this.btnBdlPrintLogReport_Click);
            // 
            // btnBdlPrintTestReport
            // 
            this.btnBdlPrintTestReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBdlPrintTestReport.FlatAppearance.BorderSize = 2;
            this.btnBdlPrintTestReport.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBdlPrintTestReport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBdlPrintTestReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBdlPrintTestReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBdlPrintTestReport.Location = new System.Drawing.Point(4, 516);
            this.btnBdlPrintTestReport.Margin = new System.Windows.Forms.Padding(1);
            this.btnBdlPrintTestReport.Name = "btnBdlPrintTestReport";
            this.btnBdlPrintTestReport.Size = new System.Drawing.Size(141, 23);
            this.btnBdlPrintTestReport.TabIndex = 56;
            this.btnBdlPrintTestReport.Text = "Print Test Report";
            this.btnBdlPrintTestReport.UseVisualStyleBackColor = false;
            this.btnBdlPrintTestReport.Click += new System.EventHandler(this.btnBdlPrintTestReport_Click);
            // 
            // btnBdlCreateNewLogfile
            // 
            this.btnBdlCreateNewLogfile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBdlCreateNewLogfile.FlatAppearance.BorderSize = 2;
            this.btnBdlCreateNewLogfile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBdlCreateNewLogfile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBdlCreateNewLogfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBdlCreateNewLogfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBdlCreateNewLogfile.Location = new System.Drawing.Point(7, 480);
            this.btnBdlCreateNewLogfile.Margin = new System.Windows.Forms.Padding(1);
            this.btnBdlCreateNewLogfile.Name = "btnBdlCreateNewLogfile";
            this.btnBdlCreateNewLogfile.Size = new System.Drawing.Size(140, 23);
            this.btnBdlCreateNewLogfile.TabIndex = 55;
            this.btnBdlCreateNewLogfile.Text = "Create New Logfile";
            this.btnBdlCreateNewLogfile.UseVisualStyleBackColor = false;
            this.btnBdlCreateNewLogfile.Click += new System.EventHandler(this.btnBdlCreateNewLogfile_Click);
            // 
            // tbBdlLoggingFilename
            // 
            this.tbBdlLoggingFilename.BackColor = System.Drawing.Color.White;
            this.tbBdlLoggingFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBdlLoggingFilename.ForeColor = System.Drawing.Color.Blue;
            this.tbBdlLoggingFilename.Location = new System.Drawing.Point(104, 449);
            this.tbBdlLoggingFilename.Margin = new System.Windows.Forms.Padding(1);
            this.tbBdlLoggingFilename.Multiline = true;
            this.tbBdlLoggingFilename.Name = "tbBdlLoggingFilename";
            this.tbBdlLoggingFilename.Size = new System.Drawing.Size(348, 20);
            this.tbBdlLoggingFilename.TabIndex = 54;
            // 
            // lblBdlLoggingFileName
            // 
            this.lblBdlLoggingFileName.AutoSize = true;
            this.lblBdlLoggingFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBdlLoggingFileName.Location = new System.Drawing.Point(7, 452);
            this.lblBdlLoggingFileName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBdlLoggingFileName.Name = "lblBdlLoggingFileName";
            this.lblBdlLoggingFileName.Size = new System.Drawing.Size(93, 13);
            this.lblBdlLoggingFileName.TabIndex = 52;
            this.lblBdlLoggingFileName.Text = "Logging Filename:";
            // 
            // rtbBdlLoggingWindow
            // 
            this.rtbBdlLoggingWindow.BackColor = System.Drawing.Color.White;
            this.rtbBdlLoggingWindow.Font = new System.Drawing.Font("Courier New", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBdlLoggingWindow.Location = new System.Drawing.Point(4, 44);
            this.rtbBdlLoggingWindow.Margin = new System.Windows.Forms.Padding(1);
            this.rtbBdlLoggingWindow.Name = "rtbBdlLoggingWindow";
            this.rtbBdlLoggingWindow.Size = new System.Drawing.Size(445, 400);
            this.rtbBdlLoggingWindow.TabIndex = 51;
            this.rtbBdlLoggingWindow.Text = "";
            // 
            // lblBdlLoggingAndReportingTool
            // 
            this.lblBdlLoggingAndReportingTool.AutoSize = true;
            this.lblBdlLoggingAndReportingTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBdlLoggingAndReportingTool.Location = new System.Drawing.Point(4, 4);
            this.lblBdlLoggingAndReportingTool.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBdlLoggingAndReportingTool.Name = "lblBdlLoggingAndReportingTool";
            this.lblBdlLoggingAndReportingTool.Size = new System.Drawing.Size(189, 13);
            this.lblBdlLoggingAndReportingTool.TabIndex = 50;
            this.lblBdlLoggingAndReportingTool.Text = "Logging And Reporting Tool (L.A.R.T.)";
            // 
            // panelBioDomeLoggingCover
            // 
            this.panelBioDomeLoggingCover.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelBioDomeLoggingCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBioDomeLoggingCover.Controls.Add(this.btnOpenLoggingWindow);
            this.panelBioDomeLoggingCover.Controls.Add(this.pbBioLoggingCoverTop);
            this.panelBioDomeLoggingCover.Controls.Add(this.pbBioLoggingCoverBottom);
            this.panelBioDomeLoggingCover.Location = new System.Drawing.Point(744, 4);
            this.panelBioDomeLoggingCover.Margin = new System.Windows.Forms.Padding(1);
            this.panelBioDomeLoggingCover.Name = "panelBioDomeLoggingCover";
            this.panelBioDomeLoggingCover.Size = new System.Drawing.Size(454, 547);
            this.panelBioDomeLoggingCover.TabIndex = 5;
            // 
            // btnOpenLoggingWindow
            // 
            this.btnOpenLoggingWindow.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOpenLoggingWindow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenLoggingWindow.Location = new System.Drawing.Point(15, 510);
            this.btnOpenLoggingWindow.Margin = new System.Windows.Forms.Padding(1);
            this.btnOpenLoggingWindow.Name = "btnOpenLoggingWindow";
            this.btnOpenLoggingWindow.Size = new System.Drawing.Size(132, 24);
            this.btnOpenLoggingWindow.TabIndex = 2;
            this.btnOpenLoggingWindow.Text = "Show Logging Window";
            this.btnOpenLoggingWindow.UseVisualStyleBackColor = false;
            this.btnOpenLoggingWindow.Click += new System.EventHandler(this.btnOpenLoggingWindow_Click);
            // 
            // pbBioLoggingCoverTop
            // 
            this.pbBioLoggingCoverTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBioLoggingCoverTop.Image = global::BioDomeSimulator.Properties.Resources.ShuttleInSpaceSmaller2;
            this.pbBioLoggingCoverTop.Location = new System.Drawing.Point(-1, 0);
            this.pbBioLoggingCoverTop.Margin = new System.Windows.Forms.Padding(1);
            this.pbBioLoggingCoverTop.Name = "pbBioLoggingCoverTop";
            this.pbBioLoggingCoverTop.Size = new System.Drawing.Size(457, 377);
            this.pbBioLoggingCoverTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBioLoggingCoverTop.TabIndex = 0;
            this.pbBioLoggingCoverTop.TabStop = false;
            // 
            // pbBioLoggingCoverBottom
            // 
            this.pbBioLoggingCoverBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pbBioLoggingCoverBottom.Image = global::BioDomeSimulator.Properties.Resources.DeltaComLogo2;
            this.pbBioLoggingCoverBottom.Location = new System.Drawing.Point(0, 380);
            this.pbBioLoggingCoverBottom.Margin = new System.Windows.Forms.Padding(1);
            this.pbBioLoggingCoverBottom.Name = "pbBioLoggingCoverBottom";
            this.pbBioLoggingCoverBottom.Size = new System.Drawing.Size(456, 168);
            this.pbBioLoggingCoverBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBioLoggingCoverBottom.TabIndex = 1;
            this.pbBioLoggingCoverBottom.TabStop = false;
            // 
            // panelExpTestcaseImplementationTool
            // 
            this.panelExpTestcaseImplementationTool.AutoSize = true;
            this.panelExpTestcaseImplementationTool.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelExpTestcaseImplementationTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExpTestcaseImplementationTool.Controls.Add(this.tbCurrentTestCaseSelected);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.labCurrentTestCase);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.btnExpLogDefectIncident);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.cmbSelectATestPlanFromTheList);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpSelectTestPlan);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpCurrentControlValues);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.rtbExpCurrentControlValues);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.btnExpLoadNewTestcase);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.tbExpTestCaseNumberOf);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpTestCaseNumberOf);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.btnExpNextTestCase);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.btnExpLastTestCase);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.btnExpPreviousTestCase);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpActualResults);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.rtbExpActualResults);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.btnExpFirstTestCase);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.btnExpCloseTestSession);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.btnExpClearTestCase);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.btnExpDeleteTestCase);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.tbExpTestcaseResult);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpTestcaseResult);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.btnExpSaveTestCase);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.rtbExpExpectedResults);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpExpectedResults);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.cmbExpSprink2);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.btnExpRunTestCase);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.cmbExpSprink1);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpSprink2);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpSprink1);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.cmbExpVent4);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.cmbExpVent3);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.cmbExpVent2);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.cmbExpVent1);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpVent4);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpVent3);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpVent2);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpVent1);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.cmbExpHeater4);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.cmbExpHeater3);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.cmbExpHeater2);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.cmbExpHeater1);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpHeater4);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpHeater3);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpHeater2);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpHeater1);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpSetControlInputs);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpDateOfTest);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.dtpExpDateOfTest);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.numExpWindSpeedValue);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.numExpHumidValue);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.numExpTempValue);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpWindSpeedValue);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpHumidValue);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpTempValue);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpSetClimateTestInputs);
            this.panelExpTestcaseImplementationTool.Controls.Add(this.lblExpExploratoryTestcaseImplementationTool);
            this.panelExpTestcaseImplementationTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelExpTestcaseImplementationTool.Location = new System.Drawing.Point(3, 4);
            this.panelExpTestcaseImplementationTool.Margin = new System.Windows.Forms.Padding(1);
            this.panelExpTestcaseImplementationTool.Name = "panelExpTestcaseImplementationTool";
            this.panelExpTestcaseImplementationTool.Size = new System.Drawing.Size(738, 547);
            this.panelExpTestcaseImplementationTool.TabIndex = 0;
            // 
            // tbCurrentTestCaseSelected
            // 
            this.tbCurrentTestCaseSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentTestCaseSelected.ForeColor = System.Drawing.Color.Blue;
            this.tbCurrentTestCaseSelected.Location = new System.Drawing.Point(600, 64);
            this.tbCurrentTestCaseSelected.Margin = new System.Windows.Forms.Padding(1);
            this.tbCurrentTestCaseSelected.Multiline = true;
            this.tbCurrentTestCaseSelected.Name = "tbCurrentTestCaseSelected";
            this.tbCurrentTestCaseSelected.ReadOnly = true;
            this.tbCurrentTestCaseSelected.Size = new System.Drawing.Size(128, 20);
            this.tbCurrentTestCaseSelected.TabIndex = 66;
            this.tbCurrentTestCaseSelected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labCurrentTestCase
            // 
            this.labCurrentTestCase.AutoSize = true;
            this.labCurrentTestCase.Location = new System.Drawing.Point(545, 67);
            this.labCurrentTestCase.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labCurrentTestCase.Name = "labCurrentTestCase";
            this.labCurrentTestCase.Size = new System.Drawing.Size(54, 13);
            this.labCurrentTestCase.TabIndex = 65;
            this.labCurrentTestCase.Text = "Testcase:";
            // 
            // btnExpLogDefectIncident
            // 
            this.btnExpLogDefectIncident.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpLogDefectIncident.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExpLogDefectIncident.FlatAppearance.BorderSize = 2;
            this.btnExpLogDefectIncident.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpLogDefectIncident.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpLogDefectIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpLogDefectIncident.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExpLogDefectIncident.Location = new System.Drawing.Point(565, 483);
            this.btnExpLogDefectIncident.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpLogDefectIncident.Name = "btnExpLogDefectIncident";
            this.btnExpLogDefectIncident.Size = new System.Drawing.Size(160, 23);
            this.btnExpLogDefectIncident.TabIndex = 64;
            this.btnExpLogDefectIncident.Text = "Log Defect/Incident";
            this.btnExpLogDefectIncident.UseVisualStyleBackColor = false;
            // 
            // cmbSelectATestPlanFromTheList
            // 
            this.cmbSelectATestPlanFromTheList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectATestPlanFromTheList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectATestPlanFromTheList.ForeColor = System.Drawing.Color.Black;
            this.cmbSelectATestPlanFromTheList.FormattingEnabled = true;
            this.cmbSelectATestPlanFromTheList.ItemHeight = 15;
            this.cmbSelectATestPlanFromTheList.Location = new System.Drawing.Point(544, 24);
            this.cmbSelectATestPlanFromTheList.Margin = new System.Windows.Forms.Padding(1);
            this.cmbSelectATestPlanFromTheList.Name = "cmbSelectATestPlanFromTheList";
            this.cmbSelectATestPlanFromTheList.Size = new System.Drawing.Size(184, 23);
            this.cmbSelectATestPlanFromTheList.TabIndex = 63;
            // 
            // lblExpSelectTestPlan
            // 
            this.lblExpSelectTestPlan.AutoSize = true;
            this.lblExpSelectTestPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpSelectTestPlan.Location = new System.Drawing.Point(374, 28);
            this.lblExpSelectTestPlan.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpSelectTestPlan.Name = "lblExpSelectTestPlan";
            this.lblExpSelectTestPlan.Size = new System.Drawing.Size(168, 13);
            this.lblExpSelectTestPlan.TabIndex = 62;
            this.lblExpSelectTestPlan.Text = "Select A Test Plan From The List: ";
            // 
            // lblExpCurrentControlValues
            // 
            this.lblExpCurrentControlValues.AutoSize = true;
            this.lblExpCurrentControlValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpCurrentControlValues.Location = new System.Drawing.Point(6, 220);
            this.lblExpCurrentControlValues.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpCurrentControlValues.Name = "lblExpCurrentControlValues";
            this.lblExpCurrentControlValues.Size = new System.Drawing.Size(125, 13);
            this.lblExpCurrentControlValues.TabIndex = 61;
            this.lblExpCurrentControlValues.Text = "Current Simulator Values:";
            // 
            // rtbExpCurrentControlValues
            // 
            this.rtbExpCurrentControlValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbExpCurrentControlValues.Location = new System.Drawing.Point(4, 236);
            this.rtbExpCurrentControlValues.Margin = new System.Windows.Forms.Padding(1);
            this.rtbExpCurrentControlValues.Name = "rtbExpCurrentControlValues";
            this.rtbExpCurrentControlValues.Size = new System.Drawing.Size(179, 272);
            this.rtbExpCurrentControlValues.TabIndex = 60;
            this.rtbExpCurrentControlValues.Text = "";
            // 
            // btnExpLoadNewTestcase
            // 
            this.btnExpLoadNewTestcase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpLoadNewTestcase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpLoadNewTestcase.Location = new System.Drawing.Point(565, 263);
            this.btnExpLoadNewTestcase.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpLoadNewTestcase.Name = "btnExpLoadNewTestcase";
            this.btnExpLoadNewTestcase.Size = new System.Drawing.Size(160, 23);
            this.btnExpLoadNewTestcase.TabIndex = 59;
            this.btnExpLoadNewTestcase.Text = "Load New Testcase Template";
            this.btnExpLoadNewTestcase.UseVisualStyleBackColor = false;
            this.btnExpLoadNewTestcase.Click += new System.EventHandler(this.btnExpLoadNewTestcase_Click);
            // 
            // tbExpTestCaseNumberOf
            // 
            this.tbExpTestCaseNumberOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExpTestCaseNumberOf.ForeColor = System.Drawing.Color.Blue;
            this.tbExpTestCaseNumberOf.Location = new System.Drawing.Point(247, 518);
            this.tbExpTestCaseNumberOf.Margin = new System.Windows.Forms.Padding(1);
            this.tbExpTestCaseNumberOf.Multiline = true;
            this.tbExpTestCaseNumberOf.Name = "tbExpTestCaseNumberOf";
            this.tbExpTestCaseNumberOf.ReadOnly = true;
            this.tbExpTestCaseNumberOf.Size = new System.Drawing.Size(115, 20);
            this.tbExpTestCaseNumberOf.TabIndex = 58;
            this.tbExpTestCaseNumberOf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblExpTestCaseNumberOf
            // 
            this.lblExpTestCaseNumberOf.AutoSize = true;
            this.lblExpTestCaseNumberOf.Location = new System.Drawing.Point(192, 520);
            this.lblExpTestCaseNumberOf.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpTestCaseNumberOf.Name = "lblExpTestCaseNumberOf";
            this.lblExpTestCaseNumberOf.Size = new System.Drawing.Size(54, 13);
            this.lblExpTestCaseNumberOf.TabIndex = 57;
            this.lblExpTestCaseNumberOf.Text = "Testcase:";
            // 
            // btnExpNextTestCase
            // 
            this.btnExpNextTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpNextTestCase.FlatAppearance.BorderSize = 2;
            this.btnExpNextTestCase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpNextTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpNextTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpNextTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpNextTestCase.Location = new System.Drawing.Point(376, 516);
            this.btnExpNextTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpNextTestCase.Name = "btnExpNextTestCase";
            this.btnExpNextTestCase.Size = new System.Drawing.Size(31, 23);
            this.btnExpNextTestCase.TabIndex = 56;
            this.btnExpNextTestCase.Text = ">";
            this.btnExpNextTestCase.UseVisualStyleBackColor = false;
            // 
            // btnExpLastTestCase
            // 
            this.btnExpLastTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpLastTestCase.FlatAppearance.BorderSize = 2;
            this.btnExpLastTestCase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpLastTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpLastTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpLastTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpLastTestCase.Location = new System.Drawing.Point(427, 516);
            this.btnExpLastTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpLastTestCase.Name = "btnExpLastTestCase";
            this.btnExpLastTestCase.Size = new System.Drawing.Size(31, 23);
            this.btnExpLastTestCase.TabIndex = 55;
            this.btnExpLastTestCase.Text = ">>";
            this.btnExpLastTestCase.UseVisualStyleBackColor = false;
            // 
            // btnExpPreviousTestCase
            // 
            this.btnExpPreviousTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpPreviousTestCase.FlatAppearance.BorderSize = 2;
            this.btnExpPreviousTestCase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpPreviousTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpPreviousTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpPreviousTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpPreviousTestCase.Location = new System.Drawing.Point(143, 516);
            this.btnExpPreviousTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpPreviousTestCase.Name = "btnExpPreviousTestCase";
            this.btnExpPreviousTestCase.Size = new System.Drawing.Size(31, 23);
            this.btnExpPreviousTestCase.TabIndex = 54;
            this.btnExpPreviousTestCase.Text = "<";
            this.btnExpPreviousTestCase.UseVisualStyleBackColor = false;
            // 
            // lblExpActualResults
            // 
            this.lblExpActualResults.AutoSize = true;
            this.lblExpActualResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpActualResults.Location = new System.Drawing.Point(376, 220);
            this.lblExpActualResults.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpActualResults.Name = "lblExpActualResults";
            this.lblExpActualResults.Size = new System.Drawing.Size(78, 13);
            this.lblExpActualResults.TabIndex = 50;
            this.lblExpActualResults.Text = "Actual Results:";
            // 
            // rtbExpActualResults
            // 
            this.rtbExpActualResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbExpActualResults.Location = new System.Drawing.Point(376, 236);
            this.rtbExpActualResults.Margin = new System.Windows.Forms.Padding(1);
            this.rtbExpActualResults.Name = "rtbExpActualResults";
            this.rtbExpActualResults.Size = new System.Drawing.Size(179, 273);
            this.rtbExpActualResults.TabIndex = 49;
            this.rtbExpActualResults.Text = "";
            // 
            // btnExpFirstTestCase
            // 
            this.btnExpFirstTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpFirstTestCase.FlatAppearance.BorderSize = 2;
            this.btnExpFirstTestCase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpFirstTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpFirstTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpFirstTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpFirstTestCase.Location = new System.Drawing.Point(92, 516);
            this.btnExpFirstTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpFirstTestCase.Name = "btnExpFirstTestCase";
            this.btnExpFirstTestCase.Size = new System.Drawing.Size(31, 23);
            this.btnExpFirstTestCase.TabIndex = 53;
            this.btnExpFirstTestCase.Text = "<<";
            this.btnExpFirstTestCase.UseVisualStyleBackColor = false;
            // 
            // btnExpCloseTestSession
            // 
            this.btnExpCloseTestSession.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpCloseTestSession.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExpCloseTestSession.FlatAppearance.BorderSize = 2;
            this.btnExpCloseTestSession.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpCloseTestSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpCloseTestSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpCloseTestSession.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExpCloseTestSession.Location = new System.Drawing.Point(565, 516);
            this.btnExpCloseTestSession.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpCloseTestSession.Name = "btnExpCloseTestSession";
            this.btnExpCloseTestSession.Size = new System.Drawing.Size(160, 23);
            this.btnExpCloseTestSession.TabIndex = 46;
            this.btnExpCloseTestSession.Text = "Close Test Session";
            this.btnExpCloseTestSession.UseVisualStyleBackColor = false;
            this.btnExpCloseTestSession.Click += new System.EventHandler(this.btnExpCloseTestSession_Click);
            // 
            // btnExpClearTestCase
            // 
            this.btnExpClearTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpClearTestCase.FlatAppearance.BorderSize = 2;
            this.btnExpClearTestCase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpClearTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpClearTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpClearTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpClearTestCase.Location = new System.Drawing.Point(565, 375);
            this.btnExpClearTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpClearTestCase.Name = "btnExpClearTestCase";
            this.btnExpClearTestCase.Size = new System.Drawing.Size(160, 23);
            this.btnExpClearTestCase.TabIndex = 49;
            this.btnExpClearTestCase.Text = "Clear Input Values";
            this.btnExpClearTestCase.UseVisualStyleBackColor = false;
            this.btnExpClearTestCase.Click += new System.EventHandler(this.btnExpClearTestCase_Click);
            // 
            // btnExpDeleteTestCase
            // 
            this.btnExpDeleteTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpDeleteTestCase.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExpDeleteTestCase.FlatAppearance.BorderSize = 2;
            this.btnExpDeleteTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpDeleteTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpDeleteTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpDeleteTestCase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExpDeleteTestCase.Location = new System.Drawing.Point(565, 448);
            this.btnExpDeleteTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpDeleteTestCase.Name = "btnExpDeleteTestCase";
            this.btnExpDeleteTestCase.Size = new System.Drawing.Size(160, 23);
            this.btnExpDeleteTestCase.TabIndex = 20;
            this.btnExpDeleteTestCase.Text = "Delete Testcase";
            this.btnExpDeleteTestCase.UseVisualStyleBackColor = false;
            // 
            // tbExpTestcaseResult
            // 
            this.tbExpTestcaseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExpTestcaseResult.Location = new System.Drawing.Point(659, 340);
            this.tbExpTestcaseResult.Margin = new System.Windows.Forms.Padding(1);
            this.tbExpTestcaseResult.Multiline = true;
            this.tbExpTestcaseResult.Name = "tbExpTestcaseResult";
            this.tbExpTestcaseResult.Size = new System.Drawing.Size(69, 20);
            this.tbExpTestcaseResult.TabIndex = 52;
            // 
            // lblExpTestcaseResult
            // 
            this.lblExpTestcaseResult.AutoSize = true;
            this.lblExpTestcaseResult.Location = new System.Drawing.Point(564, 343);
            this.lblExpTestcaseResult.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpTestcaseResult.Name = "lblExpTestcaseResult";
            this.lblExpTestcaseResult.Size = new System.Drawing.Size(87, 13);
            this.lblExpTestcaseResult.TabIndex = 51;
            this.lblExpTestcaseResult.Text = "Testcase Result:";
            // 
            // btnExpSaveTestCase
            // 
            this.btnExpSaveTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpSaveTestCase.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExpSaveTestCase.FlatAppearance.BorderSize = 2;
            this.btnExpSaveTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpSaveTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpSaveTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpSaveTestCase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExpSaveTestCase.Location = new System.Drawing.Point(565, 412);
            this.btnExpSaveTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpSaveTestCase.Name = "btnExpSaveTestCase";
            this.btnExpSaveTestCase.Size = new System.Drawing.Size(160, 23);
            this.btnExpSaveTestCase.TabIndex = 45;
            this.btnExpSaveTestCase.Text = "Save Testcase";
            this.btnExpSaveTestCase.UseVisualStyleBackColor = false;
            this.btnExpSaveTestCase.Click += new System.EventHandler(this.btnExpSaveTestCase_Click);
            // 
            // rtbExpExpectedResults
            // 
            this.rtbExpExpectedResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbExpExpectedResults.Location = new System.Drawing.Point(191, 236);
            this.rtbExpExpectedResults.Margin = new System.Windows.Forms.Padding(1);
            this.rtbExpExpectedResults.Name = "rtbExpExpectedResults";
            this.rtbExpExpectedResults.Size = new System.Drawing.Size(179, 272);
            this.rtbExpExpectedResults.TabIndex = 46;
            this.rtbExpExpectedResults.Text = "";
            // 
            // lblExpExpectedResults
            // 
            this.lblExpExpectedResults.AutoSize = true;
            this.lblExpExpectedResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpExpectedResults.Location = new System.Drawing.Point(189, 220);
            this.lblExpExpectedResults.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpExpectedResults.Name = "lblExpExpectedResults";
            this.lblExpExpectedResults.Size = new System.Drawing.Size(93, 13);
            this.lblExpExpectedResults.TabIndex = 45;
            this.lblExpExpectedResults.Text = "Expected Results:";
            // 
            // cmbExpSprink2
            // 
            this.cmbExpSprink2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpSprink2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpSprink2.ForeColor = System.Drawing.Color.Black;
            this.cmbExpSprink2.FormattingEnabled = true;
            this.cmbExpSprink2.Location = new System.Drawing.Point(568, 192);
            this.cmbExpSprink2.Margin = new System.Windows.Forms.Padding(1);
            this.cmbExpSprink2.Name = "cmbExpSprink2";
            this.cmbExpSprink2.Size = new System.Drawing.Size(85, 23);
            this.cmbExpSprink2.TabIndex = 44;
            // 
            // btnExpRunTestCase
            // 
            this.btnExpRunTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpRunTestCase.FlatAppearance.BorderSize = 2;
            this.btnExpRunTestCase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpRunTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpRunTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpRunTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpRunTestCase.Location = new System.Drawing.Point(565, 300);
            this.btnExpRunTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnExpRunTestCase.Name = "btnExpRunTestCase";
            this.btnExpRunTestCase.Size = new System.Drawing.Size(160, 23);
            this.btnExpRunTestCase.TabIndex = 10;
            this.btnExpRunTestCase.Text = "Run Testcase";
            this.btnExpRunTestCase.UseVisualStyleBackColor = false;
            // 
            // cmbExpSprink1
            // 
            this.cmbExpSprink1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpSprink1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpSprink1.ForeColor = System.Drawing.Color.Black;
            this.cmbExpSprink1.FormattingEnabled = true;
            this.cmbExpSprink1.ItemHeight = 15;
            this.cmbExpSprink1.Location = new System.Drawing.Point(568, 150);
            this.cmbExpSprink1.Margin = new System.Windows.Forms.Padding(1);
            this.cmbExpSprink1.Name = "cmbExpSprink1";
            this.cmbExpSprink1.Size = new System.Drawing.Size(85, 23);
            this.cmbExpSprink1.TabIndex = 43;
            // 
            // lblExpSprink2
            // 
            this.lblExpSprink2.AutoSize = true;
            this.lblExpSprink2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpSprink2.Location = new System.Drawing.Point(565, 176);
            this.lblExpSprink2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpSprink2.Name = "lblExpSprink2";
            this.lblExpSprink2.Size = new System.Drawing.Size(57, 13);
            this.lblExpSprink2.TabIndex = 42;
            this.lblExpSprink2.Text = "Sprinkler 2";
            // 
            // lblExpSprink1
            // 
            this.lblExpSprink1.AutoSize = true;
            this.lblExpSprink1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpSprink1.Location = new System.Drawing.Point(565, 133);
            this.lblExpSprink1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpSprink1.Name = "lblExpSprink1";
            this.lblExpSprink1.Size = new System.Drawing.Size(57, 13);
            this.lblExpSprink1.TabIndex = 41;
            this.lblExpSprink1.Text = "Sprinkler 1";
            // 
            // cmbExpVent4
            // 
            this.cmbExpVent4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpVent4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpVent4.ForeColor = System.Drawing.Color.Black;
            this.cmbExpVent4.FormattingEnabled = true;
            this.cmbExpVent4.Location = new System.Drawing.Point(376, 192);
            this.cmbExpVent4.Margin = new System.Windows.Forms.Padding(1);
            this.cmbExpVent4.Name = "cmbExpVent4";
            this.cmbExpVent4.Size = new System.Drawing.Size(104, 23);
            this.cmbExpVent4.TabIndex = 40;
            // 
            // cmbExpVent3
            // 
            this.cmbExpVent3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpVent3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpVent3.ForeColor = System.Drawing.Color.Black;
            this.cmbExpVent3.FormattingEnabled = true;
            this.cmbExpVent3.Location = new System.Drawing.Point(376, 148);
            this.cmbExpVent3.Margin = new System.Windows.Forms.Padding(1);
            this.cmbExpVent3.Name = "cmbExpVent3";
            this.cmbExpVent3.Size = new System.Drawing.Size(104, 23);
            this.cmbExpVent3.TabIndex = 39;
            // 
            // cmbExpVent2
            // 
            this.cmbExpVent2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpVent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpVent2.ForeColor = System.Drawing.Color.Black;
            this.cmbExpVent2.FormattingEnabled = true;
            this.cmbExpVent2.Location = new System.Drawing.Point(376, 108);
            this.cmbExpVent2.Margin = new System.Windows.Forms.Padding(1);
            this.cmbExpVent2.Name = "cmbExpVent2";
            this.cmbExpVent2.Size = new System.Drawing.Size(104, 23);
            this.cmbExpVent2.TabIndex = 38;
            // 
            // cmbExpVent1
            // 
            this.cmbExpVent1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpVent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpVent1.ForeColor = System.Drawing.Color.Black;
            this.cmbExpVent1.FormattingEnabled = true;
            this.cmbExpVent1.Location = new System.Drawing.Point(376, 64);
            this.cmbExpVent1.Margin = new System.Windows.Forms.Padding(1);
            this.cmbExpVent1.Name = "cmbExpVent1";
            this.cmbExpVent1.Size = new System.Drawing.Size(104, 23);
            this.cmbExpVent1.TabIndex = 37;
            // 
            // lblExpVent4
            // 
            this.lblExpVent4.AutoSize = true;
            this.lblExpVent4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpVent4.Location = new System.Drawing.Point(376, 176);
            this.lblExpVent4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpVent4.Name = "lblExpVent4";
            this.lblExpVent4.Size = new System.Drawing.Size(38, 13);
            this.lblExpVent4.TabIndex = 36;
            this.lblExpVent4.Text = "Vent 4";
            // 
            // lblExpVent3
            // 
            this.lblExpVent3.AutoSize = true;
            this.lblExpVent3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpVent3.Location = new System.Drawing.Point(376, 135);
            this.lblExpVent3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpVent3.Name = "lblExpVent3";
            this.lblExpVent3.Size = new System.Drawing.Size(38, 13);
            this.lblExpVent3.TabIndex = 35;
            this.lblExpVent3.Text = "Vent 3";
            // 
            // lblExpVent2
            // 
            this.lblExpVent2.AutoSize = true;
            this.lblExpVent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpVent2.Location = new System.Drawing.Point(376, 89);
            this.lblExpVent2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpVent2.Name = "lblExpVent2";
            this.lblExpVent2.Size = new System.Drawing.Size(38, 13);
            this.lblExpVent2.TabIndex = 34;
            this.lblExpVent2.Text = "Vent 2";
            // 
            // lblExpVent1
            // 
            this.lblExpVent1.AutoSize = true;
            this.lblExpVent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpVent1.Location = new System.Drawing.Point(376, 49);
            this.lblExpVent1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpVent1.Name = "lblExpVent1";
            this.lblExpVent1.Size = new System.Drawing.Size(38, 13);
            this.lblExpVent1.TabIndex = 33;
            this.lblExpVent1.Text = "Vent 1";
            // 
            // cmbExpHeater4
            // 
            this.cmbExpHeater4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpHeater4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpHeater4.ForeColor = System.Drawing.Color.Black;
            this.cmbExpHeater4.FormattingEnabled = true;
            this.cmbExpHeater4.Location = new System.Drawing.Point(191, 192);
            this.cmbExpHeater4.Margin = new System.Windows.Forms.Padding(1);
            this.cmbExpHeater4.Name = "cmbExpHeater4";
            this.cmbExpHeater4.Size = new System.Drawing.Size(85, 23);
            this.cmbExpHeater4.TabIndex = 32;
            // 
            // cmbExpHeater3
            // 
            this.cmbExpHeater3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpHeater3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpHeater3.ForeColor = System.Drawing.Color.Black;
            this.cmbExpHeater3.FormattingEnabled = true;
            this.cmbExpHeater3.Location = new System.Drawing.Point(191, 148);
            this.cmbExpHeater3.Margin = new System.Windows.Forms.Padding(1);
            this.cmbExpHeater3.Name = "cmbExpHeater3";
            this.cmbExpHeater3.Size = new System.Drawing.Size(85, 23);
            this.cmbExpHeater3.TabIndex = 31;
            // 
            // cmbExpHeater2
            // 
            this.cmbExpHeater2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpHeater2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpHeater2.ForeColor = System.Drawing.Color.Black;
            this.cmbExpHeater2.FormattingEnabled = true;
            this.cmbExpHeater2.Location = new System.Drawing.Point(191, 108);
            this.cmbExpHeater2.Margin = new System.Windows.Forms.Padding(1);
            this.cmbExpHeater2.Name = "cmbExpHeater2";
            this.cmbExpHeater2.Size = new System.Drawing.Size(85, 23);
            this.cmbExpHeater2.TabIndex = 30;
            // 
            // cmbExpHeater1
            // 
            this.cmbExpHeater1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpHeater1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpHeater1.ForeColor = System.Drawing.Color.Black;
            this.cmbExpHeater1.FormattingEnabled = true;
            this.cmbExpHeater1.Location = new System.Drawing.Point(191, 64);
            this.cmbExpHeater1.Margin = new System.Windows.Forms.Padding(1);
            this.cmbExpHeater1.Name = "cmbExpHeater1";
            this.cmbExpHeater1.Size = new System.Drawing.Size(85, 23);
            this.cmbExpHeater1.TabIndex = 29;
            // 
            // lblExpHeater4
            // 
            this.lblExpHeater4.AutoSize = true;
            this.lblExpHeater4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpHeater4.Location = new System.Drawing.Point(188, 176);
            this.lblExpHeater4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpHeater4.Name = "lblExpHeater4";
            this.lblExpHeater4.Size = new System.Drawing.Size(48, 13);
            this.lblExpHeater4.TabIndex = 28;
            this.lblExpHeater4.Text = "Heater 4";
            // 
            // lblExpHeater3
            // 
            this.lblExpHeater3.AutoSize = true;
            this.lblExpHeater3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpHeater3.Location = new System.Drawing.Point(188, 135);
            this.lblExpHeater3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpHeater3.Name = "lblExpHeater3";
            this.lblExpHeater3.Size = new System.Drawing.Size(48, 13);
            this.lblExpHeater3.TabIndex = 27;
            this.lblExpHeater3.Text = "Heater 3";
            // 
            // lblExpHeater2
            // 
            this.lblExpHeater2.AutoSize = true;
            this.lblExpHeater2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpHeater2.Location = new System.Drawing.Point(188, 89);
            this.lblExpHeater2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpHeater2.Name = "lblExpHeater2";
            this.lblExpHeater2.Size = new System.Drawing.Size(48, 13);
            this.lblExpHeater2.TabIndex = 26;
            this.lblExpHeater2.Text = "Heater 2";
            // 
            // lblExpHeater1
            // 
            this.lblExpHeater1.AutoSize = true;
            this.lblExpHeater1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpHeater1.Location = new System.Drawing.Point(188, 49);
            this.lblExpHeater1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpHeater1.Name = "lblExpHeater1";
            this.lblExpHeater1.Size = new System.Drawing.Size(48, 13);
            this.lblExpHeater1.TabIndex = 25;
            this.lblExpHeater1.Text = "Heater 1";
            // 
            // lblExpSetControlInputs
            // 
            this.lblExpSetControlInputs.AutoSize = true;
            this.lblExpSetControlInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpSetControlInputs.Location = new System.Drawing.Point(188, 25);
            this.lblExpSetControlInputs.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpSetControlInputs.Name = "lblExpSetControlInputs";
            this.lblExpSetControlInputs.Size = new System.Drawing.Size(115, 13);
            this.lblExpSetControlInputs.TabIndex = 21;
            this.lblExpSetControlInputs.Text = "Set Control Test Inputs";
            // 
            // lblExpDateOfTest
            // 
            this.lblExpDateOfTest.AutoSize = true;
            this.lblExpDateOfTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDateOfTest.Location = new System.Drawing.Point(564, 236);
            this.lblExpDateOfTest.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpDateOfTest.Name = "lblExpDateOfTest";
            this.lblExpDateOfTest.Size = new System.Drawing.Size(57, 13);
            this.lblExpDateOfTest.TabIndex = 15;
            this.lblExpDateOfTest.Text = "Test Date:";
            // 
            // dtpExpDateOfTest
            // 
            this.dtpExpDateOfTest.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpDateOfTest.CalendarForeColor = System.Drawing.Color.Blue;
            this.dtpExpDateOfTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpDateOfTest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDateOfTest.Location = new System.Drawing.Point(622, 232);
            this.dtpExpDateOfTest.Margin = new System.Windows.Forms.Padding(1);
            this.dtpExpDateOfTest.Name = "dtpExpDateOfTest";
            this.dtpExpDateOfTest.Size = new System.Drawing.Size(105, 20);
            this.dtpExpDateOfTest.TabIndex = 14;
            // 
            // numExpWindSpeedValue
            // 
            this.numExpWindSpeedValue.BackColor = System.Drawing.Color.White;
            this.numExpWindSpeedValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numExpWindSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numExpWindSpeedValue.Location = new System.Drawing.Point(105, 151);
            this.numExpWindSpeedValue.Margin = new System.Windows.Forms.Padding(1);
            this.numExpWindSpeedValue.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numExpWindSpeedValue.Name = "numExpWindSpeedValue";
            this.numExpWindSpeedValue.Size = new System.Drawing.Size(42, 21);
            this.numExpWindSpeedValue.TabIndex = 13;
            // 
            // numExpHumidValue
            // 
            this.numExpHumidValue.BackColor = System.Drawing.Color.White;
            this.numExpHumidValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numExpHumidValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numExpHumidValue.Location = new System.Drawing.Point(105, 108);
            this.numExpHumidValue.Margin = new System.Windows.Forms.Padding(1);
            this.numExpHumidValue.Name = "numExpHumidValue";
            this.numExpHumidValue.Size = new System.Drawing.Size(42, 21);
            this.numExpHumidValue.TabIndex = 12;
            // 
            // numExpTempValue
            // 
            this.numExpTempValue.BackColor = System.Drawing.Color.White;
            this.numExpTempValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numExpTempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numExpTempValue.Location = new System.Drawing.Point(105, 64);
            this.numExpTempValue.Margin = new System.Windows.Forms.Padding(1);
            this.numExpTempValue.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.numExpTempValue.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numExpTempValue.Name = "numExpTempValue";
            this.numExpTempValue.Size = new System.Drawing.Size(42, 21);
            this.numExpTempValue.TabIndex = 11;
            this.numExpTempValue.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblExpWindSpeedValue
            // 
            this.lblExpWindSpeedValue.AutoSize = true;
            this.lblExpWindSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpWindSpeedValue.Location = new System.Drawing.Point(1, 152);
            this.lblExpWindSpeedValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpWindSpeedValue.Name = "lblExpWindSpeedValue";
            this.lblExpWindSpeedValue.Size = new System.Drawing.Size(98, 13);
            this.lblExpWindSpeedValue.TabIndex = 6;
            this.lblExpWindSpeedValue.Text = "Wind Speed (mph):";
            // 
            // lblExpHumidValue
            // 
            this.lblExpHumidValue.AutoSize = true;
            this.lblExpHumidValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpHumidValue.Location = new System.Drawing.Point(1, 111);
            this.lblExpHumidValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpHumidValue.Name = "lblExpHumidValue";
            this.lblExpHumidValue.Size = new System.Drawing.Size(86, 13);
            this.lblExpHumidValue.TabIndex = 5;
            this.lblExpHumidValue.Text = "Humidity (0-100):";
            // 
            // lblExpTempValue
            // 
            this.lblExpTempValue.AutoSize = true;
            this.lblExpTempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpTempValue.Location = new System.Drawing.Point(4, 68);
            this.lblExpTempValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpTempValue.Name = "lblExpTempValue";
            this.lblExpTempValue.Size = new System.Drawing.Size(85, 13);
            this.lblExpTempValue.TabIndex = 4;
            this.lblExpTempValue.Text = "Temperature (F):";
            // 
            // lblExpSetClimateTestInputs
            // 
            this.lblExpSetClimateTestInputs.AutoSize = true;
            this.lblExpSetClimateTestInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpSetClimateTestInputs.Location = new System.Drawing.Point(4, 25);
            this.lblExpSetClimateTestInputs.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpSetClimateTestInputs.Name = "lblExpSetClimateTestInputs";
            this.lblExpSetClimateTestInputs.Size = new System.Drawing.Size(116, 13);
            this.lblExpSetClimateTestInputs.TabIndex = 3;
            this.lblExpSetClimateTestInputs.Text = "Set Climate Test Inputs";
            // 
            // lblExpExploratoryTestcaseImplementationTool
            // 
            this.lblExpExploratoryTestcaseImplementationTool.AutoSize = true;
            this.lblExpExploratoryTestcaseImplementationTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpExploratoryTestcaseImplementationTool.Location = new System.Drawing.Point(1, 1);
            this.lblExpExploratoryTestcaseImplementationTool.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblExpExploratoryTestcaseImplementationTool.Name = "lblExpExploratoryTestcaseImplementationTool";
            this.lblExpExploratoryTestcaseImplementationTool.Size = new System.Drawing.Size(237, 13);
            this.lblExpExploratoryTestcaseImplementationTool.TabIndex = 2;
            this.lblExpExploratoryTestcaseImplementationTool.Text = "Exploratory Testcase Implementation Tool (ETIT)";
            // 
            // panelMainTestPage
            // 
            this.panelMainTestPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelMainTestPage.Controls.Add(this.panelTestMethodSelection);
            this.panelMainTestPage.Controls.Add(this.pbCompanyLogo);
            this.panelMainTestPage.Location = new System.Drawing.Point(3, 4);
            this.panelMainTestPage.Margin = new System.Windows.Forms.Padding(1);
            this.panelMainTestPage.Name = "panelMainTestPage";
            this.panelMainTestPage.Size = new System.Drawing.Size(737, 546);
            this.panelMainTestPage.TabIndex = 4;
            // 
            // panelTestMethodSelection
            // 
            this.panelTestMethodSelection.AutoSize = true;
            this.panelTestMethodSelection.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelTestMethodSelection.Controls.Add(this.cmbTmPathToSQLServer);
            this.panelTestMethodSelection.Controls.Add(this.cmbTmTesterId);
            this.panelTestMethodSelection.Controls.Add(this.cmbTmEnterTesterName);
            this.panelTestMethodSelection.Controls.Add(this.rtbTMLoginStatusInfo);
            this.panelTestMethodSelection.Controls.Add(this.btnTMDeCoupleTestbed);
            this.panelTestMethodSelection.Controls.Add(this.btnTmHelp);
            this.panelTestMethodSelection.Controls.Add(this.btnTmLoadDefaultServerSettings);
            this.panelTestMethodSelection.Controls.Add(this.btnTmLogIntoTesterDataBase);
            this.panelTestMethodSelection.Controls.Add(this.lblTmPathToSQLServer);
            this.panelTestMethodSelection.Controls.Add(this.panel1);
            this.panelTestMethodSelection.Controls.Add(this.btnExitSimulator);
            this.panelTestMethodSelection.Controls.Add(this.tbTmDatabaseName);
            this.panelTestMethodSelection.Controls.Add(this.lblTmSelectedDB);
            this.panelTestMethodSelection.Controls.Add(this.cmbTmDesignation);
            this.panelTestMethodSelection.Controls.Add(this.lblTmDesignation);
            this.panelTestMethodSelection.Controls.Add(this.lblTmTesterID);
            this.panelTestMethodSelection.Controls.Add(this.lblTmEnterTesterName);
            this.panelTestMethodSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTestMethodSelection.Location = new System.Drawing.Point(0, 340);
            this.panelTestMethodSelection.Margin = new System.Windows.Forms.Padding(1);
            this.panelTestMethodSelection.Name = "panelTestMethodSelection";
            this.panelTestMethodSelection.Size = new System.Drawing.Size(737, 209);
            this.panelTestMethodSelection.TabIndex = 1;
            // 
            // cmbTmPathToSQLServer
            // 
            this.cmbTmPathToSQLServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTmPathToSQLServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTmPathToSQLServer.FormattingEnabled = true;
            this.cmbTmPathToSQLServer.Location = new System.Drawing.Point(141, 173);
            this.cmbTmPathToSQLServer.Margin = new System.Windows.Forms.Padding(1);
            this.cmbTmPathToSQLServer.Name = "cmbTmPathToSQLServer";
            this.cmbTmPathToSQLServer.Size = new System.Drawing.Size(128, 23);
            this.cmbTmPathToSQLServer.TabIndex = 22;
            // 
            // cmbTmTesterId
            // 
            this.cmbTmTesterId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTmTesterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTmTesterId.FormattingEnabled = true;
            this.cmbTmTesterId.Location = new System.Drawing.Point(141, 112);
            this.cmbTmTesterId.Margin = new System.Windows.Forms.Padding(1);
            this.cmbTmTesterId.Name = "cmbTmTesterId";
            this.cmbTmTesterId.Size = new System.Drawing.Size(128, 23);
            this.cmbTmTesterId.TabIndex = 21;
            // 
            // cmbTmEnterTesterName
            // 
            this.cmbTmEnterTesterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTmEnterTesterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTmEnterTesterName.FormattingEnabled = true;
            this.cmbTmEnterTesterName.Location = new System.Drawing.Point(141, 49);
            this.cmbTmEnterTesterName.Margin = new System.Windows.Forms.Padding(1);
            this.cmbTmEnterTesterName.Name = "cmbTmEnterTesterName";
            this.cmbTmEnterTesterName.Size = new System.Drawing.Size(128, 23);
            this.cmbTmEnterTesterName.TabIndex = 20;
            // 
            // rtbTMLoginStatusInfo
            // 
            this.rtbTMLoginStatusInfo.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTMLoginStatusInfo.Location = new System.Drawing.Point(412, 49);
            this.rtbTMLoginStatusInfo.Margin = new System.Windows.Forms.Padding(1);
            this.rtbTMLoginStatusInfo.Name = "rtbTMLoginStatusInfo";
            this.rtbTMLoginStatusInfo.Size = new System.Drawing.Size(323, 147);
            this.rtbTMLoginStatusInfo.TabIndex = 19;
            this.rtbTMLoginStatusInfo.Text = "";
            // 
            // btnTMDeCoupleTestbed
            // 
            this.btnTMDeCoupleTestbed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTMDeCoupleTestbed.Enabled = false;
            this.btnTMDeCoupleTestbed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTMDeCoupleTestbed.Location = new System.Drawing.Point(280, 112);
            this.btnTMDeCoupleTestbed.Margin = new System.Windows.Forms.Padding(1);
            this.btnTMDeCoupleTestbed.Name = "btnTMDeCoupleTestbed";
            this.btnTMDeCoupleTestbed.Size = new System.Drawing.Size(120, 23);
            this.btnTMDeCoupleTestbed.TabIndex = 18;
            this.btnTMDeCoupleTestbed.Text = "De-Couple Testbed";
            this.btnTMDeCoupleTestbed.UseVisualStyleBackColor = false;
            this.btnTMDeCoupleTestbed.Click += new System.EventHandler(this.btnTMDeCoupleTestbed_Click);
            // 
            // btnTmHelp
            // 
            this.btnTmHelp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTmHelp.FlatAppearance.BorderSize = 2;
            this.btnTmHelp.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTmHelp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTmHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTmHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTmHelp.Location = new System.Drawing.Point(280, 141);
            this.btnTmHelp.Margin = new System.Windows.Forms.Padding(1);
            this.btnTmHelp.Name = "btnTmHelp";
            this.btnTmHelp.Size = new System.Drawing.Size(120, 23);
            this.btnTmHelp.TabIndex = 17;
            this.btnTmHelp.Text = "Help";
            this.btnTmHelp.UseVisualStyleBackColor = false;
            // 
            // btnTmLoadDefaultServerSettings
            // 
            this.btnTmLoadDefaultServerSettings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTmLoadDefaultServerSettings.FlatAppearance.BorderSize = 2;
            this.btnTmLoadDefaultServerSettings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTmLoadDefaultServerSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTmLoadDefaultServerSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTmLoadDefaultServerSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTmLoadDefaultServerSettings.Location = new System.Drawing.Point(280, 49);
            this.btnTmLoadDefaultServerSettings.Margin = new System.Windows.Forms.Padding(1);
            this.btnTmLoadDefaultServerSettings.Name = "btnTmLoadDefaultServerSettings";
            this.btnTmLoadDefaultServerSettings.Size = new System.Drawing.Size(120, 23);
            this.btnTmLoadDefaultServerSettings.TabIndex = 16;
            this.btnTmLoadDefaultServerSettings.Text = "Load Default Settings";
            this.btnTmLoadDefaultServerSettings.UseVisualStyleBackColor = false;
            this.btnTmLoadDefaultServerSettings.Click += new System.EventHandler(this.btnTmLoadDefaultServerSettings_Click);
            // 
            // btnTmLogIntoTesterDataBase
            // 
            this.btnTmLogIntoTesterDataBase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTmLogIntoTesterDataBase.FlatAppearance.BorderSize = 2;
            this.btnTmLogIntoTesterDataBase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTmLogIntoTesterDataBase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTmLogIntoTesterDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTmLogIntoTesterDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTmLogIntoTesterDataBase.Location = new System.Drawing.Point(280, 80);
            this.btnTmLogIntoTesterDataBase.Margin = new System.Windows.Forms.Padding(1);
            this.btnTmLogIntoTesterDataBase.Name = "btnTmLogIntoTesterDataBase";
            this.btnTmLogIntoTesterDataBase.Size = new System.Drawing.Size(120, 23);
            this.btnTmLogIntoTesterDataBase.TabIndex = 15;
            this.btnTmLogIntoTesterDataBase.Text = "Log Into DB";
            this.btnTmLogIntoTesterDataBase.UseVisualStyleBackColor = false;
            this.btnTmLogIntoTesterDataBase.Click += new System.EventHandler(this.btnTmLogIntoTesterDataBase_Click);
            // 
            // lblTmPathToSQLServer
            // 
            this.lblTmPathToSQLServer.AutoSize = true;
            this.lblTmPathToSQLServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmPathToSQLServer.Location = new System.Drawing.Point(8, 178);
            this.lblTmPathToSQLServer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTmPathToSQLServer.Name = "lblTmPathToSQLServer";
            this.lblTmPathToSQLServer.Size = new System.Drawing.Size(106, 13);
            this.lblTmPathToSQLServer.TabIndex = 13;
            this.lblTmPathToSQLServer.Text = "Path To SQL Server:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTmSelectTheTestMethod);
            this.panel1.Controls.Add(this.rbTmExecuteFullTestPlan);
            this.panel1.Controls.Add(this.rbTmExecuteSingleTestcase);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 30);
            this.panel1.TabIndex = 12;
            // 
            // lblTmSelectTheTestMethod
            // 
            this.lblTmSelectTheTestMethod.AutoSize = true;
            this.lblTmSelectTheTestMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmSelectTheTestMethod.Location = new System.Drawing.Point(8, 8);
            this.lblTmSelectTheTestMethod.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTmSelectTheTestMethod.Name = "lblTmSelectTheTestMethod";
            this.lblTmSelectTheTestMethod.Size = new System.Drawing.Size(125, 13);
            this.lblTmSelectTheTestMethod.TabIndex = 0;
            this.lblTmSelectTheTestMethod.Text = "Select The Test Method:";
            // 
            // rbTmExecuteFullTestPlan
            // 
            this.rbTmExecuteFullTestPlan.Enabled = false;
            this.rbTmExecuteFullTestPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTmExecuteFullTestPlan.Location = new System.Drawing.Point(204, 5);
            this.rbTmExecuteFullTestPlan.Margin = new System.Windows.Forms.Padding(1);
            this.rbTmExecuteFullTestPlan.Name = "rbTmExecuteFullTestPlan";
            this.rbTmExecuteFullTestPlan.Size = new System.Drawing.Size(144, 16);
            this.rbTmExecuteFullTestPlan.TabIndex = 10;
            this.rbTmExecuteFullTestPlan.TabStop = true;
            this.rbTmExecuteFullTestPlan.Text = "Execute A Full Testplan";
            this.rbTmExecuteFullTestPlan.UseVisualStyleBackColor = true;
            this.rbTmExecuteFullTestPlan.CheckedChanged += new System.EventHandler(this.rbTmExecuteFullTestPlan_CheckedChanged);
            // 
            // rbTmExecuteSingleTestcase
            // 
            this.rbTmExecuteSingleTestcase.Enabled = false;
            this.rbTmExecuteSingleTestcase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTmExecuteSingleTestcase.Location = new System.Drawing.Point(472, 5);
            this.rbTmExecuteSingleTestcase.Margin = new System.Windows.Forms.Padding(1);
            this.rbTmExecuteSingleTestcase.Name = "rbTmExecuteSingleTestcase";
            this.rbTmExecuteSingleTestcase.Size = new System.Drawing.Size(240, 17);
            this.rbTmExecuteSingleTestcase.TabIndex = 9;
            this.rbTmExecuteSingleTestcase.TabStop = true;
            this.rbTmExecuteSingleTestcase.Text = "Execute A Single Testcase";
            this.rbTmExecuteSingleTestcase.UseVisualStyleBackColor = true;
            this.rbTmExecuteSingleTestcase.CheckedChanged += new System.EventHandler(this.rbTmExecuteSingleTestcase_CheckedChanged);
            // 
            // btnExitSimulator
            // 
            this.btnExitSimulator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExitSimulator.FlatAppearance.BorderSize = 2;
            this.btnExitSimulator.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExitSimulator.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitSimulator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitSimulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSimulator.Location = new System.Drawing.Point(280, 173);
            this.btnExitSimulator.Margin = new System.Windows.Forms.Padding(1);
            this.btnExitSimulator.Name = "btnExitSimulator";
            this.btnExitSimulator.Size = new System.Drawing.Size(120, 23);
            this.btnExitSimulator.TabIndex = 11;
            this.btnExitSimulator.Text = "Exit Simulator";
            this.btnExitSimulator.UseVisualStyleBackColor = false;
            this.btnExitSimulator.Click += new System.EventHandler(this.btnExitSimulator_Click);
            // 
            // tbTmDatabaseName
            // 
            this.tbTmDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTmDatabaseName.Location = new System.Drawing.Point(141, 143);
            this.tbTmDatabaseName.Margin = new System.Windows.Forms.Padding(1);
            this.tbTmDatabaseName.Multiline = true;
            this.tbTmDatabaseName.Name = "tbTmDatabaseName";
            this.tbTmDatabaseName.Size = new System.Drawing.Size(128, 20);
            this.tbTmDatabaseName.TabIndex = 8;
            // 
            // lblTmSelectedDB
            // 
            this.lblTmSelectedDB.AutoSize = true;
            this.lblTmSelectedDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmSelectedDB.Location = new System.Drawing.Point(8, 147);
            this.lblTmSelectedDB.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTmSelectedDB.Name = "lblTmSelectedDB";
            this.lblTmSelectedDB.Size = new System.Drawing.Size(87, 13);
            this.lblTmSelectedDB.TabIndex = 7;
            this.lblTmSelectedDB.Text = "Database Name:";
            // 
            // cmbTmDesignation
            // 
            this.cmbTmDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTmDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTmDesignation.FormattingEnabled = true;
            this.cmbTmDesignation.Location = new System.Drawing.Point(141, 79);
            this.cmbTmDesignation.Margin = new System.Windows.Forms.Padding(1);
            this.cmbTmDesignation.Name = "cmbTmDesignation";
            this.cmbTmDesignation.Size = new System.Drawing.Size(128, 23);
            this.cmbTmDesignation.TabIndex = 6;
            // 
            // lblTmDesignation
            // 
            this.lblTmDesignation.AutoSize = true;
            this.lblTmDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmDesignation.Location = new System.Drawing.Point(8, 80);
            this.lblTmDesignation.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTmDesignation.Name = "lblTmDesignation";
            this.lblTmDesignation.Size = new System.Drawing.Size(66, 13);
            this.lblTmDesignation.TabIndex = 5;
            this.lblTmDesignation.Text = "Designation:";
            // 
            // lblTmTesterID
            // 
            this.lblTmTesterID.AutoSize = true;
            this.lblTmTesterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmTesterID.Location = new System.Drawing.Point(8, 113);
            this.lblTmTesterID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTmTesterID.Name = "lblTmTesterID";
            this.lblTmTesterID.Size = new System.Drawing.Size(54, 13);
            this.lblTmTesterID.TabIndex = 3;
            this.lblTmTesterID.Text = "Tester ID:";
            // 
            // lblTmEnterTesterName
            // 
            this.lblTmEnterTesterName.AutoSize = true;
            this.lblTmEnterTesterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmEnterTesterName.Location = new System.Drawing.Point(8, 52);
            this.lblTmEnterTesterName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTmEnterTesterName.Name = "lblTmEnterTesterName";
            this.lblTmEnterTesterName.Size = new System.Drawing.Size(83, 13);
            this.lblTmEnterTesterName.TabIndex = 1;
            this.lblTmEnterTesterName.Text = "Name of Tester:";
            // 
            // pbCompanyLogo
            // 
            this.pbCompanyLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCompanyLogo.Image = global::BioDomeSimulator.Properties.Resources.GalacticCenter2;
            this.pbCompanyLogo.Location = new System.Drawing.Point(0, 1);
            this.pbCompanyLogo.Margin = new System.Windows.Forms.Padding(1);
            this.pbCompanyLogo.Name = "pbCompanyLogo";
            this.pbCompanyLogo.Size = new System.Drawing.Size(738, 339);
            this.pbCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCompanyLogo.TabIndex = 0;
            this.pbCompanyLogo.TabStop = false;
            // 
            // panelTpTestplanImplementationTool
            // 
            this.panelTpTestplanImplementationTool.AutoSize = true;
            this.panelTpTestplanImplementationTool.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelTpTestplanImplementationTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTpTestplanImplementationTool.Controls.Add(this.btnTpLoadFirstTestCase);
            this.panelTpTestplanImplementationTool.Controls.Add(this.btnTPLogDefectIncident);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTPCurrentControlValues);
            this.panelTpTestplanImplementationTool.Controls.Add(this.button1);
            this.panelTpTestplanImplementationTool.Controls.Add(this.rtbTPCurrentControlValues);
            this.panelTpTestplanImplementationTool.Controls.Add(this.cmbTPThrottleAutorunTestPace);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpThrottleAutorunTestPace);
            this.panelTpTestplanImplementationTool.Controls.Add(this.textBox1);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpClimateAndControlTestInputs);
            this.panelTpTestplanImplementationTool.Controls.Add(this.panelTpSelectTestCaseRange);
            this.panelTpTestplanImplementationTool.Controls.Add(this.panelTpSelectTestMode);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpGotoTestCase);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpGotoTestCase);
            this.panelTpTestplanImplementationTool.Controls.Add(this.btnTpPauseTestRun);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpCurrentTestcase);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpNumOfTestsInTestPlan);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpNumOfTestsInTestPlan);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpSprink2);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpSprink1);
            this.panelTpTestplanImplementationTool.Controls.Add(this.cmbTpSelectTestPlan);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpVent4);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpSelectTestPlan);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpVent3);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpVent2);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpVent1);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpHeater4);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpHeater3);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpHeater2);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpHeater1);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpWindSpeedValue);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpHumidValue);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpTempValue);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpTestCaseNumberOf);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpTestPlanImplementationTool);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpTestCaseNumberOf);
            this.panelTpTestplanImplementationTool.Controls.Add(this.btnTpNextTestCase);
            this.panelTpTestplanImplementationTool.Controls.Add(this.btnTpLastTestCase);
            this.panelTpTestplanImplementationTool.Controls.Add(this.btnTpPreviousTestCase);
            this.panelTpTestplanImplementationTool.Controls.Add(this.btnTpFirstTestCase);
            this.panelTpTestplanImplementationTool.Controls.Add(this.btnTpCloseTestSession);
            this.panelTpTestplanImplementationTool.Controls.Add(this.tbTpTestcaseResult);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpTestcaseResult);
            this.panelTpTestplanImplementationTool.Controls.Add(this.btnTpEditTestPlan);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpActualResults);
            this.panelTpTestplanImplementationTool.Controls.Add(this.rtbTpActualResults);
            this.panelTpTestplanImplementationTool.Controls.Add(this.rtbTpExpectedResults);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpExpectedResults);
            this.panelTpTestplanImplementationTool.Controls.Add(this.btnTpStartTestRun);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpSprink2);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpSprink1);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpVent4);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpVent3);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpVent2);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpVent1);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpHeater4);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpHeater3);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpHeater2);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpHeater1);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpDateOfTest);
            this.panelTpTestplanImplementationTool.Controls.Add(this.dtpTpDateOfTest);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpWindSpeedValue);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpHumidValue);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpTempValue);
            this.panelTpTestplanImplementationTool.Controls.Add(this.lblTpClimateTestInputs);
            this.panelTpTestplanImplementationTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTpTestplanImplementationTool.Location = new System.Drawing.Point(3, 4);
            this.panelTpTestplanImplementationTool.Margin = new System.Windows.Forms.Padding(1);
            this.panelTpTestplanImplementationTool.Name = "panelTpTestplanImplementationTool";
            this.panelTpTestplanImplementationTool.Size = new System.Drawing.Size(738, 547);
            this.panelTpTestplanImplementationTool.TabIndex = 4;
            // 
            // btnTpLoadFirstTestCase
            // 
            this.btnTpLoadFirstTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpLoadFirstTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTpLoadFirstTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpLoadFirstTestCase.Location = new System.Drawing.Point(599, 88);
            this.btnTpLoadFirstTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnTpLoadFirstTestCase.Name = "btnTpLoadFirstTestCase";
            this.btnTpLoadFirstTestCase.Size = new System.Drawing.Size(120, 49);
            this.btnTpLoadFirstTestCase.TabIndex = 97;
            this.btnTpLoadFirstTestCase.Text = "Load The First Testcase";
            this.btnTpLoadFirstTestCase.UseVisualStyleBackColor = false;
            // 
            // btnTPLogDefectIncident
            // 
            this.btnTPLogDefectIncident.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTPLogDefectIncident.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTPLogDefectIncident.FlatAppearance.BorderSize = 2;
            this.btnTPLogDefectIncident.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTPLogDefectIncident.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTPLogDefectIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPLogDefectIncident.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTPLogDefectIncident.Location = new System.Drawing.Point(539, 484);
            this.btnTPLogDefectIncident.Margin = new System.Windows.Forms.Padding(1);
            this.btnTPLogDefectIncident.Name = "btnTPLogDefectIncident";
            this.btnTPLogDefectIncident.Size = new System.Drawing.Size(193, 23);
            this.btnTPLogDefectIncident.TabIndex = 96;
            this.btnTPLogDefectIncident.Text = "Log Defect/Incident";
            this.btnTPLogDefectIncident.UseVisualStyleBackColor = false;
            this.btnTPLogDefectIncident.Click += new System.EventHandler(this.btnTPCreateNewTestplan_Click);
            // 
            // lblTPCurrentControlValues
            // 
            this.lblTPCurrentControlValues.AutoSize = true;
            this.lblTPCurrentControlValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPCurrentControlValues.Location = new System.Drawing.Point(4, 213);
            this.lblTPCurrentControlValues.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTPCurrentControlValues.Name = "lblTPCurrentControlValues";
            this.lblTPCurrentControlValues.Size = new System.Drawing.Size(125, 13);
            this.lblTPCurrentControlValues.TabIndex = 95;
            this.lblTPCurrentControlValues.Text = "Current Simulator Values:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(539, 419);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 94;
            this.button1.Text = "Go To Selected Testcase";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // rtbTPCurrentControlValues
            // 
            this.rtbTPCurrentControlValues.BackColor = System.Drawing.Color.White;
            this.rtbTPCurrentControlValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTPCurrentControlValues.Location = new System.Drawing.Point(4, 228);
            this.rtbTPCurrentControlValues.Margin = new System.Windows.Forms.Padding(1);
            this.rtbTPCurrentControlValues.Name = "rtbTPCurrentControlValues";
            this.rtbTPCurrentControlValues.Size = new System.Drawing.Size(173, 273);
            this.rtbTPCurrentControlValues.TabIndex = 93;
            this.rtbTPCurrentControlValues.Text = "";
            // 
            // cmbTPThrottleAutorunTestPace
            // 
            this.cmbTPThrottleAutorunTestPace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTPThrottleAutorunTestPace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTPThrottleAutorunTestPace.FormattingEnabled = true;
            this.cmbTPThrottleAutorunTestPace.Location = new System.Drawing.Point(605, 167);
            this.cmbTPThrottleAutorunTestPace.Margin = new System.Windows.Forms.Padding(1);
            this.cmbTPThrottleAutorunTestPace.Name = "cmbTPThrottleAutorunTestPace";
            this.cmbTPThrottleAutorunTestPace.Size = new System.Drawing.Size(128, 23);
            this.cmbTPThrottleAutorunTestPace.TabIndex = 90;
            // 
            // lblTpThrottleAutorunTestPace
            // 
            this.lblTpThrottleAutorunTestPace.AutoSize = true;
            this.lblTpThrottleAutorunTestPace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpThrottleAutorunTestPace.Location = new System.Drawing.Point(468, 169);
            this.lblTpThrottleAutorunTestPace.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpThrottleAutorunTestPace.Name = "lblTpThrottleAutorunTestPace";
            this.lblTpThrottleAutorunTestPace.Size = new System.Drawing.Size(138, 13);
            this.lblTpThrottleAutorunTestPace.TabIndex = 89;
            this.lblTpThrottleAutorunTestPace.Text = "Throttle Autorun Test Pace:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 88;
            // 
            // lblTpClimateAndControlTestInputs
            // 
            this.lblTpClimateAndControlTestInputs.AutoSize = true;
            this.lblTpClimateAndControlTestInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpClimateAndControlTestInputs.Location = new System.Drawing.Point(345, 57);
            this.lblTpClimateAndControlTestInputs.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpClimateAndControlTestInputs.Name = "lblTpClimateAndControlTestInputs";
            this.lblTpClimateAndControlTestInputs.Size = new System.Drawing.Size(60, 13);
            this.lblTpClimateAndControlTestInputs.TabIndex = 87;
            this.lblTpClimateAndControlTestInputs.Text = "In Testplan";
            // 
            // panelTpSelectTestCaseRange
            // 
            this.panelTpSelectTestCaseRange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTpSelectTestCaseRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTpSelectTestCaseRange.Controls.Add(this.tbTpToTestCase);
            this.panelTpSelectTestCaseRange.Controls.Add(this.lblTpToTestCase);
            this.panelTpSelectTestCaseRange.Controls.Add(this.tbTpFromTestCase);
            this.panelTpSelectTestCaseRange.Controls.Add(this.lblTpFromTestCase);
            this.panelTpSelectTestCaseRange.Controls.Add(this.lblTpSTRSelectTestCaseRange);
            this.panelTpSelectTestCaseRange.Location = new System.Drawing.Point(539, 268);
            this.panelTpSelectTestCaseRange.Margin = new System.Windows.Forms.Padding(1);
            this.panelTpSelectTestCaseRange.Name = "panelTpSelectTestCaseRange";
            this.panelTpSelectTestCaseRange.Size = new System.Drawing.Size(194, 46);
            this.panelTpSelectTestCaseRange.TabIndex = 86;
            // 
            // tbTpToTestCase
            // 
            this.tbTpToTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpToTestCase.Location = new System.Drawing.Point(121, 20);
            this.tbTpToTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpToTestCase.Multiline = true;
            this.tbTpToTestCase.Name = "tbTpToTestCase";
            this.tbTpToTestCase.Size = new System.Drawing.Size(68, 20);
            this.tbTpToTestCase.TabIndex = 81;
            // 
            // lblTpToTestCase
            // 
            this.lblTpToTestCase.AutoSize = true;
            this.lblTpToTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpToTestCase.Location = new System.Drawing.Point(104, 24);
            this.lblTpToTestCase.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpToTestCase.Name = "lblTpToTestCase";
            this.lblTpToTestCase.Size = new System.Drawing.Size(16, 13);
            this.lblTpToTestCase.TabIndex = 80;
            this.lblTpToTestCase.Text = "to";
            // 
            // tbTpFromTestCase
            // 
            this.tbTpFromTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpFromTestCase.Location = new System.Drawing.Point(35, 20);
            this.tbTpFromTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpFromTestCase.Multiline = true;
            this.tbTpFromTestCase.Name = "tbTpFromTestCase";
            this.tbTpFromTestCase.Size = new System.Drawing.Size(68, 20);
            this.tbTpFromTestCase.TabIndex = 79;
            // 
            // lblTpFromTestCase
            // 
            this.lblTpFromTestCase.AutoSize = true;
            this.lblTpFromTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpFromTestCase.Location = new System.Drawing.Point(1, 24);
            this.lblTpFromTestCase.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpFromTestCase.Name = "lblTpFromTestCase";
            this.lblTpFromTestCase.Size = new System.Drawing.Size(30, 13);
            this.lblTpFromTestCase.TabIndex = 78;
            this.lblTpFromTestCase.Text = "From";
            // 
            // lblTpSTRSelectTestCaseRange
            // 
            this.lblTpSTRSelectTestCaseRange.AutoSize = true;
            this.lblTpSTRSelectTestCaseRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpSTRSelectTestCaseRange.Location = new System.Drawing.Point(1, 1);
            this.lblTpSTRSelectTestCaseRange.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpSTRSelectTestCaseRange.Name = "lblTpSTRSelectTestCaseRange";
            this.lblTpSTRSelectTestCaseRange.Size = new System.Drawing.Size(119, 13);
            this.lblTpSTRSelectTestCaseRange.TabIndex = 77;
            this.lblTpSTRSelectTestCaseRange.Text = "Select Testcase Range";
            // 
            // panelTpSelectTestMode
            // 
            this.panelTpSelectTestMode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTpSelectTestMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTpSelectTestMode.Controls.Add(this.rbTpSTMManualTestMode);
            this.panelTpSelectTestMode.Controls.Add(this.lblTpSTMSelectTestMode);
            this.panelTpSelectTestMode.Controls.Add(this.rbTpSTMAutoTestMode);
            this.panelTpSelectTestMode.Location = new System.Drawing.Point(539, 228);
            this.panelTpSelectTestMode.Margin = new System.Windows.Forms.Padding(1);
            this.panelTpSelectTestMode.Name = "panelTpSelectTestMode";
            this.panelTpSelectTestMode.Size = new System.Drawing.Size(194, 27);
            this.panelTpSelectTestMode.TabIndex = 85;
            // 
            // rbTpSTMManualTestMode
            // 
            this.rbTpSTMManualTestMode.AutoSize = true;
            this.rbTpSTMManualTestMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTpSTMManualTestMode.Location = new System.Drawing.Point(132, 4);
            this.rbTpSTMManualTestMode.Margin = new System.Windows.Forms.Padding(1);
            this.rbTpSTMManualTestMode.Name = "rbTpSTMManualTestMode";
            this.rbTpSTMManualTestMode.Size = new System.Drawing.Size(60, 17);
            this.rbTpSTMManualTestMode.TabIndex = 75;
            this.rbTpSTMManualTestMode.TabStop = true;
            this.rbTpSTMManualTestMode.Text = "Manual";
            this.rbTpSTMManualTestMode.UseVisualStyleBackColor = true;
            // 
            // lblTpSTMSelectTestMode
            // 
            this.lblTpSTMSelectTestMode.AutoSize = true;
            this.lblTpSTMSelectTestMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpSTMSelectTestMode.Location = new System.Drawing.Point(1, 8);
            this.lblTpSTMSelectTestMode.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpSTMSelectTestMode.Name = "lblTpSTMSelectTestMode";
            this.lblTpSTMSelectTestMode.Size = new System.Drawing.Size(58, 13);
            this.lblTpSTMSelectTestMode.TabIndex = 74;
            this.lblTpSTMSelectTestMode.Text = "Test Mode";
            // 
            // rbTpSTMAutoTestMode
            // 
            this.rbTpSTMAutoTestMode.AutoSize = true;
            this.rbTpSTMAutoTestMode.Enabled = false;
            this.rbTpSTMAutoTestMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTpSTMAutoTestMode.Location = new System.Drawing.Point(72, 4);
            this.rbTpSTMAutoTestMode.Margin = new System.Windows.Forms.Padding(1);
            this.rbTpSTMAutoTestMode.Name = "rbTpSTMAutoTestMode";
            this.rbTpSTMAutoTestMode.Size = new System.Drawing.Size(62, 17);
            this.rbTpSTMAutoTestMode.TabIndex = 76;
            this.rbTpSTMAutoTestMode.TabStop = true;
            this.rbTpSTMAutoTestMode.Text = "Autorun";
            this.rbTpSTMAutoTestMode.UseVisualStyleBackColor = true;
            // 
            // tbTpGotoTestCase
            // 
            this.tbTpGotoTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpGotoTestCase.Location = new System.Drawing.Point(638, 392);
            this.tbTpGotoTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpGotoTestCase.Multiline = true;
            this.tbTpGotoTestCase.Name = "tbTpGotoTestCase";
            this.tbTpGotoTestCase.ReadOnly = true;
            this.tbTpGotoTestCase.Size = new System.Drawing.Size(95, 20);
            this.tbTpGotoTestCase.TabIndex = 84;
            this.tbTpGotoTestCase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTpGotoTestCase
            // 
            this.lblTpGotoTestCase.AutoSize = true;
            this.lblTpGotoTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpGotoTestCase.Location = new System.Drawing.Point(536, 394);
            this.lblTpGotoTestCase.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpGotoTestCase.Name = "lblTpGotoTestCase";
            this.lblTpGotoTestCase.Size = new System.Drawing.Size(87, 13);
            this.lblTpGotoTestCase.TabIndex = 83;
            this.lblTpGotoTestCase.Text = "Select Testcase:";
            // 
            // btnTpPauseTestRun
            // 
            this.btnTpPauseTestRun.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpPauseTestRun.FlatAppearance.BorderSize = 2;
            this.btnTpPauseTestRun.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpPauseTestRun.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTpPauseTestRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTpPauseTestRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpPauseTestRun.Location = new System.Drawing.Point(640, 325);
            this.btnTpPauseTestRun.Margin = new System.Windows.Forms.Padding(1);
            this.btnTpPauseTestRun.Name = "btnTpPauseTestRun";
            this.btnTpPauseTestRun.Size = new System.Drawing.Size(92, 23);
            this.btnTpPauseTestRun.TabIndex = 82;
            this.btnTpPauseTestRun.Text = "Pause Run";
            this.btnTpPauseTestRun.UseVisualStyleBackColor = false;
            // 
            // tbTpCurrentTestcase
            // 
            this.tbTpCurrentTestcase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpCurrentTestcase.ForeColor = System.Drawing.Color.Red;
            this.tbTpCurrentTestcase.Location = new System.Drawing.Point(240, 55);
            this.tbTpCurrentTestcase.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpCurrentTestcase.Multiline = true;
            this.tbTpCurrentTestcase.Name = "tbTpCurrentTestcase";
            this.tbTpCurrentTestcase.ReadOnly = true;
            this.tbTpCurrentTestcase.Size = new System.Drawing.Size(100, 20);
            this.tbTpCurrentTestcase.TabIndex = 73;
            this.tbTpCurrentTestcase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTpNumOfTestsInTestPlan
            // 
            this.lblTpNumOfTestsInTestPlan.AutoSize = true;
            this.lblTpNumOfTestsInTestPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpNumOfTestsInTestPlan.Location = new System.Drawing.Point(311, 26);
            this.lblTpNumOfTestsInTestPlan.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpNumOfTestsInTestPlan.Name = "lblTpNumOfTestsInTestPlan";
            this.lblTpNumOfTestsInTestPlan.Size = new System.Drawing.Size(126, 13);
            this.lblTpNumOfTestsInTestPlan.TabIndex = 47;
            this.lblTpNumOfTestsInTestPlan.Text = "No. Of Tests In Testplan:";
            // 
            // tbTpNumOfTestsInTestPlan
            // 
            this.tbTpNumOfTestsInTestPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpNumOfTestsInTestPlan.Location = new System.Drawing.Point(444, 24);
            this.tbTpNumOfTestsInTestPlan.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpNumOfTestsInTestPlan.Multiline = true;
            this.tbTpNumOfTestsInTestPlan.Name = "tbTpNumOfTestsInTestPlan";
            this.tbTpNumOfTestsInTestPlan.ReadOnly = true;
            this.tbTpNumOfTestsInTestPlan.Size = new System.Drawing.Size(51, 20);
            this.tbTpNumOfTestsInTestPlan.TabIndex = 48;
            this.tbTpNumOfTestsInTestPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTpSprink2
            // 
            this.tbTpSprink2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpSprink2.Location = new System.Drawing.Point(540, 119);
            this.tbTpSprink2.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpSprink2.Multiline = true;
            this.tbTpSprink2.Name = "tbTpSprink2";
            this.tbTpSprink2.Size = new System.Drawing.Size(36, 20);
            this.tbTpSprink2.TabIndex = 71;
            this.tbTpSprink2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTpSprink1
            // 
            this.tbTpSprink1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpSprink1.Location = new System.Drawing.Point(540, 88);
            this.tbTpSprink1.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpSprink1.Multiline = true;
            this.tbTpSprink1.Name = "tbTpSprink1";
            this.tbTpSprink1.Size = new System.Drawing.Size(36, 20);
            this.tbTpSprink1.TabIndex = 70;
            this.tbTpSprink1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbTpSelectTestPlan
            // 
            this.cmbTpSelectTestPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTpSelectTestPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTpSelectTestPlan.ForeColor = System.Drawing.Color.Black;
            this.cmbTpSelectTestPlan.FormattingEnabled = true;
            this.cmbTpSelectTestPlan.Location = new System.Drawing.Point(144, 23);
            this.cmbTpSelectTestPlan.Margin = new System.Windows.Forms.Padding(1);
            this.cmbTpSelectTestPlan.Name = "cmbTpSelectTestPlan";
            this.cmbTpSelectTestPlan.Size = new System.Drawing.Size(149, 23);
            this.cmbTpSelectTestPlan.TabIndex = 17;
            // 
            // tbTpVent4
            // 
            this.tbTpVent4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpVent4.Location = new System.Drawing.Point(336, 177);
            this.tbTpVent4.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpVent4.Multiline = true;
            this.tbTpVent4.Name = "tbTpVent4";
            this.tbTpVent4.Size = new System.Drawing.Size(99, 20);
            this.tbTpVent4.TabIndex = 69;
            this.tbTpVent4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTpSelectTestPlan
            // 
            this.lblTpSelectTestPlan.AutoSize = true;
            this.lblTpSelectTestPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpSelectTestPlan.Location = new System.Drawing.Point(4, 25);
            this.lblTpSelectTestPlan.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpSelectTestPlan.Name = "lblTpSelectTestPlan";
            this.lblTpSelectTestPlan.Size = new System.Drawing.Size(133, 13);
            this.lblTpSelectTestPlan.TabIndex = 16;
            this.lblTpSelectTestPlan.Text = "Select A Testplan To Run:";
            // 
            // tbTpVent3
            // 
            this.tbTpVent3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpVent3.Location = new System.Drawing.Point(336, 148);
            this.tbTpVent3.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpVent3.Multiline = true;
            this.tbTpVent3.Name = "tbTpVent3";
            this.tbTpVent3.Size = new System.Drawing.Size(99, 20);
            this.tbTpVent3.TabIndex = 68;
            this.tbTpVent3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTpVent2
            // 
            this.tbTpVent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpVent2.Location = new System.Drawing.Point(336, 119);
            this.tbTpVent2.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpVent2.Multiline = true;
            this.tbTpVent2.Name = "tbTpVent2";
            this.tbTpVent2.Size = new System.Drawing.Size(99, 20);
            this.tbTpVent2.TabIndex = 67;
            this.tbTpVent2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTpVent1
            // 
            this.tbTpVent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpVent1.Location = new System.Drawing.Point(336, 88);
            this.tbTpVent1.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpVent1.Multiline = true;
            this.tbTpVent1.Name = "tbTpVent1";
            this.tbTpVent1.Size = new System.Drawing.Size(99, 20);
            this.tbTpVent1.TabIndex = 66;
            this.tbTpVent1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTpHeater4
            // 
            this.tbTpHeater4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpHeater4.Location = new System.Drawing.Point(216, 177);
            this.tbTpHeater4.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpHeater4.Multiline = true;
            this.tbTpHeater4.Name = "tbTpHeater4";
            this.tbTpHeater4.Size = new System.Drawing.Size(36, 20);
            this.tbTpHeater4.TabIndex = 65;
            this.tbTpHeater4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTpHeater3
            // 
            this.tbTpHeater3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpHeater3.Location = new System.Drawing.Point(216, 148);
            this.tbTpHeater3.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpHeater3.Multiline = true;
            this.tbTpHeater3.Name = "tbTpHeater3";
            this.tbTpHeater3.Size = new System.Drawing.Size(36, 20);
            this.tbTpHeater3.TabIndex = 64;
            this.tbTpHeater3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTpHeater2
            // 
            this.tbTpHeater2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpHeater2.Location = new System.Drawing.Point(216, 119);
            this.tbTpHeater2.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpHeater2.Multiline = true;
            this.tbTpHeater2.Name = "tbTpHeater2";
            this.tbTpHeater2.Size = new System.Drawing.Size(36, 20);
            this.tbTpHeater2.TabIndex = 63;
            this.tbTpHeater2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTpHeater1
            // 
            this.tbTpHeater1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpHeater1.Location = new System.Drawing.Point(216, 88);
            this.tbTpHeater1.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpHeater1.Multiline = true;
            this.tbTpHeater1.Name = "tbTpHeater1";
            this.tbTpHeater1.Size = new System.Drawing.Size(36, 20);
            this.tbTpHeater1.TabIndex = 62;
            this.tbTpHeater1.Tag = " ";
            this.tbTpHeater1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTpWindSpeedValue
            // 
            this.tbTpWindSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpWindSpeedValue.Location = new System.Drawing.Point(104, 148);
            this.tbTpWindSpeedValue.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpWindSpeedValue.Multiline = true;
            this.tbTpWindSpeedValue.Name = "tbTpWindSpeedValue";
            this.tbTpWindSpeedValue.Size = new System.Drawing.Size(36, 20);
            this.tbTpWindSpeedValue.TabIndex = 61;
            this.tbTpWindSpeedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTpHumidValue
            // 
            this.tbTpHumidValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpHumidValue.Location = new System.Drawing.Point(104, 119);
            this.tbTpHumidValue.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpHumidValue.Multiline = true;
            this.tbTpHumidValue.Name = "tbTpHumidValue";
            this.tbTpHumidValue.Size = new System.Drawing.Size(36, 20);
            this.tbTpHumidValue.TabIndex = 60;
            this.tbTpHumidValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTpTempValue
            // 
            this.tbTpTempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpTempValue.Location = new System.Drawing.Point(104, 88);
            this.tbTpTempValue.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpTempValue.Multiline = true;
            this.tbTpTempValue.Name = "tbTpTempValue";
            this.tbTpTempValue.Size = new System.Drawing.Size(36, 20);
            this.tbTpTempValue.TabIndex = 59;
            this.tbTpTempValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTpTestCaseNumberOf
            // 
            this.tbTpTestCaseNumberOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpTestCaseNumberOf.ForeColor = System.Drawing.Color.Blue;
            this.tbTpTestCaseNumberOf.Location = new System.Drawing.Point(236, 518);
            this.tbTpTestCaseNumberOf.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpTestCaseNumberOf.Multiline = true;
            this.tbTpTestCaseNumberOf.Name = "tbTpTestCaseNumberOf";
            this.tbTpTestCaseNumberOf.ReadOnly = true;
            this.tbTpTestCaseNumberOf.Size = new System.Drawing.Size(115, 20);
            this.tbTpTestCaseNumberOf.TabIndex = 58;
            this.tbTpTestCaseNumberOf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTpTestPlanImplementationTool
            // 
            this.lblTpTestPlanImplementationTool.AutoSize = true;
            this.lblTpTestPlanImplementationTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpTestPlanImplementationTool.Location = new System.Drawing.Point(1, 1);
            this.lblTpTestPlanImplementationTool.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpTestPlanImplementationTool.Name = "lblTpTestPlanImplementationTool";
            this.lblTpTestPlanImplementationTool.Size = new System.Drawing.Size(179, 13);
            this.lblTpTestPlanImplementationTool.TabIndex = 49;
            this.lblTpTestPlanImplementationTool.Text = "Testplan Implementation Tool (TPIT)";
            // 
            // lblTpTestCaseNumberOf
            // 
            this.lblTpTestCaseNumberOf.AutoSize = true;
            this.lblTpTestCaseNumberOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpTestCaseNumberOf.Location = new System.Drawing.Point(180, 520);
            this.lblTpTestCaseNumberOf.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpTestCaseNumberOf.Name = "lblTpTestCaseNumberOf";
            this.lblTpTestCaseNumberOf.Size = new System.Drawing.Size(54, 13);
            this.lblTpTestCaseNumberOf.TabIndex = 57;
            this.lblTpTestCaseNumberOf.Text = "Testcase:";
            // 
            // btnTpNextTestCase
            // 
            this.btnTpNextTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpNextTestCase.FlatAppearance.BorderSize = 2;
            this.btnTpNextTestCase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpNextTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTpNextTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTpNextTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpNextTestCase.Location = new System.Drawing.Point(360, 516);
            this.btnTpNextTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnTpNextTestCase.Name = "btnTpNextTestCase";
            this.btnTpNextTestCase.Size = new System.Drawing.Size(31, 23);
            this.btnTpNextTestCase.TabIndex = 56;
            this.btnTpNextTestCase.Text = ">";
            this.btnTpNextTestCase.UseVisualStyleBackColor = false;
            // 
            // btnTpLastTestCase
            // 
            this.btnTpLastTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpLastTestCase.FlatAppearance.BorderSize = 2;
            this.btnTpLastTestCase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpLastTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTpLastTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTpLastTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpLastTestCase.Location = new System.Drawing.Point(410, 516);
            this.btnTpLastTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnTpLastTestCase.Name = "btnTpLastTestCase";
            this.btnTpLastTestCase.Size = new System.Drawing.Size(31, 23);
            this.btnTpLastTestCase.TabIndex = 55;
            this.btnTpLastTestCase.Text = ">>";
            this.btnTpLastTestCase.UseVisualStyleBackColor = false;
            // 
            // btnTpPreviousTestCase
            // 
            this.btnTpPreviousTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpPreviousTestCase.FlatAppearance.BorderSize = 2;
            this.btnTpPreviousTestCase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpPreviousTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTpPreviousTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTpPreviousTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpPreviousTestCase.Location = new System.Drawing.Point(143, 516);
            this.btnTpPreviousTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnTpPreviousTestCase.Name = "btnTpPreviousTestCase";
            this.btnTpPreviousTestCase.Size = new System.Drawing.Size(31, 23);
            this.btnTpPreviousTestCase.TabIndex = 54;
            this.btnTpPreviousTestCase.Text = "<";
            this.btnTpPreviousTestCase.UseVisualStyleBackColor = false;
            // 
            // btnTpFirstTestCase
            // 
            this.btnTpFirstTestCase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpFirstTestCase.FlatAppearance.BorderSize = 2;
            this.btnTpFirstTestCase.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpFirstTestCase.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTpFirstTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTpFirstTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpFirstTestCase.Location = new System.Drawing.Point(92, 516);
            this.btnTpFirstTestCase.Margin = new System.Windows.Forms.Padding(1);
            this.btnTpFirstTestCase.Name = "btnTpFirstTestCase";
            this.btnTpFirstTestCase.Size = new System.Drawing.Size(31, 23);
            this.btnTpFirstTestCase.TabIndex = 53;
            this.btnTpFirstTestCase.Text = "<<";
            this.btnTpFirstTestCase.UseVisualStyleBackColor = false;
            // 
            // btnTpCloseTestSession
            // 
            this.btnTpCloseTestSession.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpCloseTestSession.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTpCloseTestSession.FlatAppearance.BorderSize = 2;
            this.btnTpCloseTestSession.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpCloseTestSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTpCloseTestSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpCloseTestSession.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTpCloseTestSession.Location = new System.Drawing.Point(539, 516);
            this.btnTpCloseTestSession.Margin = new System.Windows.Forms.Padding(1);
            this.btnTpCloseTestSession.Name = "btnTpCloseTestSession";
            this.btnTpCloseTestSession.Size = new System.Drawing.Size(193, 23);
            this.btnTpCloseTestSession.TabIndex = 46;
            this.btnTpCloseTestSession.Text = "Close Test Session";
            this.btnTpCloseTestSession.UseVisualStyleBackColor = false;
            this.btnTpCloseTestSession.Click += new System.EventHandler(this.btnTpCloseTestSession_Click);
            // 
            // tbTpTestcaseResult
            // 
            this.tbTpTestcaseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpTestcaseResult.Location = new System.Drawing.Point(638, 362);
            this.tbTpTestcaseResult.Margin = new System.Windows.Forms.Padding(1);
            this.tbTpTestcaseResult.Multiline = true;
            this.tbTpTestcaseResult.Name = "tbTpTestcaseResult";
            this.tbTpTestcaseResult.ReadOnly = true;
            this.tbTpTestcaseResult.Size = new System.Drawing.Size(95, 20);
            this.tbTpTestcaseResult.TabIndex = 52;
            // 
            // lblTpTestcaseResult
            // 
            this.lblTpTestcaseResult.AutoSize = true;
            this.lblTpTestcaseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpTestcaseResult.Location = new System.Drawing.Point(539, 364);
            this.lblTpTestcaseResult.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpTestcaseResult.Name = "lblTpTestcaseResult";
            this.lblTpTestcaseResult.Size = new System.Drawing.Size(87, 13);
            this.lblTpTestcaseResult.TabIndex = 51;
            this.lblTpTestcaseResult.Text = "Testcase Result:";
            // 
            // btnTpEditTestPlan
            // 
            this.btnTpEditTestPlan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpEditTestPlan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTpEditTestPlan.FlatAppearance.BorderSize = 2;
            this.btnTpEditTestPlan.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpEditTestPlan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTpEditTestPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpEditTestPlan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTpEditTestPlan.Location = new System.Drawing.Point(539, 452);
            this.btnTpEditTestPlan.Margin = new System.Windows.Forms.Padding(1);
            this.btnTpEditTestPlan.Name = "btnTpEditTestPlan";
            this.btnTpEditTestPlan.Size = new System.Drawing.Size(193, 23);
            this.btnTpEditTestPlan.TabIndex = 45;
            this.btnTpEditTestPlan.Text = "Edit Current Testplan";
            this.btnTpEditTestPlan.UseVisualStyleBackColor = false;
            this.btnTpEditTestPlan.Click += new System.EventHandler(this.btnTpEditTestPlan_Click);
            // 
            // lblTpActualResults
            // 
            this.lblTpActualResults.AutoSize = true;
            this.lblTpActualResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpActualResults.Location = new System.Drawing.Point(360, 213);
            this.lblTpActualResults.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpActualResults.Name = "lblTpActualResults";
            this.lblTpActualResults.Size = new System.Drawing.Size(78, 13);
            this.lblTpActualResults.TabIndex = 50;
            this.lblTpActualResults.Text = "Actual Results:";
            // 
            // rtbTpActualResults
            // 
            this.rtbTpActualResults.BackColor = System.Drawing.Color.White;
            this.rtbTpActualResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTpActualResults.Location = new System.Drawing.Point(360, 228);
            this.rtbTpActualResults.Margin = new System.Windows.Forms.Padding(1);
            this.rtbTpActualResults.Name = "rtbTpActualResults";
            this.rtbTpActualResults.Size = new System.Drawing.Size(173, 273);
            this.rtbTpActualResults.TabIndex = 49;
            this.rtbTpActualResults.Text = "";
            // 
            // rtbTpExpectedResults
            // 
            this.rtbTpExpectedResults.BackColor = System.Drawing.Color.White;
            this.rtbTpExpectedResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTpExpectedResults.Location = new System.Drawing.Point(181, 228);
            this.rtbTpExpectedResults.Margin = new System.Windows.Forms.Padding(1);
            this.rtbTpExpectedResults.Name = "rtbTpExpectedResults";
            this.rtbTpExpectedResults.Size = new System.Drawing.Size(173, 273);
            this.rtbTpExpectedResults.TabIndex = 46;
            this.rtbTpExpectedResults.Text = "";
            // 
            // lblTpExpectedResults
            // 
            this.lblTpExpectedResults.AutoSize = true;
            this.lblTpExpectedResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpExpectedResults.Location = new System.Drawing.Point(183, 213);
            this.lblTpExpectedResults.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpExpectedResults.Name = "lblTpExpectedResults";
            this.lblTpExpectedResults.Size = new System.Drawing.Size(93, 13);
            this.lblTpExpectedResults.TabIndex = 45;
            this.lblTpExpectedResults.Text = "Expected Results:";
            // 
            // btnTpStartTestRun
            // 
            this.btnTpStartTestRun.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpStartTestRun.FlatAppearance.BorderSize = 2;
            this.btnTpStartTestRun.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTpStartTestRun.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTpStartTestRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTpStartTestRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpStartTestRun.Location = new System.Drawing.Point(539, 325);
            this.btnTpStartTestRun.Margin = new System.Windows.Forms.Padding(1);
            this.btnTpStartTestRun.Name = "btnTpStartTestRun";
            this.btnTpStartTestRun.Size = new System.Drawing.Size(92, 23);
            this.btnTpStartTestRun.TabIndex = 10;
            this.btnTpStartTestRun.Text = "Start Run";
            this.btnTpStartTestRun.UseVisualStyleBackColor = false;
            // 
            // lblTpSprink2
            // 
            this.lblTpSprink2.AutoSize = true;
            this.lblTpSprink2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpSprink2.Location = new System.Drawing.Point(468, 120);
            this.lblTpSprink2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpSprink2.Name = "lblTpSprink2";
            this.lblTpSprink2.Size = new System.Drawing.Size(57, 13);
            this.lblTpSprink2.TabIndex = 42;
            this.lblTpSprink2.Text = "Sprinkler 2";
            // 
            // lblTpSprink1
            // 
            this.lblTpSprink1.AutoSize = true;
            this.lblTpSprink1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpSprink1.Location = new System.Drawing.Point(468, 89);
            this.lblTpSprink1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpSprink1.Name = "lblTpSprink1";
            this.lblTpSprink1.Size = new System.Drawing.Size(57, 13);
            this.lblTpSprink1.TabIndex = 41;
            this.lblTpSprink1.Text = "Sprinkler 1";
            // 
            // lblTpVent4
            // 
            this.lblTpVent4.AutoSize = true;
            this.lblTpVent4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpVent4.Location = new System.Drawing.Point(287, 180);
            this.lblTpVent4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpVent4.Name = "lblTpVent4";
            this.lblTpVent4.Size = new System.Drawing.Size(38, 13);
            this.lblTpVent4.TabIndex = 36;
            this.lblTpVent4.Text = "Vent 4";
            // 
            // lblTpVent3
            // 
            this.lblTpVent3.AutoSize = true;
            this.lblTpVent3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpVent3.Location = new System.Drawing.Point(287, 151);
            this.lblTpVent3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpVent3.Name = "lblTpVent3";
            this.lblTpVent3.Size = new System.Drawing.Size(38, 13);
            this.lblTpVent3.TabIndex = 35;
            this.lblTpVent3.Text = "Vent 3";
            // 
            // lblTpVent2
            // 
            this.lblTpVent2.AutoSize = true;
            this.lblTpVent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpVent2.Location = new System.Drawing.Point(287, 120);
            this.lblTpVent2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpVent2.Name = "lblTpVent2";
            this.lblTpVent2.Size = new System.Drawing.Size(38, 13);
            this.lblTpVent2.TabIndex = 34;
            this.lblTpVent2.Text = "Vent 2";
            // 
            // lblTpVent1
            // 
            this.lblTpVent1.AutoSize = true;
            this.lblTpVent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpVent1.Location = new System.Drawing.Point(287, 89);
            this.lblTpVent1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpVent1.Name = "lblTpVent1";
            this.lblTpVent1.Size = new System.Drawing.Size(38, 13);
            this.lblTpVent1.TabIndex = 33;
            this.lblTpVent1.Text = "Vent 1";
            // 
            // lblTpHeater4
            // 
            this.lblTpHeater4.AutoSize = true;
            this.lblTpHeater4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpHeater4.Location = new System.Drawing.Point(160, 180);
            this.lblTpHeater4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpHeater4.Name = "lblTpHeater4";
            this.lblTpHeater4.Size = new System.Drawing.Size(48, 13);
            this.lblTpHeater4.TabIndex = 28;
            this.lblTpHeater4.Text = "Heater 4";
            // 
            // lblTpHeater3
            // 
            this.lblTpHeater3.AutoSize = true;
            this.lblTpHeater3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpHeater3.Location = new System.Drawing.Point(160, 151);
            this.lblTpHeater3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpHeater3.Name = "lblTpHeater3";
            this.lblTpHeater3.Size = new System.Drawing.Size(48, 13);
            this.lblTpHeater3.TabIndex = 27;
            this.lblTpHeater3.Text = "Heater 3";
            // 
            // lblTpHeater2
            // 
            this.lblTpHeater2.AutoSize = true;
            this.lblTpHeater2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpHeater2.Location = new System.Drawing.Point(160, 120);
            this.lblTpHeater2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpHeater2.Name = "lblTpHeater2";
            this.lblTpHeater2.Size = new System.Drawing.Size(48, 13);
            this.lblTpHeater2.TabIndex = 26;
            this.lblTpHeater2.Text = "Heater 2";
            // 
            // lblTpHeater1
            // 
            this.lblTpHeater1.AutoSize = true;
            this.lblTpHeater1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpHeater1.Location = new System.Drawing.Point(160, 89);
            this.lblTpHeater1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpHeater1.Name = "lblTpHeater1";
            this.lblTpHeater1.Size = new System.Drawing.Size(48, 13);
            this.lblTpHeater1.TabIndex = 25;
            this.lblTpHeater1.Text = "Heater 1";
            // 
            // lblTpDateOfTest
            // 
            this.lblTpDateOfTest.AutoSize = true;
            this.lblTpDateOfTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpDateOfTest.Location = new System.Drawing.Point(517, 27);
            this.lblTpDateOfTest.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpDateOfTest.Name = "lblTpDateOfTest";
            this.lblTpDateOfTest.Size = new System.Drawing.Size(57, 13);
            this.lblTpDateOfTest.TabIndex = 15;
            this.lblTpDateOfTest.Text = "Test Date:";
            // 
            // dtpTpDateOfTest
            // 
            this.dtpTpDateOfTest.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTpDateOfTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTpDateOfTest.Location = new System.Drawing.Point(580, 24);
            this.dtpTpDateOfTest.Margin = new System.Windows.Forms.Padding(1);
            this.dtpTpDateOfTest.Name = "dtpTpDateOfTest";
            this.dtpTpDateOfTest.Size = new System.Drawing.Size(141, 20);
            this.dtpTpDateOfTest.TabIndex = 14;
            // 
            // lblTpWindSpeedValue
            // 
            this.lblTpWindSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpWindSpeedValue.Location = new System.Drawing.Point(1, 151);
            this.lblTpWindSpeedValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpWindSpeedValue.Name = "lblTpWindSpeedValue";
            this.lblTpWindSpeedValue.Size = new System.Drawing.Size(105, 12);
            this.lblTpWindSpeedValue.TabIndex = 6;
            this.lblTpWindSpeedValue.Text = "Wind Speed (mph):";
            // 
            // lblTpHumidValue
            // 
            this.lblTpHumidValue.AutoSize = true;
            this.lblTpHumidValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpHumidValue.Location = new System.Drawing.Point(1, 120);
            this.lblTpHumidValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpHumidValue.Name = "lblTpHumidValue";
            this.lblTpHumidValue.Size = new System.Drawing.Size(86, 13);
            this.lblTpHumidValue.TabIndex = 5;
            this.lblTpHumidValue.Text = "Humidity (0-100):";
            // 
            // lblTpTempValue
            // 
            this.lblTpTempValue.AutoSize = true;
            this.lblTpTempValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpTempValue.Location = new System.Drawing.Point(1, 89);
            this.lblTpTempValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpTempValue.Name = "lblTpTempValue";
            this.lblTpTempValue.Size = new System.Drawing.Size(85, 13);
            this.lblTpTempValue.TabIndex = 4;
            this.lblTpTempValue.Text = "Temperature (F):";
            // 
            // lblTpClimateTestInputs
            // 
            this.lblTpClimateTestInputs.AutoSize = true;
            this.lblTpClimateTestInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpClimateTestInputs.Location = new System.Drawing.Point(1, 57);
            this.lblTpClimateTestInputs.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTpClimateTestInputs.Name = "lblTpClimateTestInputs";
            this.lblTpClimateTestInputs.Size = new System.Drawing.Size(231, 13);
            this.lblTpClimateTestInputs.TabIndex = 3;
            this.lblTpClimateTestInputs.Text = "Climate And Control Test Inputs From Testcase ";
            // 
            // panelBioControlSeperator
            // 
            this.panelBioControlSeperator.BackColor = System.Drawing.Color.Green;
            this.panelBioControlSeperator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBioControlSeperator.Location = new System.Drawing.Point(1, 348);
            this.panelBioControlSeperator.Margin = new System.Windows.Forms.Padding(1);
            this.panelBioControlSeperator.Name = "panelBioControlSeperator";
            this.panelBioControlSeperator.Size = new System.Drawing.Size(1199, 6);
            this.panelBioControlSeperator.TabIndex = 2;
            // 
            // panelBioDomeControlCover
            // 
            this.panelBioDomeControlCover.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelBioDomeControlCover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBioDomeControlCover.Controls.Add(this.pbBioDomeControlCover);
            this.panelBioDomeControlCover.Location = new System.Drawing.Point(0, 3);
            this.panelBioDomeControlCover.Margin = new System.Windows.Forms.Padding(1);
            this.panelBioDomeControlCover.Name = "panelBioDomeControlCover";
            this.panelBioDomeControlCover.Size = new System.Drawing.Size(1201, 344);
            this.panelBioDomeControlCover.TabIndex = 3;
            // 
            // pbBioDomeControlCover
            // 
            this.pbBioDomeControlCover.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbBioDomeControlCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBioDomeControlCover.Image = global::BioDomeSimulator.Properties.Resources.NewControlCover_Earth;
            this.pbBioDomeControlCover.Location = new System.Drawing.Point(0, 1);
            this.pbBioDomeControlCover.Margin = new System.Windows.Forms.Padding(1);
            this.pbBioDomeControlCover.Name = "pbBioDomeControlCover";
            this.pbBioDomeControlCover.Size = new System.Drawing.Size(1201, 342);
            this.pbBioDomeControlCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBioDomeControlCover.TabIndex = 0;
            this.pbBioDomeControlCover.TabStop = false;
            // 
            // BioDomeSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1202, 907);
            this.Controls.Add(this.panelBioControlSeperator);
            this.Controls.Add(this.panelBioDomeView);
            this.Controls.Add(this.panelBioDomeControlCover);
            this.Controls.Add(this.panelBioDomeTestBed);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(577, 372);
            this.Name = "BioDomeSimulator";
            this.Text = "Bio-Dome Climate Control Simulator";
            this.panelBioDomeView.ResumeLayout(false);
            this.panelBioResourceAvailability.ResumeLayout(false);
            this.panelBioResourceAvailability.PerformLayout();
            this.panelBioCurrentClimateValues.ResumeLayout(false);
            this.panelBioCurrentClimateValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBioCompanyLogo)).EndInit();
            this.panelCurrentSystemControl.ResumeLayout(false);
            this.panelCurrentSystemControl.PerformLayout();
            this.panelBioMoistureControlView.ResumeLayout(false);
            this.panelBioMoistureControlView.PerformLayout();
            this.panelBioVentilationControlView.ResumeLayout(false);
            this.panelBioVentilationControlView.PerformLayout();
            this.panelBioTempControlView.ResumeLayout(false);
            this.panelBioTempControlView.PerformLayout();
            this.panelBioExternalClimateControlView1_1.ResumeLayout(false);
            this.panelBioExternalClimateControlView1_1.PerformLayout();
            this.panelBioDomeTestBed.ResumeLayout(false);
            this.panelBioDomeTestBed.PerformLayout();
            this.panelBioDomeLogging.ResumeLayout(false);
            this.panelBioDomeLogging.PerformLayout();
            this.panelBioDomeLoggingCover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBioLoggingCoverTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBioLoggingCoverBottom)).EndInit();
            this.panelExpTestcaseImplementationTool.ResumeLayout(false);
            this.panelExpTestcaseImplementationTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpWindSpeedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpHumidValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpTempValue)).EndInit();
            this.panelMainTestPage.ResumeLayout(false);
            this.panelMainTestPage.PerformLayout();
            this.panelTestMethodSelection.ResumeLayout(false);
            this.panelTestMethodSelection.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyLogo)).EndInit();
            this.panelTpTestplanImplementationTool.ResumeLayout(false);
            this.panelTpTestplanImplementationTool.PerformLayout();
            this.panelTpSelectTestCaseRange.ResumeLayout(false);
            this.panelTpSelectTestCaseRange.PerformLayout();
            this.panelTpSelectTestMode.ResumeLayout(false);
            this.panelTpSelectTestMode.PerformLayout();
            this.panelBioDomeControlCover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBioDomeControlCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelBioDomeView;
        private System.Windows.Forms.Panel panelCurrentSystemControl;
        private System.Windows.Forms.Panel panelBioMoistureControlView;
        private System.Windows.Forms.Panel panelBioVentilationControlView;
        private System.Windows.Forms.Panel panelBioTempControlView;
        private System.Windows.Forms.Panel panelBioExternalClimateControlView1_1;
        public System.Windows.Forms.Panel panelBioDomeTestBed;
        private System.Windows.Forms.Panel panelExpTestcaseImplementationTool;
        private System.Windows.Forms.Label lblCurrentWindClimateView;
        private System.Windows.Forms.Label lblCurrentHumidClimateView;
        private System.Windows.Forms.Label lblBioDomeClimateView;
        private System.Windows.Forms.Label lblCurTempClimateView;
        private System.Windows.Forms.Label lblCurTempSeverity;
        private System.Windows.Forms.Label lblCurHumSeverity;
        private System.Windows.Forms.Label lblCurWindSeverity;
        private System.Windows.Forms.Label lblHeater4;
        private System.Windows.Forms.Label lblHeater3;
        private System.Windows.Forms.Label lblHeater2;
        private System.Windows.Forms.Label lblHeater1;
        private System.Windows.Forms.Label lblTemperatureControlView;
        private System.Windows.Forms.Label lblVentilationUnit4;
        private System.Windows.Forms.Label lblVentilationUnit3;
        private System.Windows.Forms.Label lblVentilationUnit2;
        private System.Windows.Forms.Label lblVentilationUnit1;
        private System.Windows.Forms.Label lblVentilationControlView;
        private System.Windows.Forms.Label lblSprinkler2;
        private System.Windows.Forms.Label lblSprinkler1;
        private System.Windows.Forms.Label lblMoistureControlView;
        private System.Windows.Forms.Label lblBioCurrentStatus;
        private System.Windows.Forms.Panel panelBioResourceAvailability;
        private System.Windows.Forms.Label lblHeatersInUse;
        private System.Windows.Forms.Label lblResourceAvailability;
        private System.Windows.Forms.Panel panelBioCurrentClimateValues;
        private System.Windows.Forms.Label lblCurWindSpeedReading;
        private System.Windows.Forms.Label lblCurHumidReading;
        private System.Windows.Forms.Label lblCurTempReading;
        private System.Windows.Forms.Label lblSprinklersInUse;
        private System.Windows.Forms.Label lblVentsInUse;
        private System.Windows.Forms.Panel panelBioDomeLogging;
        private System.Windows.Forms.Label lblExpExploratoryTestcaseImplementationTool;
        private System.Windows.Forms.Label lblExpWindSpeedValue;
        private System.Windows.Forms.Label lblExpHumidValue;
        private System.Windows.Forms.Label lblExpTempValue;
        private System.Windows.Forms.Label lblExpSetClimateTestInputs;
        private System.Windows.Forms.Label lblExpDateOfTest;
        private System.Windows.Forms.Label lblTpSelectTestPlan;
        private System.Windows.Forms.Label lblUnavailableRed;
        private System.Windows.Forms.Label lblUnavailableResources;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPartiallyAvailOrange;
        private System.Windows.Forms.Label lblPartiallyAvailableResources;
        private System.Windows.Forms.Label lblExpHeater4;
        private System.Windows.Forms.Label lblExpHeater3;
        private System.Windows.Forms.Label lblExpHeater2;
        private System.Windows.Forms.Label lblExpHeater1;
        private System.Windows.Forms.Label lblExpSetControlInputs;
        private System.Windows.Forms.Label lblExpVent4;
        private System.Windows.Forms.Label lblExpVent3;
        private System.Windows.Forms.Label lblExpVent2;
        private System.Windows.Forms.Label lblExpVent1;
        private System.Windows.Forms.Label lblExpSprink2;
        private System.Windows.Forms.Label lblExpSprink1;
        private System.Windows.Forms.Label lblTpNumOfTestsInTestPlan;
        private System.Windows.Forms.Label lblExpExpectedResults;
        private System.Windows.Forms.Label lblBioCurrentClimateValues;
        private System.Windows.Forms.Label lblExpActualResults;
        private System.Windows.Forms.Panel panelBioControlSeperator;
        private System.Windows.Forms.Label lblExpTestcaseResult;
        private System.Windows.Forms.Label lblExpTestCaseNumberOf;
        private System.Windows.Forms.Label lblTpTestPlanImplementationTool;
        private System.Windows.Forms.Panel panelTpTestplanImplementationTool;
        private System.Windows.Forms.Label lblTpTestCaseNumberOf;
        private System.Windows.Forms.Label lblTpTestcaseResult;
        private System.Windows.Forms.Label lblTpActualResults;
        private System.Windows.Forms.Label lblTpExpectedResults;
        private System.Windows.Forms.Label lblTpSprink2;
        private System.Windows.Forms.Label lblTpSprink1;
        private System.Windows.Forms.Label lblTpVent4;
        private System.Windows.Forms.Label lblTpVent3;
        private System.Windows.Forms.Label lblTpVent2;
        private System.Windows.Forms.Label lblTpVent1;
        private System.Windows.Forms.Label lblTpHeater4;
        private System.Windows.Forms.Label lblTpHeater3;
        private System.Windows.Forms.Label lblTpHeater2;
        private System.Windows.Forms.Label lblTpHeater1;
        private System.Windows.Forms.Label lblTpDateOfTest;
        private System.Windows.Forms.Label lblTpWindSpeedValue;
        private System.Windows.Forms.Label lblTpHumidValue;
        private System.Windows.Forms.Label lblTpTempValue;
        private System.Windows.Forms.Label lblTpClimateTestInputs;
        private System.Windows.Forms.Label lblTpGotoTestCase;
        private System.Windows.Forms.Label lblTpToTestCase;
        private System.Windows.Forms.Label lblTpFromTestCase;
        private System.Windows.Forms.Label lblTpSTRSelectTestCaseRange;
        private System.Windows.Forms.Label lblTpSTMSelectTestMode;
        private System.Windows.Forms.Label lblAvailableGreen;
        private System.Windows.Forms.Panel panelTpSelectTestMode;
        private System.Windows.Forms.Panel panelTpSelectTestCaseRange;
        private System.Windows.Forms.Panel panelMainTestPage;
        private System.Windows.Forms.Panel panelTestMethodSelection;
        private System.Windows.Forms.Label lblTmSelectedDB;
        private System.Windows.Forms.Label lblTmDesignation;
        private System.Windows.Forms.Label lblTmTesterID;
        private System.Windows.Forms.Label lblTmEnterTesterName;
        private System.Windows.Forms.Label lblTmSelectTheTestMethod;
        private System.Windows.Forms.Label lblBdlLoggingAndReportingTool;
        public System.Windows.Forms.Panel panelBioDomeControlCover;
        private System.Windows.Forms.Panel panelBioDomeLoggingCover;
        private System.Windows.Forms.Label lblBdlLoggingFileName;
        public System.Windows.Forms.Button btnExpRunTestCase;
        public System.Windows.Forms.NumericUpDown numExpWindSpeedValue;
        public System.Windows.Forms.NumericUpDown numExpHumidValue;
        public System.Windows.Forms.NumericUpDown numExpTempValue;
        public System.Windows.Forms.DateTimePicker dtpExpDateOfTest;
        public System.Windows.Forms.ComboBox cmbTpSelectTestPlan;
        public System.Windows.Forms.Button btnExpDeleteTestCase;
        public System.Windows.Forms.ComboBox cmbExpHeater4;
        public System.Windows.Forms.ComboBox cmbExpHeater3;
        public System.Windows.Forms.ComboBox cmbExpHeater2;
        public System.Windows.Forms.ComboBox cmbExpHeater1;
        public System.Windows.Forms.ComboBox cmbExpVent4;
        public System.Windows.Forms.ComboBox cmbExpVent3;
        public System.Windows.Forms.ComboBox cmbExpVent2;
        public System.Windows.Forms.ComboBox cmbExpVent1;
        public System.Windows.Forms.ComboBox cmbExpSprink2;
        public System.Windows.Forms.ComboBox cmbExpSprink1;
        public System.Windows.Forms.TextBox tbTpNumOfTestsInTestPlan;
        public System.Windows.Forms.Button btnExpCloseTestSession;
        public System.Windows.Forms.Button btnExpSaveTestCase;
        public System.Windows.Forms.Button btnExpClearTestCase;
        public System.Windows.Forms.RichTextBox rtbExpExpectedResults;
        public System.Windows.Forms.RichTextBox rtbExpActualResults;
        public System.Windows.Forms.TextBox tbExpTestcaseResult;
        public System.Windows.Forms.TextBox tbExpTestCaseNumberOf;
        public System.Windows.Forms.Button btnExpNextTestCase;
        public System.Windows.Forms.Button btnExpLastTestCase;
        public System.Windows.Forms.Button btnExpPreviousTestCase;
        public System.Windows.Forms.Button btnExpFirstTestCase;
        public System.Windows.Forms.TextBox tbTpTempValue;
        public System.Windows.Forms.TextBox tbTpTestCaseNumberOf;
        public System.Windows.Forms.Button btnTpNextTestCase;
        public System.Windows.Forms.Button btnTpLastTestCase;
        public System.Windows.Forms.Button btnTpPreviousTestCase;
        public System.Windows.Forms.Button btnTpFirstTestCase;
        public System.Windows.Forms.Button btnTpCloseTestSession;
        public System.Windows.Forms.TextBox tbTpTestcaseResult;
        public System.Windows.Forms.Button btnTpEditTestPlan;
        public System.Windows.Forms.RichTextBox rtbTpActualResults;
        public System.Windows.Forms.RichTextBox rtbTpExpectedResults;
        public System.Windows.Forms.Button btnTpStartTestRun;
        public System.Windows.Forms.DateTimePicker dtpTpDateOfTest;
        public System.Windows.Forms.TextBox tbTpHumidValue;
        public System.Windows.Forms.TextBox tbTpHeater3;
        public System.Windows.Forms.TextBox tbTpHeater2;
        public System.Windows.Forms.TextBox tbTpHeater1;
        public System.Windows.Forms.TextBox tbTpWindSpeedValue;
        public System.Windows.Forms.TextBox tbTpVent1;
        public System.Windows.Forms.TextBox tbTpHeater4;
        public System.Windows.Forms.TextBox tbTpSprink2;
        public System.Windows.Forms.TextBox tbTpSprink1;
        public System.Windows.Forms.TextBox tbTpVent4;
        public System.Windows.Forms.TextBox tbTpVent3;
        public System.Windows.Forms.TextBox tbTpVent2;
        public System.Windows.Forms.TextBox tbTpGotoTestCase;
        public System.Windows.Forms.Button btnTpPauseTestRun;
        public System.Windows.Forms.TextBox tbTpToTestCase;
        public System.Windows.Forms.TextBox tbTpFromTestCase;
        public System.Windows.Forms.RadioButton rbTpSTMAutoTestMode;
        public System.Windows.Forms.RadioButton rbTpSTMManualTestMode;
        public System.Windows.Forms.TextBox tbTpCurrentTestcase;
        public System.Windows.Forms.PictureBox pbCompanyLogo;
        public System.Windows.Forms.TextBox tbTmDatabaseName;
        public System.Windows.Forms.ComboBox cmbTmDesignation;
        public System.Windows.Forms.RadioButton rbTmExecuteSingleTestcase;
        public System.Windows.Forms.Button btnExitSimulator;
        public System.Windows.Forms.RadioButton rbTmExecuteFullTestPlan;
        public System.Windows.Forms.RichTextBox rtbBdlLoggingWindow;
        private System.Windows.Forms.PictureBox pbBioDomeControlCover;
        private System.Windows.Forms.PictureBox pbBioLoggingCoverTop;
        public System.Windows.Forms.TextBox tbBdlLoggingFilename;
        public System.Windows.Forms.Button btnBdlClearLoggingWindow;
        public System.Windows.Forms.Button btnBdlSaveToLogfile;
        public System.Windows.Forms.Button btnBdlPrintLogReport;
        public System.Windows.Forms.Button btnBdlPrintTestReport;
        public System.Windows.Forms.Button btnBdlCreateNewLogfile;
        private System.Windows.Forms.PictureBox pbBioCompanyLogo;
        public System.Windows.Forms.Label lblBioCurTempOptimal;
        public System.Windows.Forms.Label lblBioCurTempTooCold;
        public System.Windows.Forms.Label lblBioCurTempTooHot;
        public System.Windows.Forms.Label lblBioTempLevel3;
        public System.Windows.Forms.Label lblBioTempLevel2;
        public System.Windows.Forms.Label lblBioTempLevel1;
        public System.Windows.Forms.Label lblBioHumidLevel2;
        public System.Windows.Forms.Label lblBioHumidLevel1;
        public System.Windows.Forms.Label lblBioCurHumTooDry;
        public System.Windows.Forms.Label lblBioCurHumTooHum;
        public System.Windows.Forms.Label lblBioCurHumOptimal;
        public System.Windows.Forms.Label lblBioCurWindSpeedHigh;
        public System.Windows.Forms.Label lblBioCurWindSpeedOptimal;
        public System.Windows.Forms.Label lblBioHumidLevel3;
        public System.Windows.Forms.Label lblBioWindSpeedLevel3;
        public System.Windows.Forms.Label lblBioWindSpeedLevel2;
        public System.Windows.Forms.Label lblBioWindSpeedLevel1;
        public System.Windows.Forms.Label lblBioHeater1Off;
        public System.Windows.Forms.Label lblBioHeater1On;
        public System.Windows.Forms.Label lblBioVent1Open;
        public System.Windows.Forms.Label lblBioVent1HalfOpen;
        public System.Windows.Forms.Label lblBioVent1Closed;
        public System.Windows.Forms.Label lblBioHeater4On;
        public System.Windows.Forms.Label lblBioHeater4Off;
        public System.Windows.Forms.Label lblBioHeater3On;
        public System.Windows.Forms.Label lblBioHeater3Off;
        public System.Windows.Forms.Label lblBioHeater2On;
        public System.Windows.Forms.Label lblBioHeater2Off;
        public System.Windows.Forms.Label lblBioVent4Open;
        public System.Windows.Forms.Label lblBioVent3Open;
        public System.Windows.Forms.Label lblBioVent2Open;
        public System.Windows.Forms.Label lblBioVent4HalfOpen;
        public System.Windows.Forms.Label lblBioVent3HalfOpen;
        public System.Windows.Forms.Label lblBioVent2HalfOpen;
        public System.Windows.Forms.Label lblBioVent4Closed;
        public System.Windows.Forms.Label lblBioVent3Closed;
        public System.Windows.Forms.Label lblBioVent2Closed;
        public System.Windows.Forms.Label lblBioSprink2On;
        public System.Windows.Forms.Label lblBioSprink1On;
        public System.Windows.Forms.Label lblBioSprink2Off;
        public System.Windows.Forms.Label lblBioSprink1Off;
        public System.Windows.Forms.Button btnBioViewSystemState;
        public System.Windows.Forms.Button btnBioChangeSystemState;
        public System.Windows.Forms.Label lblBioCurrentStatusValue;
        public System.Windows.Forms.TextBox tbCurWindSpeedReading;
        public System.Windows.Forms.TextBox tbCurHumidReading;
        public System.Windows.Forms.TextBox tbCurTempReading;
        public System.Windows.Forms.Label lblHeater1InUse;
        public System.Windows.Forms.Label lblHeater4InUse;
        public System.Windows.Forms.Label lblHeater3InUse;
        public System.Windows.Forms.Label lblHeater2InUse;
        public System.Windows.Forms.Label lblSprink2InUse;
        public System.Windows.Forms.Label lblSprink1InUse;
        public System.Windows.Forms.Label lblVent4InUse;
        public System.Windows.Forms.Label lblVent3InUse;
        public System.Windows.Forms.Label lblVent2InUse;
        public System.Windows.Forms.Label lblVent1InUse;
        private System.Windows.Forms.PictureBox pbBioLoggingCoverBottom;
        public System.Windows.Forms.Button btnTmHelp;
        public System.Windows.Forms.Button btnTmLoadDefaultServerSettings;
        public System.Windows.Forms.Button btnTmLogIntoTesterDataBase;
        private System.Windows.Forms.Label lblTmPathToSQLServer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBdlLoggingWindow;
        public System.Windows.Forms.ComboBox cmbTPThrottleAutorunTestPace;
        private System.Windows.Forms.Label lblTpThrottleAutorunTestPace;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTpClimateAndControlTestInputs;
        private System.Windows.Forms.Label lblBioTimeLapsedSinceStartOfTestSession;
        private System.Windows.Forms.Label lblAvailableResource;
        private System.Windows.Forms.Button btnExpLoadNewTestcase;
        private System.Windows.Forms.Button btnTMDeCoupleTestbed;
        public System.Windows.Forms.RichTextBox rtbTMLoginStatusInfo;
        public System.Windows.Forms.Label lblExpCurrentControlValues;
        public System.Windows.Forms.RichTextBox rtbExpCurrentControlValues;
        public System.Windows.Forms.Label lblTPCurrentControlValues;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox rtbTPCurrentControlValues;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lblBioTempLevel0;
        public System.Windows.Forms.Label lblBioHumidLevel0;
        public System.Windows.Forms.Label lblBioWindSpeedLevel0;
        public System.Windows.Forms.TextBox tbBioDomeControlsInUse;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnTPLogDefectIncident;
        public System.Windows.Forms.ComboBox cmbSelectATestPlanFromTheList;
        private System.Windows.Forms.Label lblExpSelectTestPlan;
        public System.Windows.Forms.ComboBox cmbTmPathToSQLServer;
        public System.Windows.Forms.ComboBox cmbTmTesterId;
        public System.Windows.Forms.ComboBox cmbTmEnterTesterName;
        private System.Windows.Forms.Button btnOpenLoggingWindow;
        public System.Windows.Forms.Button btnExpLogDefectIncident;
        private System.Windows.Forms.Label lblControlsUsed;
        private System.Windows.Forms.Label lblControlUnitsB;
        private System.Windows.Forms.Label lblControlUnitsA;
        public System.Windows.Forms.TextBox tbTempUsedControls;
        public System.Windows.Forms.TextBox tbWindAvailControls;
        public System.Windows.Forms.TextBox tbWindUsedControls;
        public System.Windows.Forms.TextBox tbHumAvailControls;
        public System.Windows.Forms.TextBox tbHumUsedControls;
        public System.Windows.Forms.TextBox tbTempAvailControls;
        public System.Windows.Forms.Label BioDomeTestInterval;
        public System.Timers.Timer sessionTimer;
        public System.Timers.Timer autoRunThrottleTimer;
        private System.Windows.Forms.Button btnTpLoadFirstTestCase;
        public System.Windows.Forms.TextBox tbCurrentTestCaseSelected;
        private System.Windows.Forms.Label labCurrentTestCase;
    }
}

