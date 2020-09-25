﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCManager : MonoBehaviour {
    // Start is called before the first frame update
    //public List<Transform> houses =  new List<Transform>(GameObject.Find("Houses").GetComponentsInChildren<Transform>());
    public List<Transform> houses;
    public GameObject PopulationList;
    public int population;
    public GameObject npc;
    //List<NPC> npcList;

    void Start() {
        System.Random rnd = new System.Random();
        //npcList = new List<NPC>(population);
        int housesLength = houses.Capacity;
        for (short i = 0; i < population; i++) {
            //npcList.Add(new NPC(houses[rnd.Next(housesLength)]));
            GameObject newNPCObject = UnityEngine.Object.Instantiate(npc, PopulationList.transform);
            NavMeshAgent navMeshAgent = newNPCObject.GetComponent<NavMeshAgent>();
            Transform house = houses[rnd.Next(housesLength)];
            NavMeshHit hit;
            if (NavMesh.SamplePosition(house.position, out hit, 20f, NavMesh.AllAreas)) {
                Debug.Log(hit.position);
                Debug.Log(hit.distance);
                Debug.Log(hit);
                newNPCObject.transform.position = hit.position;
            }
            NPC newNPC = newNPCObject.AddComponent<NPC>();
            newNPC.house = house;
        }
    }

    // Update is called once per frame
    void Update() {

    }
}

/// int - population
/// function spawn() 