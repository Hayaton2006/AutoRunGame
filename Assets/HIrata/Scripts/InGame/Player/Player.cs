using UnityEngine;

public partial class Player : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float forwardSpeed = 5f;
    StateMachine stateMachine;

    void Awake()
    {
        stateMachine = new StateMachine(new ForwardState(rb, forwardSpeed));
    }

    void Update()
    {
        stateMachine.Update();
    }

    public void Select()
    {
        stateMachine.ChangeState(new SelectState(rb, moveSpeed));
    }

    public void Unselect()
    {
        stateMachine.ChangeState(new ForwardState(rb, forwardSpeed));
    }
}
