using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnClingObjects : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform player;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject deathPanel;
    private int scoreTimer;
    private float spawntimer = 1f;
    private float countdown;
    private Vector3 objectpos;

    public float xMin;
    public float xMax;
    private bool isDead = false;
    private bool Isdead
    {
        get
        {
            return isDead;
        }
        set
        {
            isDead = value;
            deathPanel.SetActive(value);
            Time.timeScale = value ? 0 : 1;
        }
    }
    public float yMin;
    public float yMax;


    // Start is called before the first frame update
    void Start()
    {
        countdown = spawntimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Score();
            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                SpawnObjects();
                countdown = spawntimer;
            }

        }

        else
        {
            deathPanel.SetActive(true);
            isDead = !isDead;
        }
      
        
    }

    void SpawnObjects()
    {
        
        objectpos = new Vector3(Random.Range(xMin, yMin), Random.Range(yMin, yMax) + player.transform.position.y );

        GameObject createdObject = Instantiate(prefab);
        createdObject.transform.parent = gameObject.transform;
        createdObject.transform.position = objectpos;
    }



    void Score()
    {

        scoreTimer = (int)Time.time *10;

        scoreText.text = "Score: " + scoreTimer;
    }
}
