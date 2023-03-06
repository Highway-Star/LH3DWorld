using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reveal : MonoBehaviour
{
    public GameObject revealObject;
    bool isRevealed = false;

    private void OnTriggerEnter(Collider other)
    {
        if(isRevealed == false)
        {
            revealObject.SetActive(true);
            isRevealed = true;
        }
    }
}
