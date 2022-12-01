using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody body;
    public float speed;

    private float vertical;
    private float horizontal;
    private Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = (Vector3.forward * vertical + Vector3.right * horizontal) * speed * Time.fixedDeltaTime;

        mainCam.transform.position = this.transform.position + new Vector3(0,15,-10);

    }
}
