using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed;
    private Vector3 startPoint;
    private GameObject obj;
    public float sceneLength;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        startPoint = obj.transform.position;
        sceneLength = 20.5f;
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3((transform.position.x - 1), transform.position.y, 0); // deltaTime is time between frames
        obj.transform.Translate(new Vector3(-Time.deltaTime* speed, 0, 0));

        if(Vector3.Distance(startPoint, obj.transform.position) > sceneLength)
        {
            obj.transform.position = startPoint;
        }
    }
}
