// For this method, we will take 3 numbers and will output the max. WE will do it for 9 numbers.
// The method is MAX and the number type we want to be returned - int.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1; //insider's result is where the arg1 will be stored (the max result at the end)
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//We need to define the array:
// Our element's index always starts with 0:
//              0   1   2   3   4   5   6   7   8
int[] array = { 112, 21, 31, 41, 15, 61, 117, 18, 19 };

// array[0] = 12; // To talk to our element and assign any number to it (in example below it's 12)
// Console.WriteLine(array[4]); // Example how to talk to array and get it's value based on the index

// How to find max of 9 numbers:

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);



