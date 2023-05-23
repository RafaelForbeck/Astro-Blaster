using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    private int level = 1;
    public Guns guns;

    private void Start()
    {
        GunsSetup(level);
    }

    private void GunsSetup(int level)
    {
        guns.SetFireRate(GetFireRate(level));
        guns.SetShotSpeed(GetShotSpeed(level));
    }

    private float GetFireRate(int level)
    {
        switch (level)
        {
            case 1: return 0.40f;
            case 2: return 0.35f;
            case 3: return 0.30f;
            case 4: return 0.25f;
            case 5: return 0.20f;
            case 6: return 0.25f;
            default: return 0.25f;
        }
    }

    private float GetShotSpeed(int level)
    {
        switch (level)
        {
            case 1: return 20f;
            case 2: return 30f;
            case 3: return 40f;
            case 4: return 50f;
            case 5: return 60f;
            case 6: return 70f;
            default: return 70;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            level++;
            GunsSetup(level);
        }
    }
}