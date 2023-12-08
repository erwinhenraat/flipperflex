using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerParticles : MonoBehaviour
{

    private ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ps.Stop();       
    }
     public void Trigger() {
        
        ps.Play();
        StartCoroutine(StopEmissionAfterTime(1f));
    }
    IEnumerator StopEmissionAfterTime(float time) {

        yield return new WaitForSeconds(time);
        ps.Stop();

    }

}
