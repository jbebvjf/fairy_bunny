using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    [SerializeField] private GameObject settings;

    public void Exit()
    {
        settings.SetActive(false);
    }

    public void entrance()
    {
        settings.SetActive(true);
    }
}
