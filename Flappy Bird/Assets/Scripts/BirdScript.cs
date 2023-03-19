using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    /// <summary>
    /// This is the bird script!
    /// </summary>

    public Rigidbody2D myRigidBody;
    public int jump ; // maybe i shoud change it to const value
    public LogicManagerScript logic;
    public bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true) {

            myRigidBody.velocity = Vector2.up * jump;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}
