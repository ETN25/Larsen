using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavMesh : MonoBehaviour
{
    [SerializeField] NavMeshAgent Navigation;
    public Vector3 startPosition, newPosition;
    [SerializeField] float range = 10f;
    public float waitingTime, waiting;
    public bool Chasing = false;
    [SerializeField] Vector3[] Position = new Vector3[6];
    private int Selection;

    // Start is called before the first frame update
    void Start()
    {
        Selection = Random.Range(0, Position.Length);
        transform.position = Position[Selection];
        startPosition = transform.position;
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Chasing)
        {
            if (Mathf.Round(transform.position.x) >= Mathf.Round(newPosition.x) -1 && Mathf.Round(transform.position.x) <= Mathf.Round(newPosition.x) + 1 && Mathf.Round(transform.position.z) >= Mathf.Round(newPosition.z) -1 && Mathf.Round(transform.position.z) <= Mathf.Round(newPosition.z) + 1)
            {
                if (waiting >= waitingTime)
                {
                    Move();
                    waiting = 0;
                    Vector2 distance = new Vector2(newPosition.x - transform.position.x, newPosition.z - transform.position.z);
                    //Navigation.speed = distance.magnitude / 2;
                }
                waiting += 1 * Time.deltaTime;
            }
        }

        //Limits
        /*if (newPosition.z < -9 || newPosition.z > 9)
        {
            newPosition = new Vector3(startPosition.x + Random.Range(-range, range), startPosition.y, startPosition.z + Random.Range(-range, range));
        }
        if (newPosition.x < -13 || newPosition.x > 13)
        {
            newPosition = new Vector3(startPosition.x + Random.Range(-range, range), startPosition.y, startPosition.z + Random.Range(-range, range));
        }
        */

    }

    public void Move()
    {
        newPosition = new Vector3(startPosition.x + Random.Range(-range, range), startPosition.y, startPosition.z + Random.Range(-range, range));
        Navigation.destination = newPosition;
        waitingTime = Random.Range(0f, 5f);
        if (newPosition.z < 0)
        {
            newPosition.z = 0;
        }
        if (newPosition.z > 14)
        {
            newPosition.z = 14;
        }
        if (newPosition.x < 0)
        {
            newPosition.x = 0;
        }
        if (newPosition.x > 18)
        {
            newPosition.x = 18;
        }
    }

    public void Chase(Vector3 Position)
    {
        newPosition = Position;
        Navigation.destination = newPosition;
        Navigation.speed = 20f;
    }
}
