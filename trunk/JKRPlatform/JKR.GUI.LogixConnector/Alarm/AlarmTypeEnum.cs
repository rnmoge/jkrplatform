using System;
using System.Collections.Generic;
using System.Text;

namespace JKR.GUI.LogixConnector.Alarm
{
    public class AlarmTypeEnum
    {
        // Methods
        public AlarmTypeEnum();

        // Nested Types
        public enum AlarmType
        {
            OverWeight,     //超重预警
            OverTime,       //迟还柜超期预警
            OverExempt      //免柜超期预警
        }

    }
}
