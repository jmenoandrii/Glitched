using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObject : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    private void Awake()
    {
        FindPlayer();
    }

    private void FindPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (player)
        {
            if (Vector3.Distance(transform.position, player.position) < 25)
            {
                Vector3 targetPosition = new Vector3(player.position.x, transform.position.y, player.position.z);
                transform.LookAt(targetPosition);
            }
        }
        else
        {
            FindPlayer();
        }
    }
}
