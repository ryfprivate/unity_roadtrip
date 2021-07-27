using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenuManager : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader = default;

    private void Start()
    {
        _inputReader.EnableMenuInput();
    }
}
