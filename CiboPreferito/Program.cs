Console.WriteLine("----------------Favorite Food---------------");

//MAIN PROGRAM
string[] arrayFavoriteFood = { "Apple", "Strawberry", "Meat", "Beer", "Wine", "Rise", };

printArrayString(arrayFavoriteFood);





//FUNCTION
void printArrayString(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(" - " + array[i]);
    }

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