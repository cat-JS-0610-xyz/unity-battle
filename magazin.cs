using System;
class Prihod {
    static public void watsap(){
        Console.WriteLine("Как тя звут?");
        string a;
        a = Console.ReadLine();
        Console.WriteLine("Че, хочешь купить игрушку, " + a + " ?");
    }
}
class HelloWorld {
  static void Main() {
    Prihod.watsap();
  }
}