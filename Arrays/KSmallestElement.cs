using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Arrays
{
    /// <summary>
    /// http://www.geeksforgeeks.org/kth-smallestlargest-element-unsorted-array/
    /// K’th Smallest/Largest Element in Unsorted Array
    /// </summary>
    class KSmallestElement
    {
        public int SortSolution(int[] a, int k)
        {
            Array.Sort(a);
            return a[k - 1];
        }
        public int HeapSolution(int[] a, int k)
        {
            var heap = new MinHeap();
            for(int i=0; i<a.Length; i++)
            {
                heap.Push(a[i]);
            }
            int result=0;
            for (int i = 0; i < k; i++)
                result = heap.Pop();

            return result;
        }

        private class MinHeap
        {
            public List<int> _data;
            public MinHeap()
            {
                _data = new List<int>();
            }

            public int GetParent(int i)
            {
                if (i > 0)
                    return (int)Math.Floor(((double)i - 1) / 2);
                return Int32.MinValue;
            }

            public void Push(int i)
            {
                _data.Add(i);
                Heapify(_data.Count - 1);
            }
            public int Pop()
            {
                var result = _data[0];
                _data.RemoveAt(0);
                Heapify(_data.Count - 1);
                return result;
            }
            private void Heapify(int i)
            {
                var current = _data[i];

                int parentIdx = GetParent(i);
                if (parentIdx < 0)
                    return;
                var parent = _data[parentIdx];
                if (current < parent)
                {
                    _data[parentIdx] = current;
                    _data[i] = parent;
                    Heapify(parentIdx);
                }
            }
        }

    }
}
