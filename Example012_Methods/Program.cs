//Работа с текстом
/* Дан текст. В тексте нужно все пробелы заменить чёрточками,
маленькие буквы “к” заменить большими “К”,
а “.” заменить “?”.
*/

/*
string s = “qwerty”
            012345
В частности, если требуется обратиться к конкретному символу строки, мы можем это делать,
начиная отсчитывать позицию символов с 0. То есть «q» — это 0, «w» — 1, «e» — 2 и так далее.
Чтобы получить конкретный символ, мы можем через квадратные скобки обратиться, указать
идентификатор строки. Например:
// s[3] // r
*/


/*


string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
		   + "ежели бы вас послали вместо нашего милого Винценгероде,"
		   + "вы бы взяли приступом согласие прусского короля."
		   + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;     // initializing an empty line;
    int length = text.Length;   // to get the length of our line - text Length - return the length of our line
    for (int i = 0; i < length; i++)    //using FOR we will go through 0 symbol to the end of our line
    {
        if(text[i] == oldValue) result = result + $"{ newValue}";
        else result = result + $"{ text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');      // тексте нужно все пробелы заменить чёрточками’|’
Console.WriteLine(newText);
Console.WriteLine();     // Adding an aditinonal space to separate the next condition
newText = Replace(newText, 'k', 'K');      // тексте нужно все k заменить K
Console.WriteLine(newText);
Console.WriteLine();     // Adding an aditinonal space to separate the next condition
newText = Replace(newText, '.', '?');      // тексте нужно все . заменить чёрточками ?
Console.WriteLine(newText);


*/


//Наша задача — выбрать самый первый элемент и в оставшейся части, 
//с учётом нашей текущей позиции определить минимальный. 
//После того как он найден, нужно поменять выделенный (рабочий элемент), 
//на который сейчас указывает стрелочка, это 6, с единицей, являющейся для нас минимальной, в общем, выделенном куске.
/*1. Найти позицию минимального элемента в неотсортированной части массива.
2. Произвести обмен этого значения со значением первой неотсортированной позиции.
3. Повторять пока есть неотсортированные элементы.
Example: Было: 6 8 3 2 1 4 5 7
Стало: 1 8 3 2 6 4 5 7
Было: 1 8 3 2 6 4 5 7
Стало: 1 2 3 8 6 4 5 7
Результат: 1 2 3 4 5 6 7 8
*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)    //this method will display our array on the screen
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)    // THis method will organaze our array
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)    //this code will look for a max element only
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temprary = array[i];   // this code is responsible for swab
        array[i] = array[minPosition];   // this code is responsible for swab
        array[minPosition] = temprary;   // this code is responsible for swab
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
