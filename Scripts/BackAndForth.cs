using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 20;
    Vector3 pointA;
    Vector3 pointB;

    // Start is called before the first frame update
    void Start()
    {
        pointA = new Vector3(-5, 4, 4);
        pointB = new Vector3(5, 4, 0);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*if (transform.position == pointA)
        {
            //rb.AddForce(Vector3.right * speed, ForceMode.Impulse);
            rb.transform.position += Vector3.right * Time.deltaTime * speed;

        }

        else if (transform.position == pointB)
        {
            //rb.AddForce(Vector3.left * speed, ForceMode.Impulse);
            rb.transform.position += Vector3.left * Time.deltaTime * speed;
        }
        Debug.Log(transform.position);*/

        rb.transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 10) -5, transform.position.y, transform.position.z);

    }
}
