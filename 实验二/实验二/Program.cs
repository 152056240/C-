using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace 实验二
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*                                  *");
            Console.WriteLine("*    1.新建笔记     2.打开笔记     *");
            Console.WriteLine("*    3.新建分类     4.管理分类     *");
            Console.WriteLine("*    5.保存笔记     6.退出         *");
            Console.WriteLine("*                                  *");
            Console.WriteLine("************************************");
            Console.WriteLine("请输入菜单项（1-6）：");
            NoteBook nb = new NoteBook();
            while (true)
            {
                int i;
                i = Int16.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        nb.Create();
                        break;
                    case 2:
                        nb.Open();
                        break;
                    case 3:
                        nb.Classify();
                        break;
                    case 4:
                        nb.Manage();
                        break;
                    case 5:
                        nb.Save();
                        break;
                    case 6:
                        Console.WriteLine("退出记事本");
                        Environment.Exit(0);

                        break;
                    default:
                        Console.WriteLine("您输入的情况有误！！！");
                        break;
                }
            }
        }
    }
}



