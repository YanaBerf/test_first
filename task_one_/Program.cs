Console.Clear();
Console.Write("Введите символы или слова через пробел: ");
string[] arr = Console.ReadLine().Split();

PrintArray(GetArray(arr));

string[] GetArray(string[] array){
    string[] result = new string[array.Length];
    int j = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i].Length <= 3){
            result[j] = array[i];
            j++;
        }
    } return result;
   //Console.WriteLine(String.Join(" ", result));
} 
void PrintArray(string[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
