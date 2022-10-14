using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BlendChecker : MonoBehaviour
{
    public UnityEvent OnBlend;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.collider.GetComponent<Movement>())
        {
             OnBlend?.Invoke();
        }
    }
}
