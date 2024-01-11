
void PrintArray(string[] arr){
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + "  ");
    Console.WriteLine();
}

//{"Russia", "Denmark", "Kazan"}
//{"1234", "1567", "-2", "computer science"};
//{"Hello", "2", "world", ":-)"};
//{"Hello", "Bye", "2", "Congregation", ":-)"};
string[] strArray = {"Hello", "Bye", "2", "Congregation", ":-)"};
string[] resultSet;
int i, j;
int size = 0;

for (i = 0; i < strArray.Length; i++)
{
    if (strArray[i].Length <= 3)
        size++;
}
resultSet = new string[size];
for ( j = 0; j < strArray.Length; j++)
{
    if (strArray[j].Length > 3)
        continue;
    for ( i = 0; i < resultSet.Length; i++)
    {
        if (resultSet[i] == null){
            resultSet[i] = strArray[j];
            break;
        }
        else continue;
    }
}

Console.WriteLine("Заданный массив: ");
PrintArray(strArray);
Console.WriteLine("Искомый массив: ");
PrintArray(resultSet);
