// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте список чисел НегаФибоначчи, 
// в том числе для отрицательных индексов.
// *Пример:*
// - для k = 9 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

int[] CreateFibonacciArray(int[] AA)
{
    AA[0] = 0;
    AA[1] = 1;
    int size = AA.Length;
    int[] BB = new int[size * 2 - 1];
    for (int i = 2; i < size; i++)
    {
        AA[i] = AA[i - 2] + AA[i - 1];
    }
    int ii = size - 1;
    for (int iii = 0; iii < size; iii++)
    {
        BB[ii] = -AA[iii];
        ii--;
    }
    int t = size;
    for (int k = 1; k < size; k++)
    {
        BB[t] = AA[k];
        t++;
    }
    return BB;
}

void ShowArray(int[] AA)
{
    foreach (int element in AA)
        Console.Write(element + "; ");
}

int[] AA = new int[9];
int[] SS = CreateFibonacciArray(AA);
ShowArray(SS);
