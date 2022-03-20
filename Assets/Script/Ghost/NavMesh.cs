using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavMesh : MonoBehaviour
{
    [SerializeField] NavMeshAgent Navigation;
    public Vector3 startPosition;
    [SerializeField] Vector3 newPosition;
    [SerializeField] float range = 10f;
    [SerializeField] float waitingTime;
    [SerializeField] float waiting;

    [SerializeField] Vector3[] Position = new Vector3[6];
    private int Selection;

    // Start is called before the first frame update
    void Start()
    {
        Selection = Random.Range(0, Position.Length);
        transform.position = Position[Selection];
        startPosition = transform.position;
        newPosition = new Vector3(startPosition.x + Random.Range(-range, range), startPosition.y, startPosition.z + Random.Range(-range, range));
        Navigation.destination = newPosition;
        waitingTime = Random.Range(0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Round(transform.position.x) <= Mathf.Round(newPosition.x) && Mathf.Round(transform.position.z) == Mathf.Round(newPosition.z))
        {
            if (waiting >= waitingTime)
            {
                newPosition = new Vector3(startPosition.x + Random.Range(-range, range), startPosition.y, startPosition.z + Random.Range(-range, range));
                Navigation.destination = newPosition;
                waitingTime = Random.Range(0f, 5f);
                waiting = 0;
                Vector2 distance = new Vector2(newPosition.x - transform.position.x, newPosition.z - transform.position.z);
                Navigation.speed = distance.magnitude / 2;
            }
            waiting += 1 * Time.deltaTime;
        }
        
    }
}
