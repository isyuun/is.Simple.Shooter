using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSpaceCollision : _MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(this.GetMethodName() + collision.gameObject + ":" + collision.collider.tag);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log(this.GetMethodName() + collision.gameObject + ":" + collision.collider.tag);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log(this.GetMethodName() + collider.gameObject + ":" + collider.tag);
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        //Debug.Log(this.GetMethodName() + collider.gameObject + ":" + collider.tag);
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        //Debug.Log(this.GetMethodName() + collider.gameObject + ":" + collider.tag);
        Destroy(collider.gameObject);
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
