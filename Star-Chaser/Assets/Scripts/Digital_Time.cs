using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Digital_Time : MonoBehaviour
{
    public TMP_Text Clock_Text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateClock());
    }

    IEnumerator UpdateClock()
    {
        while (true)
        {
            System.DateTime now = System.DateTime.Now;
            Clock_Text.text = now.ToString("HH:mm tt");
            yield return new WaitForSeconds(1);

        }
    }
}
