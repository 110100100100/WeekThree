int number;
System.Console.WriteLine("Nhập một số nguyên: ");
number = Convert.ToInt32(Console.ReadLine());

//Kiểm tra "number" có phải số nguyên tố hay không.
//Nếu "number" < 2 thì không phải số nguyên tố
if (number < 2)
    System.Console.WriteLine(number + " không phải là số nguyên tố.");


//Nếu "number" > 2 thì kiểm tra "number" có chia hêt 
//trong lần lượt từ 2 đến căn bậc hai của "number".
//Nếu khong chia hết trong lần lượt từ 2 đến căn bậc hai của "number" => Là số nguyên tố.
//Nếu chia hết trong lần lượt từ 2 đến căn bậc hai của "number" => Không là số nguyên tố.
else
{   
    int i = 2;
    bool check = true;
    while (i <= Math.Sqrt(number))
    {
        if (number % i == 0)
        {
            check = false;
            break;
        }
        i++;
    }
    if (check)
    {
        System.Console.WriteLine("Đây là số nguyên tố.");
    }
    else
    {
        System.Console.WriteLine("Đây không phải số nguyên tố.");
    }
}
