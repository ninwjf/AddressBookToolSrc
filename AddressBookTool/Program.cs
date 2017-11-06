using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookTool
{
    static class Program
    {
        /// <summary>
        /// 如果該目錄不存在的話，試著建立目錄
        /// </summary>
        /// <param name="folderPath">目錄路徑</param>
        private static void CreateFolderIfNotExist(string folderPath)
        {
            bool exists = System.IO.Directory.Exists(folderPath);
            if (!exists)
                System.IO.Directory.CreateDirectory(folderPath);
        }

        /// <summary>
        /// 取得應用程式可以存取的目錄路徑
        /// </summary>
        /// <returns>應用程式可以存取的目錄路徑</returns>
        public static string GetAppFolderPath()
        {
            string folderPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                              + @"\" + System.AppDomain.CurrentDomain.FriendlyName.Split('.').First();
            CreateFolderIfNotExist(folderPath);
            return folderPath;
        }

        /// <summary>
        /// 取得存放 addressbook.xml 的暫存目錄路徑
        /// </summary>
        /// <returns>存放 addressbook.xml 的暫存目錄路徑</returns>
        public static string GetAddressBookTempFolderPath()
        {
            string folderPath = GetAppFolderPath() + @"\addressbook";
            CreateFolderIfNotExist(folderPath);
            return folderPath;
        }

        /// <summary>
        /// 取得存放 cardlist.xml 的暫存目錄路徑
        /// </summary>
        /// <returns>存放 cardlist.xml 的暫存目錄路徑</returns>
        public static string GetCardListTempFolderPath()
        {
            string folderPath = GetAppFolderPath() + @"\cardlist";
            CreateFolderIfNotExist(folderPath);
            return folderPath;
        }

        /// <summary>
        /// 取得存放 screensaver.jpg 的暫存目錄路徑
        /// </summary>
        /// <returns>存放 screensaver.jpg 的暫存目錄路徑</returns>
        public static string GetScreenSaverTempFolderPath()
        {
            string folderPath = GetAppFolderPath() + @"\screensaver";
            CreateFolderIfNotExist(folderPath);
            return folderPath;
        }

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
