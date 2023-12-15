using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveAround : MonoBehaviour
{
    [SerializeField] Transform center;
    [SerializeField] float distanceFromCenter;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(distanceFromCenter, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center.position, Vector3.up, speed);
        transform.LookAt(transform.forward, Vector3.up);
        var rot = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, -90, 0));
        transform.rotation = rot;
    }
}
