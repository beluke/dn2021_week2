using System;

namespace PointersExample
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            // allocate char space on stack
            char* p = stackalloc char[1];
            // update data at location p
            *p = 'p';
            // print pointer location
            PrintPointerValue(p);
            
            // make new char c
            char c = 'c';
            // print location of c using ref
            PrintPointerValue(ref c);

            // new pointer to location of c
            char* q = &c;
            // print location of c using ref to q
            PrintPointerValue(ref q);
        }

        static unsafe void PrintPointerValue(char* p)
        {
            // cast to IntPtr to print out actual address, otherwise it is not printable
            IntPtr addr = (IntPtr)p;
            Console.WriteLine("0x" + addr.ToString("x").ToUpper());
        }

        static unsafe void PrintPointerValue(ref char* p)
        {
            // cast p to IntPtr to print out actual address
            IntPtr addr = (IntPtr)p;
            Console.WriteLine("0x" + addr.ToString("x").ToUpper());
        }

        static unsafe void PrintPointerValue(ref char c)
        {
            // need fixed specifier to take value of unfixed reference
            fixed (char *p = &c)
            {
                IntPtr addr = (IntPtr)p;
                Console.WriteLine("0x" + addr.ToString("x").ToUpper());
            }
        }
    }
}
