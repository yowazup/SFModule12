using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;


namespace SFModule12
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Создадим 3 пользователей
            var user1 = new User();
            user1.Login = "Nikita";
            user1.Name = "Никита";
            user1.IsPremium = false;

            var user2 = new User();
            user2.Login = "Borya";
            user2.Name = "Борис";
            user2.IsPremium = true;

            var user3 = new User();
            user3.Login = "Slava";
            user3.Name = "Вячеслав";
            user3.IsPremium = false;

            //Соберем пользователей в список
            Array users = new User[] { user1, user2, user3 };

            //Выведем рекламу, если премиальной подписки нет
            foreach (User user in users)
                if (user.IsPremium is true)
                {
                    Console.WriteLine("Добрый день {0}, вы молодец - у вас премиальная подписка. Просто хотелось вам это сказать.", user.Name);
                    Console.WriteLine();
                }
                else
                {
                    ShowAds(user);
                    Console.WriteLine();
                }
            Console.ReadKey();
        }

        static void ShowAds(User user)
        {
            Console.WriteLine("Добрые день {0}, у нас есть классные штуки в премиальной подписке.", user.Name);

            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}