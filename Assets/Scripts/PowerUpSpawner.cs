using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject powerUpModel;
    public float chance; // 50%

    private void OnDestroy()
    {
        var num = Random.Range(0f, 100f);
        if (num <= chance)
        {
            Instantiate(powerUpModel, transform.position, Quaternion.identity);
        }
    }
}
