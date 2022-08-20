void ReadArrey(int[] arrey){
    int index = 0;
    while(index < arrey.Length){
        arrey[index] = new Random().Next(1, 100);
        index++;
    }
}

void WriteArrey(int[] arrey){
    int index = 0;
    while(index < arrey.Length){
        Console.WriteLine(arrey[index]);
        index++;
    }
}

int[] arr = new int[10];
ReadArrey(arr);
WriteArrey(arr);
