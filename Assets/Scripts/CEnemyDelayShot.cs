using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyDelayShot : CShot
{
    public float _fireDelayTime;

    private int _shotPointNum = 0;

    public CDirectMovement _movement;

    protected override void Shot()
    {
        //base.Shot();
        _movement.Stop();

        Instantiate(_laserPrefab, _shotPoints[_shotPointNum].position, _shotPoints[_shotPointNum].rotation);

        _shotPointNum++;

        if (_shotPointNum >= _shotPoints.Length)
        {
            _movement.Resume();

            Invoke("Shot", _shotDelayTime);
            _shotPointNum = 0;
        }

        Invoke("Shot", _fireDelayTime);
    }

    // Use this for initialization
    void Start()
    {
        Invoke("Shot", _shotDelayTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
