Console.Write("Flight Mil :");
double mil = Convert.ToDouble(Console.ReadLine());

if (mil <= 0)
{
    Console.Write("Wrong Usage!");
}
else
{
    double milprice = 0.1;
    double x = mil * milprice;

    Console.WriteLine("Normal Price :" + milprice * mil);
    Console.WriteLine("If you enter your other informations we can put discount on your normal price");
    Console.Write("Enter Age :");
    int age = Convert.ToInt32(Console.ReadLine());
    if (age < 0)
    {
        Console.Write("Wrong Usage");
    }
    else
    {
        if (age < 12)
        {
            Console.Write("Total:" + (x / 2) * 0.8);
        }
        else if (age >= 12 && age <= 24)
        {
            Console.Write("Total:" + (x * 0.9) * 0.8);
        }
        else if (age > 65)
        {
            Console.Write("Total:" + (x * 0.7) * 0.8);
        }
        else
        {
            Console.Write("Total:" + (x * 0.8));
        }
        Console.WriteLine("Please Choose Which One You Prefer For Flight\n1 :gidiş \n2 :geliş \n3 :gidiş dönüş ");
        int typeofflight = Convert.ToInt32(Console.ReadLine());
        if (typeofflight > 3 || typeofflight < 0)
        {
            Console.Write("Wrong Usage");
        }
    }
}
//eğer bir atırın ittiğini göstermek istiyorsan ordan içeri boşluk girdirmen lazım.