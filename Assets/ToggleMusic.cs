using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleMusic : MonoBehaviour
{
    public Toggle toggle;
    public AudioSource audioSource;

    private void Awake()
    {
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

    private void OnToggleValueChanged(bool isOn)
    {
        if (isOn)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
}
