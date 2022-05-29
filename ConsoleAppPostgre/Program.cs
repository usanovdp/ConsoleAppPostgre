using ConsoleAppPostgre;

// добавление данных
using (ApplicationContext db = new ApplicationContext())
{
    // создаем два объекта User
    User user1 = new User { Name = "Tom", Age = 33 };
    User user2 = new User { Name = "Alice", Age = 26 };
    User dima = new User { Name = "Дима", Age = 54 };
    User olga = new User { Name = "Ольга", Age = 45 };

    // добавляем их в бд
    db.Users.AddRange(user1, user2, dima, olga);
    db.SaveChanges();
//}
// получение данных
//using (ApplicationContext db = new ApplicationContext())
//{
    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Users list:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}