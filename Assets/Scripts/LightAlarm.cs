using System.Collections;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LightAlarm : MonoBehaviour
{
    [SerializeField] private Tilemap _alarmLight;

    private bool _alarmEnabled = false;

    private void OnEnable()
    {
        SecurityAlarm.DangerOn += AlarmStart;
        SecurityAlarm.DangerOff += AlarmStop;
    }

    private void OnDisable()
    {
        SecurityAlarm.DangerOn -= AlarmStart;
        SecurityAlarm.DangerOff -= AlarmStop;
    }

    private void AlarmStart()
    {
        _alarmEnabled = true;
        AlarmPlay();
    }

    private void AlarmStop()
    {
        _alarmEnabled = false;
    }


    private void AlarmPlay()
    {
        if(_alarmEnabled)
        {
            StartCoroutine(wait());
        }
    }

    IEnumerator wait()
    {
        while (_alarmEnabled)
        {
            _alarmLight.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.5f);

            _alarmLight.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
