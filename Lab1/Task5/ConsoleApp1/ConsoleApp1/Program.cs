using ConsoleApp1;
AddCulc Culc = new();

if (Culc.get_confirm())
{
    Console.WriteLine("Summ is : " + Culc.Add());
}