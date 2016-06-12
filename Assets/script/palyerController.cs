using UnityEngine;
using System.Collections;

public class palyerController : MonoBehaviour 
{
	public float speed = 10;
	void FixedUpdate()
	{
		//入力をxとzに代入
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis ("Vertical");

		//同一のGameObjectが持つ Rigidbodyコンポーネントを取得

		Rigidbody rigidbody = GetComponent<Rigidbody>();

		//rididbodyのx軸（横）とz軸（奥）に力を加える
		//rigidbody.AddForce(x, 0, z);

		//xとyにspeedを掛ける
		rigidbody.AddForce(x* speed ,0, z* speed);
}
}