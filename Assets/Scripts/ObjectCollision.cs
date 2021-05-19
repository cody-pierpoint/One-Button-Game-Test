using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    [SerializeField] private GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FreezeCamRot();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Cling"))
        {
            Destroy(gameObject);

        }
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
            Debug.Log("Wall touched");
        }


        Debug.Log(collision);
    }

    private void FreezeCamRot()
    {
        
        //camera.transform.localRotation *= Quaternion.Euler(0, transform.rotation.y, 0);
    }
    

}
