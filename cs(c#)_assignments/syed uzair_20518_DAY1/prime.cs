﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsHelloworld
{
	class prime
	{
		static void Main(string[] args)
		{
			int i, j, p, y=0;
			int[] arr = new int[20];
			int[] newarr = new int[20];
			Console.WriteLine("enter the number of elements");
			int n= int.Parse(Console.ReadLine());
			Console.WriteLine("Enter array elements:(after every element give enter and proced)");
			for (i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}

			for (i = 0; i < n; i++)
			{
				j = 2;
				p = 1;
				while (j < arr[i])
				{
					if (arr[i] % j == 0)
					{
						p = 0;
						break;
					}
					j++;
				}

				if (p == 1)
				{
					newarr[y] = arr[i];
					//Console.WriteLine(newarr[y]);
					y++;
				}
			}
			int number = newarr.Max();
			Console.WriteLine(number +" is the biggest prime number");
		}
	}
}
