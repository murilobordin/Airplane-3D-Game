using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform camSupport, airplane;
    private Vector3 prevPosition, newPosition;
    private float distance = 5f;

    // Start is called before the first frame update
    void Start()
    {
        airplane = GameObject.FindWithTag("Airplane").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera(airplane.position);
    }

    void MoveCamera(Vector3 target)
    {
        transform.LookAt(target);
        prevPosition = airplane.localPosition;
        prevPosition.x -= distance;
        transform.position = prevPosition;
    }
}
