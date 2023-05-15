using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShot : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;

        if (transform.position.y > 15)
        {
            Destroy(gameObject);
        }
    }
}
