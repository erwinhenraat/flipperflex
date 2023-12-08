using UnityEngine;
using UnityEngine.Events;

public class Bumper : MonoBehaviour
{
    [SerializeField] private UnityEvent OnHit;
    [SerializeField] private float force = 75;

    void OnCollisionEnter(Collision collision) 
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        Rigidbody rigidbody = collision.gameObject.GetComponent<Rigidbody>();
        Vector3 dir = transform.position - collision.GetContact(0).point;
        rigidbody.AddForce(-dir * force);

        OnHit.Invoke();
    }
}
