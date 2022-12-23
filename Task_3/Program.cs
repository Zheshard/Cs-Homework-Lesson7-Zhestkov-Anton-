// Программа, формирующая двумерный массив из целых чисел и находящая среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите размерность массива: ");
int sizeColumn = InputNumber("Введите количество столбцов: ");
int sizeLine = InputNumber("Введите количество строк: ");
const int minValue = 0;
const int maxValue = 10;
System.Console.WriteLine();
int[,] arrayRandomNumbers = Fill2DArrayWithRandomRealNumbers(sizeLine, sizeColumn, minValue, maxValue);
Print2DArray(arrayRandomNumbers);
System.Console.WriteLine("Среднее арифметическое ");
CalculateAverageOfTheColumns(arrayRandomNumbers);


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

// Метод, формирующий двумерный массив, заполненный случайными  целыми числами. Размерность массива задается пользователем:
int[,] Fill2DArrayWithRandomRealNumbers(int numLines, int numColumns, int leftRange, int rigthRange)
{
	int[,] fillableArray = new int[numLines, numColumns];
	Random rand = new Random();
	for (int i = 0; i < fillableArray.GetLength(0); i++)
	{
		for (int j = 0; j < fillableArray.GetLength(1); j++)
		{
			fillableArray[i, j] = rand.Next(leftRange, rigthRange + 1);
		}
	}
	return fillableArray;
}

// Метод вывода двумерного массива в консоль:
void Print2DArray(int[,] outputArray)
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

// Метод, вычисляющий среднее арифметическое каждого столбца матрицы:
double CalculateAverageOfTheColumns(int[,] inputArray)
{
	double sumElemColumn = 0;
	double average = 0;
	for (int j = 0; j < inputArray.GetLength(1); j++)
	{
		for (int i = 0; i < inputArray.GetLength(0); i++)
		{
			sumElemColumn = sumElemColumn + Convert.ToDouble(inputArray[i, j]);
		}
		System.Console.WriteLine($"{sumElemColumn}; ");
		average = Math.Round((sumElemColumn / inputArray.GetLength(0)), 2);
		System.Console.WriteLine($"в столбце №{j}: {average}; ");
		sumElemColumn = 0;
	}
	return average;
}