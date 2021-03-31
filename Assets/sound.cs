using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{

    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("collision");
        Debug.Log(gameObject.name + " has collided with " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("sound"))
        {
            print("play");
            source.Play();
        }
    }

}
