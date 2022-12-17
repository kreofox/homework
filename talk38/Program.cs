Console.Clear();
Random random = new Random();
const int N = 10;
int[] vector = new int[N];
 
Console.WriteLine("Исходный массив");
 
for (int i = 0; i < N; i++)
{
    vector[i] = random.Next(1, 9);
    Console.Write("{0} ", vector[i]);
}
 
Console.WriteLine("\nЧетные");
 
 
for (int i = 0; i < N; i++)
{
    if (vector[i] % 2 == 0)
        {
            Console.Write("{0} ", vector[i]);
        }
}
 
Console.WriteLine("\nНечетные");
 
for (int i = 0; i < N; i++)
{
    if (vector[i] % 2 != 0)
        {
            Console.Write("{0} ", vector[i]);
        }
}
