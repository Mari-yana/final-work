
Console.Write ("Enter array elements separated by spaces: ");
string inputString = Console.ReadLine();
var array1 = inputString.Split(' ').ToArray();

var list = new List<string>();
foreach (var element in array1) {
     if (element.Length <= 3) list.Add(element); 
} 
var array2 = new string[list.Count]; 
list.CopyTo(array2);

var result = string.Join(" ", array2);
Console.WriteLine(result);
