using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody PlayerRigid;
    public float Upspeed;
    // Use this for initialization
    void Start()
    {
        PlayerRigid = Player.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Ground" && Input.GetKey(KeyCode.Space)) //Groundと接触している、かつスペースキーが押されたとき
        {
            PlayerRigid.AddForce(transform.up * 100);



        }

    }
}