
using UnityEngine;

public class Entyti : MonoBehaviour
{
    public int MaxHP;

    protected int HP;

    private void Start()
    {
        Prepear();
    }
    protected virtual void Prepear()
    {
        HP = MaxHP;
    }

    public void TakeDamage(int damage) {
        if (damage < 0)
            return;
        HP -= damage;
        if (HP < 0)
            Death();

    }

    protected virtual void Death() { 
        gameObject.SetActive(false);
    }
}
