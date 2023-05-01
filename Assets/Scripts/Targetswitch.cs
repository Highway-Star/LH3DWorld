using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetswitch : MonoBehaviour
{
    public Target Boat;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Boat.TSwitch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
