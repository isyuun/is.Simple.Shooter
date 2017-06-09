using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSubShipCountUpItem : _MonoBehaviour
{
    public int _upCountValue;

    public void Dock()
    {
        GetComponent<CDirectMovement>().enabled = false;
        GetComponent<CShipHealth>().enabled = true;
        GetComponent<CPlayerShipDamage>().enabled = true;
        GetComponent<CAutoInputShot>().enabled = true;

        GetComponent<CAutoInputShot>().AutoFireTime = GameObject.Find("PlayerShip").GetComponent<CAutoInputShot>().AutoFireTime;

        if (GameObject.Find("PlayerShip").GetComponent<CPlayerShipSubShip>().subShip.Count < 2)
        {
            GameObject.Find("PlayerShip").GetComponent<CPlayerShipSubShip>().SetSubShipCountUp(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        GetComponent<CDirectMovement>().enabled = true;
        GetComponent<CShipHealth>().enabled = false;
        GetComponent<CPlayerShipDamage>().enabled = false;
        GetComponent<CAutoInputShot>().enabled = false;
    }

    private void Update()
    {
        GetComponent<CAutoInputShot>().AutoFireTime = GameObject.Find("PlayerShip").GetComponent<CAutoInputShot>().AutoFireTime;
    }

    private void OnDestroy()
    {
        if (GameObject.Find("PlayerShip") != null)
        {
            GameObject.Find("PlayerShip").GetComponent<CPlayerShipSubShip>().SetSubShipCountDown(gameObject);
        }
        int score = int.Parse(CGameManager.ScoreText.text);
        score += (int)(GetComponent<CShipDamage>()._shipHealth._orgHP /*/ 10.0f*/);
        CGameManager.ScoreText.text = score.ToString();
    }
}
