using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        // Teclado e joystick
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 delta = new Vector3(horizontal, vertical);

        transform.position += delta * speed * Time.deltaTime;

        // Acelerômetro
        float x = Input.acceleration.x;
        float y = Input.acceleration.y;

        Vector3 alpha = new Vector3(x, y);

        transform.position += alpha * speed * Time.deltaTime;
    }
}
