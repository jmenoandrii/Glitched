using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBigDoor : Key
{
    [SerializeField]
    private BigDoor.KeyColor keyColor;

    [SerializeField]
    private AudioSource getKeyAudio;

    public override void Get()
    {
        getKeyAudio.Play();
        BigDoor.singleton.OpenLock(keyColor);
        Destroy(gameObject);
    }
}
