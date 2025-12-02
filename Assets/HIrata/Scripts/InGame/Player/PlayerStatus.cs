using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int hp = 20;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            hp -= 2;
            Debug.Log($"{hp}");
            if(hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
