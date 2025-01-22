using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForCrabGame : MonoBehaviour
{
    public YarnCommands yarnCommands;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CrabGameActivate")
        {
            yarnCommands.CrabGame();
        }
    }


}
