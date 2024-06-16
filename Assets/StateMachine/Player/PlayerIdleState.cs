using StateMachine.Base;
using UnityEngine;



namespace StateMachine.Player
{
    public class PlayerIdleState : BaseState
    {
        public override void Enter(StateController stateController)
        {
            Debug.Log("Idle Enter");
        }

        public override void Update(StateController stateController)
        {
            Debug.Log("Idle Update");
        }

        public override void FixedUpdate(StateController stateController)
        {
            Debug.Log("Idle FixedUpdate");
        }

        public override void LateUpdate(StateController stateController)
        {
            Debug.Log("Idle LateUpdate");
        }

        public override void OnCollisionEnter(Collision col, StateController stateController)
        {
            Debug.Log("Idle OnCollisionEnter");
        }

        public override void OnCollisionExit(Collision col, StateController stateController)
        {
            Debug.Log("Idle OnCollisionExit");
        }

        public override void OnCollisionStay(Collision col, StateController stateController)
        {
            Debug.Log("Idle OnCollisionStay");
        }

        public override void OnTriggerEnter(Collider col, StateController stateController)
        {
            Debug.Log("Idle OnTriggerEnter");
        }

        public override void OnTriggerExit(Collider col, StateController stateController)
        {
            Debug.Log("Idle OnTriggerExit");
        }

        public override void OnTriggerStay(Collider col, StateController stateController)
        {
            Debug.Log("Idle OnTriggerStay");
        }

        public override void Exit(StateController stateController)
        {
            Debug.Log("Idle Exit");
        }

    }
}
