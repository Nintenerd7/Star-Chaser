using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyStarNormal : MonoBehaviour
{
    public Transform tr;
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
            AudioSourceController.Instance.PlaySFX("Twinkle");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
