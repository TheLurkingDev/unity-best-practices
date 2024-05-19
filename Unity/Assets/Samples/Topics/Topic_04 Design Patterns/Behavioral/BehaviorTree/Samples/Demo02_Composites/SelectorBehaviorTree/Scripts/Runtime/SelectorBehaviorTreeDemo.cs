using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.BehaviorTreePattern.Sample
{
	public class SelectorBehaviorTreeDemo : BaseDemo
	{
		//[Header("Demo")]

		private SelectorBehaviorTree _selectorBehaviorTree;
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			_selectorBehaviorTree = new SelectorBehaviorTree();
			_selectorBehaviorTree.Initialize();

		}

		private void Update()
		{
			_selectorBehaviorTree.OnTick(Time.deltaTime);
		}
	}
}