/*1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в 
отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом,
 как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/



string[]RandomArray(int size){
    string[]array = new string[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToString(new Random().Next(0, 2000));

        } return array;
}
void ShowArray(string[]array){
   Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
void Numbers(string[]array1,string[]array2){
     int count =0;
     for (int i = 0; i < array1.Length; i++)
     {
        if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
     }
 }
     
     

Console.WriteLine("Input a size massive");          //запрвшиваем размер массива у пользователя
int size = Convert.ToInt32(Console.ReadLine());


/*
string[] array1 =RandomArray(size); 
string[] array2 = new string[array1.Length];
Numbers(array2);

