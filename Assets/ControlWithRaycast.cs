using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlWithRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform gizmo;
    
    private Rigidbody _rigidbody;
    private RaycastHit _hit;
    private float _horizontalMovement, _verticalMovement, _sagitalMovement;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>(); // Assigning
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out _hit))
            {
                gizmo.position = _hit.point;
                
                _horizontalMovement = _hit.point.x - transform.position.x;
                _verticalMovement = _hit.point.y - transform.position.y;
                _sagitalMovement = _hit.point.z - transform.position.z;

            }
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(_horizontalMovement ,  _verticalMovement, _sagitalMovement ,ForceMode.VelocityChange);
    }
}
