using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.BehaviorTreePattern.Sample
{
    public class CountUpWithBlackboardBehaviorTree : BehaviorTree
    {
        /// <summary>
        /// Demo: See <see cref="CountUpNode"/> for expected behavior
        /// </summary>
        protected override Node CreateRootNode()
        {
            int maxCount = Blackboard.GetValue<int>("MaxCount");

            Debug.Log("Use value" + maxCount);
            
            Node root = new CountUpNode(maxCount);
            return root;
        }
    }
}

