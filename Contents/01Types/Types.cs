using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reinforcement.Contents
{
    // C# is a strongly-typed language. It means we must declare the type
    // of a variable that indicates the kind of values it is going to store,
    // such as integer, float, decimal, text, etc. C# mainly categorized
    // data types in two types: Value types and Reference types. Value types
    // include simple types (such as int, float, bool, char), enum types,
    // struct types and Nullable value types. Reference types include class
    // types, interface types, delegate types and array types.
    public class Types
    {
        public static void TypesDemonstrationUsingMinAndMaxValues()
        {
            Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue}");
            Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"float: {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double: {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MinValue}");

            // here I'm using explicit conversion (or cast) from char to int so we can
            // see both MinValue and MaxValue for chars correctly. Casting is 
            // required when information might be lost in the conversion, 
            // or when the conversion might not succeed for other reasons.
            // In this case, we need to cast to (int) because the MinValue
            // for chars is u+0000, which represents a NUL char and shows nothing
            // in the WriteLine output, and the MaxValue for chars is u+ffff,
            // which represents Undefined and outputs nothing too.
            Console.WriteLine($"char: {(int)char.MinValue:x4} to {(int)char.MaxValue:x4}");
            
            Console.WriteLine($"DateTime: {DateTime.MinValue} to {DateTime.MaxValue}");
            
            Console.WriteLine($"bool: logical true or false");
            Console.WriteLine($"object: Base type of all other objects");
            Console.WriteLine($"dynamic: This seems like javascript, bypassing static type checking");
            Console.WriteLine($"string: A sequence of Unicode characters");
            
        }
    }
}