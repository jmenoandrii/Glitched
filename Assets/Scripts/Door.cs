using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Stats stats;

    [SerializeField]
    private GameObject requestText;

    [SerializeField]
    private float requestKeys;

    [SerializeField]
    private AudioSource openDoorSound;
    [SerializeField]
    private AudioSource lockedDoorSound;

    private void Awake()
    {
        stats = GameObject.FindGameObjectWithTag("GameController").GetComponent<Stats>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && stats.Key >= requestKeys)
        {
            requestText.SetActive(false);
            stats.Key -= requestKeys;
            if (!GetComponent<Teleport>() && !GetComponent<TriggerObject>())
            {
                openDoorSound.Play();
                Destroy(gameObject);
            }
            else
            {
                GetComponent<Teleport>().Teleporting(other);
            }
            Destroy(this);
        }
        else
        {
            lockedDoorSound.Play();
            requestText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        requestText.SetActive(false);
    }
}
