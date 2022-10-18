using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoupelleController : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody _rb;
    Vector3 _direction;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _direction = new Vector3(
            Input.GetAxis("Horizontal") * speed,
            0f,
            Input.GetAxis("Vertical") * speed
        );

        // transform.position += _direction * Time.deltaTime;
    }
        
    void FixedUpdate()
    {
        _rb.MovePosition(transform.position + _direction * Time.fixedDeltaTime);
    }
}
