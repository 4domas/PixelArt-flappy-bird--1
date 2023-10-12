using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGround : MonoBehaviour
{
    public float speed;
    public float startX;
    public float endX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < startX)
        {
            transform.position = new Vector3(endX,-7);
        }
    }
}
