using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadious = 10f; //this is the whole area the enemy has to detect the player

    public bool musicplay = false; /*this is a very important variable, it's the whole reason the NPC will know if the music
    is played or not*/

    Transform target; //this is the variable where our player prefab will be assigned.
    NavMeshAgent agent; //this is the variable where the navmesh agent will be assigned.

    // Start is called before the first frame update
    void Start()
    {
        /* DECLARING OUR PREVIOUS TRANSFORM AND NAVMESHAGENT VARIABLES */
        target = PlayerManager.instance.player.transform; /*this is where it's getting our player to make the AI detect
        the player prefab, note that "transform" here is for refering the player's position later. */

        agent = GetComponent<NavMeshAgent>(); //again, this is to detect the navmesh agent of the NPC.
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position); /*this variable is getting the player's postion,
        through "target.position", and "transform.position" is needed to see if the player is moving or not*/

        if (Input.GetKeyDown(KeyCode.F)) //this is where our variable becomes true
        {
            musicplay = true; //needed to make the following conditional work
        }

        if (distance <= lookRadious && musicplay == true) /*THIS IS NEEDED BECAUSE "distance <= lookRadious" IS BASICALLY SAYING
            IF THE PLAYER IS INSIDE THE BOUND*/
        {
            agent.isStopped = false; //required to make the NPC move
            agent.SetDestination(target.position); //THIS IS ALSO IMPORTAN BECAUSE IT WILL GO TO WHEREVER THE PLAYER IS AT.

            if (Input.GetKeyUp(KeyCode.F)) //in case the F key get's released
            {
                musicplay = false; //to stop the whole process
            }
        }
        else
        {
            agent.isStopped = true; //THIS STOPS THE NPC
            if (Input.GetKeyUp(KeyCode.F))
            {
                musicplay = false;
            }
        }
        
    }

    private void OnDrawGizmosSelected() //this whole thing is just for the editor only.
    {
        Gizmos.color = Color.red; //this will make the wire red, can be changed of color, it won't affect the AI.
        Gizmos.DrawWireSphere(transform.position, lookRadious); //this is where it draws the bound in the engine once selected.
    }
}
