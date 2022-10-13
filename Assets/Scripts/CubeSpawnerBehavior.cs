using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnerBehavior : MonoBehaviour
{
    public GameObject cube;
    public float interval = 1f;
    float currentTime = 0f;

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > interval)
        {
            GameObject newCube = Instantiate(cube, transform.position, Random.rotation);
            currentTime = 0f;
            Rigidbody newCubeRb = newCube.GetComponent<Rigidbody>();
            newCubeRb.AddForce(
                new Vector3(
                    Random.Range(-5.0f, 5.0f),
                    10.0f,
                    Random.Range(-5.0f, 5.0f)
                ), ForceMode.Impulse
            );
        }
    }
}
