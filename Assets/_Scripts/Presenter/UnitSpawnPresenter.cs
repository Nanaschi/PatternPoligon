using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class UnitSpawnPresenter
{
    private UnitModel _unitModel;
    private UnitSpawnView _unitSpawnView;
    
    public UnitSpawnPresenter(UnitModel unitModel, UnitSpawnView unitSpawnView)
    {
        _unitModel = unitModel;
        _unitSpawnView = unitSpawnView;
    }

    public BaseUnitView FactoryMethod()
    {
        return _unitSpawnView.UnitPrefab;
    }

    public void SpawnTheUnit(Transform positionToSpawn)
    {
        var unit =  GameObject.Instantiate(FactoryMethod(), positionToSpawn);
    }

    public void AssignSpawnToPoints()
    {
        for (int i = 0; i < _unitSpawnView.SpawnPositions.Length; i++)
        {
            SpawnTheUnit(_unitSpawnView.SpawnPositions[i]);
        }
    }

    public void Start()
    {
        AssignSpawnToPoints();
    }

    
}
