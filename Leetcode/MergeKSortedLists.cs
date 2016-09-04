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
            private IList<T> _data;

            public Heap()
            {
                _data = new List<T>();
                _data.Add(default(T));
            }
           

            public int Count()
            {
                return _data.Count()-1;
            }

            public void Push(T item)
            {
                _data.Add(item);
                PushUp();
            }


            public T Pop()
            {
                if (Count() == 0)
                    throw new Exception("Heap is empty");

                var item = _data[1];
                if (Count() > 0)
                {
                    _data[1] = _data[Count() ];
                    _data.RemoveAt(Count());
                }
                PushDown();

                return item;

            }

            private int GetParentIndex(int idx)
            {
                if (idx >0)
                {
                    return idx / 2;
                }

                return Int32.MinValue;
            }


            private int LeftIndex(int i)
            {
                return i * 2;
            }


            private int RightIndex(int i)
            {
                return i * 2 + 1;
            }
            private bool HasLeftChild(int i)
            {
                return LeftIndex(i) <= Count();
            }
            private bool HasRightChild(int i)
            {
                return RightIndex(i) <= Count();
            }

            private bool HasParent(int i)
            {
                return i > 1;
            }

          

            private void PushDown()
            {
                int idx = 1;
                while (HasLeftChild(idx))
                {
                    var smallerChild = LeftIndex(idx);
                    if (HasRightChild(idx) && _data[RightIndex(idx)].CompareTo(_data[LeftIndex(idx)]) < 0)
                    {
                        smallerChild = RightIndex(idx);
                    }
                    if (_data[idx].CompareTo(smallerChild) > 0)
                    {
                        var tmp = _data[idx];
                        _data[idx] = _data[smallerChild];
                        _data[smallerChild] = tmp;
                    }
                    idx = smallerChild;
                }
            }

            private void PushUp()
            {
                int idx = Count();

                while(HasParent(idx) && _data[GetParentIndex(idx)].CompareTo(_data[idx])>0)
                {
                    var tmp = _data[idx];
                    _data[idx] = _data[GetParentIndex(idx)];
                    _data[GetParentIndex(idx)] = tmp;
                    idx = GetParentIndex(idx);
                }
            }
        }
    }
}
