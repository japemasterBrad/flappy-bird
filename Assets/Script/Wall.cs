using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float speed;
    private Vector3 startPoint;
    private GameObject obj;
    public GameObject newObj;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        startPoint = obj.transform.position;
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-Time.deltaTime * speed, 0, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       obj.transform.position = new Vector3(10, Random.Range(-1, 2), 0);
    }
}
