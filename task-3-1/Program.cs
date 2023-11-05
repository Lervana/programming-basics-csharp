// 3.1. Napisz program, który zapyta użytkownika o jego imię, pozwoli na jego
//      wpisanie i następnie je wyświetli na ekranie. Przykład:
//      > Proszę podać imię: Kasia
//      > Witaj Kasia!

Console.Write("Proszę podać imię: ");
string imie = Console.ReadLine();

Console.WriteLine("Witaj " + imie + "!");

Console.ReadLine();