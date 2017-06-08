using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnemyShipDamage : CShipDamage
{
    private void OnDestroy()
    {
        //Debug.Log(this.GetMethodName() + gameObject.name + ":" + _shipHealth._orgHP + ":" + _shipHealth._hp);
        int score = int.Parse(CGameManager.ScoreText.text);
        score += (int)(_shipHealth._orgHP /*/ 10.0f*/);
        CGameManager.ScoreText.text = score.ToString();
    }
}
