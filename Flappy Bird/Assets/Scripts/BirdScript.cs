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
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            myRigidBody.velocity = Vector2.up * jump;
        }
    }
}
