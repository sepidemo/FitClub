Console.WriteLine("FitClub");
Console.WriteLine("=======");
Console.WriteLine("Gym Management System");
string gymName = "FitClub";

int memberCount = 120;
Console.WriteLine($"{gymName} has {memberCount} members.");
string city = "Tehran";
int age = 25;
Console.WriteLine($"FitClub now is available in {city} and Average age at registration is {age}");

Console.WriteLine("please write member name:");
string memberName = Console.ReadLine();
Console.WriteLine("please write Monthly tuition fee:");
decimal memberFee = decimal.Parse(Console.ReadLine());
decimal yearlyFee = memberFee * 12;
Console.WriteLine($"Member {memberName}\nYearly fee:{yearlyFee}");
Console.WriteLine("please write numberkarbar:");
int numberkarbar = int.Parse(Console.ReadLine());
if (numberkarbar % 2 == 0)

{
    Console.WriteLine("number is zoj");
}
else
{
    Console.WriteLine("number is fard");
}
Console.WriteLine("give me your age:");
int memberage = int.Parse(Console.ReadLine());
if (memberage < 13)
{
    Console.WriteLine("member is kid");
}
else if (memberage >= 13 && memberage <= 17)
{
    Console.WriteLine("member is teen");
}
else
{
    Console.WriteLine("member is adult");
}
Console.WriteLine("Has the fee been paid? y/n");
string feeInput = Console.ReadLine();
if (feeInput == "y")
{
    Console.WriteLine("The fee has been paid.");
}
else if (feeInput == "n")
{
    Console.WriteLine("Payment required.");
}
if (memberage < 18)
{
    Console.WriteLine("Youth membership");
}
else
{
    Console.WriteLine("Adult membership");
}

Console.WriteLine("How many members do you want to register?");
int registerCount = int.Parse(Console.ReadLine());
decimal totalFee = 0;

for (int i = 0; i < registerCount; i++)
{
    Console.WriteLine("give name for membership:");
    string newMemberName = Console.ReadLine();
    Console.WriteLine("give fee for membership:");
    decimal newMemberFee = decimal.Parse(Console.ReadLine());
    decimal memberYearlyFee = newMemberFee * 12;
    Console.WriteLine(memberYearlyFee);
    totalFee += memberYearlyFee;
}
Console.WriteLine(totalFee);
Console.WriteLine("give your active status (y/n):");
string? isActive = Console.ReadLine();
Console.WriteLine("give your remaining capacity status:");
int remainingCapacity = int.Parse(Console.ReadLine());
if (isActive == "y")
{
    if (remainingCapacity > 0)
    {
        Console.WriteLine("Booking is permitted.");
    }
    else if (remainingCapacity ==0 )
    {
        Console.WriteLine("Capacity is full.");
    }
    else
    {
        Console.WriteLine("Invalid capacity.");
    }
}
else if (isActive == "n")
{
    Console.WriteLine("Membership is inactive.");
}
else
{
    Console.WriteLine("Invalid status. Enter y or n.");
}