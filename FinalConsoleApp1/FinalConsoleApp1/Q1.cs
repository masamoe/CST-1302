// See https://aka.ms/new-console-template for more information

class Program
{
    struct Pyramid
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        public Pyramid(int height, int width, int depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
        }
    }

    static int findVolume(Pyramid input)
    {
       return (input.Height * input.Width * input.Depth / 3);
    }

    static void compareVolumes(Pyramid input1, Pyramid input2)
    {
        Console.WriteLine("Calling findVolume for pyramidOne:\n");
        int volume1 = findVolume(input1);
        Console.WriteLine("The volume is " + volume1 + "\n");
        Console.WriteLine("Calling findVolume for pyramidTwo:\n");
        int volume2 = findVolume(input2);
        Console.WriteLine("The volume is " + volume2 + "\n");

        Console.WriteLine("Calling compareVolume for pyramidOne and pyramidTwo:\n");
        if (volume1 > volume2)
        {
            Console.WriteLine("pyramidOne is bigger by "+ (volume1 - volume2) + " cubic centimeters.");
        }
        else if (volume1 < volume2)
        {
            Console.WriteLine("pyramidTwo is bigger by " + (volume2 - volume1) + " cubic centimeters.");
        }
        else
        {
            Console.WriteLine("Pyramids are equal");
        }
    }

    static void Main(string[] args)
    {
        Pyramid pyramidOne = new Pyramid(15, 10, 5);
        Pyramid pyramidTwo = new Pyramid(25, 20, 15);

        compareVolumes(pyramidOne, pyramidTwo);
    }
}