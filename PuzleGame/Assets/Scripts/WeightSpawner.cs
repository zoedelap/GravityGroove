using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightSpawner : MonoBehaviour
{
    [SerializeField] private GameObject weightPrefab;

    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
        if (Input.GetMouseButtonDown(0)) dropWeight();
    }

    void dropWeight()
    {
        print("dropping weight");
        GameObject weight = Instantiate<GameObject>(weightPrefab);
        weight.transform.position = transform.position;
    }
}
