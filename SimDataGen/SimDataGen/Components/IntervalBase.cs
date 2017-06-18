using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VahidJalili.Di4.SimDataGen
{
    internal class IntervalBase : IComparable<IntervalBase>
    {
        public IntervalBase()
        { }

        public IntervalBase(int left, int right)
        {
            this.left = left;
            this.right = right;
        }
        public IntervalBase(IntervalBase interval)
        {
            left = interval.left;
            right = interval.right;
        }

        public int left { set; get; }
        public int right { set; get; }

        public void Intersect(IntervalBase interval)
        {
            left = Math.Max(left, interval.left);
            right = Math.Min(right, interval.right);
        }

        public int CompareTo(IntervalBase other)
        {
            if (right <= other.left) return -1;
            if (left >= other.right) return 1;
            return 0;
        }
    }
}
