﻿namespace _05.Calculate_Sequence_with_Queue
{
    using System;
    using System.Collections.Generic;

    public class SequenceWithQueue
    {
        public static void Main()
        {
            /*
             Using the Queue<T> class, this program prints first 50 members of the queue, for recieved N.
             The sequence of numbers goes like this:
                •	S1 = N
                •	S2 = S1 + 1
                •	S3 = 2*S1 + 1
                •	S4 = S1 + 2
                •	S5 = S2 + 1
                •	S6 = 2*S2 + 1
                •	S7 = S2 + 2
                •	…

             */


            var n = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            var counter = 1;

            queue.Enqueue(n);
            Console.Write(queue.Peek() + " ");

            for (int i = 1; i < 50; i++)
            {           
                if (counter == 1)
                {
                    var s1 = queue.Peek();
                    queue.Enqueue(s1 + 1);
                    Console.Write((s1 + 1) + " ");
                }
                else if (counter == 2)
                {
                    var s1 = queue.Peek();
                    queue.Enqueue(2 *s1 + 1);
                    Console.Write((2 *s1 + 1) + " ");
                }
                else
                {
                    var currNum = queue.Dequeue() + 2;
                    queue.Enqueue(currNum);
                    Console.Write(currNum + " ");
                    counter = 0;
                }
                counter++;
            }
            Console.WriteLine();
        }
    }
}
