using System;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class SpawnEntity : MonoBehaviour,IDeclareReferencedPrefabs, IConvertGameObjectToEntity
{
    public GameObject entityCube;
    public int rows, cols;
  

    public void DeclaredReferencePrefabs(List<GameObject> gameObjects)
    {
        gameObjects.Add(entityCube);
    }

    public void Convert(Entity entity, EntityManager entityManager, GameObjectConversionSystem conversionSystem)
    {
        var spawnData = new Spawner
        {
            prefab = conversionSystem.GetPrimaryEntity(entityCube),
            Erows = rows,
            Ecols = cols
        };
        entityManager.AddComponentData(entity, spawnData);
    }
}
