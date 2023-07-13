using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    PlayerController pc;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player")){
            pc = other.gameObject.GetComponent<PlayerController>();
            pc.CollectedCoins += 1;
            Destroy(this.gameObject);
        }
            
    }
   
}
