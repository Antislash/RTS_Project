using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour {

    public MouvementManager mm;

    public LayerMask walkable;
    public LayerMask player;

    Camera cam;
    NavMeshAgent agent;

    public bool isSelected;

    //public GameObject selectedObject;

	// Use this for initialization
	void Start () {
        cam = Camera.main;
        mm = FindObjectOfType<MouvementManager>();
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isSelected)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if(Physics.Raycast(ray, out hit, 100,walkable))
                {
                    mm.requestPath(hit.point);
                }
            }
        }
	}

    void Select()
    {
        isSelected = true;
        mm.numberOfUnitSelected++;
        mm.addMe(agent);
    }

    void UnSelect()
    {
        isSelected = false;
        mm.numberOfUnitSelected--;
        mm.removeMe(agent);
    }

    private void OnMouseDown()
    {
        if (isSelected)
        {
            UnSelect();
        }
        else if(mm.numberOfUnitSelected < mm.maxUnitToSelect  && !isSelected)
        {
            Select();
        }
    }
}
