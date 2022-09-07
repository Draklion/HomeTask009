void CWL(string msg)
{
  Console.WriteLine(msg);
}
void CW(string msg)
{
  Console.Write(msg);
}
string CR()
{
  return Console.ReadLine();
}
try
{

  int recursion(int m, int n)
  {
    if (m == 0) return n + 1;
    if (n == 0) return recursion(m - 1, 1);
    return recursion(m - 1, recursion(m, n - 1));
  }

  CWL("Задание 6. Программа, которая вычисляет функцию Аккермана.");
  CWL("Введите число m: ");
  int numberM = Int32.Parse(CR());
  CWL("Введите число n: ");
  int numberN = Int32.Parse(CR());
  CW(numberM >= 0 && numberN >= 0 ?
  $"Результат вычисления функции Аккермана А({numberM},{numberN}) = {recursion(numberM, numberN)}"
  : "Заданы отрицательные значения.");
}
catch (InvalidCastException e) { }
