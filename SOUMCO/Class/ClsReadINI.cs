using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace SOUMCO.Class
{
    public class ClsReadINI
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;
        private const int VALUE_BUFFER = 511;
        private const int SECTION_BUFFER = (1024 * 16);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        //[DllImport("kernel32", CharSet = CharSet.Unicode)]
        //static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        //----
        //[DllImport("kernel32.dll")]
        //private static extern int GetPrivateProfileSectionNames(byte[] lpszReturnBuffer, int nSize, string lpFileName);
        //[DllImport("kernel32.dll")]
        //private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpReturnedString, int nSize, string lpFileName);
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, byte[] lpReturnedString, int nSize, string lpFileName);
        //[DllImport("kernel32.dll")]
        //private static extern bool WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);


        public ClsReadINI(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
         }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            //GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public string GetValue(string section, string key, string ifMissing)
        {
            byte[] by = new byte[VALUE_BUFFER];
            int n = GetPrivateProfileString(section, key, ifMissing, by, VALUE_BUFFER, Path);
            string s = Encoding.ASCII.GetString(by);
            return s.Substring(0, n);
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
    

