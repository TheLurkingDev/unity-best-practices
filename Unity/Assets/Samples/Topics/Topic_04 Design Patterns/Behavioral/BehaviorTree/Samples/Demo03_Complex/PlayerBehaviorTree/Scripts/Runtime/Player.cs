using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.BehaviorTreePattern.Sample
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        public float MoveSpeed = 2f;
        
        [SerializeField]
        public float WaitDelayInSeconds = 0.5f;

        [SerializeField]
        public float MinimumFoodDistance = 6f;

        [SerializeField]
        private Transform[] _waypoints;

        private PlayerBehaviorTree _playerBehaviorTree;

        protected void Start()
        {
            
            //Create tree
            _playerBehaviorTree = new PlayerBehaviorTree();
            
            //Populate blackboard data
            _playerBehaviorTree.Blackboard.SetValue("MoveSpeed", MoveSpeed);
            _playerBehaviorTree.Blackboard.SetValue("WaitDelayInSeconds", WaitDelayInSeconds);
            _playerBehaviorTree.Blackboard.SetValue("MinimumFoodDistance", MinimumFoodDistance);
            
            //Populate local tree data
            _playerBehaviorTree.Transform = transform;
            _playerBehaviorTree.Waypoints = _waypoints;
            
            //Init
            _playerBehaviorTree.Initialize();
        }

        protected void Update()
        {
            _playerBehaviorTree.OnTick(Time.deltaTime);
        }
    }
}

