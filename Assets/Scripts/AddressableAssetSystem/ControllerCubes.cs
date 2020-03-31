using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class ControllerCubes : MonoBehaviour
{
    [SerializeField] private Button instantiateCubeButtton;

    [SerializeField] private Button destroyCubeButton;

    [SerializeField] private Button destroyAllCubeButton;

    private List<GameObject> cubes = new List<GameObject>(); 

    private void Awake()
    {
        instantiateCubeButtton.onClick.AddListener(InstantiateCube);
        destroyCubeButton.onClick.AddListener(DestroyCube);
        destroyAllCubeButton.onClick.AddListener(DestroyAllCube);
    }

    private void InstantiateCube()
    {
        var position = cubes.Count * 1.25f * Vector3.forward;
        Addressables.InstantiateAsync("Cube", position, Quaternion.identity).Completed += handle =>
        {
            cubes.Add(handle.Result);
        };
    }
    private void DestroyCube()
    {
        if (cubes.Count<=0)
        {
            return;
        }

        var lastCube = cubes.Last();
        Addressables.ReleaseInstance(lastCube);
        cubes.Remove(lastCube);
    }


    private void DestroyAllCube()
    {
        foreach(var cube in cubes)
        {
            Addressables.ReleaseInstance(cube);
        }

        cubes.Clear();
    }

}
