using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]int enemyHealth = 10;
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] float knockBackPower;   // ノックバックさせる力
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("Player"))
        {
            enemyHealth--;
            rigidbody.linearVelocity = Vector3.zero;

            // 自分の位置と接触してきたオブジェクトの位置とを計算して、距離と方向を出して正規化(速度ベクトルを算出)
            Vector3 distination = (transform.position - other.transform.position).normalized;

            rigidbody.AddForce(distination * knockBackPower, ForceMode.VelocityChange);
        }
        if (obj.CompareTag("horse"))
        {
            rigidbody.linearVelocity = Vector3.zero;

            // 自分の位置と接触してきたオブジェクトの位置とを計算して、距離と方向を出して正規化(速度ベクトルを算出)
            Vector3 distination = (transform.position - other.transform.position).normalized;

            rigidbody.AddForce(distination * knockBackPower, ForceMode.VelocityChange);
        }
    }
}
