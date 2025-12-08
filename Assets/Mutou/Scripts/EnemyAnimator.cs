using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    [SerializeField] Animator aniMator;
    int state = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if (state == 0)
        {
            aniMator.SetFloat("Idle", 1);
        }
    }
    public void RunState()
    {
        state++;
        if (state >= 1)
        {
            aniMator.SetFloat("Idle", 2);
        }
    }
}
