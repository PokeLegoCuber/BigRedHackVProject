using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;
    private float inputHorizontal;
    private float inputVertical;



    // Start is called before the first frame update
    void Start() {
       // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(inputHorizontal * speed, rb.velocity.y);
    }
}
