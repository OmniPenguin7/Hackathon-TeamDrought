using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TeleporterScript : MonoBehaviour
{
    public InMemoryVariableStorage yarnInMemoryStorage;

    public GameObject player; //Sets a reference for the player

    public GameObject target; //Sets a reference for the target object

    [YarnCommand("teleport_player_sky")]

    public void TeleportPlayerOceanFloor() //Method for teleporting the player
    {
        player.transform.SetPositionAndRotation(target.transform.position, Quaternion.identity); //Teleports the player to the selected target position in the sky
    }




}
