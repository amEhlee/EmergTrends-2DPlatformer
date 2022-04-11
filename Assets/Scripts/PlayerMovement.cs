using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // init some stuffz
    public float speed;
    public float jumpSpeed;
    private float move;
    private new Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        // import rigidbody this will be used to manipulate our player position
        rigidbody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    { 
        move = Input.GetAxis("Horizontal"); // record all horizontal movement
        rigidbody.velocity = new Vector2(speed * move, rigidbody.velocity.y);

        // when space is pressed ...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // jump!
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpSpeed);
        }
    }
}