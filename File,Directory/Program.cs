using System;
using System.IO;

namespace File_Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\HP\source\repos\File,Directory\File,Directory/Files");
            if (!File.Exists(@"C:\Users\HP\source\repos\File,Directory\File,Directory"))
            {
                {
                    File.Create(@"C:\Users\HP\source\repos\File,Directory\File,Directory");
                }
            }
        }
    }
}
