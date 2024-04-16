int choice;

System.Console.WriteLine("Menu");
System.Console.WriteLine("1. Vẽ hình tam giác.");
System.Console.WriteLine("2. Vẽ hình vuông.");
System.Console.WriteLine("3. Vẽ hình chữ nhất.");
System.Console.WriteLine("0. Thoát");
System.Console.WriteLine("Nhập lựa chọn của bạn: ");

choice = Int32.Parse(Console.ReadLine());
switch (choice)
{
     case 1:
          System.Console.WriteLine("Hình tam giác: ");
          System.Console.WriteLine("***********");
          System.Console.WriteLine("**********");
          System.Console.WriteLine("*********");
          System.Console.WriteLine("********");
          System.Console.WriteLine("*******");
          System.Console.WriteLine("******");
          System.Console.WriteLine("*****");
          System.Console.WriteLine("****");
          System.Console.WriteLine("***");
          System.Console.WriteLine("**");
          System.Console.WriteLine("*");
          break;
     case 2:
          System.Console.WriteLine("Hình vuông: ");
          System.Console.WriteLine("++++++++++++++++");
          System.Console.WriteLine("++++++++++++++++");
          System.Console.WriteLine("++++++++++++++++");
          System.Console.WriteLine("++++++++++++++++");
          System.Console.WriteLine("++++++++++++++++");
          System.Console.WriteLine("++++++++++++++++");
          System.Console.WriteLine("++++++++++++++++");
          break;
     case 3:
          System.Console.WriteLine("Hình chữ nhật: ");
          System.Console.WriteLine("|||||||||||||||||||||||");
          System.Console.WriteLine("|||||||||||||||||||||||");
          System.Console.WriteLine("|||||||||||||||||||||||");
          System.Console.WriteLine("|||||||||||||||||||||||");
          System.Console.WriteLine("|||||||||||||||||||||||");

          break;
     case 0:
          Environment.Exit(0);
          break;
     default:
          Console.WriteLine("Hãy lựa chọn lại!");
          break;
}
while (choice != 0)
{

}