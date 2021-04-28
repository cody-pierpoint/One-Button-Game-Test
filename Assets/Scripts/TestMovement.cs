using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    Vector3 movement;

    [SerializeField] private float speed;
    [SerializeField] private GameObject[] targets;
    [SerializeField] private GameObject closestTarget;
    [SerializeField] private Transform player;
    [SerializeField] private float distance;
    [SerializeField] private float maxDistance;
    [SerializeField] private bool isLockedOn = false;
    [SerializeField] private int currentTarget;
    [SerializeField] private Transform tempTarget;
    public Vector3 direction = Vector3.up;

    bool targetOnRight;

    // Start is called before the first frame update
    private void Awake()
    {

    }
    void Start()
    {
        //player.transform.rotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        movement = Vector3.up;
    }


    // Update is called once per frame
    void Update()
    {
        TargetSetup();
        CircleMotion();







        /*
        //MoveTest2();
        // targets[currentTarget] = GameObject.FindGameObjectWithTag("Cling");
        //distance = Vector3.Distance(transform.position, target[currentTarget].transform.position);
        //currentTarget = target.Length;
        if (!isLockedOn)
        {
            player.transform.Translate(transform.up * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.Space))
        {
            //transform.LookAt(target.position, transform.localPosition.);
            //transform.Translate(transform.right);

            player.transform.parent = target.transform;
            target.transform.Rotate(transform.forward * Time.deltaTime);
            isLockedOn = true;


        }
        //else if (Input.GetKey(KeyCode.Space))
        //{
        //    //player.transform.parent = target.transform;
        //    player.transform.Rotate(-transform.forward);
        //    isLockedOn = true;



        //}
        else
        {

            //player.transform.Translate(transform.up * speed * Time.deltaTime);
            isLockedOn = false;
        }


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
        */
    }

    private void CircleMotion()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 relativePoint = transform.InverseTransformPoint(TargetSetup().transform.position); // establish what is current target

            targetOnRight = (relativePoint.x > 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {

            if (targetOnRight)
            {
                transform.right = TargetSetup().transform.position - transform.position;
            }
            else
            {
                transform.right = -(TargetSetup().transform.position - transform.position);
            }
        }
    }

    private GameObject TargetSetup()
    {
        targets = GameObject.FindGameObjectsWithTag("Cling");
        closestTarget = null;
        maxDistance = Mathf.Infinity;
        Vector3 position = transform.position;

        foreach(GameObject target in targets)
        {
            Vector3 diff = target.transform.position - position;
            distance = diff.sqrMagnitude;
            if(distance < maxDistance)
            {
                closestTarget = target;
                maxDistance = distance;
            }


        }
        return closestTarget;

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

    




}
#region working Code for circle motion
/*private void CircleMotion()
{
    transform.Translate(Vector3.up * Time.deltaTime * speed);
    if (Input.GetKeyDown(KeyCode.Space))
    {
        Vector3 relativePoint = transform.InverseTransformPoint(targets[currentTarget].transform.position);

        targetOnRight = (relativePoint.x > 0);
    }

    if (Input.GetKey(KeyCode.Space))
    {

        if (targetOnRight)
        {
            transform.right = targets[currentTarget].transform.position - transform.position;
        }
        else
        {
            transform.right = -(targets[currentTarget].transform.position - transform.position);
        }
    }
}*/
#endregion