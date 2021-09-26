﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickLightItem : MonoBehaviour
{
    public float _distance;
    
    [SerializeField] private GameObject item;
    [SerializeField] private GameObject actionText;

    public GameObject light;
    // Update is called once per frame
    void Update()
    {
        _distance = PlayerCasting.DistanceFromTarget;

    }

    private void OnMouseOver()
    {
        if (_distance <= 2f)
        {
            actionText.SetActive(true);
            Cursor.visible = true;
        }
        else
        {
            actionText.SetActive(false);
            Cursor.visible = false;
            
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (_distance <= 2f)
            {
                item.SetActive(false);
                light.SetActive(true);
                actionText.SetActive(false);
                Cursor.visible = false;
            }
        }
    }

    private void OnMouseExit()
    {
        actionText.SetActive(false);
        Cursor.visible = false;
    }
}