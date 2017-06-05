using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinputShot : MonoBehaviour
{
    public GameObject _laserPrefab;
    public Transform[] _shotPoints;
    public int shotCount = 1;

    public void Shot()
    {
        for (int i = 0; i < shotCount; i++)
        {
            Instantiate(_laserPrefab, _shotPoints[i].position, _shotPoints[i].rotation);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Shot();
        }
    }
}
