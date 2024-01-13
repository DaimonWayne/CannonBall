using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFire : MonoBehaviour
{
    [SerializeField] private float Speed = 5.0f;
    [SerializeField] private Rigidbody ballRb;

    private void Start()
    {
        ballRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Fire();
    }

    public void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballRb.velocity = transform.forward * Time.deltaTime * Speed;
        }
    }
}
