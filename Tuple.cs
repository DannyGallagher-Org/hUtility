using RSG;

namespace hUtility
{
    public static class TupleExtensions
    {
        public static void Set<T1, T2>(this Tuple<T1, T2> @this, out T1 value1, out T2 value2)
        {
            if (@this == null)
            {
                value1 = default(T1);
                value2 = default(T2);
            }
            else
            {
                value1 = @this.Item1;
                value2 = @this.Item2;
            }
        }


        public static void Set<T1, T2, T3>(this Tuple<T1, T2, T3> @this, out T1 value1, out T2 value2, out T3 value3)
        {
            if (@this == null)
            {
                value1 = default(T1);
                value2 = default(T2);
                value3 = default(T3);
            }
            else
            {
                value1 = @this.Item1;
                value2 = @this.Item2;
                value3 = @this.Item3;
            }
        }

        public static void Set<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> @this, out T1 value1, out T2 value2, out T3 value3, out T4 value4)
        {
            if (@this == null)
            {
                value1 = default(T1);
                value2 = default(T2);
                value3 = default(T3);
                value4 = default(T4);
            }
            else
            {
                value1 = @this.Item1;
                value2 = @this.Item2;
                value3 = @this.Item3;
                value4 = @this.Item4;
            }
        }
    }
}
