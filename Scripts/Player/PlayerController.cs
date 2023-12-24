using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PLyerAnimator))]
public class PlayerController : MonoBehaviour
{
    MyInput inputs;
    Rigidbody2D rb;
    PLyerAnimator plyerAnimator;
    [SerializeField] protected DamageFild MainFilld;
    [SerializeField] protected int MainAttackDamage;
    [SerializeField] protected float MainReloadTime;
    protected bool AttakRedy;

    [SerializeField]protected float speed;
    private void Start()
    {
        inputs = InputSpeaker.instance.inputActions;   
        rb = GetComponent<Rigidbody2D>();
        plyerAnimator = GetComponent<PLyerAnimator>();
        inputs.Player.Move.performed += MoveComande;
        inputs.Player.Move.canceled += MoveComande;
        inputs.Player.Attack.performed += DoDamage;
        AttakRedy = true;
    }

    private void OnDisable()
    {
        inputs.Player.Move.performed -= MoveComande;
        inputs.Player.Move.canceled -= MoveComande;
        inputs.Player.Attack.performed -= DoDamage;
    }

    void MoveComande(InputAction.CallbackContext context)
    {
        rb.velocity = context.ReadValue<Vector2>() * speed;
        plyerAnimator.SetDirection(rb.velocity);
    }

    void DoDamage(InputAction.CallbackContext context)
    {

        if(AttakRedy)
        {
            plyerAnimator.PlayAttak();
            MainFilld.ApplyDamage(MainAttackDamage);
            AttakRedy=false;
            StartCoroutine(RenewMainAttak());
        }
    }

    IEnumerator RenewMainAttak() {
        yield return new WaitForSeconds(MainReloadTime);
        AttakRedy = true;
    }

}
