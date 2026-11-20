using UnityEngine;

namespace ReplayToPassAndPlay;

public class ReplayButton : MonoBehaviour
{
    public ReplayButton(IntPtr ptr) : base(ptr) { }

    private void OnGUI()
    {
        ClientBase client;
        try
        {
            client = GameManager.Client;
            if (client == null || !client.IsRecap) return;
        }
        catch
        {
            return;
        }

        if (GUI.Button(new Rect(20, 20, 220, 40), "Skip recap"))
        {
            client.SkipRecap();
        }
    }
}
