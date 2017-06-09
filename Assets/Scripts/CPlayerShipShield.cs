using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPlayerShipShield : _MonoBehaviour
{
    public Sprite[] shields;
    private SpriteRenderer render;
    CircleCollider2D shield;

    int shieldCount = 0;
    private Text _starCountText;
    CAutoInputShot autoInputShot;

    // Use this for initialization
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        shield = GetComponent<CircleCollider2D>();
        _starCountText = GameObject.Find("StarCountText").GetComponent<Text>();
        autoInputShot = GameObject.Find("PlayerShip").GetComponent<CAutoInputShot>();

    }


    private void SetShield()
    {
        Debug.Log(this.GetMethodName() + shieldCount);
        _starCountText.text = shieldCount.ToString();
        if (shieldCount > 0 && shieldCount - 1 < shields.Length)
        {
            render.sprite = shields[shieldCount - 1];
            shield.isTrigger = false;
            /*gameObject.SetActive(true);*/
        }
        else
        {
            render.sprite = null;
            shield.isTrigger = true;
            /*gameObject.SetActive(false);*/
        }
    }

    public void SetShieldCountUp(int upCountValue)
    {
        Debug.Log(this.GetMethodName() + upCountValue);
        if (shieldCount < 3)
        {
            shieldCount += upCountValue;
        }

        if (shieldCount > 3)
        {
            shieldCount = 3;
        }

        SetShield();
    }

    private void SetShieldCountDown()
    {
        Debug.Log(this.GetMethodName() + shieldCount);
        if (shieldCount > 0)
        {
            shieldCount--;
        }
        SetShield();
    }

    void BlockShield(Collider2D collider)
    {
        Debug.Log(this.GetMethodName() + collider.gameObject + ":" + collider.tag);
        if (shieldCount > 0)
        {
            if (collider.tag == "ENEMY")
            {
                collider.GetComponent<CShipDamage>().Hit(collider);
            }
            else if (collider.tag == "LASER")
            {
                Debug.Log(this.GetMethodName() + collider.gameObject + ":" + collider.tag);
                collider.isTrigger = false;
                Destroy(collider.gameObject);
            }
            else
            {
                return;
            }
        }
        SetShieldCountDown();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(this.GetMethodName() + collider.gameObject + ":" + collider.tag);
        BlockShield(collider);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(this.GetMethodName() + collision.gameObject + ":" + collision.collider.tag);
        BlockShield(collision.collider);
    }
}
