using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGun : MonoBehaviour
{
    public GameObject basicShotModel;
    private float fireRate;
    private float shotSpeed;
    private float timer;
    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireRate)
        {
            // Praticamente estamos zerando o timer.
            // Fazemos assim para não acumular erro
            timer -= fireRate;

            Shoot();
        }
    }

    void Shoot()
    {
        // Shot - Vamos instanciar um BasicShot
        GameObject shotGO = Instantiate(basicShotModel, transform.position, Quaternion.identity);
        BasicShot basicShot = shotGO.GetComponent<BasicShot>();
        basicShot.SetDirection(transform.eulerAngles.z);
        basicShot.SetSpeed(shotSpeed);
    }

    public void SetFireRate(float fireRate)
    {
        this.fireRate = fireRate;
    }

    public void SetShotSpeed(float shotSpeed)
    {
        this.shotSpeed = shotSpeed;
    }

    public void SetActiveGun(bool isActive)
    {
        gameObject.SetActive(isActive);
        timer = 0;
    }
}
