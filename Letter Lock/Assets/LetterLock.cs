using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;
using UnityEngine.Video;

public class LetterLock : MonoBehaviour {

   public KMBombInfo Bomb;
   public KMAudio Audio;

   public VideoPlayer Background;
   public VideoClip clip;
   public MeshRenderer BackRend;

   static int ModuleIdCounter = 1;
   int ModuleId;
   private bool ModuleSolved;

   void Awake () {
      ModuleId = ModuleIdCounter++;
      /*
      foreach (KMSelectable object in keypad) {
          object.OnInteract += delegate () { keypadPress(object); return false; };
      }
      */

      //button.OnInteract += delegate () { buttonPress(); return false; };

   }

   void Start () {
      StartCoroutine(PlayAnim());
      
   }

   IEnumerator PlayAnim () {
      if (!Application.isEditor)
      {
         yield return new WaitUntil(() => VideoLoader.clips != null);
         Background.clip = VideoLoader.clips[0];
      }
      else
         Background.clip = clip;
      BackRend.material.color = Color.white;
      Background.Play();
   }

   void Update () {

   }

#pragma warning disable 414
   private readonly string TwitchHelpMessage = @"Use !{0} to do something.";
#pragma warning restore 414

   IEnumerator ProcessTwitchCommand (string Command) {
      yield return null;
   }

   IEnumerator TwitchHandleForcedSolve () {
      yield return null;
   }
}
