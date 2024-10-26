using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restrictions : MonoBehaviour
{
    float speed;
    float rotH;
    float rotH2;

    // Start is called before the first frame update
    void Start()
    {
        rotH = 0;
        rotH2 = 0;
        speed = 50;

    }

    // Update is called once per frame
    void Update()
    {
        if (rotH >= 300 || rotH <= 60)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.down * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up * Time.deltaTime * speed);
            }
        }
        rotH = transform.rotation.eulerAngles.y;

        if (rotH < 300 || rotH > 298)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up * Time.deltaTime * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.down * Time.deltaTime * speed);
            }
        }
        Debug.Log("Quaternion:" + transform.rotation.y);
        Debug.Log("EulerAngle:" + transform.rotation.eulerAngles.y);
    }
}
