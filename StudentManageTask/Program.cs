//giris:
//{
//    Console.WriteLine("Daxil olacaqiniz profili secin");
//    Console.WriteLine("1. Mekteb girisi");
//    Console.WriteLine("2. Muellim girisi");
//    Console.WriteLine("3. Telebe girisi");
//    Console.WriteLine("4. Cixis");

//}
using StudentManageTask;

Mekteb m = new();


Telebe t1 = new Telebe();
t1.Ad = "Rahib";
t1.Soyad = "Gasimov";
t1.Mail = "rahib@mail.com";
t1.Password = "rahib123";
t1.Ortalama = 75.8;

Telebe t2 = new Telebe();
t2.Ad = "Ziyad";
t2.Soyad = "Ismayilov";
t2.Mail = "ziyad@mail.com";
t2.Password = "ziyad123";
t2.Ortalama = 55.8;



m.TelebeElaveEt(t1);
m.TelebeElaveEt(t2);