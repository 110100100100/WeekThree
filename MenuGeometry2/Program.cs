int choice;

System.Console.WriteLine("Menu");
System.Console.WriteLine("1. In hình chữ nhật");
System.Console.WriteLine("2. In hình tam giác vuông ở góc dưới bên trái");
System.Console.WriteLine("3. In hình tam giác vuông ở góc trái phía trên ");
System.Console.WriteLine("4. In hình tam giác cân");
System.Console.WriteLine("0. Thoát");
System.Console.WriteLine("Nhập lựa chọn của bạn: ");

choice = Int32.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Rectangle();
        break;
    case 2:
        TriangleBottomLeft();
        break;
    case 3:
        TriangleTopLeft();
        break;
    case 4:
        IsoscelesTriangle();
        break;
    default:
        Console.WriteLine("Lựa chọn không hợp lệ.");
        break;
}

while (choice != 0)
{

}

    static void Rectangle ()
    {
        System.Console.WriteLine("In ra hình chữ nhật:");
        System.Console.WriteLine("Nhập chiều dài: ");
        int heigh = Int32.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Nhập chiều rộng: ");
        int weight = Int32.Parse(Console.ReadLine());

        for(int i = 1; i < heigh; i++)
        {
            for(int j = 1; i < weight;i++)
            {
                
                System.Console.Write("* ");

            }
        }
        System.Console.WriteLine();
    }


    static void TriangleBottomLeft()
    {
        Console.WriteLine("In hình tam giác vuông :");
        Console.Write("Nhập chiều cao: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }


    static void TriangleTopLeft()
    {
        Console.WriteLine("In hình tam giác vuông ở top-left:");
        Console.Write("Nhập chiều cao: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = height; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }


    static void IsoscelesTriangle()
    {
        Console.WriteLine("In hình tam giác cân:");
        Console.Write("Nhập chiều cao: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    