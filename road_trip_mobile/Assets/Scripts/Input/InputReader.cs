using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;

[CreateAssetMenu(fileName = "InputReader", menuName = "Game/Input Reader")]
public class InputReader : ScriptableObject, TestInput.IGameActions
{

    private TestInput testInput;

    private void OnEnable()
    {
        if (testInput == null)
        {
            testInput = new TestInput();
            testInput.Game.SetCallbacks(this);
        }
    }
    private void OnDisable()
    {
        DisableAllInput();
    }

    public void OnStart(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            Debug.Log("start");
        }
    }

    public void EnableMenuInput()
    {
        testInput.Game.Enable();
    }

    public void DisableAllInput()
    {
        testInput.Game.Disable();
    }
}
