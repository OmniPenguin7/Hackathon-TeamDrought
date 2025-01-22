using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForPirateGame : MonoBehaviour
{

    public YarnCommands yarnCommands;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PirateGameActivate")
        {
            yarnCommands.PirateGame();
        }
    }
}
