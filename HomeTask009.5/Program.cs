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
  void recursion(int M, int N, int sum = 0)
  {
    if (M == N + 1) CW($"{sum}");
    if (M != N + 1) recursion(M + 1, N, sum = sum + M);
  }

  CWL("Задание 5. Программа, которая вычисляет сумму натуральных элементов в промежутке от M до N.");
  CWL("Введите число: ");
  int numberM = Int32.Parse(CR());
  int numberN = Int32.Parse(CR());
  CW($"Cумма натуральных элементов в промежутке от {numberM} до {numberN}: ");
  recursion(numberM, numberN);
}
catch (InvalidCastException e) { }
