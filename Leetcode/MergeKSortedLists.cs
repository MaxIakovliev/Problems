using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Leetcode
{
    public class MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Count() == 0)
                return null;

            ListNode result = null;
            int count = lists.Length;
            int idx = 0;
            var heap = new Heap<int>();
            while (idx < lists.Length)
            {
                while (lists[idx] != null)
                {
                    heap.Push(lists[idx].val);
                    lists[idx] = lists[idx].next;
                }
                idx++;
            }

            ListNode pointer = null;
            while (heap.Count() != 0)
            {
                if (result == null)
                {
                    result = new ListNode(heap.Pop());
                    pointer = result;
                }
                else
                {
                    pointer.next = new ListNode(heap.Pop());
                    pointer = pointer.next;
                }
            }
            return result;
        }

        public class Heap<T> where T : IComparable
        {
            private T[] _data;
            private int last = 0;
            private int capacity = 4;


            public Heap()
            {
                _data = new T[11];
                last = 0;
                capacity = 7;
            }

            public int Count()
            {
                return last;
            }

            public void Push(T item)
            {
                last++;
                if (Count() == capacity)
                {
                    Array.Resize<T>(ref _data, capacity * 2);
                    capacity = capacity * 2;
                }
                _data[last] = item;
                PushUp();

            }

            public T Pop()
            {
                var item = _data[1];
                _data[1] = _data[last];
                last--;
                Pushdown();
                return item;
            }

            private void Pushdown()
            {
                int idx = 1;
                while (true)
                {
                    int child = idx * 2;
                    if (child > Count())
                        break;
                    if (child + 1 < Count())
                    {
                        child = FindMin(child, child + 1);

                    }
                    if (_data[idx].CompareTo(_data[child]) < 0)
                        break;

                    Swap(idx, child);
                    idx = child;
                }

            }

            private void Swap(int idx, int child)
            {
                var tmp = _data[idx];
                _data[idx] = _data[child];
                _data[child] = tmp;
            }

            private int FindMin(int leftChild, int rightChild)
            {
                if (_data[leftChild].CompareTo(_data[rightChild]) < 0)
                    return leftChild;
                else 
                    return rightChild;

            }

            private void PushUp()
            {
                var idx = Count();
                while (idx > 1)
                {
                    var parentidx = idx / 2;
                    if (_data[idx].CompareTo(_data[parentidx]) > 0)
                        break;
                    Swap(idx, parentidx);
                    idx = parentidx;
                }
            }


        }
    }
}
