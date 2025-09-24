 
// Variables
string? userInput;
int secondsInput = 0, days, hours, minutes, seconds;
double totalDays;

// Constants
const int secondsInMinute = 60;
const int secondsInHour = 3600;
const int secondsInDay = 86400;

// Process
Console.WriteLine("Please Enter the Number of Seconds You want to Convert. i.e., 123456");
 
userInput = Console.ReadLine();

while (string.IsNullOrEmpty(userInput) || !int.TryParse(userInput, out secondsInput) || secondsInput < 0)
{
    Console.WriteLine("Please Enter a valid Input. The Number of Seconds You want to Convert.");
    userInput = Console.ReadLine();
}

days = secondsInput / secondsInDay;
hours = (secondsInput - days * secondsInDay) / secondsInHour ;
minutes = ((secondsInput % secondsInDay) % secondsInHour) / secondsInMinute ;
seconds = (secondsInput % secondsInDay) % secondsInHour % secondsInMinute ;
totalDays = (double) secondsInput / secondsInDay;

// Output
Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Days: {days}");
Console.WriteLine("{0}.{1}:{2}:{3}", days, hours, minutes, seconds);
Console.WriteLine("In total, that's {0} days", totalDays );
