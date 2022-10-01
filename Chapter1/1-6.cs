//using System;
//delegate void SampleDelegate(); //Delegate정의
//class DelegateClass //Delegate클래스
//{
//    public void DelegateMethod() //메소드 정의
//    {
//        Console.WriteLine("In the DelegateClass.DelegateMethod ..."); //화면 출력
//    }
//}
//class DelegateApp
//{
//    public static void Main()
//    {
//        DelegateClass obj = new DelegateClass(); //Delegate객체 생성
//        SampleDelegate sd = new SampleDelegate(obj.DelegateMethod); //Delegate객체에 메소드 연결
//        sd(); // Delegate를 통해 메소드 호출
//    }
//}