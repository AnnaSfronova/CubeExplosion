using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    private List<Color> _colors;

    private void Start()
    {
        FillColors();
    }

    public List<Cube> Spawn(Cube cube)
    {
        List<Cube> spawnedCubes = new();

        int minChaceSpawn = 0;
        int maxChaceSpawn = 100;

        if (Random.Range(minChaceSpawn, maxChaceSpawn + 1) <= cube.ChanseSpawn)
        {
            int minCubes = 2;
            int maxCubes = 6;
            int countCubes = Random.Range(minCubes, maxCubes + 1);

            for (int i = 0; i < countCubes; i++)
            {
                spawnedCubes.Add(CreateCube(cube));
            }
        }

        return spawnedCubes;
    }

    private Cube CreateCube(Cube cube)
    {
        Cube newCube = Instantiate(cube, cube.transform.position, cube.transform.rotation);

        newCube.Init(GetColor(), cube.ChanseSpawn);

        return newCube;
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

    private Color GetColor()
    {
        return _colors[Random.Range(0, _colors.Count)];
    }
}
