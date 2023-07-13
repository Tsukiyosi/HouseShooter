using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float healthPoints = 100;
    private float collectedCoins = 0;

    public float HP{
        get {return healthPoints;}
        set {healthPoints = value;}
    }

    public float CollectedCoins{
        get {return collectedCoins;}
        set {collectedCoins = value;}
    }


    void Update()
    {
        if (HP <= 0f){
            Destroy(this);
        }
    }
}
