using System;
class Prihod {
    static public void watsap(){
        Console.WriteLine("��� �� ����?");
        string a;
        a = Console.ReadLine();
        Console.WriteLine("��, ������ ������ �������, " + a + " ?");
    }
}
class HelloWorld {
  static void Main() {
    Prihod.watsap();
  }
}