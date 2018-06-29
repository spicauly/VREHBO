using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMovement : MonoBehaviour
{

    public float speed;
    public Transform target;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }


    void Update()
    {
        Move();

        if (transform.position == target.position)
        {
            transform.position = startPosition;
        }

    }

    private void Move()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

}
