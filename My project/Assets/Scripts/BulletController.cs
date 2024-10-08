using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    Vector3 _direction = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        _direction = transform.up;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(Vector3 direction)
    {
        _direction = direction;
    }

    void Move()
    {
        this.transform.Translate(_direction * speed);
    }
}
