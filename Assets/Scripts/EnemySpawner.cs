using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public SpawnerManager spawnerManager;
    public GameObject modeloInimigo;
    public float intervalo;
    public int quantidade;
    public List<Transform> listaPontos;

    private float tempo = 0f;
    private int contador = 0;

    private List<GameObject> enemies = new List<GameObject>();

    void Update()
    {
        if (CheckAnyAlive() == false)
        {
            WaveEnded();
        }
        SpawnEnemy();
    }

    public void StopSpawner()
    {
        gameObject.SetActive(false);
    }

    public void StartSpawn()
    {
        gameObject.SetActive(true);
    }

    private void SpawnEnemy()
    {
        if (contador >= quantidade)
        {
            return;
        }

        tempo += Time.deltaTime;

        if (tempo >= intervalo)
        {
            // Gera um inimigo
            GameObject inimigoGO = Instantiate(modeloInimigo, transform.position, Quaternion.identity);

            enemies.Add(inimigoGO);

            EnemyMovement enemyMovement = inimigoGO.GetComponent<EnemyMovement>();
            enemyMovement.listaPontos = listaPontos;

            tempo -= intervalo;
            contador += 1;
        }
    }

    private bool CheckAnyAlive()
    {
        if (contador < quantidade)
        {
            return true;
        }
        
        foreach (var enemy in enemies)
        {
            if (enemy != null)
            {
                return true;
            }
        }

        return false;
    }

    private void WaveEnded()
    {
        gameObject.SetActive(false);
        spawnerManager.WaveEnded();
    }
}