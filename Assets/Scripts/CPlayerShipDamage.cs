using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerShipDamage : CShipDamage
{
    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        base.OnTriggerEnter2D(collider);
        //Debug.Log(this.GetMethodName() + collider.gameObject + ":" + collider.tag);
        if (collider.tag == "ENEMY")
        {
            Hit(collider);
        }
    }

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(this.GetMethodName() + collision.gameObject + ":" + collision.collider.tag);
        base.OnCollisionEnter2D(collision);
        if (collision.collider.tag == "ENEMY")
        {
            Hit(collision.collider);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
