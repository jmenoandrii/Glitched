using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private Transform outputPosition;
    [SerializeField]
    private AudioSource openDoorSound;
    private PlayerInput playerInput;

    private bool scared = false;

    private void Awake()
    {
        playerInput = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerInput>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !GetComponent<Door>())
        {
            Teleporting(other);
        }
    }
    private void LateUpdate()
    {
        if (scared)
        {
            playerInput.Unscared();
            scared = false;
        }
    }

    public void Teleporting(Collider other)
    {
        scared = true;
        openDoorSound.Play();
        other.GetComponent<PlayerMovement>().WarpToPosition(outputPosition.position, outputPosition.rotation);
    }
}
