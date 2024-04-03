namespace Övning_Generics_Låda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxes = new BoxCollection();

            boxes.Add(new Box(2, 2, 2));
            boxes.Add(new Box(2, 2, 2));
            boxes.Add(new Box(3, 3, 3));
            boxes.Add(new Box(1, 3, 9));
            boxes.Add(new Box(2, 3, 4));


            BoxDisplay(boxes);
            Console.WriteLine("-----------------------------------------");

            boxes.Remove(new Box(2, 3, 4));
            BoxDisplay(boxes);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(boxes.Contains(new Box(2, 2, 2)));


            Console.ReadKey(); 
        }

        public static void BoxDisplay(BoxCollection box)
        {
            foreach (Box b in box)
            {
                Console.WriteLine($"Height: {b.Height}, Width: {b.Width}, Length: {b.Length}, Volym: {b.Height*b.Width*b.Length}");

            }
        }
    }
}
