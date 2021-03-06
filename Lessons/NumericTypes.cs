using System;


namespace Lessons
{
    public class NumericTypes
    {

        /* Integral - Signed */
        // range -128 to 127
        sbyte _mySbyteValue = 2;

        // range -32,768 to 32,767
        short _myShortValue = 4;

        // range 2,147,483,648 to 2,147,483,647
        int _myIntValue = 25_000;

        // range -8,233,372,036,854,775,808 - 8,233,372,036,854,775,807
        long _myLongValue = 1_234_567L;
        long _myLongValue2 = 0x5F;

        /* Integral - Unsigned */

        // range 0 to 255
        byte _myByteValue = 3;
        byte _myByteValue2 = 254;

        // range 0 to 65,535
        ushort _myUshortValue = 35;

        // range 0 to 4,294,967,295
        uint _myUintValue = 2345U;

        // rnge 0 to 18,446,744,076,789,553,625
        ulong _myUlong = 123456UL;

        /* Real Numbers */
        // range 3.4E +/- 38(7 digits)
        float _myFloatValue = -123.6589F;

        // range 1.7E +/- 308(15 digits)
        double _myDoubleValue = 12.34;
        double _myDoubleValue2 = 1E06;

        //range -7.9228E24 to 7.9228E24
        decimal _myDecimalValue = 13.234M;

        // Type Inference; the getType method returns the variable type.
        public void GetSomeType()
        {
            // double 
            Console.WriteLine(3.0.GetType());
            // float
            Console.WriteLine(_myFloatValue.GetType());
        }
        // method to demonstrate an explicit cast from float to int
        public int ConvertFloatToInt(float value)
        {
            int total = (int)value;
            return total;
        }
        // method to demonstrate an implicit cast from int to long
        public long LongFormInt(int value)
        {
            long total = value;
            return total;
        }


        public void BasicMath()
        {
            int myVal = 5, myOtherVal = 10;
            int addVal = myVal + myOtherVal;
            int subtractVal = myVal - myOtherVal;
            int multiplyVal = myOtherVal * myVal;
            int divisionVal = myVal / myOtherVal;
            int modulusVal = myVal % myOtherVal;

            Console.WriteLine(addVal);
            Console.WriteLine(subtractVal);
            Console.WriteLine(multiplyVal);
            Console.WriteLine(divisionVal);
            Console.WriteLine(modulusVal);
        }

        public void CheckOperators()
        {
            int test = 100, test2 = 100;

            int testVal = checked(test * test2);
            checked
            {
                // make value 300000000 to fail
                int testAgain = test * 300;
                Console.WriteLine(testAgain);
            }
            Console.WriteLine(testVal);
        }

        public void IncrementDecrement()
        {
            int myValue = 13, myOther = 10;

            // myValue = myValue + 1
            myValue++;
            Console.WriteLine(myValue);

            // myValue = myValue - 1
            myOther--;
            Console.WriteLine(myOther);


            myValue--;
            Console.WriteLine(myValue);
            myOther++;
            Console.WriteLine(myOther);

        }

        public void SpecialValues()
        {
            Console.WriteLine(2.0/0.0);
            Console.WriteLine(-2.0/0.0);
            Console.WriteLine(2.0/-0.0);
            Console.WriteLine(-2.0/-0.0);
            Console.WriteLine(0.0/0.0);
            Console.WriteLine((2.0/0.0)-(2.0/0.0));
            Console.WriteLine(0.0/-0.0 == double.NaN);
            Console.WriteLine(double.IsNaN(0.0/0.0));
            Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN));
        }
        public void ComparisonOperators()
        {
            bool isCool = true;//declaration of bool value

            /**bool vlues cn be true or false.!-- No cast type for bool to numeric types */
            int x=3, y=5, z=3;
            Console.WriteLine(x==y);//false
            Console.WriteLine(x!=y);//true
            Console.WriteLine(x==z);//true
        }

        public void OtherOperators()
        {
            int val1=5, val2=10;
            // val1 = val + val2
            Console.WriteLine(val1 += val2);
            
            // val2 = val1 <<
            Console.WriteLine(val1 <<= val2);
            Console.WriteLine("fuck this boolshit");
        }

        
         
    }
}