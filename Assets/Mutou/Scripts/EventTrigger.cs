using System;
using UnityEngine;
using UnityEngine.Events;

public class EventTrigger : MonoBehaviour
{
    [Serializable]
    public class EnemySpawnInfo
    {
        public Vector3 position;
        public Enemy prefab;
    }

    [SerializeField] EnemySpawnInfo[] spawnInfo;
    [SerializeField] UnityEvent onEventEnter;

    private void OnTriggerEnter(Collider other)
    {
        // 馬車だったら
        if (other.CompareTag("horse"))
        {
            onEventEnter.Invoke();
        }
    }

    public void Dummy()
    {
        Debug.Log("Dummy");
    }

    public void SpawnEnemies()
    {
        for (int i = 0; i < spawnInfo.Length; i++)
        {
            Instantiate(spawnInfo[i].prefab, spawnInfo[i].position, Quaternion.identity);
        }
    }
    public void Deactive()
    {
        gameObject.SetActive(false);
    }
}
