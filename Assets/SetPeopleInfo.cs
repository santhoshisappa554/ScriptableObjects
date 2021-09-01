using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPeopleInfo : MonoBehaviour
{
    public GameObject peopleInfoPanel;
    public GameObject peopleIcon;
    public Text peopleName;
    public Text BioLevel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenPeoplePanel()
    {
        peopleInfoPanel.SetActive(true);
    }

    public void ClosePeoplePanel()
    {
        peopleInfoPanel.SetActive(false);
    }
}
