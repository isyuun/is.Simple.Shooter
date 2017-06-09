using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShipDamage : _MonoBehaviour
{
    public CShipHealth _shipHealth;

    public GameObject _demageEffectPrefab;

    public Animator _animator;

    public void ShowNitEffect(Vector2 pos)
    {
        if (_demageEffectPrefab != null)
        {
            GameObject effect = Instantiate(_demageEffectPrefab, pos, Quaternion.identity);
            Destroy(effect, 0.3f);
        }

        _animator.Play("Hit");

    }

    public void Hit(Collider2D collider)
    {
        if (!enabled)
        {
            return;
        }

        Destroy(collider.gameObject);

        ShowNitEffect(collider.transform.position);

        int hp = _shipHealth.HpDown(CGameManager.LaserDamage);

        if (hp <= 0)
        {
            _shipHealth.DoDestroy();
        }
    }

    protected virtual void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log(this.GetMethodName() + collider.gameObject + ":" + collider.tag);
        if (collider.tag == "LASER")
        {
            Hit(collider);
        }    
    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(this.GetMethodName() + collision.gameObject + ":" + collision.collider.tag);
        if (collision.collider.tag == "LASER")
        {
            Hit(collision.collider);
        }
    }

    // Use this for initialization
    void Start()
    {
        //_shipHealth = GetComponent<CShipHealth>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
