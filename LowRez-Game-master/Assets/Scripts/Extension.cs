using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extension 
{
    public static void ReassignBooleans<T>(this T item) where T : MonoBehaviour
    {
        item.enabled =! item.enabled;
    }
}
