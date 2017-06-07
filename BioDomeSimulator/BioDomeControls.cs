using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioDomeSimulator
{
    class BioDomeControls
    {
        // Generate Bio-Dome System Control and Atmospheric Status Indicator Objects

        public static ClimateVariables temperatureStateIndicator = new ClimateVariables("Temperature");
        public static ClimateVariables humidityStateIndicator = new ClimateVariables("Humidity");
        public static ClimateVariables windSpeedStateIndicator = new ClimateVariables("Wind Speed");

        public static ClimateSeverityIndicator temperatureSeverityIndicator = new ClimateSeverityIndicator("Temperature");
        public static ClimateSeverityIndicator humiditySeverityIndicator = new ClimateSeverityIndicator("Humidity");
        public static ClimateSeverityIndicator windSpeedSeverityIndicator = new ClimateSeverityIndicator("Wind Speed");

        public static ControlUnit vent1 = new ControlUnit("Vent Unit 1 - Zone 1");
        public static ControlUnit vent2 = new ControlUnit("Vent Unit 2 - Zone 1");
        public static ControlUnit vent3 = new ControlUnit("Vent Unit 3 - Zone 2");
        public static ControlUnit vent4 = new ControlUnit("Vent Unit 4 - Zone 2");

        public static ControlUnit heat1 = new ControlUnit("Heater Unit 1 - Zone 1");
        public static ControlUnit heat2 = new ControlUnit("Heater Unit 2 - Zone 1");
        public static ControlUnit heat3 = new ControlUnit("Heater Unit 3 - Zone 2");
        public static ControlUnit heat4 = new ControlUnit("Heater Unit 4 - Zone 2");

        public static ControlUnit sprink1 = new ControlUnit("Spinkler Unit 1 - Zone 1");
        public static ControlUnit sprink2 = new ControlUnit("Spinkler Unit 2 - Zone 2");

        public static ControlUnit[] bioDomeControlUnits = new ControlUnit[10];

        //##########################################################################################################

        // User inputted values for current temperature, humidity and wind speed
        public static int currentTemperatureValue = 0;
        public static int currentHumidityValue = 0;
        public static int currentWindSpeedValue = 0;

        //##########################################################################################################

        public static Int32 seconds = 0;
        public static Int32 minutes = 0;
        public static Int32 hours = 0;

        //##########################################################################################################


        //##########################################################################################################


        // Create an ArrayList to hold the System Controls 
        // for The Bio-Dome Simulator Tool

        public void LoadBioDomeObjectsArray()
        {
            List<String> bioDomeControlNameList = new List<String>
            {
                "Vent Unit 1 - Zone 1", "Vent Unit 2 - Zone 1",
                "Vent Unit 3 - Zone 2", "Vent Unit 4 - Zone 2",
                "Heater Unit 1 - Zone 1", "Heater Unit 2 - Zone 1",
                "Heater Unit 3 - Zone 2", "Heater Unit 4 - Zone 2",
                "Spinkler Unit 1 - Zone 1", "Spinkler Unit 2 - Zone 2"
            };

            // Populate the BioDomeControlUnits Array with objects 
            // of type ControlUnit and name each control unit
            for (int i = 0; i < bioDomeControlUnits.Count(); i++)
            {
                bioDomeControlUnits[i] = new ControlUnit(bioDomeControlNameList[i]);
            }
        }

        //##########################################################################################################

        // Method sets the Initial state for all the Bio-Dome control units
        // and atmospheric state indicators to either 'Closed, 'On, 'Off' or 'Optimal'

        public void SetInitialControlStates()
        {
            temperatureStateIndicator.SetState("Optimal");
            humidityStateIndicator.SetState("Optimal");
            windSpeedStateIndicator.SetState("Optimal");

            temperatureSeverityIndicator.SetState("Level 0");
            humiditySeverityIndicator.SetState("Level 0");
            windSpeedSeverityIndicator.SetState("Level 0");

            vent1.SetState("Closed");
            vent2.SetState("Closed");
            vent3.SetState("Closed");
            vent4.SetState("Closed");

            heat1.SetState("On");
            heat2.SetState("On");
            heat3.SetState("On");
            heat4.SetState("On");

            sprink1.SetState("Off");
            sprink2.SetState("Off");

            // Set the state of all the Bio-Dome objects
            LoadBioDomeObjectsArray();
        }

        //##########################################################################################################

        // Method sets the Shut-Down state for all the Bio-Dome control units
        // and atmospheric state indicators to 'Undefined'

        public void SetShutDownControlStates()
        {
            BioDomeSimulator bioDome = new BioDomeSimulator();

            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Displaying the BioDome Control State Details!\n");
            TestTools.DisplayCurrentSystemTime(bioDome);

            temperatureStateIndicator.SetState("Null");
            humidityStateIndicator.SetState("Null");
            windSpeedStateIndicator.SetState("Null");

            temperatureSeverityIndicator.SetState("Null");
            humiditySeverityIndicator.SetState("Null");
            windSpeedSeverityIndicator.SetState("Null");

            vent1.SetState("Null");
            vent2.SetState("Null");
            vent3.SetState("Null");
            vent4.SetState("Null");

            heat1.SetState("Null");
            heat2.SetState("Null");
            heat3.SetState("Null");
            heat4.SetState("Null");

            sprink1.SetState("Null");
            sprink2.SetState("Null");

            // Set the state of all the Bio-Dome objects
            LoadBioDomeObjectsArray();
        }

        //##########################################################################################################
        // Method displays the current state of all the Bio-Domw controls
        // using the toString method

        public void DisplayBioDomeControlDetails(BioDomeSimulator bioDome)
        {
            String name = "";
            String state = "";
            String color = "";

            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Displaying the BioDome Control State Details!\n");
            TestTools.DisplayCurrentSystemTime(bioDome);

            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, Constants.FULL_STATE_DISPLAY_BANNER_TOP);

            name = temperatureStateIndicator.GetName();
            state = temperatureStateIndicator.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ": Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            name = humidityStateIndicator.GetName();
            state = humidityStateIndicator.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ":    Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            name = windSpeedStateIndicator.GetName();
            state = windSpeedStateIndicator.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ":  Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "\n");

            name = temperatureSeverityIndicator.GetName();
            state = temperatureSeverityIndicator.GetState();
            color = GetStateColor(state); 
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ": Simulator Load Stress -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            name = humiditySeverityIndicator.GetName();
            state = humiditySeverityIndicator.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ":    Simulator Load Stress -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            name = windSpeedSeverityIndicator.GetName();
            state = windSpeedSeverityIndicator.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ":  Simulator Load Stress -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "\n");

            name = heat1.GetName();
            state = heat1.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ": Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            name = heat2.GetName();
            state = heat2.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ": Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            name = heat3.GetName();
            state = heat3.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ": Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            name = heat4.GetName();
            state = heat4.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ": Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "\n");

            name = vent1.GetName();
            state = vent1.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ": Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            name = vent2.GetName();
            state = vent2.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ": Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            name = vent3.GetName();
            state = vent3.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ": Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            name = vent4.GetName();
            state = vent4.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ": Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, "\n");

            name = sprink1.GetName();
            state = sprink1.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ": Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            name = sprink2.GetName();
            state = sprink2.GetState();
            color = GetStateColor(state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   " + name);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, ": Current State -> [ ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, color, state);
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, " ]\n");

            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, Constants.FULL_STATE_DISPLAY_BANNER_BOT);
        }

        //##########################################################################################################
        // Method sets the color and background of the given control based on its state
        public String GetStateColor(String state)
        {
            String color = "";
            switch (state)
            {
                case "Optimal":
                case "Closed":
                case "Off":
                case "Level 0":
                    color = Constants.LIGREBLK;
                    break;
                case "Open":
                case "On":
                case "Null":
                case "Level 3":
                    color = Constants.REDBLK;
                    break;
                case "Half-Open":
                case "Level 2":
                    color = Constants.ORGBLK;
                    break;
                case "Level 1":
                    color = Constants.YELBLK;
                    break;
            }

            return color;
        }

        //##########################################################################################################
        // Method sets the initial color for all controls in their Off-Line State
        public void SetBioDomeOffLineState(BioDomeSimulator bioDome)
        {
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Setting the BioDome Off-Line State!\n");
            TestTools.DisplayCurrentSystemTime(bioDome);

            Constants.initialTemperature = 0;
            Constants.initialHumidity = 0;
            Constants.minimumWindSpeed = 0;

            if (Constants.SystemState == 1)
            {
                bioDome.lblBioCurrentStatusValue.Text = "Off-line";
                bioDome.lblBioCurrentStatusValue.BackColor = Color.Red;

                SetShutDownControlStates();

                for (int i = 0; i < BioDomeSimulator.fullBioDomeControlList.Count(); i++)
                {
                    BioDomeSimulator.fullBioDomeControlList[i].BackColor = SystemColors.Control;
                }

                bioDome.tbCurTempReading.Text = "";
                bioDome.tbCurHumidReading.Text = "";
                bioDome.tbCurWindSpeedReading.Text = "";

                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "\n\n   ***************************************************\n\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   The System has been ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "deactivated\n\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   All controls are now off-line and the\n"
                            + "   current system status value is ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "OFF\n\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   ***************************************************\n");

                Constants.SystemState = 0;
            }
        }

        //##########################################################################################################
        // Method sets the initial color for all controls in their On-Line State
        public void SetInitialBioDomeOnDisplay(BioDomeSimulator bioDome)
        {
            Constants.initialTemperature = 67;
            Constants.initialHumidity = 55;
            Constants.minimumWindSpeed = 3;

            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Setting the initial BioDome On-Display!\n");
            TestTools.DisplayCurrentSystemTime(bioDome);

            if (Constants.SystemState == 0)
            {
                 for (int i = 0; i < 3; i++)
                 {
                     BioDomeSimulator.bioClimateControlList[i].BackColor = Color.Lime;
                 }

                 for (int i = 3; i < 8; i++)
                 {
                     BioDomeSimulator.bioClimateControlList[i].BackColor = Color.LightGray;
                 }

                for (int i = 0; i < 3; i++)
                {
                    BioDomeSimulator.bioClimateSeverityList[i].BackColor = Color.Lime;
                }

                for (int i = 3; i < 12 ; i++)
                {
                    BioDomeSimulator.bioClimateSeverityList[i].BackColor = Color.LightGray;
                }

                for (int i = 0; i < 4; i++)
                 {
                     BioDomeSimulator.bioVentList[i].BackColor = Color.Lime;
                 }

                 for (int i = 4; i < 12; i++)
                 {
                     BioDomeSimulator.bioVentList[i].BackColor = Color.LightGray;
                 }

                 for (int i = 0; i < 4; i++)
                 {
                     BioDomeSimulator.bioHeaterList[i].BackColor = Color.Lime;
                }

                 for (int i = 4; i < 8; i++)
                 {
                     BioDomeSimulator.bioHeaterList[i].BackColor = Color.LightGray;
                }

                for (int i = 0; i < 2; i++)
                {
                    BioDomeSimulator.bioSprinklerList[i].BackColor = Color.Lime;
                }

                 for (int i = 2; i < 4; i++)
                 {
                     BioDomeSimulator.bioSprinklerList[i].BackColor = Color.LightGray;
                 }

                 for (int i = 0; i < 10; i++)
                 {
                     BioDomeSimulator.bioControlsInUseList[i].BackColor = Color.Lime;
                 }

                bioDome.tbBioDomeControlsInUse.Text = "";
                bioDome.tbBioDomeControlsInUse.Text = TestTools.inUseCounter.ToString();

                //Append(Constants.BLK, Constants.SYSTEM_TURNED_ON);

                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "\n\n   ***************************************************\n\n"
                                   + "   The System has been ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "activated\n\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   All controls are now ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "on-line ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "and the\n   current system status value is ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "ON");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLKWHT, "\n   All controls are either ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "Closed");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " or ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.RED, "Off\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   and external climate values are set to\n"
                          + "   within their Optimal Ranges.\n\n"
                          + "   ***************************************************\n\n");
                bioDome.lblBioCurrentStatusValue.Text = "On-line";
                bioDome.lblBioCurrentStatusValue.BackColor = Color.Lime;

                SetInitialControlStates();

                bioDome.tbCurTempReading.Text = Convert.ToString(Constants.initialTemperature);
                bioDome.tbCurHumidReading.Text = Convert.ToString(Constants.initialHumidity);
                bioDome.tbCurWindSpeedReading.Text = Convert.ToString(Constants.minimumWindSpeed);

                bioDome.tbTempUsedControls.Text = "0";
                bioDome.tbHumUsedControls.Text = "0";
                bioDome.tbWindUsedControls.Text = "0";

                bioDome.tbTempAvailControls.Text = "14";
                bioDome.tbHumAvailControls.Text = "10";
                bioDome.tbWindAvailControls.Text = "8";


                Constants.SystemState = 1;
            }
        }

        //##########################################################################################################
        /*
                // Implements a new set of climate values inputed by the user
                public void ImplementNewExternalClimateValues()
                {
                    BioDomeSimulator bioDome = new BioDomeSimulator();

                    if (bioDome.lblBioCurrentStatusValue.Equals("ON"))
                    {

                        // Check the inputed data for validation and range
                        ErrorHandler.CheckForValidInput();

                        // Reset the failFlag
                        Constants.failFlag = 0;

                        // If the validation process fails
                        if (Constants.errorReport.length() > 0)
                        {

                            ErrorHandler.OutputValidationErrorReport();

                        }
                        else
                        {

                            // If temperature, humidity and wind values entered all fall within
                            // their nominal ranges do the following...
                            if ((Constants.temperature >= 40 && Constants.temperature <= 85) &&
                                (Constants.humidity >= 35 && Constants.humidity <= 75) &&
                                (Constants.windSpeed >= 0 && Constants.windSpeed <= 6))
                            {

                                // Adjust control panel, one control at a time according to the rules
                                RunGreenhouseControledStepDown();

                            }
                            else
                            {

                                // Handle values that are outside the Nominal ranges
                            }
                        }

                    }
                    else
                    {

                        // Let the user know that the system is currently 'OFF'
                        Append(Constants.BLK, Constants.SYSTEM_IS_OFF);
                    }

                }*/


        //##########################################################################################################

        //##########################################################################################################


        //##########################################################################################################


        //##########################################################################################################


        //##########################################################################################################


        //##########################################################################################################
        // Loads the Login Information for Verified Testers into the 
        // comboboxes provided for access to the Test Plan Database

        public void LoadLoginInfo(BioDomeSimulator bioDome)
        {
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Loading the Login Combo-boxes!\n");
            TestTools.DisplayCurrentSystemTime(bioDome);

            // Fill the Login Information Combo Boxes

            bioDome.cmbTmEnterTesterName.Items.Add("Select...");
            bioDome.cmbTmEnterTesterName.Items.Add("Eddie Gallagher");
            bioDome.cmbTmEnterTesterName.Items.Add("Tristan Duffy");
            bioDome.cmbTmEnterTesterName.Items.Add("Shane Rodgers");
            bioDome.cmbTmEnterTesterName.Items.Add("Guest");

            bioDome.cmbTmDesignation.Items.Add("Select...");
            bioDome.cmbTmDesignation.Items.Add("Software Dev");
            bioDome.cmbTmDesignation.Items.Add("Test Lead");
            bioDome.cmbTmDesignation.Items.Add("Jr. Tester");
            bioDome.cmbTmDesignation.Items.Add("Test Manager");
            bioDome.cmbTmDesignation.Items.Add("Contractor");

            bioDome.cmbTmTesterId.Items.Add("Select...");
            bioDome.cmbTmTesterId.Items.Add("SD-4554");
            bioDome.cmbTmTesterId.Items.Add("TL-6221");
            bioDome.cmbTmTesterId.Items.Add("JT-2337");
            bioDome.cmbTmTesterId.Items.Add("TM-9009");
            bioDome.cmbTmTesterId.Items.Add("C-8888");

            bioDome.cmbTmPathToSQLServer.Items.Add("Select...");
            bioDome.cmbTmPathToSQLServer.Items.Add("DESKTOP-9N9J51G");
            bioDome.cmbTmPathToSQLServer.Items.Add("COB16PC");
            bioDome.cmbTmPathToSQLServer.Items.Add("COB18PC");
            bioDome.cmbTmPathToSQLServer.Items.Add("COB19PC");

            bioDome.cmbTmEnterTesterName.SelectedIndex = 0;
            bioDome.cmbTmDesignation.SelectedIndex = 0;
            bioDome.cmbTmTesterId.SelectedIndex = 0;
            bioDome.cmbTmPathToSQLServer.SelectedIndex = 0;
        }

        //##########################################################################################################

        // Loads the ETI Tool Bio-Dome Control 
        // Comboboxes with their Value Options

        public void LoadETITool(BioDomeSimulator BioSim)
        {
            BioSim.Append(BioSim.rtbBdlLoggingWindow, Constants.BLU, "\n   Loading the ETI Tool control Combo-boxes\n");
            TestTools.DisplayCurrentSystemTime(BioSim);

            // Fill the Exploratory Testing Control Combo Boxes

            BioSim.cmbExpHeater1.Items.Add("Select...");
            BioSim.cmbExpHeater1.Items.Add("Off");
            BioSim.cmbExpHeater1.Items.Add("On");
            BioSim.cmbExpHeater2.Items.Add("Select...");
            BioSim.cmbExpHeater2.Items.Add("Off");
            BioSim.cmbExpHeater2.Items.Add("On");
            BioSim.cmbExpHeater3.Items.Add("Select...");
            BioSim.cmbExpHeater3.Items.Add("Off");
            BioSim.cmbExpHeater3.Items.Add("On");
            BioSim.cmbExpHeater4.Items.Add("Select...");
            BioSim.cmbExpHeater4.Items.Add("Off");
            BioSim.cmbExpHeater4.Items.Add("On");

            BioSim.cmbExpVent1.Items.Add("Select...");
            BioSim.cmbExpVent1.Items.Add("Closed");
            BioSim.cmbExpVent1.Items.Add("Half-Open");
            BioSim.cmbExpVent1.Items.Add("Open");
            BioSim.cmbExpVent2.Items.Add("Select...");
            BioSim.cmbExpVent2.Items.Add("Closed");
            BioSim.cmbExpVent2.Items.Add("Half-Open");
            BioSim.cmbExpVent2.Items.Add("Open");
            BioSim.cmbExpVent3.Items.Add("Select...");
            BioSim.cmbExpVent3.Items.Add("Closed");
            BioSim.cmbExpVent3.Items.Add("Half-Open");
            BioSim.cmbExpVent3.Items.Add("Open");
            BioSim.cmbExpVent4.Items.Add("Select...");
            BioSim.cmbExpVent4.Items.Add("Closed");
            BioSim.cmbExpVent4.Items.Add("Half-Open");
            BioSim.cmbExpVent4.Items.Add("Open");

            BioSim.cmbExpSprink1.Items.Add("Select...");
            BioSim.cmbExpSprink1.Items.Add("Off");
            BioSim.cmbExpSprink1.Items.Add("On");
            BioSim.cmbExpSprink2.Items.Add("Select...");
            BioSim.cmbExpSprink2.Items.Add("Off");
            BioSim.cmbExpSprink2.Items.Add("On");

            BioSim.cmbExpHeater1.SelectedIndex = 0;
            BioSim.cmbExpHeater2.SelectedIndex = 0;
            BioSim.cmbExpHeater3.SelectedIndex = 0;
            BioSim.cmbExpHeater4.SelectedIndex = 0;
            BioSim.cmbExpVent1.SelectedIndex = 0;
            BioSim.cmbExpVent2.SelectedIndex = 0;
            BioSim.cmbExpVent3.SelectedIndex = 0;
            BioSim.cmbExpVent4.SelectedIndex = 0;
            BioSim.cmbExpSprink1.SelectedIndex = 0;
            BioSim.cmbExpSprink2.SelectedIndex = 0;
        }

        //##########################################################################################################

        // Loads the TPI Tool Bio-Dome Control Throttle 
        // Comboboxes with the available time Options

        public void LoadAutorunThrottle(BioDomeSimulator BioSim)
        {
            BioSim.Append(BioSim.rtbBdlLoggingWindow, Constants.BLU, "\n   Loading the Autorun Throttle Combo-box!\n");
            TestTools.DisplayCurrentSystemTime(BioSim);

            BioSim.cmbTPThrottleAutorunTestPace.Items.Add("Select Test Pace!");
            BioSim.cmbTPThrottleAutorunTestPace.Items.Add("10 seconds");
            BioSim.cmbTPThrottleAutorunTestPace.Items.Add("20 seconds");
            BioSim.cmbTPThrottleAutorunTestPace.Items.Add("45 seconds");
            BioSim.cmbTPThrottleAutorunTestPace.Items.Add("01 minute");
            BioSim.cmbTPThrottleAutorunTestPace.Items.Add("03 minutes");
            BioSim.cmbTPThrottleAutorunTestPace.Items.Add("05 minutes");
            BioSim.cmbTPThrottleAutorunTestPace.Items.Add("15 minutes");
            BioSim.cmbTPThrottleAutorunTestPace.Items.Add("30 minutes");

            BioSim.cmbTPThrottleAutorunTestPace.SelectedIndex = 0;
        }

        //##########################################################################################################
        // Not currently being used
        public void ColorSelectedString(RichTextBox rtb, string color)
        {
            string formatError = rtb.Text;
            rtb.SelectAll();
            rtb.SelectionColor = System.Drawing.Color.FromName(color);
            rtb.AppendText(formatError);
        }

        //##########################################################################################################


        //##########################################################################################################

        // Generates a testcase template for the Pre-Test and Expected Results listboxes in the 
        // Exploratory Testcase Implementation Tool and Testplan Implementation Tool
        public void GenerateTestcaseResultsTemplate(BioDomeSimulator bioDome, RichTextBox logging, RichTextBox expected)
        {
            bioDome.Append(logging, Constants.BLU, "\n   Loading the 'Expected Results' template.\n");
            TestTools.DisplayCurrentSystemTime(bioDome);

            expected.Clear();
            expected.Text = "";
            bioDome.Append(expected, Constants.ORGBLK, "=====================\n\n");
            bioDome.Append(expected, Constants.BLK, "Current Testcase: ");
            bioDome.Append(expected, Constants.BLU, "[" + Constants.testCaseNumber + "]\n\n");

            bioDome.Append(expected, Constants.ORGBLK, "=====================\n\n");

            bioDome.Append(expected, Constants.BLK, "Temperature Details\n");
            bioDome.Append(expected, Constants.BLK, "T-Value:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");
            bioDome.Append(expected, Constants.BLK, "T-Status:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");
            bioDome.Append(expected, Constants.BLK, "T-Load Severity:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n\n");

            bioDome.Append(expected, Constants.LIGREBLK, "=====================\n\n");

            bioDome.Append(expected, Constants.BLK, "Humidity Details\n");
            bioDome.Append(expected, Constants.BLK, "H-Value:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");
            bioDome.Append(expected, Constants.BLK, "H-Status:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");
            bioDome.Append(expected, Constants.BLK, "H-Load Severity:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n\n");

            bioDome.Append(expected, Constants.LIGREBLK, "=====================\n\n");

            bioDome.Append(expected, Constants.BLK, "Wind Details\n");
            bioDome.Append(expected, Constants.BLK, "W-Value:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");
            bioDome.Append(expected, Constants.BLK, "W-Status:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");
            bioDome.Append(expected, Constants.BLK, "W-Load Severity:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n\n");

            bioDome.Append(expected, Constants.LIGREBLK, "=====================\n\n");

            bioDome.Append(expected, Constants.BLK, "Heater 1:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");

            bioDome.Append(expected, Constants.BLK, "Heater 2:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");

            bioDome.Append(expected, Constants.BLK, "Heater 3:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");

            bioDome.Append(expected, Constants.BLK, "Heater 4:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n\n");

            bioDome.Append(expected, Constants.LIGREBLK, "=====================\n\n");

            bioDome.Append(expected, Constants.BLK, "Vent 1:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");

            bioDome.Append(expected, Constants.BLK, "Vent 2:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");

            bioDome.Append(expected, Constants.BLK, "Vent 3:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");

            bioDome.Append(expected, Constants.BLK, "Vent 4:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n\n");

            bioDome.Append(expected, Constants.LIGREBLK, "=====================\n\n");

            bioDome.Append(expected, Constants.BLK, "Sprinkler 1:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n");

            bioDome.Append(expected, Constants.BLK, "Sprinkler 2:-> ");
            bioDome.Append(expected, Constants.BLU, "[ ]\n\n");

            bioDome.Append(expected, Constants.ORGBLK, "=====================\n\n");

            bioDome.Append(expected, Constants.BLK, "End of Results\n");
            bioDome.Append(expected, Constants.BLK, "For Testcase ");
            bioDome.Append(expected, Constants.BLU, "[" + Constants.testCaseNumber + "]");

            bioDome.Append(expected, Constants.ORGBLK, "\n\n=====================");
        }

        //##################################################################
        //##################################################################

        // Loads the current control values into the CurrentSimulatorValues rich text box
        // in either the Test Implementation Tool or the Exploratory Testcase Implementation 
        // Tool. The method will display the values that existed prior to the testcase
        // being run. When the current testcase has completed and a testcase result is returned
        // the rich text box will be cleared in order to be ready for the next testcase.

        public void LoadCurrentControlValues(BioDomeSimulator bioDome, RichTextBox logging, RichTextBox current)
        {
            bioDome.Append(logging, Constants.BLU, "\n   Loading the current control values into\n"
                                                                      + "   CurrentSimulatorValues rich text box\n");
            TestTools.DisplayCurrentSystemTime(bioDome);

            string state = "";

            current.Clear();
            current.Text = "";
            bioDome.Append(current, Constants.ORGBLK, "=====================\n\n");
            bioDome.Append(current, Constants.BLK, "Current Control States\n\n");

            bioDome.Append(current, Constants.ORGBLK, "=====================\n\n");

            state = bioDome.tbCurTempReading.Text;
            if (state.Length < 1)
            {
                state = "Null";
            }
            bioDome.Append(current, Constants.BLK, "Temperature Details\n");
            bioDome.Append(current, Constants.BLK, "T-Value:-> ");
            bioDome.Append(current, Constants.BLU, "[" + state + "]\n");
            bioDome.Append(current, Constants.BLK, "T-Status:-> ");
            bioDome.Append(current, Constants.BLU, "[" + temperatureStateIndicator.GetState() + "]\n");
            bioDome.Append(current, Constants.BLK, "T-Load Severity:-> ");
            bioDome.Append(current, Constants.BLU, "[" + temperatureSeverityIndicator.GetState() + "]\n\n");

            bioDome.Append(current, Constants.LIGREBLK, "=====================\n\n");

            state = bioDome.tbCurHumidReading.Text;
            if (state.Length < 1)
            {
                state = "Null";
            }
            bioDome.Append(current, Constants.BLK, "Humidity Details\n");
            bioDome.Append(current, Constants.BLK, "H-Value:-> ");
            bioDome.Append(current, Constants.BLU, "[" + state + "]\n");
            bioDome.Append(current, Constants.BLK, "H-Status:-> ");
            bioDome.Append(current, Constants.BLU, "[" + humidityStateIndicator.GetState() + "]\n");
            bioDome.Append(current, Constants.BLK, "H-Load Severity:-> ");
            bioDome.Append(current, Constants.BLU, "[" + humiditySeverityIndicator.GetState() + "]\n\n");

            bioDome.Append(current, Constants.LIGREBLK, "=====================\n\n");

            state = bioDome.tbCurWindSpeedReading.Text;
            if (state.Length < 1)
            {
                state = "Null";
            }
            bioDome.Append(current, Constants.BLK, "Wind Details\n");
            bioDome.Append(current, Constants.BLK, "W-Value:-> ");
            bioDome.Append(current, Constants.BLU, "[" + state + "]\n");
            bioDome.Append(current, Constants.BLK, "W-Status:-> ");
            bioDome.Append(current, Constants.BLU, "[" + windSpeedStateIndicator.GetState() + "]\n");
            bioDome.Append(current, Constants.BLK, "W-Load Severity:-> ");
            bioDome.Append(current, Constants.BLU, "[" + windSpeedSeverityIndicator.GetState() + "]\n\n");

            bioDome.Append(current, Constants.LIGREBLK, "=====================\n\n");

            bioDome.Append(current, Constants.BLK, "Heater 1:-> ");
            bioDome.Append(current, Constants.BLU, "[" + heat1.GetState() + "]\n");

            bioDome.Append(current, Constants.BLK, "Heater 2:-> ");
            bioDome.Append(current, Constants.BLU, "[" + heat2.GetState() + "]\n");

            bioDome.Append(current, Constants.BLK, "Heater 3:-> ");
            bioDome.Append(current, Constants.BLU, "[" + heat3.GetState() + "]\n");

            bioDome.Append(current, Constants.BLK, "Heater 4:-> ");
            bioDome.Append(current, Constants.BLU, "[" + heat4.GetState() + "]\n\n");

            bioDome.Append(current, Constants.LIGREBLK, "=====================\n\n");

            bioDome.Append(current, Constants.BLK, "Vent 1:-> ");
            bioDome.Append(current, Constants.BLU, "[" + vent1.GetState() + "]\n");

            bioDome.Append(current, Constants.BLK, "Vent 2:-> ");
            bioDome.Append(current, Constants.BLU, "[" + vent2.GetState() + "]\n");

            bioDome.Append(current, Constants.BLK, "Vent 3:-> ");
            bioDome.Append(current, Constants.BLU, "[" + vent3.GetState() + "]\n");

            bioDome.Append(current, Constants.BLK, "Vent 4:-> ");
            bioDome.Append(current, Constants.BLU, "[" + vent4.GetState() + "]\n\n");

            bioDome.Append(current, Constants.LIGREBLK, "=====================\n\n");

            bioDome.Append(current, Constants.BLK, "Sprinkler 1:-> ");
            bioDome.Append(current, Constants.BLU, "[" + sprink1.GetState() + "]\n");

            bioDome.Append(current, Constants.BLK, "Sprinkler 2:-> ");
            bioDome.Append(current, Constants.BLU, "[" + sprink2.GetState() + "]\n\n");

            bioDome.Append(current, Constants.ORGBLK, "=====================\n\n");

            bioDome.Append(current, Constants.BLK, "End of current values\n");
            bioDome.Append(current, Constants.BLK, "present on the Simulator");

            bioDome.Append(current, Constants.ORGBLK, "\n\n=====================");
        }

        //##################################################################
        //##################################################################

        // Loads the control values into the ActualResults rich text box
        // in either the Test Implementation Tool or the Exploratory Testcase Implementation 
        // Tool. The method will display the values that exist after the current testcase has
        // beeen run. When the current testcase has run the expected results will be compared 
        // against the values contained in the ActualResults text box and a result of Fail or
        // Pass will be assigned to the testcase. The current, expected and actual simulator 
        // values will be logged against the testcase along with the result and the text boxes 
        // will then be cleared in order to be ready for the next testcase. 

        public void LoadControlValuesAfterTest(BioDomeSimulator bioDome, RichTextBox logging, RichTextBox actual)
        {
            bioDome.Append(logging, Constants.BLU, "\n   Loading the current control values into\n"
                                                                      + "   CurrentSimulatorValues rich text box\n");
            TestTools.DisplayCurrentSystemTime(bioDome);

            string state = "";

            actual.Clear();
            actual.Text = "";
            bioDome.Append(actual, Constants.ORGBLK, "=====================\n\n");
            bioDome.Append(actual, Constants.BLK, "Current Testcase: ");
            bioDome.Append(actual, Constants.BLU, "[" + Constants.testCaseNumber + "]\n\n");

            bioDome.Append(actual, Constants.ORGBLK, "=====================\n\n");

            state = bioDome.tbCurTempReading.Text;
            if (state.Length < 1)
            {
                state = "Null";
            }
            bioDome.Append(actual, Constants.BLK, "Temperature Details\n");
            bioDome.Append(actual, Constants.BLK, "T-Value:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + state + "]\n");
            bioDome.Append(actual, Constants.BLK, "T-Status:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + temperatureStateIndicator.GetState() + "]\n");
            bioDome.Append(actual, Constants.BLK, "T-Load Severity:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + temperatureSeverityIndicator.GetState() + "]\n\n");

            bioDome.Append(actual, Constants.LIGREBLK, "=====================\n\n");

            state = bioDome.tbCurHumidReading.Text;
            if (state.Length < 1)
            {
                state = "Null";
            }
            bioDome.Append(actual, Constants.BLK, "Humidity Details\n");
            bioDome.Append(actual, Constants.BLK, "H-Value:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + state + "]\n");
            bioDome.Append(actual, Constants.BLK, "H-Status:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + humidityStateIndicator.GetState() + "]\n");
            bioDome.Append(actual, Constants.BLK, "H-Load Severity:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + humiditySeverityIndicator.GetState() + "]\n\n");

            bioDome.Append(actual, Constants.LIGREBLK, "=====================\n\n");

            state = bioDome.tbCurWindSpeedReading.Text;
            if (state.Length < 1)
            {
                state = "Null";
            }
            bioDome.Append(actual, Constants.BLK, "Wind Details\n");
            bioDome.Append(actual, Constants.BLK, "W-Value:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + state + "]\n");
            bioDome.Append(actual, Constants.BLK, "W-Status:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + windSpeedStateIndicator.GetState() + "]\n");
            bioDome.Append(actual, Constants.BLK, "W-Load Severity:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + windSpeedSeverityIndicator.GetState() + "]\n\n");

            bioDome.Append(actual, Constants.LIGREBLK, "=====================\n\n");

            bioDome.Append(actual, Constants.BLK, "Heater 1:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + heat1.GetState() + "]\n");

            bioDome.Append(actual, Constants.BLK, "Heater 2:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + heat2.GetState() + "]\n");

            bioDome.Append(actual, Constants.BLK, "Heater 3:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + heat3.GetState() + "]\n");

            bioDome.Append(actual, Constants.BLK, "Heater 4:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + heat4.GetState() + "]\n\n");

            bioDome.Append(actual, Constants.LIGREBLK, "=====================\n\n");

            bioDome.Append(actual, Constants.BLK, "Vent 1:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + vent1.GetState() + "]\n");

            bioDome.Append(actual, Constants.BLK, "Vent 2:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + vent2.GetState() + "]\n");

            bioDome.Append(actual, Constants.BLK, "Vent 3:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + vent3.GetState() + "]\n");

            bioDome.Append(actual, Constants.BLK, "Vent 4:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + vent4.GetState() + "]\n\n");

            bioDome.Append(actual, Constants.LIGREBLK, "=====================\n\n");

            bioDome.Append(actual, Constants.BLK, "Sprinkler 1:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + sprink1.GetState() + "]\n");

            bioDome.Append(actual, Constants.BLK, "Sprinkler 2:-> ");
            bioDome.Append(actual, Constants.BLU, "[" + sprink2.GetState() + "]\n\n");

            bioDome.Append(actual, Constants.ORGBLK, "=====================\n\n");

            bioDome.Append(actual, Constants.BLK, "End of Results\n");
            bioDome.Append(actual, Constants.BLK, "For Testcase ");
            bioDome.Append(actual, Constants.BLU, "[" + Constants.testCaseNumber + "]");
            bioDome.Append(actual, Constants.ORGBLK, "\n\n=====================");
        }

        //##################################################################
        //##################################################################

        // Method determines the values for hours, minutes and seconds of
        // lapsed Simulator time.
        public static void GetSecondsMinutesHours(BioDomeSimulator bioDome)
        {
            if (seconds <= 58)
            {
                seconds++;
            }
            else
            {
               seconds = 0;

                if (minutes <= 58)
                {
                    minutes++;
                }
                else
                {
                    hours++;
                    minutes = 0;
                }
            }

            DisplayLapsedTime(bioDome);
        }

        //##################################################################
        //##################################################################

        // Method formats the lapsed Simulator time into hours, minutes and seconds.
        public static void DisplayLapsedTime(BioDomeSimulator bioDome)
        {
            string formattedhours = "";
            string formattedminutes = "";
            string formattedseconds = "";

            if (hours < 10)
            {
                formattedhours = "0" + hours.ToString();
            }
            else
            {
                formattedhours = hours.ToString();
            }

            if (minutes < 10)
            {
                formattedminutes = "0" + minutes.ToString();
            }
            else
            {
                formattedminutes = minutes.ToString();
            }

            if (seconds < 10)
            {
                formattedseconds = "0" + seconds.ToString();
            }
            else
            {
                formattedseconds = seconds.ToString();
            }

            bioDome.BioDomeTestInterval.Text = formattedhours + " hrs  " + formattedminutes + " mins  " + formattedseconds + " secs";
        }

        //##################################################################
        //##################################################################

        // Method compares the expected results against the actual results 
        // derived from running the testcase.
        public static void CompareExpectedResultsToActualResults()
        {

        }


        //##################################################################
        //##################################################################
        
        //C:\Users\Eddie Gallagher\Desktop\ETB C# Stuff\BioDomeSimulator\Logs


    }
}
