using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // public float speed = 10;
    public Joystick myJoystick;
    private Rigidbody _rigidbody;
    private float _horizontalMovement, _verticalMovement;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = myJoystick.Horizontal;
        _verticalMovement = myJoystick.Vertical;
        
        _rigidbody.AddForce(_horizontalMovement /* Time.deltaTime * speed*/, 0, _verticalMovement /* Time.deltaTime * speed*/, ForceMode.VelocityChange);
    }
}
