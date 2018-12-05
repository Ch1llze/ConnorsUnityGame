using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float playerSpeed;
    public float jumpHeight;
    private Rigidbody2D rigi;
    public LayerMask whatIsGround;
    public Vector2 groundRadius;
    public bool grounded;
    public Transform groundCheck;

    
    // Use this for initialization
    void Start () {

        rigi = GetComponent<Rigidbody2D>();
      
        

    }

    private void FixedUpdate()
    {

        
        grounded = Physics2D.OverlapArea(groundCheck.position, groundRadius, whatIsGround);



    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey (KeyCode.A))
        {
            rigi.velocity = new Vector2(-playerSpeed, rigi.velocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigi.velocity = new Vector2(playerSpeed, rigi.velocity.y);
            
        }
        if (Input.GetKeyDown (KeyCode.Space) && grounded == true)
        {
            rigi.velocity = new Vector2(rigi.velocity.x, jumpHeight);

        }
    }
}
