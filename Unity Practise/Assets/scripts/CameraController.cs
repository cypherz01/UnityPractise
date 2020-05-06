using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Target;

    private Vector3 cameraOffset;


    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - Target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position + cameraOffset;
    }
}
