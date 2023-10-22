// 2.9. Stwórz program wyświetlający poniższe tablice prawdy, wynik każdego
//      z obliczeń ma być zapisany jako operacja logiczna. W zadaniu można
//      wykorzystać tylko takie elementy jak: zmienne, Console.WriteLine,
//      operatory logiczne oraz Convert.ToInt32:
//      (a) a OR  b
//      (b) a AND b
//      (c) (~ a OR c) OR(~b OR c)
//      (d) [(~a OR ~c) OR(~a OR b)] AND ~b
//      (e) [(~a AND ~b) OR(a AND b)] OR (a AND ~c)

using static System.Runtime.InteropServices.JavaScript.JSType;

bool a, b, c;

// a) a OR b
Console.WriteLine("(a) Tabela prawdy dla a OR b:");
Console.WriteLine();
Console.WriteLine("| a | b | a v b |");
Console.WriteLine("-----------------");

a = false;
b = false;

Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} |   {Convert.ToInt32(a || b)}   |");

a = false;
b = true;

Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} |   {Convert.ToInt32(a || b)}   |");

a = true;
b = false;

Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} |   {Convert.ToInt32(a || b)}   |");

a = true;
b = true;

Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} |   {Convert.ToInt32(a || b)}   |");

bool memory1, memory2, memory3, memory4, memory5, memory6;

// b) a AND b
Console.WriteLine();
Console.WriteLine("(b) Tabela prawdy dla a AND b:");
Console.WriteLine();
Console.WriteLine("| a | b | a ∧ b |");
Console.WriteLine("-----------------");

a = false;
b = false;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} |   {Convert.ToInt32(a && b)}   |");

a = false;
b = true;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} |   {Convert.ToInt32(a && b)}   |");

a = true;
b = false;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} |   {Convert.ToInt32(a && b)}   |");

a = true;
b = true;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} |   {Convert.ToInt32(a && b)}   |");

// c) (~ a OR c) OR (~b OR c)
Console.WriteLine();
Console.WriteLine("(c) Tabela prawdy dla (~a OR c) OR (~b OR c):");
Console.WriteLine();
Console.WriteLine("| a | b | c | ~a | ~b | ~a v c | ~b v c | (~a v c) v (~b v c) |");
Console.WriteLine("---------------------------------------------------------------");

a = false;
b = false;
c = false;
var notA = !a;
var notB = !b;
var notAOrC = notA || c;
var notBOrC = notB || c;
var finalResult = notAOrC || notBOrC;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |    {Convert.ToInt32(notAOrC)}   |    {Convert.ToInt32(notBOrC)}   |          {Convert.ToInt32(finalResult)}          |");

a = false;
b = false;
c = true;
notA = !a;
notB = !b;
notAOrC = notA || c;
notBOrC = notB || c;
finalResult = notAOrC || notBOrC;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |    {Convert.ToInt32(notAOrC)}   |    {Convert.ToInt32(notBOrC)}   |          {Convert.ToInt32(finalResult)}          |");

a = false;
b = true;
c = false;
notA = !a;
notB = !b;
notAOrC = notA || c;
notBOrC = notB || c;
finalResult = notAOrC || notBOrC;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |    {Convert.ToInt32(notAOrC)}   |    {Convert.ToInt32(notBOrC)}   |          {Convert.ToInt32(finalResult)}          |");

a = false;
b = true;
c = true;
notA = !a;
notB = !b;
notAOrC = notA || c;
notBOrC = notB || c;
finalResult = notAOrC || notBOrC;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |    {Convert.ToInt32(notAOrC)}   |    {Convert.ToInt32(notBOrC)}   |          {Convert.ToInt32(finalResult)}          |");

a = true;
b = false;
c = false;
notA = !a;
notB = !b;
notAOrC = notA || c;
notBOrC = notB || c;
finalResult = notAOrC || notBOrC;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |    {Convert.ToInt32(notAOrC)}   |    {Convert.ToInt32(notBOrC)}   |          {Convert.ToInt32(finalResult)}          |");

a = true;
b = false;
c = true;
notA = !a;
notB = !b;
notAOrC = notA || c;
notBOrC = notB || c;
finalResult = notAOrC || notBOrC;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |    {Convert.ToInt32(notAOrC)}   |    {Convert.ToInt32(notBOrC)}   |          {Convert.ToInt32(finalResult)}          |");

a = true;
b = true;
c = false;
notA = !a;
notB = !b;
notAOrC = notA || c;
notBOrC = notB || c;
finalResult = notAOrC || notBOrC;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |    {Convert.ToInt32(notAOrC)}   |    {Convert.ToInt32(notBOrC)}   |          {Convert.ToInt32(finalResult)}          |");

a = true;
b = true;
c = true;
notA = !a;
notB = !b;
notAOrC = notA || c;
notBOrC = notB || c;
finalResult = notAOrC || notBOrC;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |    {Convert.ToInt32(notAOrC)}   |    {Convert.ToInt32(notBOrC)}   |          {Convert.ToInt32(finalResult)}          |");

// d) [(~a OR ~c) OR(~a OR b)] AND ~b
Console.WriteLine();
Console.WriteLine("(d) Tabela prawdy dla [(~a OR ~c) OR (~a OR b)] AND ~b:");
Console.WriteLine();
Console.WriteLine("| a | b | c | ~a | ~b | ~c | ~a v ~c | ~a v b | (~a v ~c) v (~a v b) | [(~a v ~c) v (~a v b)] ∧ ~b |");
Console.WriteLine("----------------------------------------------------------------------------------------------------");

a = false;
b = false;
c = false;
notA = !a;
notB = !b;
var notC = !c;
var notAOrNotC = notA || notC;
var notAOrB = notA || b;
var notAOrNotCOrNotAOrB = notAOrNotC || notAOrB;
finalResult = notAOrNotCOrNotAOrB && notB;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} |    {Convert.ToInt32(notAOrNotC)}    |    {Convert.ToInt32(notAOrB)}   |           {Convert.ToInt32(notAOrNotCOrNotAOrB)}          |            {Convert.ToInt32(finalResult)}                |");

a = false;
b = false;
c = true;
notA = !a;
notB = !b;
notC = !c;
notAOrNotC = notA || notC;
notAOrB = notA || b;
notAOrNotCOrNotAOrB = notAOrNotC || notAOrB;
finalResult = notAOrNotCOrNotAOrB && notB;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} |    {Convert.ToInt32(notAOrNotC)}    |    {Convert.ToInt32(notAOrB)}   |           {Convert.ToInt32(notAOrNotCOrNotAOrB)}          |            {Convert.ToInt32(finalResult)}                |");

a = false;
b = true;
c = false;
notA = !a;
notB = !b;
notC = !c;
notAOrNotC = notA || notC;
notAOrB = notA || b;
notAOrNotCOrNotAOrB = notAOrNotC || notAOrB;
finalResult = notAOrNotCOrNotAOrB && notB;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} |    {Convert.ToInt32(notAOrNotC)}    |    {Convert.ToInt32(notAOrB)}   |           {Convert.ToInt32(notAOrNotCOrNotAOrB)}          |            {Convert.ToInt32(finalResult)}                |");

a = false;
b = true;
c = true;
notA = !a;
notB = !b;
notC = !c;
notAOrNotC = notA || notC;
notAOrB = notA || b;
notAOrNotCOrNotAOrB = notAOrNotC || notAOrB;
finalResult = notAOrNotCOrNotAOrB && notB;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} |    {Convert.ToInt32(notAOrNotC)}    |    {Convert.ToInt32(notAOrB)}   |           {Convert.ToInt32(notAOrNotCOrNotAOrB)}          |            {Convert.ToInt32(finalResult)}                |");

a = true;
b = false;
c = false;
notA = !a;
notB = !b;
notC = !c;
notAOrNotC = notA || notC;
notAOrB = notA || b;
notAOrNotCOrNotAOrB = notAOrNotC || notAOrB;
finalResult = notAOrNotCOrNotAOrB && notB;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} |    {Convert.ToInt32(notAOrNotC)}    |    {Convert.ToInt32(notAOrB)}   |           {Convert.ToInt32(notAOrNotCOrNotAOrB)}          |            {Convert.ToInt32(finalResult)}                |");

a = true;
b = false;
c = true;
notA = !a;
notB = !b;
notC = !c;
notAOrNotC = notA || notC;
notAOrB = notA || b;
notAOrNotCOrNotAOrB = notAOrNotC || notAOrB;
finalResult = notAOrNotCOrNotAOrB && notB;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} |    {Convert.ToInt32(notAOrNotC)}    |    {Convert.ToInt32(notAOrB)}   |           {Convert.ToInt32(notAOrNotCOrNotAOrB)}          |            {Convert.ToInt32(finalResult)}                |");

a = true;
b = true;
c = false;
notA = !a;
notB = !b;
notC = !c;
notAOrNotC = notA || notC;
notAOrB = notA || b;
notAOrNotCOrNotAOrB = notAOrNotC || notAOrB;
finalResult = notAOrNotCOrNotAOrB && notB;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} |    {Convert.ToInt32(notAOrNotC)}    |    {Convert.ToInt32(notAOrB)}   |           {Convert.ToInt32(notAOrNotCOrNotAOrB)}          |            {Convert.ToInt32(finalResult)}                |");

a = true;
b = true;
c = true;
notA = !a;
notB = !b;
notC = !c;
notAOrNotC = notA || notC;
notAOrB = notA || b;
notAOrNotCOrNotAOrB = notAOrNotC || notAOrB;
finalResult = notAOrNotCOrNotAOrB && notB;
Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} |  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} |    {Convert.ToInt32(notAOrNotC)}    |    {Convert.ToInt32(notAOrB)}   |           {Convert.ToInt32(notAOrNotCOrNotAOrB)}          |            {Convert.ToInt32(finalResult)}                |");


// e) [(~a AND ~b) OR(a AND b)] OR (a AND ~c)
Console.WriteLine();
Console.WriteLine("(e) Tabela prawdy dla [(~a AND ~b) OR (a AND b)] OR (a AND ~c):");
Console.WriteLine();
Console.WriteLine("| a | b | c | ~a | ~b | ~c | ~a ∧ ~b | a ∧ b | (~a ∧ ~b) v (a ∧ b) | a ∧ ~c | [(~a ∧ ~b) v (a ∧ b)] v (a ∧ ~c) |");
Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

a = false;
b = false;
c = false;
notA = !a;
notB = !b;
notC = !c;
var notAOrNotB = !a || notC;
var aAndB = a && b;
var notAOrNotBOrAAndB = notAOrNotB || aAndB;
var aAndNotC = a && notC;
finalResult = notAOrNotBOrAAndB || aAndNotC;

Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} " +
    $"|  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} " +
    $"|    {Convert.ToInt32(notAOrNotB)}    |   {Convert.ToInt32(aAndB)}   |           {Convert.ToInt32(notAOrNotBOrAAndB)}         " +
    $"|    {Convert.ToInt32(finalResult)}   |                       {Convert.ToInt32(finalResult)}          |");

a = false;
b = false;
c = true;
notA = !a;
notB = !b;
notC = !c;
notAOrNotB = !a || notC;
aAndB = a && b;
notAOrNotBOrAAndB = notAOrNotB || aAndB;
aAndNotC = a && notC;
finalResult = notAOrNotBOrAAndB || aAndNotC;

Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} " +
    $"|  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} " +
    $"|    {Convert.ToInt32(notAOrNotB)}    |   {Convert.ToInt32(aAndB)}   |           {Convert.ToInt32(notAOrNotBOrAAndB)}         " +
    $"|    {Convert.ToInt32(finalResult)}   |                       {Convert.ToInt32(finalResult)}          |");

a = false;
b = true;
c = false;
notA = !a;
notB = !b;
notC = !c;
notAOrNotB = !a || notC;
aAndB = a && b;
notAOrNotBOrAAndB = notAOrNotB || aAndB;
aAndNotC = a && notC;
finalResult = notAOrNotBOrAAndB || aAndNotC;

Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} " +
    $"|  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} " +
    $"|    {Convert.ToInt32(notAOrNotB)}    |   {Convert.ToInt32(aAndB)}   |           {Convert.ToInt32(notAOrNotBOrAAndB)}         " +
    $"|    {Convert.ToInt32(finalResult)}   |                       {Convert.ToInt32(finalResult)}          |");

a = false;
b = true;
c = true;
notA = !a;
notB = !b;
notC = !c;
notAOrNotB = !a || notC;
aAndB = a && b;
notAOrNotBOrAAndB = notAOrNotB || aAndB;
aAndNotC = a && notC;
finalResult = notAOrNotBOrAAndB || aAndNotC;

Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} " +
    $"|  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} " +
    $"|    {Convert.ToInt32(notAOrNotB)}    |   {Convert.ToInt32(aAndB)}   |           {Convert.ToInt32(notAOrNotBOrAAndB)}         " +
    $"|    {Convert.ToInt32(finalResult)}   |                       {Convert.ToInt32(finalResult)}          |");

a = true;
b = false;
c = false;
notA = !a;
notB = !b;
notC = !c;
notAOrNotB = !a || notC;
aAndB = a && b;
notAOrNotBOrAAndB = notAOrNotB || aAndB;
aAndNotC = a && notC;
finalResult = notAOrNotBOrAAndB || aAndNotC;

Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} " +
    $"|  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} " +
    $"|    {Convert.ToInt32(notAOrNotB)}    |   {Convert.ToInt32(aAndB)}   |           {Convert.ToInt32(notAOrNotBOrAAndB)}         " +
    $"|    {Convert.ToInt32(finalResult)}   |                       {Convert.ToInt32(finalResult)}          |");

a = true;
b = false;
c = true;
notA = !a;
notB = !b;
notC = !c;
notAOrNotB = !a || notC;
aAndB = a && b;
notAOrNotBOrAAndB = notAOrNotB || aAndB;
aAndNotC = a && notC;
finalResult = notAOrNotBOrAAndB || aAndNotC;

Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} " +
    $"|  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} " +
    $"|    {Convert.ToInt32(notAOrNotB)}    |   {Convert.ToInt32(aAndB)}   |           {Convert.ToInt32(notAOrNotBOrAAndB)}         " +
    $"|    {Convert.ToInt32(finalResult)}   |                       {Convert.ToInt32(finalResult)}          |");

a = true;
b = true;
c = false;
notA = !a;
notB = !b;
notC = !c;
notAOrNotB = !a || notC;
aAndB = a && b;
notAOrNotBOrAAndB = notAOrNotB || aAndB;
aAndNotC = a && notC;
finalResult = notAOrNotBOrAAndB || aAndNotC;

Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} " +
    $"|  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} " +
    $"|    {Convert.ToInt32(notAOrNotB)}    |   {Convert.ToInt32(aAndB)}   |           {Convert.ToInt32(notAOrNotBOrAAndB)}         " +
    $"|    {Convert.ToInt32(finalResult)}   |                       {Convert.ToInt32(finalResult)}          |");

a = true;
b = true;
c = true;
notA = !a;
notB = !b;
notC = !c;
notAOrNotB = !a || notC;
aAndB = a && b;
notAOrNotBOrAAndB = notAOrNotB || aAndB;
aAndNotC = a && notC;
finalResult = notAOrNotBOrAAndB || aAndNotC;

Console.WriteLine($"| {Convert.ToInt32(a)} | {Convert.ToInt32(b)} | {Convert.ToInt32(c)} " +
    $"|  {Convert.ToInt32(notA)} |  {Convert.ToInt32(notB)} |  {Convert.ToInt32(notC)} " +
    $"|    {Convert.ToInt32(notAOrNotB)}    |   {Convert.ToInt32(aAndB)}   |           {Convert.ToInt32(notAOrNotBOrAAndB)}         " +
    $"|    {Convert.ToInt32(finalResult)}   |                       {Convert.ToInt32(finalResult)}          |");
