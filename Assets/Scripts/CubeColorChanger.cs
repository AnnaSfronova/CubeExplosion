using System.Collections.Generic;
using UnityEngine;

public class CubeColorChanger : MonoBehaviour
{
    private List<Color> _colors;

    private void Start()
    {
        FillColors();
    }

    public Color GetColor()
    {
        return _colors[Random.Range(0, _colors.Count)];
    }

    private void FillColors()
    {
        _colors = new()
        {
            new Color32(201,203,163,255),
            new Color32(255,225,168,255),
            new Color32(226,109,92,255)
        };
    }
}
