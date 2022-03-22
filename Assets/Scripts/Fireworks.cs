using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireworks : MonoBehaviour
{
    ParticleSystem ps;
    public bool test = false;
    // Start is called before the first frame update
    void Start()
    {
       ps=  gameObject.GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            test = true;
            ps.Play();
        }
    }
}
