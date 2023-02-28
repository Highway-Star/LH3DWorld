using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour
{
    public CharacterController PlayerCollisionObject;
    public Transform Spawn;
    public Transform PlayerPos;
    Vector3 SpawnPos;

    public void Awake()
    {
        //Player = FindObjectOfType<PlayerCharacterLogic>().gameObject;
        PlayerCollisionObject.GetComponent<CharacterController>();
        //SpawnPos = new Vector3(Spawn.transform(x),);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == PlayerCollisionObject)
        {
            print("DEATH!");
            PlayerPos.position = Spawn.position;
        }
    }
}
