﻿using UnityEngine;
using System.Collections;

//NOTE: Unused. FormWordCloud keeps track of all children itself
// Exporting that could *maybe* make FormWordCloud cleaner, but would mean passing around the list of children more

public class HelicopterParent : MonoBehaviour {
    public Transform helicopter;

    // Use this for initialization
    void Start() {
        //helicopter = transform.parent;
    }

    // Diana keeps taking away my children >:(
    // I love my children, and they should always love me
    // Actually, might be easier attached to the phrase lol
    // Update is called once per frame
    void Update() {
        if(transform.parent != helicopter){
            transform.SetParent(helicopter);
        }
    }
}
