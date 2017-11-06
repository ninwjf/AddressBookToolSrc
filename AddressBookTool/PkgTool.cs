using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookTool
{
    class PkgTool
    {
        /// <summary>
        /// Convert an arbitrary file to a PKG format file.
        /// </summary>
        /// <param name="fromFolderPath">input folder path</param>
        /// <param name="toFilePath">output file path</param>
        public static void ToPkgFile(string fromFolderPath, string toFilePath)
        {
            lock (typeof(PkgTool))
            {
                try
                {
                    string[] cmd = new string[8];
                    cmd[0] = "pkgtool";
                    cmd[1] = "--version";
                    cmd[2] = "1";
                    cmd[3] = "--nor-partiton0-dir";
                    cmd[4] = fromFolderPath;
                    cmd[5] = "--no-partition";
                    cmd[6] = "-o";
                    cmd[7] = toFilePath;
                    NativeMethods.create_package_execute(8, cmd);
                }
                catch (Exception) { }
            }
        }
    }
}
