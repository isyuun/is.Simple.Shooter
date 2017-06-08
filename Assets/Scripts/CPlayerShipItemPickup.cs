using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerShipItemPickup : _MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "HPUPITEM")
        //{
        //    collision.GetComponent<CHpUpItem>().Use();
        //    Destroy(collision.gameObject);
        //}
        //else if (collision.tag == "STARCOUNTUPITEM")
        //{
        //    collision.GetComponent<CStarCountUpItem>().Use();
        //    Destroy(collision.gameObject);
        //}
        //else if (collision.tag == "LASERCOUNTUPITEM")
        //{
        //    collision.GetComponent<CLaserCountUpItem>().Use();
        //    Destroy(collision.gameObject);
        //}
        if (collision.tag == "ITEM")
        {
            //collision.GetComponent<IItem>().Use();
            collision.SendMessage("Use", SendMessageOptions.DontRequireReceiver);
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "SUBSHIP")
        {
            collision.GetComponent<CSubShipCountUpItem>().Dock();
            //collision.SendMessage("Dock", SendMessageOptions.DontRequireReceiver);
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
