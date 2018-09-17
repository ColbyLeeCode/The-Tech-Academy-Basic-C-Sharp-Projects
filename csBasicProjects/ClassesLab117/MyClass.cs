using System;

namespace ClassesLab117
{
    class MyClass
    {
        public MyClass()
        {

        }


        /*a void method that outputs an integer. Have the method divide the data passed to it by 2.*/
        public void outInt(out int x, int y)
        {
            x = y / 2;    
        }

        /*Create a method with output parameters.*/
        /*Output user input for x and y. Add optional addition to both*/
        public void assignValues(out int x, out int y, int addition = 0)
        {
            x = Convert.ToInt32(Console.ReadLine()) + addition;
            y = Convert.ToInt32(Console.ReadLine()) + addition;
        }

        /*Output user input for x and y as double. Add optional addition to both*/
        public void assignValues(out double x, out double y, int addition = 0)
        {
            x = Convert.ToDouble(Console.ReadLine()) + addition;
            y = Convert.ToDouble(Console.ReadLine()) + addition;
        }


    }
}
 