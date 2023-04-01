using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] private GameObject[] points;
    [SerializeField] private float speed = 2f;

    SpriteRenderer sr;

    private int index = 0;

   

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");

        if (Vector2.Distance(points[index].transform.position,transform.position) < .1f) {
            index++;
            if(index >= points.Length)
            {
                index = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, points[index].transform.position, Time.deltaTime * speed);

        sr.flipX = movement < 0 ? true : false; 
    }
}
