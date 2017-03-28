using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SimpleReminder
{
    public class Tools
    {

        public static bool IsFileOrFolderExist(string path)
        {
            bool result = false;

            return result;
        } 

        public static bool CreateFile(string path, string name)
        {
            bool result = false;

            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (IOException)
                {
                    result = false;
                }
            }

            if (result)
            {
                try
                {
                    File.Create(string.Format("{0}{1}", path, name));
                }
                catch (UnauthorizedAccessException)
                {
                    result = false;
                }
            }

            return result;
        }

        public static bool GetFile(string path, string name)
        {
            bool result = false;

            return result;
        }


        public static bool WriteFile(string path, string name, XmlDocument datas)
        {
            bool result = false;

            if (!Tools.IsFileOrFolderExist(string.Format("{0}{1}", path, name)))
            {
                Tools.CreateFile(path, name);
                
            }

            return result;
        }

    }
}