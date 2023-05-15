using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public List<Transform> listaPontos;
    int indice = 0;

    void Update()
    {
        Vector3 proximoPonto = listaPontos[indice].position;

        Vector3 direcao = proximoPonto - transform.position;
        Vector2 direcaoNormalizada = direcao.normalized;
        Vector3 delta = direcaoNormalizada * speed * Time.deltaTime;

        if (delta.magnitude >= direcao.magnitude)
        {
            // Chegou
            transform.position = proximoPonto;
            indice += 1;
            if (indice >= listaPontos.Count)
            {
                indice = 0;
            }
        }
        else
        {
            // Ainda não chegou
            transform.position += delta;
        }
    }
}
