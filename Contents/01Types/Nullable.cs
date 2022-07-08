using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reinforcement.Contents
{
    public class NullableStudy
    {
        // A nullable type can represent the correct range of values for
        // its underlying value type, plus an additional null value. For
        // example, Nullable<int> can be assigned any value from
        // Int32.MinValue to Int32.MaxValue, or a null value.
        // The Nullable types are instances of System.Nullable<T> struct.
        public struct nullable<T> where T : struct
        {
            public bool HasValue { get; }
        }

        public static void Usage()
        {

        }
    }
}