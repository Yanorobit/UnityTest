
using UnityEngine;

public class BaseBrain : MonoBehaviour
{
    public States myState;
    public virtual void SetState(States newState) { 
    myState = newState;
    }
}
