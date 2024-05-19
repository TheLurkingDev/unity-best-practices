using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.BehaviorTreePattern.Sample
{
	public class CountUpBehaviorTreeDemo : BaseDemo
	{
		//[Header("Demo")]
		private CountUpBehaviorTree _countUpBehaviorTree;
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			_countUpBehaviorTree = new CountUpBehaviorTree();
			_countUpBehaviorTree.Initialize();

		}

		private void Update()
		{
			_countUpBehaviorTree.OnTick(Time.deltaTime);
		}
	}
}