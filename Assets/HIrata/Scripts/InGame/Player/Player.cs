using UnityEngine;

public partial class PlayerMoveer : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float moveSpeed = 5f;
    StateMachine stateMachine;

    void Awake()
    {
        stateMachine = new StateMachine(new IdleState());
    }

    void Update()
    {
        stateMachine.Update();
    }

    public void Select()
    {
        stateMachine.ChangeState(new MoveState(rb, moveSpeed));
    }

    public void Unselect()
    {
        stateMachine.ChangeState(new IdleState());
    }
}
