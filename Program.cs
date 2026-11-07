// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);
// Hero alexander = new Hero("   Александр   ", 150);

// alexander.TakeDamage(10);
// alexander.Heal(10);

// Console.WriteLine(">>> Участники готовы <<<");
// Console.WriteLine();
// Console.WriteLine(yaroslav.GetInfo());
// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());
// Console.WriteLine();
// Console.WriteLine(alexander.GetInfo());
// Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");

class Program
{
    static void Main()
    {
        Game persona = new Game("Persona 3 Reload", "JRPG", 2024, 10.0);
        Game zelda = new Game("The Legend Of Zelda: Breath Of The Wild", "Cool", 2017, 10.0);
        Game brokenGame = new Game("  ", "", 1800, 15.0);

        System.Console.WriteLine("Проверка инкапсуляции");
        System.Console.WriteLine($"Игра 1: [{persona.Title}], Год: {persona.ReleaseYear}, Рейтинг: {persona.Rating}");
        System.Console.WriteLine($"Игра 2: [{brokenGame.Title}], Жанр: {brokenGame.Genre}, Год: {brokenGame.ReleaseYear}, Рейтинг: {brokenGame.Rating}");
        System.Console.WriteLine("\nВызовы методов изменения состояния");
        System.Console.WriteLine($"До изменения: {persona.Title} - Рейтинг: {persona.Rating}");
        persona.UpdateRating(9.5);
        System.Console.WriteLine($"После допустимого: {persona.Title} - Рейтинг: {persona.Rating}");

        System.Console.WriteLine($"До изменения: {zelda.Title} - Рейтинг: {zelda.Rating}");
        zelda.UpdateRating(15.0);
        System.Console.WriteLine($"После недопустимого: {zelda.Title} - Рейтинг: {zelda.Rating}");

        System.Console.WriteLine("\nИтоговый вывод");
        PrintGameCard("Игра 1", persona);
        PrintGameCard("Игра 2", zelda);
    }
    static void PrintGameCard(string header, Game game)
    {
        System.Console.WriteLine($"{header}");
        System.Console.WriteLine($"Название: {game.Title}");
        System.Console.WriteLine($"Жанр: {game.Genre}");
        System.Console.WriteLine($"Год выхода: {game.ReleaseYear}");
        System.Console.WriteLine($"Рейтинг: {game.Rating}\n");
    }
}