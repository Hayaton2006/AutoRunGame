using UnityEngine;

public class CariageMove : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 1f;
    void Start()
    {
        
    }

  
    void Update()
    {
        transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
    }
}
