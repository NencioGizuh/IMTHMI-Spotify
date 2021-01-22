using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneInformation : MonoBehaviour
{
    [SerializeField]
    public GameObject materiaal;
    [SerializeField]
    public Material material;

    [SerializeField]
    public void change() {
        materiaal.GetComponent<MeshRenderer> ().material = material;
    }
}
