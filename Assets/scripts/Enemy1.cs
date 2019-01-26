using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;


public class Enemy1 : MonoBehaviour
{

    public GameObject target;
    NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();

        //Vector3 destination = target.transform.position;

        //agent.SetDestination(destination); //(destination.x,destination.y,destination.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
