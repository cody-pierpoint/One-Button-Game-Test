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
        //spawn position is set to new vector3
        Vector3 spawnposition = new Vector3();
        for (int i = 0; i < numberOfObjects; i++)
        {
            //for spawnposition y is a random y value between min y and max Y
            spawnposition.y += Random.Range(minY, maxY);
            //for spawnposition X is a random X value between min X and max X
            spawnposition.x = Random.Range(-levelWidth, levelWidth);
            //create prefabed copy of object with position being spawn Position
            Instantiate(clingPrefab, spawnposition, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
