﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NaviCharacter : MonoBehaviour
{
    NavMeshAgent navi;
    Vector3 vEnd = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        navi = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray, out hitInfo, 100))
            {
                vEnd = hitInfo.point;
                navi.destination = vEnd;
            }
        }
    }
}
