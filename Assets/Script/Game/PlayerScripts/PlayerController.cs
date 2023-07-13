using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int healthPoints = 100;
    private int collectedCoins = 0;

    public int HP{
        get {return healthPoints;}
        set {healthPoints = value;}
    }

    public int CollectedCoins{
        get {return collectedCoins;}
        set {collectedCoins = value;}
    }


    void Update()
    {
        if (HP <= 0){
            Destroy(this);
        }
    }
}
