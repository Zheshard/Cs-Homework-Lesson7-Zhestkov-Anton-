// Программа, формирующая двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите размерность массива: ");
int sizeColumn = InputNumber("Введите количество столбцов: ");
int sizeLine = InputNumber("Введите количество строк: ");
const int minValue = -100;
const int maxValue = 100;
double[,] arrayRandomRealNum = Fill2DArrayWithRandomRealNumbers(sizeLine, sizeColumn, minValue, maxValue);
Print2DArray(arrayRandomRealNum);

// ======================Методы==============================================================
// Метод, позволяющий ввести в консоль целое число и исключающий ввод других типов значений:
int InputNumber(string invitationText)
{
	int inputNum;
	while (true)
	{
		Console.Write(invitationText);
		string inputStr = Console.ReadLine();
		if (int.TryParse(inputStr, out inputNum))
		{
			break;
		}
		Console.WriteLine("Введено неверное значение!");
	}
	return inputNum;
}

// Метод, формирующий двумерный массив, заполненный случайными вещественными числами. Размерность массива задается пользователем:
double[,] Fill2DArrayWithRandomRealNumbers(int numLines, int numColumns, int leftRange, int rigthRange)
{
	double[,] fillableArray = new double[numLines, numColumns];
	Random rand = new Random();
	for (int i = 0; i < fillableArray.GetLength(0); i++)
	{
		for (int j = 0; j < fillableArray.GetLength(1); j++)
		{
			fillableArray[i, j] = Math.Round(rand.Next(leftRange, rigthRange) + rand.NextDouble(), 2);
		}
	}
	return fillableArray;
}

// Метод вывода двумерного массива в консоль:
void Print2DArray(double[,] outputArray)
{
	for (int i = 0; i < outputArray.GetLength(0); i++)
	{
		for (int j = 0; j < outputArray.GetLength(1); j++)
		{
			Console.Write($"| {outputArray[i, j]} \t");
		}
		Console.WriteLine("|");
	}
}