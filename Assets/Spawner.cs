using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject dropWater;
    private Camera mainCamera;
    private float coolDowmn = 0;
    public Material material;
   
    private void Start()
    {
        material.color = Color.red;
        mainCamera = Camera.main;
    }
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            coolDowmn -= Time.deltaTime;
            while(coolDowmn < 0)
            {
                coolDowmn += 0.01f;
                Instantiate(dropWater, (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition) + Random.insideUnitCircle * .2f, Quaternion.identity);
            }
        }
    }
}
