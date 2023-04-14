

//MAIN PROGRAM

Console.WriteLine("----------------Favorite Food---------------");
string[] arrayFavoriteFood = { "Apple", "Strawberry", "Meat", "Beer", "Wine", "Rise", };
printArrayString(arrayFavoriteFood);

Console.WriteLine("--------------------------------------------");
numberElementsArrayInString(arrayFavoriteFood);

Console.WriteLine("--------------------------------------------");
favoriteFoodclassifString(arrayFavoriteFood);
lessFavoriteFoodString(arrayFavoriteFood);

Console.WriteLine("--------------------------------------------");
























//FUNCTION
void printArrayString(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(i+1 + " - " + array[i]);
    }

}


void numberElementsArrayInString(string[] array)
{
    Console.WriteLine("This array have " + array.Length + " elements.");
}


void favoriteFoodclassifString(string[] array)
{
    Console.WriteLine(array[0] + " - THE BEST!");
}

void lessFavoriteFoodString(string[] array)
{
    Console.WriteLine(array[5] + " - SOMETIMES I DON'T LIKE IT.");
}









//NOTES
/*
 * FOR WRITE IN CONSOLE
Console.WriteLine(array[0]);


 * FOR WRITE IN CONSOLE THE ARRAY LENGTH (NUMBER)
Console.WriteLine(array.Length);


 * FOR WRITE IN CONSOLE THE ARRAY ELEMENTS
for (int i = 0; i < array; i++)
{
    Console.WriteLine(array[i]);
}


*/