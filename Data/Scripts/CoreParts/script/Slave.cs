using System;
using System.IO;
using Sandbox.ModAPI;
using VRage.Game.Components;
using static Scripts.Structure;
namespace Scripts
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate, int.MaxValue)]
    public class Session : MySessionComponentBase
    {
        public override void LoadData()
        {
            Log.Init($"{ModContext.ModName}Init.log");
            MyAPIGateway.Utilities.RegisterMessageHandler(7772, Handler);
            Init();
            SendModMessage(true);
        }

        protected override void UnloadData()
        {
            Log.Close();
            MyAPIGateway.Utilities.UnregisterMessageHandler(7772, Handler);
            Array.Clear(Storage, 0, Storage.Length);
            Storage = null;
        }

        void Handler(object o)
        {
            if (o == null) SendModMessage(false);
        }

        void SendModMessage(bool sending)
        {
            Log.CleanLine(sending ? "Sending request to core" : "Receiving request from core");
            MyAPIGateway.Utilities.SendModMessage(7771, Storage);
        }

        internal byte[] Storage;

        internal void Init()
        {
            BaseDefinition[] baseDefs;
            Parts.GetBaseDefinitions(out baseDefs);
            Log.CleanLine($"Found: {baseDefs.Length} part definitions");
            for (int i = 0; i < baseDefs.Length; i++)
            {
                var baseDef = baseDefs[i];
                var partDef = baseDef as PartDefinition;

                if (partDef != null) 
                    partDef.ModPath = ModContext.ModPath;

            }
            Storage = MyAPIGateway.Utilities.SerializeToBinary(baseDefs);
            Log.CleanLine($"Handing over control to Core and going to sleep");
        }

        public class Log
        {
            private static Log _instance = null;
            internal TextWriter File = null;

            public static void Init(string name)
            {
                _instance = new Log {File = MyAPIGateway.Utilities.WriteFileInLocalStorage(name, typeof(Log))};
            }

            public static void CleanLine(string text)
            {
                _instance.File.WriteLine(text);
                _instance.File.Flush();
            }

            public static void Close()
            {
                if (_instance?.File == null) return;
                _instance.File.Flush();
                _instance.File.Close();
                _instance.File.Dispose();
                _instance.File = null;
                _instance = null;
            }
        }
    }
}

