using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;


public class linkweb : MonoBehaviour
{
	public void Web_A1()
	{
		#if !UNITY_EDITOR
		openWindow("https://wa.me/62811200412");
		#endif
	}


	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}
