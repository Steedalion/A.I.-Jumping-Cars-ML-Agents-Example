using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate : MonoBehaviour
{
	public int xduplicates = 2;
	public float xdistance = 120;
	public int zduplicates = 2;
	public float zdistance = 120;
	public GameObject original;
	
    // Start is called before the first frame update
	void Awake()
	{

		for(int i =0; i<xduplicates; i++)
		{
			float xtranslate = (1+i) * xdistance;
			for(int j =0; j<zduplicates; j++)
			{
				float ztranslate = (1+j)*zdistance;
				GameObject duplicate = Instantiate(original);
				duplicate.transform.Translate(xtranslate,0,ztranslate);
			}
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
