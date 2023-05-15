using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShot : MonoBehaviour
{
    public float speed;
    public float direction;

    private void Start()
    {
        transform.Rotate(0f, 0f, direction);
    }

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;

        if (transform.position.y > 15)
        {
            Destroy(gameObject);
        }
    }
}
