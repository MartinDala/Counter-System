using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Media;

namespace JARVIS
{
    public partial class AlarmClock : Form
    {
        enum AMPM
        {
            am,
            pm
        }

        bool dragForm = false;
        Point ofdFormLocation;
        Point oldCursorLocation;
        string alarmMessage = "";
        SoundPlayer player = new SoundPlayer();
        Stream sound;

        bool _onAlarm = false;
        bool _activateAlarm = false;

        string alarmHour = "00";
        string alarmMinute = "00";
        AMPM _alarmAMPM = AMPM.am;

        string alarmAMPM
        {
            get
            {
                if (_alarmAMPM == AMPM.am)
                {
                    return System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.AMDesignator;
                }
                else
                {
                    return System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.PMDesignator;
                }
            }
        }

        string fullAlarmTimeStr
        {
            get
            {
                return string.Format("{0} : {1} {2}", alarmHour.PadLeft(2, '0'), alarmMinute.PadLeft(2, '0'), alarmAMPM);
            }
        }

        bool OnAlarm
        {
            get
            {
                return _onAlarm;
            }
            set
            {
                _onAlarm = value;
                if (_onAlarm)
                {

                }
                else
                {
                    
                }
            }
        }

        public AlarmClock()
        {
            InitializeComponent();
        }

        private void AlarmClock_Load(object sender, EventArgs e)
        {

        }
    }
}
