using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;

public class CloudSave : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);//do not destroy

    }
        void Start()
    {
        SignIn();
    }
    async void SignIn()
    {
        await UnityServices.InitializeAsync();
        await AuthenticationService.Instance.SignInAnonymouslyAsync();
    }

    async void SaveData()
    {
        var data = new Dictionary<string, object>
        {
            {"HighScore", 1 }
        };
        await CloudSaveService.Instance.Data.ForceSaveAsync(data);
        Debug.Log("Saved the game");
    }

   async void LoadData()
    {
        var KeysToLoad = new HashSet<string>
        {
            "HighScore"
        };

        var loadedData = await CloudSaveService.Instance.Data.LoadAsync(KeysToLoad);
        var loadedScore = loadedData["HighScore"];
        Debug.Log("loaded Data. score:"+ loadedScore);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveData();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadData();
        }
    }
}
