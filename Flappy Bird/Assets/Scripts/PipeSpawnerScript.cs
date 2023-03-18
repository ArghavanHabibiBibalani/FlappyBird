using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    /// <summary>
    /// This is spawning the pipe!
    /// </summary>

    public GameObject pipe;
    public float SpawningRate;
    public float hight = 3;


    private float timer = 0;
    void Start()
    {
        PipeSpawning();

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawningRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            PipeSpawning();
            timer = 0;
        }
    }

    private void PipeSpawning()
    {
        float minPoint = transform.position.y - hight;
        float maxPoint = transform.position.y + hight;

        Vector3 position = new Vector3 (transform.position.x, Random.Range (minPoint, maxPoint));
        Instantiate(pipe, position, transform.rotation);
    }
}
