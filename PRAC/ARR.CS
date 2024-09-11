using System;

class ArrayEx{
    public static void Main(string[] args)
    {
        // int [] arr={1,2,3,4,5};
        // foreach(int item in arr){
        //     Console.WriteLine(item);
        // }

        int [,] arr ={{1,2,3},{1,3,4},{1,4,5}};

        for(int i=0;i<arr.Length;i++){
            for(int j=0;j<arr[i].Length;j++){
                Console.WriteLine(arr[i,j])
            }
        }
    }
}