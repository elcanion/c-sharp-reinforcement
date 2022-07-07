// The using directive allows you to use types defined
// in a namespace without specifying the fully qualified
// namespace of that type. In its basic form, the using
// directive imports all the types from a single namespace,
// like in "using System;".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// The namespace keyword is used to declare a scope
// that contains a set of related objects. You can
// use a namespace to organize code elements and to
// create globally unique types. In this case, we're
// declaring a scope that contains a Basic class.

// Within a namespace, you can declare zero or more
// of the following types:
// - class
// - interface
// - struct
// - enum
// - delegate
namespace reinforcement.Contents
{

    // Classes are user-defined blueprints or prototypes
    // from which objects are created. They are the most
    // fundamental building-blocks in OOP. Basically, a
    // class combines the fields and methods (member functions
    // which defines actions) into a single unit.

    // A class declaration contains a access modifier that can be:
    // - public: this means the class/members can be accessed from anywhere;
    // - internal: this means the members are visible to all code in the assembly they are declared in (not too intuitive);
    // - private: this means the members are visible only to the declaring class (including nested classes);
    // - protected: the members are like private members, but are also visible in all classes that inherit the declaring type;
    // - protected internal: read that like protected OR internal;
    // - private protected: members can only be accessed by classes derived from the base class AND in the same assembly;
    public class Basics
    {
        // Methods represents behaviours we can define to
        // classes. In this case, we defined the behaviour
        // HelloWorld that prints "Hello, World!" in the console.

        // Here we declared a public static method, meaning that
        // the values inside the method belongs to the type (in this
        // case, the class) and not to a particular object instance.
        public static void HelloWorld()
        {
            Console.Write("Hello, World!");
        }
    }
}