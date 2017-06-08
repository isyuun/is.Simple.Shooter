using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShot : _MonoBehaviour
{
    public float MAX_COUNTFIRE = 10.0f;

    public GameObject _laserPrefab;
    public Transform[] _shotPoints;
    protected int shotCount = 1;

    public float _shotDelayTime;

    public void SetShotCountUp(int upCountValue)
    {
        shotCount += upCountValue;
        if (shotCount >= _shotPoints.Length)
        {
            shotCount = _shotPoints.Length;
        }
        else if (shotCount < 1)
        {
            shotCount = 1;
        }

        CancelInvoke();
        Invoke("AutoShotCountDown", MAX_COUNTFIRE);
    }

    private void AutoShotCountDown()
    {
        SetShotCountUp(-2);
    }

    protected virtual void Shot()
    {
        for (int i = 0; i < shotCount; i++)
        {
            Instantiate(_laserPrefab, _shotPoints[i].position, _shotPoints[i].rotation);
        }
    }

    // Use this for initialization
    protected virtual void Start()
    {
        shotCount = _shotPoints.Length;
        CancelInvoke();
        Invoke("AutoShotCountDown", MAX_COUNTFIRE);
    }

    // Update is called once per frame
    protected virtual void Update()
    {
    }
}
