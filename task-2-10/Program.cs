// 2.10. Czy w zadaniu 9 można byłoby użyć Convert.ToInt16? Jeśli tak/nie
//       to dlaczego? Jakie są potencjalne korzyści/wady takiej zmiany?

//       W poprzednim zadaniu można użyć Convert.ToInt16, wynik będzie taki sam
//       jak w przypadku Convert.ToInt32, ponieważ wartości logiczne true
//       i false w języku C# są reprezentowane jako odpowiednio 1 i 0, a oba te
//       typy danych (Int16 i Int32) mogą przechowywać te wartości.
//
//       Występują jednak pewne różnice:
//       - Int16(krótka) zajmuje mniej miejsca w pamięci niż Int32 (całkowita).
//       - Int16 zajmuje 16 bitów (2 bajty), Int32 zajmuje 32 bity (4 bajty).
//       - Int16 ma mniejszy zakres wartości w porównaniu do Int32.

Console.ReadLine();