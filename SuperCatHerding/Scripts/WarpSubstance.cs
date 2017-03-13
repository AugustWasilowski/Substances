using UnityEngine;
using System.Collections;

public class WarpSubstance : MonoBehaviour
{
    public Renderer rend;
    public float cycleTime = 10;
    public string floatRangeProperty = "Warp_Intensity";
	void Start ()
    {
        rend = GetComponent<Renderer>();
	}
	

	void Update ()
    {
        ProceduralMaterial substance = rend.sharedMaterial as ProceduralMaterial;

        if (substance)
        {
            float lerp = Mathf.PingPong(Time.time * 2 / cycleTime, 1);
            substance.SetProceduralFloat("Warp_Intensity", lerp);
            substance.RebuildTextures();
            
        }
	}
}
