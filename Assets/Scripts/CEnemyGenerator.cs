using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyGenerator : _MonoBehaviour
{
    public GameObject[] _enemyPrefab;
    GameObject enemyPrefab;

    public Transform[] _genPos;

    public float _delayMinTime;
    public float _delayMaxTime;

    // Use this for initialization
    void Start()
    {
        float delayTime = GetDelayTime();

        Invoke("CreateEnemy", delayTime);
    }

    private float GetDelayTime()
    {
        float delayTime = UnityEngine.Random.Range(_delayMinTime, _delayMaxTime);

        return delayTime;
    }

    private void CreateEnemy()
    {
        int posNum = UnityEngine.Random.Range(0, _genPos.Length);

        float delayTime = GetDelayTime();

        int rate = UnityEngine.Random.Range(0, 10);
        //if (rate > 7)
        //{
        //    enemyPrefab = _enemyPrefab[2];
        //}
        //else if (rate > 5)
        //{
        //    enemyPrefab = _enemyPrefab[1];
        //}
        //else
        //{
        //    enemyPrefab = _enemyPrefab[0];
        //}

        enemyPrefab = _enemyPrefab[rate % _enemyPrefab.Length];

        Instantiate(enemyPrefab, _genPos[posNum].position, Quaternion.identity);

        Invoke("CreateEnemy", delayTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
