using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += ((Vector3.left * speed) * Time.deltaTime);        
        transform.Translate(-0.01f, 0f, 0f);
    }
}
