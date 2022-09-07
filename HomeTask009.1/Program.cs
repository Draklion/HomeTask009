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
  void recursion(int N, int i = 1)
  {
    if (i <= N)
    {
      CW($"{i} ");
      recursion(N, i + 1);
    }
  }

  CWL("Задание 1. Программа, которая выведет все натуральные числа в промежутке от 1 до N.");
  CWL("Введите число: ");
  int number = Int32.Parse(CR());
  CW($"Натуральные числа в промежутке от 1 до {number}: ");
  recursion(number);
}
catch (InvalidCastException e) { }
