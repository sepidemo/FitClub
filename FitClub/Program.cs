PrintHeader("FitClub - Gym Management System");

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
    decimal yearlyFee = CalculateYearlyFee(memberFee);
    Console.WriteLine($"Member {memberName}\nYearly fee:{yearlyFee}");
}

int numberInput = ReadInt("please write a number:");
if (numberInput % 2 == 0)
{
    Console.WriteLine("number is zoj");
}
else
{
    Console.WriteLine("number is fard");
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
    Console.WriteLine(GetMembershipType(memberAge));
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

int registerCount = ReadInt("How many members do you want to register?");
if (registerCount < 0)
{
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

    decimal memberYearlyFee = CalculateYearlyFee(newMemberFee);
    totalFee += memberYearlyFee;
    Console.WriteLine($"{newMemberName}: yearly fee {memberYearlyFee}");
}
Console.WriteLine($"Total yearly fee: {totalFee}");

int[] memberIds = { 101, 102, 103, 104 };
bool running = true;
while (running)
{
    PrintMenu();
    int choice = ReadInt("Choose an option:");

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

            Console.WriteLine("Has the fee been paid? (y/n)");
            string feePaidInput = Console.ReadLine();
            bool isPaid = feePaidInput == "y";
            string feePayment = isPaid ? "paid" : "Payment required";
            Console.WriteLine($"{viewMemberName} has {tuitionFee} and {feePayment}.");
            break;

        case 2:
            Console.WriteLine("Check reservation selected");
            Console.WriteLine("give your active status (y/n):");
            string? isActive = Console.ReadLine();
            int remainingCapacity = ReadInt("give your remaining capacity status:");

            bool active = isActive == "y";
            if (CheckReservation(active, remainingCapacity))
            {
                Console.WriteLine("Booking is permitted.");
            }
            else
            {
                Console.WriteLine("Booking is not possible.");
            }
            break;

        case 3:
            int searchId = ReadInt("Give member id please:");
            if (FindMemberIndex(memberIds, searchId, out int pos))
            {
                Console.WriteLine($"Member {searchId} found at index {pos}");
            }
            else
            {
                Console.WriteLine($"Member {searchId} not found");
            }
            break;

        default:
            Console.WriteLine("Invalid choice, choose again please (0/1/2/3)");
            break;
    }
}

// ===== توابع =====

void PrintHeader(string header)
{
    Console.WriteLine("=====\n" + header + "\n=====");
}

int ReadInt(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            return number;
        }
        Console.WriteLine("Invalid input. Please enter a whole number.");
    }
}

decimal CalculateYearlyFee(decimal monthlyFee, int months = 12)
{
    return monthlyFee * months;
}

void PrintMenu()
{
    Console.WriteLine("1 - View member");
    Console.WriteLine("2 - Check reservation");
    Console.WriteLine("3 - Search member by ID");
    Console.WriteLine("0 - Exit");
}

bool FindMemberIndex(int[] ids, int id, out int index)
{
    index = -1;
    for (int i = 0; i < ids.Length; i++)
    {
        if (ids[i] == id)
        {
            index = i;
            return true;
        }
    }
    return false;
}

string GetMembershipType(int memberAge)
{
    if (memberAge < 18)
    {
        return "Youth membership";
    }
    return "Adult membership";
}

bool CheckReservation(bool isActive, int remainingCapacity)
{
    return isActive && remainingCapacity > 0;
}
