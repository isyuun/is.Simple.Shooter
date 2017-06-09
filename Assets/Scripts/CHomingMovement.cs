using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHomingMovement : CDirectMovement
{

    private Transform _target;
    public float _delay = 0.0f;
    public float offset = 0.0f;

    public enum FacingDirection
    {
        UP = 270,
        DOWN = 90,
        LEFT = 180,
        RIGHT = 0
    }

    private Quaternion FaceObject(Vector2 startingPosition, Vector2 targetPosition, FacingDirection facing)
    {
        Vector2 direction = targetPosition - startingPosition;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        angle -= (float)facing;
        return Quaternion.AngleAxis(angle, Vector3.forward);
    }


    protected void Homing()
    {
        //Debug.Log(this.GetMethodName() + _target + ":" + _target.position);
        Quaternion rotation = FaceObject(transform.position, _target.position, FacingDirection.UP);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, _speed * Time.deltaTime);
    }

    private void Awake()
    {
        if (GameObject.FindWithTag("Player"))
        {
            _target = GameObject.FindWithTag("Player").GetComponent<Transform>();
        }
    }

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
        Invoke("Homing", _delay);
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
