using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speed;

    void Update()
    {
        var delta = Vector3.down * speed * Time.deltaTime;
        transform.position += delta;

        if (transform.position.y < -15)
        {
            Destroy(gameObject);
        }
    }
}
