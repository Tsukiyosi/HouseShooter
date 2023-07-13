using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Photon.Pun;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] public float speed = 10;
    [SerializeField] public float rotationSpeed = 300;
    private Joystick joystick;
    private Rigidbody2D rb;
    private PhotonView view;
    private Vector2 input;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        joystick = GameObject.FindGameObjectWithTag("Joystick").GetComponent<Joystick>();
        view = GetComponent<PhotonView>();
        transform.rotation = new Quaternion (0, 0, 180, 0);
    }

    void Update()
    {
        input = new Vector2(joystick.Horizontal, joystick.Vertical);
        if(view.IsMine)
            Move();
    }

    private void Move(){
       Vector2 relativePos = (Vector3)input - transform.position;

        rb.MovePosition(rb.position + input * speed * Time.deltaTime);
        
        if (input != Vector2.zero){
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, input * rotationSpeed);
            transform.rotation = toRotation;
        }

    }
}
