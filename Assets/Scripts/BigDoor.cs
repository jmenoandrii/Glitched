using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDoor : MonoBehaviour
{
    public enum KeyColor
    {
        Green,
        Blue,
        Red,
        White
    }

    [SerializeField]
    private List<Lock> locks;

    [SerializeField]
    private AudioSource openDoorAudio;
    [SerializeField]
    private AudioSource lockedDoorAudio;
    [SerializeField]
    private GameObject openDoor;

    public static BigDoor singleton;

    private void Awake()
    {
        singleton = this;
    }

    public void OpenLock(KeyColor key)
    {
        locks[(int)key].Open();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bool allOpen = true;
            foreach (Lock lockObj in locks)
            {
                if (!lockObj.open) {
                    allOpen = false;
                }
            }

            if (allOpen)
            {
                openDoor.SetActive(true);
                openDoorAudio.Play();
                EndGame.singleton.Win();
                Destroy(gameObject);
            }
            else
            {
                lockedDoorAudio.Play();
            }
        }
    }
}

[System.Serializable]
public class Lock
{
    public GameObject closeLock;
    public GameObject openLock;

    public bool open;

    public void Open()
    {
        openLock.SetActive(true);
        closeLock.SetActive(false);
        open = true;
    }
}