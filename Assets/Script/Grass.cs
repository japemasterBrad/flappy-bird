using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    public float speed;
    private Vector3 startPoint;
    private GameObject obj;
    public float objSize;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        startPoint = obj.transform.position;
        objSize = 4;
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-Time.deltaTime * speed, 0, 0));

        if (Vector3.Distance(startPoint, obj.transform.position) > objSize)
        {
            obj.transform.position = startPoint;
        }
    }
}
