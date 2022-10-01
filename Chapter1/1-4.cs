//using System;
//class PropertyClass
//{
//    private int privateValue; //필드명
//    public int PrivateValue //프로퍼티명
//    {
//        get { return privateValue; } // get-accessor
//        set { privateValue = value; } // set-accessor , value는 예약어
//    }
//    public void PrintValue()
//    {
//        Console.WriteLine("Hidden Value = " + privateValue);
//    }
//}
//class PropertyApp
//{
//    public static void Main()
//    {
//        int n;
//        PropertyClass obj = new PropertyClass();
//        obj.PrivateValue = 100; //  set-accessor 호출
//        obj.PrintValue();
//        n = obj.PrivateValue; //  get-accessor 호출
//        Console.WriteLine(" Value = " + n);
//    }
//}