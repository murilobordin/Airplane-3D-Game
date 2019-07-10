using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneController : MonoBehaviour
{
    private Rigidbody rBody;
    private Quaternion airplaneRot;

    [SerializeField]
    private float vertRot;
    [SerializeField]
    private float horiRot;
    [SerializeField]
    private float angularSpeed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horiRot = HorizontalInput(horiRot);
        vertRot = VerticalInput(vertRot);

        MoveAirplane(horiRot, vertRot); 
    }

    void MoveAirplane(float horizontal, float vertical)
    {
        transform.Translate(Vector3.right * Time.deltaTime);
        transform.localEulerAngles = new Vector3(horizontal, 0f, vertical);
    }

    private float HorizontalInput(float horiInput)
    {
        if (Input.GetKey(KeyCode.A))
            horiInput+=Time.deltaTime*angularSpeed;
        else if (Input.GetKey(KeyCode.D))
            horiInput-=Time.deltaTime*angularSpeed;

        return horiInput;
    }

    private float VerticalInput(float vertInput)
    {
        if (Input.GetKey(KeyCode.W))
            vertInput-=Time.deltaTime*angularSpeed;
        else if (Input.GetKey(KeyCode.S))
            vertInput+=Time.deltaTime*angularSpeed;

        return vertInput;
    }
}
