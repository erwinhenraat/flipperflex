using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSnow : MonoBehaviour
{
    private Vector3 startPos;
    private Rigidbody rb;
    [SerializeField]private float spawnY = 20;
    [SerializeField]private float unSpawnY = -20;
    [SerializeField] private float maxSpawnOffset = 20;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < unSpawnY) {
            Vector3 spawnPos = startPos;
            spawnPos.y = spawnY + Random.Range(0,maxSpawnOffset);
            transform.position = spawnPos;
            rb.velocity = Vector3.zero;
            
         
        }
    }
}
