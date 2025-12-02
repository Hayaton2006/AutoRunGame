using UnityEngine;
using UnityEngine.SceneManagement;

public class horse : MonoBehaviour
{
    [SerializeField] float horsespeed;
    [SerializeField] int horsehp = 10;
    void Update()
    {
        transform.Translate(0, 0, horsespeed);
        if(horsehp == 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("Enemy"))
        {
            horsehp--;
        }
    }
}
