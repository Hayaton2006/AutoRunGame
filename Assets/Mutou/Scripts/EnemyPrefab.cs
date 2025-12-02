using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;



public class EnemyPrefab : MonoBehaviour
{
    public GameObject prefab;
    [SerializeField] float positionx;
    [SerializeField] float positiony;
    [SerializeField] float positionz;
    //[SerializeField] private EmemySpawnInfo[] enemyInfo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(InstantiateFastEnemy());
    }

    // Update is called once per frame
    void Update()
    {    
    }

    IEnumerator InstantiateFastEnemy()
    { 
        yield return new WaitForSeconds(1);

        //for (int i = 0; i < enemyInfo.Length; i++)
        //{
        //    Instantiate(enemyInfo[i].prefab, enemyInfo[i].position, Quaternion.identity);
        //}
    }
}
