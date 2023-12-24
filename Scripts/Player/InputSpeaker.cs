using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSpeaker : MonoBehaviour
{
   static public InputSpeaker instance;
   public MyInput inputActions ;

    private void Awake()
    {
        inputActions=new MyInput();
        instance = this;
        inputActions.Enable();
    }


}
