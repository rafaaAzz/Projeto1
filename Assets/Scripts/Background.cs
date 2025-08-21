using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour

{
    float speed = 5f;
   
 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y <= -10f)
        {
           transform.Translate(Vector3.up * 20f);
        }
    }
}
