using UnityEngine;

public class AnimationMovementPS4 : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private static readonly int GoRight = Animator.StringToHash("GoRight");
    private static readonly int GoLeft  = Animator.StringToHash("GoLeft");

    public void SlideRight()
    {
        animator.ResetTrigger(GoLeft);
        animator.SetTrigger(GoRight);
    }

    public void SlideLeft()
    {
        animator.ResetTrigger(GoRight);
        animator.SetTrigger(GoLeft);
    }
}
