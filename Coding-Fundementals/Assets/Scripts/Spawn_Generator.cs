using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Generator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] FallingObject;
    public float Timer = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        else
        {
            Instantiate(FallingObject[0]);
            Timer = 0.7f;
        }
    }


}
