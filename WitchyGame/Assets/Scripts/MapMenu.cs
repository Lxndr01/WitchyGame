using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapMenu : MonoBehaviour
{
    public RawImage map;
    private bool isMapEnabled;

    private void Awake()
    {
        isMapEnabled = false;
        map.enabled = false;
    }

    public void Update()
    {
        if (isMapEnabled != true)
        {
            isMapEnabled = !isMapEnabled;
            MapEnabling();
        }
    }

    public void MapEnabling()
    {
        map.enabled = isMapEnabled;
    }
}
