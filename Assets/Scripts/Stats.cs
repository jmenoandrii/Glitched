using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    [SerializeField]
    private float battery;
    [SerializeField]
    private float key;
    [SerializeField]
    private float stamina;
    [SerializeField]
    private float health = 3;

    [SerializeField]
    private Image staminaImage;
    [SerializeField]
    private Text keyText;

    [SerializeField]
    private GameObject livesAlert;
    private Animation livesAlertAnimation;
    private Text livesAlertText;

    [SerializeField]
    private AudioSource getKeyAudio;

    public static Stats singleton;

    private void Awake()
    {
        livesAlertAnimation = livesAlert.GetComponent<Animation>();
        livesAlertText = livesAlert.GetComponent<Text>();
        singleton = this;
    }

    public float Battery { 
        get => battery;
        set
        {
            battery = value;
            battery = Mathf.Clamp(battery, 0, 100);
        }
    }

    public float Key { 
        get => key;
        set
        {
            key = value;
            keyText.text = key.ToString();
            if (key < 0)
            {
                key = 0;
            }
        }
    }

    public float Stamina { 
        get => stamina;
        set
        {
            stamina = value;
            stamina = Mathf.Clamp(stamina, 0, 100);
            staminaImage.fillAmount = stamina / 100;
        }
    }

    public float Health { 
        get => health;
        set
        {
            health = value;
            livesAlertText.text = health.ToString() + " lives left";
            livesAlert.SetActive(true);
            livesAlertAnimation.Play();
            if (health <= 0)
            {
                EndGame.singleton.Lose();
            }
        }
    }

    public void GetKey(int value)
    {
        getKeyAudio.Play();
        Key += value;
    }
}
