// this code generates two random numbers (numberA and numberB) between 1 and 10, 
// displays them on the console, calculates their sum (result), and outputs the sum to the console as well.

int numberA = new Random().Next(1, 10); // 1 2 3 4 5 .. 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);

