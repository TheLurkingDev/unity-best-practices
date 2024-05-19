using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.BehaviorTreePattern.Sample
{
	public class CountUpWithBlackboardBehaviorTreeDemo : BaseDemo
	{
		//[Header("Demo")]

		private CountUpWithBlackboardBehaviorTree _countUpWithBlackboardBehaviorTree;
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			_countUpWithBlackboardBehaviorTree = new CountUpWithBlackboardBehaviorTree();
			_countUpWithBlackboardBehaviorTree.Initialize();

		}

		private void Update()
		{
			_countUpWithBlackboardBehaviorTree.OnTick(Time.deltaTime);
		}
	}
}