using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_SystemFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string command;
            string[] listCommand;
            bool stop = true;
            Directory C = new Directory ("C:", null);
            File CurrentFile = C;

            while (stop == true)
            {
                command = Console.ReadLine();
                listCommand = command.Split(' ');
                if (listCommand[0] == "mkdir")
                    Console.WriteLine(CurrentFile.mkdir(listCommand[1]));
                if (listCommand[0] == "create")
                    Console.WriteLine(CurrentFile.createNewFile(listCommand[1]));
                if (listCommand[0] == "ls" && CurrentFile.ls() != null)
                {
                    foreach (File found in CurrentFile.ls())
                    {
                        Console.WriteLine(found.name + " " + found.GetType() + " " + found.rights);
                    }
                }
                if (listCommand[0] == "file")
                    if (CurrentFile.isFile() == true)
                        Console.WriteLine("Vous êtes dans un fichier!");
                    else if (CurrentFile.isFile() == false)
                        Console.WriteLine("Vous n'êtes pas dans un fichier!");
                if (listCommand[0] == "directory")
                    if (CurrentFile.isDirectory() == true)
                        Console.WriteLine("Vous êtes dans un répertoire!");
                    else if (CurrentFile.isDirectory() == false)
                        Console.WriteLine("Vous n'êtes pas dans un répertoire!");
                if (listCommand[0] == "name")
                    Console.WriteLine(CurrentFile.getName());
                if (listCommand[0] == "cd")
                    CurrentFile = CurrentFile.cd(listCommand[1]);
                if (listCommand[0] == "parent")
                    CurrentFile=CurrentFile.getParent();
                
                if (listCommand[0] == "path")
                    Console.WriteLine("PATH : " + CurrentFile.getPath());
                if (listCommand[0] == "rename" && listCommand[1] != null && listCommand[2] != null)
                    Console.WriteLine(CurrentFile.renameTo(listCommand[1], listCommand[2]));              
                if (listCommand[0] == "delete")
                    Console.WriteLine(C.delete(listCommand[1]));
                //if (listCommand[0] == "root")
                //    Console.WriteLine(C.root(listCommand[1]));
                //if (listCommand[0] == "chmod")
                //    Console.WriteLine(C.chmod(listCommand[1]));
                //if (listCommand[0] == "search")
                //    Console.WriteLine(CurrentFile.search(listCommand[1]));
            }
        }
    }
}
