using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    public float smoothSpeed = .3f;
   // private Vector3 currentVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        //if there is no target
        if (target != null)
        {

            //if target height is greater then camera height
            if (target.transform.position.y > transform.position.y)
            {
                //camera position = target Y position
                Vector3 newPos = new Vector3(transform.position.x, target.transform.position.y, transform.position.z);
                transform.position = newPos;
                //Vector3.SmoothDamp(transform.position, newPos, ref currentVelocity, smoothSpeed);
                //transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed);

            }
            //target y is less then camera y
            else if (target.transform.position.y < transform.position.y)
            {
                //camera position = target y;
                Vector3 newPos = new Vector3(transform.position.x, target.transform.position.y, transform.position.z);
                transform.position = newPos;
            }
        }
    }
}
