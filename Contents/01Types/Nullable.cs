using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reinforcement.Contents
{

    // A type is said to be nullable if it can be assigned a value or can
    // be assigned null, which means the type has no value whatsoever. By
    // default, all reference types, such as String, are nullable, but all
    // value types, such as Int32, are not. In C#, you mark a value type as
    // nullable by using the ? notation after the value type. For example,
    // int? in C# declares an integer value type that can be assigned null.
    // The Nullable<T> structure supports using only a value type as a nullable
    // type because reference types are nullable by design.
    // The nullable class provides complementary support for the Nullable<T>
    // structure. The Nullable class supports obtaining the underlying type of
    // a nullable type, and comparison and equality operations on pairs of
    // nullable types whose underlying value type does not support generic
    // comparison and equality operations.

    // The two fundamental members of the Nullable<T> structure are the HasValue
    // and Value properties. If the HasValue property for a Nullable<T> object
    // is true, the value of the object can be accessed with the Value property.
    // If the HasValue property is false, the value of the object is undefined
    // and an attempt to access the Value property throws an InvalidOperationException.
    public class NullableStudy
    {
        // A nullable value type T? represents all values of its underlying
        // value type T and an additional null value. For example, you can
        // assign any of the following three values to a bool? variable:
        // true, false or null. An underlying value type T cannot be a
        // nullable value type itself.
        // Any nullable value type is an instance of the generic
        // System.Nullable<T> structure. You can refer to a nullable value
        // type when you need to represent the undefined value of an
        // underlying value type. For example, a Boolean, or bool, variable
        // can only be either true or false. However, in some applications
        // a variable value can be undefined or missing. For example, a
        // database field may contain true or false, or it may contain
        // no value at all, that is, NULL. You can use the bool? type in
        // that scenario.

        // As a value type is implicitly convertible to the corresponding
        // nullable value type, you can assign a value to a variable of a
        // nullable value type as you would do that for its underlying value
        // type. You can also assign the null value. For example:
        public static void NullableDeclarationAndAssignment()
        {
            double? pi = 3.14;
            char? letter = 'a';

            int? m2 = 10;
            int? m = m2;

            bool? flag = null;

            // An array of a nullable value type:
            int?[] arr = new int?[10];

            // The default value of a nullable value type represents null,
            // that is, it's an instance whose Nullable<T>.HasValue property
            // returns false.
        }

        // Beginning with C# 7.0, you can use the is operator with a type
        // pattern to both examine an instance of a nullable value type
        // for null and retrieve a value of an underlying type:
        public static void NullableInstanceExamination()
        {
            int? a = 42;
            if (a is int valueOfA)
            {
                Console.WriteLine($"a is {valueOfA}");
            }
            else
            {
                Console.WriteLine("a does not have a value");
            }
        }

        // You always can use the following read-only properties to
        // examine and get a value of a nullable value type variable:
        // Nullable<T>.HasValue indicates whether an instance of a
        // nullable value type has a value of its underlying type.
        // Nullable<T>.Value gets the value of an underlying type if
        // HasValue is true. If HasValue is false, the Value property
        // throws an InvalidOperationException.
        // The following example uses the HasValue property to test
        // whether the variable contains a value before displaying it:
        public static void NullableHasValueCondition()
        {
            int? b = 10;
            if (b.HasValue)
            {
                Console.WriteLine($"b is {b.Value}");
            }
            else
            {
                Console.WriteLine("b doesn't have a value");
            }
        }

        // You can also compare a variable of a nullable value type with
        // null instead of using the HasValue property, as the following
        // example shows:
        public static void NullableComparisonWithNull()
        {
            int? c = 7;
            if (c != null)
            {
                Console.WriteLine($"c is {c.Value}");
            }
            else
            {
                Console.WriteLine("c doesn't have a value");
            }
        }

        // If you want to assign a value of a nullable value type to a
        // non-nullable value type variable, you might need to specify
        // the value to be assigned in place of null. Use the null-coalescing
        // operator ?? to do that (you can also use the Nullable<T>.GetValueOrDefault(T)
        // method for the same purpose):
        public static void NullableToUnderlyingTypeConversion()
        {
            int? a = 28;
            int b = a ?? -1;
            Console.WriteLine($"b is {b}"); // output: b is 28

            int? c = null;
            int d = c ?? -1;
            Console.WriteLine($"d is {d}"); // output: d is -1
            // If you want to use the default value of the underlying value
            // type in place of null, use the Nullable<T>.GetValueOrDefault()
            // method.
            float? e = 12.34f;
            float? f = -1.0f;
            f = e.GetValueOrDefault(); // Method available only for Nullables
        }

        // You can also explicitly cast a nullable value type to a
        // non-nullable type, as the following example shows:
        public static void NullableCastToNonNullable()
        {
            int? n = null;
            // int m1 = n;      // Doesn't compile
            int n2 = (int)n;    // Compiles, but throws an exception if n is null
            // At run time, if the value of a nullable value type is null,
            // the explicit cast throws an InvalidOperationException.
            // A non-nullable value type T is implicitly convertible to
            // the corresponding nullable value type T?.
        }

        public static void Usage()
        {

        }
    }
}