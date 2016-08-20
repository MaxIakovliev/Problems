using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    /// <summary>
    /// http://www.geeksforgeeks.org/find-a-tour-that-visits-all-stations/
    /// Find the first circular tour that visits all petrol pumps
    /// 
    /// Suppose there is a circle. There are n petrol pumps on that circle. You are given two sets of data.
    /// 1. The amount of petrol that every petrol pump has.
    /// 2. Distance from that petrol pump to the next petrol pump.
    /// Calculate the first point from where a truck will be able to complete the circle 
    /// (The truck will stop at each petrol pump and it has infinite capacity). 
    /// Expected time complexity is O(n). Assume for 1 litre petrol, the truck can go 1 unit of distance.
    /// </summary>
    class FindTheFirstCircularTourThatVisitsAllPetrolPumps
    {
        public int Solution1(Tuple<int, int>[] a)
        {
            int start = 0, current=0, end=a.Length-1;
            int currentFuel = 0;
            var allVisited = false;
            while (!allVisited)
            {
                currentFuel = currentFuel + a[current].Item1 - a[current].Item2;
                if (currentFuel < 0)
                {
                    start = (start + 1) % a.Length;
                    current = start;
                    if (start == 0)
                        return -1;
                    currentFuel = 0;
                    end = start - 1;
                }
                else
                {
                    current = (current + 1) % a.Length;
                    if (current == end)
                        allVisited = true;
                }
            }
            return start;
        }
    }
}
