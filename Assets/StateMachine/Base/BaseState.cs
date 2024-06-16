using UnityEngine;



namespace StateMachine.Base
{
    public abstract class BaseState
    {
        public abstract void Enter(StateController stateController);
        public abstract void Update(StateController stateController);
        public abstract void FixedUpdate(StateController stateController);
        public abstract void LateUpdate(StateController stateController);
        public abstract void OnTriggerEnter(Collider col, StateController stateController);
        public abstract void OnTriggerStay(Collider col, StateController stateController);
        public abstract void OnTriggerExit(Collider col, StateController stateController);
        public abstract void OnCollisionEnter(Collision col, StateController stateController);
        public abstract void OnCollisionStay(Collision col, StateController stateController);
        public abstract void OnCollisionExit(Collision col, StateController stateController);
        public abstract void Exit(StateController stateController);

    }
}
