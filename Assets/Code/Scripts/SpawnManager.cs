using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour{

    [SerializeField] float spaenRangeX = 20;
    [SerializeField] float spawnPosZ = 20;

    [SerializeField] float startDelay = 2;
    [SerializeField] float spawnInterval = 1.5f;

    [SerializeField] GameObject[] animalPrefabs = new GameObject[3];

    private void Start(){
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal(){

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spaenRangeX, spaenRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), animalPrefabs[animalIndex].transform.rotation);
    }
}