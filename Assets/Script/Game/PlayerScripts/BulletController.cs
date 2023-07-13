using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BulletController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private PhotonView view;
    void Start()
    {
        view = GetComponent<PhotonView>();
        rb = GetComponent<Rigidbody2D>();
        if(view.IsMine)
            rb.velocity = transform.up * speed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player")){
            PlayerController pc = other.gameObject.GetComponent<PlayerController>();
            pc.HP -= 40;
            Debug.Log(pc.HP);
        }
        Destroy(this.gameObject);
        
    }
}
