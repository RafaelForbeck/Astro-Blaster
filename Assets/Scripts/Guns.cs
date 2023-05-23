using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    public List<BasicGun> gunsList;
    private float fireRate;
    private float shotSpeed;

    private void Start()
    {
        GunsSetup();
    }

    private void GunsSetup()
    {
        foreach (var gun in gunsList)
        {
            gun.SetFireRate(fireRate);
            gun.SetShotSpeed(shotSpeed);
        }
    }

    public void SetFireRate(float fireRate)
    {
        this.fireRate = fireRate;
    }

    public void SetShotSpeed(float shotSpeed)
    {
        this.shotSpeed = shotSpeed;
    }
}
