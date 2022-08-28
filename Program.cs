
using static System.Console;
//
using WeekDay2;

//call function\
//Soal No.1
/**
WriteLine("Before Random");
int[] n = { 15, 2, 30, 12, 10, 5 };
var myArray = ArrayTest.InitArrayInt(n);
ArrayTest.DisplayArrayInt(myArray);
WriteLine();
WriteLine();
var myRandom = ArrayTest.ArrayRandom(n);
ArrayTest.DisplayArrayInt(myRandom);
//Write(myRandom);
**/



/**
WriteLine("Soal No.2");
WriteLine("Before Shifting : ");
int[] n = { 15, 2, 30, 12, 10, 5 };
var myArray = ArrayTest.InitArrayInt(n);
ArrayTest.DisplayArrayInt(myArray);
WriteLine();
WriteLine("After Random Position  Element Change :");
var myShift = ArrayTest.Shifting(n);
ArrayTest.DisplayArrayInt(myShift);
**/


/**
WriteLine("Soal No.3");
WriteLine("Rotate Shifting ke n :");
int[] n = { 15, 2, 30, 12, 10, 5 };
var myArray = ArrayTest.InitArrayInt(n);
ArrayTest.DisplayArrayInt(myArray);
WriteLine();
var shifting = ArrayTest.ShiftingTerus(n);
ArrayTest.DisplayArrayInt(shifting);
**/



/** Matrix */

/**
Matrix.InitMatrix();
var myMatrix = Matrix.FillRandomMatrix(5, 5);
Matrix.DisplayMatrix(myMatrix);

WriteLine();
var matrixDiagonal = Matrix.MatrixDiagonal(5, 5);
Matrix.DisplayMatrix(matrixDiagonal);
**/

/**
var matrix=Matrix.Soal10(5,5);
Matrix.DisplayMatrix(matrix);
**/

/**
var matrix=Matrix.Soal11();
Matrix.DisplayMatrix(matrix);
**/



/**
MyCollection.InitList();
MyCollection.InitStack();
MyCollection.InitDictionary();
MyCollection.InitHashset();
MyCollection.InitQueue();
**/




//declare
/**
var list = new List<string> { "Dios", "Nada", "Syarifa" };
var student =MyCollection.GetStudent(ref list);

foreach(var item in student)
{
    Console.WriteLine($"{item}");
}
var number = new List<int> { 2, 3, 4, 5, 6 };
var myNumber =MyCollection.GetStudent(ref number);
foreach(var item in number)
{
    Console.WriteLine($"{item}");
}
**/
ReadLine();