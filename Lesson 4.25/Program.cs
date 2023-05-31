var A = Convert.ToInt32 (Console.ReadLine ()); 
var B  = Convert.ToInt32 (Console.ReadLine ());
var C = 1;
for (int i = 0; i < B; i++) //возведение в степень это 1 умноженное A B раз
{
    C *= A;
}
Console.WriteLine(C);