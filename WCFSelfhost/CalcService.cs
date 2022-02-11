using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFSelfhost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalcService" in both code and config file together.
    public class CalcService : ICalcService
    {
        public string ConcatIntValue(int value1, int value2)
        {
            int result = value1 + value2;
            return string.Format("Your Value is {0}", result);
        }

        public string ConcatStringValue(string value1, string value2)
        {
            return string.Format("Your Value is {0}{1}", value1, value2);
        }

       
    }
}
