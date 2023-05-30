using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour
{
    public List<BasicGun> gunsList;

    public void SetFireRate(float fireRate)
    {
        foreach (var gun in gunsList)
        {
            gun.SetFireRate(fireRate);
        }
    }

    public void SetShotSpeed(float shotSpeed)
    {
        foreach (var gun in gunsList)
        {
            gun.SetShotSpeed(shotSpeed);
        }
    }

    public void SetToggleGuns(List<bool> turnOn)
    {
        for (int i = 0; i < gunsList.Count; i++)
        {
            var isActive = turnOn[i];
            gunsList[i].SetActiveGun(isActive);
        }
    }
}
