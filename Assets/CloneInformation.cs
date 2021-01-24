using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneInformation : MonoBehaviour
{
    [SerializeField]
    public GameObject materiaal;

    [SerializeField]
    public GameObject player;

    [SerializeField]
    public void change() {
        Debug.Log(materiaal.transform.GetChild(1).transform.GetChild(0).transform.GetChild(4).transform.GetChild(0).GetComponent<MeshRenderer> ().material);
        player.GetComponent<MeshRenderer> ().material = materiaal.transform.GetChild(1).transform.GetChild(0).transform.GetChild(4).transform.GetChild(0).GetComponent<MeshRenderer> ().material;
    }
}
