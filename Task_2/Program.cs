// Программа, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите размерность массива: ");
int sizeColumn = InputNumber("Введите количество столбцов: ");
int sizeLine = InputNumber("Введите количество строк: ");
const int minValue = -100;
const int maxValue = 100;
int[,] arrayRandomNumbers = Fill2DArrayWithRandomRealNumbers(sizeLine, sizeColumn, minValue, maxValue);
Print2DArray(arrayRandomNumbers);
Console.WriteLine("Введите позицию искомого элемента: ");
int lineNum = InputNumber("Введите номер строки (нумерация с нуля): ");
int columnNum = InputNumber("Введите номер столбца (нумерация с нуля): ");
bool findElem = FindElementInArray(arrayRandomNumbers, lineNum, columnNum);

if (findElem == true)
{
	int elementValue = arrayRandomNumbers[lineNum, columnNum];
	System.Console.WriteLine($"Элемент в строке {lineNum}, столбце {columnNum} равен {elementValue}");
}
else
{
	System.Console.WriteLine("Элемента с такими индексами не существует");
}


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

// Метод, определяющий, существует ли в двумерном массиве элемент на позиции, которую ввел пользователь:
bool FindElementInArray(int[,] inputArray, int lineNumber, int columnNumber)
{
	if (lineNum < 0 || lineNum > arrayRandomNumbers.GetLength(0) - 1 || columnNum < 0 || columnNum > arrayRandomNumbers.GetLength(1) - 1)
	{
		return false;
	}
	else
	{
		return true;
	}
}
