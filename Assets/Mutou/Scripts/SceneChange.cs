using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void SceneLoad()
    {
        SceneManager.LoadScene("inGame");
    }
    public void OptionScene()
    {
        SceneManager.LoadScene("Option");
    }
    public void TitleScene()
    {
        SceneManager.LoadScene("OutGame");
    }


}
