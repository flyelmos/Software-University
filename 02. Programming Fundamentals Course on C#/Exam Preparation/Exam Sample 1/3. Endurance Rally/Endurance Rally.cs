﻿namespace _3.Endurance_Rally
{
    using System;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            string[] participants = Console.ReadLine()
                .Split(' ');

            double[] trackLayout = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            int[] checkpoints = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            foreach (var participant in participants)
            {
                int startingFuel = (int)(participant[0]);
                double leftFuel = startingFuel;
                int checkpointCount = 0;

                for (int i = 0; i < trackLayout.Length; i++)
                {
                    bool isEqual = false;

                    for (int j = 0; j < checkpoints.Length; j++)
                    {
                        if (i == checkpoints[j])
                        {
                            isEqual = true;
                            break;
                        }
                    }

                    if (isEqual)
                    {
                        leftFuel += trackLayout[i];
                    }
                    else
                    {
                        leftFuel -= trackLayout[i];
                    }
                    if (leftFuel > 0)
                    {
                        checkpointCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{participant} - reached {checkpointCount}");
                        break;
                    }
                }

                if (leftFuel > 0 )
                {
                    Console.WriteLine("{0} - fuel left {1:f2}", participant, leftFuel);
                }
            }
        }
    }
}
