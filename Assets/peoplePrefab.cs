using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class peoplePrefab : MonoBehaviour
{
    [SerializeField]
    private PeopleData info;
    private SetPeopleInfo setPlantinfo;

    private void Start()
    {
        setPlantinfo = GameObject.FindGameObjectWithTag("PeopleInfo").GetComponent<SetPeopleInfo>();
    }

    private void OnMouseDown()
    {
        setPlantinfo.OpenPeoplePanel();
        setPlantinfo.peopleName.text = info.Name;
        setPlantinfo.BioLevel.text = info.PeopleBio.ToString();
        setPlantinfo.peopleIcon.GetComponent<RawImage>().texture = info.Icon;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && info.PeopleBio == PeopleData.peopleBio.Enemy)
        {
            PlayerController.dead = true;
        }
    }
}
