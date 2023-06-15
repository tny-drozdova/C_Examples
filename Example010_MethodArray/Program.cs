/*How to determin the positions of the element we need:
Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
1. Установить счетчик index в позицию 0
2. Если array [index] = find, алгоритм завершил работу успешно.
3. Увеличить index на 1
4. Если index < n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспешно.*/



int[] array = { 1, 12, 18, 31, 4, 18, 15, 16, 17, 18 };
int n = array.Length; // Length returns the number of the elements in array
int find = 18; // We will be looking for element 4

int index = 0;  //Установить счетчик index в позицию 0

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; // index = index + 1;
}





