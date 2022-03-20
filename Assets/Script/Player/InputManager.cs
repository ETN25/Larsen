using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Movement movementScript;
    [SerializeField] MouseLook mouseLook;
    [SerializeField] Lamp lamp;

    PlayerController controls;
    PlayerController.MovementActions movement;
    PlayerController.ActionActions action;

    Vector2 horizontalInput;
    Vector2 mouseInput;

    private void Awake()
    {
        controls = new PlayerController();
        movement = controls.Movement;
        action = controls.Action;

        movement.HorizontalMovement.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();

        movement.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        movement.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();

        action.Light.performed += ctx => lamp.OnOff();
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }

    void Update()
    {
        movementScript.ReceiveInput(horizontalInput);
        mouseLook.ReceiveInput(mouseInput);
    }
}
