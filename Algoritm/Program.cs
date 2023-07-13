namespace Algoritm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> parts = new List<User>();
            parts.Add(new User() { Login = "ivan", Name = "Иван", IsPremium = false });
            parts.Add(new User() { Login = "testuser", Name = "Олег", IsPremium = false });
            parts.Add(new User() { Login = "user1488", Name = "Нурлан", IsPremium = true });
            parts.Add(new User() { Login = "nagibator228", Name = "Сергей", IsPremium = true});
            parts.Add(new User() { Login = "uhlol", Name = "Жорик", IsPremium = true });

            foreach (var item in parts) {
                if (!item.IsPremium)
                {
                    ShowAds();
                }
            }
        }
        public static void ShowAds()
        {
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
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

    }
}