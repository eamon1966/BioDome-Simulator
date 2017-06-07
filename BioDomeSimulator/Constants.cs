using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioDomeSimulator
{
    class Constants
    {
        public const string CRITICAL_HIGH_TEMPERATURE = "   ******  Warning: Situation Critical  ******\n\n"
                                                      + "   System is over-heating! No system resources\n"
                                                      + "   available to reduce temperature. All heat \n"
                                                      + "   reduction resources have been deployed...\n";

        public const string CRITICAL_LOW_TEMPERATURE = "   ******  Warning: Situation Critical  ******\n\n"
                                                     + "   System temperature is too low! No resources\n"
                                                     + "   are available to increase temperature. All heat\n"
                                                     + "   producing resources have been deployed...\n";

        public const string CRITICAL_HIGH_HUMIDITY = "   ******  Warning: Situation Critical  ******\n\n"
                                                   + "   System moisture level is too high! No system\n"
                                                   + "   controls available to reduce humidity levels.\n"
                                                   + "   All moisture producing resources have been already\n"
                                                   + "   deployed...\n";

        public const string CRITICAL_LOW_HUMIDITY = "   ******  Warning: Situation Critical  ******\n\n"
                                                  + "   System moisture level is too low! No system\n"
                                                  + "   controls available to increase humidity levels.\n"
                                                  + "   All moisture reducing resources have been already\n"
                                                  + "   deployed...\n";

        public const string CRITICAL_HIGH_AIR_FLOW = "   *****Warning: Situation Critical * ****\n"
                                                   + "   System air flow speed is too high! No system\n"
                                                   + "   controls available to reduce air flow speed.\n"
                                                   + "   All air flow control resources have already\n"
                                                   + "   been deployed...\n";

        public const string SYSTEM_TURNED_OFF = "\n   ***************************************\n\n"
                                              + "      The System has been deactivated\n\n"
                                              + "   All controls are now off-line and the\n"
                                              + "   current system status value is 'OFF'\n"
                                              + "   ***************************************\n";

        public const string SYSTEM_TURNED_ON = "\n   ***************************************************\n\n"
                                             + "      The System has been activated\n\n"
                                             + "   All controls are now on-line and the\n"
                                             + "   current system status value is 'ON'\n"
                                             + "   All controls are either Closed or Off\n"
                                             + "   and external climate value are set to\n"
                                             + "   within their Nominal values\n\n"
                                             + "   ***************************************************\n\n";

        public const string SYSTEM_IS_OFF = "\n   ***************************************************\n"
                                          + "   System is currently OFF!\n"
                                          + "   Turn system ON before continuing...\n"
                                          + "   ***************************************************\n";

        public const string FULL_STATE_DISPLAY_BANNER_TOP = "\n   ***************************************************\n"
                                                          + "   *                                                 *\n"
                                                          + "   *          Current System Control States          *\n"
                                                          + "   *                                                 *\n"
                                                          + "   ***************************************************\n\n";

        public const string FULL_STATE_DISPLAY_BANNER_BOT = "\n   ***************************************************\n";

        public const string USER_VALIDATION_REPORT_HEADER = "   ****       User Input Validation Report        ****\n\n";

        public const string SYSTEM_IS_RUNNING_IN_OPTIMAL_STATE = "\n   ***************************************************\n"
                                                               + "   No control changes were made to the system"
                                                               + "   as all controls are in their optimal states\n"
                                                               + "   for maximum operating effeciency\n"
                                                               + "   ***************************************************\n";

        public static string errorReport = "";

        public const string BLK = "Black";
        public const string GRN = "Green";
        public const string RED = "Red";
        public const string BLU = "Blue";
        public const string ORG = "Orange";
        public const string YEL = "Yellow";
        public const string LYM = "Lime";
        public const string BLKWHT = "BlackWhite";
        public const string YELBLK = "YellowBlack";
        public const string GREBLK = "GreenBlack";
        public const string LIGREBLK = "LimeBlack";
        public const string REDBLK = "RedBlack";
        public const string BLUYEL = "BlueYellow";
        public const string ORGBLK = "OrangeBlack";

        public static int temperature = 0;
        public static int initialTemperature = 68; // mid-range
        public static int lowTemperature = 48;
        public static int highTemperature = 85;

        public static int humidity = 0;
        public static int initialHumidity = 55; // mid-range
        public static int lowHumidity = 35;
        public static int highHumidity = 75;

        public static int windSpeed = 0;
        public static int initialWindSpeed = 3; // mid-range
        public static int minimumWindSpeed = 0;
        public static int maximumSafeWindSpeed = 10;

        public static string greenActiveOn = "0,255,0";
        public static string greyActiveOff = "192,192,192";

        public static string yellowWarningIndicator = "255,255,0";
        public static string orangeWarningIndicator = "255,165,0";
        public static string redWarningIndicator = "255,0,0";

        public static int failFlag = 0;
        public static StringBuilder tempError = new StringBuilder();
        public static int SystemState = 0;

        // Variable holding the number of empty values of:
        // temperature, humidity and wind speed
        public static int emptyValue = 0;

        public static int ventStateCounter = 0;
        public static int radStateCounter = 0;
        public static int sprinkStateCounter = 0;

        public static int testCaseNumber = 10001;

        public const int MAX_TEMP_CONTROLS = 14;
        public const int MAX_HUMID_CONTROLS = 10;
        public const int MAX_WIND_CONTROLS = 8;

        //########################################################################
    }
}
