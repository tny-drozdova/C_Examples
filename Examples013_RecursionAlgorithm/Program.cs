// Example: таблицa строк.

/*
string[,] table = new string[2, 5];
// String.Empty  //для строк инициализация происходит через константу Empty - the lines will be empty

// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]  
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]

table[1, 2] = "word";    //Чтобы обратиться к нужному элементу, указываем имя массива и в квадратных скобках пишем индекс строки (1) и индекс столбца (2). 
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/





/*
// Example: Table with digits.

// Определим двумерный массив, назовём
// его matrix и укажем для него, например, 3 строки и 4 столбца. Затем поступим аналогично, используя
// циклы. Вместо rows можно написать i (внешний цикл, щёлкающий строки), вместо columns — j
// (внутренний цикл, щёлкающий столбцы). Выводим на экран. Там, где в прошлом примере был дефис
// (минус), поставим пробел. 

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);      // interval [1; 10)
        }
    }

}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/


/*
// Теперь давайте попробуем написать код, который позволит нам взять картинку и закрасить область внутри контура. 

int[,] pic = new int[,]  // Не обязательно указывать количество строк и столбцов, если у вас есть фиксированные данные
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};


void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");  //if our coordinates=0, then we print nothing " "
            else Console.Write($"+");   //if our coordinates=1, then we print plus "+"
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col) //method FillImage, в качестве аргумента я укажу позицию строки и пикселя, с которого мы должны будем начать закраску.
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);  //поднимаемся на строчку выше
        FillImage(row, col - 1);  //потом идём влево (row, col-1),
        FillImage(row + 1, col);  //потом вниз (row+1, col)
        FillImage(row, col + 1);  //потом вправо (row, col+1).
    }
}
PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);
*/


/*
// Factorial:
//Определим функцию или метод, который будет принимать число, факториал которого нужно вычислить. 
//Кэто снова метод, который принимает какой-то аргумент (в частности,число) и возвращает факториал этого числа. 

int Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(5));      // the factorial will be calculated for the number that we will call, ex:3 +> 1 * 2 * 3 = 6, where 6 is a factorial
Console.WriteLine(); 

// We use double to calculate larger number, for example factorial for all numbers less than 40:
double FactorialBig(int num)
{
 // 1! = 1
 // 0! = 1
 if(num == 1) return 1;
 else return num * FactorialBig(num-1);
}
for (int j = 1; j < 40; j++)
{
 Console.WriteLine($"{j}! = {FactorialBig(j)}");
}
*/





// FIBONACCI
// числа Фибоначчи, где каждое следующее число задаётся предыдущим.
// функция Fibonacci. В качестве аргумента указываем n, eсли значение n=1 или n=2, возвращаем 1. 
// Иначе мы хотим вернуть Fibonacci(n-1) + Fibonacci(n-2).

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}
Console.WriteLine();
//По аналогии с факториалом попробуем посчитать первые 50 чисел Фибоначчи так, чтобы возвращалось double-значение. 

double FibonacciBig(int n)
{
 if(n == 1 || n == 2) return 1;
 else return FibonacciBig(n-1) + FibonacciBig(n-2);
}
for (int j = 1; j < 50; j++)
{
 Console.WriteLine($"f({j}) = {FibonacciBig(j)}");
}