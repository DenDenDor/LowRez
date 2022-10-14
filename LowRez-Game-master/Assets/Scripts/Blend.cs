using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Blend : MonoBehaviour
{
    [SerializeField] private GameObject _blendedPrefab;
    private List<Movement> _movements = new List<Movement>();
    private void Awake() 
    {
        _movements = FindObjectsOfType<Movement>().ToList();
    }
    public void BlendObjects()
    {
        Instantiate(_blendedPrefab,_movements.FirstOrDefault().transform.position,_movements.FirstOrDefault().transform.rotation);
        _movements.Select(e=>e.gameObject).ToList().ForEach(e=>e.SetActive(!e.activeSelf));
    }
}
