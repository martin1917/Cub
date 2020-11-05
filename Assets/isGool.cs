using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class isGool : MonoBehaviour
{
    public GameObject sphere;
    public Text info;
    Vector3 start_pos;
    float dis1, dis2, count = 0;
    void Start()
    {
        start_pos = sphere.transform.position;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 curr_pos = sphere.transform.position;
            dis1 = Vector3.Distance(curr_pos, start_pos);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 curr_pos = sphere.transform.position;
            dis2 = Vector3.Distance(curr_pos, start_pos);

            if (dis2 > dis1)
            {
                count += 1;
                info.text = "Score: " + count.ToString();
            }
        }
    }
}
