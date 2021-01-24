using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOrPause : MonoBehaviour
{
    [SerializeField]
    public GameObject materiaal;

    [SerializeField]
    public Material play;

    [SerializeField]
    public Material pause;

    public bool state = false;

    [SerializeField]
    public void changeLogo() {
        if(state == false) {
            state = true;
            materiaal.GetComponent<MeshRenderer> ().material = pause;
        }
        else if(state == true) {
            state = false;
            materiaal.GetComponent<MeshRenderer> ().material = play;
        }
    }
}
