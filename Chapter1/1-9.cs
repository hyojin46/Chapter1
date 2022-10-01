//using System;
//using System.Threading; // 1. System.Threading 네임스페이스
//class ThreadApp
//{
//    static void ThreadBody() //2. 메소드 작성
//    { 
//        Console.WriteLine("In the thread body …");
//    }
//    public static void Main()
//    {
//        ThreadStart ts = new ThreadStart(ThreadBody); // 3. 메소드를 delegate에 연결
//        Thread t = new Thread(ts); // 4. 스레드 객체 생성
//        Console.WriteLine("*** Start of Main");
//        t.Start(); // 5. 스레드 실행을 시작
//        Console.WriteLine("*** End of Main");
//    }
//}