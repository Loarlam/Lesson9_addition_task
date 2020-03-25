using System;

namespace Addition_task
{
    class Program
    {
        delegate double MyDelegateWithInputParameter(int myFirstParameter, int mySecondParameter, int myThirdParameter);

        static void Main(string[] args)
        {
            MyDelegateWithInputParameter myDWithInputParameter;
            int firstParameter = 1, secondParameter = 2, thirdParameter = 3;

            myDWithInputParameter = (myFirstParameter, mySecondParameter, myThirdParameter) => (myFirstParameter + mySecondParameter + myThirdParameter) / 3;

            Console.WriteLine($"Среднее арифметическое ({firstParameter}+{secondParameter}+{thirdParameter})/3 = {myDWithInputParameter(firstParameter, secondParameter, thirdParameter)}");
            Console.ReadKey();
        }
    }
}
