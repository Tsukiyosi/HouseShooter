using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    [SerializeField] public GameObject lose;
    [SerializeField] public GameObject win;
    private GameObject[] players;
    private PlayerController pc;
    void Start()
    {
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        players = GameObject.FindGameObjectsWithTag("Player");
    }

    void Update()
    {
        if (pc.HP <= 0){
            lose.SetActive(true);
        }

        if(players.Length == 1 && lose.activeSelf == false){
            win.SetActive(true);
        }
    }
}
