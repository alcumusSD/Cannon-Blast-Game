using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileShoot : MonoBehaviour
{
    [SerializeField]
    public float speed = 20;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void move()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);
        //rb.velocity = speed;
    }
}
