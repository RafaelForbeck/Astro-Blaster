using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject modeloInimigo;
    public float intervalo;
    public int quantidade;
    public List<Transform> listaPontos;

    float tempo = 0f;
    int contador = 0;

    void Update()
    {
        tempo += Time.deltaTime;

        if (tempo >= intervalo)
        {
            // Gera um inimigo
            GameObject inimigoGO = Instantiate(modeloInimigo, transform.position, Quaternion.identity);
            EnemyMovement enemyMovement = inimigoGO.GetComponent<EnemyMovement>();
            enemyMovement.listaPontos = listaPontos;

            tempo -= intervalo;
            contador += 1;
            if (contador >= quantidade)
            {
                gameObject.SetActive(false);
            }
        }
    }
}