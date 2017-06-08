using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CStarCountUpItem : _MonoBehaviour, IItem
{
    public int _upScoreValue;
    private Text _starCountText;
    CAutoInputShot autoInputShot;

    // Use this for initialization
    void Start()
    {
        _starCountText = GameObject.Find("StarCountText").GetComponent<Text>();
        autoInputShot = GameObject.Find("PlayerShip").GetComponent<CAutoInputShot>();
    }

    public void Use()
    {
        int count = int.Parse(_starCountText.text);
        count += _upScoreValue;
        _starCountText.text = count.ToString();
        //autoInputShot.SetMaxAutoFire(count) ;
    }
}
