using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;
    public Sprite profile;
    public string speechTxt;
    public string actorName;
    public LayerMask playerLayer;
    public float radious;

    private DialogueControl dc;
    bool onRadious;

    private void Start()
    {
        // rig = GetComponent<Rigidbody2D>();

        dc = FindObjectOfType<DialogueControl>();
    }

    private void Update()
    {
        // rig.velocity = new Vector2(speed, rig.velocity.y);
        if(Input.GetKeyDown(KeyCode.Space) && onRadious){
            dc.Speech(profile,speechTxt, actorName);
        }
    }

    private void FixedUpdate(){
        Interact();
    }

    public void Interact(){
        Collider2D hit = Physics2D.OverlapCircle(transform.position,radious,playerLayer);
        if(hit != null){
            onRadious = true;
        } else{
            onRadious = false;
        }
    }
}
