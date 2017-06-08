using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSheildCountUpItem : _MonoBehaviour, IItem
{
    public int _upCountValue;

    public void Use()
    {
        GameObject.Find("PlayerShield").GetComponent<CPlayerShipShield>().SetShieldCountUp(_upCountValue);
    }
}
