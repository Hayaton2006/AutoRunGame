using UnityEngine;

public partial class Enemy : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float chasespeed;
    [SerializeField] float detectionRange;

    StateMachine stateMachine;
    

    void Start()
    {
        stateMachine = new StateMachine(new IdleState());
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
}
