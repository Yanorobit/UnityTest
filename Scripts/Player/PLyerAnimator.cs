using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PLyerAnimator : MonoBehaviour
{
   public Animator animation;
    private void Start()
    {
        animation = GetComponent<Animator>();
    }

   public void SetDirection(int deirectionIndex)
    {
        if(deirectionIndex!=-1)
        animation.SetInteger("DirectionIndex", deirectionIndex);
    }

    public void SetDirection(Vector2 vector)
    {
      
      animation.SetBool("Runing", vector != Vector2.zero);
      int index = MathHelper.VectorToDirectionIndex(vector,8);
      SetDirection(index);
    }

    public void PlayAttak()
    {
        animation.SetTrigger("Attaka");
    }
}
