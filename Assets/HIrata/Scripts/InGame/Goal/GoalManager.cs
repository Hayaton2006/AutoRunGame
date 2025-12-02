
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoalManager : MonoBehaviour
{
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("horse"))
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
