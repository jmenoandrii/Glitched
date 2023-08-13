using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(AudioSource))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;
    [SerializeField]
    private float speed, speedRunning;
    [SerializeField]
    private float gravity = -30f;

    private Vector2 horizontalInput;
    private bool running;
    private Vector2 verticalVelocity = Vector3.zero;

    private Vector3 warpPosition = Vector3.zero;
    private Quaternion warpRotation;

    private AudioSource audio;

    [SerializeField]
    private List<AudioClip> footstepsClips;
    [SerializeField]
    private float delayWalk;
    [SerializeField]
    private float delayRun;
    private bool canPlayAudio = true;

    private GlitchEffect glitchEffect;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        audio = GetComponent<AudioSource>();
        glitchEffect = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<GlitchEffect>();
    }

    private void Update()
    {
        if (controller.isGrounded)
            verticalVelocity.y = 0;

        Vector3 horizontalVelocity = (transform.right * horizontalInput.x + transform.forward * horizontalInput.y) * (running ? speedRunning : speed);
        controller.Move(horizontalVelocity * Time.deltaTime);

        if (controller.isGrounded && controller.velocity.magnitude > 2f && !audio.isPlaying && canPlayAudio)
        {
            StartCoroutine(Footstep());
            canPlayAudio = false;
        }

        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
    }

    private void LateUpdate()
    {
        if (warpPosition != Vector3.zero)
        {
            controller.enabled = false;
            controller.transform.position = warpPosition;
            controller.enabled = true;
            controller.transform.rotation = warpRotation;
            warpPosition = Vector3.zero;
            glitchEffect.enabled = false;
        }
    }

    public void WarpToPosition(Vector3 newPosition, Quaternion newRotation)
    {
        warpPosition = newPosition;
        warpRotation = newRotation;
    }

    public void RecieveInput (Vector2 _horizontalInput, bool _running)
    {
        horizontalInput = _horizontalInput;
        running = _running;
    }

    private IEnumerator Footstep()
    {
        int numberRandomClip = Random.Range(0, footstepsClips.Count);

        audio.clip = footstepsClips[numberRandomClip];

        audio.volume = Random.Range(0.4f, 0.5f);
        audio.pitch = Random.Range(0.8f, 1.1f);
        audio.Play();

        yield return new WaitForSeconds(running ? delayRun : delayWalk);

        canPlayAudio = true;
    }
}
