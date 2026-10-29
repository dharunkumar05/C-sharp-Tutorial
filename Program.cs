using System;

class School{
    public class Subject{
        public void show(string sub){
            Console.WriteLine("The Subject is: "+ sub);
        }
    }
}
class Ain{
    public static void Main(){
        School.Subject a =new School.Subject();
        string sub = Console.ReadLine();
        a.show(sub);
        a.show("Science");
}
}