using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
   // [SerializeField] private GameObject camera;
    [SerializeField] private GameObject deathPanel;
    [SerializeField] private GameObject player;

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
            deathPanel.SetActive(true);
            Time.timeScale = value ? 0 : 1;
        }
      
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //FreezeCamRot();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if player collides with gameObject tagged Cling
        if (collision.gameObject.CompareTag("Cling"))
        {
            //Destroy Player
            Destroy(player);
            //player is dead
            isDead = true;

        }
        //if player collides with gameobject tagged wall
        if (collision.gameObject.tag == "Wall")
        {
            //destroy player
            Destroy(player);
            //player is dead
            Debug.Log("Wall touched");
            isDead = true;
        }



        Debug.Log(collision);
    }

    private void FreezeCamRot()
    {
        
        //camera.transform.localRotation *= Quaternion.Euler(0, transform.rotation.y, 0);
    }
    

}
