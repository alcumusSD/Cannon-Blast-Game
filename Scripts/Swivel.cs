using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swivel : MonoBehaviour
{
    [SerializeField]
    float speed;
    float rotH;
    float rotH2;

    public GameObject Cannon;
    public GameObject LaunchPoint;
    private float xRotation = 0.5f;
    private float yRotation = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        Cannon = GameObject.Find("canon_lvl_1");
        LaunchPoint = GameObject.Find("LaunchPoint");
        rotH = 0;
        rotH2 = 0;
        speed = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Cannon.transform.Rotate(0.0f, -0.1f, 0.0f, Space.Self);
            //LaunchPoint.transform.Rotate(0.0f, -0.05f, 0.0f, Space.World);
            //xRotation = Mathf.Clamp(xRotation * Time.deltaTime * 5, -180, 180);
            //transform.eulerAngles = new Vector3(xRotation, 0.0f, 0.0f);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
          Cannon.transform.Rotate(0.0f, 0.1f, 0.0f, Space.Self);
            //LaunchPoint.transform.Rotate(0.0f, 0.05f, 0.0f, Space.World);
            //xRotation = Mathf.Clamp(xRotation * Time.deltaTime * 5, -180, 180);
            //transform.eulerAngles = new Vector3(xRotation, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Cannon.transform.Rotate(-0.1f, 0.0f, 0.0f, Space.Self);
            //LaunchPoint.transform.Rotate(-0.05f, 0.0f, 0.0f, Space.World);
            //yRotation = Mathf.Clamp(yRotation * Time.deltaTime * 5, -180, 180);
            //transform.eulerAngles = new Vector3(0.0f, yRotation, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Cannon.transform.Rotate(0.1f, 0.0f, 0.0f, Space.Self);
            //LaunchPoint.transform.Rotate(0.05f, 0.0f, 0.0f, Space.World);
            // yRotation = Mathf.Clamp(yRotation * Time.deltaTime * 5, -180, 180);
            //transform.eulerAngles = new Vector3(0.0f, yRotation, 0.0f);
        }
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Cannon.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        }*/

    }

    /*void FixedUpdate()
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




    }*/


}
