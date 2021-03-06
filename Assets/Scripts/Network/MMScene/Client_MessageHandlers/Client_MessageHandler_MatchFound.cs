﻿
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

internal class Client_MessageHandler_MatchFound
{
    private Client client;

    public Client_MessageHandler_MatchFound(Client client)
    {
        this.client = client;
    }

    internal void Handle(Message_Updates_MatchFound data)
    {
        Debug.Log("Recieved Message_Updates_MatchFound");
        //client.KillConnection();
        AppConfig.GetPersistentData().ip = data.ip;
        AppConfig.GetPersistentData().port = data.port;
        SceneManager.LoadScene(AppConfig.InGameSceneName);
    }
}