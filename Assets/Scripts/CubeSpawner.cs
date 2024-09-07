using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private CubeColorChanger _cubeColorChanger;

    public void Spawn(Cube cube, List<Cube> spawnedCubes)
    {
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
    }

    private Cube CreateCube(Cube cube)
    {
        Cube newCube = Instantiate(cube, cube.transform.position, cube.transform.rotation);

        newCube.Init(_cubeColorChanger.GetColor(), cube.ChanseSpawn);

        return newCube;
    }
}
