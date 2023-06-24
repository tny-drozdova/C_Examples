// For this method, we will take 3 numbers and will output the max. WE will do it for 9 numbers.
// The method is MAX and the number type we want to be returned - int.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1; //insider's result is where the arg1 will be stored (the max result at the end)
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// The function and the method's body above is resposible for the search of the max from 3variables;

int a1 = 15;
int b1 = 2341;
int c1 = 39;
int a2 = 12000;
int b2 = 23;
int c2 = 3333;
int a3 = 13;
int b3 = 23;
int c3 = 33;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

// four lines above are replaceble with the one line below and means the same:
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);


