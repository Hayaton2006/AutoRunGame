using UnityEngine;

public class EnemyknockBack : MonoBehaviour
{
    PlayCharacter character;
    private float enemyHeart = 10;
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] float knockBackPower;   // ノックバックさせる力
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHeart <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("Player"))
        {
            //enemyHealth -= character.playerPower;
            enemyHeart--;
            rigidBody.linearVelocity = Vector3.zero;

            // 自分の位置と接触してきたオブジェクトの位置とを計算して、距離と方向を出して正規化(速度ベクトルを算出)
            Vector3 distination = (transform.position - other.transform.position).normalized;

            rigidBody.AddForce(distination * knockBackPower, ForceMode.VelocityChange);
        }
        if (obj.CompareTag("horse"))
        {
            rigidBody.linearVelocity = Vector3.zero;

            // 自分の位置と接触してきたオブジェクトの位置とを計算して、距離と方向を出して正規化(速度ベクトルを算出)
            Vector3 distination = (transform.position - other.transform.position).normalized;

            rigidBody.AddForce(distination * knockBackPower, ForceMode.VelocityChange);
        }
    }
}
