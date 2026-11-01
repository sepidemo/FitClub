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
decimal memberFee;
bool isFeeNumber = decimal.TryParse(Console.ReadLine(), out memberFee);
if (isFeeNumber == false || memberFee < 0)
{
    Console.WriteLine("Invalid fee");
}
else
{
    decimal yearlyFee = memberFee * 12;
    Console.WriteLine($"Member {memberName}\nYearly fee:{yearlyFee}");
}
Console.WriteLine("please write a number:");
int numberInput;
bool isNumberInput = int.TryParse(Console.ReadLine(), out numberInput);
if (isNumberInput ==  false)
{
    Console.WriteLine("number is invalid try again");
}
else
{
    if (numberInput % 2 == 0)
    {
        Console.WriteLine("number is zoj");
    }
    else
    {
        Console.WriteLine("number is fard");
    }
}
Console.WriteLine("give me your age:");
int memberAge;
bool isAgeNumber = int.TryParse(Console.ReadLine(), out memberAge);
if (isAgeNumber == false || memberAge < 0)
{
    Console.WriteLine("Invalid age");
}
else
{
    if (memberAge < 13)
    {
        Console.WriteLine("member is kid");
        Console.WriteLine("Youth membership");
    }
    else if (memberAge >= 13 && memberAge <= 17)
    {
        Console.WriteLine("member is teen");
        Console.WriteLine("Youth membership");
    }
    else
    {
        Console.WriteLine("member is adult");
        Console.WriteLine("Adult membership");
    }
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
Console.WriteLine("How many members do you want to register?");
int registerCount;
bool isCountNumber = int.TryParse(Console.ReadLine(), out registerCount);
if (isCountNumber == false || registerCount < 0)
{
    Console.WriteLine("Invalid count");
    registerCount = 0;
}
decimal totalFee = 0;

for (int i = 0; i < registerCount; i++)
{
    Console.WriteLine("give name for membership:");
    string newMemberName = Console.ReadLine();
    Console.WriteLine("give fee for membership:");
    decimal newMemberFee;
    bool isNewFeeNumber = decimal.TryParse(Console.ReadLine(), out newMemberFee);
    if (isNewFeeNumber == false)
    {
        Console.WriteLine("Invalid fee, skipped.");
        continue;
    }
    decimal memberYearlyFee = newMemberFee * 12;
    Console.WriteLine(memberYearlyFee);
    totalFee += memberYearlyFee;
}
Console.WriteLine(totalFee);
int[] memberIds = { 101, 102, 103, 104 };
bool running = true;
while (running)
{
    Console.WriteLine("1 - View member");
    Console.WriteLine("2 - Check reservation");
    Console.WriteLine("3 - Search member by ID");
    Console.WriteLine("0 - Exit");
    Console.WriteLine("Choose an option:");
    int choice;
    string input = Console.ReadLine();
    bool isNumber = int.TryParse(input, out choice);

    if (isNumber == false)
    {
        Console.WriteLine("Invalid input, please enter a number.");
        continue;
    }
    switch (choice)
    {
        case 0:
            Console.WriteLine("Exit");
            running = false;
            break;
        case 1:
            Console.WriteLine("View member selected");
            Console.WriteLine("enter your name:");
            string viewMemberName = Console.ReadLine();
            Console.WriteLine("give your fee cost:");
            decimal tuitionFee;
            bool isTuitionNumber = decimal.TryParse(Console.ReadLine(), out tuitionFee);
            if (isTuitionNumber == false)
            {
                Console.WriteLine("invalid data");
                break;
            }
            string feePayment;


            Console.WriteLine("Has the fee been paid? (y/n)");
            string feePaidInput = Console.ReadLine();
            bool isPaid = feePaidInput == "y";
            feePayment = isPaid ? "paid" : "Payment required";
            Console.WriteLine($"{viewMemberName} has {tuitionFee} and {feePayment}.");
            break;
        case 2:
            Console.WriteLine("Check reservation selected");

            Console.WriteLine("give your active status (y/n):");
            string? isActive = Console.ReadLine();
            Console.WriteLine("give your remaining capacity status:");
            int remainingCapacity;
            bool isCapacityNumber = int.TryParse(Console.ReadLine(), out remainingCapacity);
            if (isCapacityNumber == false)
            {
                Console.WriteLine("invalid data");
                break;
            }
            if (isActive == "y")
            {
                if (remainingCapacity > 0)
                {
                    Console.WriteLine("Booking is permitted.");
                }
                else if (remainingCapacity == 0)
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

            break;
        case 3:
            Console.WriteLine("Give member id please:");
            int searchId;
            bool isSearchId = int.TryParse(Console.ReadLine(), out searchId);
            if (isSearchId  == false)
            {
                Console.WriteLine("invalid data");
                break;
            }
            bool found = false;
            for (int i = 0; i < memberIds.Length; i++)
            {
                if (searchId == memberIds[i])
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Member found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            break;
        default:
            Console.WriteLine("Invalid choice, choose again please (0/1/2/3)");
            break;
    }
}
