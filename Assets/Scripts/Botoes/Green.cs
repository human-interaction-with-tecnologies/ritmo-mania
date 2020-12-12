﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : ButtonClass
{
    private float x, y, z;
    private float sx, sy, sz;
    private float selectButton;

    public static Green Instance { get; set; } = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
    }


    public float SelectButton
    {
        get => selectButton;
        set => selectButton = value;
    }

    void Start()
    {

        SelectButtons();

        //Debug.Log("GREEN");
        //Debug.Log(transform.position);
        // Debug.Log(transform.localScale);
        // Debug.Log("--------------------");
    }

    private void Update()
    {
        InputRadar();
    }

    public void InputRadar()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            SelectButton = SetConfig.Instance.ButtonNumber;
            SelectButtons();
            //Debug.Log(selectButton);
        }
    }

    public void Load() => SetConfig.Instance.ButtonNumber = 3;

    public void GetSelectButtons() => SelectButtons();

    private void SelectButtons()
    {
        selectButton = SetConfig.Instance.ButtonNumber;

        if (selectButton == 7)
        {
            x = -2.4f;
            y = 1.9f;
            z = 85.8f;
            sx = 60;
            sy = 60;
            sz = 60;
            transform.position = new Vector3(x, y, z);
            transform.localScale = new Vector3(sx, sy, sz);
        }
        else if (selectButton == 6)
        {
            x = 0;
            y = 2.1f;
            z = 85.8f;
            sx = 60;
            sy = 60;
            sz = 60;
            transform.position = new Vector3(x, y, z);
            transform.localScale = new Vector3(sx, sy, sz);
        }
        else if (selectButton == 5)
        {
            x = 0;
            y = 2.1f;
            z = 85.8f;
            sx = 60;
            sy = 60;
            sz = 60;
            transform.position = new Vector3(x, y, z);
            transform.localScale = new Vector3(sx, sy, sz);
        }
        else if (selectButton == 4)
        {
            x = -2.4f;
            y = 0;
            z = 85.8f;
            sx = 60;
            sy = 60;
            sz = 60;
            transform.position = new Vector3(x, y, z);
            transform.localScale = new Vector3(sx, sy, sz);
        }
        else if (selectButton == 3)
        {
            x = 0;
            y = 0f;
            z = 85.8f;
            sx = 71.5f;
            sy = 71.5f;
            sz = 71.5f;
            transform.position = new Vector3(x, y, z);
            transform.localScale = new Vector3(sx, sy, sz);
        }
        else if (selectButton == 2)
        {
            x = 4.2f;
            y = 0f;
            z = 85.8f;
            sx = 85.8f;
            sy = 85.8f;
            sz = 85.8f;
            transform.position = new Vector3(x, y, z);
            transform.localScale = new Vector3(sx, sy, sz);
        }
        else
        {
            x = 20;
            y = 0f;
            z = 85.8f;
            sx = 60;
            sy = 60;
            sz = 60;
            transform.position = new Vector3(x, y, z);
            transform.localScale = new Vector3(sx, sy, sz);
        }
    }

}
