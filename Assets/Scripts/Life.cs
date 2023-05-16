using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public float life;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        life -= 1;
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
        Destroy(collision.gameObject);
    }
}
