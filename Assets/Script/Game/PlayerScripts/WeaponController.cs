using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class WeaponController : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject firePoint;

    private Button btn;

    void Start()
    {
        btn = GameObject.FindGameObjectWithTag("ShootButton").GetComponent<Button>();
        btn.onClick.AddListener(Shoot);
    }
    public void Shoot(){
        PhotonNetwork.Instantiate(bullet.name, firePoint.transform.position, firePoint.transform.rotation);
    }
}
