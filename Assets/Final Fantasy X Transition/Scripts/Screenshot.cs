using UnityEngine;
using System.Collections;

public class Screenshot : MonoBehaviour {
    
    bool _HasTakennScreenShot;

    private void Start()
    {
        Invoke("TakeSnapShot", 2f);
    }

    void TakeSnapShot()
    {
        if (!_HasTakennScreenShot)
        {
            StartCoroutine(ScreenShot());
            _HasTakennScreenShot = true;
        }
    }

    IEnumerator ScreenShot()
	{
		yield return new WaitForEndOfFrame();
		Texture2D texture = new Texture2D (Screen.width, Screen.height, TextureFormat.ARGB32, false);
		texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		texture.Apply ();

        ShatterController SController = Instantiate(Resources.Load<ShatterController>("Shattered Object"));
        SController.AnimateEvent(texture);
	}
}
