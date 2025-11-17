using UnityEngine;

public class AutoScrollCamera : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 2.0f;
    void Update()
    {
        transform.position += Vector3.forward * scrollSpeed * Time.deltaTime;
    }
}
