using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrys
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        }
    }


//            ArrayList num = new ArrayList();
//            num.Add(1);
//            num.Add(2);
//            num.Add(3);
//            num.Add(2);
//            foreach (int i in num)
//            {
//                Console.WriteLine(i);
//            }
//            Console.ReadLine();
//        }
//    }
//}  


//int[] num= new int[3];
//num[0] = 1;
//num[1] = 2;
//num[2] = 3;
//num[4] = 2;

//foreach(int i in num)
//{
//    Console.WriteLine(i);
