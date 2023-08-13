using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    [SerializeField]
    private bool offFlashlight;
    [SerializeField]
    private bool destroyTrigger;
    [SerializeField]
    private bool noNeedOpenDoor;

    [SerializeField]
    private List<GameObject> triggerObjects;
    [SerializeField]
    private bool stateTriggetObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!GetComponent<Door>() || noNeedOpenDoor)
            {
                if (offFlashlight)
                {
                    GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerInput>().SwitchFlashlight();
                }

                foreach (GameObject triggerObject in triggerObjects)
                    triggerObject.SetActive(stateTriggetObject);

                if (destroyTrigger)
                    Destroy(this);
            }
        }
    }
}
