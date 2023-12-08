using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;
using UnityEngine.Events;


public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent OnTeleported;
    public UnityEvent OnEnterTeleport;
    public GameObject teleportOut;
    public float time;
    private GameObject ball;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
       

        if (col.gameObject.name == "Ball") {
            OnEnterTeleport.Invoke();
            ball = col.gameObject;
            ball.gameObject.SetActive(false);
            StartCoroutine(Wait(.5f));
        }
    }

    IEnumerator Wait(float time) {

        yield return new WaitForSeconds(time);
        Move();

    }
    private void Move()
    {
        ball.transform.position = teleportOut.transform.position;
        ball.SetActive(true);
        OnTeleported.Invoke();


    }
}
