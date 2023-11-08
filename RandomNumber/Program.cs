
Random rnd = new Random();

//int myRandomNum = rnd.Next(0, 11); //0-10
//Console.WriteLine($"My random number is: {myRandomNum}");

int myRandomNum;

int randomsum = 0;



for (int i = 0; i < 3; i++) 
{
    myRandomNum = rnd.Next(0, 11);
    randomsum = randomsum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}


Console.WriteLine($"random sum total: {randomsum}");
