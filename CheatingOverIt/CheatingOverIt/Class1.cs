using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;

namespace CheatingOverIt
{
    public class Class1 : MelonMod
    {
        public static Color pissypiss;
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            //MelonLogger.Log("Starting...");
        }
        public override void OnGUI()
        {
            base.OnGUI();
            if (!Input.GetKey(KeyCode.Q)) return; //(!Input.GetKey(KeyCode.Insert))
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            GUI.contentColor = Color.white;
            GUI.backgroundColor = pissypiss; //Color.magenta;
            GUI.Box(new Rect(10, 10, 380, 300), "CheatingOverIt Menu");
            if (GUI.Button(new Rect(20, 40, 160, 30), "TP UP LOL"))
            {
                GameObject bruhh = GameObject.Find("/Player");
                Vector3 Poz = new Vector3(64, 433.68f);//bruhh.transform.position.magnitude;
                bruhh.transform.position = Poz;
            }
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            pissypiss = new((float)Math.Sin(2 * Time.time * 0.5f + 0.5f), (float)Math.Sin((2 * Time.time) + Math.PI * 2.0 / 3.0) * 0.5f + 0.5f, (float)Math.Sin((2 * Time.time) + Math.PI * 4.0 / 3.0) * 0.5f + 0.5f);

        }
    }
}
