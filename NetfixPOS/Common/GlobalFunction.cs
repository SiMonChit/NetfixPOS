using NetfixPOS.Models;
using NetfixPOS.Models.DataSetFile;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetfixPOS.Common
{
    public class GlobalFunction
    {
        public GlobalFunction()
        {
            Check_IsRegister();
        }
        public static ds_Users.UsersRow LoginUser;
        public static ds_Permission.UserPermissionDataTable LoginUser_Permission;
        public static decimal sevTax = 0;
        public static DateTime saleDate;
        public static dsNewSetup.tbl_GE_AppInfoDataTable appInfo;

        public static int Check_IsRegister()
        {
            App_Information_Check app_check = new App_Information_Check();
            return app_check.Check_IsRegister();
        }
        public static string GetComputerName()
        {
            return Dns.GetHostName();
        }
        public static string GetIPAddress()
        {
            string hostName = GetComputerName();
            return Dns.GetHostByName(hostName).AddressList[0].ToString();
        }

        public static Image ConvertByteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            if (data.Length == 0) return null;
            return Image.FromStream(ms);
        }

        public static byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                //img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        public static string PasswordEncrypt(string data)
        {
            MD5CryptoServiceProvider pro = new MD5CryptoServiceProvider();
            UTF8Encoding utf = new UTF8Encoding();
            byte[] b = pro.ComputeHash(utf.GetBytes(data));

            return Convert.ToBase64String(b);
        }

        public static string BurmeseNumber(char[] num)
        {
            String[] burmese_num = { "၀", "၁", "၂", "၃", "၄", "၅", "၆", "၇", "၈", "၉" };
            string transalate_string = "";
            int j;

            for (int i = 0; i < num.Length; i++)
            {
                j = Convert.ToInt32(char.ToString(num[i]));
                transalate_string += burmese_num[j];
            }
            return transalate_string;
        }

        public static void GridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                DataGridView gridView = sender as DataGridView;
                if (gridView != null)
                {
                    gridView.RowHeadersWidth = 50;
                    foreach (DataGridViewRow row in gridView.Rows)
                    {
                        gridView.Rows[row.Index].HeaderCell.Value = (row.Index + 1).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            try
            {
                var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
                return Encoding.UTF8.GetString(base64EncodedBytes, 0, base64EncodedBytes.Length);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return "";
        }

        public static void WriteLog(string LogMessage)
        {
            if (LogMessage == "")
                return;

            string tempfolder = ReadSetting("LogPath");
            string logfolder = tempfolder + "log";
            if (!Directory.Exists(logfolder))
            {
                Directory.CreateDirectory(logfolder);
            }

            string logfilename = DateTime.Now.ToString("yyyy-MM-dd") + ".log";

            string[] start = { DateTime.Now + ": " + LogMessage };
            File.AppendAllLines(tempfolder + @"\log\" + logfilename, start);
        }

        public static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                var result = appSettings[key] ?? string.Empty;
                return result;
            }
            catch (ConfigurationErrorsException exc)
            {
                Console.WriteLine(exc.Message);
            }
            return string.Empty;
        }

        public static void DeleteOldLogFiles(string directoryPath)
        {

            DateTime currentDate = DateTime.Now;
            int daysThreshold = Convert.ToInt32(ReadSetting("DeleteLogDay"));
            // Calculate the date threshold (last month) with days taken into account
            DateTime thresholdDate = currentDate.AddMonths(0).AddDays(-daysThreshold);

            // Get a list of all files in the folder
            string[] allFiles = Directory.GetFiles(directoryPath);

            foreach (string filePath in allFiles)
            {
                // Get the creation date of the file
                DateTime creationDate = File.GetCreationTime(filePath);

                // Check if the file's creation date is older than the threshold date
                if (creationDate < thresholdDate)
                {
                    File.Delete(filePath);
                }
            }
        }
    }
}
