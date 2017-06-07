using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioDomeSimulator
{
    class SqlCommandHandler
    {
        public static int updateSelected = 0;
        public static int addSelected = 0;
        public static int repeatAddRecord = 0;
        public static List<string> TestPlanList = new List<string>();
        public static string localSQLServer = "";
        public static string database = "";
        //public static String sqlPath = "Server=" + localSQLServer + ";Database=" + database + ";" 
        //                                           + "Trusted_Connection=yes;Connection Timeout=5";
        public static String sqlPath = "";
        public static DataTable dtTestPlanNames = new DataTable();
        public static DataTable dtTestPlanContents = new DataTable();
        public static int testCaseCount = 0;
        public static int listPosition = 0;
        public static int currentListPosition = 0;
        public static ArrayList test = new ArrayList();
        public static bool conToServer = false;

        //##########################################################################################################
        //##########################################################################################################

        public static void ValidateLoginDetails(BioDomeSimulator bioDome)
        {

            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Attempting to validate user's login credentials\n"
                                                                     + "   and log into the MS SQL Server.\n");
            TestTools.DisplayCurrentSystemTime(bioDome);

            int badCredentials = 0;

            string testerName = "";
            string jobType = "";
            string testerId = "";
            string dBase = "";
            string sqlSever = "";

            testerName = bioDome.cmbTmEnterTesterName.Text;
            jobType = bioDome.cmbTmDesignation.Text;
            testerId = bioDome.cmbTmTesterId.Text;
            dBase = bioDome.tbTmDatabaseName.Text;
            sqlSever = bioDome.cmbTmPathToSQLServer.Text;

            if (testerName.Equals("Eddie Gallagher") && jobType.Equals("Software Dev") &&
                testerId.Equals("SD-4554"))
            {
                ConnectToSQLServer(bioDome);
            }
            else if (testerName.Equals("Tristan Duffy") && jobType.Equals("Test Lead") &&
                testerId.Equals("TL-6221"))
            {
                ConnectToSQLServer(bioDome);
            }
            else if (testerName.Equals("Shane Rodgers") && jobType.Equals("Jr. Tester") &&
                testerId.Equals("JT-2337")) 
            {
                ConnectToSQLServer(bioDome);
            }
            else if (testerName.Equals("Guest") && jobType.Equals("Contractor") &&
                testerId.Equals("C-8888") && dBase.Equals("BioDomeTestPlans"))
            {
                ConnectToSQLServer(bioDome);
            }
            else
            {
                MessageBox.Show("Incorrect User Information has been entered.\n"
                              + "Please ensure that the:\n\n"
                              + "     Tester Name\n"
                              + "     Designation\n"
                              + "     Tester ID\n"
                              + "     and\n"
                              + "     database Name\n\n"
                              + "correspond to a legitimately stored User Profile","User Data Validation error!" );

                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "\n   The following incorrect Login credentials were entered:\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   Tester Name      = ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + testerName + "\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   Job Designation  = ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + jobType + "\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   Tester ID        = ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + testerId + "\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   Database Name    = ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + dBase + "\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   SQL Server       = ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + sqlSever + "\n\n");

                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLK, "\n   The following incorrect Login\n   credentials were entered:\n");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLK, "   Tester Name      = ");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLU, "   " + testerName + "\n");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLK, "   Job Designation  = ");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLU, "   " + jobType + "\n");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLK, "   Tester ID        = ");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLU, "   " + testerId + "\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   Database Name    = ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + dBase + "\n");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLK, "   SQL Server       = ");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLU, "   " + sqlSever + "\n\n");

                badCredentials = 1;
            }

            if (badCredentials == 0)
            {
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "\n   The following Login credentials were entered:\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   Tester Name      = ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + testerName + "\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   Job Designation  = ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + jobType + "\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   Tester ID        = ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + testerId + "\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   Database Name    = ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + dBase + "\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   SQL Server       = ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + sqlSever + "\n\n");

                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLK, "\n   The following Login credentials\n   were entered:\n");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLK, "   Tester Name      = ");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLU, "   " + testerName + "\n");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLK, "   Job Designation  = ");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLU, "   " + jobType + "\n");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLK, "   Tester ID        = ");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLU, "   " + testerId + "\n");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLK, "   Database Name    = ");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLU, "   " + dBase + "\n");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLK, "   SQL Server       = ");
                bioDome.Append(bioDome.rtbTMLoginStatusInfo, Constants.BLU, "   " + sqlSever + "\n\n");
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        public static void ConnectToSQLServer(BioDomeSimulator bioDome)
        {
            localSQLServer = bioDome.cmbTmPathToSQLServer.Text;
            database = bioDome.tbTmDatabaseName.Text;
            sqlPath = "Server=" + localSQLServer + ";Database=" + database + ";Trusted_Connection=yes;Connection Timeout=3";

            Console.WriteLine("localSQLServer = " + localSQLServer);
            Console.WriteLine("database = " + database);
            Console.WriteLine("path = " + sqlPath);

 
            // Try to connect to the MS SQL server and retrieve all Bio-Dome testplans
            GetListOfTestPlans(bioDome);

            // If GetListOfTestPlans is successful, access to the server has been established...
            if  (conToServer) 
            {
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "\n   ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "MS SQL Server connection successful!\n");
                bioDome.rbTmExecuteSingleTestcase.Enabled = true;
                bioDome.rbTmExecuteFullTestPlan.Enabled = true;
            }
            else 
            {
                // If GetListOfTestPlans is successful, access to the server has been established...
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "\n   ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "Insuccessful MS SQL Server connection atempt!\n");
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        // Searches the BioDomeTestPlans database for all test plans and then
        // loads the Testplan Selection combobox with the result
        public static void GetListOfTestPlans(BioDomeSimulator bioDome)
        {
            // Clear all previous data from the combo-boxes, data table and Testplan list 
            bioDome.cmbTpSelectTestPlan.Items.Clear();
            bioDome.cmbSelectATestPlanFromTheList.Items.Clear();
            TestPlanList.Clear();
            dtTestPlanNames.Clear();

            // Get a list of Test Plans in the BioDomeTestPlans database
            RunSQLCommand("SELECT name FROM sys.Tables", 2);

            foreach (DataRow dr in dtTestPlanNames.Rows)
            {
                TestPlanList.Add(dr[0].ToString());
            }

            // Place a select testplan option at the first entry to the combo-boxes
            bioDome.cmbTpSelectTestPlan.Items.Add("Select Testplan...");
            bioDome.cmbSelectATestPlanFromTheList.Items.Add("Select Testplan...");

            for (int i = 0; i < TestPlanList.Count; i++)
            {
                // Populat the combo-boxes with the testplans obtained
                bioDome.cmbTpSelectTestPlan.Items.Add(TestPlanList[i]);
                bioDome.cmbSelectATestPlanFromTheList.Items.Add(TestPlanList[i]);
            }

            bioDome.cmbTpSelectTestPlan.SelectedIndex = 0;
            bioDome.cmbSelectATestPlanFromTheList.SelectedIndex = 0;
        }

        //##########################################################################################################
        //##########################################################################################################

        // Loads the specified Holiday record into the text boxes in the main form
        public static void LoadTestcaseRecord(BioDomeSimulator bioDome, int recordNum)
        {
            TestTools.expTCNumber = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][0].ToString();
            TestTools.testTValue = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][1].ToString();
            TestTools.testTStatus = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][2].ToString();
            TestTools.testTSeverity = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][3].ToString();
            TestTools.testHValue = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][4].ToString();
            TestTools.testHStatus = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][5].ToString();
            TestTools.testHSeverity = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][6].ToString();
            TestTools.testWValue = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][7].ToString();
            TestTools.testWStatus = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][8].ToString();
            TestTools.testWSeverity = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][9].ToString();
            TestTools.testHeat1 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][10].ToString();
            TestTools.testHeat2 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][11].ToString();
            TestTools.testHeat3 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][12].ToString();
            TestTools.testHeat4 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][13].ToString();
            TestTools.testVent1 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][14].ToString();
            TestTools.testVent2 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][15].ToString();
            TestTools.testVent3 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][16].ToString();
            TestTools.testVent4 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][17].ToString();
            TestTools.testSprink1 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][18].ToString();
            TestTools.testSprink2 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][19].ToString();
            TestTools.expTStatus = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][20].ToString();
            TestTools.expTSeverity = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][21].ToString();
            TestTools.expHStatus = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][22].ToString();
            TestTools.expHSeverity = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][23].ToString();
            TestTools.expWStatus = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][24].ToString();
            TestTools.expWSeverity = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][25].ToString();
            TestTools.expHeat1 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][26].ToString();
            TestTools.expHeat2 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][27].ToString();
            TestTools.expHeat3 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][28].ToString();
            TestTools.expHeat4 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][29].ToString();
            TestTools.expVent1 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][30].ToString();
            TestTools.expVent2 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][31].ToString();
            TestTools.expVent3 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][32].ToString();
            TestTools.expVent4 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][33].ToString();
            TestTools.expSprink1 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][34].ToString();
            TestTools.expSprink2 = SqlCommandHandler.dtTestPlanContents.Rows[recordNum][35].ToString();

            TestTools.expectedList.Add(TestTools.testTValue);
            TestTools.expectedList.Add(TestTools.expTStatus);
            TestTools.expectedList.Add(TestTools.expTSeverity);
            TestTools.expectedList.Add(TestTools.testHValue);
            TestTools.expectedList.Add(TestTools.expHStatus);
            TestTools.expectedList.Add(TestTools.expHSeverity);
            TestTools.expectedList.Add(TestTools.testWValue);
            TestTools.expectedList.Add(TestTools.expWStatus);
            TestTools.expectedList.Add(TestTools.expWSeverity);
            TestTools.expectedList.Add(TestTools.expHeat1);
            TestTools.expectedList.Add(TestTools.expHeat2);
            TestTools.expectedList.Add(TestTools.expHeat3);
            TestTools.expectedList.Add(TestTools.expHeat4);
            TestTools.expectedList.Add(TestTools.expVent1);
            TestTools.expectedList.Add(TestTools.expVent2);
            TestTools.expectedList.Add(TestTools.expVent3);
            TestTools.expectedList.Add(TestTools.expVent4);
            TestTools.expectedList.Add(TestTools.expSprink1);
            TestTools.expectedList.Add(TestTools.expSprink2);
        }

        //##########################################################################################################
        //##########################################################################################################



        //##########################################################################################################
        //##########################################################################################################



        //##########################################################################################################
        //##########################################################################################################



        //##########################################################################################################
        //##########################################################################################################

        // Adds a new Holiday record to the database
        /*public static void AddTestCaseRecord(string testPlan)
        {
            addSelected = 1;
            frmHolidayControls.HolidayErrorList.Clear();
            frmHolidayControls.CheckForValidHolidayInputs();
            String errorList = frmHolidayControls.HolidayErrorList.ToString();
            //frmHolidayControls.FormatDateData();
            if (frmHolidayControls.HolidayErrorList.Length == 0)
            {
                //frmHolidayControls.FormatDateData();
                // Configure the SQL INSERT command 
                RunSQLCommand("INSERT INTO " + testPlan + "(HolidayNo, Destination, Cost, DepartureDate, NoOfDays, Available) VALUES (@HolidayNo, @Destination, @Cost, @DepartureDate, @NoOfDays, @Available)", 2);

                // Release all disabled buttons
                frmHolidayControls.ReleaseFormControls();
                // Enable Holiday input textboxes for data entry
                frmHolidayControls.DisableHolidayInputControls();
                // Enable the Update button
                frmHoliday.btnUpdate.Enabled = true;
                // Get the most current list of all Holiday registration numbers and sort in ascending order
                RefreshDataTable();
                // set the total number of Holiday records
                GetNumberOfRecords();
                // Set the Holiday list positioning variable to the last Holiday record
                listPosition = recordCount;
                frmHoliday.tbIndexList.Text = listPosition + " of " + recordCount;
                //listPosition--;
                // Load the last Holiday record
                frmHolidayControls.LoadHolidayRecord(SqlCommandHandler.recordCount - 1);
                // Set the Holiday list positioning variable to the last Holiday record
                SqlCommandHandler.listPosition = SqlCommandHandler.recordCount - 1;
                frmHoliday.btnAdd.Text = "Add";
                repeatAddRecord = 0;
            }
            else
            {
                MessageBox.Show("The following formatting errors were found while trying to ADD a new Holiday Record!\n\n" + errorList, "Record ADDITION formatting error(s) detected!");
                //frmHolidayControls.RefreshDataFields();
                repeatAddRecord = 1;
                //frmHolidayControls.InitializeForNewRecord();
                //frmHoliday.tbHolidayNumber.Focus();
                frmHolidayControls.FindHolidayInputFocus();
            }
        }*/

        //##################################################################

        // First clears the current data table contents and then refreshes
        // the data table with the most current representation of 
        // the contents of the StudentInfo table

        public static void RefreshDataTable(string testPlan)
        {
            //dt.Clear();
            // Refresh the data table after an Update, Record Addition or Deletion
            //RunSQLCommand("SELECT * FROM tblHoliday ORDER BY Make ASC", 3);
            RunSQLCommand("SELECT * FROM " + testPlan, 3);
        }

        //##################################################################

        public static void GetNumberOfRecords(string testPlan)
        {
            RunSQLCommand("SELECT COUNT(*) FROM " + testPlan, 1);
        }

        //##################################################################
        // Parses the SQL command passed to the method

        public static void RunSQLCommand(String command, int key)
        {
            BioDomeSimulator bioDome = new BioDomeSimulator();
            try
            {
                SqlConnection con = new SqlConnection(@sqlPath);
                SqlCommand cmd = new SqlCommand(command);

                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                con.Open();

                // Key determines the type of SQL command is run: 
                // ExecuteReader, ExecuteScalar or ExecuteNonQuery
                switch (key)
                {
                    case 1:
                        // Get the number of unique test cases in the table
                        testCaseCount = (Int32)cmd.ExecuteScalar();
                        break;
                    //case 2:
                    /* try
                     {
                         // Insert a new Holiday Record
                         cmd.Parameters.AddWithValue("@HolidayNo", frmHoliday.tbHolidayNumber.Text);
                         cmd.Parameters.AddWithValue("@Destination", frmHoliday.tbDestination.Text);
                         if (updateSelected > 0)
                         {
                             cmd.Parameters.AddWithValue("@Cost", symbolFreeHolidayPrice);
                         }
                         else
                         {
                             cmd.Parameters.AddWithValue("@Cost", frmHoliday.tbCost.Text);
                         }
                         cmd.Parameters.AddWithValue("@DepartureDate", date);
                         cmd.Parameters.AddWithValue("@NoOfDays", frmHoliday.tbNoOfDays.Text);
                         cmd.Parameters.AddWithValue("@Available", frmHoliday.cbAvailable.Checked);
                         cmd.ExecuteNonQuery();
                         updateSelected = 0;
                     }
                     catch (Exception e)
                     {
                         MessageBox.Show(e.ToString(), "Catch in RunSQLCommand() case 2");
                     } */
                    //break;
                    case 2:
                        // Create a new adapter to handle the data table
                        SqlDataAdapter daTestPlanNames = new SqlDataAdapter(cmd);
                        // Using the sql adapter load the datatable
                        daTestPlanNames.Fill(dtTestPlanNames);
                        // On completion dispose of the adapter 
                        daTestPlanNames.Dispose();

                        // Allow access to the Single Testcase and Full Testplan testing suites.
                        conToServer = true;
                        break;
                    case 3:
                        // Create a new adapter to handle the data table
                        SqlDataAdapter daTestPlanContents = new SqlDataAdapter(cmd);
                        // Using the sql adapter load the datatable
                        daTestPlanContents.Fill(dtTestPlanContents);
                        // On completion dispose of the adapter 
                        daTestPlanContents.Dispose();
                        break;
                    case 4:
                        cmd.ExecuteNonQuery();
                        break;
                    case 5:
                        /*if (cmd.ExecuteScalar() == null)
                        {
                            duplicateHolidayNo = "";
                        }
                        else
                        {
                            duplicateHolidayNo = cmd.ExecuteScalar().ToString();
                        }*/
                        break;
                }
                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("An Error has occured while trying to connect\nto the SQL Server.\n\n" 
                              + "Either\n\n        1. An incorrect MS SQL Server option was selected.\n"
                              + "Or\n\n        2. The database 'BioDomeTestPlans does not exist"
                               , "Local MS SQL Server not available");
                conToServer = false;
            }
        }

    }
}
