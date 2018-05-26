using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MouvementManager : MonoBehaviour {

    public int numberOfUnitSelected;
    public int maxUnitToSelect = 6;

    public List<NavMeshAgent> agents = new List<NavMeshAgent>();
    //public List<Controller> ctrls = new List<Controller>();


    public void addMe(NavMeshAgent agent)
    {
        agents.Add(agent);
    }

    public void removeMe(NavMeshAgent agent)
    {
        agents.Remove(agent);
    }

    public void removeAll()
    {
        agents.Clear();
        numberOfUnitSelected = -1;
    }

    public void requestPath(Vector3 target)
    {
        if (numberOfUnitSelected == 5)
        {
            agents[0].SetDestination(target + new Vector3(0, 0, 0));
            agents[1].SetDestination(target + new Vector3(1, 0, 0));
            agents[2].SetDestination(target + new Vector3(-1, 0, 0));
            agents[3].SetDestination(target + new Vector3(0, 0, -1));
            agents[4].SetDestination(target + new Vector3(1, 0, -1));
            agents[5].SetDestination(target + new Vector3(-1, 0, -1));
        }
        if (numberOfUnitSelected == 4)
        {
            agents[0].SetDestination(target + new Vector3(0, 0, 0));
            agents[1].SetDestination(target + new Vector3(1, 0, 0));
            agents[2].SetDestination(target + new Vector3(-1, 0, 0));
            agents[3].SetDestination(target + new Vector3(0.5f, 0, -1));
            agents[4].SetDestination(target + new Vector3(-0.5f, 0, -1));
        }
        if (numberOfUnitSelected == 3)
        {
            agents[0].SetDestination(target + new Vector3(0.5f, 0, 0));
            agents[1].SetDestination(target + new Vector3(0.5f, 0, 0));
            agents[2].SetDestination(target + new Vector3(-0.5f, 0, 0));
            agents[3].SetDestination(target + new Vector3(0.5f, 0, -1));
        }
        if (numberOfUnitSelected == 2)
        {
            agents[0].SetDestination(target + new Vector3(0, 0, 0));
            agents[1].SetDestination(target + new Vector3(1, 0, 0));
            agents[2].SetDestination(target + new Vector3(-1, 0, 0));
        }
        if (numberOfUnitSelected == 1)
        {
            agents[0].SetDestination(target + new Vector3(0.5f, 0, 0));
            agents[1].SetDestination(target + new Vector3(-0.5f, 0, 0));
        }
        if (numberOfUnitSelected == 0)
        {
            agents[0].SetDestination(target + new Vector3(0, 0, 0));
        }
    }
}
