using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    
    public Transform target;
    NavMeshAgent nav;
    private float timer = 0;
    [SerializeField]
    private float timertotal = 1;
    bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        TimerTool();
    }
    private void TimerTool()
    {
        if (timer > timertotal)
        {
            timer = 0;
            TimerContent();
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        started = true;
    }
    protected virtual void TimerContent()
    {
        if (started == true)
        {
            print("GO");
            nav.SetDestination(target.position);
        }
    }
}
