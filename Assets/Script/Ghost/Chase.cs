using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chase : MonoBehaviour
{
    public GameObject player, Shadow, screamer;
    public float AngerLevel, AngerLimit, waiting, waitingTime;
    public NavMesh NavMesh;
    public GhostManager GhostManager;
    float wait;

    [SerializeField] float distance;
    // Start is called before the first frame update
    void Start()
    {
        AngerLimit = Random.Range(100f, 500f);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);


        AngerLevel += 1 * Time.deltaTime;
        if (AngerLevel > AngerLimit)
        {
            Shadow.SetActive(true);
            NavMesh.Chasing = true;
            GhostManager.Chasing = true;
            GhostManager.Glitch();
            waiting += 1 * Time.deltaTime;
            if (waiting >= waitingTime)
            {
                if(Vector3.Distance(player.transform.position, transform.position) < 10f)
                {
                    NavMesh.Chase(player.transform.position);
                    if (Vector3.Distance(player.transform.position, transform.position) < 1f)
                    {
                        player.GetComponent<Movement>().speed = 0f;
                        screamer.SetActive(true);
                        print("tué");
                        
                        wait += 1 * Time.deltaTime;
                        if (wait > 1f)
                        {
                            Cursor.lockState = CursorLockMode.None;
                            SceneManager.LoadScene("Killed");
                        }
                        
                    }
                }
                else
                {
                    AngerLevel = 0f;
                    AngerLimit = Random.Range(100f, 500f);
                    NavMesh.Chasing = false;
                    GhostManager.Chasing = false;
                    Shadow.SetActive(false);
                    NavMesh.Move();
                }
            }
        }
    }
}
