using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPlayerShipHealth : CShipHealth
{
    public Image _healthProgress;

    public override int HpDown(float damage)
    {
        int ret = base.HpDown(damage);
        setHp();
        return ret;
    }

    // 체력을 올려 줌
    public void HpUp(int hpValue)
    {
        //// 체력을 올려줌
        //_hp += hpValue;
        //// 체력이 100이 넘으면 100으로 설정함
        //_hp = (_hp > 100) ? 100 : _hp;
        //// 체력 게이지를 지정한 수치 만큼 채워 줌
        //_healthProgress.fillAmount = _hp * 0.01f;
        _hp += hpValue;
        _hp = (_hp > _orgHP) ? (int)_orgHP : _hp;
        setHp();
    }

    private void setHp()
    {
        _healthProgress.fillAmount = _hp / _orgHP;
    }
}
