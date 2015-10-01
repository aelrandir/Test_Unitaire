using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_SystemFile
{
    public class File
    {
        public string name;
        public int rights;
        public Directory father;

        public File (string name, Directory father)
        {
            this.name = name;
            this.father = father;
            rights = 4;
        }
        public virtual bool mkdir(string name)
        {
            return false;
        }
        public virtual bool createNewFile(string name)
        {
            return false;
        }
        public virtual List<File> ls()
        {
            return null;    
        }
        public virtual bool isFile()
        {
            return true;
        }
        public virtual bool isDirectory()
        {
            return false;
        }
        public string getPath()
        {
            Directory father2 = father;
            string path = this.name;
            while (father2 != null)
            {
                path = father2.name + "\\" + path;
                father2 = father2.father;
            }
            return path;
        }
        public virtual bool renameTo(string name, string newName)
        {
            return false;
        }
        public virtual File cd(string name)
        {
            return null;
        }
        public File getParent()
        {
            return father;
        }
        public string getName()
        {
            return this.name;
        }
        public bool canWrite()
        {
            return (rights & 2) > 0;
        }
        public bool canExecute()
        {
            return (rights & 1) > 0;
        }
        public bool canRead()
        {
            return (rights & 4) > 0;
        }
    }
}
