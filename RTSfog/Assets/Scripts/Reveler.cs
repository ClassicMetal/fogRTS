using UnityEngine;

public class Reveler : MonoBehaviour
{
	public int sight;

	private void Start()
	{
        FindObjectOfType<FogOfWar>().AddRevealer(this);
	}
}
