using System;
using System.Linq;

class exercicio11 {
    static void Main(){
        int[] array1 = { 6, 7, 8, 3};
        int[] array2 = { 8, 9, 3, 4};
        var intersect = array1.Intersect(array2);
        foreach(int res in intersec){
            Console.WriteLine(res);
        }
    }
}