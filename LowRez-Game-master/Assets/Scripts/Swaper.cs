using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using System;
public class Swaper : MonoBehaviour
{
    private PlayerActions _playerInput;
    private List<Movement> _movements= new List<Movement>();
    private List<CinemachineVirtualCamera> _virtualCamers = new List<CinemachineVirtualCamera>();
    private bool _canSwap;
    private void Awake() 
    {
        _playerInput = new();
        _playerInput.PlayerInput.Swap.started += OnSwap;
        _playerInput.PlayerInput.Swap.canceled += OnSwap;
        _movements = FindObjectsOfType<Movement>().ToList();
        _virtualCamers = FindObjectsOfType<CinemachineVirtualCamera>().ToList();
    }

    private void OnSwap(InputAction.CallbackContext context)
    {
        _canSwap = context.ReadValueAsButton();
        if(_canSwap)
        {
            Swap();
        }
    }


    private void Swap()
    {
        _movements.ForEach(e=>e.ReassignBooleans());
        _virtualCamers.ForEach(e=>e.ReassignBooleans());
        _canSwap = false;
    }

    private void OnEnable()
    {
        _playerInput.PlayerInput.Enable();    
    }

    private void OnDisable() 
    {
        _playerInput.PlayerInput.Disable();    
    }
}
