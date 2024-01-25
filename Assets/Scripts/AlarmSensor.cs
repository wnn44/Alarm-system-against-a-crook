using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmSensor : MonoBehaviour
{
    [SerializeField] private GameObject _thief;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _thief.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision) 
    {
        _thief.SetActive(true); 
    }
}
