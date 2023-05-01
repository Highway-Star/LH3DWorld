using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    
    public Transform target1;
    public Transform target2;
    public Transform currTarget;
    NavMeshAgent nav;
    private float timer = 0;
    [SerializeField]
    private float timertotal = 1;
    public bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        currTarget = target1;
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
    public void TSwitch()
    {
        if(currTarget == target1)
        {
            currTarget = target2;
        }
        else { 
            currTarget = target1;
        }
    }
    protected virtual void TimerContent()
    {
        if (started == true)
        {
            print("GO");
            nav.SetDestination(currTarget.position);
        }
    }
}
