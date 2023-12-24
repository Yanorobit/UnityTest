using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class MeleBrain : BaseBrain
{
    protected Transform playerTransform;
    protected NavMeshAgent agent;
    protected MeeleAnimationControler animator;
    protected Vector2 LineToPlayer;
    protected int directionIndex;

    [SerializeField] protected EnemyMeleZone zone;
    [SerializeField] protected int damage;
    [SerializeField] protected float reloadTime;
    protected bool AttakRedy;
    void Start()
    {
        AttakRedy = true;
        playerTransform = PlayerHelth.instanse.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        animator = GetComponent<MeeleAnimationControler>();
        agent.destination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        LineToPlayer =playerTransform.position - transform.position;
        directionIndex=MathHelper.VectorToDirectionIndex(LineToPlayer, 8);
        switch (myState)
        { 
            case States.Pasive:
                animator?.StopRun();    
            break;
            case States.GoToTarget:
                agent.destination = playerTransform.position;
                animator.SetDirection(directionIndex);
                animator.StartRun();
                animator.StopAttak();
                break;
            case States.Attak:
                tryAttack();
            break;
        }  
    }

    protected void tryAttack()
    {
        if(AttakRedy)
        {
            animator.SetDirection(directionIndex);
            animator.StopRun();
            animator.TrigAttak();
            zone.ApplyDamage(damage);
            AttakRedy=false;
            StartCoroutine(RenewMainAttak());
        }
    }

    IEnumerator RenewMainAttak()
    {
        yield return new WaitForSeconds(reloadTime);
        AttakRedy = true;
    }
}
