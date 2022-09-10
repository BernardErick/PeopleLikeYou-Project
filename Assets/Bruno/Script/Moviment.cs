using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public float velPlayer;
    public Rigidbody2D rb;
    private Inventory inventory;

    [SerializeField] private UI_Inventory uiInventory;

    private void Awake(){
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }

    void Update()
    {
        move();
    }

    void move(){
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        // transform.position = transform.position + movement * Time.deltaTime * velPlayer;
        rb.velocity = new Vector2(movement.x * velPlayer , movement.y * velPlayer);

        if(Input.GetAxis("Horizontal")>0f){
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }

        if(Input.GetAxis("Horizontal")<0f){
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }
    }
}
