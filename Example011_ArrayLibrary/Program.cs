// For the following task we defied the array of 10 elements, then we filled the array, and then we print the array

void FillArray(int[] collection) // This is the method FillArray that will accept argument - collection
{
    int Length = collection.Length; // this will allow to get the lenht of our array
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10); // WE want to insert a rendom number in our argument Collection withing the diapason of 1-10
        index++;  //index = index +1;
    }

}

void PrintArray (int[] collec)   // void method doesn't return any calues;
{
    int count = collec.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collec[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // this will find the possition of our element by using the method (IndexOf in this case)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;   // We use -1 to force and show all elements, even if requested element is not present, otherwise we use 0 to show element that includes the requested element
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];  // new int[10] means to create an array of 10 elements 


// TO Test the methods we need to call them:
FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);   // Here we show the element which position we want to display additononaly at the end. If the elemen is not in our array, we will see 0.
Console.WriteLine(pos);
