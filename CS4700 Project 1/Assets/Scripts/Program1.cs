/*************************************************************** 
*file: Program1.cs 
*author: K. Korfali 
*class: CS 4700 – Game Development 
*
*assignment: Program 1 
*date last modified: 2/03/2023 
* 
*purpose: This program print to the console the values in a hard coded 2D
*array in normal order, reverse order, as well as print out the 
*minimum and maximum values in the array.  
* 
****************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program1 : MonoBehaviour
{
    //Declare a 2-D array
    private double[,] myArray;

    //Declare variables to store size of myArray's rows and cols
    private int rows;
    private int cols;

    //Program1 Constructor
    Program1() 
    {
        //Initialize 2-D array
        myArray = new double[5, 5]{
        { 100000, 2.2, 3, 4, 5 },
        { 6, 7, 8, 8.8, 10 },
        { 11, 12, 13, 14, 15 },
        { 16.8, 17, 18, 19.9, 20 },
        { 21, 22, 22.1, 24, 25 } };

        //Gets the size of the array's rows and cols and stores them in local vars
        rows = myArray.GetLength(0);
        cols = myArray.GetLength(1);
    }


    //function: PrintArrayInNormalOrder 
    //purpose: This function iterates over an n by m array (rows by cols) in
    //normal order and stores the values in a string seperated by ", ".
    //This string is then printed to the console
    void PrintArrayInNormalOrder(double[,] myArr, int rows, int cols)
    {
        //Variable used to store normal order array values
        string normOrder = "";

        //Iterates over 2-D Array in Normal Order and Stores Values as they appear
        //in a string var
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                //Exclude last "," for last number
                if (i == rows - 1 && j == cols - 1)
                {
                    normOrder += myArray[i, j];
                }
                else
                {
                    normOrder += myArray[i, j] + ", ";
                }

            }
        }

        //Prints array in Normal Order
        print("Normal Order: \n" + normOrder);
    }

    //function: PrintArrayInReverseOrder 
    //purpose: This function iterates over an n by m array (rows by cols) in
    //reverse order and stores the values in a string seperated by ", ".
    //This string is then printed to the console
    void PrintArrayInReverseOrder(double[,] myArr, int rows, int cols)
    {
        //Variable used to store reverse order array values
        string revOrder = "";

        //Iterates over 2-D Array in Normal Order and Stores Values as they appear
        //in a string var
        for (int i = rows - 1; i >= 0; i--)
        {
            for (int j = cols - 1; j >= 0; j--)
            {
                //Exclude last "," for last number
                if (i == 0 && j == 0)
                {
                    revOrder += myArray[i, j];
                }
                else
                {
                    revOrder += myArray[i, j] + ", ";
                }
            }
        }
        
        //Prints array in Reverse Order
        print("Reverse Order: \n" + revOrder);
    }

    //function: PrintMinAndMax 
    //purpose: This function iterates over an n by m array (rows by cols) in
    //normal order and stores and prints out the min and max values of the array
    //to the console.
    void PrintMinAndMax(double[,] myArr, int rows, int cols)
    {
        //Variables to store min and max values of array
        double min = myArray[0, 0];
        double max = myArray[0, 0];

        //Iterate over 2-D array in normal order
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Find minimum and maximum values
                if (myArray[i, j] < min)
                {
                    min = myArray[i, j];
                }
                if (myArray[i, j] > max)
                {
                    max = myArray[i, j];
                }
            }
        }

        //Prints min and max values
        print("Minimum Value: " + min);
        print("Maximum Value: " + max);
    }


    // Start is called before the first frame update
    void Start()
    {
        //Prints the 2-D array in normal and order
        PrintArrayInNormalOrder(myArray, rows, cols);
        PrintArrayInReverseOrder(myArray, rows, cols);

        //Prints the min and max values in the 2-D array
        PrintMinAndMax(myArray, rows, cols);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
