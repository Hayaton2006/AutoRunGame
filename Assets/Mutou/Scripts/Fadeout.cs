using System.Collections;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fadeout : MonoBehaviour
{
    [SerializeField] Image image;

    private void Start()
    {
        StartCoroutine(FadeCoroutine());
    }

    IEnumerator FadeCoroutine()
    {
        // Imageコンポーネントのカラーのアルファ値が1.0になるまで加算する
        while (image.color.a > 0.0f)
        {
            var color = image.color;
            color.a -= Time.deltaTime;
            image.color = color;
            yield return null;
        }
    }
}
