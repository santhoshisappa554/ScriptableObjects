using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

public class SpawnerSystem : JobComponentSystem
{
    EndSimulationEntityCommandBufferSystem m_EntityCommandBufferSystem;

    protected override void OnCreateManager()
    {
        m_EntityCommandBufferSystem = World.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
    }
   
    struct SpawnJob: IJobProcessComponentDateWithEntity<Spawner, LocalToWorld>
    {
       
    }
}
