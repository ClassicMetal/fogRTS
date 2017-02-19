using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeTrigger : MonoBehaviour
{

    public AgentMovement parentUnit;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyUnit")
        {
            //if (unitState != e_unitStates.moving)

            parentUnit.enemiesInRange.Add(other.gameObject);
            print("Enemy Contact: " + other.name);
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.tag == "EnemyUnit")
        {
            //if (unitState != e_unitStates.moving)

            parentUnit.enemiesInRange.Remove(other.gameObject);
            print("Enemy lost: " + other.name);
        }

    }
}