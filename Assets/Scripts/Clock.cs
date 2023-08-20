using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private Transform _hoursPivot;
    [SerializeField] private Transform _minutesPivot;
    [SerializeField] private Transform _secondsPivot;

    private const float _hoursToDegrees = -30.0f;
    private const float _minutesToDegrees = -6.0f;
    private const float _secondsToDegrees = -6.0f;


    private void Update()
    {
        RotateClockArms();
    }

    private void RotateClockArms()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        _hoursPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, _hoursToDegrees * (float)time.TotalHours);
        _minutesPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, _minutesToDegrees * (float)time.TotalMinutes);
        _secondsPivot.localRotation = Quaternion.Euler(0.0f, 0.0f, _secondsToDegrees * (float)time.TotalSeconds);
    }
}
