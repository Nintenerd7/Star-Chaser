using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Generator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] FallingObject;
    public float Timer = 2;
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
            Object_Randomizer();
            Timer = 0.7f;
        }
    }

   public void Object_Randomizer()
    {
        int Chance = Random.Range(1, 10);
        if (Chance <= 2)
        {
            Instantiate(FallingObject[0]);
        }
        else
        {
            Instantiate(FallingObject[1]);
        }
    }
}
