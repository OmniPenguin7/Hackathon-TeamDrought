using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class YarnCommands : MonoBehaviour
{

    public InMemoryVariableStorage yarnInMemoryStorage;
    public GameObject player;

    [Header ("CrabGame")]
    public GameObject crabGameTeleport;
    public AudioSource crabGameIntro;
    public AudioSource crabGameMusic;

    [Header ("PirateGame")]
    public GameObject pirateGameTeleport;
    public AudioSource pirateGameIntro;
    public AudioSource pirateGameMusic;

    [Header ("PirateLittering")]
    public AudioSource pirateLittering;
    public Animation pirateLitteringAnimation;

    [Header ("EndGame")]
    public AudioSource endGameSound;
    public AudioSource endGameMusic;


    [Header ("Starfish")]
    public GameObject starfish;

    [YarnCommand("start_pirate_game")]

    public void PirateGame()
    {
        player.transform.SetPositionAndRotation(pirateGameTeleport.transform.position, Quaternion.identity);
    }

    [YarnCommand("start_crab_game")]

    public void CrabGame()
    {
        player.transform.SetPositionAndRotation(crabGameTeleport.transform.position, Quaternion.identity);
    }

    [YarnCommand ("end_game")]

    public void EndGame()
    {

    }

    [YarnCommand ("play_pirate_littering_animation")]

    public void PirateLittering()
    {
        //Play Animation for litter
        //Play Animation for pirate shaking head
        //Play Audio from pirate littering
    }

    [YarnCommand ("starfish_appear")]

    public void StarfishAppear()
    {
        starfish.SetActive (true);
    }

}
