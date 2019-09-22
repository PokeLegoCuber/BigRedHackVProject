using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{

    //[SerializeField]
    //public float speed = 6;


    //    void OnTriggerStay2D(Collider2D other) {
    //        if (other.tag == "Player" && Input.GetKey(KeyCode.W)) {
    //                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    //    } else if (other.tag == "Player" && Input.GetKey(KeyCode.S)) {
    //                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
    //    } else {
    //             other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    //    }
    //}

    //OnTriggerEnter2D(Collider other)
    //{
    //    // Stops the player from being affected by gravity while on ladder
    //    if (other.Tag == "Player")
    //        other.gameObject.GetComponent<RigidBody2D>().gravityScale = 0;
    //}

    //OnTriggerStay2D(Collider other)
    //{
    //    if (!(other == "Player"))
    //        return;

    //    float y = Input.GetAxis("Vertical");
    //    other.transform.translate(new Vector3(0, other, 0));
    //}

    //OnTriggerExit2D(Collider other)
    //{
    //    // Stops the player from being affected by gravity while on ladder
    //    if (other.Tag == "Player")
    //        other.gameObject.GetComponent<RigidBody2D>().gravityScale = 1;
    //}
}
