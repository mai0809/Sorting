﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class CloneApp2
{

    static void sort3(int[] arr, int[] temp)
    {

        // Insert arr[1]
        if (arr[1] < arr[0])
        {
            temp[0] = arr[0];
            arr[0] = arr[1];
            arr[1] = temp[0];
        }

        // Insert arr[2]
        if (arr[2] < arr[1])
        {
            temp[0] = arr[1];
            arr[1] = arr[2];
            arr[2] = temp[0];

            if (arr[1] < arr[0])
            {
                temp[0] = arr[0];
                arr[0] = arr[1];
                arr[1] = temp[0];
            }
        }
    }

    
    public static void Main(String[] args)
    {
        int[] a = new int[] { 2, 10, 1 };
        int[] temp1 = new int[10];
        sort3(a, temp1);

        for (int i = 0; i < 3; i++)
            Console.Write(a[i] + " ");
    }
}
