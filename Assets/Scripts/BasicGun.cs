using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGun : MonoBehaviour
{
    public GameObject basicShotModel;
    public float fireRate;
    float timer;
    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= fireRate)
        {
            // Praticamente estamos zerando o timer.
            // Fazemos assim para não acumular erro
            timer -= fireRate;

            // Shot - Vamos instanciar um BasicShot
            GameObject shotGO = Instantiate(basicShotModel, transform.position, Quaternion.identity);
            BasicShot basicShot = shotGO.GetComponent<BasicShot>();
            basicShot.direction = transform.eulerAngles.z;
        }
    }
}
