//Math >=90 OR Chemistry >=90;

//math && chemistry || math && biology || chemistry && biology

int math, chemistry, biology;

Console.WriteLine("Enter your biology result");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result");
chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your math result");
math = Int32.Parse(Console.ReadLine());

if (chemistry >= 90 && math >= 90 || math >= 90 && biology >= 90 || biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congrats!");
}
else
{
    Console.WriteLine("Your application was denied.");
}


