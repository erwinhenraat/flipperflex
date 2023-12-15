using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveAround2 : MonoBehaviour
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
        transform.RotateAround(center.position, Vector3.up, speed * Time.deltaTime);
        transform.LookAt(center, Vector3.up);
        transform.Rotate(0, -90, 0);
    }
}
