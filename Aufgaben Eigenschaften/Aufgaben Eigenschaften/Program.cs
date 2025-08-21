namespace Aufgaben_Eigenschaften
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Rectangle rectangle1 = new Rectangle(100, 200) {Description = "Rechteck"};
            Rectangle rectangle2 = new Rectangle(30, 50, "rectangle 2");
            Rectangle rectangle3 = new Rectangle(100, 100, true);
        }
    }
}
