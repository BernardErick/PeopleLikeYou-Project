using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public float velPlayer;
    public Rigidbody2D rb;

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0.0f);
        // transform.position = transform.position + movement * Time.deltaTime * velPlayer;
        rb.velocity = new Vector2(movement.x * velPlayer , movement.y * velPlayer);
    }
}
