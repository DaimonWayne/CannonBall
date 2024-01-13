using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallControl : MonoBehaviour
{
    [SerializeField] private float RotationAngle = 20.0f;
    [SerializeField] private float Smooth = 5.0f;

    [SerializeField] private GameObject Ball;

    private void LateUpdate()
    {
        ControlAngle();
    }

    private void ControlAngle()
    {
        //Topun saða sola ve yukarý aþaðý hareketi burada saðlanýyor.
        float horizontal;
        float vertical;

        horizontal = Input.GetAxis("Horizontal") * RotationAngle;
        vertical = Input.GetAxis("Vertical") * RotationAngle;

        Quaternion angle = Quaternion.Euler(vertical, horizontal, 0f);

        transform.rotation = Quaternion.Slerp(transform.rotation, angle, Time.deltaTime * Smooth);
        Ball.transform.rotation = transform.rotation;
    }   
}
