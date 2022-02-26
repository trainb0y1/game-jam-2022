using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable()]
public class LevelColor {
    public Color color;
    public GameObject[] objects;
    public LevelColor nextColor;
}
