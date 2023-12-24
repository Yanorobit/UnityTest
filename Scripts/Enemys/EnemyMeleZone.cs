using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleZone : MonoBehaviour
{
    public List<Entyti> targets;
    [SerializeField] protected MeleBrain brain;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerHelth>())
        {
            targets.Add(collision.gameObject.GetComponent<PlayerHelth>());
            brain.myState = States.Attak;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerHelth>())
        {
            targets.Remove(collision.gameObject.GetComponent<PlayerHelth>());
           if(brain.myState== States.Attak)
            brain.myState = States.GoToTarget;
        }
    }

    public void ApplyDamage(int Damage)
    {
        foreach (Entyti item in targets)
        {
            item?.TakeDamage(Damage);
        }
    }
}
