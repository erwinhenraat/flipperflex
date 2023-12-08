using UnityEngine;
using UnityEngine.Events;

public class Plunger : MonoBehaviour
{
    private GameObject ball;
    [SerializeField] private UnityEvent OnLaunchBall;

    void Start()
    {
    }

    void Update()
    {
        if (ball && Input.GetKeyDown(KeyCode.Space)) 
        {
            ball.GetComponent<Rigidbody>().AddForce(transform.up * Random.Range(200, 300));

            OnLaunchBall.Invoke();

        }
    }

    void OnCollisionEnter(Collision collision) 
    {
        if (!collision.transform.CompareTag("Player")) return;
        ball = collision.gameObject;
    }

    void OnCollisionExit(Collision collision)
    {
        if (!collision.transform.CompareTag("Player")) return;
        ball = null;
    }
}
