
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MeeleAnimationControler : MonoBehaviour
{
    protected Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

   public void SetDirection(int directionIndex)
   {
        animator.SetInteger("DirectionIndex", directionIndex);
   }

    public void StartRun()
    {
        animator.SetBool("Run",true);
    }

    public void StopRun()
    {
        animator.SetBool("Run", false);
    }

    public void TrigAttak()
    {
        animator.SetBool("Attak",true);
    }

    public void StopAttak()
    {
        animator.SetBool("Attak", false);
    }
}


