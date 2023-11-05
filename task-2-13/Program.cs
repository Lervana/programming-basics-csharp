// 2.13. Napisz program, który konwertuje temperaturę z Celsiusza na Fahrenheit
//       lub odwrotnie, w zależności od ustawienia flagi typu bool.

var value = 36.6;
var isCelcius = true;

var message1 = isCelcius ? "C" : "F";
var message2 = isCelcius ? "F" : "C";
var newValue = isCelcius ? Math.Round((value * 9 / 5) + 32) : Math.Round((value - 32) * 5 / 9, 2);


Console.Write($"{value}°{message1} = {newValue}°{message2}");

Console.ReadLine();