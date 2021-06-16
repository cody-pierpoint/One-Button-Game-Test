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
    [SerializeField] private bool isLockedOn;
    [SerializeField] private int currentTarget;
    [SerializeField] private GameObject tempTarget;
    [SerializeField] private GameObject ClingObjectPrefab;

    public Vector3 direction = Vector3.up;
    bool targetAbove;
    bool targetOnRight;

    // Start is called before the first frame update
    private void Awake()
    {

    }
    void Start()
    {
        movement = Vector3.up;

    }


    // Update is called once per frame
    void Update()
    {
        //TargetSetup();
        CircleMotion();
    }

    private void CircleMotion()
    {
        
        transform.Translate(Vector3.up * Time.deltaTime * speed);
       

        TargetSetup();
        if (Input.GetKeyDown(KeyCode.Space))
        {
           //temp target is closest Target
            tempTarget = closestTarget;
            // establish what is current target
            Vector3 relativePointX = transform.InverseTransformPoint(tempTarget.transform.position); 
            // target on the right becomes the inverse transform point of the temp target
            targetOnRight = (relativePointX.x > 0);
            
        }

        if (Input.GetKey(KeyCode.Space))
        {
            //if the target is on the right
            if (targetOnRight)
            {
                //rotate to the right
                transform.right = tempTarget.transform.position - transform.position;
                // isLockedOn = false;
            }
            else
            {
                //rotate to the left
                transform.right = -(tempTarget.transform.position - transform.position);
                // isLockedOn = false;
            }
        }




    }

    private GameObject TargetSetup()
    {
        // finds targets
        targets = GameObject.FindGameObjectsWithTag("Cling");
        closestTarget = null;
        //checks target distance
        maxDistance = Mathf.Infinity;
        
        Vector3 position = transform.position;
        if (closestTarget == targetAbove)
        {
            // distance *= 1.3f;
            //Debug.Log(distance);
        }
        //foreach target find the closest 
        foreach (GameObject target in targets)
        {

            //sets diff to be the differece between each target
            Vector3 diff = target.transform.position - position;
            distance = diff.sqrMagnitude;
            //checks the distance between target and player
            if (distance < maxDistance)
            {
                //finds the closest target based on distance
                closestTarget = target;
                maxDistance = distance;
            }


        }
        //return closest target
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



    private void SpawnEnemys()
    {
        //Instantiate(ClingObjectPrefab,gameObject,)


    }

    private void SpherecastTest()
    {
       // Physics2D.CircleCast(player, 2)


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