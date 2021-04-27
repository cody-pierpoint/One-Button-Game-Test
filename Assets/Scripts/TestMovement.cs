using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Sprites;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform target;
    [SerializeField] private Transform player;
    [SerializeField] private Transform playerRot;
    [SerializeField] private float distance;
    [SerializeField] private float maxDistance;
    [SerializeField] private bool isLockedOn = false;
    [SerializeField] private int currentTarget;
    [SerializeField] private Transform tempTarget;
    public Vector3 direction = Vector3.up;

    // Start is called before the first frame update
    public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles)
    {
        return RotatePointAroundPivot(point, pivot, Quaternion.Euler(angles));
    }
    public Vector3 RotatePointAroundPivot(Vector3 player, Vector3 target, Quaternion rotation)
    {
        return rotation * (player - target) + target;
    }
    private void Awake()
    {

    }
    void Start()
    {
        //player.transform.rotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);

    }


    // Update is called once per frame
    void Update()
    {
        MoveTest2();
        // targets[currentTarget] = GameObject.FindGameObjectWithTag("Cling");
        //distance = Vector3.Distance(transform.position, target[currentTarget].transform.position);
        //currentTarget = target.Length;
        //if (!isLockedOn)
        //{
        //    player.transform.Translate(transform.up * speed * Time.deltaTime);

        //}

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    //transform.LookAt(target.position, transform.localPosition.);
        //    //transform.Translate(transform.right);

        //    player.transform.parent = target.transform;
        //    target.transform.Rotate(transform.forward);
        //    isLockedOn = true;


        //}
        //else if (Input.GetKey(KeyCode.Space))
        //{
        //    //player.transform.parent = target.transform;
        //    player.transform.Rotate(-transform.forward);
        //    isLockedOn = true;



        //}
        //else
        //{

        //    //player.transform.Translate(transform.up * speed * Time.deltaTime);
        //       isLockedOn = false;
        //}


        //player.transform.Translate(transform.up * speed * Time.deltaTime);




        //MoveTowardsTest();


        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    player.transform.Translate(transform.forward * speed * Time.deltaTime);

        //}
        //target].transform.parent = null;




        //   transform.LookAt(target);
        //   transform.rotation *= Quaternion.FromToRotation(Vector3.left, Vector3.forward);
        //  // transform.Translate(transform.up * speed * Time.deltaTime);
        //if(Vector3.Distance(transform.position, target.transform.position) >= 5f)
        //   {
        //       transform.Translate(-transform.up * speed * Time.deltaTime);
        //       transform.Translate(transform.right * speed * Time.deltaTime);


        //   }
        //else if(Vector3.Distance(transform.position, target.transform.position) <= 5f)
        //   {
        //       transform.Translate(transform.up * speed * Time.deltaTime);
        //       transform.Translate(-transform.right * speed * Time.deltaTime);
        //   }
        //transform.Translate(-transform.right * speed * Time.deltaTime);
    }
    private void LateUpdate()
    {
        // player.transform.rotation = Quaternion.(Vector3.forward);
    }


    private void MoveTowardsTest()
    {
        //    transform.Translate(Vector3.MoveTowards(transform.position, target.transform.right, speed));
        //    transform.Translate(Vector3.MoveTowards(transform.position, -target.transform.up, speed));



    }

    private void MoveTest2()
    {



        if (Input.GetKey(KeyCode.Space))
        {
            if (target == null)
            {
                target = tempTarget;

            }

            else
            {
                target = null;
            
            }


           // transform.RotateAround(target.transform.position, Vector3.forward, -20 * speed * Time.deltaTime);
           // isLockedOn = true;
        }

        if (target == null)
        {
            transform.Translate(transform.up * speed * Time.deltaTime);


        }
        else
        {
            transform.RotateAround(target.transform.position, Vector3.up, 20 * speed * Time.deltaTime);
        }

    }




}
