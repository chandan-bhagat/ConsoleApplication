﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary;
using TestLibrary.Computer;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testmessage();

            //Queue();

            //Stack();

            //StackV2();

            StackV3();

            Console.ReadLine();
        }

        static void Testmessage()
        {
            Test t = new Test();
            Console.WriteLine("From T Object");
           // Console.WriteLine("From Static "+Test.TestFunction());
            Console.WriteLine("From non static "+t.TestNonStatic());
            Test t1 = new Test();

            Console.WriteLine("From t1 object");
            //Console.WriteLine("From Static " + Test.TestFunction());
            Console.WriteLine("From non static " + t1.TestNonStatic());

        }

        static void Queue()
        {
            CustomQueue cq = new CustomQueue(20);
            cq.Enqueue(10);
            cq.Enqueue(20);
            cq.Enqueue(30);

            Console.WriteLine(cq.Count);
            var tmp = cq.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cq.Dequeue();
            Console.WriteLine("After Dequeuing : ");
            tmp = cq.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cq.Enqueue(40);
            Console.WriteLine("After adding 40 : ");
            tmp = cq.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }
        }

        static void Stack()
        {
            CustomStack cs = new CustomStack();
            cs.Push(10);
            
            var tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Pop();
            cs.Pop();
            Console.WriteLine("After Pop :");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Push(40);
            Console.WriteLine("After push 40 : ");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }
        }

        static void StackV2()
        {
            CustomStackV2 cs = new CustomStackV2();
            for (int i = 0; i < 20; i++)
            {
                cs.Push(i * 10);
            }

            var tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Pop();
            cs.Pop();
            Console.WriteLine("After Pop :");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Push(40);
            Console.WriteLine("After push 40 : ");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }
        }
        static void StackV3()
        {
            CustomStackV3 cs = new CustomStackV3();
            for (int i = 0; i < 20; i++)
            {
                cs.Push(i * 10);
            }

            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }

            cs.Pop();
            cs.Pop();
            Console.WriteLine("After Pop :");
            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }

            cs.Push(40);
            Console.WriteLine("After push 40 : ");
            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }
        }
    }
}










