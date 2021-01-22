using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Lijst : MonoBehaviour
{
    [SerializeField]
    public List<Material> ClassicList;

    [SerializeField]
    public List<Material> IndieCrushList;

    [SerializeField]
    public List<Material> EDMList;

    [SerializeField]
    public GameObject materiaal;

    [SerializeField]
    public GameObject afbeelding;

    [SerializeField]
    public GameObject titel;

    [SerializeField]
    public GameObject artiest;

    [SerializeField]
    public int counter = 0;

    [SerializeField]
    public string playlist = "";

    public string Playlist { get => playlist; set => playlist = value; }

    public int Add() {
        if(counter == 5) {
            counter = 0;
            return counter;
        }
        else {
            return counter++;
        }
    }

    public int Min() {
        if(counter == -1) {
            counter = 4;
            return counter;
        }
        else {
            return counter--;
        }
    }
    
    [SerializeField]
    public void Forward() {
        Add();
        switch(playlist) {
            case "classic": {
                switch(counter) {
                case 0:
                materiaal.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                titel.GetComponent<TextMeshPro> ().text = "The Blue Danube";
                artiest.GetComponent<TextMeshPro> ().text = "Johan Straus II";
                break;
                case 1:
                materiaal.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Canon in D";
                artiest.GetComponent<TextMeshPro> ().text = "Kanon Orchestre de Chambre";
                break;
                case 2:
                materiaal.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Once Upon a December";
                artiest.GetComponent<TextMeshPro> ().text = "Emile Pandolfi";
                break;
                case 3:
                materiaal.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                titel.GetComponent<TextMeshPro> ().text = "The Four Seasons";
                artiest.GetComponent<TextMeshPro> ().text = "Salzburg Chamber Orchestra";
                break;
                case 4:
                materiaal.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Corpse Bride";
                artiest.GetComponent<TextMeshPro> ().text = "Uriel";
                break;
                }
            }
            break;
            case "indiecrush": {
            switch(counter) {
                case 0:
                materiaal.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Run";
                artiest.GetComponent<TextMeshPro> ().text = "Joji & Diplo";
                break;
                case 1:
                materiaal.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Two queens";
                artiest.GetComponent<TextMeshPro> ().text = "Girl in Red";
                break;
                case 2:
                materiaal.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                titel.GetComponent<TextMeshPro> ().text = "I am used to it";
                artiest.GetComponent<TextMeshPro> ().text = "Powfu";
                break;
                case 3:
                materiaal.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Keep it Gold";
                artiest.GetComponent<TextMeshPro> ().text = "Surfaces";
                break;
                case 4:
                materiaal.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Distance";
                artiest.GetComponent<TextMeshPro> ().text = "Ruel";
                break;
            }
            break;
            }
            case "edm": {
                switch(counter) {
                case 0:
                materiaal.GetComponent<MeshRenderer> ().material = EDMList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = EDMList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Slow Lane";
                artiest.GetComponent<TextMeshPro> ().text = "Armin van Buuren";
                break;
                case 1:
                materiaal.GetComponent<MeshRenderer> ().material = EDMList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = EDMList[counter];
                titel.GetComponent<TextMeshPro> ().text = "The Business";
                artiest.GetComponent<TextMeshPro> ().text = "Tiësto";
                break;
                case 2:
                materiaal.GetComponent<MeshRenderer> ().material = EDMList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = EDMList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Ones You Miss";
                artiest.GetComponent<TextMeshPro> ().text = "R3HAB";
                break;
                case 3:
                materiaal.GetComponent<MeshRenderer> ().material = EDMList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = EDMList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Places";
                artiest.GetComponent<TextMeshPro> ().text = "Drove & Dillon Dancis";
                break;
                case 4:
                materiaal.GetComponent<MeshRenderer> ().material = EDMList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = EDMList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Lemon Tree";
                artiest.GetComponent<TextMeshPro> ().text = "Alle Farben & Fools Garden";
                break;
                }
            }
            break;
        }
    }
    [SerializeField]
    public void Backward() {
        Min();
                switch(playlist) {
            case "classic": {
                switch(counter) {
                case 0:
                materiaal.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                titel.GetComponent<TextMeshPro> ().text = "The Blue Danube";
                artiest.GetComponent<TextMeshPro> ().text = "Johan Straus II";
                break;
                case 1:
                materiaal.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Canon in D";
                artiest.GetComponent<TextMeshPro> ().text = "Kanon Orchestre de Chambre";
                break;
                case 2:
                materiaal.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Once Upon a December";
                artiest.GetComponent<TextMeshPro> ().text = "Emile Pandolfi";
                break;
                case 3:
                materiaal.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                titel.GetComponent<TextMeshPro> ().text = "The Four Seasons";
                artiest.GetComponent<TextMeshPro> ().text = "Salzburg Chamber Orchestra";
                break;
                case 4:
                materiaal.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = ClassicList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Corpse Bride";
                artiest.GetComponent<TextMeshPro> ().text = "Uriel";
                break;
                }
            }
            break;
            case "indiecrush": {
            switch(counter) {
                case 0:
                materiaal.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Run";
                artiest.GetComponent<TextMeshPro> ().text = "Joji & Diplo";
                break;
                case 1:
                materiaal.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Two queens";
                artiest.GetComponent<TextMeshPro> ().text = "Girl in Red";
                break;
                case 2:
                materiaal.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                titel.GetComponent<TextMeshPro> ().text = "I am used to it";
                artiest.GetComponent<TextMeshPro> ().text = "Powfu";
                break;
                case 3:
                materiaal.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Keep it Gold";
                artiest.GetComponent<TextMeshPro> ().text = "Surfaces";
                break;
                case 4:
                materiaal.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = IndieCrushList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Distance";
                artiest.GetComponent<TextMeshPro> ().text = "Ruel";
                break;
            }
            break;
            }
            case "edm": {
                switch(counter) {
                case 0:
                materiaal.GetComponent<MeshRenderer> ().material = EDMList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = EDMList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Slow Lane";
                artiest.GetComponent<TextMeshPro> ().text = "Armin van Buuren";
                break;
                case 1:
                materiaal.GetComponent<MeshRenderer> ().material = EDMList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = EDMList[counter];
                titel.GetComponent<TextMeshPro> ().text = "The Business";
                artiest.GetComponent<TextMeshPro> ().text = "Tiësto";
                break;
                case 2:
                materiaal.GetComponent<MeshRenderer> ().material = EDMList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = EDMList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Ones You Miss";
                artiest.GetComponent<TextMeshPro> ().text = "R3HAB";
                break;
                case 3:
                materiaal.GetComponent<MeshRenderer> ().material = EDMList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = EDMList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Places";
                artiest.GetComponent<TextMeshPro> ().text = "Drove & Dillon Dancis";
                break;
                case 4:
                materiaal.GetComponent<MeshRenderer> ().material = EDMList[counter];
                afbeelding.GetComponent<MeshRenderer> ().material = EDMList[counter];
                titel.GetComponent<TextMeshPro> ().text = "Lemon Tree";
                artiest.GetComponent<TextMeshPro> ().text = "Alle Farben & Fools Garden";
                break;
                }
            }
            break;
        }
    }
}
