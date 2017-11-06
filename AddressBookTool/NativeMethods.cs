using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookTool
{
    internal static class NativeMethods
    {
        [DllImport("pkgtool.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool create_package_execute(int argc, string[] argv);
    }
}
