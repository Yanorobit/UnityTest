
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public States newEntytiState;
    public BaseBrain controledEnemy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerHelth>())
        {
            controledEnemy.SetState(newEntytiState);
        }
    }
}
