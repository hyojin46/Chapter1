//using System;
//class EventApp
//{   
//    public event EventHandler MyEvent; //1.델리게이트 선언(EventHandler- 미리 정의된 이벤트를 위한 델리게이트) 2. 이벤트 선언
//    void MyEventHandler(object sender, EventArgs e)  // 3. 이벤트 처리기 작성
//    {
//        Console.WriteLine("Hello world");
//    }
//    public EventApp()  // 생성자
//    {
//        this.MyEvent += new EventHandler(MyEventHandler); // 4. 이벤트 처리기 등록
//    }
//    public void InvokeEvent() //이벤트 발생을 위한 메소드
//    {
//        if (MyEvent != null)
//            MyEvent(this, null); // 5. 이벤트 발생
//    }
//    public static void Main() 
//    {
//        new EventApp().InvokeEvent(); //InvokeEvent() 호출
//    }
//}