using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour
{
    public CharacterController playerController;
    public Transform Spawn;
    //public Transform PlayerPos;
    Vector3 SpawnPos;

    public void Awake()
    {
        //Player = FindObjectOfType<PlayerCharacterLogic>().gameObject;
        playerController.GetComponent<CharacterController>();
        //SpawnPos = new Vector3(Spawn.transform(x),);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == playerController)
        {
            print("DEATH!");
            playerController.enabled = false;
            playerController.transform.position = Spawn.position;
            playerController.enabled = true;
        }
    }
}
