using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPlayerShipMiniShip : _MonoBehaviour
{
    public List<GameObject> miniShip = new List<GameObject>();
    public Transform[] miniPos;

    public void SetMiniShipCountUp(GameObject gameObject)
    {
        Debug.Log(this.GetMethodName() + gameObject + ":" + miniShip.Count);
        if (miniShip.Count < 2)
        {
            miniShip.Add(gameObject);
        }
        foreach (GameObject item in miniShip)
        {
            if (item != null)
            {
                item.transform.SetParent(miniPos[miniShip.IndexOf(item)]);
                item.transform.position = miniPos[miniShip.IndexOf(item)].position;
            }
        }
    }

    public void SetMiniShipCountDown(GameObject gameObject)
    {
        Debug.Log(this.GetMethodName() + gameObject + ":" + miniShip.Count);
        miniShip.Remove(gameObject);
    }
}
