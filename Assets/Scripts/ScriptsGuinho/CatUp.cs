using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatUp : MonoBehaviour
{
    public float timeBetweenSpawn;

    public GameObject cat; //prefab do gato

    public Transform spawn1; // início do spawn
    public Transform spawn2; // fim do spawn

    public void SpawnCat()
    {
        //cria o gato em uma posição aleatória entre o começo e o fim do spawn
        var projectille = Instantiate(cat);
        Vector3 spawnPosition = spawn1.position;

        spawnPosition.x = Random.Range(spawn1.position.x, spawn2.position.x);
        projectille.transform.position = spawnPosition;
    }

    IEnumerator SpawnCatCoroutine()
    {
        //delay entre um spawn e outro
        while (true)
        {
            SpawnCat();

            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(SpawnCatCoroutine());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StopAllCoroutines();
        }
    }
}
