using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "People data", menuName = "PeopleData", order = 50)]
public class PeopleData : ScriptableObject
{
    public enum peopleBio { None, Human, Enemy }
    [SerializeField]
    private string peopleName;
    [SerializeField]
    private peopleBio peoplebio;
    [SerializeField]
    private Texture icon;


    public string Name { get { return peopleName; } }
    public peopleBio PeopleBio { get { return peoplebio; } }
    public Texture Icon { get { return icon; } }
}
