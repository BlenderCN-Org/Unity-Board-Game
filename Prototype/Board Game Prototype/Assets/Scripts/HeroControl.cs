﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControl : MonoBehaviour
{
    public PlayerControl player;
    public Material material;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void setMaterial(Material nuMaterial) {
        gameObject.transform.GetChild(0).GetComponent<MeshRenderer>().material = nuMaterial;
    }
}
