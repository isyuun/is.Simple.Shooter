using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPlayerShipSubShip : _MonoBehaviour
{
    public List<GameObject> subShip = new List<GameObject>();
    public Transform[] subPos;

    public void SetSubShipCountUp(GameObject gameObject)
    {
        Debug.Log(this.GetMethodName() + gameObject + ":" + subShip.Count);
        if (subShip.Count < 2)
        {
            subShip.Add(gameObject);
        }
        foreach (GameObject item in subShip)
        {
            if (item != null)
            {
                item.transform.SetParent(subPos[subShip.IndexOf(item)]);
                item.transform.position = subPos[subShip.IndexOf(item)].position;
            }
        }
    }

    public void SetSubShipCountDown(GameObject gameObject)
    {
        Debug.Log(this.GetMethodName() + gameObject + ":" + subShip.Count);
        subShip.Remove(gameObject);
    }
}
