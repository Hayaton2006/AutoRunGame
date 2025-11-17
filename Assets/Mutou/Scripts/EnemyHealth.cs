using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]int enemyhealth = 10;
    Rigidbody rb;
    [SerializeField] float knockBackPower;   // ノックバックさせる力
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyhealth == 0)
        {
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("Player"))
        {
            enemyhealth--;
            rb.linearVelocity = Vector3.zero;

            // 自分の位置と接触してきたオブジェクトの位置とを計算して、距離と方向を出して正規化(速度ベクトルを算出)
            Vector3 distination = (transform.position - other.transform.position).normalized;

            rb.AddForce(distination * knockBackPower, ForceMode.VelocityChange);
        }
        if (obj.CompareTag("Respawn"))
        {
            rb.linearVelocity = Vector3.zero;

            // 自分の位置と接触してきたオブジェクトの位置とを計算して、距離と方向を出して正規化(速度ベクトルを算出)
            Vector3 distination = (transform.position - other.transform.position).normalized;

            rb.AddForce(distination * knockBackPower, ForceMode.VelocityChange);
        }
    }
}
