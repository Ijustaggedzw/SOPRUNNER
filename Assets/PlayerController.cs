using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;
    public float jumpForce;
    float maxSpeed = 5.0f;
    public bool isOnGround = false;


    Rigidbody2D playerObject;

    // Start is called before the first frame update
    void Start()
    {


        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementValueX = 1;

        playerObject.velocity = new Vector2(movementValueX * maxSpeed, playerObject.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);

        if ((isOnGround == true) && (Input.GetAxis("Jump") > 0.0f))

        {
            playerObject.AddForce(Vector2.up * jumpForce);
        }

    }
}