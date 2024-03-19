using Alg.Users;

namespace Alg
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Привет, {UserData().Name}");

            if (!UserData().IsPremium)
            {
                ShowAds();
            }
        }
        static void GetUser()
        {
            User user = UserData();
        }

        static User UserData()
        {
            return new User()
            {
                Login = "German123",
                Name = "German",
                IsPremium = false
            };
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }
    }
}
