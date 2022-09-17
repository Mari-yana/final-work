Console.Write ("Enter array elements separated by spaces: ");
string inputString = Console.ReadLine();
var array1 = inputString.Split(' ').ToArray();

int count = 0; 
foreach (var element in array1) { 
    if (element.Length <= 3) count++; 
} 

var array2 = new string[count]; 

int j = 0; 
for (int i = 0; i < array1.Length; i++) { 
    if (array1[i].Length <= 3) {
       array2[j++] = array1[i]; 
    }
}

var result = string.Join(" ", array2);
Console.WriteLine(result);