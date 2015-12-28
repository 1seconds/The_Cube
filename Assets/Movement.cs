using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    public GameObject camera01;


    public float Speed = 10f;
    Rigidbody rigdbody;
    Vector3 movement;



    public float Force;

    public float xForce=0;
    public float yForce=0;
    public float zForce=0;

    public float Jump;
    

    // Use this for initialization
    void Start()
    {
        
        Force = 0.2f;
        Jump = 2.0f;

    }

    // Update is called once per frame

    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(camera01.GetComponent<Camera>().currentXRotation, camera01.GetComponent<Camera>().currentYRotation, 0);


        xForce = Input.GetAxis("Horizontal") * Force;
        yForce = Input.GetAxis("Vertical") * Force;
        

        transform.Translate(new Vector3(xForce, zForce, yForce));


        if (zForce > 3.0f)
        {
            zForce -= 1.0f;
        }

        zForce = Input.GetAxis("Jump") * Force;
    }

        


}