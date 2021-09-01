using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlantPrefabs : MonoBehaviour
{
    [SerializeField]
    private PlantData info;
    private SetPlantInfo setPlantinfo;

    private void Start()
    {
        setPlantinfo = GameObject.FindGameObjectWithTag("PlantInfo").GetComponent<SetPlantInfo>();
    }

    private void OnMouseDown()
    {
        setPlantinfo.OpenPlantPanel();
        setPlantinfo.plantName.text = info.Name;
        setPlantinfo.threatLevel.text = info.PlantThreat.ToString();
        setPlantinfo.plantIcon.GetComponent<RawImage>().texture = info.Icon;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && info.PlantThreat == PlantData.THREAT.High)
        {
            PlayerController.dead = true;
        }
    }
}
