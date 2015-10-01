using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_SystemFile
{
    public class Directory : File
    {
        List<File> file = new List<File>();

        public Directory(string name, Directory father)
            : base(name, father)
        {
            this.rights = 4;
        }
        public override bool mkdir(string name)
        {
            file.Add(new Directory(name, this));
            return true;
            //Only Directory
        }
        public override List<File> ls()
        {
            return this.file;
        }
        public override File cd(string name)
        {
            bool etbil = true;
            int i = 0;
            File NewCurrentFile = null;
            while (etbil == true && i < file.Count)
            {
                if (name == file[i].name)
                {
                    NewCurrentFile = file[i];
                    etbil = false;
                }
                i++;
            }
            return NewCurrentFile;
        }
        public override bool isFile()
        {
            return false;
        }
        public override bool isDirectory()
        {
            return true;
        }
        public override bool renameTo(string name, string newName)
        {
            bool exist = false;
            int j = 0;
            for (int i = 0; i < file.Count() && exist == false; i++)
            {
                exist = name == file[i].name;
                if (exist == true)
                {
                    j = i;
                }
            }
            if (exist == true)
            {
                bool live = false;
                for (int x = 0; x < file.Count() && live == false; x++)
                {
                    live = newName == file[x].name;
                }
                if (live == false)
                {

                    file[j].name = newName;
                    return true;
                }
            }
            return false;
        }
        public bool renameTo(string newName)
        {
            return false;
        }
        public override bool createNewFile(string name)
        {
            file.Add(new File(name, this));
            return true;
            //Only File
        }
        public bool delete(string name)
        {
            file.Remove(new File(name, this));
            return true;
        }
    }
}
