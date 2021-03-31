using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telepo : MonoBehaviour
{
    public Vector3 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(2.9f, 0.41f, 0f);
        targetPos = new Vector3(0.49f, 0.11f, 4.42f);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("collision");

        if (collision.gameObject.CompareTag("sound"))
        {
            print("collided");
            transform.position = targetPos;

        }
    }


}
