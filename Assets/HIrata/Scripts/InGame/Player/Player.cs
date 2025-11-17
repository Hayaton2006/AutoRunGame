using UnityEngine;

public partial class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float PlayerScrollSpeed = 1f;

    StateMachine stateMachine;

    void Start()
    {
        stateMachine = new StateMachine(new IdleState());
    }

    void Update()
    {
        transform.Translate(Vector3.forward * PlayerScrollSpeed * Time.deltaTime);

      
        stateMachine.Update();
    }

    public void Select()
    {
        stateMachine.ChangeState(new MoveState(transform, moveSpeed));
    }

    public void Unselect()
    {
        stateMachine.ChangeState(new IdleState());
    }
}
