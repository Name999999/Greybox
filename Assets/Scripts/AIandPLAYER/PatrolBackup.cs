using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class PatrolBackup : MonoBehaviour
{
    public Transform[] points;
    int x = 0;
    private NavMeshAgent agent;

    CharacterController characterController;

    [SerializeField] GameObject GameObject;

    void Start()
    {
        characterController = FindObjectOfType<CharacterController>();
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        GotoNextPoint();
    }

    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
        {
            return;
        }


        // Set the agent to go to the currently selected destination.

        agent.destination = points[x].position;
        x++;
        if (x >= points.Length)
        {
            x = 0;
        }
    }

    void Update()
    {

        float distance = Mathf.Sqrt(Mathf.Pow(gameObject.transform.position.x - characterController.transform.position.x, 2) + Mathf.Pow(gameObject.transform.position.y - characterController.transform.position.y, 2));
        print(distance);
        if (distance <= 6)
        {

            print("within vicinity");
            agent.destination = characterController.transform.position;
            return;
        }
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GotoNextPoint();
        }

        if (GameObject.activeInHierarchy == true)
        {
            print("light activated");
            agent.destination = characterController.transform.position;
            return;
        }
    }
}

