using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    
    public GameObject target;
    NavMeshAgent agent;


    void Start()
    {
       agent = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
    }
}
