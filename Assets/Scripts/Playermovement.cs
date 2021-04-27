using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] GameObject clingObjects;
    [SerializeField] GameObject player;
    //[SerializeField] bool looking = false;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        clingObjects = GameObject.FindGameObjectWithTag("Obstacle");
        player.transform.Translate(Vector3.left * speed * Time.deltaTime);
        Debug.Log("stuff is happening");
        if (Input.GetKey(KeyCode.Q))
        {
            clingObjects.transform.position = new Vector3(player.transform.position.x, clingObjects.transform.position.y, player.transform.position.z);
            Debug.Log("space pressed");
            player.transform.LookAt(clingObjects.transform);
           
        }
        //Cling();
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Debug.Log("space pressed");
        //    transform.LookAt(clingObjects.transform);
        //    Debug.Log("looking at object");
        //    if (clingObjects.transform.position.x >= player.transform.position.x)
        //    {
        //        transform.Translate(Vector3.left);
        //        Debug.Log("translate left");
        //    }
        //    if (clingObjects.transform.position.x <= player.transform.position.x)
        //    {
        //        transform.Translate(Vector3.right);
        //        Debug.Log("translate right");
        //    }
        //    transform.Translate(Vector3.left);

        //}
    }

    private void Cling()
    {
        clingObjects = GameObject.FindGameObjectWithTag("Obstacle");
        player.transform.Translate(Vector3.left * speed * Time.deltaTime);
        // clingObjects.transform.position = new Vector3(clingObjects.transform.position.x, clingObjects.transform.position.y, clingObjects.transform.position.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.LookAt(clingObjects.transform.position, Vector3.left);
            
        }
       

       






    }


}
