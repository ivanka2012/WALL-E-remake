using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //DO NOT DELETE THIS REGION NOR THE ENDREGION
    #region Singleton 

    public static PlayerManager instance; // we're declaring a variable on here, it's nothing whatsoever for the static type, again you need it public so it will be detected by other classes

    void Awake() //this is where we will declare our variable
    {
        instance = this; //it's refering to all the content in this script
    }

    #endregion

    public GameObject player; /* this is the most important thing on the whole script, it's where our EnemyControlloer.cs
    will get the player's prefab detected so it will count as the target variable(see the script for any reference).
    keep in mind you need to assign the player prefab*/
}
