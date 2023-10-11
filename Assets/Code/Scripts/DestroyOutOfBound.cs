using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour{

    float topBound = 30;
    float lowerBound = -10;

    private void Update(){
        
        if(transform.position.z > topBound){
            Destroy(gameObject);
        }else if(transform.position.z < lowerBound){
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}