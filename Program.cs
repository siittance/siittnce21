using System.Globalization;
using System.Text;

Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

string text = Console.ReadLine();
Console.WriteLine("Вы ввели:" + text);

//Console.WriteLine("Введите ваш возраст:");
//string txt = Console.ReadLine();
//double num;
//if (double.TryParse(txt, out num) == true)
//{
//    if (num < 0 || num > 100)
//    {
//        Console.WriteLine("Возраст не может быть таким");
//    }
//    else
//    {
//        if (num > 10)
//        {
//            num = num + 8;
//            Console.WriteLine("Вам будет: " + num);
//        }
//        else
//        {
//            num = num + 23;
//            Console.WriteLine("Вам будет: " + num);
//        }
//    }
//}
//else
//{
//    Console.WriteLine("Это не число");
//}