using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDomeSimulator
{
    class TimerManagement
    {
        public static int sessionTimerFlag = 0;
        public static int throttleTimerFlag = 0;
        public static int sessionInterval = 1000;
        public static int throttleInterval = 10000;

        public static void GenerateSessionTimer(BioDomeSimulator bioDome)
        {
            // Create a System Timer to note elapsed Simulator Session time
            if (sessionTimerFlag < 1)
            {
                bioDome.sessionTimer = new System.Timers.Timer();
                ((System.ComponentModel.ISupportInitialize)(bioDome.sessionTimer)).BeginInit();
                // sessionTimer 
                bioDome.sessionTimer.Enabled = true;
                bioDome.sessionTimer.Interval = sessionInterval;
                bioDome.sessionTimer.SynchronizingObject = bioDome;
                bioDome.sessionTimer.Elapsed += new System.Timers.ElapsedEventHandler(bioDome.sessionTimer_Elapsed);
                ((System.ComponentModel.ISupportInitialize)(bioDome.sessionTimer)).EndInit();
                sessionTimerFlag = 1;
            }
        }

        public static void GenerateThrottleTimer(BioDomeSimulator bioDome)
        {
            if (throttleTimerFlag < 1)
            {
                bioDome.autoRunThrottleTimer = new System.Timers.Timer();
                ((System.ComponentModel.ISupportInitialize)(bioDome.autoRunThrottleTimer)).BeginInit();
                // autoRunThrottleTimer
                bioDome.autoRunThrottleTimer.Enabled = true;
                bioDome.sessionTimer.Interval = throttleInterval;
                bioDome.autoRunThrottleTimer.SynchronizingObject = bioDome;
                bioDome.autoRunThrottleTimer.Elapsed += new System.Timers.ElapsedEventHandler(bioDome.autoRunThrottleTimer_Elapsed);
                ((System.ComponentModel.ISupportInitialize)(bioDome.autoRunThrottleTimer)).EndInit();
                throttleTimerFlag = 1;
            }

        }
    }
}
