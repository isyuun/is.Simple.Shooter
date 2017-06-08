using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Input->Movement
/// </summary>
public class CInputMovement : _MonoBehaviour
{
    private const float LIMIT_POS_Y = 5.5f, LIMIT_POS_X = 2.44f;

    public float _speed;

    public void InputMove()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(h, v);
        transform.Translate(direction * _speed * Time.deltaTime);
        //transform.Translate(direction * _speed * Time.deltaTime);

        Vector2 pos = transform.position;
        if(Mathf.Abs(pos.x) > LIMIT_POS_X)
        {
            pos.x = Mathf.Sign(pos.x) * LIMIT_POS_X;
        }
        if (Mathf.Abs(pos.y) > LIMIT_POS_Y)
        {
            pos.y = Mathf.Sign(pos.y) * LIMIT_POS_Y;
        }
        transform.position = pos;
    }

    private void Awake()
    {
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        InputMove();
    }
}
