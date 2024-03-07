# Exp02-CSharpPattern

## Aim:
To write the C# program to print Pascal's triangle.

## Algorithm:

<b>Step1:</b> Initialize the neccessary attributes.


<b>Step2:</b> Get the no. of rows from the user.


<b>Step3:</b> Using for loop print the rows, columns and spaces at required places.


<b>Step4:</b> Apply if condition to print 1.


<b>Step5:</b> If the condition fails, print the number using the formula. value=value*(i-j+1)/j.



## Program:
```c#
using System;
namespace new444
{
    class Program
    {
        public static void Main()
        {
            int rows, c = 1, s, i, j;
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pascal's triangle");
            for (i = 0; i < rows; i++)
            {
                for (s = 1; s <= rows - i; s++)
                    Console.Write(" ");
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        c = 1;
                    else
                        c = c * (i - j + 1) / j;
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

```

## Output:

![image](https://github.com/ShyamKumar-AI-DS/Exp02-CSharpPattern/assets/93427182/34f2c832-1850-4715-b6a7-67f97eb69a60)


## Result:
Hence, a C# program for a pascal's triangle is executed successfully.

