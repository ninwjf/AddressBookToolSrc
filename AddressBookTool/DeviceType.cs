using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookTool
{
    public class DeviceType
    {
        private string displayText;

        public string DisplayText
        {
            get { return displayText; }
        }

        private byte value;

        public byte Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public DeviceType(byte value, string displayText)
        {
            this.value = value;
            this.displayText = displayText;
        }
    }
}