using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeract : MonoBehaviour
{
    public float playerMoveSpeed;
    public Rigidbody2D playerRB;
    public Collider2D playerColl;

    // Start is called before the first frame update
    void Start()
    {
        playerColl = GetComponent<Collider2D>();
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
    void PlayerMove()
    {
        float horizontalNum = Input.GetAxis("Horizontal");
        float faceNum = Input.GetAxis("Horizontal");
        playerRB.velocity = new Vector2(playerMoveSpeed * horizontalNum, playerRB.velocity.y);
    }
}
