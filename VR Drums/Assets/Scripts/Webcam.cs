using UnityEngine;
using System.Collections;

public class Webcam : MonoBehaviour 
{

	public MeshRenderer[] UseWebcamTexture;
	private WebCamTexture webcamTexture;

	// Use this for initialization
	void Start () 
	{
		//WebCamDevice[] devices = WebCamTexture.devices;
		webcamTexture = new WebCamTexture();
		webcamTexture.deviceName = "Logitech HD Webcam C310";
		/*print ("devices: " + devices.Length);
		for(int i=0;i<devices.Length;i++)
		{
			print("devices: "+devices[i].name);
		}


		if (devices.Length > 1)
		{
			webcamTexture.deviceName = devices [1].name;
		}
		else
		{
			webcamTexture.deviceName = devices [0].name;
		}*/

		foreach(MeshRenderer r in UseWebcamTexture)
		{
			r.material.mainTexture = webcamTexture;
		}
		renderer.material.mainTexture = webcamTexture;
		webcamTexture.Play();
	}

	void OnGUI()
	{
		if (webcamTexture.isPlaying)
		{
			if (GUILayout.Button("Pause"))
			{
				webcamTexture.Pause();
			}
			if (GUILayout.Button("Stop"))
			{
				webcamTexture.Stop();
			}
		}
		else
		{
			if (GUILayout.Button("Play"))
			{
				webcamTexture.Play();
			}
		}
	}
}