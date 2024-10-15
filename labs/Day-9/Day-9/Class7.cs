using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    internal class Class7
    {
        public static void Main()
        {
            //StreamWriter sw = new StreamWriter("Sample.txt");
            //sw.WriteLine("Vikash is being written from main method");
            //sw.Flush();
            //sw.Close();

            //StreamReader sr = new StreamReader("Sample.txt");
            //sr.BaseStream.Seek(0,SeekOrigin.Begin);
            //string str=sr.ReadLine();
            //Console.WriteLine(str);
            //sr.Close();

            //FileStream fwrite = new FileStream("Sample.txt",FileMode.Create,FileAccess.Write,FileShare.None);
            string textToWrite = "Hi I am viaksh coming with filestream";
            //byte[] writeArr = Encoding.UTF8.GetBytes(textToWrite);
            //fwrite.Write(writeArr,0, textToWrite.Length);
            //fwrite.Close();

            //FileStream fRead = new FileStream("Sample.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            //byte[] ReadArr = new byte[textToWrite.Length];
            //int count;

            //while ((count=fRead.Read(ReadArr,0, ReadArr.Length))>0)
            //{
            //    Console.WriteLine(Encoding.UTF8.GetString(ReadArr,0,count));
            //}
            //fRead.Close();

            //TextWriter tw = File.CreateText("file.txt");
            //tw.WriteLine("c# file handling");
            //tw.Close();
            //TextReader tr = File.OpenText("file.txt");
            //Console.WriteLine(tr.ReadToEnd());
            //tr.Close();

            BinaryWriter bw = new BinaryWriter(File.Open("Binaryfile.txt",FileMode.Create));
            bw.Write(textToWrite);
            bw.Close();

            BinaryReader br = new BinaryReader(File.Open("Binaryfile.txt", FileMode.Open));
            Console.WriteLine(br.ReadString());
            br.Close();
        }
    }
}
