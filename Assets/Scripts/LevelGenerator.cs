using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject clingPrefab;

    public int numberOfObjects = 100;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnposition = new Vector3();
        for (int i = 0; i < numberOfObjects; i++)
        {
            spawnposition.y += Random.Range(minY, maxY);
            spawnposition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(clingPrefab, spawnposition, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
