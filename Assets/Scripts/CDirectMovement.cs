using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Straight Foward
/// </summary>
public class CDirectMovement : _MonoBehaviour
{
    //private const float LIMIT_POS_Y = 4.5f, LIMIT_POS_X = 2.44f;

    public Vector2 _direction;
    public float _speed;
    public float _orgSpeed;

    void Move()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }

    public void Stop()
    {
        _speed = 0.0f;
    }

    public void Resume()
    {
        _speed = _orgSpeed;
    }

    // Use this for initialization
    protected virtual void Start()
    {
        _orgSpeed = _speed;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Move();
    }
}
