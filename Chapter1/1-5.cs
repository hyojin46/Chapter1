﻿//using System;
//class Even
//{
//    int evenNumber;
//    public Even(int n) // 매개변수 있는생성자
//    { 
//        evenNumber = (n % 2 == 0) ? n : n + 1; //n을 2로 나눈 나머지가 0이라면 참이어서 n, 0이 아니라면 거짓이어서 n+1실행
//    }
//    public static Even operator ++(Even e) // ++ 연산자
//    { 
//        e.evenNumber += 2; // 다음 짝수
//        return e;
//    }
//    public static Even operator --(Even e) // -- 연산자
//    { 
//        e.evenNumber -= 2; // 이전 짝수
//        return e;
//    }
//    public void PrintEven() // 출력 메소드
//    { 
//        Console.WriteLine("Even Number = " + evenNumber);
//    }
//}
//class OperatorOverloadingApp
//{
//    public static void Main()
//    {
//        Even e = new Even(4); e.PrintEven();
//        ++e; 
//        e.PrintEven();
//        --e; 
//        e.PrintEven();
//    }
//}