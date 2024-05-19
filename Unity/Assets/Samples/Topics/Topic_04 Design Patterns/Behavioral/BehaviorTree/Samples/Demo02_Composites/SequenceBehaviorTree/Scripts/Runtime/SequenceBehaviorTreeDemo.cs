using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.BehaviorTreePattern.Sample
{
	public class SequenceBehaviorTreeDemo : BaseDemo
	{
		//[Header("Demo")]

		private SequenceBehaviorTree _sequenceBehaviorTree;
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			_sequenceBehaviorTree = new SequenceBehaviorTree();
			_sequenceBehaviorTree.Initialize();

		}

		private void Update()
		{
			_sequenceBehaviorTree.OnTick(Time.deltaTime);
		}
	}
}