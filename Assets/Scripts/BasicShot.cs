using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicShot : MonoBehaviour
{
    private float speed;
    private float direction;

    private void Start()
    {
        transform.Rotate(0f, 0f, direction);
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += transform.up * speed * Time.deltaTime;

        if (transform.position.y > 15)
        {
            Destroy(gameObject);
        }
    }

    public void SetDirection(float direction) {
        this.direction = direction;
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }
}