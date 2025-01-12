using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class FallAndRiseBehaviour : StateMachineBehaviour
{
    PlayerCharacterController playerCharacterController;

    public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
    {
        base.OnStateMachineEnter(animator, stateMachinePathHash, controller);
        if (!playerCharacterController)
            playerCharacterController = animator.GetComponent<PlayerCharacterController>();
        playerCharacterController.ToggleMoving(shouldMove: false);
    }

    public override void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller)
    {
        base.OnStateMachineEnter(animator, stateMachinePathHash, controller);
        playerCharacterController.ToggleMoving(shouldMove: false);
    }
}
