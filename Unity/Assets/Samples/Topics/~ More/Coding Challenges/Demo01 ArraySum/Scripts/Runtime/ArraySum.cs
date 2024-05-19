using System.Collections.Generic;
using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.CodingChallenges.ArraySum
{
	/// <summary>
	/// 
	/// </summary>
	public class ArraySum : BaseDemo
	{
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
			var targetSum = 7;
			var result = FindIndexes(numbers, targetSum);
			Debug.Log("Which indexes added together equals " + targetSum);
			Debug.Log("ValueA: " + result[0]);
			Debug.Log("ValueB: " + result[1]);
		}

		private int[] FindIndexes(List<int> list, int targetSum)
		{
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = i + 1; j < list.Count; j++)
				{
					if (list[i] + list[j] == targetSum)
					{
						return new int[] { list[i],  list[j]  };
					}
				}
			}
			return null;
		}
	}
}