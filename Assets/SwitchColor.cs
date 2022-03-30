using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchColor : MonoBehaviour
{
    [SerializeField] private Color color;
    [SerializeField] private Spawner spawner;
    public void SwitchColorButton()
    {
        spawner.material.color = color;
    }
}
