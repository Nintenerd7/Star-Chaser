using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyStar : MonoBehaviour
{
    public Transform tr;
    public GameObject Explosion;
    // Start is called before the first frame update
    void Start()
    {
        float X = Random.Range(-6, 6);
        tr.position = new Vector2(X, 8f);//position of falling
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
