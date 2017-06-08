using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyShot : CShot
{
    // Use this for initialization
    protected override void Start()
    {
        shotCount = _shotPoints.Length;
        InvokeRepeating("Shot", _shotDelayTime, _shotDelayTime);
    }

    // Update is called once per frame
    protected override void Update()
    {

    }
}
