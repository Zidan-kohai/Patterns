using StateMachine.Base;
using StateMachine.Player;

public class PlayerStateController : StateController
{
    private BaseState currentState;
    private PlayerIdleState playerIdleState = new PlayerIdleState();
    private PlayerWalkState playerWalkState = new PlayerWalkState();

    private void Start()
    {
        currentState = playerIdleState;
        currentState.Enter(this);
    }

    private void Update()
    {
        currentState.Update(this);
    }

    public void SwitchState(BaseState newState)
    {
        currentState.Exit(this);

        currentState = newState;

        currentState.Enter(this);
    }

}
