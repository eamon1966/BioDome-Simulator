using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDomeSimulator
{
   /* class ErrorHandler
    {
        //##########################################################################################################

        // Checks that the inputed Climate data is in the specified format and in range
        public void CheckForValidInput(BioDomeSimulator bioDome)
        {

            // Checks for a valid temperature format and range
            //CheckForValidTemperatureValue();

            // Checks for a valid humidity format and range		
            //CheckForValidHumidityValue();

            // Checks for a valid wind speed format and range
            //CheckForValidWindSpeedValue();

            //CheckForValidBioDomeControls();

            if (Constants.emptyValue == 3)
            {

                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   Data Set Empty:  No values were entered for\n"
                                                                         + "   temperature, humidity or wind speed...\n\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   ***************************************************\n\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   No values were entered for:\n\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   (1) ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.REDBLK, "Temperature\n\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   (2) ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLUYEL, "Humidity\n\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   (3) ");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.GREBLK, "Wind Speed\n\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   At least one of the three values:\n"
                                                                         + "   (1) Temperature, (2) Humidity or\n"
                                                                         + "   (3) Wind Speed must be entered in\n"
                                                                         + "   order for a valid test to be run...\n\n");
                bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, "   ***************************************************\n\n");

                Constants.emptyValue = 0;
            }

            //BioDomeApp.tfStatus.setText("");

            //Constants.errorReport = Constants.tempError.toString();
        }

        //##########################################################################################################

        // Outputs the list of errors found when trying to implement user-inputed climate values
        public static void OutputValidationErrorReport(BioDomeSimulator bioDome)
        {

            String completeErrRpt = Constants.USER_VALIDATION_REPORT_HEADER + Constants.errorReport;

            bioDome.Append(bioDome.rtbBdlLoggingWindow, Constants.BLK, completeErrRpt + "\n");
            bioDome.tpBioLoggingWindow.setText(Constants.errorReport);
            Constants.tempError.setLength(0);

        }


        //##########################################################################################################

        public void CheckForValidBioDomeControls(BioDomeSimulator bioDome)
        {
        }

        //##########################################################################################################
        
        // Method checks if all temperature affecting (heat reducing) control units are active. 
        // The method counts the number that have been deployed and returns the number being used.

        public int TemperatureHotTest()
        {

            int criticalHotTest = 0;

            // Count the number of Greenhouse ventilation units that are 'Open'
            for (int i = 0; i < 4; i++)
            {
                if (BioDomeControls.bioDomeControlUnits[i].getState().equals("Open"))
                {
                    Constants.ventStateCounter++;
                    criticalHotTest += Constants.ventStateCounter;
                }
            }

            // Count the number of Greenhouse radiator units that are 'Off'
            for (int i = 4; i < 8; i++)
            {
                if (Controls.bioDomeControlUnits[i].getState().equals("Off"))
                {
                    Constants.radStateCounter++;
                    criticalHotTest += Constants.radStateCounter;
                }
            }

            // Count the number of Greenhouse sprinkler units that are 'On'
            for (int i = 8; i < 10; i++)
            {
                if (Controls.bioDomeControlUnits[i].getState().equals("On"))
                {
                    Constants.sprinkStateCounter++;
                    criticalHotTest += Constants.sprinkStateCounter;
                }
            }

            return criticalHotTest;
        }
        //##########################################################################################################

        public static void HeatSeverityDisplay()
        {

            int heatSeverity = TemperatureHotTest();

            if (heatSeverity == 10)
            {

                Controls.Append(Constants.RED, Constants.CRITICAL_HOT_WARNING);
                BioDomeApp.lblBioCurTempTooHot.setBackground(Color.RED);
                BioDomeApp.lblBioCurTempOptimal.setBackground(Color.LIGHT_GRAY);
                BioDomeApp.lblBioCurTempTooCold.setBackground(Color.LIGHT_GRAY);

            }
            else if (heatSeverity >= 5 && heatSeverity < 10)
            {

                Controls.Append(Constants.ORG, Constants.MODERATE_HOT_WARNING);
                BioDomeApp.lblBioCurTempTooHot.setBackground(Color.ORANGE);
                BioDomeApp.lblBioCurTempOptimal.setBackground(Color.LIGHT_GRAY);
                BioDomeApp.lblBioCurTempTooCold.setBackground(Color.LIGHT_GRAY);

            }
            else
            {

                Controls.Append(Constants.YEL, Constants.LOW_HOT_WARNING);
                BioDomeApp.lblBioCurTempTooHot.setBackground(Color.YELLOW);
                BioDomeApp.lblBioCurTempOptimal.setBackground(Color.LIGHT_GRAY);
                BioDomeApp.lblBioCurTempTooCold.setBackground(Color.LIGHT_GRAY);
            }
        }

        //##########################################################################################################

        public static void TooColdHandler()
        {

            int ventStateCounter = 0;
            int radStateCounter = 0;
            int sprinkStateCounter = 0;

        }

        //##########################################################################################################

        public static void TooWetHandler()
        {

            int ventStateCounter = 0;
            int radStateCounter = 0;
            int sprinkStateCounter = 0;

        }

        //##########################################################################################################

        public static void TooDryHandler()
        {

            int ventStateCounter = 0;
            int radStateCounter = 0;
            int sprinkStateCounter = 0;

        }

        //##########################################################################################################

        public static void TooWindyHandler()
        {

            int ventStateCounter = 0;
            int radStateCounter = 0;
            int sprinkStateCounter = 0;

        }

        //##########################################################################################################

        public static void SelectHandler()
        {



        }
        //##########################################################################################################
   }*/
}
