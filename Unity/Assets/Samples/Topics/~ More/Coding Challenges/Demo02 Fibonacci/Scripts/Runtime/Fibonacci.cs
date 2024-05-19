using System.Collections.Generic;
using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.CodingChallenges.Fibonacci
{
	/// <summary>
	/// https://www.youtube.com/watch?v=8o8w_vBj9ac
	/// </summary>
	public class Fibonacci : BaseDemo
	{
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			var n = 11;
			var result1 = CalculateFibonacciInt(n);
			Debug.Log($"The Fibonacci at index {n} is {result1}. ");

			int from = 0;
			int to = n;
			List<int> result2 = CalculateFibonacciList(from, to);
			
			//change to in-line log
			Debug.Log($"The Fibonacci from index {from} to {to} is {string.Join(", ", result2.ToArray())}. ");
		}

		private List<int> CalculateFibonacciList(int from, int to)
		{
			List<int> list = new List<int>();
			for (int i = from; i < to; i++)
			{
				list.Add(CalculateFibonacciInt(i));
			}
			return list;
		}

		private int CalculateFibonacciInt(int i)
		{
			if (i == 0)
			{
				return 0;
			}
			if (i == 1)
			{
				return 1;
			}
			return CalculateFibonacciInt(i - 1) + CalculateFibonacciInt(i - 2);
		}
	}
}