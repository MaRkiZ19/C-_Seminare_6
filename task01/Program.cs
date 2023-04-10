// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. ДЗ 4 задача 2
//Первый вариант, более затратный, через массив

//Console.WriteLine(GetSumFromInt(12345));

int GetSumFromString(string number)
{
	int result = 0;

	for (int i = 0; i < number.Length; i++)
	{
		result += int.Parse(number[i].ToString());
	}

	return result;
}

/*Второй вариант, математический, мез массива
int GetSumFromInt(int number)
{
	int result = 0;

	for (int i = number; i > 0; i /= 10)
	{
		result += i % 10;
	}

	return result;
}
*/
