using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] float PlayerWalkSpeed = 1f;
    void Start()
    {
        
    }
    void Update()
    {
       
        // 前進
        transform.Translate(Vector3.forward * PlayerWalkSpeed * Time.deltaTime);

        // アニメーションを歩行状態に切り替える
        animator.SetFloat("Speed", 1.0f);
    }
}
