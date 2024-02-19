using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    [SerializeField] private GameObject scene;
    [SerializeField] private GameObject scene1;

    public void changescene()
    {
        scene.SetActive(false);
        scene1.SetActive(true);
    }


}
