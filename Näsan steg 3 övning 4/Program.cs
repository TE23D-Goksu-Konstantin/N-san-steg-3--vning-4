using System;

class Triangeldrama
{
    
    static int RightTriangleArea(int a, int b)
    {
        return((a*b)/2);  //Blir 10 eftersom svaret på a*b blir 21 då 10,5 ej går så den avrundar neråt
    }

    static void Main(string[] args){
        Console.WriteLine(RightTriangleArea(3,7));
        Console.ReadLine();
    }



}