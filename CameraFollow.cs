using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        distanceToTarget = transform.position.x - targetObject.transform.position.x;
    }
    public GameObject targetObject;
    private float distanceToTarget;
    // Update is called once per frame
    void Update()
    {
        float targetObjectX = targetObject.transform.position.x;
        Vector3 newCameraPosition = transform.position;
        newCameraPosition.x = targetObjectX;
        transform.position = newCameraPosition;
        
    }
}
