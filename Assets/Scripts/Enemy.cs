using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private NavMeshAgent agent;
    private Jail jail; 
    private PlayerInput playerInput;

    [SerializeField]
    private List<Transform> homePositions;

    [SerializeField]
    private float waitTime;

    [SerializeField]
    private int numberHomePos = 0;
    [SerializeField]
    private bool inHome = false;

    [SerializeField]
    private float radiusFieldView;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        jail = GameObject.FindGameObjectWithTag("GameController").GetComponent<Jail>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerInput = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerInput>();
    }

    private void Update()
    {
        Vector3 targetPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
        transform.LookAt(targetPosition);

        Vector3 position;

        if (Vector3.Distance(transform.position, player.position) <= radiusFieldView)
        {
            position = player.position;
            if (Vector3.Distance(transform.position, player.position) <= radiusFieldView / 1.5)
            {
                playerInput.Scared();
            }
            else
            {
                playerInput.Unscared();
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, homePositions[numberHomePos].position) <= 2 && !inHome)
            {
                inHome = true;
                StartCoroutine(Wait());
            }
            position = homePositions[numberHomePos].position;
        }
        agent.SetDestination(position);
    }

    private int RandomHomePos()
    {
        int a = Random.Range(0, homePositions.Count);

        return (numberHomePos == a ? RandomHomePos() : a);
    }

    public void SetPosition(int id)
    {
        numberHomePos = id;
        inHome = false;
        StopCoroutine(Wait());
        agent.SetDestination(homePositions[numberHomePos].position);
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        numberHomePos = RandomHomePos();
        inHome = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jail.GoInJail();
        }
    }
}
