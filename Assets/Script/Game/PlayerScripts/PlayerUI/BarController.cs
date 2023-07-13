using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarController : MonoBehaviour
{
    [SerializeField]Image healthBar;
    [SerializeField]Image coinBar;
    private PlayerController pc;
    private int maxHP = 100;
    private int maxCoins = 10;
    private int hP;
    private int collectedCoins = 0;

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
        coinBar.fillAmount = collectedCoins / maxCoins;
        healthBar.fillAmount = hP / maxHP;
    }
}
