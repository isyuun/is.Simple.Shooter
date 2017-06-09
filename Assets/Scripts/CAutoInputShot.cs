using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CAutoInputShot : CinputShot
{

    public float MAX_COOLDOWN = 5.0f;
    public float MAX_AUTOFIRE = 10.0f;

    private float coolDownTime;
    private float autoFireTime;
    public float AutoFireTime
    {
        get { return autoFireTime; }
        set { autoFireTime = value; }
    }

    public Image coolDownImage;
    public Image autoFireImage;


    public void Reset()
    {
        MAX_COOLDOWN = 5.0f;
        MAX_AUTOFIRE = 10.0f;
        coolDownTime = MAX_COOLDOWN;
        autoFireTime = MAX_AUTOFIRE;

        _shotDelayTime = CGameManager.ShotDelayTime;
    }

    public void SetMaxAutoFireTime(float time)
    {
        Reset();
        MAX_AUTOFIRE = time;
        coolDownTime = MAX_COOLDOWN;
        autoFireTime = MAX_AUTOFIRE;
    }

    float _shotNextTime = 0;

    void ShotAuto()
    {
        if (_shotNextTime == 0)
        {
            base.Shot();
        }
        _shotNextTime += Time.deltaTime;
        if (_shotNextTime < _shotDelayTime)
        {
            return;
        }
        _shotNextTime = 0;
        base.Shot();
    }

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        Reset();
    }

    // Update is called once per frame
    protected override void Update()
    {
        if (autoFireTime > 0.0f)
        {
            if (Input.GetKey(KeyCode.LeftControl) || Input.GetMouseButton(0))
            {
                ShotAuto();
            }
            autoFireTime -= Time.deltaTime;
            coolDownTime = MAX_COOLDOWN;
            if (coolDownImage != null)
            {
                coolDownImage.enabled = false;
                coolDownImage.fillAmount = coolDownTime / MAX_COOLDOWN;
            }
            if (autoFireImage != null)
            {
                autoFireImage.enabled = true;
                autoFireImage.fillAmount = autoFireTime / MAX_AUTOFIRE;
            }
        }
        else
        {
            if (coolDownTime > 0.0f)
            {
                if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetMouseButtonDown(0))
                {
                    Shot();
                }
            }
            else
            {
                autoFireTime = MAX_AUTOFIRE;
            }
            coolDownTime -= Time.deltaTime;
            if (coolDownImage != null)
            {
                coolDownImage.enabled = true;
                coolDownImage.fillAmount = coolDownTime / MAX_COOLDOWN;
            }
            if (autoFireImage != null)
            {
                autoFireImage.enabled = false;
                autoFireImage.fillAmount = autoFireTime / MAX_AUTOFIRE;
            }
        }
    }

}
