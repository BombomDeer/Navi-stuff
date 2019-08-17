using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour {

	public NavMeshAgent navi;
	List<Vector3> way = new List<Vector3>();
	int curWay = 0;
	// Use this for initialization
	void Start () 
	{
		navi = GetComponent<NavMeshAgent> ();
		Vector3 way1 = new Vector3 (-2.03f, 0, 5.41f);
		Vector3 way2 = new Vector3 (-0.55f, 0.3f, -0.76f);
		Vector3 way3 = new Vector3 (2.21f,  0, -5.95f);
		Vector3 way4 = new Vector3 (2.21f,	0,  6);
		way.Add (way1);	
		way.Add (way2);	
		way.Add (way3);	
		way.Add (way4);	

		navi.destination = way1;
	}

	void SetWayEndPos()
	{
		for( int i = 0; i < way.Count; i++ )
		{
			if (transform.position.x == way [i].x &&
				transform.position.z == way [i].z) 
			{
				curWay = i + 1;
				if (i + 1 >= way.Count) 
				{
					curWay = 0;
				}
					 
				navi.destination = way [curWay];
				return;
			}
		}
	}
	// Update is called once per frame
	void Update () {
		SetWayEndPos ();
	}
}
