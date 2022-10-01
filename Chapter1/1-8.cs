//using System;
//class Stack<StackType> // 제네릭 클래스
//{
//    private StackType[] stack = new StackType[100];//배열 생성
//    private int sp = -1;
//    public void Push(StackType element) //항목 삽입
//    {
//        stack[++sp] = element;
//    }
//    public StackType Pop() //항목 삭제
//    {
//        return stack[sp--];
//    }
//}
//class GenericClassApp
//{
//    public static void Main()
//    {
//        Stack<int> stk1 = new Stack<int>(); // 정수형 스택
//        Stack<double> stk2 = new Stack<double>(); // 실수형 스택
//        stk1.Push(1); stk1.Push(2); stk1.Push(3); //항목 삽입 메소드 호출
//        Console.WriteLine("integer stack : " + stk1.Pop() + " " +
//        stk1.Pop() + " " + stk1.Pop()); //항목 삭제 메소드 호출
//        stk2.Push(1.5); stk2.Push(2.5); stk2.Push(3.5); //항목 삽입 메소드 호출
//        Console.WriteLine(" double stack : " + stk2.Pop() + " " +
//        stk2.Pop() + " " + stk2.Pop());
//    }
//}