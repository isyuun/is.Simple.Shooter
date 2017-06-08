using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLaserCountUpItem : _MonoBehaviour, IItem
{
    public int _upCountValue;
    public void Use()
    {
        GameObject.Find("PlayerShip").GetComponent<CShot>().SetShotCountUp(_upCountValue);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
