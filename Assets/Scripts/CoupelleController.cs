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


    void FixedUpdate()
    {
        _direction = new Vector3(
            Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime,
            0f,
            Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime
        );

        _rb.MovePosition(transform.position + _direction);
    }
}
