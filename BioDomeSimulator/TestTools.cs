using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioDomeSimulator
{
    class TestTools
    {
        //##########################################################################################################

        // Variables used to check Testcase Results
        public static string expTCNumber = "";
        public static string testTValue = "";
        public static string testTStatus = "";
        public static string testTSeverity = "";
        public static string testHValue = "";
        public static string testHStatus = "";
        public static string testHSeverity = "";
        public static string testWValue = "";
        public static string testWStatus = "";
        public static string testWSeverity = "";
        public static string testHeat1 = "";
        public static string testHeat2 = "";
        public static string testHeat3 = "";
        public static string testHeat4 = "";
        public static string testVent1 = "";
        public static string testVent2 = "";
        public static string testVent3 = "";
        public static string testVent4 = "";
        public static string testSprink1 = "";
        public static string testSprink2 = "";
        public static string expTStatus = "";
        public static string expTSeverity = "";
        public static string expHStatus = "";
        public static string expHSeverity = "";
        public static string expWStatus = "";
        public static string expWSeverity = "";
        public static string expHeat1 = "";
        public static string expHeat2 = "";
        public static string expHeat3 = "";
        public static string expHeat4 = "";
        public static string expVent1 = "";
        public static string expVent2 = "";
        public static string expVent3 = "";
        public static string expVent4 = "";
        public static string expSprink1 = "";
        public static string expSprink2 = "";

        public static string actTCNumber = "";
        public static string actTValue = "";
        public static string actTStatus = "";
        public static string actTSeverity = "";
        public static string actHValue = "";
        public static string actHStatus = "";
        public static string actHSeverity = "";
        public static string actWValue = "";
        public static string actWStatus = "";
        public static string actWSeverity = "";
        public static string actHeat1 = "";
        public static string actHeat2 = "";
        public static string actHeat3 = "";
        public static string actHeat4 = "";
        public static string actVent1 = "";
        public static string actVent2 = "";
        public static string actVent3 = "";
        public static string actVent4 = "";
        public static string actSprink1 = "";
        public static string actSprink2 = "";

        //##########################################################################################################

        public static List<string> expectedList = new List<string>();
        public static List<string> actualList = new List<string>();

        //##########################################################################################################

        public static DateTime currentTime;
        public static int stateChange = 0;

        // Counters for temperature, humidity and wind speed controls that are inuse
        public static int tempControlsInUse = 0;
        public static int humControlsInUse = 0;
        public static int winControlsInUse = 0;
        public static int inUseCounter = 0;


        // User inputted values for current temperature, humidity and wind speed
        public static int currentTemperatureValue = 0;
        public static int currentHumidityValue = 0;
        public static int currentWindSpeedValue = 0;

        //##########################################################################################################
        //##########################################################################################################

        public static void DisplayCurrentSystemTime(BioDomeSimulator bioDome)
        {
            currentTime = DateTime.Now;
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   Current System Time: ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.RED, currentTime + "\n");
        }

        //##########################################################################################################
        //##########################################################################################################

        public static void ImplementControlUnitChange(BioDomeSimulator bioDome)
        {
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   In Method ImplementControlUnitChange!\n");
            DisplayCurrentSystemTime(bioDome);

            if ((currentTemperatureValue >= 55 && currentTemperatureValue <= 75) && (currentHumidityValue >= 50 
                && currentHumidityValue <= 70) && (currentWindSpeedValue >= 0 && currentWindSpeedValue <= 7))
            {
                ReportNoControlChangeNeeded(bioDome);
                DisplayControlsInUse(bioDome);
            }
            else
            {
                if (currentTemperatureValue > 75)
                {
                    ManageTemperatureTooHigh(bioDome);
                }
                else if (currentTemperatureValue < 55)
                {
                    ManageTemperatureTooLow(bioDome);
                }
                else if (currentHumidityValue > 70)
                {
                    ManageHumidityTooHigh(bioDome);
                }
                else if (currentHumidityValue < 50)
                {
                    ManageHumidityTooLow(bioDome);
                }
                else if (currentWindSpeedValue > 7)
                {
                    ManageAirFlowTooHigh(bioDome);
                }
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        // Changes the color of the resource availability indicators according to their state.
        public static void DisplayControlsInUse(BioDomeSimulator bioDome)
        {
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Setting and displaying the controls in use.\n");
            DisplayCurrentSystemTime(bioDome);

            string h1 = BioDomeControls.heat1.GetState();
            string h2 = BioDomeControls.heat2.GetState();
            string h3 = BioDomeControls.heat3.GetState();
            string h4 = BioDomeControls.heat4.GetState();
            string v1 = BioDomeControls.vent1.GetState();
            string v2 = BioDomeControls.vent2.GetState();
            string v3 = BioDomeControls.vent3.GetState();
            string v4 = BioDomeControls.vent4.GetState();
            string s1 = BioDomeControls.sprink1.GetState();
            string s2 = BioDomeControls.sprink2.GetState();

            tempControlsInUse = 0;
            humControlsInUse = 0;
            winControlsInUse = 0;

            inUseCounter = 0;

            if (h1.Equals("On"))
            {
                BioDomeSimulator.bioControlsInUseList[0].BackColor = Color.Red;
                inUseCounter++;
                tempControlsInUse++;
            }
            else
            {
                BioDomeSimulator.bioControlsInUseList[0].BackColor = Color.Lime;
                if (tempControlsInUse > 0)
                {
                    tempControlsInUse--;
                }
            }

            if (h2.Equals("On"))
            {
                BioDomeSimulator.bioControlsInUseList[1].BackColor = Color.Red;
                inUseCounter++;
                tempControlsInUse++;
            }
            else
            {
                BioDomeSimulator.bioControlsInUseList[1].BackColor = Color.Lime;
                if (tempControlsInUse > 0)
                {
                    tempControlsInUse--;
                }
            }

            if (h3.Equals("On"))
            {
                BioDomeSimulator.bioControlsInUseList[2].BackColor = Color.Red;
                inUseCounter++;
                tempControlsInUse++;
            }
            else
            {
                BioDomeSimulator.bioControlsInUseList[2].BackColor = Color.Lime;
                if (tempControlsInUse > 0)
                {
                    tempControlsInUse--;
                }
            }

            if (h4.Equals("On"))
            {
                BioDomeSimulator.bioControlsInUseList[3].BackColor = Color.Red;
                inUseCounter++;
                tempControlsInUse++;
            }
            else
            {
                BioDomeSimulator.bioControlsInUseList[3].BackColor = Color.Lime;
                if (tempControlsInUse > 0)
                {
                    tempControlsInUse--;
                }
            }

            if (v1.Equals("Open"))
            {
                BioDomeSimulator.bioControlsInUseList[4].BackColor = Color.Red;
                inUseCounter++;
                tempControlsInUse++;
                humControlsInUse++;
                winControlsInUse++;
            }
            else if (v1.Equals("Half-Open"))
            {
                BioDomeSimulator.bioControlsInUseList[4].BackColor = Color.Orange;
                inUseCounter++;
                tempControlsInUse++;
                humControlsInUse++;
                winControlsInUse++;
            }
            else
            {
                BioDomeSimulator.bioControlsInUseList[4].BackColor = Color.Lime;
                if (tempControlsInUse > 0)
                {
                    tempControlsInUse--;
                }
                if (humControlsInUse > 0)
                {
                    humControlsInUse--;
                }
                if (winControlsInUse > 0)
                {
                    winControlsInUse--;
                }
            }

            if (v2.Equals("Open"))
            {
                BioDomeSimulator.bioControlsInUseList[5].BackColor = Color.Red;
                inUseCounter++;
                tempControlsInUse++;
                humControlsInUse++;
                winControlsInUse++;
            }
            else if (v2.Equals("Half-Open"))
            {
                BioDomeSimulator.bioControlsInUseList[5].BackColor = Color.Orange;
                inUseCounter++;
                tempControlsInUse++;
                humControlsInUse++;
                winControlsInUse++;
            }
            else
            {
                BioDomeSimulator.bioControlsInUseList[5].BackColor = Color.Lime;
                if (tempControlsInUse > 0)
                {
                    tempControlsInUse--;
                }
                if (humControlsInUse > 0)
                {
                    humControlsInUse--;
                }
                if (winControlsInUse > 0)
                {
                    winControlsInUse--;
                }
            }

            if (v3.Equals("Open"))
            {
                BioDomeSimulator.bioControlsInUseList[6].BackColor = Color.Red;
                inUseCounter++;
                tempControlsInUse++;
                humControlsInUse++;
                winControlsInUse++;
            }
            else if (v3.Equals("Half-Open"))
            {
                BioDomeSimulator.bioControlsInUseList[6].BackColor = Color.Orange;
                inUseCounter++;
                tempControlsInUse++;
                humControlsInUse++;
                winControlsInUse++;
            }
            else
            {
                BioDomeSimulator.bioControlsInUseList[6].BackColor = Color.Lime;
                if (tempControlsInUse > 0)
                {
                    tempControlsInUse--;
                }
                if (humControlsInUse > 0)
                {
                    humControlsInUse--;
                }
                if (winControlsInUse > 0)
                {
                    winControlsInUse--;
                }
            }

            if (v4.Equals("Open"))
            {
                BioDomeSimulator.bioControlsInUseList[7].BackColor = Color.Red;
                inUseCounter++;
                tempControlsInUse++;
                humControlsInUse++;
                winControlsInUse++;
            }
            else if (v4.Equals("Half-Open"))
            {
                BioDomeSimulator.bioControlsInUseList[7].BackColor = Color.Orange;
                inUseCounter++;
                tempControlsInUse++;
                humControlsInUse++;
                winControlsInUse++;
            }
            else
            {
                BioDomeSimulator.bioControlsInUseList[7].BackColor = Color.Lime;
                if (tempControlsInUse > 0)
                {
                    tempControlsInUse--;
                }
                if (humControlsInUse > 0)
                {
                    humControlsInUse--;
                }
                if (winControlsInUse > 0)
                {
                    winControlsInUse--;
                }
            }

            if (s1.Equals("On"))
            {
                BioDomeSimulator.bioControlsInUseList[8].BackColor = Color.Red;
                inUseCounter++;
                tempControlsInUse++;
                humControlsInUse++;
            }
            else
            {
                BioDomeSimulator.bioControlsInUseList[8].BackColor = Color.Lime;
                if (tempControlsInUse > 0)
                {
                    tempControlsInUse--;
                }
                if (humControlsInUse > 0)
                {
                    humControlsInUse--;
                }
            }

            if (s2.Equals("On"))
            {
                BioDomeSimulator.bioControlsInUseList[9].BackColor = Color.Red;
                inUseCounter++;
                tempControlsInUse++;
                humControlsInUse++;
            }
            else
            {
                BioDomeSimulator.bioControlsInUseList[9].BackColor = Color.Lime;
                if (tempControlsInUse > 0)
                {
                    tempControlsInUse--;
                }
                if (humControlsInUse > 0)
                {
                    humControlsInUse--;
                }
            }

            // Display the number of controls units that are in use.
            bioDome.tbBioDomeControlsInUse.Text = "";
            bioDome.tbBioDomeControlsInUse.Text = inUseCounter.ToString();

            // Breakdown and display control units in use 
            // for each climate state.
            bioDome.tbTempUsedControls.Text = tempControlsInUse.ToString();
            bioDome.tbHumUsedControls.Text = humControlsInUse.ToString();
            bioDome.tbWindUsedControls.Text = winControlsInUse.ToString();

            // Calculate and display the controls units 
            // still available for each climate state.
            bioDome.tbTempAvailControls.Text = (14 - tempControlsInUse).ToString();
            bioDome.tbHumAvailControls.Text = (10 - humControlsInUse).ToString();
            bioDome.tbWindAvailControls.Text = (8 - winControlsInUse).ToString();

            SetLoadSeverityLevels(bioDome);
        }

        //##########################################################################################################
        //##########################################################################################################

        // Method sets the severity level for temperature, humidity and wind speed. Also sets the color of each level
        // in relation to the level that is currently active.
        public static void SetLoadSeverityLevels(BioDomeSimulator bioDome)
        {
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Setting and displaying the Load Severity Levels.\n");
            DisplayCurrentSystemTime(bioDome);

            if (tempControlsInUse == 0)
            {
                bioDome.lblBioTempLevel0.BackColor = Color.Lime;
                bioDome.lblBioTempLevel1.BackColor = Color.LightGray;
                bioDome.lblBioTempLevel2.BackColor = Color.LightGray;
                bioDome.lblBioTempLevel3.BackColor = Color.LightGray;
            }
            else if (tempControlsInUse >= 1 && tempControlsInUse <= 4)
            {
                bioDome.lblBioTempLevel0.BackColor = Color.LightGray;
                bioDome.lblBioTempLevel1.BackColor = Color.Yellow;
                bioDome.lblBioTempLevel2.BackColor = Color.LightGray;
                bioDome.lblBioTempLevel3.BackColor = Color.LightGray;
            }
            else if (tempControlsInUse >= 5 && tempControlsInUse <= 10)
            {
                bioDome.lblBioTempLevel0.BackColor = Color.LightGray;
                bioDome.lblBioTempLevel1.BackColor = Color.LightGray;
                bioDome.lblBioTempLevel2.BackColor = Color.Orange;
                bioDome.lblBioTempLevel3.BackColor = Color.LightGray;
            }
            else if (tempControlsInUse >= 11 && tempControlsInUse <= 14)
            {
                bioDome.lblBioTempLevel0.BackColor = Color.LightGray;
                bioDome.lblBioTempLevel1.BackColor = Color.LightGray;
                bioDome.lblBioTempLevel2.BackColor = Color.LightGray;
                bioDome.lblBioTempLevel3.BackColor = Color.Red;
            }

            if (humControlsInUse == 0)
            {
                bioDome.lblBioHumidLevel0.BackColor = Color.Lime;
                bioDome.lblBioHumidLevel1.BackColor = Color.LightGray;
                bioDome.lblBioHumidLevel2.BackColor = Color.LightGray;
                bioDome.lblBioHumidLevel3.BackColor = Color.LightGray;
            }
            else if (humControlsInUse >= 1 && humControlsInUse <= 3)
            {
                bioDome.lblBioHumidLevel0.BackColor = Color.LightGray;
                bioDome.lblBioHumidLevel1.BackColor = Color.Yellow;
                bioDome.lblBioHumidLevel2.BackColor = Color.LightGray;
                bioDome.lblBioHumidLevel3.BackColor = Color.LightGray;
            }
            else if (humControlsInUse >= 4 && humControlsInUse <= 7)
            {
                bioDome.lblBioHumidLevel0.BackColor = Color.LightGray;
                bioDome.lblBioHumidLevel1.BackColor = Color.LightGray;
                bioDome.lblBioHumidLevel2.BackColor = Color.Orange;
                bioDome.lblBioHumidLevel3.BackColor = Color.LightGray;
            }
            else if (humControlsInUse >= 8 && humControlsInUse <= 10)
            {
                bioDome.lblBioHumidLevel0.BackColor = Color.LightGray;
                bioDome.lblBioHumidLevel1.BackColor = Color.LightGray;
                bioDome.lblBioHumidLevel2.BackColor = Color.LightGray;
                bioDome.lblBioHumidLevel3.BackColor = Color.Red;
            }

            if (winControlsInUse == 0)
            {
                bioDome.lblBioWindSpeedLevel0.BackColor = Color.Lime;
                bioDome.lblBioWindSpeedLevel1.BackColor = Color.LightGray;
                bioDome.lblBioWindSpeedLevel2.BackColor = Color.LightGray;
                bioDome.lblBioWindSpeedLevel3.BackColor = Color.LightGray;
            }
            else if (winControlsInUse >= 1 && winControlsInUse <= 2)
            {
                bioDome.lblBioWindSpeedLevel0.BackColor = Color.LightGray;
                bioDome.lblBioWindSpeedLevel1.BackColor = Color.Yellow;
                bioDome.lblBioWindSpeedLevel2.BackColor = Color.LightGray;
                bioDome.lblBioWindSpeedLevel3.BackColor = Color.LightGray;
            }
            else if (winControlsInUse >= 3 && winControlsInUse <= 6)
            {
                bioDome.lblBioWindSpeedLevel0.BackColor = Color.LightGray;
                bioDome.lblBioWindSpeedLevel1.BackColor = Color.LightGray;
                bioDome.lblBioWindSpeedLevel2.BackColor = Color.Orange;
                bioDome.lblBioWindSpeedLevel3.BackColor = Color.LightGray;
            }
            else if (winControlsInUse >= 7 && winControlsInUse <= 8)
            {
                bioDome.lblBioWindSpeedLevel0.BackColor = Color.LightGray;
                bioDome.lblBioWindSpeedLevel1.BackColor = Color.LightGray;
                bioDome.lblBioWindSpeedLevel2.BackColor = Color.LightGray;
                bioDome.lblBioWindSpeedLevel3.BackColor = Color.Red;
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        // Method outputs to the logging window a statement that no state changes were required due to the system
        // being in an optimal state.
        public static void ReportNoControlChangeNeeded(BioDomeSimulator bioDome)
        {
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   System in OPTIMAL state. No changes made\n");
            DisplayCurrentSystemTime(bioDome);

            // Let the user know that no changes were made to the system following the implementation of the last
            // set of climate values because the system is running at the optimal configuration
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "\n   ***************************************************\n\n");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   No control changes were made to the\n");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   system as ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.RED, "all controls");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " are in their\n");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "   optimal states");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " for ");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.RED, "maximum operating \n");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.RED, "   effeciency\n");
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   ***************************************************\n");

        }

        //##########################################################################################################
        //##########################################################################################################

        // Method looks at each sprinkler ( last to first ) and turns OFF the first
        // sprinkler that it finds in an 'On' state
        public static void TurnOffBioDomeSprinkler(BioDomeSimulator bioDome)
        {
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Attempting to turn OFF a sprinkler.\n");
            DisplayCurrentSystemTime(bioDome);

            for (int i = 9; i >= 8; i--)
            {
                // Change the state of the sprinkler with the highest 
                // designation that is currently 'On' to 'Off'

                if (BioDomeControls.bioDomeControlUnits[i].GetState().Equals("On"))
                {
                    BioDomeControls.bioDomeControlUnits[i].SetState("Off");
                    stateChange = 1;

                    // If the control is Sprinkler 2 do...
                    if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Spinkler Unit 2 - Zone 2"))
                    {
                        bioDome.lblBioSprink2Off.BackColor = Color.Lime;
                        bioDome.lblBioSprink2On.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nSpinkler Unit 2 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "OFF\n\n");


                        // If the control is Sprinkler 1 do...	
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Spinkler Unit 1 - Zone 1"))
                    {
                        bioDome.lblBioSprink1Off.BackColor = Color.Lime;
                        bioDome.lblBioSprink1On.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nSpinkler Unit 1 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "OFF\n\n");
                    }
                }
            }
        }
        //##########################################################################################################
        //##########################################################################################################

        // Method looks at each sprinkler ( first to last ) and turns ON the first
        // sprinkler that it finds in an 'Off' state
        public static void TurnOnBioDomeSprinkler(BioDomeSimulator bioDome)
        {
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Attempting to turn ON a sprinkler.\n");
            DisplayCurrentSystemTime(bioDome);

            for (int i = 8; i < 10; i++)
            {
                // Change the state of the sprinkler with the highest 
                // designation that is currently 'Off' to 'On'

                if (BioDomeControls.bioDomeControlUnits[i].GetState().Equals("Off"))
                {
                    BioDomeControls.bioDomeControlUnits[i].SetState("On");
                    stateChange = 1;

                    // If the control is Sprinkler 1 do...
                    if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Spinkler Unit 1 - Zone 1"))
                    {
                        bioDome.lblBioSprink1On.BackColor = Color.Red;
                        bioDome.lblBioSprink1Off.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nSpinkler Unit 1 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "ON\n\n");

                        // If the control is Sprinkler 2 do...	
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Spinkler Unit 2 - Zone 2"))
                    {
                        bioDome.lblBioSprink2On.BackColor = Color.Red;
                        bioDome.lblBioSprink2Off.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nSpinkler Unit 2 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "ON\n\n");
                    }
                }
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        // Method looks at each heater ( last to first ) and turns OFF the first
        // heater that it finds in an 'On' state
        public static void TurnOffBioDomeHeater(BioDomeSimulator bioDome)
        {
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Attempting to turn OFF a heater.\n");
            DisplayCurrentSystemTime(bioDome);

            for (int i = 7; i >= 4; i--)
            {
                // Change the state of the heater with the highest 
                // designation that is currently 'On' to 'Off' 
                if (BioDomeControls.bioDomeControlUnits[i].GetState().Equals("On"))
                {
                    BioDomeControls.bioDomeControlUnits[i].SetState("Off");
                    stateChange = 1;

                    // If the control is Heater 4 do...
                    if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Heater Unit 4 - Zone 2"))
                    {
                        bioDome.lblBioHeater4Off.BackColor = Color.Lime;
                        bioDome.lblBioHeater4On.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nHeater Unit 4 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "OFF\n\n");

                        // If the control is Heater 3 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Heater Unit 3 - Zone 2"))
                    {
                        bioDome.lblBioHeater3Off.BackColor = Color.Lime;
                        bioDome.lblBioHeater3On.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nHeater Unit 3 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "OFF\n\n");

                        // If the control is Heater 2 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Heater Unit 2 - Zone 1"))
                    {
                        bioDome.lblBioHeater2Off.BackColor = Color.Lime;
                        bioDome.lblBioHeater2On.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nHeater Unit 2 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "OFF\n\n");

                        // If the control is Heater 1 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Heater Unit 1 - Zone 1"))
                    {
                        bioDome.lblBioHeater1Off.BackColor = Color.Lime;
                        bioDome.lblBioHeater1On.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nHeater Unit 1 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "OFF\n\n");
                    }
                }
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        // Method looks at each heater ( first to last ) and turns ON the first
        // heater that it finds in an 'Off' state
        public static void TurnOnBioDomeHeater(BioDomeSimulator bioDome)
        {
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Attempting to turn ON a heater.\n");
            DisplayCurrentSystemTime(bioDome);

            for (int i = 4; i < 8; i++)
            {
                // Change the state of the heater with the highest 
                // designation that is currently 'Off' to 'On' 
                if (BioDomeControls.bioDomeControlUnits[i].GetState().Equals("Off"))
                {
                    BioDomeControls.bioDomeControlUnits[i].SetState("On");
                    stateChange = 1;

                    // If the control is Heater 1 do...
                    if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Heater Unit 1 - Zone 1"))
                    {
                        bioDome.lblBioHeater1On.BackColor = Color.Red;
                        bioDome.lblBioHeater1Off.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nHeater Unit 1 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "ON\n\n");

                        // If the control is Heater 2 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Heater Unit 2 - Zone 1"))
                    {
                        bioDome.lblBioHeater2On.BackColor = Color.Red;
                        bioDome.lblBioHeater2Off.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nHeater Unit 2 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "ON\n\n");

                        // If the control is Heater 3 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Heater Unit 3 - Zone 2"))
                    {
                        bioDome.lblBioHeater3On.BackColor = Color.Red;
                        bioDome.lblBioHeater3Off.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nHeater Unit 3 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "ON\n\n");

                        // If the control is Heater 4 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Heater Unit 4 - Zone 2"))
                    {
                        bioDome.lblBioHeater4On.BackColor = Color.Red;
                        bioDome.lblBioHeater4Off.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nHeater Unit 4 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "ON\n\n");
                    }
                }
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        // Method looks at each vent ( last to first ) and partially closes a vent based
        // on the following rules:
        // (i)  Close an opened vent to half-open
        // (ii) If no vents are open, fully close a half-opened vent
        public static void CloseBioDomeVent(BioDomeSimulator bioDome)
        {
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Attempting to HALF CLOSE an opened vent\n"
                                                                     + "   or FULLY CLOSE a half-open vent.\n");
            DisplayCurrentSystemTime(bioDome);

            for (int i = 3; i >= 0; i--)
            {
                // Change the state of the ventilation unit with the highest 
                // to designation that is currently 'Open' to 'Half-Open'
                if (BioDomeControls.bioDomeControlUnits[i].GetState().Equals("Open"))
                {
                    BioDomeControls.bioDomeControlUnits[i].SetState("Half-Open");
                    stateChange = 1;

                    // If the control is Vent 4 do...
                    if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 4 - Zone 2"))
                    {
                        bioDome.lblBioVent4Open.BackColor = Color.LightGray;
                        bioDome.lblBioVent4HalfOpen.BackColor = Color.Orange;
                        bioDome.lblBioVent4Closed.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 4 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.ORGBLK, "Half-Open\n\n");

                        // If the control is Vent 3 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 3 - Zone 2"))
                    {
                        bioDome.lblBioVent3Open.BackColor = Color.LightGray;
                        bioDome.lblBioVent3HalfOpen.BackColor = Color.Orange;
                        bioDome.lblBioVent3Closed.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 3 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.ORGBLK, "Half-Open\n\n");

                        // If the control is Vent 2 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 2 - Zone 1"))
                    {
                        bioDome.lblBioVent2Open.BackColor = Color.LightGray;
                        bioDome.lblBioVent2HalfOpen.BackColor = Color.Orange;
                        bioDome.lblBioVent2Closed.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 2 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.ORGBLK, "Half-Open\n\n");

                        // If the control is Vent 1 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 1 - Zone 1"))
                    {
                        bioDome.lblBioVent1Open.BackColor = Color.LightGray;
                        bioDome.lblBioVent1HalfOpen.BackColor = Color.Orange;
                        bioDome.lblBioVent1Closed.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 1 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.ORGBLK, "Half-Open\n\n");
                    }

                    // If no ventilation units are 'Open', try to change the state of 
                    // the ventilation unit with the highest designation that is 
                    // currently 'Half-Open' to 'Closed'	
                }
                else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Half-Open"))
                {
                    BioDomeControls.bioDomeControlUnits[i].SetState("Closed");
                    stateChange = 1;

                    // If the control is Vent 4 do...
                    if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 4 - Zone 2"))
                    {                 
                        bioDome.lblBioVent4Open.BackColor = Color.LightGray;
                        bioDome.lblBioVent4HalfOpen.BackColor = Color.LightGray;
                        bioDome.lblBioVent4Closed.BackColor = Color.Lime;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 4 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "Closed\n\n");

                        // If the control is Vent 3 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 3 - Zone 2"))
                    {
                        bioDome.lblBioVent3Open.BackColor = Color.LightGray;
                        bioDome.lblBioVent3HalfOpen.BackColor = Color.LightGray;
                        bioDome.lblBioVent3Closed.BackColor = Color.Lime;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 3 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "Closed\n\n");

                        // If the control is Vent 2 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 2 - Zone 1"))
                    {
                        bioDome.lblBioVent2Open.BackColor = Color.LightGray;
                        bioDome.lblBioVent2HalfOpen.BackColor = Color.LightGray;
                        bioDome.lblBioVent2Closed.BackColor = Color.Lime;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 2 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "Closed\n\n");

                        // If the control is Vent 1 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 1 - Zone 1"))
                    {
                        bioDome.lblBioVent1Open.BackColor = Color.LightGray;
                        bioDome.lblBioVent1HalfOpen.BackColor = Color.LightGray;
                        bioDome.lblBioVent1Closed.BackColor = Color.Lime;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 1 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.LIGREBLK, "Closed\n\n");
                    }
                }
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        // Method looks at each vent ( first to last ) and partially opens a vent based
        // on the following rules:
        // (i)  Open a closed vent to half-open
        // (ii) If no vents are closed, fully open a half-opened vent
        public static void OpenBioDomeVent(BioDomeSimulator bioDome)
        {
            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n   Attempting to HALF OPEN a closed vent\n"
                                                                     + "   or FULLY OPEN a half-open vent.\n");
            DisplayCurrentSystemTime(bioDome);

            for (int i = 0; i < 4; i++)
            {

                // Change the state of the ventilation unit with the highest 
                // to designation that is currently 'Closed' to 'Half-Open'
                if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Closed"))
                {
                    BioDomeControls.bioDomeControlUnits[i].SetState("Half-Open");
                    stateChange = 1;

                    // If the control is Vent 1 do...
                    if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 1 - Zone 1"))
                    {
                        bioDome.lblBioVent1Open.BackColor = Color.LightGray;
                        bioDome.lblBioVent1HalfOpen.BackColor = Color.Orange;
                        bioDome.lblBioVent1Closed.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 1 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.ORGBLK, "Half-Open\n\n");

                        // If the control is Vent 2 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 2 - Zone 1"))
                    {
                        bioDome.lblBioVent2Open.BackColor = Color.LightGray;
                        bioDome.lblBioVent2HalfOpen.BackColor = Color.Orange;
                        bioDome.lblBioVent2Closed.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 2 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.ORGBLK, "Half-Open\n\n");

                        // If the control is Vent 3 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 3 - Zone 2"))
                    {
                        bioDome.lblBioVent3Open.BackColor = Color.LightGray;
                        bioDome.lblBioVent3HalfOpen.BackColor = Color.Orange;
                        bioDome.lblBioVent3Closed.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 3 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.ORGBLK, "Half-Open\n\n");

                        // If the control is Vent 4 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 4 - Zone 2"))
                    {
                        bioDome.lblBioVent4Open.BackColor = Color.LightGray;
                        bioDome.lblBioVent4HalfOpen.BackColor = Color.Orange;
                        bioDome.lblBioVent4Closed.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 4 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.ORGBLK, "Half-Open\n\n");
                    }

                    // If no ventilation units are 'Closed', try to change the state of 
                    // the ventilation unit with the highest designation that is 
                    // currently 'Half-Open' to 'Open'	
                }
                else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Half-Open"))
                {
                    BioDomeControls.bioDomeControlUnits[i].SetState("Open");
                    stateChange = 1;

                    // If the control is Vent 1 do...
                    if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 1 - Zone 1"))
                    {
                        bioDome.lblBioVent1Open.BackColor = Color.Red;
                        bioDome.lblBioVent1HalfOpen.BackColor = Color.LightGray;
                        bioDome.lblBioVent1Closed.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 1 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "Open\n\n");

                        // If the control is Vent 2 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 2 - Zone 1"))
                    {
                        bioDome.lblBioVent2Open.BackColor = Color.Red;
                        bioDome.lblBioVent2HalfOpen.BackColor = Color.LightGray;
                        bioDome.lblBioVent2Closed.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 2 - Zone 1\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "Open\n\n");

                        // If the control is Vent 3 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 3 - Zone 2"))
                    {
                        bioDome.lblBioVent3Open.BackColor = Color.Red;
                        bioDome.lblBioVent3HalfOpen.BackColor = Color.LightGray;
                        bioDome.lblBioVent3Closed.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 3 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "Open\n\n");

                        // If the control is Vent 4 do...
                    }
                    else if (BioDomeControls.bioDomeControlUnits[i].GetName().Equals("Ventilation Unit 4 - Zone 2"))
                    {
                        bioDome.lblBioVent4Open.BackColor = Color.Red;
                        bioDome.lblBioVent4HalfOpen.BackColor = Color.LightGray;
                        bioDome.lblBioVent4Closed.BackColor = Color.LightGray;
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLU, "\n\nVentilation Unit 4 - Zone 2\n");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, " has been switched to ");
                        bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "Open\n\n");
                    }
                }
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        // Method changes the state of one system control to reduce the temperature  in the Bio-Dome
        public static void ManageTemperatureTooHigh(BioDomeSimulator bioDome)
        {
            TurnOffBioDomeHeater(bioDome);
            DisplayControlsInUse(bioDome);
            if (stateChange < 1)
            {
                OpenBioDomeVent(bioDome);
                DisplayControlsInUse(bioDome);
            }
            if (stateChange < 1)
            {
                TurnOnBioDomeSprinkler(bioDome);
                DisplayControlsInUse(bioDome);
            }
            if (stateChange < 1)
            {
                MessageBox.Show(Constants.CRITICAL_HIGH_TEMPERATURE, "Critical High Temperature Warning!");
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        // Method changes the state of one system control to increase the temperature in the Bio-Dome 
        public static void ManageTemperatureTooLow(BioDomeSimulator bioDome)
        {
            CloseBioDomeVent(bioDome);
            DisplayControlsInUse(bioDome);
            if (stateChange < 1)
            {
                TurnOffBioDomeSprinkler(bioDome);
                DisplayControlsInUse(bioDome);
            }
            if (stateChange < 1)
            {
                TurnOnBioDomeHeater(bioDome);
                DisplayControlsInUse(bioDome);
            }
            if (stateChange < 1)
            {
                MessageBox.Show(Constants.CRITICAL_LOW_TEMPERATURE, "Critical Low Temperature Warning!");
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        // Method changes the state of one system control to reduce the humidity in the Bio-Dome 
        public static void ManageHumidityTooHigh(BioDomeSimulator bioDome)
        {
            TurnOffBioDomeSprinkler(bioDome);
            DisplayControlsInUse(bioDome);
            if (stateChange < 1)
            {
                OpenBioDomeVent(bioDome);
                DisplayControlsInUse(bioDome);
            }
            if (stateChange < 1)
            {
                MessageBox.Show(Constants.CRITICAL_HIGH_HUMIDITY, "Critical High Moisture Warning!");
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        // Method changes the state of one system control to increase the humidity in the Bio-Dome 
        public static void ManageHumidityTooLow(BioDomeSimulator bioDome)
        {
            TurnOnBioDomeSprinkler(bioDome);
            DisplayControlsInUse(bioDome);
            if (stateChange < 1)
            {
                CloseBioDomeVent(bioDome);
                DisplayControlsInUse(bioDome);
            }
            if (stateChange < 1)
            {
                MessageBox.Show(Constants.CRITICAL_LOW_HUMIDITY, "Critical Low Moisture Warning!");
            }
        }

        //##########################################################################################################
        //##########################################################################################################

        // Method changes the state of one system control to reduce the air flow speed in the Bio-Dome 
        public static void ManageAirFlowTooHigh(BioDomeSimulator bioDome)
        {
            CloseBioDomeVent(bioDome);
            DisplayControlsInUse(bioDome);
            if (stateChange < 1)
            {
                //bioDome.timLapsedSimulatorTime.Stop();
                MessageBox.Show(Constants.CRITICAL_HIGH_AIR_FLOW, "Critical High Air Flow Warning!");
                //bioDome.timLapsedSimulatorTime.Start();
            }
        }

        //##########################################################################################################
        //##########################################################################################################


        // Method compares the expected results against the actual results 
        // derived from running the testcase.
        public static void CompareExpectedResultsToActualResults(BioDomeSimulator bioDome, 
                           RichTextBox logging, RichTextBox expected, RichTextBox actual)
        {
            bioDome.Append(logging, Constants.BLU, "\n   Comparing 'Expected Results' to 'Actual Results'.\n");
            TestTools.DisplayCurrentSystemTime(bioDome);

            //string expected_results = expected.SelectionLength = 
        }

        //##########################################################################################################
        //##########################################################################################################


        public static void StringFromRichTextBox(RichTextBox rtb1, RichTextBox rtb2)
        {
            //TextRange textRange = new TextRange(
            // TextPointer to the start of content in the RichTextBox.

            object fred = new object();
            fred = rtb1.Text;
            string frank = rtb1.Text;
            string freddy = rtb2.Text;



            Console.WriteLine("\n\n\nContents of expected rtb = " + frank + "\n\n\n");
            Console.WriteLine("\n\n\nContents of current rtb = " + freddy + "\n\n\n");
            Console.WriteLine("\n\n\nContents of object fred = " + fred + "\n\n\n");


            //rtb.Document.ContentStart,
            // TextPointer to the end of content in the RichTextBox.
            //rtb.Document.ContentEnd
            // );

            // The Text property on a TextRange object returns a string
            // representing the plain text content of the TextRange.
        }
    }
}
