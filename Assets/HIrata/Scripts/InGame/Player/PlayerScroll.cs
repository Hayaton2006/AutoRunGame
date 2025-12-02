using UnityEngine;

public class PlayerScroll : MonoBehaviour
{
    [SerializeField] float PlayerScrollSpeed = 1f;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(Vector3.forward * PlayerScrollSpeed * Time.deltaTime);
    }
}
