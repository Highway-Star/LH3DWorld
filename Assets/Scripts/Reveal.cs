using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reveal : MonoBehaviour
{
    public GameObject[] revealObjects;
    public GameObject[] concealObjects;
    [SerializeField]
    RespawnController respawnController;
    public Transform checkPoint;

    bool isRevealed = false;

    private void OnTriggerEnter(Collider other)
    {
        if(isRevealed == false)
        {
            respawnController.Spawn = checkPoint;
            foreach(GameObject go in revealObjects)
            {
                go.SetActive(true);
            }
            foreach (GameObject co in concealObjects)
            {
                co.SetActive(false);
            } 
            //revealObject.SetActive(true);
            isRevealed = true;
        }
    }
}
