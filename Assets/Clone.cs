using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    public GameObject GameOjectYouWantToClone;

    [SerializeField]
    public void onClone() {
        GameObject CloneOfGameOject = Instantiate(GameOjectYouWantToClone);
        CloneOfGameOject.transform.position = new Vector3(transform.position.x, transform.position.y , transform.position.z);
        Vector3 p = transform.position;
    }
}
