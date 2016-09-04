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
            ListNode result = null;
            bool isEmpty = false;
            int idx = 0;
            var heap = new Heap<int>();
            while(isEmpty)
            {
                isEmpty = true;
                if(lists[idx]!=null)
                {
                    isEmpty = false;
                    heap.Push(lists[idx].val);
                    lists[idx] = lists[idx].next;
                    idx++;
                }
                if (idx == lists.Length) idx = 0;
            }

            ListNode pointer = null;
            while(heap.Count()!=0)
            {
                if(result==null)
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
            private IList<T> _data;

            public Heap()
            {
                _data = new List<T>();
            }
            private void Heapify(int idx)
            {
                if (idx < 0) return;

                var item = _data[idx];
                if (item == null)
                    return;
                var parentIdx = GetParent(idx);
                if (parentIdx < 0)
                    return;

                var parentItem = _data[parentIdx];
                if (item.CompareTo(parentItem) > 0)
                {
                    _data[parentIdx] = item;
                    _data[idx] = parentItem;
                }
            }

            public int Count()
            {
                return _data.Count();
            }

            public void Push(T item)
            {
                _data.Add(item);
                Heapify(_data.Count - 1);
            }


            public T Pop()
            {
                if (_data.Count == 0)
                    throw new Exception("Heap is empty");

                var item = _data[0];
                _data.RemoveAt(0);
                Heapify(_data.Count - 1);

                return item;

            }

            private int GetParent(int idx)
            {
                if (idx > 0)
                    return (int)Math.Floor((double)((idx - 1) / 2));

                return Int32.MinValue;
            }
        }
    }
}
