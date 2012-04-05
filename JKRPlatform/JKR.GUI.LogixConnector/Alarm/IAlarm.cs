using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace JKR.GUI.LogixConnector.Alarm
{
    public interface IAlarm
    {
        // Events
        event DelegateAlarm AlarmEvent;

        // Methods
        void InitAlarm();

        // Properties
        string AlarmContent { get; set; }
        DataSet AlarmData { get; set; }
        Form AlarmForm { get; set; }
        Hashtable AlarmList { get; set; }
        bool AlarmRight { get; set; }
        string AlarmTitle { get; set; }
        AlarmTypeEnum.AlarmType AlarmType { get; set; }
        UserControl AlarmUserControl { get; set; }
        bool HasAlarm { get; set; }

        // Nested Types
        public delegate void DelegateAlarm(IAlarm alarm);
    }


}
