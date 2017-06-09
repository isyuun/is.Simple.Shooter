using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMiniShipCountUpItem : _MonoBehaviour
{
    public int _upCountValue;

    public void Dock()
    {
        GetComponent<CDirectMovement>().enabled = false;
        GetComponent<CShipHealth>().enabled = true;
        GetComponent<CPlayerShipDamage>().enabled = true;
        if (GetComponent<CAutoInputShot>() != null)
        {
            GetComponent<CAutoInputShot>().enabled = true;
            GetComponent<CAutoInputShot>().AutoFireTime = GameObject.Find("PlayerShip").GetComponent<CAutoInputShot>().AutoFireTime;
        }
        if (GetComponent<CAutoTargetShot>() != null)
        {
            GetComponent<CAutoTargetShot>().enabled = true;
        }


        if (GameObject.Find("PlayerShip").GetComponent<CPlayerShipMiniShip>().miniShip.Count < 2)
        {
            GameObject.Find("PlayerShip").GetComponent<CPlayerShipMiniShip>().SetMiniShipCountUp(gameObject);
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
        if (GetComponent<CAutoInputShot>() != null)
        {
            GetComponent<CAutoInputShot>().enabled = false;
        }
        if (GetComponent<CAutoTargetShot>() != null)
        {
            GetComponent<CAutoTargetShot>().enabled = false;
        }
    }

    private void Update()
    {
        if (GetComponent<CAutoInputShot>() != null)
        {
            GetComponent<CAutoInputShot>().AutoFireTime = GameObject.Find("PlayerShip").GetComponent<CAutoInputShot>().AutoFireTime;
        }
    }

    private void OnDestroy()
    {
        if (GameObject.Find("PlayerShip") != null)
        {
            GameObject.Find("PlayerShip").GetComponent<CPlayerShipMiniShip>().SetMiniShipCountDown(gameObject);
        }
        int score = int.Parse(CGameManager.ScoreText.text);
        score += (int)(GetComponent<CShipDamage>()._shipHealth._orgHP /*/ 10.0f*/);
        CGameManager.ScoreText.text = score.ToString();
    }
}
