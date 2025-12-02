using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class CarriageHP : MonoBehaviour
{
    [SerializeField]int Carriagehp = 40;
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Carriagehp -= 2;

            if(Carriagehp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
