/*
# Name: Aidan Friday
# email: fridayaj@uc.mail.edu
# Assignment Title: Final Project
# Due Date: 4/23/24
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: Solve leet code and display it 
# Citations: LeetCode.com, ChatGPT, Professor Nicholson
# Anything else that's relevant:
*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace final_example
{
    public class Aidan_Solution
    {
        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var building in buildings)
            {
                set.Add(building[0]);
                set.Add(building[1]);
            }

            var res = new List<IList<int>>();

            foreach (var x in set.OrderBy(x => x))
                Console.WriteLine(x);

            int max = 0;
            foreach (var pos in set.OrderBy(x => x))
            {
                max = 0;
                foreach (var building in buildings)
                {
                    if (pos >= building[0] && pos < building[1])
                    {
                        max = Math.Max(max, building[2]);
                    }
                }

                if (res.Count == 0 || res.Last()[1] != max)
                {
                    res.Add(new int[] { pos, max });
                }
            }

            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem Description: Given a list of building outlines represented by their left and right x-coordinate and height, return the skyline formed by these buildings. Each building is represented by a triplet of integers [left, right, height].");

            // Example Test Case (Skyline)
            int[][] buildings = new int[][] {
                new int[] {2, 9, 10},
                new int[] {3, 7, 15},
                new int[] {5, 12, 12},
                new int[] {15, 20, 10},
                new int[] {19, 24, 8}
            };

            Console.WriteLine("\nLeetCode Test Case (Skyline): ");
            foreach (var building in buildings)
            {
                Console.WriteLine($"[{building[0]}, {building[1]}, {building[2]}]");
            }

            Aidan_Solution solution = new Aidan_Solution();
            var skyline = solution.GetSkyline(buildings);

            Console.WriteLine("\nSolution (Skyline): ");
            foreach (var point in skyline)
            {
                Console.WriteLine($"[{point[0]}, {point[1]}]");
            }
        }
    }
}
