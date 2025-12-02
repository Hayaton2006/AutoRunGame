using UnityEngine;
using TMPro;

public class DistanceToGoal : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform goal;
    [SerializeField] private TextMeshProUGUI distanceText;

    void Update()
    {
        // Z軸方向だけの距離を計算（縦スクロール）
        float dist = goal.position.z - player.position.z;

        // マイナスになったら0に丸める（ゴール後の表示崩れ対策）
        dist = Mathf.Max(dist, 0f);

        // 1m単位で表示
        distanceText.text = $"{dist:F0} m";
    }
}
