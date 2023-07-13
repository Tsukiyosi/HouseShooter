using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Win : MonoBehaviour
{
   [SerializeField] TMP_Text collectedCoins;
    PlayerController pc;
    void Start()
    {

        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        gameObject.SetActive(false);
    }

    
    void Update()
    {
        collectedCoins.text = "Collected coins:" + pc.CollectedCoins;

        if(gameObject.activeSelf){
            Invoke("OpenMenu", 4);
        }
    }

    void OpenMenu(){
        SceneManager.LoadScene("Loading");
    }
    
}
