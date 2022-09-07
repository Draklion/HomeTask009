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
  void recursion(int N, int sum = 0)
  {
    if (N % 10 == 0) CW($"{sum}");
    if (N % 10 != 0)
    {
      sum = sum + N % 10;
      recursion(N / 10, sum);
    }
  }

  CWL("Задание 2. Программа, которая будет принимать на вход число и возвращать сумму его цифр.");
  CWL("Введите число: ");
  int number = Int32.Parse(CR());
  CW($"Сумма цифр числа {number} равна: ");
  recursion(number);
}
catch (InvalidCastException e) { }
