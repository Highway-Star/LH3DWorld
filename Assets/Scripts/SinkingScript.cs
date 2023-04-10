using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkingScript : MonoBehaviour
{
    public CharacterController PlayerCollisionObject;
    public float sinkSpeed = -0.5f;
    float startY;
    bool sinking = false;
    // Start is called before the first frame update
    void Awake()
    {
        PlayerCollisionObject.GetComponent<CharacterController>();
        startY = transform.position.y;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == PlayerCollisionObject)
        {
            sinking = true;
        }
        else
        {
            sinking = false;
        }
    }
    public void Update()
    {
        if (sinking)
        {
            //this.transform.Translate(0, sinkSpeed, 0);
        }
    }
}
