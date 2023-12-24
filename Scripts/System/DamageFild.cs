
using System.Collections.Generic;
using UnityEngine;

public class DamageFild : MonoBehaviour
{
   public List<Entyti> targets;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.GetComponent<Entyti>())
        { 
            targets.Add(collision.gameObject.GetComponent<Entyti>()); 
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Entyti>())
        {
            targets.Remove(collision.gameObject.GetComponent<Entyti>());
        }
    }

    public void ApplyDamage(int Damage)
    {

        foreach(Entyti item in targets)
        {
            item.TakeDamage(Damage);
        }
        
    }
}
