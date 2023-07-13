using System.Runtime.ConstrainedExecution;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarController : MonoBehaviour
{
    [SerializeField]Image healthBar;
    [SerializeField]Image coinBar;
    private PlayerController pc;
    private float maxHP = 100;
    private float maxCoins = 10;
    private float hP;
    private float collectedCoins;

    void Start()
    {
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        hP = maxHP;
        pc.HP = hP;
    }


    void Update()
    {
        hP = pc.HP;
        collectedCoins = pc.CollectedCoins;
        coinBar.fillAmount = (float) (pc.CollectedCoins / maxCoins);
        healthBar.fillAmount = (float) (pc.HP / maxHP);
        Debug.Log("hp:" + hP);
        Debug.Log("coins:" + pc.CollectedCoins);
        Debug.Log(coinBar.fillAmount);
    }
}
