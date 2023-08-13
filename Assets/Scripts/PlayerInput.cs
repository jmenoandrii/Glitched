using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Stats))] 
public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private GameObject flashlight;

    private Stats stats;

    private PlayerMovement movement;
    private MouseLook mouse;

    public PlayerControls controls;
    private PlayerControls.GroundMovementActions groundMovement;

    private Vector2 horizontalInput;
    private Vector2 mouseInput;
    [SerializeField]
    private bool running;

    [SerializeField]
    private AudioSource switchFlashlight;

    [SerializeField]
    private GlitchEffect glitchEffect;
    [SerializeField]
    private AudioSource heartbeat;

    private void Awake()
    {
        movement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        mouse = GameObject.FindGameObjectWithTag("Player").GetComponent<MouseLook>();
        stats = GetComponent<Stats>();

        controls = new PlayerControls();
        controls.Enable();
        groundMovement = controls.GroundMovement;

        groundMovement.Horizontal.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();


        groundMovement.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        groundMovement.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();

        groundMovement.Run.performed += ctx => ChangeRunning(true);
        groundMovement.Run.canceled += ctx => ChangeRunning(false);

        controls.Flashlights.Switch.performed += ctx => SwitchFlashlight();
    }

    public void Unscared()
    {
        glitchEffect.enabled = false;
        heartbeat.enabled = false;
    }

    public void Scared()
    {
        glitchEffect.enabled = true;
        heartbeat.enabled = true;
    }

    private void Update()
    {
        CheckRunning();

        movement.RecieveInput(horizontalInput, running);
        mouse.RecieveInput(mouseInput);

        //if (flashlight.activeSelf)
            //stats.Battery -= 1 * Time.deltaTime;

        if (running)
            stats.Stamina -= 3 * Time.deltaTime;
        else
            stats.Stamina += 1 * Time.deltaTime;

        if (stats.Battery <= 0)
        {
            switchFlashlight.Play();
            flashlight.SetActive(false);
        }
    }

    private void CheckRunning()
    {
        if (stats.Stamina <= 0)
            running = false;
    }

    private void ChangeRunning(bool value)
    {
        running = value;
        CheckRunning();
    }

    public void SwitchFlashlight()
    {
        switchFlashlight.Play();
        if (stats.Battery > 0)
            flashlight.SetActive(!flashlight.activeSelf);
        else
            flashlight.SetActive(false);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
