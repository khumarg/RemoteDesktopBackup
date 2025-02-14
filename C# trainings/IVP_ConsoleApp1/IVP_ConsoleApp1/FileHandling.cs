using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IVP_ConsoleApp1
{
    internal class FileHandling
    {
        FileStream fs;
        StreamWriter sw;
        StreamReader sr;
        FileInfo fi;
        DirectoryInfo di;
        public void FileCreate()
        {
            fs = new FileStream(@"C:\MyIVPFiles\MyData.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);

            sw.WriteLine("Welcome to File Handling");
            sw.WriteLine("This is IVP Data");

            sw.Flush();   // to clear the buffer for current writer.  
                          //.NET CORE automatically flushes but Framework
                          //does not and wont write in the file without flush.

            sw.Close();
            fs.Close();

            Console.WriteLine("Done!");
        }

        public void FileRead()
        {
            try
            {
                fs = new FileStream(@"C:\MyIVPFiles\MyData.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                Console.WriteLine(sr.ReadToEnd());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            finally
            {
                 sr.Close();
                 fs.Close();
            }
           
        }

        public void DirectoryDetails()
        {
            di = new DirectoryInfo(@"C:\Users\kgirdhar\Desktop\C# trainings\IVP_ConsoleApp1\IVP_ConsoleApp1");
            DirectoryInfo[] dirs = di.GetDirectories();
            FileInfo[] files = di.GetFiles();

            foreach(DirectoryInfo dir in dirs)
            {
                FileInfo[] fs = dir.GetFiles();
                Console.WriteLine("Directory: " + dir.Name);
                foreach (FileInfo file in fs)
                {
                    Console.WriteLine(file.Name + " - " + file.LastWriteTime + " - " + file.Extension);
                }
            }

            //foreach(var file in files)
            //{
            //    Console.WriteLine(file.Name + " - " + file.LastWriteTime + " - " + file.Extension);
            //}
        }
        public void DirectoryMethods()
        {
            di = new DirectoryInfo(@"C:\MyIVPFiles\NewDirectory");
            //di.Create();
            

            //DirectoryInfo subdir = di.CreateSubdirectory("NewSubDirectory");
            //Console.WriteLine($"{subdir.Name} Created!");

            di.Delete();
            Console.WriteLine("Folder Deleted...");
        }

        public void FileInfoMethods()
        {
            fi = new FileInfo(@"C:\MyIVPFiles\NewFile.txt");
            //fi.Create();

            Console.WriteLine(fi.FullName + " Created!");

            sw = fi.CreateText();
            sw.WriteLine("NewFile Text will be shown here in the file");

            sw.Close();
            sw.Dispose();

            sr = fi.OpenText();
            string str = "";

            while((str = sr.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
            sr.Close();
        }

        public void BinaryFileHandling()
        {
            fs = File.Open(@"C:\MyIVPFiles\Student.bin", FileMode.Open);
            //BinaryWriter bw = new BinaryWriter(fs);

            //bw.Write(10);
            //bw.Write("Nikhil");
            //bw.Write("Electrical");
            //bw.Write(78.5f);
            //bw.Write(true);

            BinaryReader br = new BinaryReader(fs);

            Console.WriteLine("Student ID: " + br.ReadInt32());
            Console.WriteLine("Student Name: " + br.ReadString());
            Console.WriteLine("Student Branch: " + br.ReadString());
            Console.WriteLine("Student Marks: " + br.ReadSingle());
            Console.WriteLine("Student Active Status: " + br.ReadBoolean());

            br.Close();
            //bw.Close();
            fs.Close();
        }

        public void FileMethods()
        {
            if(File.Exists(@"C:\MyIVPFiles\NewFile.txt"))
            {
                string[] lines = File.ReadAllLines(@"C:\MyIVPFiles\NewFile.txt");

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

                string newFileText = File.ReadAllText(@"C:\MyIVPFiles\NewFile.txt");

                Console.WriteLine(newFileText);
            } else
            {
                Console.WriteLine("Please create a file");
            }
        }
    }
}
