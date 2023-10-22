// 2.12. Stwórz program, który sprawdza, czy podany rok jest rokiem przestępnym
//       i informuje użytkownika o wyniku.

// int year = 2000;
// int year = 2010;
int year = 2024;

if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {
    Console.WriteLine($"Rok {year} jest przestępny.");
} else {
    Console.WriteLine($"Rok {year} nie jest przestępny.");
}
