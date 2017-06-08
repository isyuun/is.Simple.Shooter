using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHpUpItem : _MonoBehaviour, IItem
{

    public int _hpUpValue;

    public void Use()
    {
        GameObject.FindWithTag("Player").GetComponent<CPlayerShipHealth>().HpUp(_hpUpValue);
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
