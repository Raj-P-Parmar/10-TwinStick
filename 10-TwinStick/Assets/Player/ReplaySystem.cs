using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaySystem : MonoBehaviour {

	private const int bufferFrameSize = 100;
	private KeyFrame[] keyFrames = new KeyFrame[bufferFrameSize];
	private Rigidbody rigidBody;
	private GameManager manager;

	private void Start()
	{
		rigidBody = GetComponent<Rigidbody>();
		manager = GameManager.FindObjectOfType<GameManager>();
	}


	private void Update()
	{
        if (manager.recording)
        {
			Record();
        }
        else
        {
			PlayBack();
        }
	}

	private void Record()
    {
		rigidBody.isKinematic = false;
		int frame = Time.frameCount % bufferFrameSize;
		float time = Time.time;
		keyFrames[frame] = new KeyFrame(time, transform.position, transform.rotation);
	}

	private void PlayBack()
    {
		rigidBody.isKinematic = true;
		int frame = Time.frameCount % bufferFrameSize;
		transform.position = keyFrames[frame].position;
		transform.rotation = keyFrames[frame].rotation;
	}
}

public struct KeyFrame
{
	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;

	public KeyFrame(float aTime, Vector3 aPosition, Quaternion aRotation)
	{
		frameTime = aTime;
		position = aPosition;
		rotation = aRotation;
	}
}
