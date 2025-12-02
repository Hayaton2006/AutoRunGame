using UnityEngine;
using UnityEngine.InputSystem;

public partial class Enemy : MonoBehaviour
{
    [SerializeField] float chasespeed;
    [SerializeField] float detectionRange;
    [SerializeField] bool ishorse;
    StateMachine stateMachine;
    GameObject target;


    void Start()
    {
        stateMachine = new StateMachine(new IdleState());
        target = GameObject.FindWithTag("horse");
        //if (ishorse)
        //{
        //    
        //}
        //if (!ishorse)
        //{
        //    target = GameObject.FindWithTag("Player");
        //}
    }
    void Update()
    {
        stateMachine.Update();

        float dis = Vector3.Distance(this.transform.position, target.transform.position);

        // Playerが検出範囲に侵入している場合
        if (dis <= detectionRange && stateMachine.GetStateType() != typeof(ChaseState))
        {
           stateMachine.ChangeState(new ChaseState(transform, target, chasespeed));
        }
    }
    public void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("Player"))
        {
            target = obj;
            stateMachine.ChangeState(new ChaseState(transform, target, chasespeed));
        }
    }
}
