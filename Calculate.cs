using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class Calculate
    {

        public static float result = 0.0f;

        static Calculate()
        {
            result = 0.0f;
        }

        // Integers
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Mult(int x, int y)
        {
            return x * y;
        }
        public static int Div(int x, int y)
        {
            return x / y;
        }
       
        // Floating 
        
        public static float Add(float x, float y)
        {
            return x + y;
        }
        public static float Sub(float x, float y)
        {
            return x - y;
        }
        public static float Mult(float x, float y)
        {
            return x * y;
        }
        public static float Div(float x, float y)
        {
            return x / y;
        }
    }
}
