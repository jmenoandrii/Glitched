using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Stats))]
public class Jail : MonoBehaviour
{
    private Stats stats;
    private PlayerMovement playerMovement;
    private PlayerInput playerInput;

    [SerializeField]
    private List<Transform> jails;

    [SerializeField]
    private AudioSource dieSound;

    [SerializeField]
    private Enemy enemyFirstFloor;

    private bool scared = false;

    private void Awake()
    {
        stats = GetComponent<Stats>();
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        playerInput = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerInput>();
    }

    private void LateUpdate()
    {
        if (scared)
        {
            playerInput.Unscared();
            scared = false;
        }
    }

    public void GoInJail()
    {
        dieSound.Play();

        stats.Health -= 1;
        stats.Stamina += 50;

        switch (stats.Health)
        {
            case 1:
                playerMovement.WarpToPosition(jails[0].position, jails[0].rotation);
                break;
            case 2:
                playerMovement.WarpToPosition(jails[1].position, jails[1].rotation);
                break;
        }
        scared = true;

        enemyFirstFloor.SetPosition(1);
    }

}