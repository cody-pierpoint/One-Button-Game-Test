using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private Transform target;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerPOS = GameObject.Find("Player").transform.transform.position;
        GameObject.Find("MainCamera").transform.position = new Vector3(PlayerPOS.x - distance, PlayerPOS.y, PlayerPOS.z - distance);

    }
}
