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
        var fireRate = GetFireRate(level);
        guns.SetFireRate(fireRate);
        var shotSpeed = GetShotSpeed(level);
        guns.SetShotSpeed(shotSpeed);
        var toggleGuns = GetToggleGuns(level);
        guns.SetToggleGuns(toggleGuns);
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
            case 2: return 25f;
            case 3: return 30f;
            case 4: return 35f;
            case 5: return 40f;
            case 6: return 45f;
            default: return 45;
        }
    }

    private List<bool> GetToggleGuns(int level)
    {
        switch (level)
        {
            case 1: return new List<bool>() { false, false, true, false, false };
            case 2: return new List<bool>() { false, true, false, true, false };
            case 3: return new List<bool>() { false, true, true, true, false };
            case 4: return new List<bool>() { false, true, true, true, false };
            case 5: return new List<bool>() { true, true, false, true, true };
            case 6: return new List<bool>() { true, true, true, true, true };
            default: return new List<bool>() { true, true, true, true, true };
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            level++;
            GunsSetup(level);
            Destroy(collision.gameObject);
        }
    }
}