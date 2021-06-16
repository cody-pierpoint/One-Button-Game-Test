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
   // private float spawntimer = 1f;
   // private float countdown;
   // private Vector3 objectpos;

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

    }

    // Update is called once per frame
    void Update()
    {
        //if player exists
        if (player != null)
        {
            //show score
            Score();

        }

        else
        {
            //death screen is active
            deathPanel.SetActive(true);
            isDead = !isDead;
        }
      
        
    }


    void Score()
    {
        //score = time.time * 10;
        scoreTimer = (int)Time.time *10;
        //display score as scoretext
        scoreText.text = "Score: " + scoreTimer;
    }
}
