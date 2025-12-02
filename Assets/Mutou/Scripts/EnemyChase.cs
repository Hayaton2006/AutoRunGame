using UnityEngine;
using UnityEngine.InputSystem.XR;

public class EnemyChase : MonoBehaviour
{
    [Header("プレイヤー検出距離")]
    [SerializeField] float detectionRange;
    private GameObject target;
    PlayerMoveer player;
    public float Enemyspeed;
    public float Chasespeed;
    [SerializeField] GameObject Player;

    void Start()
    {
        Enemyspeed = 0.005f;
        target = GameObject.Find("horse");
        player = Player.GetComponent<PlayerMoveer>();
    }

    void Update()
    {
        // EnemyとPlayerの距離を計算
        float dis = Vector3.Distance(this.transform.position, target.transform.position);

        // Playerが検出範囲に侵入している場合
            if (dis <= detectionRange)
            {

                Enemyspeed = 0.018f * Chasespeed;

                transform.LookAt(target.transform);
                transform.position += transform.forward * Enemyspeed;
            }
    }
}
