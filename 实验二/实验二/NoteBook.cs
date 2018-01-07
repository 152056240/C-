using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;

namespace 实验二
{
   
    class NoteBook:ICreate,IOpen,IClassify,IManage,ISave
    {
        public void Create()
        {
            StreamWriter sw = new StreamWriter(@"D:/C#/note.txt", true);
            Console.WriteLine("新建笔记成功");    
        }
        public void Open()
        {
            String file = @"D:/C#/note.txt";
            FileInfo fi = new FileInfo(file);
            Process p = new Process();
            p.StartInfo.FileName = file;
            p.StartInfo.WorkingDirectory = fi.DirectoryName;
            p.Start();
            Console.WriteLine("打开笔记成功");
        }
        public void Save()
        {
            Console.WriteLine("请输入编辑的内容：");
            String text = Console.ReadLine();
            StreamWriter sw = new StreamWriter(@"D:/C#/note.txt");
            sw.WriteLine(text);
            Console.WriteLine("保存笔记成功");
            sw.Close();
        }
        public void Classify()
        {
            Console.WriteLine("新建分类成功");
        }
        public void Manage()
        {
            Console.WriteLine("管理分类成功");
        }
    }
}