using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonExample : MonoBehaviour
{

    public static SingletonExample instance;


    private void Awake()
    {
        if (instance != null && instance == this)
        {
            Destroy(this);
        }
        else 
        {
            instance = this;          
        }

        //DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
