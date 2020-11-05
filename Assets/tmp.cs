using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tmp : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    Vector3 targetPos;
    public GameObject cube;
    public float rotSpeed = 2.0f;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            targetPos = hit.point;
        }

        Vector3 dir = new Vector3(targetPos.x - cube.transform.position.x, 0, targetPos.z - cube.transform.position.z);//направление поворота
        Quaternion quaternion = Quaternion.LookRotation(dir);//задаем поворот


        if(Input.GetKey(KeyCode.Mouse0))
        {
            cube.transform.rotation = Quaternion.Lerp(cube.transform.rotation, quaternion, rotSpeed * Time.deltaTime);
        }
    }
}
