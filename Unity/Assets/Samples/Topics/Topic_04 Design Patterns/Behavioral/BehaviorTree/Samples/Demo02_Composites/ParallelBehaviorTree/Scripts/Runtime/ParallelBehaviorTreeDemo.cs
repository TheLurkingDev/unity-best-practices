using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.BehaviorTreePattern.Sample
{
	public class ParallelBehaviorTreeDemo : BaseDemo
	{
		//[Header("Demo")]

		private ParallelBehaviorTree _parallelBehaviorTree;
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			_parallelBehaviorTree = new ParallelBehaviorTree();
			_parallelBehaviorTree.Initialize();

		}

		private void Update()
		{
			_parallelBehaviorTree.OnTick(Time.deltaTime);
		}
	}
}