using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovmentScript : MonoBehaviour
{
    /// <summary>
    /// This is the pipe moving script!
    /// </summary>

    public float movingSpeed;
    public float deadZone = -20;

    void Start()
    {
        
    }


    void Update()
    {
        transform.position += Vector3.left * movingSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
