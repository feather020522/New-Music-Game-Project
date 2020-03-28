﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class SongData{
    public string SongName;
    public string Author;
    public Sprite SongImage;
    public AudioClip BGM;
    public int BPM;
}
[System.Serializable]
public class SongPreview : SongData
{
    public int SongID;
    public List<StageData> Diff = new List<StageData>();
}
[System.Serializable]
public class StageData:SongData
{
    public float offset;
    public List<Note> N = new List<Note>();
    public List<Hold> H = new List<Hold>();
}
