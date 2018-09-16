/*Create a class. In that class, create three methods, each of which will take one 
 * integer parameter in and return an integer. The methods should do some math 
 * operation on the received parameter. Put this class in a separate .cs file in 
 * the application.*/


using System;

namespace ClassesLab111
{
    class myClass
    {
        static public int addTwo(int input)
        {
            return input + 2;
        }

        static public int subTwo(int input)
        {
            return input - 2;
        }

        static public int divTwo(int input)
        {
            return input / 2;
        }
    }
}