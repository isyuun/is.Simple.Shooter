using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Straight Foward
/// </summary>
public class CDirectMovement : _MonoBehaviour
{
    private const float LIMIT_POS_Y = 4.5f, LIMIT_POS_X = 2.44f;

    public Vector2 _direction;
    public float _speed;

    void Move()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();

        Vector2 pos = transform.position;
        if (Mathf.Abs(pos.x) > LIMIT_POS_X)
        {
            //pos.x = Mathf.Sign(pos.x) * LIMIT_POS_X;
            Destroy(gameObject);
        }
        if (Mathf.Abs(pos.y) > LIMIT_POS_Y)
        {
            //pos.y = Mathf.Sign(pos.y) * LIMIT_POS_Y;
            Destroy(gameObject);
        }
        //transform.position = pos;
    }
}
