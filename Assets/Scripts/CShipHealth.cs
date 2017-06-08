using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShipHealth : _MonoBehaviour
{
    public int _hp;
    public float _orgHP;

    public virtual int HpDown(float damage)
    {
        _hp -= (int)damage;
        _hp = _hp < 0 ? 0 : _hp;
        return _hp;
    }

    public void DoDestroy()
    {
        Destroy(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        _orgHP = (float)_hp;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
